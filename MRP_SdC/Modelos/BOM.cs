namespace MRP_SdC
{
    public class BOM
    {
        //atributos
        public int idBOM { get; set; }
        public string saidaFinal { get; set; }
        public int idProduto { get; set; }
        public string categoria { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public int custoUnidade { get; set; }

        public BOM()
        {

        }

        //construtores
        public BOM(
            string saidaFinal, int idProduto, string categoria, string nome, int quantidade, int custoUnidade
        )

        {
            this.saidaFinal = saidaFinal;
            this.idProduto = idProduto;
            this.categoria = categoria;
            this.nome = nome;
            this.quantidade = quantidade;
            this.custoUnidade = custoUnidade;
        }

        public override string ToString()
        {
            return this.idProduto.ToString();
        }
    }  
}
