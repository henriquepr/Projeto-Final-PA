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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras, nome, descricao, preco, estoque, unidade, tipo;
                codBarras = textBox1.Text;
                nome = textBox2.Text;
                descricao = textBox3.Text;
                preco = textBox5.Text;
                estoque = textBox6.Text;
                unidade = textBox7.Text;
                tipo = comboBox1.Text;

                if (string.IsNullOrWhiteSpace(codBarras) || codBarras == "Digite o código de barras do produto")
                {
                    throw new Exception("O campo \"Código de barras\" está vazio");
                }

                try
                {
                    Convert.ToInt64(codBarras);
                }

                catch
                {
                    throw new Exception("O campo \"Código de barras\" está com caracteres inválidos");
                }

                if(codBarras.Length != 13)
                {
                    throw new Exception("O campo \"Código de Barras\" deve conter 13 digitos");
                }

                if (string.IsNullOrWhiteSpace(nome) || nome == "Digite o nome do produto")
                {
                    throw new Exception("O campo \"Nome\" está vazio");
                }

                if (string.IsNullOrWhiteSpace(descricao) || descricao == "Digite a descrição do produto")
                {
                    throw new Exception("O campo \"Descrição\" está vazio");
                }

                if (string.IsNullOrWhiteSpace(preco))
                {
                    throw new Exception("O campo \"Preço\" está vazio");
                }

                try
                {
                    Convert.ToDouble(preco);
                }

                catch
                {
                    throw new Exception("O campo \"Preço\" está com caracteres inválidos");
                }

                if (string.IsNullOrWhiteSpace(estoque))
                {
                    throw new Exception("O campo \"Estoque\" está vazio");
                }

                try
                {
                    Convert.ToInt64(estoque);
                }

                catch
                {
                    throw new Exception("O campo \"Estoque\" está com caracteres inválidos");
                }

                if (string.IsNullOrWhiteSpace(unidade))
                {
                    throw new Exception("O campo \"Unidade\" está vazio");
                }

                try
                {
                    Convert.ToInt64(unidade);
                }

                catch
                {
                    throw new Exception("O campo \"Unidade\" está com caracteres inválidos");
                }

                if (string.IsNullOrWhiteSpace(tipo))
                {
                    throw new Exception("O campo \"Tipo\" está vazio");
                }
                MessageBox.Show("Produto cadastrado com sucesso", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Digite o código de barras do produto")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Digite o código de barras do produto";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Digite o nome do produto")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Digite o nome do produto";
                textBox2.ForeColor = Color.Silver;
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Digite a descrição do produto")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Digite a descrição do produto";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
