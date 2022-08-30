using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC.Modelos
{
    class PrevisaoDemanda
    {
        //Atributos
        public int idPrevisaoDemanda { get; set; }
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int quantidade { get; set; }
        public int semana { get; set; }

        public PrevisaoDemanda()
        {

        }

        //Construtor 
        public PrevisaoDemanda(int idProduto, string nomeProduto, int quantidade, int semana)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.quantidade = quantidade;
            this.semana = semana;
        }

        public override string ToString()
        {
            return this.idPrevisaoDemanda.ToString();
        }
    }
}
