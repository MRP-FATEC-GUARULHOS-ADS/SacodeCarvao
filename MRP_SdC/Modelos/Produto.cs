namespace MRP_SdC
{
    class Produto
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }
        public int qtdeMin { get; set; }
        public int qtdeMax { get; set; }
        public int qtdeAtual { get; set; }
        public char estado { get; set; }

        // Construtores
        public Produto()
        {

        }

        public Produto(
            int id, string modelo, string descricao, double valor,
            int qtdeMin = 0, int qtdeMax = 0, int qtdeAtual = 0, char estado = 'D'
        )
        {
            this.id = id;
            this.modelo = modelo;
            this.descricao = descricao;
            this.valor = valor;
            this.qtdeMin = qtdeMin;
            this.qtdeMax = qtdeMax;
            this.qtdeAtual = qtdeAtual;
            this.estado = estado;
        }

        public override string ToString()
        {
            return this.modelo;
        }

    }
}
