namespace Atividade3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFunc = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.btnDesc = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskbxINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.GbxSexo = new System.Windows.Forms.GroupBox();
            this.RbtnF = new System.Windows.Forms.RadioButton();
            this.RbtnM = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.GbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunc
            // 
            this.lblFunc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFunc.Location = new System.Drawing.Point(12, 9);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(108, 21);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "Nome do Funcionário";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(126, 6);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(170, 20);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(12, 54);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalBruto.TabIndex = 2;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(12, 100);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumFilhos.TabIndex = 4;
            this.lblNumFilhos.Text = "Número de Filhos";
            this.lblNumFilhos.Click += new System.EventHandler(this.lblNumFilhos_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(126, 140);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(197, 30);
            this.btnDesc.TabIndex = 6;
            this.btnDesc.Text = "Verificar Desconto";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(12, 196);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(41, 13);
            this.lblDados.TabIndex = 7;
            this.lblDados.Text = "Dados:";
            this.lblDados.Click += new System.EventHandler(this.lblDados_Click);
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(11, 327);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(75, 13);
            this.lblINSS.TabIndex = 8;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(12, 359);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblIRPF.TabIndex = 9;
            this.lblIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(12, 391);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalFamilia.TabIndex = 10;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(12, 423);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalLiquido.TabIndex = 11;
            this.lblSalLiquido.Text = "Salário Líquido";
            this.lblSalLiquido.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(359, 327);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 16;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(360, 359);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 17;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(126, 51);
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(170, 20);
            this.mskbxSalBruto.TabIndex = 18;
            this.mskbxSalBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxSalBruto_MaskInputRejected);
            // 
            // mskbxNumFilhos
            // 
            this.mskbxNumFilhos.Location = new System.Drawing.Point(126, 100);
            this.mskbxNumFilhos.Name = "mskbxNumFilhos";
            this.mskbxNumFilhos.Size = new System.Drawing.Size(170, 20);
            this.mskbxNumFilhos.TabIndex = 19;
            // 
            // mskbxINSS
            // 
            this.mskbxINSS.Enabled = false;
            this.mskbxINSS.Location = new System.Drawing.Point(126, 320);
            this.mskbxINSS.Name = "mskbxINSS";
            this.mskbxINSS.Size = new System.Drawing.Size(170, 20);
            this.mskbxINSS.TabIndex = 20;
            // 
            // mskbxIRPF
            // 
            this.mskbxIRPF.Enabled = false;
            this.mskbxIRPF.Location = new System.Drawing.Point(126, 352);
            this.mskbxIRPF.Name = "mskbxIRPF";
            this.mskbxIRPF.Size = new System.Drawing.Size(170, 20);
            this.mskbxIRPF.TabIndex = 21;
            // 
            // mskbxSalFamilia
            // 
            this.mskbxSalFamilia.Enabled = false;
            this.mskbxSalFamilia.Location = new System.Drawing.Point(126, 384);
            this.mskbxSalFamilia.Name = "mskbxSalFamilia";
            this.mskbxSalFamilia.Size = new System.Drawing.Size(170, 20);
            this.mskbxSalFamilia.TabIndex = 22;
            // 
            // mskbxSalLiq
            // 
            this.mskbxSalLiq.Enabled = false;
            this.mskbxSalLiq.Location = new System.Drawing.Point(126, 416);
            this.mskbxSalLiq.Name = "mskbxSalLiq";
            this.mskbxSalLiq.Size = new System.Drawing.Size(170, 20);
            this.mskbxSalLiq.TabIndex = 23;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Location = new System.Drawing.Point(473, 324);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(144, 20);
            this.mskbxDescINSS.TabIndex = 24;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Location = new System.Drawing.Point(473, 359);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(144, 20);
            this.mskbxDescIRPF.TabIndex = 25;
            // 
            // GbxSexo
            // 
            this.GbxSexo.Controls.Add(this.RbtnM);
            this.GbxSexo.Controls.Add(this.RbtnF);
            this.GbxSexo.Location = new System.Drawing.Point(417, 6);
            this.GbxSexo.Name = "GbxSexo";
            this.GbxSexo.Size = new System.Drawing.Size(127, 100);
            this.GbxSexo.TabIndex = 26;
            this.GbxSexo.TabStop = false;
            this.GbxSexo.Text = "Sexo";
            // 
            // RbtnF
            // 
            this.RbtnF.AutoSize = true;
            this.RbtnF.Location = new System.Drawing.Point(46, 19);
            this.RbtnF.Name = "RbtnF";
            this.RbtnF.Size = new System.Drawing.Size(31, 17);
            this.RbtnF.TabIndex = 0;
            this.RbtnF.TabStop = true;
            this.RbtnF.Text = "F";
            this.RbtnF.UseVisualStyleBackColor = true;
            // 
            // RbtnM
            // 
            this.RbtnM.AutoSize = true;
            this.RbtnM.Location = new System.Drawing.Point(46, 59);
            this.RbtnM.Name = "RbtnM";
            this.RbtnM.Size = new System.Drawing.Size(34, 17);
            this.RbtnM.TabIndex = 1;
            this.RbtnM.TabStop = true;
            this.RbtnM.Text = "M";
            this.RbtnM.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(417, 140);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(77, 17);
            this.ckbxCasado.TabIndex = 27;
            this.ckbxCasado.Text = "Casado (a)";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 484);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.GbxSexo);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalLiq);
            this.Controls.Add(this.mskbxSalFamilia);
            this.Controls.Add(this.mskbxIRPF);
            this.Controls.Add(this.mskbxINSS);
            this.Controls.Add(this.mskbxNumFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbxSexo.ResumeLayout(false);
            this.GbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNumFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxINSS;
        private System.Windows.Forms.MaskedTextBox mskbxIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalLiq;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.GroupBox GbxSexo;
        private System.Windows.Forms.RadioButton RbtnM;
        private System.Windows.Forms.RadioButton RbtnF;
        private System.Windows.Forms.CheckBox ckbxCasado;
    }
}

