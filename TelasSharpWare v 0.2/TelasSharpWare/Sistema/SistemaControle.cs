using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare
{
    public partial class SistemaControle : Form
    {
        public SistemaControle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = false;
        }

        private void botaoCliente1_Click(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = true;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = false;
        }

        private void botaoProduto1_Click(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = true;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = false;
        }

        private void botaoFornecedor1_Click(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = true;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = false;
        }

        private void botaoCompras1_Click(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = true;
            AdministrativoPnl.Visible = false;
        }

        private void botaoRelatorios1_Click(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = true;
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = false;

        }

        private void botaoAdministrativo1_Click(object sender, EventArgs e)
        {

            FormPanel.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
            ComprasPnl.Visible = false;
            AdministrativoPnl.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A resposta do universo é 42!");
        }

        


       
    }
}
