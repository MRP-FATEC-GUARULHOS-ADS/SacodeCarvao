namespace MRP_SdC.Modelos
{
    class Pedido
    {
        //Atributos
        public string idPedido;
        public int idProduto;
        public int quantidade;

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
            return this.idPedido.ToString();
        }
    }
}
