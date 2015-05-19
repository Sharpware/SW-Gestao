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
    public partial class BotaoFimPedido : UserControl
    {
        public BotaoFimPedido()
        {
            InitializeComponent();
        }

        private void BotaoFimPedido_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFimPedido2;
        }

        private void BotaoFimPedido_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFimPedido1;
        }
    }
}
