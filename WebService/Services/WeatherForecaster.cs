using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Services
{
    public class WeatherForecaster : IWeatherForecaster
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// TODO:  EF has been added to the prject.  Need to pull data from the DB.
        /// </summary>
        /// <returns></returns>
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
