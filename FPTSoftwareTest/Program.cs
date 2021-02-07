using NPH.Services.Implementation;
using NPH.Services.Interface;
using System;

namespace FPTSoftwareTest
{
    class Program
    {
        private const string SerivceUrl = "http://api.weatherstack.com/current?access_key=610acf4c1d203448cd6f671955c5e8aa&query=";
        static void Main(string[] args)
        {
            var zipCode = GetZipCode();
            if(zipCode == 0)
            {
                Console.WriteLine("Exiting");
                return;
            }
            IWeatherStack _weatherStack = new WeatherStack();
            var result = _weatherStack.GetWeatherInformation(SerivceUrl, zipCode);
            while (!result.Success)
            {
                Console.WriteLine(result.Error.Info);
                Console.WriteLine("Please try again (or enter 0 to exit): ");
                zipCode = GetZipCode();
                if(zipCode == 0)
                {
                    return;
                }
            }

            IWeatherAnalysis _weatherAnalysis = new WeatherAnalysis();
            var canGoOutSide = _weatherAnalysis.GoOuside(result) ? "Yes" : "No";
            var needWearSunscreen = _weatherAnalysis.WearSunscreen(result) ? "Yes" : "No";
            var canFlyKite = _weatherAnalysis.FlyKite(result) ? "Yes" : "No";
            Console.WriteLine($"Should I go outside? {canGoOutSide}");
            Console.WriteLine($"Should I wear sunscreen? {needWearSunscreen}");
            Console.WriteLine($"Can I fly my kite? {canFlyKite}");

            Console.ReadLine();
        }

        private static int GetZipCode()
        {
            Console.Write("Enter your zip code: ");
            var zipCode = 0;
            while (!int.TryParse(Console.ReadLine(), out zipCode))
            {
                Console.Write("Please enter the valid zip code: ");
            }
            return zipCode;
        }
    }
}
