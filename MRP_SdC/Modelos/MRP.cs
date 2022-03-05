namespace MRP_SdC
{
    public class MRP
    {
        //Atributos
        public int idMRP { get; set; }
        public int idPedido { get; set; }
        public int idBom { get; set; }
        public int idProduto { get; set; }
        public int quantidadePedido { get; set; }
        public int quantidadeBom { get; set; }
        public int quantidadeFinal { get; set; }

        //Construtores
        public MRP()
        {

        }

        //Construtores
        public MRP(
            int idPedido, int idBom, int idProduto, int quantidadePedido, 
            int quantidadeBom, int quantidadeFinal
        )

        {
            this.idPedido = idPedido;
            this.idBom = idBom;
            this.idProduto = idProduto;
            this.quantidadePedido = quantidadePedido;
            this.quantidadeBom = quantidadeBom;
            this.quantidadeFinal = quantidadeFinal;

        }

        public override string ToString()
        {
            return this.idProduto.ToString();
        }
    }
}
