using System.Collections.Generic;

namespace MRP_SdC
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string modelo { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
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
           string modelo, string descricao, int valor
        )
        {
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
