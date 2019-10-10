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

    public class Weathers
    {

        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }


    }

    public class Mains
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        

    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class Clouds
    {
        public double all { get; set; }
    }
        public class LatestWeatherRoot
    {
        
        public LatestWeatherModel coord { get; set; }
        public IList<Weathers> weather { get; set; }

        public Mains main { get; set; }
        public double visibility { get; set; }
        public string dt { get; set; }
        public Wind wind { get; set; }
    }
        
}
