using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Conversions
{
    public partial class FormMoney : Form
    {
        public FormMoney()
        {
            InitializeComponent();
        }

        private void FormMoney_Load(object sender, EventArgs e)
        {
            radioButton1.Focus();
            radioButton9.Focus();
            textBox1.Focus();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }


        string dir = @"..\Files\";
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String date1 = (aDate.ToString("yyyy-MM-dd  HH:mm:ss"));
            string filepath = dir + "currency_convert.txt";
            FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            Double total = 0, num = 0;
            if(Convert.ToDouble(textBox1.Text.Length) > 0)
            { 
                num = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Please enter value greater than 0. \nThank you !!!");
            }
            //Convert Button 08 JULY 2020 10:39 PM
            // 1 CAD = 0.59 POUND, 0.65 EURO, 0.74 USD, 55.46 INR LHS
            try
            {
                if (radioButton1.Checked && radioButton7.Checked)//GBP
                {
                    total = (num * 0.59);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n"+num + " " + radioButton1.Text + " = " + total + " " + radioButton7.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton1.Text + " = " + total + " " + radioButton7.Text);
                }

                else if (radioButton1.Checked && radioButton6.Checked) //INR
                {
                    total = (num * 55.46);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton1.Text + " = " + total + " " + radioButton6.Text + " " + date1);
                    textOut.Close();

                    MessageBox.Show(num + " " + radioButton1.Text + " = " + total + " " + radioButton6.Text);
                }

                else if (radioButton1.Checked && radioButton8.Checked) //EUR
                {
                    total = (num * 0.65);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton1.Text + " = " + total + " " + radioButton8.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton1.Text + " = " + total + " " + radioButton8.Text);
                }

                else if (radioButton1.Checked && radioButton9.Checked) //USD
                {
                    total = (num * 0.74);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton1.Text + " = " + total + " " + radioButton9.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton1.Text + " = " + total + " " + radioButton9.Text);
                }

                else if (radioButton1.Checked && radioButton10.Checked) //CAD
                {
                    cad.Visible = true;
                    cad.Visible = true;
                    total = (num * 1);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton1.Text + " = " + total + " " + radioButton10.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton1.Text + " = " + total + " " + radioButton10.Text);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error due to : " + ex.Message);
            }

            //USD LHS
            // 1 USD = 74.94 INR, 0.79 GBP, 0.88 EURO, 1 USD, 1.35 CAD, 74.94 INR
            try
            {
                if (radioButton2.Checked && radioButton6.Checked)//INR
                {
                    total = (num * 74.94);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton2.Text + " = " + total + " " + radioButton6.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton2.Text + " = " + total + " " + radioButton6.Text);
                }

                else if (radioButton2.Checked && radioButton7.Checked)//GBP
                {
                    total = (num * 0.79);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton2.Text + " = " + total + " " + radioButton7.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton2.Text + " = " + total + " " + radioButton7.Text);
                }

                else if (radioButton2.Checked && radioButton8.Checked) //EUR
                {
                    total = (num * 0.88);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton2.Text + " = " + total + " " + radioButton8.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton2.Text + " = " + total + " " + radioButton8.Text);
                }

                else if (radioButton2.Checked && radioButton9.Checked) //USD
                {
                    total = (num * 1);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton2.Text + " = " + total + " " + radioButton9.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton2.Text + " = " + total + " " + radioButton9.Text);
                }

                else if (radioButton2.Checked && radioButton10.Checked) //CAD
                {
                    total = (num * 1.35);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton2.Text + " = " + total + " " + radioButton10.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton2.Text + " = " + total + " " + radioButton10.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to : " + ex.Message);
            }

            //EUR LHS
            // 1 EUR = 85.01 INR, 0.90 GBP, 1 EUR, 1.13 USD, CAD
            try
            {
                if (radioButton3.Checked && radioButton6.Checked)//INR
                {
                    total = (num * 85.01);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton3.Text + " = " + total + " " + radioButton6.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton3.Text + " = " + total + " " + radioButton6.Text);
                }

                else if (radioButton3.Checked && radioButton7.Checked)//GBP
                {
                    total = (num * 0.90);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton3.Text + " = " + total + " " + radioButton7.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton3.Text + " = " + total + " " + radioButton7.Text);
                }

                else if (radioButton3.Checked && radioButton8.Checked) //EUR
                {
                    total = (num * 1);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton3.Text + " = " + total + " " + radioButton8.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton3.Text + " = " + total + " " + radioButton8.Text);
                }

                else if (radioButton3.Checked && radioButton9.Checked) //USD
                {
                    total = (num * 1.13);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton3.Text + " = " + total + " " + radioButton9.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton3.Text + " = " + total + " " + radioButton9.Text);
                }

                else if (radioButton3.Checked && radioButton10.Checked) //CAD
                {
                    total = (num * 1.53);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton3.Text + " = " + total + " " + radioButton10.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton3.Text + " = " + total + " " + radioButton10.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to : " + ex.Message);
            }

            //GBP LHS
            //1 GBP = 94.53 INR, 1 GBP, 1.11 EUR, 1.26 USD, 1.70 CAD
            try
            {
                if (radioButton4.Checked && radioButton6.Checked)//INR
                {
                    total = (num * 94.53);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton4.Text + " = " + total + " " + radioButton6.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton4.Text + " = " + total + " " + radioButton6.Text);
                }

                else if (radioButton4.Checked && radioButton7.Checked)//GBP
                {
                    total = (num * 1);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton4.Text + " = " + total + " " + radioButton7.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton4.Text + " = " + total + " " + radioButton7.Text);
                }

                else if (radioButton4.Checked && radioButton8.Checked) //EUR
                {
                    total = (num * 1.11);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton4.Text + " = " + total + " " + radioButton8.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton4.Text + " = " + total + " " + radioButton8.Text);
                }

                else if (radioButton4.Checked && radioButton9.Checked) //USD
                {
                    total = (num * 1.26);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton4.Text + " = " + total + " " + radioButton9.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton4.Text + " = " + total + " " + radioButton9.Text);
                }

                else if (radioButton4.Checked && radioButton10.Checked) //CAD
                {
                    total = (num * 1.70);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton4.Text + " = " + total + " " + radioButton10.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton4.Text + " = " + total + " " + radioButton10.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to : " + ex.Message);
            }

            //INR LHS
            //1 INR = 1 INR, 0.011 GBP, 0.012 EUR, 0.013 USD, 0.018 CAD
            try
            {
                if (radioButton5.Checked && radioButton6.Checked)//INR
                {
                    total = (num * 1);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton5.Text + " = " + total + " " + radioButton6.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton5.Text + " = " + total + " " + radioButton6.Text);
                }

                else if (radioButton5.Checked && radioButton7.Checked)//GBP
                {
                    total = (num * 0.011);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton5.Text + " = " + total + " " + radioButton8.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton5.Text + " = " + total + " " + radioButton7.Text);
                }

                else if (radioButton5.Checked && radioButton8.Checked) //EUR
                {
                    total = (num * 0.012);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton5.Text + " = " + total + " " + radioButton8.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton5.Text + " = " + total + " " + radioButton8.Text);
                }

                else if (radioButton5.Checked && radioButton9.Checked) //USD
                {
                    total = (num * 0.013);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton5.Text + " = " + total + " " + radioButton9.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton5.Text + " = " + total + " " + radioButton9.Text);
                }

                else if (radioButton5.Checked && radioButton10.Checked) //CAD
                {
                    total = (num * 0.018);
                    textBox2.Text = total.ToString();
                    textOut.Write("\n" + num + " " + radioButton5.Text + " = " + total + " " + radioButton10.Text + " " + date1);
                    textOut.Close();
                    MessageBox.Show(num + " " + radioButton5.Text + " = " + total + " " + radioButton10.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to : " + ex.Message);
            }
            
            //MessageBox.Show(num + " " + radioButton1.Text + " = " + total + " " + radioButton7.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit the application Money Exchange ?", "Exit ?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Let's calculate !!","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DateTime aDate = DateTime.Now;
            //String date1 = (aDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            string filePath = dir + "currency_convert.txt"; // .\Test\Names.txt
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadToEnd();
                    row = row.ToString();
                    textToPrint += row;
                }
                // close the input stream for the text file
                MessageBox.Show(textToPrint,"Read File");
                textIn.Close();
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
    }
}
