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
    public partial class BotaoAdicionarClienteCaixa : UserControl
    {
        public BotaoAdicionarClienteCaixa()
        {
            InitializeComponent();
        }

        private void BotaoAdicionarClienteCaixa_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarClienteCaixa2;
        }

        private void BotaoAdicionarClienteCaixa_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarClienteCaixa1;
        }
    }
}
