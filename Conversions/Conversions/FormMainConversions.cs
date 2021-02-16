using Calculator;
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
    public partial class FormMainConversions : Form
    {
        string dir = @"..\Files\";
        public FormMainConversions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MessageBox.Show("Folder created" + dir);
            }
            else
            {
                MessageBox.Show("Folder Exist: " + dir);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMoney formMoney = new FormMoney();
            formMoney.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTemperature formTemperature = new FormTemperature();
            formTemperature.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCalcOprn formCalcOprn = new FormCalcOprn();
            formCalcOprn.ShowDialog();
        }

        private void lotto_max_Click(object sender, EventArgs e)
        {
            FormLottoMax formLottoMax = new FormLottoMax();
            formLottoMax.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormIPv4 formIPv4 = new FormIPv4();
            formIPv4.Show();
        }

        private void lotto_649_Click(object sender, EventArgs e)
        {
            FormLotto649 formLotto649 = new FormLotto649();
            formLotto649.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
