using MgmWeatherForecast.Models;
using MgmWeatherForecast.PlacesModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MgmWeatherForecast
{
    public class WeatherForecast
    {
        /// <summary>
        /// MGM request url.
        /// </summary>
        private const string MGM_URL_BASE = "http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx";

        /// <summary>
        /// Gets the page asynchronous.
        /// </summary>
        /// <param name="uppercasePlaceName">Name of the place.</param>
        /// <exception cref="System.Net.WebException"></exception>
        private static async Task<string> GetPageAsync(string uppercasePlaceName)
        {
            string url = MGM_URL_BASE + "?m=" + uppercasePlaceName;
            WebRequest req = WebRequest.Create(url);
            WebResponse response = await req.GetResponseAsync();
            var responseString = "";
            using (var stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            return responseString;
        }

        /// <summary>
        /// Gets the forecast asynchronous.
        /// </summary>
        /// <param name="place">City or district such as ISTANBUL or ZEYTINBURNU</param>
        public static async Task<Forecast> GetForecastAsync(AbstractPlace place)
        {
            var responseString = await GetPageAsync(place.Name);
            return WeatherParser.Parse(ref responseString);
        }

        /// <summary>
        /// Gets the all cities and related districts.
        /// </summary>
        /// <param name="city">The city.</param>
        public static async Task<Places> GetPlacesAsync(City city)
        {
            var responseString = await GetPageAsync(city.Name);
            return PlacesParser.Parse(ref responseString);
        }
    }
}
