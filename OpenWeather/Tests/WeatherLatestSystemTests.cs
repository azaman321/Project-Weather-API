using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenWeather.Weather_Latest.HTTP_Manager;
using RestSharp;

namespace OpenWeather.Tests
{
    public class WeatherLatestSystemTests
    {
        private WeatherLatestSystem WeatherLatest = new WeatherLatestSystem();
        
        [Test()]
        public void LonDataType()
        {
            
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lon);
          //  Assert.AreEqual(53.35", WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

        [Test()]
        public void LonDataValue()
        {
            
              Assert.AreEqual(-6.26, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lon);
        }



        [Test()]
        public void LatDataType()
        {
            Assert.IsNotInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

        [Test()]
        public void LatDataValue()
        {

            Assert.AreEqual(53.35, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.coord.lat);
        }

      

        [Test()]
        public void IdDataType()
        {
            Assert.IsInstanceOf<int>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].id);
        }

        [Test()]
        public void MainstringLength()
        {
            Assert.IsTrue( WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].main.Length>0);
        }

       

        [Test()]
        public void MainType()
        {
            Assert.IsInstanceOf<string>( WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].main);

        }

        [Test()]
        public void DescriptionstringLength()
        {
            Assert.IsTrue( (WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].description.Length)>0);
        }



    

        [Test()]
        public void DescriptionType()
        {
            Assert.IsInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].description);

        }

        [Test()]
        public void IconstringLength()
        {
            Assert.IsTrue((WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].icon.Length) > 0);
        }





        [Test()]
        public void IconType()
        {
            Assert.IsInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.weather[0].icon);

        }

        [Test()]
        public void TempValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.temp);
        }





        [Test()]
        public void TempType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.temp);

        }

           [Test()]
        public void PressureValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.pressure);
        }





        [Test()]
        public void PressureType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.pressure);

        }

        [Test()]
        public void HumidityValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.humidity);
        }





        [Test()]
        public void HumidityType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.humidity);

        }

        [Test()]
        public void TempMinValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.temp_min);
        }





        [Test()]
        public void TempMinType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.temp_min);

        }

        [Test()]
        public void TempMaxValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.temp_max);
        }





        [Test()]
        public void TempMaxType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.main.temp_max);

        }

        [Test()]
        public void VisibilityValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.visibility);
        }







        [Test()]
        public void VisibilityType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.visibility);

        }

        [Test()]
        public void SpeedValue()
        {
            Assert.AreNotEqual(null, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.wind.speed);
        }





        [Test()]
        public void SpeedType()
        {
            Assert.IsInstanceOf<double>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.wind.speed);

        }

        [Test()]
        public void BaseString()
        {

            Assert.AreEqual("stations", WeatherLatest.weatherLatestDTO.LatestWeatherRoot.@base);
        }

        [Test()]
        public void BaseLength()
        {

            Assert.AreEqual(8, WeatherLatest.weatherLatestDTO.LatestWeatherRoot.@base.Length);
        }

        [Test()]
        public void BaseType()
        {
            Assert.IsInstanceOf<string>(WeatherLatest.weatherLatestDTO.LatestWeatherRoot.@base);
        }




        [Test()]
        public void ContentTypeTest()
        {
            
            
           
            Assert.That(WeatherLatest.GetHeaders(), Is.EqualTo("OK"));
        }

    }
}
