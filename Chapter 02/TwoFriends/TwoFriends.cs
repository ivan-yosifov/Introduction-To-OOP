/* Write a program that declares two variables to hold the names of two of your friends, and assign a value to each variable. Display the result of using the String.Compare() method with your friends’ names. 
 * Save the program as TwoFriends.cs
 */
using System;

namespace TwoFriends
{
    class TwoFriends
    {
        static void Main(string[] args)
        {
            string name1 = "Joe";
            string name2 = "Megan";

            Console.WriteLine(String.Compare(name1, name2)); // -1
            Console.WriteLine(String.Compare(name2, name1)); // 1
        }
    }
}
