using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using DLL_Exceptions;
using DLL_Enums;

namespace DLL_Models
{
    public class Funcionario : Pessoa
    {
        private int id;
        private int telefone;
        private TipoFuncionario especificacao;

        public static List<Funcionario> funcionarios = new List<Funcionario>();

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Telefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }
        public TipoFuncionario Especificacao
        {
            get { return this.especificacao; }

            set
            {
                if (Enum.IsDefined(typeof(TipoFuncionario), value))
                {
                    this.especificacao = value;
                }
            }
        }
        public Funcionario(int id, string nome, DateOnly data_nascimento, string email, int telefone, TipoFuncionario especificacao) : base(nome, data_nascimento, email)
        {
            this.id = id;
            this.telefone = telefone;
            this.especificacao = especificacao;
        }
        public static void AdicionarFuncionarioLista(Funcionario novo_funcionario)
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario.id == novo_funcionario.id)
                {
                    throw new FuncionarioException($"Funcionario {novo_funcionario.Nome} ja foi inserido");
                }
            }
            funcionarios.Add(novo_funcionario);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Nome: {1}, DataNascimento: {2}, Email: {3}, Telefone: {4}, Especificacao: {5}", Id, Nome, Data_nascimento, Email, Telefone, Especificacao);
            return outStr;
        }
        public static void InformacoesFuncionario()
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }
    }
}






