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
    public partial class frmLogin : Form
    {

        /// ListUsuario
        List<login> usuarios = new List<login>();
        public login usuarioEncontrado;
        public frmLogin()
        {
            InitializeComponent();
        }
             private void frmLogin_Load(object sender, EventArgs e)
        {


            login user1 = new login(1,"Arthur" ,"adm01@gmail.com", "adm123", "Administrador");
            login user2 = new login(1, "Caio","operador2@gmail.com", "123quatro", "Operador");
            login user3 = new login(1, "Roberta","operador3@gmail.com", "um2três", "Operador");

            usuarios.Add(user1);
            usuarios.Add(user2);
            usuarios.Add(user3);



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textoLogin = this.textLogin.Text;
            string textoSenha = this.textPassword.Text;

            if (string.IsNullOrWhiteSpace(textoLogin))
            {
                this.textLogin.BackColor = Color.Pink;

                MessageBox.Show("O login de usuário NÃO PODE SER VAZIO",
                    "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                this.textLogin.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(textoSenha))
            {
                this.textPassword.BackColor = Color.Pink;

                MessageBox.Show("a senha de usuário NÃO PODE SER VAZIA",
                    "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                this.textPassword.Focus();

                return;
            }

            // NO FINAL DO BTN  DEPOIS DAS VALIDAÇÕES

            usuarioEncontrado = usuarios.FirstOrDefault(
                usuario => usuario.autenticar(textoLogin, textoSenha)
            );

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuário NÃO encontrado",
                    "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                _ = MessageBox.Show($"Bem-Vindo, {usuarioEncontrado.Nome}");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        


        private void textLogin_TextChanged(object sender, EventArgs e)
        {
            this.textLogin.BackColor = Color.White;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

            this.textLogin.BackColor = Color.White;
        }

        private void Rafael(object sender, EventArgs e)
        {
            MessageBox.Show("Rafael");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
       