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
    public partial class BotaoPesquisarFornecedor : UserControl
    {
        public BotaoPesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void BotaoPesquisarFornecedor_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarFornecedor2;
        }

        private void BotaoPesquisarFornecedor_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarFornecedor1;
        }
    }
}
