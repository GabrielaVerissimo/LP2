namespace Atividade6
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
            this.btnExec1 = new System.Windows.Forms.Button();
            this.btnExec2 = new System.Windows.Forms.Button();
            this.btnExec3 = new System.Windows.Forms.Button();
            this.btnExec4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec1
            // 
            this.btnExec1.Location = new System.Drawing.Point(16, 6);
            this.btnExec1.Name = "btnExec1";
            this.btnExec1.Size = new System.Drawing.Size(152, 71);
            this.btnExec1.TabIndex = 0;
            this.btnExec1.Text = "Exercício 1";
            this.btnExec1.UseVisualStyleBackColor = true;
            this.btnExec1.Click += new System.EventHandler(this.btnExec1_Click);
            // 
            // btnExec2
            // 
            this.btnExec2.Location = new System.Drawing.Point(211, 6);
            this.btnExec2.Name = "btnExec2";
            this.btnExec2.Size = new System.Drawing.Size(152, 71);
            this.btnExec2.TabIndex = 1;
            this.btnExec2.Text = "Exercício 2";
            this.btnExec2.UseVisualStyleBackColor = true;
            this.btnExec2.Click += new System.EventHandler(this.btnExec2_Click);
            // 
            // btnExec3
            // 
            this.btnExec3.Location = new System.Drawing.Point(16, 130);
            this.btnExec3.Name = "btnExec3";
            this.btnExec3.Size = new System.Drawing.Size(152, 71);
            this.btnExec3.TabIndex = 2;
            this.btnExec3.Text = "Exercício 3";
            this.btnExec3.UseVisualStyleBackColor = true;
            this.btnExec3.Click += new System.EventHandler(this.btnExec3_Click);
            // 
            // btnExec4
            // 
            this.btnExec4.Location = new System.Drawing.Point(211, 130);
            this.btnExec4.Name = "btnExec4";
            this.btnExec4.Size = new System.Drawing.Size(152, 71);
            this.btnExec4.TabIndex = 3;
            this.btnExec4.Text = "Exercício 4";
            this.btnExec4.UseVisualStyleBackColor = true;
            this.btnExec4.Click += new System.EventHandler(this.btnExec4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 219);
            this.Controls.Add(this.btnExec4);
            this.Controls.Add(this.btnExec3);
            this.Controls.Add(this.btnExec2);
            this.Controls.Add(this.btnExec1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec1;
        private System.Windows.Forms.Button btnExec2;
        private System.Windows.Forms.Button btnExec3;
        private System.Windows.Forms.Button btnExec4;
    }
}

