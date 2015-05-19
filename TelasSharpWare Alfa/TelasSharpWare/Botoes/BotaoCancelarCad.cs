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
    public partial class BotaoCancelarCad : UserControl
    {
        public BotaoCancelarCad()
        {
            InitializeComponent();
        }

        private void BotaoCancelarCad_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelarCad2;
        }

        private void BotaoCancelarCad_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCancelarCad1;
        }
    }
}
