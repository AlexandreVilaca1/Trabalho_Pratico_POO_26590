using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_Enums;

namespace DLL_Models
{
    public class Bilhete
    {
        private int id;
        private DateTime data_emissao;
        private decimal preco;
        private string numero_assento;
        private Cliente cliente;
        private Espetaculo espetaculo;
        private static List<Bilhete> bilhetes = new List<Bilhete>();


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

        public decimal Preco
        {
            get
            {
                return this.preco;
            }
            set
            {
                this.preco = value;
            }
        }
        public DateTime Data_Emissao
        {
            get
            {
                return this.data_emissao;
            }
            set
            {
                this.data_emissao = value;
            }
        }
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
            }
        }
        public Espetaculo Espetaculo
        {
            get
            {
                return this.espetaculo;
            }
            set
            {
                this.espetaculo = value;
            }
        }
        public string Numero_Assento
        {
            get
            {
                return this.numero_assento;
            }
            set
            {
                this.numero_assento = value;
            }
        }
        public Bilhete(int id, decimal preco, DateTime data_emissao, string numero_assento, Cliente cliente, Espetaculo espetaculo)
        {
            this.id = id;
            this.preco = preco;
            this.data_emissao = data_emissao;
            this.numero_assento = numero_assento;
            this.cliente = cliente;
            this.espetaculo = espetaculo;
        }

        public static void AdicionarBilheteLista(Bilhete novo_bilhete)
        {
            bilhetes.Add(novo_bilhete);
        }
        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Preco: {1}, DataEmissao: {2}, NumeroAssento: {3}, Cliente: {4}, TipoEspetaculo: {5}", Id, Preco, Data_Emissao, Numero_Assento, Cliente.Nome, Espetaculo.Tipo_Espetaculo);
            return outStr;
        }
        public static void MostrarBilhetes()
        {
            foreach (var bilhete in bilhetes)
            {
                Console.WriteLine(bilhete.ToString());
            }
        }
    }
}
