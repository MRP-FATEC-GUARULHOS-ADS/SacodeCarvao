using System.Collections.Generic;

namespace MRP_SdC
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string modelo { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public int qtdeAtualEstoque { get; set; }
        public int estoqueSeguranca { get; set; }
        public int leadTime { get; set; }
        public int lote { get; set; }
        public bool estado { get; set; }
        public List<Componente> componentes { get; set; }

        // Construtores
        public Produto()
        {

        }

        public Produto(
           string modelo, string descricao, int valor, int qtdeAtualEstoque, int estoqueSeguranca, 
           int leadTime, int lote
        )
        {
            this.modelo = modelo;
            this.descricao = descricao;
            this.valor = valor;
            this.qtdeAtualEstoque = qtdeAtualEstoque;
            this.estoqueSeguranca = estoqueSeguranca;
            this.leadTime = leadTime;
            this.lote = lote;
        }

        public override string ToString()
        {
            return this.modelo;
        }

    }
}
