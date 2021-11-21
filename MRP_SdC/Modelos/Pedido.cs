using System;
using System.Windows.Forms;

namespace MRP_SdC.Modelos
{
    class Pedido
    {
        //Atributos
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }

        //Construtores
        public Pedido()
        {

        }

        //Construtores
        public Pedido(
            int idProduto, int quantidade
         )

        {
            this.idProduto = idProduto;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return this.idPedido.ToString();
        }
    }
}
