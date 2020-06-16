using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace P0030481921038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            string valor = "";


            valor = Interaction.InputBox("Insira seu último número do RA", "Insira os dados");
            if (!int.TryParse(valor, out n))
                MessageBox.Show("Número não válido!");
            if (n > 9 || n < 0)
                MessageBox.Show("Número não válido! Insira um número entre 0 e 9.");
            else if (n == 0)
                n = 10;
            else
            {
                double[,] tabVend = new double[n, 8];
                string valTab = "";

                for (int i = 0; i < n; i++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        valTab = Interaction.InputBox("Insira o valor das vendas do mês " + (i + 1) + ", semana " + (x + 1), "Insira os dados");
                        if (!double.TryParse(valTab, out tabVend[i, x]))
                        {
                            MessageBox.Show("Número não válido!");
                            x--;
                        }
                    }
                }
                double totSem, totMes, totGeral, acumulador = 0, acumuladorMes = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        totSem = tabVend[i, x];
                        lbLista.Items.Add("Total do mês " + (i + 1) + " Semana " + (x + 1) + ": " + totSem.ToString("C2"));
                        acumulador += totSem;
                    }
                    totMes = acumulador;
                    lbLista.Items.Add(">> Total Mês: " + totMes.ToString("C2"));
                    lbLista.Items.Add("-----------------------");
                    acumulador = 0;
                    acumuladorMes += totMes;
                }
                totGeral = acumuladorMes;
                lbLista.Items.Add("Total Geral: " + totGeral.ToString("C2"));
            }

        }
    }
}
        
    

