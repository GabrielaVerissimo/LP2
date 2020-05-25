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
   public partial class frmExec1 : Form
{
   
        public frmExec1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = rchtxtTexto.Text;
            int brancos = 0;
            for (int i = 0; i < texto.Length; i++) 

            {
                if (Char.IsWhiteSpace(texto[i]))
                    brancos = brancos + 1;
            }

            MessageBox.Show("A quantidade de espaços em branco é: " + brancos);

        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            string textoR = rchtxtTexto.Text;
            int R = 0;

            foreach (char r in textoR)
            {
                if (r == 'R' || r == 'r')
                    R = R + 1;
            }
            MessageBox.Show("A quantidade de R's é: " + R);
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            string texto = rchtxtTexto.Text;
            int pares = 0;
            int i;

            for (i = 0; i < texto.Length - 1; i++)
            {
                if (texto[i] == texto[i + 1])
                    pares = pares + 1;
            }
        }
 
   }     
}
