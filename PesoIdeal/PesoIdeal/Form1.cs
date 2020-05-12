using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            {
                double altura, pesoatual;
                double DIPesoIdeal;
                if (double.TryParse(msktxtbxAltura.Text, out altura) && double.TryParse(msktxtbxPeso.Text
                    , out pesoatual))
                {
                    if (rdobtnFem.Checked == true)
                    {
                        DIPesoIdeal = (62.1 * altura) - 44.7;
                    }
                    else
                    {
                        DIPesoIdeal = (72.7 * altura) - 58;
                    }
                    DIPesoIdeal = Math.Round(DIPesoIdeal, 2);

                    if (pesoatual == DIPesoIdeal)
                    {
                        MessageBox.Show("Está no peso ideal!");
                    }
                    else if (pesoatual > DIPesoIdeal)
                    {
                        MessageBox.Show("Faça um regime");
                    }
                    else
                    {
                        MessageBox.Show("Pode comer mais!");
                    }
                }
                else
                {
                    MessageBox.Show("Dados inválidos");
                }
            }
        }
    }
}
    

