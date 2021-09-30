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
    public partial class Fornecedores : Form
    {
        // fornecedor selecionado
        Fornecedor myForn;

        public Fornecedores()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista()
        {
            Access.FornecedorDAO objFornDAO = new Access.FornecedorDAO();
            List<Fornecedor> listaFornecedores = objFornDAO.GetFornecedores();

            var lista = new BindingList<Fornecedor>(listaFornecedores);
            forn_lista_dgv.DataSource = lista;
        }

        private void MudaInfos()
        {
            myForn = forn_lista_dgv.CurrentRow.DataBoundItem as Fornecedor;
            // textos do fornecedor selecionado
            codigo_lbl.Text = String.Format("{0:D6}", myForn.id);
            nome_lbl.Text = myForn.nome;
            logradouro_lbl.Text = String.Format("{0} - {1}", myForn.logradouro, myForn.numero);
            cep_lbl.Text = myForn.cep;
            telefone_lbl.Text = myForn.telefone;
            celular_lbl.Text = myForn.celular;
            email_lbl.Text = myForn.email;
            site_lbl.Text = myForn.site;
        }

        // funcoes do formulario
        private void Form_Load(object sender, EventArgs e)
        {
            AtualizaLista();

            MudaInfos();
        }

        // funcoes da lista
        private void Lista_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                componentes_btn.Enabled = true;
                editar_btn.Enabled = true;
                excluir_btn.Enabled = true;
            }
        }

        private void Fornecedores_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && forn_lista_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastrar_btn_Click(object sender, EventArgs e)
        {
            CadastroFornecedor formCadFornecedor = new CadastroFornecedor();
            formCadFornecedor.ShowDialog();
            AtualizaLista();
        }

        private void Componentes_btn_Click(object sender, EventArgs e)
        {
            ComponentesFornecedor formCompsFornecedor = new ComponentesFornecedor(myForn);
            formCompsFornecedor.ShowDialog();
            AtualizaLista();
        }
    }
}
