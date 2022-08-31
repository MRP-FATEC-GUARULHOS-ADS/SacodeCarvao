using System.Collections.Generic;

namespace MRP_SdC
{
    public class MPS
    {
        //Atributos
        public int idMPS { get; set; }
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int quantidadePedido { get; set; }
        public int quantidadePrevisaoDemanda { get; set; }
        public int quantidadeDemandaConsiderada { get; set; }
        public int estoqueAtual { get; set; }
        public int planoMestreProducao { get; set; }
        public int semana { get; set; }

        //Construtores
        public MPS()
        {

        }

        //Construtores
        public MPS(
            int idProduto, string nomeProduto, int quantidadePedido, int quantidadePrevisaoDemanda,
            int quantidadeDemandaConsiderada, int estoqueAtual, int PlanoMestreProducao, int semana
        )

        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.quantidadePedido = quantidadePedido;
            this.quantidadePrevisaoDemanda = quantidadePrevisaoDemanda;
            this.quantidadeDemandaConsiderada = quantidadeDemandaConsiderada;
            this.estoqueAtual = estoqueAtual;
            this.planoMestreProducao = PlanoMestreProducao;
            this.semana = semana;
        }

        public override string ToString()
        {
            return this.idMPS.ToString();
        }
    }
}
