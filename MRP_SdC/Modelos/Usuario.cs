﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC.Modelos
{
    public class Usuario
    {
        //Atributos de Usuário
        public string Nome { get; set; }
        public string Acesso { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }

        public Usuario ()
        {

        }

        public Usuario(string Nome, string Acesso, string Senha, string Foto)
        {
            this.Nome = Nome;
            this.Acesso = Acesso;
            this.Senha = Senha;
            this.Foto = Foto;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
