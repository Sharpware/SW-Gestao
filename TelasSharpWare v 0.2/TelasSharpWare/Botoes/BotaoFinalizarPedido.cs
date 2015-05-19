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
    public partial class BotaoFinalizarPedido : UserControl
    {
        public BotaoFinalizarPedido()
        {
            InitializeComponent();
        }

        private void BotaoFinalizarPedido_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFinalizarPedido2;
        }

        private void BotaoFinalizarPedido_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFinalizarPedido1;
        }
    }
}
