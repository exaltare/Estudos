using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorNumero
{
    public partial class Form1 : Form
    {

        int verificaMaior(int num1, int num2)
         
        
        {
            if (num1 > num2)
            {
                return num1;
            }
            else  
            {
                return num2;
            }
            

        }

        void limparControles()
        {
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            int a, b;

            //entrada de dados para as variáveis
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            //chamando a função verificaMaior 
            //e passando os argumentos para os parâmetros num1 e num2
            // TextBox txtMaior recebe o retorno da função
            txtMaior.Text = verificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //chama o procedimento limparControles
            limparControles();
        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            //declaração das variáveis
            int a, b;

            //entrada de dados para as variáveis
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            //chamando a função verificaMaior 
            //e passando os argumentos para os parâmetros num1 e num2
            // TextBox txtMaior recebe o retorno da função
            txtMaior.Text = verificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            //chama o procedimento limparControles
            limparControles();
        }
    }
}
