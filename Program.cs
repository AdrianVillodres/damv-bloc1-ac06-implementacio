using System;
using System.Security.Cryptography;
namespace EuroToDollar
{
    public class EuroToDollar
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input an amount in euros.

            const float EXCHANGE_RATE = 1.12f;
            const string MSG_INPUT = "Enter amount in euros: ";
            const string MSG_RESULT = "Amount in dollars: ";

            float euros;
            float dollars;

            Console.Write(MSG_INPUT);
            euros = float.Parse(Console.ReadLine());
            dollars = euros * EXCHANGE_RATE;
            Console.WriteLine(MSG_RESULT + dollars);

            // POSTCONDITION: 'dollars' contains the converted amount, and it is displayed.

        }
    }
}