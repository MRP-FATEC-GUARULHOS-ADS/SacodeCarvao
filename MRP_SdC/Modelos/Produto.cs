using System.Collections.Generic;

namespace MRP_SdC
{
    public class Produto
    {
        public int idTabProduto { get; set; }
        public string idProduto { get; set; }
        public string modelo { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }
        public int qtdeMin { get; set; }
        public int qtdeMax { get; set; }
        public int qtdeAtual { get; set; }
        public bool estado { get; set; }
        public List<Componente> componentes { get; set; }

        // Construtores
        public Produto()
        {

        }

        public Produto(
            string idProduto, string modelo, string descricao, double valor
        )
        {
            this.idProduto = idProduto;
            this.modelo = modelo;
            this.descricao = descricao;
            this.valor = valor;
        }

        public override string ToString()
        {
            return this.modelo;
        }

    }
}
