// <copyright file="IWeatherForecaster.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebService.Data;

    /// <summary>
    /// Interface for WeatherForcaster.
    /// </summary>
    public interface IWeatherForecaster
    {
        /// <summary>
        /// Static version of retrieving weather summaries.
        /// </summary>
        /// <returns>Array of weather summaries.</returns>
        public WeatherForecast[] WeatherSummaires();

        /// <summary>
        /// An async version of retrieving static weather summaries.
        /// </summary>
        /// <returns>Array of weather summaries.</returns>
        public Task<WeatherForecast[]> WeatherSummairesAsync();

        /// <summary>
        /// Database version of retrieving weather summaries.
        /// </summary>
        /// <returns>List of weather summaries.</returns>
        public Task<List<WeatherForecast>> WeatherSummariesFromDatabase();
    }
}
