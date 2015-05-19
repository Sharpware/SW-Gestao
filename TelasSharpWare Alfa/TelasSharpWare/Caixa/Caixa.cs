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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void botaoFinalizarVenda2_Click(object sender, EventArgs e)
        {
            ModoDePagamento pagamento = new ModoDePagamento();
            pagamento.ShowDialog();
        }

        private void botaoAdicionarClienteCaixa1_Click(object sender, EventArgs e)
        {
            PesquisarCliente pesquisarCliente = new PesquisarCliente();
            pesquisarCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
