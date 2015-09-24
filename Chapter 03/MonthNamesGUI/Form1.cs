using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    public partial class Form1 : Form
    {
        enum Month
        {
            JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int monthNumber = Convert.ToInt32(monthIntegerTextBox.Text);
            Month month = (Month)monthNumber;

            outputLabel.Text = String.Format("{0} is {1}", monthNumber, month);
        }
    }
}
