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
            Caixa caixa = new Caixa();
            if(entrada.ShowDialog() == DialogResult.OK)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new SistemaControle());
                }
                else
                    MessageBox.Show("Login ou senha incoreta");
            }
            else 
            {
                if(login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Caixa());
                }
            }
            
        }
    }
}
