/* Write a GUI program for the Magic Blender Company. The program prompts the user for a name, street address, city, state, zip code, and quantity of blenders ordered at $39.95 each. Display all the input data as well as the following:
 • Amount due before tax, defi ned as number ordered times price each
 • Sales tax, defi ned as 7% of the amount due
 • Net due, defi ned as amount due before tax, plus tax
 * Save the project as OrderReceiptGUI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderReceiptGUI
{
    static class OrderReceiptGUI
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
