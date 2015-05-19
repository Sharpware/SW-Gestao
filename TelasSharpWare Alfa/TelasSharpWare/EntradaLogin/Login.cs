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
                LoginTbx.Text = "";
                SenhaTbx.Text = "";
            }
            else
            {
                DialogResult = DialogResult.Retry;
                LoginTbx.Text = "";
                SenhaTbx.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
