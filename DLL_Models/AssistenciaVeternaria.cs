using DLL_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_Enums;

namespace DLL_Models
{
    public class AssistenciaVeternaria
    {
        private int id;
        private List<Animal> animais_assistencia = new List<Animal>();
        private List<Funcionario> funcionarios_assistencia = new List<Funcionario>();
        private static List<AssistenciaVeternaria> assistencia_veternarias = new List<AssistenciaVeternaria>();
        private DateTime data_assistencia;
        private TipoAssistencia tipo_assistencia;
        private string relatorio;

        public int Id
        {

            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime Data_Assistencia
        {
            get { return this.data_assistencia; }
            set
            {
                this.data_assistencia = value;
            }
        }

        public TipoAssistencia Tipo_Assistencia
        {
            get { return this.tipo_assistencia; }
            set
            {
                this.tipo_assistencia = value;
            }
        }

        public string Relatorio
        {
            get { return this.relatorio; }
            set
            {
                if (value.Length > 0)
                {

                    this.relatorio = value;
                }
            }
        }

        public AssistenciaVeternaria(int id, DateTime data_assistencia, TipoAssistencia tipo_assistencia, string relatorio)
        {
            this.id = id;
            this.data_assistencia = data_assistencia;
            this.tipo_assistencia = tipo_assistencia;
            this.relatorio = relatorio;
        }

        public void AdicionarAnimalAssistenciaLista(Animal animal)
        {
            animais_assistencia.Add(animal);
        }

        public void AdicionarFuncionarioAssistenciaLista(Funcionario funcionario)
        {
            funcionarios_assistencia.Add(funcionario);
        }

        public static void AdicionarAssistenciaVeternariasLista(AssistenciaVeternaria nova_assistencia)
        {
            assistencia_veternarias.Add(nova_assistencia);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Data Assistencia: {1}, Tipo de Assistencia: {2}, Relatorio: {3}", Id, Data_Assistencia, Tipo_Assistencia, Relatorio);
            return outStr;
        }

        public void MostrarInformacoesAssistenciasVeternarias(AssistenciaVeternaria assistenciaVeternaria)
        {
            Console.WriteLine(assistenciaVeternaria.ToString());


            Console.WriteLine("Animais Assistidos");
            foreach (var animal in animais_assistencia)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine("Funcionários Responsáveis:");
            foreach (var funcionario in funcionarios_assistencia)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }

    }
}
