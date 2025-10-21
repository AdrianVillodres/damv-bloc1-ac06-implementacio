using System;
namespace RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input the width and height of a rectangle.

            const string MSG_INPUT_WIDTH = "Enter the width of the rectangle: ";
            const string MSG_INPUT_HEIGHT = "Enter the height of the rectangle: ";
            const string MSG_RESULT = "The area of the rectangle is: ";

            float width;
            float height;
            float area;

            Console.Write(MSG_INPUT_WIDTH);
            width = float.Parse(Console.ReadLine());
            Console.Write(MSG_INPUT_HEIGHT);
            height = float.Parse(Console.ReadLine());
            area = width * height;
            Console.WriteLine(MSG_RESULT + area);


            // POSTCONDITION: 'area' contains the product of 'width' and 'height', and it is displayed.
        }
    }
}