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
        private Mock<IWeatherStack> mock;
        private Mock<WeatherResult> mockWeather;
        private Mock<WeatherCurrent> mockWeatherCurrent;

        [TestInitialize]
        public void Init()
        {
            mock = new Mock<IWeatherStack>();
            mockWeather = new Mock<WeatherResult>();
            mockWeatherCurrent = new Mock<WeatherCurrent>();
        }

        [TestMethod()]
        public void Can_GoOuside_Test()
         {
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
            mockWeatherCurrent.SetupGet<int>(p => p.WeatherCode).Returns(264);
            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = false;
            var actual = weatherAnalysis.GoOuside(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected, "cannot go outside when raining");
        }

        [TestMethod()]
        public void GoOuside_Error_Test()
        {
            mockWeather.Setup(p => p.Success).Returns("Error");
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = false;
            var actual = weatherAnalysis.GoOuside(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void Need_WearSunscreen_Test()
        {
            mockWeatherCurrent.SetupGet<float>(p => p.UvIndex).Returns(4);
            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = true;
            var actual = weatherAnalysis.WearSunscreen(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void NoNeed_WearSunscreen_Test()
        {
            mockWeatherCurrent.SetupGet<float>(p => p.UvIndex).Returns(2);
            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = false;
            var actual = weatherAnalysis.WearSunscreen(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void Can_WearSunscreen_Test()
        {
            mockWeatherCurrent.SetupGet<int>(p => p.WeatherCode).Returns(262);
            mockWeatherCurrent.SetupGet<float>(p => p.WindSpeed).Returns(16);

            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = true;
            var actual = weatherAnalysis.FlyKite(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void Cant_WearSunscreen_Raining_Test()
        {
            mockWeatherCurrent.SetupGet<int>(p => p.WeatherCode).Returns(265);
            mockWeatherCurrent.SetupGet<float>(p => p.WindSpeed).Returns(16);

            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = false;
            var actual = weatherAnalysis.FlyKite(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void Cant_WearSunscreen_NoWind_Test()
        {
            mockWeatherCurrent.SetupGet<int>(p => p.WeatherCode).Returns(262);
            mockWeatherCurrent.SetupGet<float>(p => p.WindSpeed).Returns(14);

            mockWeather.SetupGet(p => p.Current).Returns(mockWeatherCurrent.Object);
            mock.Setup(p => p.GetWeatherInformation("", 0)).Returns(mockWeather.Object);

            IWeatherAnalysis weatherAnalysis = new WeatherAnalysis();
            var expected = false;
            var actual = weatherAnalysis.FlyKite(mock.Object.GetWeatherInformation("", 0));
            actual.Should().Be(expected);
        }
    }
}