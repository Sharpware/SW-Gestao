using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare.Botoes
{
    public partial class BotaoPesqProduto : UserControl
    {
        public BotaoPesqProduto()
        {
            InitializeComponent();
        }

        private void BotaoPesqProduto_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesqProduto2;
        }

        private void BotaoPesqProduto_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesqProduto1;
        }
    }
}
