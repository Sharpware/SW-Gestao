using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare
{
    public partial class BotaoPesquisarProduto : UserControl
    {
        public BotaoPesquisarProduto()
        {
            InitializeComponent();
        }

        private void BotaoPesquisarProduto_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarProduto2;
        }

        private void BotaoPesquisarProduto_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarProduto1;
        }
    }
}
