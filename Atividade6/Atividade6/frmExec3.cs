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
    public partial class frmExec3 : Form
    {
        public frmExec3()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;
            string inversa = "";

            string FraseM = frase.ToUpper();
            string FraseF = FraseM.Replace(" ", "");

            char[] arr = FraseF.ToCharArray();
            Array.Reverse(arr);
            foreach (char c in arr)
            {
                inversa = inversa + c.ToString();
            }

            txtPalindromo.Text = inversa;

            if (FraseF == inversa)
                MessageBox.Show("Sim!");
            else
                MessageBox.Show("Não!");

        }
    }
}
