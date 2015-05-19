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
    public partial class BotaoAdicionarCliente : UserControl
    {
        public BotaoAdicionarCliente()
        {
            InitializeComponent();
        }

        private void BotaoAdicionarCliente_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarCliente2;
        }

        private void BotaoAdicionarCliente_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarCliente1;
        }
    }
}
