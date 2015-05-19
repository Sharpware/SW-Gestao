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
    public partial class BotaoEditarCliente : UserControl
    {
        public BotaoEditarCliente()
        {
            InitializeComponent();
        }

        private void BotaoEditarCliente_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoEditarCliente2;
        }

        private void BotaoEditarCliente_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoEditarCliente1;
        }
    }
}
