using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NPH.Models;
using NPH.Services.Implementation;
using NPH.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace NPH.Services.Tests
{
    [TestClass()]
    public class WeatherAnalysisTests
    {
        [TestInitialize]
        public void Init()
        {

        }

        [TestMethod()]
        public void Can_GoOuside_Test()
         {
            var mock = new Mock<IWeatherStack>();
            var mockWeather = new Mock<WeatherResult>();
            var mockWeatherCurrent = new Mock<WeatherCurrent>();

            mockWeatherCurrent.SetupGet<int>(p => p.WeatherCode).Returns(262);
            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = true;
            var actual = weatherAnalysis.GoOuside(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void Cant_GoOuside_Test()
        {
            var mock = new Mock<IWeatherStack>();
            var mockWeather = new Mock<WeatherResult>();
            var mockWeatherCurrent = new Mock<WeatherCurrent>();

            mockWeatherCurrent.SetupGet<int>(p => p.WeatherCode).Returns(264);
            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = false;
            var actual = weatherAnalysis.GoOuside(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected, "cannot go outside when raining");
        }
    }
}