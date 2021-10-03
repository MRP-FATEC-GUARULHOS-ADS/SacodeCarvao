using System;
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
    public partial class EditarFornecedor : Form
    {
        // fornecedor selecionado
        Fornecedor myForn;

        // funcoes personalizadas
        private void MudaInfos()
        {
            ttl_lbl.Text = String.Format("{0:D6}", myForn.id);
            nome_tbx.Text = myForn.nome;
            logradouro_tbx.Text = myForn.logradouro;
            numero_tbx.Text = myForn.numero;
            complemento_tbx.Text = myForn.complemento;
            cep_tbx.Text = myForn.cep;
            telefone_tbx.Text = myForn.telefone;
            celular_tbx.Text = myForn.celular;
            email_tbx.Text = myForn.email;
            site_tbx.Text = myForn.site;
        }

        public EditarFornecedor( Fornecedor forn)
        {
            InitializeComponent();

            myForn = forn;

            MudaInfos();
            ok_btn.Enabled = false;
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            ok_btn.Enabled = (nome_tbx.Text != "" && cep_tbx.Text != "" && telefone_tbx.Text != "");
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            myForn.nome = nome_tbx.Text;
            myForn.cep = cep_tbx.Text;
            myForn.telefone = telefone_tbx.Text;
            myForn.logradouro = logradouro_tbx.Text;
            myForn.numero = numero_tbx.Text;
            myForn.complemento = complemento_tbx.Text;
            myForn.celular = celular_tbx.Text;
            myForn.email = email_tbx.Text;
            myForn.site = site_tbx.Text;

            // confirmando edicao
            DialogResult confirmarEdit = MessageBox.Show(
                "(ｏ ‵-′)ノ”(ノ﹏<。) " + myForn + " ?!", "Confirmar Edição",
                MessageBoxButtons.YesNo
            );
            if (confirmarEdit == DialogResult.Yes)
            {
                Access.FornecedorDAO objFornDAO = new Access.FornecedorDAO();
                objFornDAO.Update(myForn);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
