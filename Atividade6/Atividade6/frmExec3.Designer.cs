namespace Atividade6
{
    partial class frmExec3
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.lblInversa = new System.Windows.Forms.Label();
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(12, 9);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(98, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Escreva uma frase:";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(116, 6);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(320, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(456, 20);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(116, 41);
            this.btnPalindromo.TabIndex = 2;
            this.btnPalindromo.Text = "Gerar Palíndromo";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // lblInversa
            // 
            this.lblInversa.AutoSize = true;
            this.lblInversa.Location = new System.Drawing.Point(12, 63);
            this.lblInversa.Name = "lblInversa";
            this.lblInversa.Size = new System.Drawing.Size(93, 13);
            this.lblInversa.TabIndex = 3;
            this.lblInversa.Text = "Frase Palíndroma:";
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(116, 56);
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(320, 20);
            this.txtPalindromo.TabIndex = 4;
            // 
            // frmExec3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 88);
            this.Controls.Add(this.txtPalindromo);
            this.Controls.Add(this.lblInversa);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblFrase);
            this.Name = "frmExec3";
            this.Text = "frmExec3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnPalindromo;
        private System.Windows.Forms.Label lblInversa;
        private System.Windows.Forms.TextBox txtPalindromo;
    }
}