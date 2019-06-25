using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double FirstNum;
        double SecondNum;
        string Operation;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void np_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                SecondNum = Convert.ToDouble(textBox1.Text);                
                Operation = "%";

            }
            else
            {
                textBox1.Text = "0";
            }
            
        }

        private void nOne_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void ntwo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void nNull_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void nthree_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void nfour_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void nfive_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void nsix_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void nseven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void neight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void nnine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }
               
        private void ndot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
                
        private void nplus_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void nminus_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void nmultiply_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "x";
        }

        private void ndivide_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            SecondNum = Convert.ToDouble(textBox1.Text);
            switch(Operation)
            {
                case "+":
                    result = FirstNum + SecondNum;
                    textBox1.Text = Convert.ToString(result);
                    FirstNum = result;
                    break;
                case "-" :
                    result = FirstNum - SecondNum;
                    textBox1.Text = Convert.ToString(result);
                    FirstNum = result;
                    break;
                case "x":
                    result = FirstNum * SecondNum;
                    textBox1.Text = Convert.ToString(result);
                    FirstNum = result;
                    break;
                case "/":
                    if(SecondNum == 0)
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        result = FirstNum / SecondNum;
                        textBox1.Text = Convert.ToString(result);
                        FirstNum = result;
                    }
                    break;
                case "%":
                    result = FirstNum * SecondNum / 100;
                    textBox1.Text = Convert.ToString(result);
                    FirstNum = result;
                    break;
                    
            }

          
        }

        private void nplusMinus_Click(object sender, EventArgs e)
        {
            //    if (textBox1.Text != "0" && textBox1.Text != null && textBox1.Text.StartsWith("-"))
            //    {
            //        textBox1.Text[0].Delete();
            //    }
            //    else if (textBox1.Text != "0" && textBox1.Text != null && textBox1.Text.Contains(!"-"))
            //    {
            //        textBox1.Text[0].pus += "-";
            //    }
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNum = 0;
            SecondNum = 0;
        }

        private void nce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void nsqrt_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(FirstNum);
            textBox1.Text = Convert.ToString(result);
            FirstNum = result;
        }

        private void npowOfTwo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                FirstNum = Convert.ToDouble(textBox1.Text);
                result = Math.Pow(FirstNum, 2);
                textBox1.Text = Convert.ToString(result);
                FirstNum = result;
            }
            else
            {
                textBox1.Text = "0";
            }
            

        }

        private void ndivByOne_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                FirstNum = Convert.ToDouble(textBox1.Text);
                result = 1 / FirstNum;
                textBox1.Text = Convert.ToString(result);
                FirstNum = result;
            }
            else
            {
                textBox1.Text = "0";
            }
        }
    }
}
