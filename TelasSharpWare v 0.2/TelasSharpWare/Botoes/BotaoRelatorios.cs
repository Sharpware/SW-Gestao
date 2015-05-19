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
    public partial class BotaoRelatorios : UserControl
    {
        public BotaoRelatorios()
        {
            InitializeComponent();
        }

        private void BotaoRelatorios_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeRelatorios2;
        }

        private void BotaoRelatorios_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeRelatorios1;
        }
    }
}
