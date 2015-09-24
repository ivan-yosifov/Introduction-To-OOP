/* Create an enumeration named Month that holds values for the months of the year, starting with JANUARY equal to 1. Prompt the user for a month integer. Convert the user’s entry to a Month value and display it. 
 * Save the fi le as MonthNames.cs
 */
using System;

namespace MonthNames
{
    class MonthNames
    {
        enum Month
        {
            JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }
        static void Main(string[] args)
        {
            int monthNumber;

            Console.Write("Enter a month integer (1-12): ");
            monthNumber = Convert.ToInt32(Console.ReadLine());

            Month month = (Month)monthNumber;
            Console.WriteLine("You picked: {0}", month);
        }
    }
}
