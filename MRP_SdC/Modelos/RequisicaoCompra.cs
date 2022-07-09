using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC.Modelos
{
    //nova classe de requisição de compras.
    class RequisicaoCompra
    {
        //atributos.
        public int idReqCompra { get; set; }
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int quantidade { get; set; }

        //Método Construtor.
        public RequisicaoCompra(int idProduto, string nomeProduto, int quantidade)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.quantidade = quantidade;
        }

        //Método override.
        public override string ToString()
        {
            return this.nomeProduto.ToString();
        }
    }
}
