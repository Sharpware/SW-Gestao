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
    public partial class BotaoCompras : UserControl
    {
        public BotaoCompras()
        {
            InitializeComponent();
        }

        private void BotaoCompras_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeCompras2;
        }

        private void BotaoCompras_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeCompras1;
        }
    }
}
