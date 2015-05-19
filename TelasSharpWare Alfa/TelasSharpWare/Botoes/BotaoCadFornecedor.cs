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
    public partial class BotaoCadFornecedor : UserControl
    {
        public BotaoCadFornecedor()
        {
            InitializeComponent();
        }

        private void BotaoCadFornecedor_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCadFornecedor2;
        }

        private void BotaoCadFornecedor_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCadFornecedor1;
        }
    }
}
