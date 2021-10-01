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
    public partial class EstoqueProduto : Form
    {
        // produto selecionado
        Produto myProd;

        public EstoqueProduto()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista()
        {
            Access.ProdutoDAO objProdDAO = new Access.ProdutoDAO();
            List<Produto> listaProdutos = (pesquisa_descnt_cbx.Checked ? objProdDAO.GetProdutos() : objProdDAO.GetProdutosAtivos());

            var bindingProdutos = new BindingList<Produto>(listaProdutos);
            prod_lista_dgv.DataSource = bindingProdutos;
        }
        private void MudaInfos()
        {
            myProd = prod_lista_dgv.CurrentRow.DataBoundItem as Produto;
            descnt_btn.Enabled = myProd.estado;
            // textos do produto selecionado
            dados_ttl_lbl.Text = String.Format("{0:D6}", myProd.id);
            dados_subttl_lbl.Text = myProd.modelo;
            estoque_atual_tbx.Text = myProd.qtdeAtual.ToString();
            estoque_min_tbx.Text = myProd.qtdeMin.ToString();
            estoque_max_tbx.Text = myProd.qtdeMax.ToString();
        }

        // funcoes do formulario
        private void FormEstProd_Load(object sender, EventArgs e)
        {
            AtualizaLista();

            MudaInfos();
        }

        // funcoes da checkbox da pesquisa
        private void Pesquisa_CBX_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        // funcoes da lista
        private void Lista_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                editar_btn.Enabled = true;
                arvore_btn.Enabled = true;
            }
        }

        private void Produtos_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && prod_lista_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        // funcoes das textboxes
        private void Estoque_tbx_TextChanged(object sender, EventArgs e)
        {
            atualizar_btn.Enabled = true;
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            EditarProduto editProd = new EditarProduto( myProd );
            editProd.ShowDialog();
            AtualizaLista();
        }

        private void Arvore_btn_Click(object sender, EventArgs e)
        {
            ExplosaoProduto arvoreProd = new ExplosaoProduto(myProd);
            arvoreProd.ShowDialog();
            AtualizaLista();
        }

        private void Descnt_btn_Click(object sender, EventArgs e)
        {
            Access.ProdutoDAO prodDAO = new Access.ProdutoDAO();
            myProd.estado = false;
            prodDAO.UpdateEstado(myProd);
            AtualizaLista();
        }


    }
}
