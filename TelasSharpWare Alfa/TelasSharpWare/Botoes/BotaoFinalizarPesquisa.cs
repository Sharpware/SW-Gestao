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
    public partial class BotaoFinalizarPesquisa : UserControl
    {
        public BotaoFinalizarPesquisa()
        {
            InitializeComponent();
        }

        private void BotaoFinalizarPesquisa_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFinalizarPesquisa2;
        }

        private void BotaoFinalizarPesquisa_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoFinalizarPesquisa1;
        }
    }
}
