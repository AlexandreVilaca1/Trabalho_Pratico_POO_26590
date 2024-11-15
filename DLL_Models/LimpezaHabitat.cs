using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Models
{
    public class LimpezaHabitat
    {
        private int id;
        private Habitat habitat;
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private static List<LimpezaHabitat> limpeza_habitats = new List<LimpezaHabitat>();
        private DateTime ultima_limpeza;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Habitat Habitat
        {
            get { return this.habitat; }
            set { this.habitat = value; }
        }

        public DateTime Ultima_Limpeza
        {
            get { return this.ultima_limpeza; }
            set { this.ultima_limpeza = value; }
        }

        public LimpezaHabitat(int id, Habitat habitat, DateTime ultima_limpeza)
        {
            this.id = id;
            this.habitat = habitat;
            this.ultima_limpeza = ultima_limpeza;
        }
        public static void AdiocionarLimpezaHabitatLista(LimpezaHabitat limpezaHabitat)
        {
            limpeza_habitats.Add(limpezaHabitat);
        }
        public void AdicionarFuncionarioLimpezaLista(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Habitat: {1}, Ultima Limpeza: {2}", Id, Habitat.Nome, Ultima_Limpeza);
            return outStr;
        }

        public void MostrarInformacaoLimpezaHabitats(LimpezaHabitat limpezaHabitat)
        {
            Console.WriteLine(limpezaHabitat.ToString());
            Console.WriteLine("Funcionarios Responsaveis:");

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }
    }
}
