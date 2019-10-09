using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenWeather.Weather_Latest.Data_Handling;


namespace OpenWeather.Weather_Latest.HTTP_Manager
{
   public class WeatherLatestSystem
    {
        public WeatherLatestDTO weatherLatestDTO = new WeatherLatestDTO();

        public WeatherLatestCallManager callManager = new WeatherLatestCallManager();

        public JObject LatestWeatherJson;
        public WeatherLatestSystem()
        {
            weatherLatestDTO.DeserializeLatestWeather(callManager.GetLatestWeather());
        }
    }
}
