using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace OpenWeather
{
    public static class WeatherConfig
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly string ApiUrlMod = ConfigurationManager.AppSettings["api_ct"];
    }
}
