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
    public partial class BotaoInativarCliente : UserControl
    {
        public BotaoInativarCliente()
        {
            InitializeComponent();
        }

        private void BotaoInativarCliente_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInativarCliente2;
        }

        private void BotaoInativarCliente_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInativarCliente1;
        }
    }
}
