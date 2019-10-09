using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenWeather.Weather_Latest.HTTP_Manager;

namespace OpenWeather.Tests
{
    public class WeatherLatestSystemTests
    {
        private WeatherLatestSystem WeatherLatest = new WeatherLatestSystem();
        public WeatherLatestCallManager CM = new WeatherLatestCallManager();

        [Test()]
        public void success()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lon);
          //  Assert.AreEqual("53.35", WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

        

        [Test()]
        public void ContentTypeTest()
        {
            CM.GetLatestWeather();
            Assert.That(CM.iresponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

    }
}
