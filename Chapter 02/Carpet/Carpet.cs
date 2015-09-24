/* Write a C# program that declares variables to represent the length and width of a room in feet and the price of carpeting per square foot in dollars and cents. Assign appropriate values to the variables. Compute and display, with explanatory text, the cost of carpeting the room. 
 * Save the program as Carpet.cs
 */
using System;

namespace Carpet
{
    class Carpet
    {
        static void Main(string[] args)
        {
            int length = 35;
            int width = 17;
            double area = length * width;
            double pricePerSquareFoot = 10;
            double cost = pricePerSquareFoot * area;

            Console.WriteLine("Room dimensions: {0} x {1}", length, width);
            Console.WriteLine("Total area in feet: {0}", area.ToString("F2"));
            Console.WriteLine("Total cost of carpeting: {0}", cost.ToString("C"));
        }
    }
}
