namespace MgmUtils.Models
{
    public class ForecastForDay
    {
        public ForecastForDay()
        {
            Daily = new ForecastDaily();
            History = new ForecastDailyHistory();
        }
        public string Date { get; set; }
        public ForecastDaily Daily { get; set; }
        public ForecastDailyHistory History { get; set; }
    }
}
