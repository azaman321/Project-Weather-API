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
        public void lonDataType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lon);
          //  Assert.AreEqual(53.35", WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

        [Test()]
        public void lonDataValue()
        {
            
              Assert.AreEqual(-6.26, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lon);
        }



        [Test()]
        public void latDataType()
        {
            Assert.IsNotInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

        [Test()]
        public void latDataValue()
        {

            Assert.AreEqual(53.35, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

      

        [Test()]
        public void idDataType()
        {
            Assert.IsInstanceOf<int>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].id);
        }

        [Test()]
        public void mainstringLength()
        {
            Assert.IsTrue( WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].main.Length>0);
        }

       

        [Test()]
        public void mainType()
        {
            Assert.IsInstanceOf<string>( WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].main);

        }

        [Test()]
        public void descriptionstringLength()
        {
            Assert.IsTrue( (WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].description.Length)>0);
        }



    

        [Test()]
        public void descriptionType()
        {
            Assert.IsInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].description);

        }

        [Test()]
        public void iconstringLength()
        {
            Assert.IsTrue((WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].icon.Length) > 0);
        }





        [Test()]
        public void iconType()
        {
            Assert.IsInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].icon);

        }




        [Test()]
        public void ContentTypeTest()
        {
            CM.GetLatestWeather();
            Assert.That(CM.iresponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

    }
}
