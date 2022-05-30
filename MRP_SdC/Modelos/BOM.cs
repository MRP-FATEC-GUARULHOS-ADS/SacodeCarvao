namespace MRP_SdC
{
    public class BOM
    {
        //atributos
        public int idBOM { get; set; }
        public int noProduto { get; set; }
        public int noPai { get; set; }
        public int noFilho { get; set; }
        public int codigoLista { get; set; }
        public string nome { get; set; }
        public int nivel { get; set; }
        public int quantidadeLista { get; set; }

        public BOM()
        {

        }

        //construtores
        public BOM(
            int noPai, int noFilho, int codigoLista, string nome, int nivel, int quantidadeLista,
            int noProduto
        )

        {
            this.noProduto = noProduto;
            this.noPai = noPai;
            this.noFilho = noFilho;
            this.codigoLista = codigoLista;
            this.nome = nome;
            this.nivel = nivel;
            this.quantidadeLista = quantidadeLista;
        }

        public override string ToString()
        {
            return this.nome.ToString();
        }
    }  
}
