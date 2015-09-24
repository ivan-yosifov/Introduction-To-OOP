/* Write a program for the Magic Blender Company. The program prompts the user for a name, street address, city, state, zip code, and quantity of blenders ordered at $39.95 each. In an attractive format (similar to Figure 2-24), display all the input data as well as the following:
 
 • Amount due before tax, defined as number ordered times price each
 • Sales tax, defined as 7% of the amount due
 • Net due, defined as amount due before tax, plus tax

 * Save the program as OrderReceipt.cs
 */
using System;

namespace OrderReceipt
{
    class OrderReceipt
    {
        static void Main(string[] args)
        {
            const double PRICE_PER_BLENDER = 39.95;
            const double SALES_TAX = 0.07;
            string name, address, city, state;
            int zipCode, blenders;
            double totalPrice, tax, due;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Street address: ");
            address = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip code: ");
            zipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many blenders do you want to order? ");
            blenders = Convert.ToInt32(Console.ReadLine());

            totalPrice = blenders * PRICE_PER_BLENDER;
            tax = totalPrice * SALES_TAX;
            due = totalPrice + tax;

            Console.WriteLine();
            Console.WriteLine("Receipt for: ");
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine("{0}, {1} {2}", city, state, zipCode);

            Console.WriteLine();
            Console.WriteLine("{0} blenders ordered at {1} each", 
                blenders, PRICE_PER_BLENDER.ToString("C"));

            Console.WriteLine();
            Console.WriteLine("Total:   {0, 10}", totalPrice.ToString("C"));
            Console.WriteLine("Tax:     {0, 10}", tax.ToString("C"));
            Console.WriteLine("-----------------------");
            Console.WriteLine("Due:     {0, 10}", due.ToString("C"));
                
        }
    }
}
