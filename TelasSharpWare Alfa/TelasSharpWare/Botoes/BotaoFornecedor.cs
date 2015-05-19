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
    public partial class BotaoFornecedor : UserControl
    {
        public BotaoFornecedor()
        {
            InitializeComponent();
        }

        private void BotaoFornecedor_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeFornecedor2;
        }

        private void BotaoFornecedor_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeFornecedor1;
        }
    }
}
