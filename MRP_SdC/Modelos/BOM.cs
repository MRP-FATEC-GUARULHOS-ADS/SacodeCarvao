namespace MRP_SdC
{
    public class BOM
    {
        //atributos
        public string idBOM { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }
        public string nivel { get; set; }


        public BOM()
        {

        }

        //construtores
        public BOM(
            string idBOM, int idProduto, int quantidade, string nivel
        )

        {
            this.idBOM = idBOM;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.nivel = nivel;
        }

        public override string ToString()
        {
            return this.idBOM;
        }
    }  
}
