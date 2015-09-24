/* Write a program that declares a minutes variable to represent minutes worked on a job, and assign a value to it. Display the value in hours and minutes. For example, 197 minutes becomes 3 hours and 17 minutes.
 * Save the program as HoursAndMinutes.cs
 */

using System;

namespace HoursAndMinutes
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            const int MINUTES_PER_HOUR = 60;
            int totalMinutes = 197;
            int hours = totalMinutes / MINUTES_PER_HOUR;
            int minutes = totalMinutes % MINUTES_PER_HOUR;

            Console.WriteLine("{0} minutes is {1} hours and {2} minutes", 
                totalMinutes, hours, minutes);

        }
    }
}
