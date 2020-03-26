using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Clear();
            txtC.Text = null;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxC_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txtBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            double a, b, c, x;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) &&
                double.TryParse(txtC.Text, out c) & a > 0 & b > 0 & c > 0) {
               
                if (b > a && b > c)
                {
                    x = a;
                    a = b;
                    b = x;
                }
                if (c > b && c > a)
                {
                    x = a;
                    a = c;
                    c = x;
                }

            if (a >= b + c)
                MessageBox.Show("Não forma triângulo");

            else if (a == b && b == c)
                MessageBox.Show("Triângulo Equilátero");

            else if (a != b && b != c)
            MessageBox.Show("Triângulo Escaleno");

            else if (a == b || b == c || c == a)
            MessageBox.Show("Triângulo Isósceles");


            else
                MessageBox.Show("Dados Inválidos");

            

            
        }
    }
}
