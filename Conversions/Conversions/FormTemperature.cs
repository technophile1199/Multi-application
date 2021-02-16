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
    public partial class FormTemperature : Form
    {
        public FormTemperature()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "C";
            label2.Text = "F";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //read file
            string filePath = dir + "convert_temperature.txt"; // .\Test\Names.txt
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
                MessageBox.Show(textToPrint, "Read File");
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

        private void FormTemperature_Load(object sender, EventArgs e)
        {
            btn_Convert.Focus();
        }
        string dir = @"..\Files\";
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String date1 = (aDate.ToString("yyyy-MM-dd  HH:mm:ss"));
            Double tempc = 0;
            tempc = (Convert.ToDouble(textBox1.Text) * 1.8) + 32;
            textBox2.Text = tempc.ToString();

            string filepath = dir + "convert_temperature.txt";
            FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            
            if (radioButton1.Checked)
            {
                textOut.Write("\n" + textBox1.Text + " " + label3.Text + " = " + tempc + " " + label2.Text + "    " + date1);
                textOut.Close();
                if (textBox1.Text == "100" && textBox2.Text == "212")
                {
                    richTextBox2.Text = "Water Boils !!";
                }

                else if (textBox1.Text == "40" && textBox2.Text == "104")
                {
                    richTextBox2.Text = "Hot Bath";
                }

                else if (textBox1.Text == "37" && textBox2.Text == "98.6")
                {
                    richTextBox2.Text = "Body Temperature";
                }

                else if (textBox1.Text == "30" && textBox2.Text == "86")
                {
                    richTextBox2.Text = "Beach Weather";
                }

                else if (textBox1.Text == "21" && textBox2.Text == "70")
                {
                    richTextBox2.Text = "Room Temperature";
                }

                else if (textBox1.Text == "10" && textBox2.Text == "50")
                {
                    richTextBox2.Text = "Cool Day";
                }

                else if (textBox1.Text == "0" && textBox2.Text == "32")
                {
                    richTextBox2.Text = "Freezing point of water";
                }

                else if (textBox1.Text == "-18" && textBox2.Text == "0")
                {
                    richTextBox2.Text = "Very Cold Day";
                }

                else if (textBox1.Text == "-40" && textBox2.Text == "-40")
                {
                    richTextBox2.Text = "Extremely Cold Day \n ( and the same number! )";

                }
                else
                {
                    richTextBox2.Text = "";
                }
            }

            if (radioButton2.Checked)
            {
                double tempf = 0;
                tempf = (Convert.ToDouble(textBox1.Text) - 32) * 5/9;
                textBox2.Text = tempf.ToString();

                textOut.Write("\n" + textBox1.Text + " " + label3.Text + " = " + tempc + " " + label2.Text + "    " + date1);
                textOut.Close();
                if (textBox2.Text == "100" && textBox1.Text == "212")
                {
                    richTextBox2.Text = "Water Boils !!";
                }

                else if (textBox2.Text == "40" && textBox1.Text == "104")
                {
                    richTextBox2.Text = "Hot Bath";
                }

                else if (textBox2.Text == "37" && textBox1.Text == "98.6")
                {
                    richTextBox2.Text = "Body Temperature";
                }

                else if (textBox2.Text == "30" && textBox1.Text == "86")
                {
                    richTextBox2.Text = "Beach Weather";
                }

                else if (textBox2.Text == "21" && textBox1.Text == "70")
                {
                    richTextBox2.Text = "Room Temperature";
                }

                else if (textBox2.Text == "10" && textBox1.Text == "50")
                {
                    richTextBox2.Text = "Cool Day";
                }

                else if (textBox2.Text == "0" && textBox1.Text == "32")
                {
                    richTextBox2.Text = "Freezing point of water";
                }

                else if (textBox2.Text == "-18" && textBox1.Text == "0")
                {
                    richTextBox2.Text = "Very Cold Day";
                }

                else if (textBox2.Text == "-40" && textBox1.Text == "-40")
                {
                    richTextBox2.Text = "Extremely Cold Day \n ( and the same number! )";

                }
                else
                {
                    richTextBox2.Text = "";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "F";
            //label3.Font.Bold = true;
            label2.Text = "C";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to quit Degree Conversion ?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
