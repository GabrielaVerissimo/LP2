namespace Atividade6
{
    partial class frmExec2
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.btnNumH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(113, 12);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(202, 20);
            this.txtN.TabIndex = 0;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(113, 67);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(202, 20);
            this.txtH.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 15);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(95, 13);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Digite o número N:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(12, 74);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(58, 13);
            this.lblH.TabIndex = 3;
            this.lblH.Text = "Número H:";
            // 
            // btnNumH
            // 
            this.btnNumH.Location = new System.Drawing.Point(146, 124);
            this.btnNumH.Name = "btnNumH";
            this.btnNumH.Size = new System.Drawing.Size(128, 41);
            this.btnNumH.TabIndex = 4;
            this.btnNumH.Text = "Gerar Número H";
            this.btnNumH.UseVisualStyleBackColor = true;
            this.btnNumH.Click += new System.EventHandler(this.btnNumH_Click);
            // 
            // frmExec2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumH);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtN);
            this.Name = "frmExec2";
            this.Text = "frmExec2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Button btnNumH;
    }
}