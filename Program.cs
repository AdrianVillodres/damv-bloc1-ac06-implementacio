using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
namespace CelsiusToKelvin
{
    public class CelsiusToKelvin
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input a temperature in Celsius.

            const string MSG_INPUT = "Enter temperature in Celsius: ";
            const string MSG_RESULT = "Temperature in Kelvin: ";

            float celsius;
            float kelvin;

            Console.Write(MSG_INPUT);
            celsius = float.Parse(Console.ReadLine());
            kelvin = celsius + 273.15f;
            Console.WriteLine(MSG_RESULT + kelvin);


            // POSTCONDITION: 'kelvin' contains the converted temperature, and it is 
            // displayed.
        }
    }
}
