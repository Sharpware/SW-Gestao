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
    public partial class BotaoCadProduto : UserControl
    {
        public BotaoCadProduto()
        {
            InitializeComponent();
        }

        private void BotaoCadProduto_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCadProduto2;
        }

        private void BotaoCadProduto_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCadProduto1;
        }
    }
}
