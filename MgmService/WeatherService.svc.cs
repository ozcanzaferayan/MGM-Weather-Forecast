using MgmUtils.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using MgmUtils.PlacesModels;
using MgmUtils;

namespace MgmService
{
    public class WeatherService : IWeatherService
    {
        public async Task<Forecast> GetWeatherForecastAsync(string placeNameHref)
        {
            return await WeatherRequest.GetForecast(placeNameHref);
        }

        public async Task<Places> GetPlacesAsync(string placeNameHref)
        {
            return await WeatherRequest.GetPlaces(placeNameHref);
        }
    }
}
