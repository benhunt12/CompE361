using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            float originalFahrenheit, calculatedCelsius, calculatedFahrenheit; //variables to hold values
            Console.Write("Please enter a temperature in Fahrenheit : ");
            originalFahrenheit = float.Parse(Console.ReadLine()); //read in the user Fahrenheit value
            calculatedCelsius = ((originalFahrenheit - 32) / 9) * 5; //convert to Celsius
            calculatedFahrenheit = ((calculatedCelsius * 9) / 5) + 32; //convert back to Fahrenheit
            Console.WriteLine("{0:F2} degrees Fahrenheit is {1:F2} degrees Celsius", originalFahrenheit, calculatedCelsius); //print the output
            Console.WriteLine("{0:F2} degrees Celsius is {1:F2} degrees Fahrenheit", calculatedCelsius, calculatedFahrenheit);
            Console.ReadKey();
        }
    }
}
