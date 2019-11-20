using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_PA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, rg, cpf, email, endereço, bairro, cidade, numero, estado, cep, sexo, senha, confirm_senha;
                nome = txtNome.Text;
                rg = txtRg.Text;
                cpf = txtCPF.Text;
                email = txtEmail.Text;
                endereço = txtEndereco.Text;
                bairro = txtBairro.Text;
                cidade = txtCidade.Text;
                numero = txtNumero.Text;
                estado = txtEstado.Text;
                cep = txtCEP.Text;
                senha = txtSenha.Text;
                confirm_senha = txtConfirmaSenha.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }
    }
}
