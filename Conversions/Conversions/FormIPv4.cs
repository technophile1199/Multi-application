using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Conversions
{
    public partial class FormIPv4 : Form
    {
        public FormIPv4()
        {
            InitializeComponent();
        }

        private void FormIPv4_Load(object sender, EventArgs e)
        {
            label1.Text = "Today : " + DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit ??", "IPv4", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            { 
                this.Close();
            }
            else
            {
                MessageBox.Show("Enjoy networking !!!","Exit",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_Valid_Click(object sender, EventArgs e)
        {
            Regex ip = new Regex(@"^([1-2])([0-9]{2})\.([0-9]{3})\.([0-9]{3})\.([0-9]{3})$");
            if(ip.IsMatch(textBox1.Text) == true)
            {
                MessageBox.Show(textBox1.Text+"\n The IP is correct !!","Valid IP");
            }
            else
            {
                MessageBox.Show(textBox1.Text + "\n The IP must have 4 bytes \n integer must be between 0 to 255\n seperated by a dot(255.255.255.255)", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to reset ?","Reset",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            { 
                textBox1.Text = "";
            }
            else
            {

            }
        }
    }
}
