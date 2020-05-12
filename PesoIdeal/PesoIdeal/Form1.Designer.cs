namespace PesoIdeal
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gpbxSexo = new System.Windows.Forms.GroupBox();
            this.rdobtnMasc = new System.Windows.Forms.RadioButton();
            this.rdobtnFem = new System.Windows.Forms.RadioButton();
            this.msktxtbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.gpbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 19);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 13);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso Atual";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 61);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(155, 151);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(115, 45);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // gpbxSexo
            // 
            this.gpbxSexo.Controls.Add(this.rdobtnMasc);
            this.gpbxSexo.Controls.Add(this.rdobtnFem);
            this.gpbxSexo.Location = new System.Drawing.Point(255, 12);
            this.gpbxSexo.Name = "gpbxSexo";
            this.gpbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gpbxSexo.TabIndex = 5;
            this.gpbxSexo.TabStop = false;
            this.gpbxSexo.Text = "Sexo";
            // 
            // rdobtnMasc
            // 
            this.rdobtnMasc.AutoSize = true;
            this.rdobtnMasc.Location = new System.Drawing.Point(6, 50);
            this.rdobtnMasc.Name = "rdobtnMasc";
            this.rdobtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdobtnMasc.TabIndex = 1;
            this.rdobtnMasc.TabStop = true;
            this.rdobtnMasc.Text = "Masculino";
            this.rdobtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdobtnFem
            // 
            this.rdobtnFem.AutoSize = true;
            this.rdobtnFem.Location = new System.Drawing.Point(6, 19);
            this.rdobtnFem.Name = "rdobtnFem";
            this.rdobtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdobtnFem.TabIndex = 0;
            this.rdobtnFem.TabStop = true;
            this.rdobtnFem.Text = "Feminino";
            this.rdobtnFem.UseVisualStyleBackColor = true;
            // 
            // msktxtbxPeso
            // 
            this.msktxtbxPeso.Location = new System.Drawing.Point(76, 19);
            this.msktxtbxPeso.Name = "msktxtbxPeso";
            this.msktxtbxPeso.Size = new System.Drawing.Size(135, 20);
            this.msktxtbxPeso.TabIndex = 2;
            // 
            // msktxtbxAltura
            // 
            this.msktxtbxAltura.Location = new System.Drawing.Point(76, 61);
            this.msktxtbxAltura.Name = "msktxtbxAltura";
            this.msktxtbxAltura.Size = new System.Drawing.Size(132, 20);
            this.msktxtbxAltura.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(491, 226);
            this.Controls.Add(this.msktxtbxAltura);
            this.Controls.Add(this.msktxtbxPeso);
            this.Controls.Add(this.gpbxSexo);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbxSexo.ResumeLayout(false);
            this.gpbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox gpbxSexo;
        private System.Windows.Forms.RadioButton rdobtnMasc;
        private System.Windows.Forms.RadioButton rdobtnFem;
        private System.Windows.Forms.MaskedTextBox msktxtbxPeso;
        private System.Windows.Forms.MaskedTextBox msktxtbxAltura;
    }
}

