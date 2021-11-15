using System;
using System.Windows.Forms;

namespace MRP_SdC.Modelos
{
    class Pedido
    {
        //Atributos
        public int idtabpedido { get; set; }
        public string idPedido { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }

        //Construtores
        public Pedido()
        {

        }

        //Construtores
        public Pedido(
            string idPedido, int idProduto, int quantidade
         )

        {
            this.idPedido = idPedido;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return this.idtabpedido.ToString();
        }
    }
}
