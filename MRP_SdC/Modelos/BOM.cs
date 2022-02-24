namespace MRP_SdC
{
    public class BOM
    {
        //atributos
        public string idBOM { get; set; }
        public int idProduto { get; set; }
        public string nomeComponente { get; set; }
        public int nivelComponente { get; set; }
        public int quantidade { get; set; }

        public BOM()
        {

        }

        //construtores
        public BOM(
            string idBOM, int idProduto, string nomeComponente, int nivelComponente, int quantidade
        )

        {
            this.idBOM = idBOM;
            this.idProduto = idProduto;
            this.nomeComponente = nomeComponente;
            this.nivelComponente = nivelComponente;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return this.idBOM;
        }
    }  
}
