using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03Program01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;

            //input step
            //check first input

            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }

            //check second input

            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }

            // Process Step

            answer = operand1 / operand2;

            // Display Step

            txtResult.Text = operand1.ToString() + " divided by " +
                             operand2.ToString() + " equals " + answer.ToString();
            txtResult.Visible = true;
        }


        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
