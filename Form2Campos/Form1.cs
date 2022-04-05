using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2Campos
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {
            int a, b, soma; 

            //entrada de dados
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);

            // processamento

            soma = a + b;

            //sainda de dados
            txtResultado.Text = soma.ToString();

        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            double a, b , soma ;

            a = Convert.ToDouble(txtA.Text);
            b = double.Parse(txtB.Text);

            soma = a + b;

            txtResultado.Text = soma.ToString();

            


        }
    }
}
