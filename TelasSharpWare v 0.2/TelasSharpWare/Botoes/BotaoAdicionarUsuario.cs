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
    public partial class BotaoAdicionarUsuario : UserControl
    {
        public BotaoAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void BotaoAdicionarUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarUsuario2;
        }

        private void BotaoAdicionarUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarUsuario1;
        }

    }
}
