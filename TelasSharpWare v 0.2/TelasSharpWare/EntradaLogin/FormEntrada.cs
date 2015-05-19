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
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            
            InitializeComponent();
        }
        

        private void botaoCaixa1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "\tCaixa";
        }

        private void botaoCaixa1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void botaoSistema1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Sistema de gestão";
        }

        private void botaoSistema1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void botaoPesquisar1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Pesquisa de produtos";
        }

        private void botaoPesquisar1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void botaoSistema1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void botaoCaixa1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
