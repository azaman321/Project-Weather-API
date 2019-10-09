using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Weather_Latest.Data_Handling
{
   public class WeatherLatestDTO
    {
        public LatestWeatherRoot LatestWeatherRoot { get; set; }
        public void DeserializeLatestWeather(String LatestWeatherResponse)
        {
            LatestWeatherRoot = JsonConvert.DeserializeObject<LatestWeatherRoot>(LatestWeatherResponse);
        }
    }

   
}
