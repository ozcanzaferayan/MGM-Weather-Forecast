namespace MgmWeatherForecast.Models
{
    public class Forecast
    {
        public Forecast()
        {
            this.LocationInfo = new LocationInfo();
            this.CurrentForecast = new ForecastCurrent();
            this.FiveDayForecast = new ForecastForFiveDays();
        }
        public LocationInfo LocationInfo { get; set; }
        public ForecastCurrent CurrentForecast { get; set; }
        public ForecastForFiveDays FiveDayForecast { get; set; }
    }
}
