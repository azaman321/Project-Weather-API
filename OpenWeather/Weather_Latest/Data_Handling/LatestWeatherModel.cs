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
        public List<weathers> weather { get; set; }


    }

    public class LatestWeatherRoot
    {
        public LatestWeatherModel coord { get; set; }
    }
        
}
