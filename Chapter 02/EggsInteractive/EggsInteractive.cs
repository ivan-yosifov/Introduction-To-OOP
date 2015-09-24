/* Modify the Eggs program in Exercise 10 so it prompts the user for and accepts a number of eggs for each chicken. 
 * Save the program as EggsInteractive.cs
 */
using System;

namespace EggsInteractive
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            const int EGGS_PER_DOZEN = 12;
            int chicken1, chicken2, chicken3, chicken4;

            Console.Write("Enter monthly number of eggs for first chicken: ");
            chicken1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter monthly number of eggs for second chicken: ");
            chicken2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter monthly number of eggs for third chicken: ");
            chicken3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter monthly number of eggs for fourth chicken: ");
            chicken4 = Convert.ToInt32(Console.ReadLine());

            int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
            int dozen = totalEggs / EGGS_PER_DOZEN;
            int eggs = totalEggs % EGGS_PER_DOZEN;

            Console.WriteLine("Total eggs: {0} ({1} dozen and {2} eggs)",
                totalEggs, dozen, eggs);
        }
    }
}
