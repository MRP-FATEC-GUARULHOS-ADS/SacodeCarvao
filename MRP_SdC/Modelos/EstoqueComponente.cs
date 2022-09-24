using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC.Modelos
{
    public class EstoqueComponente
    {
        public int idEstoqueComponente { get; set; }
        public int idComponente { get; set; }
        public string modeloComponente { get; set; }
        public int qtdeAtualEstoque { get; set; }
        public int estoqueSeguranca { get; set; }
        public int leadTime { get; set; }
        public int lote { get; set; }

        //Construtores
        public EstoqueComponente()
        {

        }

        public EstoqueComponente(int idComponente, string modeloComponente, int qtdeAtualEstoque, int estoqueSeguranca,
        int leadTime, int lote)
        {
            this.idComponente = idComponente;
            this.modeloComponente = modeloComponente;
            this.qtdeAtualEstoque = qtdeAtualEstoque;
            this.estoqueSeguranca = estoqueSeguranca;
            this.leadTime = leadTime;
            this.lote = lote;
        }

        public override string ToString()
        {
            return this.modeloComponente;
        }
    }
}
