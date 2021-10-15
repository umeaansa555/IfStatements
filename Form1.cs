using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfStatements
{
    public partial class Form1 : Form
    {
        int number;

        public Form1()
        {
            InitializeComponent();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(inputBox.Text);
            if (number > 0)
                outputLabel.Text = $"{number} is a positive number.";
            else if(number == 0)
            {
                outputLabel.Text = $"{number} is a neutral integer.";
            }
            else
            {
                outputLabel.Text = $"{number} is a negative number.";
            }

            if (number == 0)
            {
                sevenLabel.Text = $"{number} divided by 7 is {number}.";
            }
            else if(number % 7 == 0)
            {
                sevenLabel.Text = $"{number} is evenly divisible by 7.";
            }
            
            else
            {
                sevenLabel.Text = $"{number} is not evenly divisible by 7.";
            }

        }
    }
}
