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
    public partial class BotaoPedidosEmAberto : UserControl
    {
        public BotaoPedidosEmAberto()
        {
            InitializeComponent();
        }

        private void BotaoPedidosEmAberto_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPedidosEmAberto2;
        }

        private void BotaoPedidosEmAberto_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPedidosEmAberto1;
        }
    }
}
