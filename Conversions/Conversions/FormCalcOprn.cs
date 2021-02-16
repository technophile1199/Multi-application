using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Conversions
{
    public partial class FormCalcOprn : Form
    {
        Calculator123 calculator123 = new Calculator123();
        public FormCalcOprn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to quit Calculator ?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Let's perform Arithmatic operations...","Calculator",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void FormCalcOprn_Load(object sender, EventArgs e)
        {

        }
        double x = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            //temp = Convert.ToDouble(textBox1.Text);
            calculator123.Num1 = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox1.Text);
            lbl_mem.Text = calculator123.Num1 + " " + "+";
            textBox1.Text = "";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            //lbl_mem.Text = "";
            calculator123.Num1 = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox1.Text);
            lbl_mem.Text = calculator123.Num1 + " " + "-";
            textBox1.Text = "";
        }
        private void btn_mul_Click(object sender, EventArgs e)
        {
            //lbl_mem.Text = "";
            calculator123.Num1 = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox1.Text);
            lbl_mem.Text = calculator123.Num1 + " " + "*";
            textBox1.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            //lbl_mem.Text = "";
            calculator123.Num1 = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox1.Text);
            lbl_mem.Text = calculator123.Num1 + " " + "\\";
            textBox1.Text = "";
        }
        string dir = @"..\Files\";
        private void btn_total_Click(object sender, EventArgs e)
        {
            //lbl_mem.Visible = false;
            DateTime aDate = DateTime.Now;
            String date1 = (aDate.ToString("yyyy-MM-dd  HH:mm:ss"));
            string filepath = dir + "calculator.txt";
            FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);

            Regex add = new Regex(@"\+");
            Regex sub = new Regex(@"\-");
            Regex mul = new Regex(@"\*");
            Regex div = new Regex(@"\\");
            double y = 0;
            if (add.IsMatch(lbl_mem.Text) == true)
            {
                calculator123.Num2 = Convert.ToDouble(textBox1.Text);
                 y = Convert.ToDouble(textBox1.Text); 
                textBox1.Text = "";
                
                textBox1.Text = (calculator123.Add().ToString());
                MessageBox.Show("You have entered \nNumber 1: " + Convert.ToString(x) + "\nNumber 2: " + Convert.ToString(y) + "\nYour answer is : " + textBox1.Text);
                
                textOut.Write("\n" + x + " + " + y + "\tAnwer is: " + textBox1.Text);
                textOut.Close();
            }
            else if(sub.IsMatch(lbl_mem.Text) == true)
            {
                calculator123.Num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

                textBox1.Text = (calculator123.Sub().ToString());
                MessageBox.Show("You have entered \nNumber 1: " + Convert.ToString(x) + "\nNumber 2: " + Convert.ToString(y) + "\nYour answer is : " + textBox1.Text);

                textOut.Write("\n" + x + " - " + y + "\tAnwer is: " + textBox1.Text);
                textOut.Close();
            }
            else if(mul.IsMatch(lbl_mem.Text) == true)
            {
                calculator123.Num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

                textBox1.Text = (calculator123.Mul().ToString());
                MessageBox.Show("You have entered \nNumber 1: " + Convert.ToString(x) + "\nNumber 2: " + Convert.ToString(y) + "\nYour answer is : " + textBox1.Text);

                textOut.Write("\n" + x + " * " + y + "\tAnwer is: " + textBox1.Text);
                textOut.Close();
            }
            else if (div.IsMatch(lbl_mem.Text) == true)
            {
                calculator123.Num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

                textBox1.Text = (calculator123.Div().ToString());
                MessageBox.Show("You have entered \nNumber 1: " + Convert.ToString(x) + "\nNumber 2: " + Convert.ToString(y) + "\nYour answer is : " + textBox1.Text);

                textOut.Write("\n" + x + " / " + y + "\tAnwer is: " + textBox1.Text);
                textOut.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid values !!","Error !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            lbl_mem.Text = "";
        }

        
    }
}
