namespace P0030481921038
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 12);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(227, 316);
            this.lbLista.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(52, 350);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(154, 60);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 422);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lbLista);
            this.Name = "Form1";
            this.Text = "Prova";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnVerificar;
    }
}

