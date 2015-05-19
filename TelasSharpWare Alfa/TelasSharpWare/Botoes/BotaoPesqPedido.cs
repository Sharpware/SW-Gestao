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
    public partial class BotaoPesqPedido : UserControl
    {
        public BotaoPesqPedido()
        {
            InitializeComponent();
        }

        private void BotaoPesqPedido_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesqPedido2;
        }

        private void BotaoPesqPedido_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesqPedido1;
        }
    }
}
