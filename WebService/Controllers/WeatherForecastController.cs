using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Data;
using WebService.Services;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecaster _weatherService;

        public WeatherForecastController(IWeatherForecaster weatherService, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> Get()
        {
            _logger.LogInformation($"Begin GET/weatherforecast @ {DateTime.Now}");

            // Retrieve a locally generated random set of data
            //var summaries = await _weatherService.WeatherSummairesAsync();

            // Retrieve a static set of data from SQL
            var summaries = await _weatherService.WeatherSummariesFromDatabase();

            _logger.LogInformation($"End GET/weatherforecast @ {DateTime.Now}");

            return Ok(summaries);
        }
    }
}
