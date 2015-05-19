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
    public partial class BotaoCaixa : UserControl
    {
        public BotaoCaixa()
        {
            InitializeComponent();
        }

        private void BotaoCaixa_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCaixa2;
        }

        private void BotaoCaixa_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCaixa1;
        }
    }
}
