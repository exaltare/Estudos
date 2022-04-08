using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostraPatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //limpa os itens adicionados no ComboBox
            cboAnimais.Items.Clear();

            //adiciona os Itens no ComboBox 
            //por meio do méto Add( )

            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.Items.Add("Pássaro");
        }

        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPatas_Click(object sender, EventArgs e)
        {
            //declara variável
            String strAnimal;

            //variável recebe o texto do item do ComboBox Selecionado
            strAnimal = cboAnimais.Text;

            //instrução de seleção
            switch (strAnimal)
            {
                //agrupando vários casos na mesma seção
                case "Cavalo":
                case "Gato":
                case "Cachorro":
                    MessageBox.Show("Este aminal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Centopeia":
                    MessageBox.Show("Este aminal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Cobra":
                    MessageBox.Show("Este aminal não tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Pássaro":
                    MessageBox.Show("Este aminal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
