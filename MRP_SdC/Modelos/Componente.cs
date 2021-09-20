namespace MRP_SdC
{
    class Componente
    {
        // Atributos
        public int id { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string especificacoes { get; set; }
        public int qtdeMin { get; set; }
        public int qtdeMax { get; set; }
        public int qtdeAtual { get; set; }
        public char estado { get; set; }

        // Construtores
        public Componente()
        {

        }

        public Componente(
            int id, string tipo, string marca, string modelo, string especificacoes,
            int qtdeMin = 0, int qtdeMax = 0, int qtdeAtual = 0, char estado = 'P'
        )
        {
            this.id = id;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.especificacoes = especificacoes;
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
