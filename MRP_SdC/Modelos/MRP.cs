namespace MRP_SdC
{
    public class MRP
    {
        //Atributos
        public int idNecesLiq { get; set; }
        public int idProduto { get; set; }
        public int qntdPedido { get; set; }
        public int qntdEstoque { get; set; }
        public int qntdNecesLiq { get; set; }

        //Construtores
        public MRP()
        {

        }

        //Construtores
        public MRP(
            int idProduto, int qntdPedido, int qntdEstoque,
            int qntdNecesLiq
        )

        {
            this.idProduto = idProduto;
            this.qntdPedido = qntdPedido;
            this.qntdEstoque = qntdEstoque;
            this.qntdNecesLiq = qntdNecesLiq;

        }

        public override string ToString()
        {
            return this.idProduto.ToString();
        }
    }
}
