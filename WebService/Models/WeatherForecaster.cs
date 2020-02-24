using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.WebService;

namespace WebService.Models
{
    public class WeatherForecaster
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecast[] WeatherSummaires()
        {
            var rng = new Random();
            var weather = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return weather;
        }

        public Task<WeatherForecast[]> WeatherSummairesAsync()
        {
            return Task<WeatherForecast[]>.Run(() => WeatherSummaires());
        }

    }
}
