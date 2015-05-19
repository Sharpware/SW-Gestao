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
    public partial class BotaoRelatorioDeVendas : UserControl
    {
        public BotaoRelatorioDeVendas()
        {
            InitializeComponent();
        }

        private void BotaoRelatorioDeVendas_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoRelatorioDeVendas2;
        }

        private void BotaoRelatorioDeVendas_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoRelatorioDeVendas1;
        }
    }
}
