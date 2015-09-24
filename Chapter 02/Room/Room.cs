/* Write a C# program that declares variables to represent the length and width of a room in feet. Assign appropriate values to the variables, such as length = 15 and width = 25. Compute and display the fl oor space of the room in square feet (area = length * width). As output, do not display only a value; instead, display explanatory text with the value, such as "The floor space is 375 square feet".
 * Save the program as Room.cs.
 */
using System;

namespace Room
{
    class Room
    {
        static void Main(string[] args)
        {
            int length = 15;
            int width = 25;
            double area = length * width;

            Console.WriteLine("The floor space is {0} square feet", area);
        }
    }
}
