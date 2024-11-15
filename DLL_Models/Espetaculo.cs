using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_Enums;
using DLL_Models;

namespace DLL_Models
{
    public class Espetaculo
    {
        private int id;
        private DateTime data;
        private string nome;
        private List<Animal> animais_espetaculo = new List<Animal>();
        private List<Funcionario> funcionarios_espetaculo = new List<Funcionario>();
        private List<Cliente> clientes_espetaculo = new List<Cliente>();
        private static List<Espetaculo> espetaculos = new List<Espetaculo>();
        private TimeSpan duracao;
        private TipoEspetaculo tipo_espetaculo;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set
            {
                if (value.Length > 0)
                    this.nome = value;
            }
        }
        public TimeSpan Duracao
        {
            get { return this.duracao; }
            set
            {
                this.duracao = value;
            }
        }
        public TipoEspetaculo Tipo_Espetaculo
        {
            get
            {
                return this.tipo_espetaculo;

            }
            set

            {
                this.tipo_espetaculo = value;
            }
        }


        public Espetaculo(int id, DateTime data, string nome, TimeSpan duracao, TipoEspetaculo tipo_Espetaculo)
        {
            this.id = id;
            this.data = data;
            this.nome = nome;
            this.duracao = duracao;
            this.tipo_espetaculo = tipo_Espetaculo;
        }
        public void AdicionarAnimalEspetaculoLista(Animal animal)
        {
            animais_espetaculo.Add(animal);
        }
        public void AdicionarFuncionarioEspetaculoLista(Funcionario funcionario)
        {
            funcionarios_espetaculo.Add(funcionario);
        }
        public void AdicionarClienteEspetaculoLista(Cliente cliente)
        {
            clientes_espetaculo.Add(cliente);
        }

        public static void AdicionarEspetaculoLista(Espetaculo espetaculo)
        {
            espetaculos.Add(espetaculo);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Nome: {1}, Data: {2}, Duracao: {3}", Id, Nome, Data, Duracao);
            return outStr;
        }
        public void MostrarInformacoesEspetaculo(Espetaculo espetaculo)
        {

            Console.WriteLine(espetaculo.ToString());


            Console.WriteLine("Animais Participantes:");
            foreach (var animal in animais_espetaculo)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine("Funcionários Responsáveis:");
            foreach (var funcionario in funcionarios_espetaculo)
            {
                Console.WriteLine(funcionario.ToString());
            }

            Console.WriteLine("Clientes a assistir:");
            foreach (var cliente in clientes_espetaculo)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
    }


}
