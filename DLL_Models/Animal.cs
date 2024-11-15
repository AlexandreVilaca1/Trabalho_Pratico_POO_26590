using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_Models;
using DLL_Exceptions;
using DLL_Enums;

namespace DLL_Models
{
    public class Animal
    {
        #region Private Properties
        private int id;
        private TipoAnimal tipo;
        private string nome;
        private DateOnly data_nascimento;
        private Grupo grupo; //Aquatico, terrestre, aério
        private static List<Animal> animais = new List<Animal>(); //Lista estatica esta referenciada a todos os animais enquanto que uma lista não estática está só relacionada a um objeto.
        private List<Alimentacao> dieta_animais = new List<Alimentacao>();

        #endregion

        #region Public Properties
        // if (user has permissions to see the age)
        public int Id
        {

            get { return this.id; }  //retorna o valor da propriedade privada e coloca na variavel publica
            set { this.id = value; } //Altera o valor da propriedade privada pelo value
        }

        public string Nome
        {
            get
            {
                return this.nome; //retorna o valor da propriedade privada e coloca na publica
            }
            set
            {
                if (value.Length > 0) //verifica se não é uma string vazia
                {
                    this.nome = value; //O value toma um valor quando temos person1.Name = "Maria", quanto estamos a modificar o valor
                }
            }
        }

        public TipoAnimal Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public DateOnly Data_Nascimento
        {
            get { return this.data_nascimento; }
            set { this.data_nascimento = value; }
        }

        public Grupo Grupo
        {
            get
            {
                return this.grupo;
            }
            set
            {
                if (Enum.IsDefined(typeof(Grupo), value))
                {
                    this.grupo = value;
                }
            }
        }
        #region  Constructor
        public Animal(int id, TipoAnimal tipo, string nome, DateOnly data_nascimento, Grupo grupo)
        {
            this.id = id;
            this.tipo = tipo;
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.grupo = grupo;
        }
        #endregion
        //public static void LerFicheiro(string filePath)
        //{

        //    try
        //    {
        //        foreach (var line in File.ReadLines(filePath))
        //        {
        //            var parts = line.Split(',');

        //            if (parts.Length == 5)
        //            {
        //                int id = int.Parse(parts[0]);
        //                string tipo = parts[1]; 
        //                string nome = parts[2]; 
        //                DateOnly data_nascimento = DateOnly.Parse(parts[3]);
        //                Grupo grupo = (Grupo)Enum.Parse(typeof(Grupo), parts[4]); 

        //                // Criar um novo objeto funcionario e adicionar à lista
        //                var animal = new Animal(id, tipo, nome, data_nascimento, grupo);
        //                animais.Add(animal);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Erro ao ler o ficheiro: {ex.Message}");
        //    }
        //}
        public static bool AdicionarAnimalLista(Animal novo_animal)
        {
            // Verificação
            foreach (var animal in animais)
            {
                if (animal.id == novo_animal.id && animal.nome == novo_animal.nome)
                {
                    throw new AnimalException($"Animal {novo_animal.Nome} ja foi inserido");
                }
            }
            animais.Add(novo_animal);
            return true;
        }

        public void AdicionarAlimentacaoAnimalLista(Alimentacao alimentacao)
        {
            dieta_animais.Add(alimentacao);
        }
        public static void AdicionarAnimalFicheiro(Animal novo_animal)
        {
            if (File.Exists("../../../TxtFiles/animais.txt"))
            {
                var lines = File.ReadAllLines("../../../TxtFiles/animais.txt");

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length > 0 && int.TryParse(data[0], out int idFicheiro) && idFicheiro == novo_animal.id)
                    {
                        throw new AnimalException($"Animal {novo_animal.Nome} ja foi inserido no ficheiro");
                    }
                }
            }
            try
            {
                using (StreamWriter sw = File.AppendText("../../../TxtFiles/animais.txt"))
                {
                    sw.WriteLine($"{novo_animal.Id},{novo_animal.Tipo},{novo_animal.Nome},{novo_animal.Data_Nascimento},{novo_animal.Grupo}");
                }
            }
            catch (FicheiroException)
            {
                throw new FicheiroException("Nao foi possivel adicionar o animal ao ficheiro");
            }
        }
        public void AtualizarAnimalFicheiro(int id, TipoAnimal tipo, string nome, DateOnly data_nascimento, Grupo grupo)
        {

            var animal_a_atualizar = animais.Find(t => t.Id.Equals(id));
            if (animal_a_atualizar != null)
            {

                animal_a_atualizar.Tipo = tipo;
                animal_a_atualizar.Nome = nome;
                animal_a_atualizar.Data_Nascimento = data_nascimento;
                animal_a_atualizar.Grupo = grupo;

                try
                {
                    var lines = new List<string>();
                    foreach (var animal in animais)
                    {
                        lines.Add($"{animal.Id},{animal.Tipo},{animal.Nome},{animal.Data_Nascimento},{animal.Grupo}");
                    }

                    File.WriteAllLines("../../../TxtFiles/animais.txt", lines);
                }
                catch (FicheiroException)
                {
                    throw new FicheiroException("Nao foi possivel atualizar o ficheiro");
                }
            }
            else
            {
                throw new AnimalException($"Animal nao encontrado");
            }
        }
        public override string ToString()
        {

            string outStr = String.Format("Id: {0}, Tipo: {1}, Nome: {2}, DataNascimento: {3}, Grupo: {4}", Id, Tipo, Nome, Data_Nascimento, Grupo);
            return outStr;

        }

        public static void InformacoesAnimal()
        {
            foreach (var animal in animais)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        public void MostrarAlimentacaoAnimal(Animal animal)
        {
            Console.WriteLine($"Alimentacao Animal {animal.id}:");
            foreach (var alimentacao in dieta_animais)
            {
                Console.WriteLine(alimentacao.ToString());
            }
        }
    }

    #endregion
}

