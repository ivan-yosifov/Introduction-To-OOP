using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            const double FEDERAL_TAX = 0.15;
            const double STATE_TAX = 0.05;

            double grossPay, netPay;
            double federalWithholdingTax, stateWithholdingTax;

            string name = nameTextBox.Text;
            string ssn = ssnTextBox.Text;
            double payRate = Convert.ToDouble(payRateTextBox.Text);
            int hoursWorked = Convert.ToInt32(hoursWorkedTextBox.Text);

            grossPay = payRate * hoursWorked;
            federalWithholdingTax = grossPay * FEDERAL_TAX;
            stateWithholdingTax = grossPay * STATE_TAX;
            netPay = grossPay - (federalWithholdingTax + stateWithholdingTax);

            outputLabel.Text = String.Format("Payroll Summary for: {0}\n", name);
            outputLabel.Text += String.Format("SSN: {0}\n", ssn);
            outputLabel.Text += String.Format("You worked {0} hours at {1} per hour\n\n", hoursWorked, payRate.ToString("C"));
            outputLabel.Text += String.Format("Gross pay:            {0,10}\n", grossPay.ToString("C"));
            outputLabel.Text += String.Format("Federal withholding:  {0,10}\n", federalWithholdingTax.ToString("C"));
            outputLabel.Text += String.Format("State withholding:    {0,10}\n", stateWithholdingTax.ToString("C"));
            outputLabel.Text += String.Format("--------------------------------------\n");
            outputLabel.Text += String.Format("Net pay:              {0,10}\n", netPay.ToString("C"));
        }
    }
}
