// <copyright file="WeatherForecaster.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using WebService.Data;

    /// <summary>
    /// WeatherForecaster class to demonstrate backend access to SQL db via EF.
    /// </summary>
    public class WeatherForecaster : IWeatherForecaster
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching",
        };

        private static WebServiceDBContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecaster"/> class.
        /// </summary>
        /// <param name="context">DBContext.</param>
        public WeatherForecaster(WebServiceDBContext context)
        {
            _dbContext = context;
        }

        /// <summary>
        /// Static version of retrieving weather summaries.
        /// </summary>
        /// <returns>Array of weather summaries.</returns>
        public WeatherForecast[] WeatherSummaires()
        {
            var rng = new Random();
            var weather = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
            })
            .ToArray();

            return weather;
        }

        /// <summary>
        /// An async version of retrieving static weather summaries.
        /// </summary>
        /// <returns>Array of weather summaries.</returns>
        public Task<WeatherForecast[]> WeatherSummairesAsync()
        {
            return Task<WeatherForecast[]>.Run(() => this.WeatherSummaires());
        }

        /// <summary>
        /// Database version of retrieving weather summaries.
        /// </summary>
        /// <returns>List of weather summaries.</returns>
        public async Task<List<WeatherForecast>> WeatherSummariesFromDatabase()
        {
            return await _dbContext.WeatherForecasts.ToListAsync();
        }
    }
}
