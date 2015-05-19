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
    public partial class BotaoCancelarVenda : UserControl
    {
        public BotaoCancelarVenda()
        {
            InitializeComponent();
        }

        private void BotaoCancelarVenda_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelarVenda2;
        }

        private void BotaoCancelarVenda_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelarVenda1;
        }
    }
}
