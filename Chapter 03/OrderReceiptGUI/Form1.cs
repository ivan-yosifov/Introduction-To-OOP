using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderReceiptGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateReceiptButton_Click(object sender, EventArgs e)
        {
            const double SALES_TAX = 0.07;
            const double PRICE_PER_BLENDER = 39.95;

            double amountDue, netDue, tax;

            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            int zipCode = Convert.ToInt32(zipCodeTextBox.Text);
            int blenders = Convert.ToInt32(blenderQuantityTextBox.Text);

            amountDue = blenders * PRICE_PER_BLENDER;
            tax = amountDue * SALES_TAX;
            netDue = amountDue + tax;

            outputLabel.Text = String.Format("Receipt for\n");
            outputLabel.Text += String.Format("{0}\n", name);
            outputLabel.Text += String.Format("{0}\n", address);
            outputLabel.Text += String.Format("{0}, {1} {2}\n\n", city, state, zipCode);
            outputLabel.Text += String.Format("{0} blenders ordered at {1} each\n\n", blenders, PRICE_PER_BLENDER.ToString("C"));
            outputLabel.Text += String.Format("Total:   {0,10}\n", amountDue.ToString("C"));
            outputLabel.Text += String.Format("Tax:     {0,10}\n", tax.ToString("C"));
            outputLabel.Text += String.Format("-----------------------------\n");
            outputLabel.Text += String.Format("Due:     {0,10}\n", netDue.ToString("C"));
        }
    }
}
