using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calcForm : Form
    {
        public calcForm()
        {
            InitializeComponent();
        }

        private void sfClear_Click(object sender, EventArgs e)
        {
            // If the user clicks, clear text from sfGradLabel
            sfGradLabel.Text = "";
            // If the sfBack button is disabled, enable it
            if (sfBack.Enabled == false || sfEquals.Enabled == false)
            {
                sfBack.Enabled = true;
                sfEquals.Enabled = true;
            }
        }

        private void sfDivide_Click(object sender, EventArgs e)
        {
            // If the user clicks, add the divide symbol to sfGradLabel
            sfGradLabel.Text += "/";
        }

        private void sfTimes_Click(object sender, EventArgs e)
        {
            // If the user clicks, add the multiply symbol to sfGradLabel
            sfGradLabel.Text += "*";
        }

        private void sfMinus_Click(object sender, EventArgs e)
        {
            // If the user clicks, add the minus symbol to sfGradLabel
            sfGradLabel.Text += "-";
        }

        private void sfAdd_Click(object sender, EventArgs e)
        {
            // If the user clicks, add the plus symbol to sfGradLabel
            sfGradLabel.Text += "+";
        }

        private void sfEquals_Click(object sender, EventArgs e)
        {
            if (sfGradLabel.Text != "")
            {
                // Equate the equation in sfGradLabel
                sfGradLabel.Text = new DataTable().Compute(sfGradLabel.Text, null).ToString();
                // Disable the sfBack button
                sfBack.Enabled = false;
                sfEquals.Enabled = false;
                // Add a comma for every thousands place that works with a decimal
                sfGradLabel.Text = string.Format("{0:n}", double.Parse(sfGradLabel.Text));
            }
        }

        private void sfBack_Click(object sender, EventArgs e)
        {
            // If the user clicks, remove the last character from sfGradLabel
            if (sfGradLabel.Text.Length > 0)
            {
                sfGradLabel.Text = sfGradLabel.Text.Remove(sfGradLabel.Text.Length - 1);
            }
        }

        private void sfNum1_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "1";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum2_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "2";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum3_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "3";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum4_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "4";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum5_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "5";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum6_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "6";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum7_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "7";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum8_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "8";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum9_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "9";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfNum0_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += "0";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfDecimal_Click(object sender, EventArgs e)
        {
            if (sfEquals.Enabled == true)
            {
                sfGradLabel.Text += ".";
            }
            else
            {
                MessageBox.Show("Please clear the calculator first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfGradLabel_TextChanged(object sender, EventArgs e)
        {
            // If there is no number before the decimal, add a zero
            if (sfGradLabel.Text.StartsWith("."))
            {
                sfGradLabel.Text = "0" + sfGradLabel.Text;
            }
            // If there is no number before times, divide, minus, or add, add a zero
            if (sfGradLabel.Text.StartsWith("*") || sfGradLabel.Text.StartsWith("/") || sfGradLabel.Text.StartsWith("-") || sfGradLabel.Text.StartsWith("+"))
            {
                // Remove the last character
                sfGradLabel.Text = sfGradLabel.Text.Remove(sfGradLabel.Text.Length - 1);
            }
        }
    }
}
