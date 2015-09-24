/* Write a program that declares five variables to hold scores for five tests you have taken, and assign a value to each variable. Display the average of the test scores to two decimal places.
 * Save the program as Tests.cs
 */
using System;

namespace Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            int test1 = 80;
            int test2 = 56;
            int test3 = 73;
            int test4 = 82;

            double average = (test1 + test2 + test3 + test4) / 4.0;
            Console.WriteLine("Test average: {0}", average.ToString("F2"));
        }
    }
}
