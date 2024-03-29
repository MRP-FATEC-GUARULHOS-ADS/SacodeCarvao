﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC;

namespace MRP_SdC.Telas.Estoque
{
    public partial class frmCadastroEstoqueComponente : Form
    {
        public frmCadastroEstoqueComponente()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Objeto e seus atributos.
                Modelos.EstoqueComponente estComp = new Modelos.EstoqueComponente(int.Parse(txtIdComponente.Text), cmbModeloComponente.Text, int.Parse(txtQuantidadeAtual.Text),
                int.Parse(txtEstoqueSeguranca.Text), int.Parse(txtLeadTime.Text), int.Parse(txtLote.Text));
                
                DialogResult confirmarInsert = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + estComp.modeloComponente + " ?!", "Confirmar Inserção",
                    MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    MySQL.EstoqueComponenteDAO estCompDao = new MySQL.EstoqueComponenteDAO();

                    estCompDao.Insert(estComp);

                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCadastroEstoqueComponente_Load(object sender, EventArgs e)
        {
            //Objeto Produto.
            Componente componente = new Componente();
            //Objeto ProdutoDAO.
            MySQL.ComponenteDAO componenteDao = new MySQL.ComponenteDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = componenteDao.GetComponentesAtivos();

            foreach (Componente item in model)
            {
                cmbModeloComponente.Items.Add(item);
            }
        }

        private void cmbModeloComponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                MySQL.ComponenteDAO componenteDao = new MySQL.ComponenteDAO();
                componenteDao.GetModeloComponente(cmbModeloComponente.Text);

                txtIdComponente.Text = componenteDao.id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}