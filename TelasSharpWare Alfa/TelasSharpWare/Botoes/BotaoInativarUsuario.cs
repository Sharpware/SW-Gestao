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
    public partial class BotaoInativarUsuario : UserControl
    {
        public BotaoInativarUsuario()
        {
            InitializeComponent();
        }

        private void BotaoInativarUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInativarUsuario2;
        }

        private void BotaoInativarUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoInativarUsuario1;
        }
    }
}
