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
    public partial class PesquisaDeProduto : Form
    {
        public PesquisaDeProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoCadProduto1_Click(object sender, EventArgs e)
        {
            AdicionarProduto adicionarProduto = new AdicionarProduto();
            adicionarProduto.Show();
        }

        private void botaoSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
