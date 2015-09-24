/* Write a program that declares four variables to hold the number of eggs produced in a month by each of four chickens, and assign a value to each variable. Sum the eggs, then display the total in dozens and eggs. For example, a total of 127 eggs is 10 dozen and 7 eggs. 
 * Save the program as Eggs.cs
 */
using System;

namespace Eggs
{
    class Eggs
    {
        static void Main(string[] args)
        {
            const int EGGS_PER_DOZEN = 12;
            int chicken1 = 35;
            int chicken2 = 29;
            int chicken3 = 32;
            int chicken4 = 31;

            int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
            int dozen = totalEggs / EGGS_PER_DOZEN;
            int eggs = totalEggs % EGGS_PER_DOZEN;

            Console.WriteLine("Total eggs: {0} ({1} dozen and {2} eggs)",
                totalEggs, dozen, eggs);
        }
    }
}
