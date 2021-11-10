namespace MRP_SdC
{
    public class BOM
    {
        //atributos
        public int numeroReferencia { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }
        public string nivel { get; set; }


        public BOM()
        {

        }

        //construtores
        public BOM(
            int idProduto, int quantidade, string nivel
        )

        {
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.nivel = nivel;
        }

        public override string ToString()
        {
            return this.idProduto.ToString();
        }
    }  
}
