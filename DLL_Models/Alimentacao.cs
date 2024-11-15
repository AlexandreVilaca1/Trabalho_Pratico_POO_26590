using DLL_Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Models
{
    public class Alimentacao
    {
        private int calorias;
        private int quantidade;
        private TipoComida tipo_comida;
        private DateTime data_refeicao;

        public int Calorias
        {
            get { return this.calorias; }
            set { this.calorias = value; }
        }

        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public TipoComida Tipo_Comida
        {
            get { return this.tipo_comida; }
            set { this.tipo_comida = value; }
        }

        public DateTime Data_Refeicao
        {
            get { return this.data_refeicao; }
            set { this.data_refeicao = value; }
        }

        public Alimentacao(int calorias, int quantidade, TipoComida tipo_comida, DateTime data_refeicao)
        {
            this.calorias = calorias;
            this.quantidade = quantidade;
            this.tipo_comida = tipo_comida;
            this.data_refeicao = data_refeicao;
        }

        public override string ToString()
        {

            string outStr = String.Format("Calorias: {0}, Quantidade: {1}, Tipo Comida: {2}, Data Refeicao: {3}", Calorias, Quantidade, Tipo_Comida, Data_Refeicao);
            return outStr;

        }

    }


    //Metodo para calcular as calorias
}
