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
    public partial class EstoqueComponente : Form
    {
        // componente selecionado
        Componente myComp;

        public EstoqueComponente()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista()
        {
            MySQL.ComponenteDAO objCompDAO = new MySQL.ComponenteDAO();
            List<Componente> listaComponentes =
                (pesquisa_descnt_cbx.Checked ? objCompDAO.GetComponentes() : objCompDAO.GetComponentesAtivos()); ;

            var bindingComps = new BindingList<Componente>(listaComponentes);
            comp_lista_dgv.DataSource = bindingComps;
        }

        private void MudaInfos()
        {
            myComp = comp_lista_dgv.CurrentRow.DataBoundItem as Componente;
            descnt_btn.Enabled = myComp.estado;

            // textos do componente selecionado
            dados_ttl_lbl.Text = String.Format("{0:D6} - {1}", myComp.id, myComp.tipo);
            dados_subttl_lbl.Text = myComp.modelo;

            atualizar_btn.Enabled = false;
        }

        // funcoes do formulario
        private void FormEstComp_Load(object sender, EventArgs e)
        {
            AtualizaLista();

            MudaInfos();
            atualizar_btn.Enabled = false;
        }

        // funcoes da lista
        private void Lista_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                editar_btn.Enabled = true;
                descnt_btn.Enabled = true;
            }
        }

        private void Componentes_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && comp_lista_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        // funcoes de pesquisa
        private void Pesquisar()
        {
            if (pesquisa_tbx.Text != "")
            {
                MySQL.ComponenteDAO componenteDAO = new MySQL.ComponenteDAO();
                List<Componente> listaComponentes = componenteDAO.PesquisaComponentes(pesquisa_tbx.Text);
                var bindingComponentes = new BindingList<Componente>(listaComponentes);
                comp_lista_dgv.DataSource = bindingComponentes;
            }
            else
            {
                AtualizaLista();
            }
        }

        private void Pesquisar_TBX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }
        private void Pesquisar_BTN_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        /// funcoes da checkbox da pesquisa
        private void Pesquisar_CBX_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        // funcoes das textboxes
        private void Dados_tbx_TextChanged(object sender, EventArgs e)
        {
            atualizar_btn.Enabled = true;
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastrar_btn_Click(object sender, EventArgs e)
        {
            CadastroComponente formCadComponente = new CadastroComponente();
            formCadComponente.ShowDialog();
            AtualizaLista();
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            EditarComponente formEditarComp = new EditarComponente( myComp );
            formEditarComp.ShowDialog();
            AtualizaLista();
        }

        private void Descnt_btn_Click(object sender, EventArgs e)
        {

            MySQL.ComponenteDAO compDAO = new MySQL.ComponenteDAO();
            myComp.estado = false;
            compDAO.UpdateEstado(myComp);
            AtualizaLista();
        }

        private void Estoque_btn_Click(object sender, EventArgs e)
        {
            MySQL.ComponenteDAO compDAO = new MySQL.ComponenteDAO();


            compDAO.UpdateEstoque(myComp);
            atualizar_btn.Enabled = false;

            AtualizaLista();
        }
    }
}
