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
            ComprasPnl.Visible = true;
            ClientePnl.Visible = false;
            ProdutosPnl.Visible = false;
            FornecedorPnl.Visible = false;
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
            Agradecimentos agradecimento = new Agradecimentos();
            agradecimento.Show();
        }

        private void botaoAdicionarCliente1_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastroCliente = new CadastrarCliente();
            cadastroCliente.Show();
        }

        private void botaoPesquisarCliente1_Click(object sender, EventArgs e)
        {
            PesquisarCliente pesquisaCliente = new PesquisarCliente();
            pesquisaCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botaoAdicionaProduto1_Click(object sender, EventArgs e)
        {
            AdicionarProduto adicionarProduto = new AdicionarProduto();
            adicionarProduto.Show();
        }

        private void botaoPesquisarProduto1_Click(object sender, EventArgs e)
        {
            PesquisaDeProduto pesquisarProduto = new PesquisaDeProduto();
            pesquisarProduto.Show();
        }

        private void botaoAdicionarFornecedor1_Click(object sender, EventArgs e)
        {
            AdicionarFornecedor adicionarFornecedor = new AdicionarFornecedor();
            adicionarFornecedor.Show();
        }

        private void botaoPesquisarFornecedor1_Click(object sender, EventArgs e)
        {
            PesquisarFornecedor pesquisarFornecedor = new PesquisarFornecedor();
            pesquisarFornecedor.Show();
        }

        private void botaoRelatorioDeVendas1_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorioVendas = new RelatorioVendas();
            relatorioVendas.Show();
        }

        private void botaoFazerPedido1_Click(object sender, EventArgs e)
        {
            FazerPedido fazerPedido = new FazerPedido();
            fazerPedido.Show();
        }

        private void botaoPesquisarPedido1_Click(object sender, EventArgs e)
        {
            PesquisarPedido pesquisarPedido = new PesquisarPedido();
            pesquisarPedido.Show();
        }

        private void botaoAdicionarUsuario1_Click(object sender, EventArgs e)
        {
            AdicionarUsuario adicionarUsuario = new AdicionarUsuario();
            adicionarUsuario.Show();
        }

        private void botaoPesquisarUsuario1_Click(object sender, EventArgs e)
        {
            PesquisarUsuario pesquisarUsuario = new PesquisarUsuario();
            pesquisarUsuario.Show();
        }

        private void botaoSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        


       
    }
}
