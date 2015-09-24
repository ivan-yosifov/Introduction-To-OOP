/* Write a GUI program that accepts the names of two of your friends. Display the result of using the String.Compare() method with your friends’ names. 
 * Save the project as TwoFriendsInteractiveGUI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFriendsInteractiveGUI
{
    static class TwoFriendsInteractiveGUI
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
