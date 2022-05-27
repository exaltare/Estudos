using ConsultarCEPCorreios.Model;
using ConsultarCEPCorreios.Services;
using Correios.Net;
using System;
using System.Windows.Forms;



namespace ConsultarCEPCorreios
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

        private async void DadosCEP(object sender, EventArgs e)
        {
            string NumeroCEP = txtCep.Text.Replace("-", string.Empty).Replace(".", String.Empty);
            if (NumeroCEP.Length == 8)
            {
                CEPResponseModel Endereco = new();
                CEPServices Service = new();
                Endereco = await Service.GetDataCEP(NumeroCEP);
                txtEstado.Text = Endereco.Uf;
                txtRua.Text = Endereco.Logradouro;
                txtCidade.Text = Endereco.Localidade;
                txtBairro.Text = Endereco.Bairro;

            }         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCep.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;

            txtCep.Focus();


        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //private void textCep_Leave(object sender, EventArgs e)
        //{
        //    //LocalizarCEP();
        //}


        //private void LocalizarCEP()
        //{
        //    if (!string.IsNullOrWhiteSpace(txtCep.Text))
        //    {
        //        Address endereco = SearchZip.GetAddress(txtCep.Text);
        //        if (endereco.Zip != null)
        //        {
        //            txtEstado.Text = endereco.State;
        //            txtCidade.Text = endereco.City;
        //            txtBairro.Text = endereco.District;
        //            txtRua.Text = endereco.Street;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Cep não localizado...");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Informe um CEP válido");
        //    }
        //}


    }
}
