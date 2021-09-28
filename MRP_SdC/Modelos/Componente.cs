namespace MRP_SdC
{
    public class Componente
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
        public bool estado { get; set; }

        // Construtores
        public Componente()
        {

        }

        public Componente(
            string tipo, string marca, string modelo, string especificacoes, bool estado = false
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
