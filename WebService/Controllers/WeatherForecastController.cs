using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation($"Begin GET/weatherforecast @ {DateTime.Now}");
            
            var forecaster = new WeatherForecaster();

            _logger.LogInformation($"End GET/weatherforecast @ {DateTime.Now}");

            return forecaster.WeatherSummaires();
        }
    }
}
