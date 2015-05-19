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
    public partial class BotaoInativarFornecedor : UserControl
    {
        public BotaoInativarFornecedor()
        {
            InitializeComponent();
        }

        private void BotaoInativarFornecedor_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInativarFornecedor2;
        }

        private void BotaoInativarFornecedor_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInativarFornecedor1;
        }
    }
}
