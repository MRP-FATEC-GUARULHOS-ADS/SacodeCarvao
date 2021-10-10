namespace MRP_SdC
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Acesso { get; set; }

        public Usuario ()
        {

        }

        public Usuario(string Nome, string Acesso)
        {
            this.Nome = Nome;
            this.Acesso = Acesso;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
