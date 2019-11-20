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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 produto = new Form2(); /*Form2 nome da classe, produto nome objeto, Form2();metodo construtor*/
            produto.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 cliente = new Form3();
            cliente.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 cliente = new Form3();
            cliente.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 produto = new Form2(); /*Form2 nome da classe, produto nome objeto, Form2();metodo construtor*/
            produto.ShowDialog();
            this.Close();
        }
    }
}
