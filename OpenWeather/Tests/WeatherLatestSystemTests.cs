using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenWeather.Weather_Latest.HTTP_Manager;
namespace OpenWeather.Tests
{
    public class WeatherLatestSystemTests
    {
        private WeatherLatestSystem WeatherLatest = new WeatherLatestSystem();

        [Test()]
        public void success()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }
    }
}
