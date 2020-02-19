using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBusPOA.model
{
    class User
    {
        private int id;
        private string nome;
        private string senha;

        public int getID()
        {
            Random random = new Random();
            return random.Next(0, 999);
        }

        public String getNome()
        {
            return this.nome;
        }
        public String getSenha()
        {
            return this.senha;
        }

        public User(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }

        public User(int id, string nome, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
        }

        public User() { }

    }
}
