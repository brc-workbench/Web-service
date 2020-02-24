using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Models;

namespace Project.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            /*
                [Consumes(MediaTypeNames.Application.Json)]
                [ProducesResponseType(StatusCodes.Status201Created)]
                [ProducesResponseType(StatusCodes.Status400BadRequest)]
             */
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> Get()
        {
            _logger.LogInformation($"Begin GET/weatherforecast @ {DateTime.Now}");
            
            // ToDo - IoC this type
            var forecaster = new WeatherForecaster();
            var summaries = await forecaster.WeatherSummairesAsync();

            _logger.LogInformation($"End GET/weatherforecast @ {DateTime.Now}");

            return Ok(summaries);
        }
    }
}
