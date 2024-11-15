using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Models
{
    abstract public class Pessoa
    {
        private string nome;
        private DateOnly data_nascimento;
        private string email;

        public string Nome
        {
            get { return this.nome; }
            set
            {
                if (value.Length > 0)
                {
                    this.nome = value;
                }
            }
        }
        public DateOnly Data_nascimento
        {
            get { return this.data_nascimento; }
            set
            {
                this.data_nascimento = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.Length > 0)
                {
                    this.email = value;
                }
            }
        }
        public Pessoa(string nome, DateOnly data_nascimento, string email)
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.email = email;
        }
        public abstract string ToString();
    }

}
