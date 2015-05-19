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
    public partial class BotaoAdicionaProduto : UserControl
    {
        public BotaoAdicionaProduto()
        {
            InitializeComponent();
        }

        private void BotaoAdicionaProduto_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarProduto2;
        }

        private void BotaoAdicionaProduto_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarProduto1;
        }
    }
}
