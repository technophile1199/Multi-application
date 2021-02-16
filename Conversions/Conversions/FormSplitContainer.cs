using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class FormSplitContainer : Form
    {
        public FormSplitContainer()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            FormMainConversions formMainConversions = new FormMainConversions();
            formMainConversions.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
        }
    }
}
