using System.Collections.Generic;

namespace MgmUtils.PlacesModels
{
    public class Places
    {
        public Places()
        {
            Cities = new List<City>();
            Districts = new List<District>();
        }
        public List<City> Cities { get; set; }
        public List<District> Districts { get; set; }
    }
}
