using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botaoLogin1_Click(object sender, EventArgs e)
        {
            if (LoginTbx.Text == "sharpware" && SenhaTbx.Text == "1234")
            {
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Retry;
        }
    }
}
