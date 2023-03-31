using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_produtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtBoxId.Text == "")
            {
                MessageBox.Show("Você precisar digitar o ID", "Erro de Formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxId.Focus();
                return;
            }
            if (txtBoxProduto.Text == "")
            {
                MessageBox.Show("Você precisa digitar o nome do produto", "Erro de formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxProduto.Focus();
                return;
            }
            if (txtBoxQuantidade.Text == "")
            {
                MessageBox.Show("Você precisa digitar o Quantidade para continuar", "Erro de formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxPreco.Focus();
                return;
            }
            if(txtBoxPreco.Text == "")
            {
                MessageBox.Show("Você precisa digitar a Preco para continuar", "Erro de formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxPreco.Focus();
                return;
            }

            String[] produtos = new String[4];
            produtos[0] = txtBoxId.Text;
            produtos[1] = txtBoxProduto.Text;
            produtos[2] = txtBoxQuantidade.Text;
            produtos[3] = txtBoxPreco.Text;

            ListViewItem L = new ListViewItem(produtos);
            listView1.Items.Add(L);
            limpar();

            
        }

        private void limpar()
        {
            txtBoxId.Clear();
            txtBoxProduto.Clear();
            txtBoxQuantidade.Clear();
            txtBoxPreco.Clear();
            txtBoxId.Focus();
        }

        
    }
}
