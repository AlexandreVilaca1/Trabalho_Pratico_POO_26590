using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_Enums;
using DLL_Exceptions;


namespace DLL_Models
{
    public class Cliente : Pessoa
    {
        private Tipo tipo;
        private DateOnly data_registo;
        private static List<Cliente> clientes = new List<Cliente>();


        public Tipo Tipo_Cliente
        {
            get
            {
                return this.tipo;
            }

            set
            {
                if (Enum.IsDefined(typeof(Tipo), value))
                {
                    this.tipo = value;
                }
            }
        }

        public DateOnly Data_Registo
        {
            get { return data_registo; }
            set
            {
                this.Data_Registo = value;
            }

        }

        public Cliente(string nome, DateOnly data_nascimento, string email, Tipo tipo, DateOnly data_registo) : base(nome, data_nascimento, email)
        {
            this.tipo = tipo;
            this.data_registo = data_registo;
        }

        public static void AdicionarClienteLista(Cliente novo_cliente)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Nome == novo_cliente.Nome && cliente.Email == novo_cliente.Email)
                {
                    throw new ClienteException($"Cliente {novo_cliente.Nome} ja foi inserido");
                }
            }
            clientes.Add(novo_cliente);
        }

        public override string ToString()
        {
            string outStr = String.Format("Nome: {0}, DataNascimento: {1}, Email: {2}, Tipo: {3}, DataRegisto: {4}", Nome, Data_nascimento, Email, Tipo_Cliente, Data_Registo);
            return outStr;
        }
        public static void InformacoesCliente()
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

    }
}
