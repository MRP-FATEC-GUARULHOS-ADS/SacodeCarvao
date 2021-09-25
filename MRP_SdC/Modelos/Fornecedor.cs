namespace MRP_SdC
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string site { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor (
            int id, string nome, string telefone, string logradouro = "", string numero = "", string complemento = "",
            string cep = "", string celular = "", string email = "", string site = ""
        )
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
            this.celular = celular;
            this.email = email;
            this.site = site;
        }
    }
}
