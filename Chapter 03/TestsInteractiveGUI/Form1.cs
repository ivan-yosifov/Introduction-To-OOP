using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int firstTestScore = Convert.ToInt32(firstTestScoreTextBox.Text);
            int secondTestScore = Convert.ToInt32(secondTestScoreTextBox.Text);
            int thirdTestScore = Convert.ToInt32(thirdTestScoreTextBox.Text);
            int fourthTestScore = Convert.ToInt32(fourthTestScoreTextBox.Text);
            int fifthTestScore = Convert.ToInt32(fifthTestScoreTextBox.Text);

            int total = firstTestScore + secondTestScore + thirdTestScore + fourthTestScore + fifthTestScore;

            double average = total / 5.0;

            outputLabel.Text = String.Format("The average is {0}", average.ToString("F2"));
        }
    }
}
