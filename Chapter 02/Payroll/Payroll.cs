/* Write a program that prompts the user for a name, Social Security number, hourly pay rate, and number of hours worked. In an attractive format (similar to Figure 2-23), display all the input data as well as the following:

 •  Gross pay, defined as hourly pay rate times hours worked
 •  Federal withholding tax, defined as 15% of the gross pay
 • State withholding tax, defined as 5% of the gross pay
 • Net pay, defined as gross pay minus taxes
 * Save the program as Payroll.cs
 */
using System;

namespace Payroll
{
    class Payroll
    {
        static void Main(string[] args)
        {
            string name, ssn;
            double payRate, grossPay, federalWithholdingTax, stateWithholdingTax, netPay;
            int hoursWorked;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Social Security number: ");
            ssn = Console.ReadLine();
            Console.Write("Hourly pay rate: ");
            payRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked: ");
            hoursWorked = Convert.ToInt32(Console.ReadLine());

            grossPay = hoursWorked * payRate;
            federalWithholdingTax = grossPay * 0.15;
            stateWithholdingTax = grossPay * 0.05;
            netPay = grossPay - (federalWithholdingTax + stateWithholdingTax);

            Console.WriteLine();
            Console.WriteLine("Payroll Summary for: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
            Console.WriteLine("You worked {0} hours at {0} per hour", 
                hoursWorked, payRate.ToString("C2"));
            
            Console.WriteLine();
            Console.WriteLine("Gross pay:          {0, 10}", grossPay.ToString("C"));
            Console.WriteLine("Federal whitholding:{0, 10}", federalWithholdingTax.ToString("C"));
            Console.WriteLine("State withholding:  {0, 10}", stateWithholdingTax.ToString("C"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Net pay:            {0, 10}", netPay.ToString("C"));

        }
    }
}
