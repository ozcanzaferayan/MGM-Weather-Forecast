using ExampleConsoleApp.WeatherService;
using MgmUtils.Models;
using MgmUtils.PlacesModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string forecastString = JsonConvert.SerializeObject(forecast);
            string placesString = JsonConvert.SerializeObject(places);
            File.WriteAllText("Forecast.txt", forecastString);
            File.WriteAllText("Places.txt", placesString);
            Process.Start("Forecast.txt");
            Process.Start("Places.txt");
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
