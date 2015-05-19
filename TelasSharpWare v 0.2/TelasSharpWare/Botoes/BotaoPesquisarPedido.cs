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
    public partial class BotaoPesquisarPedido : UserControl
    {
        public BotaoPesquisarPedido()
        {
            InitializeComponent();
        }

        private void BotaoPesquisarPedido_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarPedido2;
        }

        private void BotaoPesquisarPedido_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarPedido1;
        }
    }
}
