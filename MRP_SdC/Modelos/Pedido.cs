﻿using System;
using System.Windows.Forms;

namespace MRP_SdC.Modelos
{
    class Pedido
    {
        //Atributos
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int quantidade { get; set; }
        public int valor { get; set; }

        //Construtores
        public Pedido()
        {

        }

        //Construtores
        public Pedido(
            int idProduto, string nomeProduto, int quantidade, int valor
         )

        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public override string ToString()
        {
            return this.idPedido.ToString();
        }
    }
}
