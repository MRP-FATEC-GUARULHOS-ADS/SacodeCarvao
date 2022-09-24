using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC.Modelos
{
    public class EstoqueProduto
    {
        public int idEstoqueProduto { get; set; }
        public int idProduto { get; set; }
        public string modeloProduto { get; set; }
        public int qtdeAtualEstoque { get; set; }
        public int estoqueSeguranca { get; set; }
        public int leadTime { get; set; }
        public int lote { get; set; }

        //Construtores
        public EstoqueProduto()
        {

        }

        public EstoqueProduto(int idProduto, string modeloProduto, int qtdeAtualEstoque, int estoqueSeguranca,
        int leadTime, int lote)
        {
            this.idProduto = idProduto;
            this.modeloProduto = modeloProduto;
            this.qtdeAtualEstoque = qtdeAtualEstoque;
            this.estoqueSeguranca = estoqueSeguranca;
            this.leadTime = leadTime;
            this.lote = lote;
        }

        public override string ToString()
        {
            return this.modeloProduto;
        }
    }
}
