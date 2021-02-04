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
            Console.ReadLine();
        }
    }
}
