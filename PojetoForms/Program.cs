using ProjetoForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoForms
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmLogin telaLogin = new frmLogin();

            if(telaLogin.ShowDialog() == DialogResult.OK)
            {
                login usuarioLogado = telaLogin.usuarioEncontrado;
                Application.Run(new frmMenu_Principal(usuarioLogado));
            }
            else
            {
                Application.Exit();
            }

                Application.Run(new Form1());
        }
    }
}
