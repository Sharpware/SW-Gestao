using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormEntrada entrada = new FormEntrada();
            Login login = new Login();
            do
            {
                entrada.ShowDialog();
                if (entrada.DialogResult == DialogResult.OK)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new SistemaControle());
                    }
                    if (login.DialogResult == DialogResult.No)
                    {
                        login.Close();
                    }
                    if (login.DialogResult == DialogResult.Retry)
                        MessageBox.Show("Login ou senha incoreta");
                }
                if (entrada.DialogResult == DialogResult.Yes)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Caixa());
                    }
                    if (login.DialogResult == DialogResult.No)
                    {
                        login.Close();
                    }
                    if (login.DialogResult == DialogResult.Retry)
                        MessageBox.Show("Login ou senha incoreta");
                }

                if (entrada.DialogResult == DialogResult.Abort)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new PesquisarProduto());
                    }
                    if (login.DialogResult == DialogResult.No)
                    {
                        login.Close();
                    }
                    if (login.DialogResult == DialogResult.Retry)
                        MessageBox.Show("Login ou senha incoreta");
                }
            } while (entrada.DialogResult != DialogResult.No);
        }
    }
}
