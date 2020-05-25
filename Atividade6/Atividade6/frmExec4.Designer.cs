namespace Atividade6
{
    partial class frmExec4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblInscrição = new System.Windows.Forms.Label();
            this.lblProdução = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratif = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtInsc = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtGratif = new System.Windows.Forms.TextBox();
            this.btnSalBruto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(8, 44);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblInscrição
            // 
            this.lblInscrição.AutoSize = true;
            this.lblInscrição.Location = new System.Drawing.Point(8, 84);
            this.lblInscrição.Name = "lblInscrição";
            this.lblInscrição.Size = new System.Drawing.Size(108, 13);
            this.lblInscrição.TabIndex = 2;
            this.lblInscrição.Text = "Número de Inscrição:";
            // 
            // lblProdução
            // 
            this.lblProdução.AutoSize = true;
            this.lblProdução.Location = new System.Drawing.Point(8, 124);
            this.lblProdução.Name = "lblProdução";
            this.lblProdução.Size = new System.Drawing.Size(56, 13);
            this.lblProdução.TabIndex = 3;
            this.lblProdução.Text = "Produção:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(8, 171);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário:";
            // 
            // lblGratif
            // 
            this.lblGratif.AutoSize = true;
            this.lblGratif.Location = new System.Drawing.Point(8, 205);
            this.lblGratif.Name = "lblGratif";
            this.lblGratif.Size = new System.Drawing.Size(67, 13);
            this.lblGratif.TabIndex = 5;
            this.lblGratif.Text = "Gratificação:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(56, 44);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(215, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // txtInsc
            // 
            this.txtInsc.Location = new System.Drawing.Point(119, 81);
            this.txtInsc.Name = "txtInsc";
            this.txtInsc.Size = new System.Drawing.Size(152, 20);
            this.txtInsc.TabIndex = 8;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(66, 124);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(205, 20);
            this.txtProd.TabIndex = 9;
            this.txtProd.TextChanged += new System.EventHandler(this.txtProd_TextChanged);
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(56, 168);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(215, 20);
            this.txtSal.TabIndex = 10;
            // 
            // txtGratif
            // 
            this.txtGratif.Location = new System.Drawing.Point(81, 198);
            this.txtGratif.Name = "txtGratif";
            this.txtGratif.Size = new System.Drawing.Size(190, 20);
            this.txtGratif.TabIndex = 11;
            // 
            // btnSalBruto
            // 
            this.btnSalBruto.Location = new System.Drawing.Point(81, 237);
            this.btnSalBruto.Name = "btnSalBruto";
            this.btnSalBruto.Size = new System.Drawing.Size(110, 57);
            this.btnSalBruto.TabIndex = 12;
            this.btnSalBruto.Text = "Calcular Salário Bruto";
            this.btnSalBruto.UseVisualStyleBackColor = true;
            this.btnSalBruto.Click += new System.EventHandler(this.btnSalBruto_Click);
            // 
            // frmExec4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 319);
            this.Controls.Add(this.btnSalBruto);
            this.Controls.Add(this.txtGratif);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtInsc);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratif);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProdução);
            this.Controls.Add(this.lblInscrição);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExec4";
            this.Text = "frmExec4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblInscrição;
        private System.Windows.Forms.Label lblProdução;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratif;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtInsc;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtGratif;
        private System.Windows.Forms.Button btnSalBruto;
    }
}