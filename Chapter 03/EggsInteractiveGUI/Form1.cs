using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int EGGS_PER_DOZEN = 12;

            int firstChickenEggs = Convert.ToInt32(firstChickenTextBox.Text);
            int secondChickenEggs = Convert.ToInt32(secondChickenTextBox.Text);
            int thirdChickenEggs = Convert.ToInt32(thirdChickenTextBox.Text);
            int fourthChickenEggs = Convert.ToInt32(fourthChickenTextBox.Text);
            int fifthChickenEggs = Convert.ToInt32(fifthChickenTextBox.Text);

            int totalEggs = firstChickenEggs + secondChickenEggs + thirdChickenEggs + fourthChickenEggs + fifthChickenEggs;

            int dozen = totalEggs / EGGS_PER_DOZEN;
            int leftOver = totalEggs % EGGS_PER_DOZEN;

            outputLabel.Text = String.Format("{0} eggs is {1} dozen with {2} left over", totalEggs, dozen, leftOver);
        }
    }
}
