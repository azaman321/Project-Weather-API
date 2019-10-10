using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using OpenWeather;

namespace OpenWeather.Weather_Latest.HTTP_Manager
{
   public class WeatherLatestCallManager
    {
        public string StatusCode { get; set; }
        
        readonly IRestClient restClient;
        public IRestResponse iresponse;
        public WeatherLatestCallManager()
        {
            restClient = new RestClient(WeatherConfig.BaseUrl);
        }

        public string GetLatestWeather()
        {
            var request = new RestRequest(WeatherConfig.ApiUrlMod + "&" + WeatherConfig.ApiKey);
            var response = restClient.Execute(request, Method.GET);
            iresponse = response;
            StatusCode = response.StatusCode.ToString();
            return response.Content;
        }
    }
}
