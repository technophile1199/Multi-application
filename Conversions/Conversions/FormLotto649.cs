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

namespace Conversions
{
    public partial class FormLotto649 : Form
    {
        public FormLotto649()
        {
            InitializeComponent();
        }

        string dir = @"..\Files\";
        private void btn_gen_Click(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String date1 = (aDate.ToString("yyyy-MM-dd  HH:mm:ss"));

            string filepath = dir + "lotto_max.txt";
            FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);

            Random random = new Random();
            int randomNumber = 0;
            try
            {
                if (textBox1.Text == null)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        randomNumber = random.Next(1, 49);
                        textBox1.Text += randomNumber.ToString() + Environment.NewLine;
                    }
                }
                else
                {
                    textBox1.Text = "";
                    for (int i = 0; i < 6; i++)
                    {
                        randomNumber = random.Next(1, 49);
                        textBox1.Text += randomNumber.ToString() + Environment.NewLine;
                    }
                }
                MessageBox.Show(textBox1.Text);
                string x = "";
                for (int i = 0; i <= 5; i++)
                {
                    x += textBox1.Lines[i] + ",";
                }

                x += textBox1.Lines[6] + "Extra ".PadLeft(10) + textBox1.Lines[7];
                MessageBox.Show(x);
                textOut.Write("\n649,".PadRight(10) + date1 + ",".PadRight(10) + x);
                textOut.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to " + ex);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to quit application ?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Let's Continue !!!!","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = dir + "lotto_max.txt"; // .\Test\Names.txt
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
    }
}
