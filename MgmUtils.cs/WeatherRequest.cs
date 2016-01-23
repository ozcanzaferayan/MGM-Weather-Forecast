using MgmUtils.Models;
using MgmUtils.PlacesModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils
{
    public class WeatherRequest
    {
        public const string MGM_URL_BASE = "http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx";

        private static async Task<string> GetPage(string placeName)
        {
            string url = MGM_URL_BASE + "?m=" + placeName;
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

        public static async Task<Forecast> GetForecast(string placeName)
        {
            var responseString = await GetPage(placeName);
            return WeatherParser.Parse(ref responseString);
        }

        public static async Task<Places> GetPlaces(string placeName)
        {
            var responseString = await GetPage(placeName);
            return PlacesParser.Parse(ref responseString, placeName);
        }
    }
}
