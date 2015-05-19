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
    public partial class BotaoPesquisar : UserControl
    {
        public BotaoPesquisar()
        {
            InitializeComponent();
        }

        private void BotaoPesquisar_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisar2;
        }

        private void BotaoPesquisar_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisar1;
        }

    }
}
