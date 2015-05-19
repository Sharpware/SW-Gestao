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
    public partial class BotaoCadUsuario : UserControl
    {
        public BotaoCadUsuario()
        {
            InitializeComponent();
        }

        private void BotaoCadUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCadUsuario2;
        }

        private void BotaoCadUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCadUsuario1;
        }
    }
}
