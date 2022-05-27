using Correios.Net;
using System;
using System.Windows.Forms;

namespace WF_BuscaCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();

        }
        private void LocalizarCEP()
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                Address endereco = SearchZip.GetAddress(txtCep.Text);
                if (endereco.Zip != null)
                {
                    txtEstado.Text = endereco.State;
                    txtCidade.Text = endereco.City;
                    txtBairro.Text = endereco.District;
                    txtRua.Text = endereco.Street;
                }
                else
                {
                    MessageBox.Show("Cep não localizado...");
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido");
            }
        }
    }
}
