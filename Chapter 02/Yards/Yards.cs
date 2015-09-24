/* Write a program that declares variables to represent the length and width of a room in feet and the price of carpeting per square yard in dollars and cents. Assign the value 25 to the length variable and the value 42 to the width variable. Compute and display the cost of carpeting the room. (Hint:  There are nine square feet in one square yard.) 
 * Save the program as Yards.cs
 */
using System;

namespace Yards
{
    class Yards
    {
        static void Main(string[] args)
        {
            const double FEET_PER_YARD = 9;
            int length = 25;
            int width = 42;
            double areaInFeet = length * width;
            double areaInYards = areaInFeet / FEET_PER_YARD;
            double pricePerSquareYard = 10;
            double totalPrice = pricePerSquareYard * areaInYards;

            Console.WriteLine("Room dimensions: {0} x {1}", length, width);
            Console.WriteLine("Total area in yards: {0}", areaInYards.ToString("F2"));
            Console.WriteLine("Total cost of carpeting: {0}", totalPrice.ToString("C"));
        }
    }
}
