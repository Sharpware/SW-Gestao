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
    public partial class BotaoPesquisarUsuario : UserControl
    {
        public BotaoPesquisarUsuario()
        {
            InitializeComponent();
        }

        private void BotaoPesquisarUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarUsuario2;
        }

        private void BotaoPesquisarUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoPesquisarUsuario1;
        }
    }
}
