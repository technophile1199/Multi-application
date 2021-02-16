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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Final Project ");
            btn_open.Focus();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            FormMainConversions formMainConversions = new FormMainConversions();
            formMainConversions.ShowDialog();
        }
        string dir = @"..\Files\";
        private void btn_data_Click(object sender, EventArgs e)
        {
            string filepath = dir + "student_Details.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            // create the output stream for a text file that exists
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(txt_fnm + "|");
            textOut.WriteLine(txt_lnm + " " + txt_ID);
        }
    }
}
