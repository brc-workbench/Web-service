using System.Threading.Tasks;

namespace WebService.Services
{
    public interface IWeatherForecaster
    {
        public WeatherForecast[] WeatherSummaires();
        public Task<WeatherForecast[]> WeatherSummairesAsync();
    }
}
