using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Weather_Latest.Data_Handling
{
    public class LatestWeatherModel
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class weathers
    {

        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }


    }

    public class mains
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double temtemp_min { get; set; }
        public double temtemp_max { get; set; }

    }
        public class LatestWeatherRoot
    {
        public LatestWeatherModel coord { get; set; }
        public IList<weathers> weather { get; set; }

        public mains main { get; set; }
    }
        
}
