/* Modify the Tests program in Exercise 12 so it accepts five test scores from a user.
 * Save the program as TestsInteractive.cs
 */
using System;

namespace TestsInteractive
{
    class TestsInteractive
    {
        static void Main(string[] args)
        {
            int test1, test2, test3, test4;

            Console.Write("Enter first test score: ");
            test1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second test score: ");
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third test score: ");
            test3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter fourth test score: ");
            test4 = Convert.ToInt32(Console.ReadLine());

            double average = (test1 + test2 + test3 + test4) / 4.0;
            Console.WriteLine("Test average: {0}", average.ToString("F2"));
        }
    }
}
