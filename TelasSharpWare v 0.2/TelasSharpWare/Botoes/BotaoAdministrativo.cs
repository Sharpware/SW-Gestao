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
    public partial class BotaoAdministrativo : UserControl
    {
        public BotaoAdministrativo()
        {
            InitializeComponent();
        }

        private void BotaoAdministrativo_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeAdministrativo2;
        }

        private void BotaoAdministrativo_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.IconeAdministrativo1;
        }
    }
}
