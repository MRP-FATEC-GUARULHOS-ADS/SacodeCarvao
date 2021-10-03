using System.Collections.Generic;

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
        public List<FornecedorComponente> componentes { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor (
            string nome, string cep, string telefone,
            string logradouro = "", string numero = "", string complemento = "",
            string celular = "", string email = "", string site = ""
        )
        {
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

        public override string ToString()
        {
            return this.nome;
        }
    }
}
