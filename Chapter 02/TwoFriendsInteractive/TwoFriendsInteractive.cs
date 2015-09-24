using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFriendsInteractive
{
    class TwoFriendsInteractive
    {
        static void Main(string[] args)
        {
            string name1, name2;
            Console.Write("Enter first name: ");
            name1 = Console.ReadLine();
            Console.Write("Enter second name: ");
            name2 = Console.ReadLine();

            Console.WriteLine(String.Compare(name1, name2)); 
        }
    }
}
