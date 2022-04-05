namespace Form2Campos
{
    partial class frmSoma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.Label();
            this.btnInteiros = new System.Windows.Forms.Button();
            this.btnReais = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Location = new System.Drawing.Point(30, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(15, 15);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "A";
            // 
            // txtB
            // 
            this.txtB.AutoSize = true;
            this.txtB.Location = new System.Drawing.Point(30, 53);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(14, 15);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "B";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(30, 82);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(59, 15);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.Text = "Resultado";
            // 
            // btnInteiros
            // 
            this.btnInteiros.Location = new System.Drawing.Point(323, 32);
            this.btnInteiros.Name = "btnInteiros";
            this.btnInteiros.Size = new System.Drawing.Size(75, 23);
            this.btnInteiros.TabIndex = 3;
            this.btnInteiros.Text = "Inteiros";
            this.btnInteiros.UseVisualStyleBackColor = true;
            this.btnInteiros.Click += new System.EventHandler(this.btnInteiros_Click);
            // 
            // btnReais
            // 
            this.btnReais.Location = new System.Drawing.Point(323, 62);
            this.btnReais.Name = "btnReais";
            this.btnReais.Size = new System.Drawing.Size(75, 23);
            this.btnReais.TabIndex = 4;
            this.btnReais.Text = "Reais";
            this.btnReais.UseVisualStyleBackColor = true;
            this.btnReais.Click += new System.EventHandler(this.btnReais_Click);
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(135, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(100, 23);
            this.lblA.TabIndex = 5;
            // 
            // lblB
            // 
            this.lblB.Location = new System.Drawing.Point(135, 53);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(100, 23);
            this.lblB.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(135, 82);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.ReadOnly = true;
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 7;
            // 
            // frmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 154);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnReais);
            this.Controls.Add(this.btnInteiros);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "frmSoma";
            this.Text = "Somar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.Label txtB;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Button btnInteiros;
        private System.Windows.Forms.Button btnReais;
        private System.Windows.Forms.TextBox lblA;
        private System.Windows.Forms.TextBox lblB;
        private System.Windows.Forms.TextBox lblResultado;
    }
}
