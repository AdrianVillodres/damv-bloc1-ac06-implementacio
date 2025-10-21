using System;
namespace AverageThreeNumbers
{
    public class AverageThreeNumbers
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input three real numbers.


            const string MSG_INPUT1 = "Enter the first number: ";
            const string MSG_INPUT2 = "Enter the second number: ";
            const string MSG_INPUT3 = "Enter the third number: ";
            const string MSG_RESULT = "The average is: ";

            float num1;
            float num2;
            float num3;
            float average;

            Console.Write(MSG_INPUT1);
            num1 = float.Parse(Console.ReadLine());
            Console.Write(MSG_INPUT2);
            num2 = float.Parse(Console.ReadLine());
            Console.Write(MSG_INPUT3);
            num3 = float.Parse(Console.ReadLine());
            average = (num1 + num2 + num3) / 3;
            Console.WriteLine(MSG_RESULT + average);


            // POSTCONDITION: 'average' contains the arithmetic mean of the three numbers, and it is displayed.

        }
    }
}