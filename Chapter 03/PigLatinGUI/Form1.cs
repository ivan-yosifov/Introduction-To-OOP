using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string word = wordTextBox.Text;
            string pigLatinWord = word.Substring(1) + word.Substring(0, 1) + "ay";

            outputLabel.Text = String.Format("{0} in Pig Latin is {1}", word, pigLatinWord);
        }
    }
}
