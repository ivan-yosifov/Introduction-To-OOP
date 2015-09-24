/* Write a GUI program that prompts the user for a name, Social Security number, hourly pay rate, and number of hours worked. In an attractive format, display all the input data as well as the following:
 
 • Gross pay, defined as hourly pay rate times hours worked
 • Federal withholding tax, defined as 15% of the gross pay
 • State withholding tax, defined as 5% of the gross pay
 • Net pay, defined as gross pay minus taxes
 
 * Save the project as PayrollGUI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    static class PayrollGUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
