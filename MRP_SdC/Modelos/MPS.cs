using System.Collections.Generic;

namespace MRP_SdC
{
    public class MPS
    {
        //Atributos
        public string idMPS { get; set; }
        public int idProduto { get; set; }
        public int quantidadeemMaos { get; set; }
        public int quantidadeDisponivel { get; set; }
        public int quantidadeDemanda { get; set; }
        public int quantidadeProduzir { get; set; }

        //Construtores
        public MPS()
        {

        }

        //Construtores
        public MPS(
            int idProduto, int quantidadeemMaos, int quantidadeDisponivel,
            int quantidadeDemanda, int quantidadeProduzir
        )

        {
            this.idProduto = idProduto;
            this.quantidadeemMaos = quantidadeemMaos;
            this.quantidadeDisponivel = quantidadeDisponivel;
            this.quantidadeDemanda = quantidadeDemanda;
            this.quantidadeProduzir = quantidadeProduzir;
        }

        public override string ToString()
        {
            return this.idMPS.ToString();
        }
    }
}
