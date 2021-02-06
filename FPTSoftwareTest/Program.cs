using NPH.Services.Implementation;
using NPH.Services.Interface;
using System;
using System.Configuration;

namespace FPTSoftwareTest
{
    class Program
    {
        private const string SerivceUrl = "http://api.weatherstack.com/current?access_key=610acf4c1d203448cd6f671955c5e8aa&query=";
        static void Main(string[] args)
        {
            Console.Write("Enter your zip code: ");
            var zipCode = -1;
            while (!int.TryParse(Console.ReadLine(), out zipCode))
            {
                Console.WriteLine("Please enter the valid zip code: ");
            }
            Console.WriteLine($"Your Zip Code is {zipCode}");

            IWeatherStack _weatherStack = new WeatherStack();
            var result = _weatherStack.GetWeatherInformation(SerivceUrl, zipCode);
            IWeatherAnalysis _weatherAnalysis = new WeatherAnalysis();
            var canGoOutSide = _weatherAnalysis.GoOuside(result) ? "Yes" : "No";
            var needWearSunscreen = _weatherAnalysis.WearSunscreen(result) ? "Yes" : "No";
            var canFlyKite = _weatherAnalysis.FlyKite(result) ? "Yes" : "No";
            Console.WriteLine($"Should I go outside? {canGoOutSide}");
            Console.WriteLine($"Should I wear sunscreen? {needWearSunscreen}");
            Console.WriteLine($"Can I fly my kite? {canFlyKite}");

            Console.ReadLine();
        }
    }
}
