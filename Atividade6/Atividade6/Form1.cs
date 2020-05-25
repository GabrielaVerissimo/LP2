using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec1_Click(object sender, EventArgs e)
        {
            frmExec1 frm1 = new frmExec1();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void btnExec2_Click(object sender, EventArgs e)
        {
            frmExec2 frm2 = new frmExec2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void btnExec3_Click(object sender, EventArgs e)
        {
            frmExec3 frm3 = new frmExec3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void btnExec4_Click(object sender, EventArgs e)
        {
            frmExec4 frm4 = new frmExec4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }
    }
}
