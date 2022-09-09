using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_Sdc
{
    public class BOM
    {
        //atributos
        public int idBOM { get; set; }
        public int codigoLista { get; set; }
        public string nome { get; set; }
        public string nivel { get; set; }
        public int quantidadeLista { get; set; }

        public BOM()
        {

        }

        //construtores
        public BOM(
            int codigoLista, string nome, string nivel, int quantidadeLista
         
        )
        {

            this.codigoLista = codigoLista;
            this.nome = nome;
            this.nivel = nivel;
            this.quantidadeLista = quantidadeLista;
        }

        public override string ToString()
        {
            return this.nome.ToString();
        }
    }  
}
