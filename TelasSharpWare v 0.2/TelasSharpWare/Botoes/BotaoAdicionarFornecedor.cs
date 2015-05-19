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
    public partial class BotaoAdicionarFornecedor : UserControl
    {
        public BotaoAdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void BotaoAdicionarFornecedor_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarFornecedor2;
        }

        private void BotaoAdicionarFornecedor_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarFornecedor1;
        }
    }
}
