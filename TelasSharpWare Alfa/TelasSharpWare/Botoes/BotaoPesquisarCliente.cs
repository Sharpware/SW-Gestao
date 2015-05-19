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
    public partial class BotaoPesquisarCliente : UserControl
    {
        public BotaoPesquisarCliente()
        {
            InitializeComponent();
        }

        private void BotaoPesquisarCliente_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarCliente2;
        }

        private void BotaoPesquisarCliente_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarCliente1;
        }
    }
}
