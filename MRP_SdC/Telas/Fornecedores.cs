﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC
{
    public partial class Fornecedores : Form
    {
        // fornecedor selecionado
        //Componente myComp;

        public Fornecedores()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista()
        {
            //Access.ComponenteDAO objCompDAO = new Access.ComponenteDAO();
            //List<Componente> listaComponentes = objCompDAO.GetComponentes();

            //var lista = new BindingList<Componente>(listaComponentes);
            //comp_lista_dgv.DataSource = lista;
        }

        private void MudaInfos()
        {
            //myComp = comp_lista_dgv.CurrentRow.DataBoundItem as Componente;
            // textos do componente selecionado
            //dados_ttl_lbl.Text = String.Format("{0:D6} - {1}", myComp.id, myComp.tipo);
            //dados_subttl_lbl.Text = myComp.modelo;
            //dados_atual_tbx.Text = myComp.qtdeAtual.ToString();
            //dados_min_tbx.Text = myComp.qtdeMin.ToString();
            //dados_max_tbx.Text = myComp.qtdeMax.ToString();
        }

        // funcoes do formulario
        private void FormEstComp_Load(object sender, EventArgs e)
        {
            AtualizaLista();

            MudaInfos();
        }

        // funcoes da lista
        private void Componentes_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1 && forn_lista_dgv.CurrentRow != null)
            //{
            //    MudaInfos();
            //}
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
