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
    public partial class BotaoFazerPedido : UserControl
    {
        public BotaoFazerPedido()
        {
            InitializeComponent();
        }

        private void BotaoFazerPedido_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFazerPedido2;
        }

        private void BotaoFazerPedido_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFazerPedido1;
        }
    }
}
