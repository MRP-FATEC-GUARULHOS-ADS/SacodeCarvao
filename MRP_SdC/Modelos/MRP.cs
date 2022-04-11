namespace MRP_SdC
{
    public class MRP
    {
        //Atributos
        public int idMRP { get; set; }
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public int quantidadePedido { get; set; }
        public int quantidadeEstoque { get; set; }
        public int quantidadeFinal { get; set; }

        //Construtores
        public MRP()
        {

        }

        //Construtores
        public MRP(
            int idPedido, int idProduto, int quantidadePedido, 
            int quantidadeEstoque, int quantidadeFinal
        )

        {
            this.idPedido = idPedido;
            this.idProduto = idProduto;
            this.quantidadePedido = quantidadePedido;
            this.quantidadeEstoque = quantidadeEstoque;
            this.quantidadeFinal = quantidadeFinal;

        }

        public override string ToString()
        {
            return this.idProduto.ToString();
        }
    }
}
