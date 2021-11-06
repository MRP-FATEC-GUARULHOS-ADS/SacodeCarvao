namespace MRP_SdC
{
    public class MPS
    {
        //Atributos
        public int idProducao { get; set; }
        public int idProduto { get; set; }
        public int quantidadeemMaos { get; set; }
        public int quantidadeDisponivel { get; set; }
        public int quantidadeDemanda { get; set; }
        public int quantidadeProduzir { get; set; }

        public MPS()
        {

        }
        //Construtores
        public MPS(
            int idProduto, int quantidadeemMaos, int quantidadeDisponivel,
            int quantidadeDemanda, int quantidadeProduzir
        )
        {
            this.idProducao = idProducao;
            this.idProduto = idProduto;
            this.quantidadeemMaos = quantidadeemMaos;
            this.quantidadeDisponivel = quantidadeDisponivel;
            this.quantidadeDemanda = quantidadeDemanda;
            this.quantidadeProduzir = quantidadeProduzir;
        }
    }
}
