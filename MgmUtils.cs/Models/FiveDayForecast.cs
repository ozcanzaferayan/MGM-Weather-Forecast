using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs.Models
{
    class FiveDayForecast
    {
        public FiveDayForecast()
        {
            this.Forecasts = new ForecastForDay[5];
        }
        public ForecastForDay[] Forecasts { get; set; }
    }
}
