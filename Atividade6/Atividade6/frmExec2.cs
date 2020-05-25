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
    public partial class frmExec2 : Form
    {
        public frmExec2()
        {
            InitializeComponent();
        }

        private void btnNumH_Click(object sender, EventArgs e)
        {
            int N;
            string numero = txtN.Text;
            int.TryParse(numero, out N);

            int i;
            double H = 0;

            for (i=1; i<-N; i++)
            {
                H = H + (1 / (double)i);
            }

            txtH.Text = H.ToString("N4");

        }
    }
}
