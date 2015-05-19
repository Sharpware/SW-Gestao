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
    public partial class BotaoRelatorioDeDespesas : UserControl
    {
        public BotaoRelatorioDeDespesas()
        {
            InitializeComponent();
        }

        private void BotaoRelatorioDeDespesas_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoRelatorioDeDespesas2;
        }

        private void BotaoRelatorioDeDespesas_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoRelatorioDeDespesas1;
        }
    }
}
