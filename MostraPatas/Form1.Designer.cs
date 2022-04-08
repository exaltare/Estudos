namespace MostraPatas
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
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.btnPatas = new System.Windows.Forms.Button();
            this.pctAnimais = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnimais
            // 
            this.cboAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimais.FormattingEnabled = true;
            this.cboAnimais.Location = new System.Drawing.Point(115, 17);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(141, 23);
            this.cboAnimais.TabIndex = 0;
            this.cboAnimais.SelectedIndexChanged += new System.EventHandler(this.cboAnimais_SelectedIndexChanged);
            // 
            // btnPatas
            // 
            this.btnPatas.Location = new System.Drawing.Point(141, 55);
            this.btnPatas.Name = "btnPatas";
            this.btnPatas.Size = new System.Drawing.Size(94, 23);
            this.btnPatas.TabIndex = 1;
            this.btnPatas.Text = "Mostrar Patas";
            this.btnPatas.UseVisualStyleBackColor = true;
            this.btnPatas.Click += new System.EventHandler(this.btnPatas_Click);
            // 
            // pctAnimais
            // 
            this.pctAnimais.Location = new System.Drawing.Point(115, 106);
            this.pctAnimais.Name = "pctAnimais";
            this.pctAnimais.Size = new System.Drawing.Size(141, 130);
            this.pctAnimais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnimais.TabIndex = 2;
            this.pctAnimais.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 298);
            this.Controls.Add(this.pctAnimais);
            this.Controls.Add(this.btnPatas);
            this.Controls.Add(this.cboAnimais);
            this.Name = "Form1";
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Button btnPatas;
        private System.Windows.Forms.PictureBox pctAnimais;
    }
}
