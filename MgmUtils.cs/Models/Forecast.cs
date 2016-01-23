using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs.Models
{
    class Forecast
    {
        public Forecast()
        {
            this.LocationInfo = new LocationInfo();
            this.ForecastLastStatus = new ForecastLastStatus();
            this.FiveDayForecast = new FiveDayForecast();
        }
        public LocationInfo LocationInfo { get; set; }
        public ForecastLastStatus ForecastLastStatus { get; set; }
        public FiveDayForecast FiveDayForecast { get; set; }
    }
}
