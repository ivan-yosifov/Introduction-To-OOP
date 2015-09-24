/* Create an enumeration named Month that holds values for the months of the year, starting with JANUARY equal to 1. (Recall that an enumeration must be placed within a class but outside of any method.) Using a GUI interface, prompt the user for a month integer. Convert the user’s entry to a Month value anddisplay it. 
 * Save the project as MonthNamesGUI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    static class MonthNamesGUI
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
