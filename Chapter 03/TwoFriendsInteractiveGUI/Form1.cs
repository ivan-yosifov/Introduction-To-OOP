using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFriendsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string secondName = secondNameTextBox.Text;

            int result = String.Compare(firstName, secondName);
            outputLabel.Text = String.Format("Comparing {0} and {1} results in {2}", firstName, secondName, result);
        }
    }
}
