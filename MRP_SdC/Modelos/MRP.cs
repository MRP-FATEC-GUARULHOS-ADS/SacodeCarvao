namespace MRP_SdC
{
    public class MRP
    {
        //Atributos
        public int idMRP { get; set; }
        public int idComponente { get; set; }
        public string nome { get; set; }
        public int necBruta { get; set; }
        public int estoqueDisp { get; set; }
        public int recOrdensPlan { get; set; }
        public int libDeOrdens { get; set; }
        public int semana { get; set; }

        //Construtores
        public MRP()
        {

        }

        //Construtores
        public MRP(
            int idComponente, string nome, int necBruta, int estoqueDisp, int recOrdensPlan, 
            int libDeOrdens, int semana
        )

        {
            this.idComponente = idComponente;
            this.nome = nome;
            this.necBruta = necBruta;
            this.estoqueDisp = estoqueDisp;
            this.recOrdensPlan = recOrdensPlan;
            this.libDeOrdens = libDeOrdens;
            this.semana = semana;
        }

        public override string ToString()
        {
            return this.nome.ToString();
        }
    }
}
