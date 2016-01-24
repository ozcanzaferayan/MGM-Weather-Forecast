using System.Threading.Tasks;
using MgmWeatherForecast.PlacesModels;
using MgmWeatherForecast;
using MgmWeatherForecast.Models;

namespace MgmService
{
    public class WeatherService : IWeatherService
    {
        public async Task<Forecast> GetWeatherForecastAsync(string placeNameHref)
        {
            return await WeatherRequest.GetForecastAsync(placeNameHref);
        }

        public async Task<Places> GetPlacesAsync(string placeNameHref)
        {
            return await WeatherRequest.GetPlacesAsync(placeNameHref);
        }
    }
}
