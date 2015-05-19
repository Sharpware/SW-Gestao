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
    public partial class BotaoAdProduto : UserControl
    {
        public BotaoAdProduto()
        {
            InitializeComponent();
        }

        private void BotaoAdProduto_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdProduto2;
        }

        private void BotaoAdProduto_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdProduto1;
        }
    }
}
