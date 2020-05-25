namespace Atividade6
{
    partial class frmExec1
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnBrancos = new System.Windows.Forms.Button();
            this.btnRs = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(12, 12);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(776, 157);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnBrancos
            // 
            this.btnBrancos.Location = new System.Drawing.Point(12, 191);
            this.btnBrancos.Name = "btnBrancos";
            this.btnBrancos.Size = new System.Drawing.Size(165, 59);
            this.btnBrancos.TabIndex = 1;
            this.btnBrancos.Text = "Quantidade de Brancos";
            this.btnBrancos.UseVisualStyleBackColor = true;
            this.btnBrancos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRs
            // 
            this.btnRs.Location = new System.Drawing.Point(327, 191);
            this.btnRs.Name = "btnRs";
            this.btnRs.Size = new System.Drawing.Size(165, 59);
            this.btnRs.TabIndex = 2;
            this.btnRs.Text = "Quantidade de R\'s";
            this.btnRs.UseVisualStyleBackColor = true;
            this.btnRs.Click += new System.EventHandler(this.btnRs_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(623, 191);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(165, 59);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Quantidade de Par de Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // frmExec1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnRs);
            this.Controls.Add(this.btnBrancos);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExec1";
            this.Text = "Exec1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnBrancos;
        private System.Windows.Forms.Button btnRs;
        private System.Windows.Forms.Button btnLetras;
    }
}