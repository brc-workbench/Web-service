using System.Threading.Tasks;
using System.Collections.Generic;
using WebService.Data;

namespace WebService.Services
{
    public interface IWeatherForecaster
    {
        public WeatherForecast[] WeatherSummaires();
        public Task<WeatherForecast[]> WeatherSummairesAsync();
        public Task<List<WeatherForecast>> WeatherSummariesFromDatabase();
    }
}
