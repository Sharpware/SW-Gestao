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
    public partial class BotaoCancelPedido : UserControl
    {
        public BotaoCancelPedido()
        {
            InitializeComponent();
        }

        private void BotaoCancelPedido_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelPedido2;
        }

        private void BotaoCancelPedido_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelPedido1;
        }
    }
}
