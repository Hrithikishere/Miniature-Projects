using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class Calculator : Form
    {
        double result = 0;
        string operations =  "";
        bool enterValue = false;
        char iOperation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbersOnly(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtDisplay.Text == "0" || (enterValue))
            {
                txtDisplay.Text = "";
                enterValue = false;
            }

            if(button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + button.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + button.Text;
            }
        }

        private void basicOperations(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                btnEqual.PerformClick();
                enterValue = true;
                operations = button.Text;
                lblShowOp.Text = Convert.ToString(result) + "  " + operations;
                lblShowOp.Visible = true;
            }
            else
            {

                operations = button.Text;
                if (txtDisplay.Text == "")
                {
                    txtDisplay.Text = "0";
                }
                else
                {
                    result = Double.Parse(txtDisplay.Text);
                    txtDisplay.Text = "";
                    lblShowOp.Text = Convert.ToString(result) + "  " + operations;
                    lblShowOp.Visible = true;
                }
               
            }
        }

        private void btnClearE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                lblShowOp.Text = "";
                lblShowOp.Visible = false;

                switch (operations)
                {

                    case "+":
                        txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "x":
                        txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "/":
                        txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    default:
                        break;
                }

                result = Double.Parse(txtDisplay.Text);
                operations = "";
            }
        }

        private void btnSingleClear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if(txtDisplay.Text == "") 
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnSqaure_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                result = Double.Parse(txtDisplay.Text);
                result = result * result;
                txtDisplay.Text = result.ToString();
            }
        }

        private void btnRootOver_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                result = Double.Parse(txtDisplay.Text);
                result = Math.Sqrt(result);
                txtDisplay.Text = result.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                result = Double.Parse(txtDisplay.Text);
                result = 1 / (result);
                txtDisplay.Text = result.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                result = Double.Parse(txtDisplay.Text);
                result = (result) * -1;
                txtDisplay.Text = result.ToString();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                result = Double.Parse(txtDisplay.Text);
                result = (result) / 100;
                txtDisplay.Text = result.ToString();
            }
        }
    }
}
