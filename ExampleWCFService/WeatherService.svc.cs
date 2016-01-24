using System.Threading.Tasks;
using MgmWeatherForecast.PlacesModels;
using MgmWeatherForecast;
using MgmWeatherForecast.Models;

namespace SampleWCFService
{
    public class WeatherService : IWeatherService
    {
        public async Task<Forecast> GetWeatherForecastAsync(string placeName)
        {
            return await WeatherForecast.GetForecastAsync(new City(placeName));
        }

        public async Task<Places> GetPlacesAsync(string cityName)
        {
            return await WeatherForecast.GetPlacesAsync(new City(cityName));
        }
    }
}
