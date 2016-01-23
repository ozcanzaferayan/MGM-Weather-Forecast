using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgmUtils.cs.Models
{
    class ForecastDailyHistory
    {
        public ForecastDailyHistory()
        {
            Extremity = new Temperature();
            Average = new Temperature();
        }
        public Temperature Extremity { get; set; }
        public Temperature Average { get; set; }
    }
}
