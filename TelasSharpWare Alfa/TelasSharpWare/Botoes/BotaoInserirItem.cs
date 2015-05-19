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
    public partial class BotaoInserirItem : UserControl
    {
        public BotaoInserirItem()
        {
            InitializeComponent();
        }

        private void BotaoInserirItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInserirPedido2;
        }

        private void BotaoInserirItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInserirPedido1;
        }
    }
}
