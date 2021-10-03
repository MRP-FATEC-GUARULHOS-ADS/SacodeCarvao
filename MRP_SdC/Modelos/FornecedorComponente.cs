namespace MRP_SdC
{
    public class FornecedorComponente
    {
        public Fornecedor fornecedor { get; set; }
        public Componente componente { get; set; }
        public int leadTime { get; set; }
        public double custo { get; set; }

        public FornecedorComponente () { }

        public FornecedorComponente (
            Fornecedor fornecedor, Componente componente,
            int leadTime, double custo
        ) {
            this.fornecedor = fornecedor;
            this.componente = componente;
            this.leadTime = leadTime;
            this.custo = custo;
        }

        public override string ToString()
        {
            return (this.fornecedor.ToString() + this.componente.ToString());
        }
    }
}
