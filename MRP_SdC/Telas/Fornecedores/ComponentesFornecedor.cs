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
    public partial class ComponentesFornecedor : Form
    {
        // fornecedor selecionado
        Fornecedor myForn;
        // componente selecionado
        FornecedorComponente myFornComp;

        public ComponentesFornecedor(Fornecedor forn)
        {
            InitializeComponent();
            myForn = forn;

            ttl_lbl.Text = myForn.nome;
        }

        // funcoes personalizadas
        private void AtualizaLista()
        {
            MySQL.FornecedorComponenteDAO objFornCompDAO = new MySQL.FornecedorComponenteDAO();
            List<FornecedorComponente> listaFornComps = objFornCompDAO.GetComponentes(myForn);

            var bindingLista = new BindingList<FornecedorComponente>(listaFornComps);
            comp_lista_dgv.DataSource = bindingLista;
        }

        // funcoes do formulario
        private void Form_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        // funcoes da lista
        private void Lista_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                editar_btn.Enabled = true;
                excluir_btn.Enabled = true;
            }
        }

        private void Componentes_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && comp_lista_dgv.CurrentRow != null)
            {
                myFornComp = comp_lista_dgv.CurrentRow.DataBoundItem as FornecedorComponente;
            }
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastrar_btn_Click(object sender, EventArgs e)
        {
            CadastroComponenteFornecedor formCadCompForn = new CadastroComponenteFornecedor(myForn);
            formCadCompForn.ShowDialog();
            AtualizaLista();
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            EditarComponenteFornecedor formEditCompForn = new EditarComponenteFornecedor(myFornComp);
            formEditCompForn.ShowDialog();
            AtualizaLista();
        }

        private void Excluir_btn_Click(object sender, EventArgs e)
        {
            // confirmando exclusão
            DialogResult confirmarExclusao = MessageBox.Show(
                "(✿◡‿◡) " + myFornComp + " ?!", "Confirmar exclusão do componente fornecido",
                MessageBoxButtons.YesNo
            );
            if (confirmarExclusao == DialogResult.Yes)
            {
                MySQL.FornecedorComponenteDAO forncompDAO = new MySQL.FornecedorComponenteDAO();
                forncompDAO.Delete(myFornComp);
                AtualizaLista();
            }
        }
    }
}
