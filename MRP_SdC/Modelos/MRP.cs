namespace MRP_SdC
{
    public class MRP
    {
        //Atributos
        public int idMRP { get; set; }
        public int idMPS { get; set; }
        public int idProduto { get; set; }
        public string nome { get; set; }
        public int quantidadePedido { get; set; }
        public int quantidadeEstoque { get; set; }
        public int quantidadeFinal { get; set; }

        //Construtores
        public MRP()
        {

        }

        //Construtores
        public MRP(
            int idMPS, int idProduto, string nome, int quantidadePedido, 
            int quantidadeEstoque, int quantidadeFinal
        )

        {
            this.idMPS = idMPS;
            this.idProduto = idProduto;
            this.nome = nome;
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
