/* Write a GUI program that allows a user to enter scores for five tests he has taken. Display the average of the test scores to two decimal places.
 * Save the project as TestsInteractiveGUI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    static class TestsInteractiveGUI
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
