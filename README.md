# Project-Weather-API
Project Title:
 Project-Weather-API Testing


# Motivation:
A project to improve my skills in testing and to practice. The aim was to write and run tests on the content returned by the OpenWeather API and to validate its content. All tests were based on the weather forecast for London


# Classes:


## LatestWeatherModel
Defines the data types that each data point received from the response will be converted to.

## WeatherLatestDTO- 
Contains a method for deserializing Json Object. Deserialization is used to read the data and to construct the object again

## WeatherLatestCallManager-
Creates a new REST client to make requests to the API and return the response that is deserialized by the DTO.

To create the request, data is retrieved from the OpenWeatherMapConfig class which reads from the app settings in the App.config file

## WeatherLatestSystem
The service class is an overarching class that creates instances of the data handling and http manager classes acting as an entry point for access.

The service will call the DeserializeForecast method in the DTO in order to deserialize the JSON response received from the CallManager


# Technology/Framework Used: 
.NET Framework

# Technology Used : 
**C#** - C# is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.

**NUnit and Test Adapter** - NUnit is a unit-testing framework for all .Net languages with a strong TDD focus and NUnit 3 adapter for running tests in Visual Studio.

**Newtonsoft.Json** - Json .Net is a popular high-performance JSON framework for .NET

**RestSharp** - Simple REST and HTTP API Client



# Installation:
1. Download the project code, preferably using git clone.
2. In Visual Studio, select File | Open... and point to the **OpenWeathers.sln** file.
3. Rebuild the project
4. Click on **View -> Solution Explorer** or press **Ctrl+Alt+L** to view the Solution Explorer
5. Right click on the **'OpenWeathers'** Project file in the Solution Explorer and click **'Manage NuGet Packages..."**
6. Update NuGet packages/Check that all the packages are installed and updated (see NuGet Packages below)
7. Click on **Test -> Windows -> Test Explorer** to view the test window
8. Click on the green **Run All** button to execute all tests or **Run** button to execute selected tests in the Test Explorer


# API Reference:
OpenWeathers API
http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=a62d884fa6942acfc726dc06978f9564






