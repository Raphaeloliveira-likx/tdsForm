using ProjetoForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Classes
{
    public class login
    {
        private int id;
        private string userLogin;
        private string userPassword;
        private string userProfile;
        private string nome;

        public login(int id, string userLogin, string userPassword, string userProfile, string nome)
        {
            this.id = id;
            this.userLogin = userLogin;
            this.userPassword = userPassword;
            this.userProfile = userProfile;
            this.nome = nome;
        }
        public int Id { get => id; set => id = value; }
        public string UserLogin { get => userLogin; set => userLogin = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserProfile { get => userProfile; set => userProfile = value; }
        public string Nome { get => nome; set => nome = value; }


        public bool autenticar(string username, string password)
        {

            return username == this.userLogin && password == this.userPassword;

        }
    }
}