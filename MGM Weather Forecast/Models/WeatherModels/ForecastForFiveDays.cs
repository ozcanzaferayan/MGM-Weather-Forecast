namespace MgmWeatherForecast.Models
{
    public class ForecastForFiveDays
    {
        public ForecastForFiveDays()
        {
            this.Forecasts = new ForecastForDay[5];
        }
        public ForecastForDay[] Forecasts { get; set; }
    }
}
