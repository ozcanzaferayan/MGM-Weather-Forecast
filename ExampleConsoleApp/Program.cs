using MgmWeatherForecast;
using MgmWeatherForecast.Models;
using MgmWeatherForecast.PlacesModels;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        public static WeatherRequest client = new WeatherRequest();

        static void Main(string[] args)
        {
            Forecast forecast = WeatherRequest.GetForecastAsync("ISTANBUL").Result;
            Places places = WeatherRequest.GetPlacesAsync("ISTANBUL").Result;
            string forecastString = JsonConvert.SerializeObject(forecast);
            string placesString = JsonConvert.SerializeObject(places);
            File.WriteAllText("Forecast.txt", forecastString);
            File.WriteAllText("Places.txt", placesString);
            Process.Start("Forecast.txt");
            Process.Start("Places.txt");
        }
    }
}
