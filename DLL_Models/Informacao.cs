using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Models
{
    public class Informacao
    {
        private string nome;
        private string distrito;
        private string codigo_postal;
        private string rua;
        private string descricao;

        public string Nome
        {
            get { return this.nome; }
            set
            {
                if (value.Length > 0)
                    this.nome = value;
            }
        }
        public string Distrito
        {
            get { return this.distrito; }
            set
            {
                if (value.Length > 0)
                    this.distrito = value;
            }
        }
        public string Codigo_Postal
        {
            get { return this.codigo_postal; }
            set
            {
                if (value.Length > 0)
                    this.codigo_postal = value;
            }
        }
        public string Rua
        {
            get { return this.rua; }
            set
            {
                if (value.Length > 0)
                    this.rua = value;
            }
        }
        public string Descricao
        {
            get { return this.descricao; }
            set
            {
                if (value.Length > 0)
                    this.descricao = value;
            }
        }
        public Informacao(string nome, string distrito, string codigo_postal, string rua, string descricao)
        {
            this.nome = nome;
            this.distrito = distrito;
            this.codigo_postal = codigo_postal;
            this.rua = rua;
            this.descricao = descricao;
        }

        public override string ToString()
        {
            string outStr = String.Format("Nome: {0}, Distrito: {1}, Codigo-Postal: {2}, Rua: {3}, Descricao: {4}\n", Nome, Distrito, Codigo_Postal, Rua, Descricao);
            return outStr;
        }

        public void MostrarInformacao(Informacao zoo)
        {
            Console.WriteLine(zoo.ToString());
        }



    }
}
