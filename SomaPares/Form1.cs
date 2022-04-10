using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            int i, num, soma = 0;

            //entrada de dados - atribui a num o valor do txtNum
            num = Convert.ToInt32(txtNum.Text);

            //inicializa o laço em 1;
            //testa a condição de parada: i <= num
            //incrementa a variavel i++ 
            for (i = 1; i <= num; i++)
            {
                //verifica se i é par
                if (i % 2 == 0)
                {
                    //faz o somatório dos números pares
                    soma = soma + i;
                }
            }

            //apresenta o total da soma dos pares no txtSoma
            txtSoma.Text = soma.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa os TextBox
            txtSoma.Clear();
            txtNum.Clear();
            //coloca o foco no txtNum
            txtNum.Focus();
        }
    }
}
