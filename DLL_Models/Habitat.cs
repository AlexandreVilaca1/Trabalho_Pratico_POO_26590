using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_Enums;
using DLL_Models;


namespace DLL_Models
{
    public class Habitat
    {
        private int id;
        private string nome;
        private List<Funcionario> funcionarios_habitat = new List<Funcionario>();
        private List<Animal> animais_habitat = new List<Animal>();
        private static List<Habitat> habitats = new List<Habitat>();
        private DateTime ultima_manutencao;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
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
        public DateTime Ultima_Manutencao
        {
            get { return this.ultima_manutencao; }
            set
            {
                this.ultima_manutencao = value;
            }
        }

        public Habitat(int id, string nome, DateTime ultima_manutencao)
        {
            this.id = id;
            this.nome = nome;
            this.ultima_manutencao = ultima_manutencao;
        }

        public void AdicionarFuncionariosHabitatLista(Funcionario funcionario)
        {
            funcionarios_habitat.Add(funcionario);
        }

        public void AdicionarAnimaisHabitatLista(Animal animal)
        {
            animais_habitat.Add(animal);
        }

        public static void AdicionarHabitatLista(Habitat habitat)
        {
            habitats.Add(habitat);
        }

        public int ContarAnimaisHabitat(Habitat habitat)
        {
            Console.WriteLine($"Quantidade de Animais: {animais_habitat.Count}\n");
            return animais_habitat.Count;
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Nome: {1}, Ultima Manutencaoa: {2}", Id, Nome, Ultima_Manutencao);
            return outStr;
        }

        public void MostrarInformacoesHabitat(Habitat habitat)
        {

            Console.WriteLine(habitat.ToString());

            Console.WriteLine("Funcionarios");
            foreach (var funcionario in funcionarios_habitat)
            {
                Console.WriteLine(funcionario.ToString());
            }

            Console.WriteLine("Animais");
            foreach (var animal in animais_habitat)
            {
                Console.WriteLine(animal.ToString());
            }
        }

    }

}
