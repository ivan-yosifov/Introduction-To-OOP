/* Pig Latin is a nonsense language. To create a word in pig Latin, you remove the first letter and then add the first letter and “ay” at the end of the word. For example, “dog” becomes “ogday” and “cat” becomes “atcay”. Write a GUI program that allows the user to enter a word. Output the pig Latin version.
 * Save the project as PigLatinGUI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    static class PigLatinGUI
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
