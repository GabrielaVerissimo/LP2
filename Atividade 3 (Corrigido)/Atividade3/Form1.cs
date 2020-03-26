using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumFilhos_Click(object sender, EventArgs e)
        {

        }

        private void lblDados_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            double verify1, verify2, aliquoINSS, aliquoIRPF, salFamilia, salLiq;


            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                MessageBox.Show("Nome em branco!");
            else
                if (double.TryParse(mskbxSalBruto.Text, out verify1) && double.TryParse(mskbxNumFilhos.Text, out verify2))

                if (RbtnF.Checked == true || RbtnM.Checked == true)
                {
                    string nome;
                    nome = txtNomeFunc.Text;


                    if (RbtnF.Checked == true && ckbxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\nque é casada\ne tem {1} fiho(s)", nome, verify2);
                    if (RbtnF.Checked == true && ckbxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\nque é solteira\ne tem {1} filho(s)", nome, verify2);
                    if (RbtnF.Checked == false && ckbxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário do Sr.{0}\nque é solteiro e tem {1} filho(s)", nome, verify2);
                    if (RbtnF.Checked == false && ckbxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário do Sr.{0}\nque é casado \ne tem {1} filho(s)", nome, verify2);

                    if (verify1 <= 800.47)
                    {
                        aliquoINSS = verify1 * (7.65 / 100);
                        mskbxINSS.Text = "7.65%";
                    }
                    else if (verify1 <= 1050)
                    {
                        aliquoINSS = verify1 * (8.65 / 100);
                        mskbxINSS.Text = "8.65%";
                    }
                    else if (verify1 <= 1400.77)
                    {
                        aliquoINSS = verify1 * (9 / 100);
                        mskbxINSS.Text = "9.00%";
                    }
                    else if (verify1 <= 2801.56)
                    {
                        aliquoINSS = verify1 * (11 / 100);
                        mskbxINSS.Text = "11%";
                    }
                    else
                    {
                        aliquoINSS = 308.17;
                        mskbxINSS.Text = "Teto";
                    }

                    mskbxDescINSS.Text = aliquoINSS.ToString("N2");


                    if (verify1 <= 1257.12)
                    {
                        aliquoIRPF = 0;
                        mskbxIRPF.Text = "0";
                    }
                    else if (verify1 <= 2512.18)
                    {
                        aliquoIRPF = verify1 * (15 / 100);
                        mskbxIRPF.Text = "15%";
                    }
                    else
                    {
                        aliquoIRPF = verify1 * (27.5 / 100);
                        mskbxIRPF.Text = "27.5%";
                    }

                    mskbxDescIRPF.Text = aliquoIRPF.ToString("N2");


                    if (verify1 <= 435.52)
                    {
                        salFamilia = verify2 * 22.33;
                    }
                    else if (verify1 <= 654.61)
                        salFamilia = verify2 * 15.74;
                    else
                        salFamilia = 0;


                    mskbxSalFamilia.Text = salFamilia.ToString("N2");

                    salLiq = verify1 - aliquoINSS - aliquoIRPF + salFamilia;
                    mskbxSalLiq.Text = salLiq.ToString("N2");






                }

                else
                    MessageBox.Show("Sexo não selecionado!");

            else
                MessageBox.Show("Dados Inválidos!");
        }

        private void mskbxSalBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
