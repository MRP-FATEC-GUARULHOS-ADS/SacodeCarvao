using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            MySQL.ProdutoDAO objProdDAO = new MySQL.ProdutoDAO();
            List<Produto> listaProdutos = (pesquisa_descnt_cbx.Checked ? objProdDAO.GetProdutos() : objProdDAO.GetProdutosAtivos());

            var bindingProdutos = new BindingList<Produto>(listaProdutos);
            prod_lista_dgv.DataSource = bindingProdutos;
        }

        private void MudaInfos()
        {
            myProd = prod_lista_dgv.CurrentRow.DataBoundItem as Produto;
            descnt_btn.Enabled = myProd.estado;

            // textos do produto selecionado
            dados_ttl_lbl.Text = myProd.idProduto.ToString();
            dados_subttl_lbl.Text = myProd.modelo;
            estoque_atual_tbx.Text = myProd.qtdeAtual.ToString();
            estoque_min_tbx.Text = myProd.qtdeMin.ToString();
            estoque_max_tbx.Text = myProd.qtdeMax.ToString();

            atualizar_btn.Enabled = true;
        }

        // funcoes do formulario
        private void FormEstProd_Load(object sender, EventArgs e)
        {
            AtualizaLista();
            MudaInfos();
            atualizar_btn.Enabled = true;
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

        private void prod_lista_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && prod_lista_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (pesquisa_tbx.Text != "")
            {
                MySQL.ProdutoDAO produtoDAO = new MySQL.ProdutoDAO();
                List<Produto> listaProdutos = produtoDAO.PesquisaProdutos(pesquisa_tbx.Text);
                var bindingProdutos = new BindingList<Produto>(listaProdutos);
                prod_lista_dgv.DataSource = bindingProdutos;
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
                PesquisarProdutos();
            }
        }

        private void Pesquisar_BTN_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        /// funcoes da checkbox da pesquisa
        private void Pesquisar_CBX_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaLista();
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
            MySQL.ProdutoDAO prodDAO = new MySQL.ProdutoDAO();
            myProd.estado = false;
            prodDAO.UpdateEstado(myProd);
            AtualizaLista();
        }

        private void Estoque_btn_Click(object sender, EventArgs e)
        {
            MySQL.ProdutoDAO prodDAO = new MySQL.ProdutoDAO();

            myProd.qtdeAtual = Int32.Parse(estoque_atual_tbx.Text);
            myProd.qtdeMin = Int32.Parse(estoque_min_tbx.Text);
            myProd.qtdeMax = Int32.Parse(estoque_max_tbx.Text);

            prodDAO.UpdateEstoque(myProd);
            atualizar_btn.Enabled = false;

            AtualizaLista();
        }

        Telas.Producao.ConsultaBOM bom = new Telas.Producao.ConsultaBOM();

        // funcoes de pesquisa
        public void PesquisarProdutosBOM()
        {
            string pesquisa = dados_ttl_lbl.Text;

                MySQL.DAOBOM daoBom = new MySQL.DAOBOM();
                List<BOM> listaBom = daoBom.PesquisaBOM(pesquisa);
                var bindingProdutos = new BindingList<BOM>(listaBom);
                bom.dgvBom.DataSource = bindingProdutos;
            
        }

        private void AtualizaListasBOM()
        {
            MySQL.DAOBOM daoBom = new MySQL.DAOBOM();
            List<BOM> listaBom = daoBom.GetBOM();
            var bindingBom = new BindingList<BOM>(listaBom);
        }

        private void árvoreDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Producao.ConsultaBOM consultabom = new Telas.Producao.ConsultaBOM();
            consultabom.pesquisa_tbx.Text = dados_ttl_lbl.Text;
            consultabom.Show();
            consultabom.pesquisaBOMProduto();
        }

    }
}
