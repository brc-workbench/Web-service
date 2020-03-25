// <copyright file="WeatherForecastController.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using WebService.Data;
    using WebService.Services;

    /// <summary>
    /// API for WeatherForecast.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecaster _weatherService;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastController"/> class.
        /// </summary>
        /// <param name="weatherService">Data access service.</param>
        /// <param name="logger">Default logger.</param>
        public WeatherForecastController(IWeatherForecaster weatherService, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        /// <summary>
        /// GET for all weather summaries.
        /// </summary>
        /// <returns>List of summaries.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> Get()
        {
            _logger.LogInformation($"Begin GET/weatherforecast @ {DateTime.Now}");

            // Retrieve a locally generated random set of data
            // var summaries = await _weatherService.WeatherSummairesAsync();

            // Retrieve a static set of data from SQL
            var summaries = await _weatherService.WeatherSummariesFromDatabase();

            _logger.LogInformation($"End GET/weatherforecast @ {DateTime.Now}");

            return Ok(summaries);
        }
    }
}
