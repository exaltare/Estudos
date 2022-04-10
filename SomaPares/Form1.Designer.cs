namespace SomaPares
{
    partial class Form1
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.lblSoma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(94, 39);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(51, 15);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(147, 36);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(143, 23);
            this.txtNum.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 94);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(215, 94);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(147, 150);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(143, 23);
            this.txtSoma.TabIndex = 5;
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(94, 153);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(37, 15);
            this.lblSoma.TabIndex = 4;
            this.lblSoma.Text = "Soma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 224);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Soma Pares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Label lblSoma;
    }
}
