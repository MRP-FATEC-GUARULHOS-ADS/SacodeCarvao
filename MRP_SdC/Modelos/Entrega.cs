using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC.Modelos
{
    public class Entrega
    {
        //atributos
        public int idEntrega { get; set; }
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int quantidade { get; set; }

        public Entrega()
        {

        }

        //construtor
        public Entrega(int idProduto, string nomeProduto, int quantidade)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return this.nomeProduto.ToString();
        }
    }
}
