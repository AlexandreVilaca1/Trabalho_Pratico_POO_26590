using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using DLL_Enums;
using DLL_Models;

namespace Projeto_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zoo
            Console.WriteLine("Zoo");
            Informacao zoo = new Informacao("Zoo Braga", "Braga", "4705-194", "rua dos congregados", "Melhor zoo do país, com maior diversidade de animais");
            zoo.MostrarInformacao(zoo);

            //Alimentacao
            Alimentacao alimentacao1 = new Alimentacao(400, 2, TipoComida.Carne, DateTime.Parse("2024-12-14 11:40"));
            Alimentacao alimentacao2 = new Alimentacao(150, 4, TipoComida.Fruta, DateTime.Parse("2024-12-14 16:30"));

            //Animais
            Console.WriteLine("Lista de Animais");
            Animal animal1 = new Animal(1, TipoAnimal.Hipopotamo, "Hipo", DateOnly.Parse("2021-09-24"), Grupo.Mamute);
            Animal animal2 = new Animal(2, TipoAnimal.Golfinho, "Golfu", DateOnly.Parse("2019-07-16"), Grupo.Peixe);
            Animal animal3 = new Animal(3, TipoAnimal.Canario, "Paulo", DateOnly.Parse("2022-09-11"), Grupo.Ave);
            //Animal.LerFicheiro("../../../TxtFiles/animais.txt");
            Animal.AdicionarAnimalFicheiro(animal1);
            Animal.AdicionarAnimalFicheiro(animal2);
            Animal.AdicionarAnimalFicheiro(animal3);
            Animal.AdicionarAnimalLista(animal1);
            Animal.AdicionarAnimalLista(animal2);
            Animal.AdicionarAnimalLista(animal3);
            animal2.AtualizarAnimalFicheiro(2, TipoAnimal.Golfinho, "golfi", DateOnly.Parse("2019-07-16"), Grupo.Peixe);
            Animal.InformacoesAnimal();
            animal1.AdicionarAlimentacaoAnimalLista(alimentacao1);
            animal1.AdicionarAlimentacaoAnimalLista(alimentacao2);
            animal1.MostrarAlimentacaoAnimal(animal1);
            Console.WriteLine("\n");

            //Funcionarios
            Console.WriteLine("Lista de Funcionarios");
            Funcionario funcionario1 = new Funcionario(1, "Alexandre", DateOnly.Parse("2001-02-14"), "alexandrepv1357@gmail.com", 910543931, TipoFuncionario.Cuidador);
            Funcionario funcionario2 = new Funcionario(2, "Mafalada", DateOnly.Parse("1999-08-11"), "mafalda99@gmail.com", 967231780, TipoFuncionario.Veternario);
            Funcionario funcionario3 = new Funcionario(3, "Pedro", DateOnly.Parse("1987-06-08"), "pedro@outlook.pt", 914790531, TipoFuncionario.Cuidador);
            Funcionario funcionario4 = new Funcionario(4, "Ricardo", DateOnly.Parse("1992-01-25"), "ricardo@outlook.pt", 924539214, TipoFuncionario.Limpeza);
            Funcionario.AdicionarFuncionarioLista(funcionario1);
            Funcionario.AdicionarFuncionarioLista(funcionario2);
            Funcionario.AdicionarFuncionarioLista(funcionario3);
            Funcionario.AdicionarFuncionarioLista(funcionario4);
            Funcionario.InformacoesFuncionario();
            Console.WriteLine("\n");

            //Habitats
            Console.WriteLine("Lista de Habitats");
            Habitat habitat1 = new Habitat(1, "Floresta Tropical Passaros", DateTime.Parse("2024-12-02 11:25"));
            Habitat habitat2 = new Habitat(1, "Piscina Golfinhos", DateTime.Parse("2024-12-03 17:45"));
            habitat1.AdicionarAnimaisHabitatLista(animal3);
            habitat1.AdicionarFuncionariosHabitatLista(funcionario3);
            habitat2.AdicionarAnimaisHabitatLista(animal2);
            habitat2.AdicionarFuncionariosHabitatLista(funcionario1);
            Habitat.AdicionarHabitatLista(habitat1);
            habitat1.MostrarInformacoesHabitat(habitat1);
            habitat1.ContarAnimaisHabitat(habitat1);
            habitat2.MostrarInformacoesHabitat(habitat2);
            habitat2.ContarAnimaisHabitat(habitat2);

            //Limpeza Habitats
            Console.WriteLine("Lista das Limpezas Realizadas");
            LimpezaHabitat limpezaHabitat1 = new LimpezaHabitat(1, habitat1, DateTime.Parse("2024-12-03 14:30"));
            limpezaHabitat1.AdicionarFuncionarioLimpezaLista(funcionario4);
            LimpezaHabitat.AdiocionarLimpezaHabitatLista(limpezaHabitat1);
            limpezaHabitat1.MostrarInformacaoLimpezaHabitats(limpezaHabitat1);
            Console.WriteLine("\n");



            //Assistencia Animais
            Console.WriteLine("Assistencia de animais");
            AssistenciaVeternaria assistenciaVeternaria1 = new AssistenciaVeternaria(1, DateTime.Parse("2024-11-16 14:30"), TipoAssistencia.Rotina, "Animal com pouca vontade de comer, possivelmente devido a congestão nasal");
            assistenciaVeternaria1.AdicionarFuncionarioAssistenciaLista(funcionario2);
            assistenciaVeternaria1.AdicionarAnimalAssistenciaLista(animal1);
            assistenciaVeternaria1.MostrarInformacoesAssistenciasVeternarias(assistenciaVeternaria1);
            AssistenciaVeternaria.AdicionarAssistenciaVeternariasLista(assistenciaVeternaria1);
            Console.WriteLine("\n");

            //Clientes
            Console.WriteLine("Lista de Clientes");
            Cliente cliente1 = new Cliente("Miguel", DateOnly.Parse("1992-07-19"), "miguel@outllok.pt", Tipo.Novo, DateOnly.Parse("2024-10-31"));
            Cliente cliente2 = new Cliente("Maria", DateOnly.Parse("2001-03-24"), "maria@gmail.com", Tipo.Socio, DateOnly.Parse("2022-11-04"));
            Cliente.AdicionarClienteLista(cliente1);
            Cliente.AdicionarClienteLista(cliente2);
            Cliente.InformacoesCliente();
            Console.WriteLine("\n");

            //Espetaculos
            Console.WriteLine("Espetaculos");
            Espetaculo espetaculoGolfinhos1 = new Espetaculo(1, DateTime.Parse("2024-12-01 15:30"), "Espetaculo Golfinhos", TimeSpan.Parse("02:30:00"), TipoEspetaculo.Golfinhos);
            espetaculoGolfinhos1.AdicionarAnimalEspetaculoLista(animal2);
            espetaculoGolfinhos1.AdicionarFuncionarioEspetaculoLista(funcionario1);
            espetaculoGolfinhos1.AdicionarClienteEspetaculoLista(cliente1);
            Espetaculo.AdicionarEspetaculoLista(espetaculoGolfinhos1);
            espetaculoGolfinhos1.MostrarInformacoesEspetaculo(espetaculoGolfinhos1);
            Console.WriteLine("\n");

            //Bilhetes
            Console.WriteLine("Bilhetes");
            Bilhete bilheteGolfinhos1 = new Bilhete(1, 10, DateTime.Parse("2024-11-30 10:40"), "B16", cliente1, espetaculoGolfinhos1);
            Bilhete.AdicionarBilheteLista(bilheteGolfinhos1);
            Bilhete.MostrarBilhetes();
            Console.WriteLine("\n");
        }
    }
}


