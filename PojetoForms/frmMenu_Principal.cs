using ProjetoForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoForms
{
    public partial class frmMenu_Principal : Form
    {
        public frmMenu_Principal(login usuarioAutenticado)
        {
            InitializeComponent();
            this.strFuncionario.Text = usuarioAutenticado.Nome;
            this.strFuncao.Text = Text = usuarioAutenticado.UserProfile;
        }

        private void frmMenu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Senhor é o ");
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
