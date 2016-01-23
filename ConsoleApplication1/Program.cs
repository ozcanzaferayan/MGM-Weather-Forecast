using ConsoleApplication1.WeatherService;
using MgmUtils.Models;
using MgmUtils.PlacesModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static WeatherServiceClient client = new WeatherServiceClient();

        static void Main(string[] args)
        {
            Forecast forecast = GetWeather().Result;
            Places places = GetPlaces().Result;
            Console.WriteLine(JsonConvert.SerializeObject(forecast));
            Console.WriteLine(JsonConvert.SerializeObject(places));
            Console.Read();
        }

        async static Task<Forecast> GetWeather()
        {
            Forecast forecast = await client.GetWeatherForecastAsync("ISTANBUL");
            return forecast;
        }

        async static Task<Places> GetPlaces()
        {
            Places places = await client.GetPlacesAsync("ISTANBUL");
            return places;
        }
    }
}
