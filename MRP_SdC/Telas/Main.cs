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
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            Access.ConexaoMPS mps = new Access.ConexaoMPS();
            List<MPS> listaMPS = mps.GetMPS();
            var bindingMPS = new BindingList<MPS>(listaMPS);
            dem_lista_dgv.DataSource = bindingMPS;

            ListarProdutosAtivos();
        }
        private void ListarProdutosAtivos()
        {
            Access.ProdutoDAO produtoDAO = new Access.ProdutoDAO();
            List<Produto> listaProdutos = produtoDAO.GetProdutosAtivos();
            var bindingProdutos = new BindingList<Produto>(listaProdutos);
            prod_lista_dgv.DataSource = bindingProdutos;
        }

        // funcoes do formulario
        private void FormMain_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }

        // funcoes das listas


        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (prod_pesquisa_tbx.Text != "")
            {
                Access.ProdutoDAO produtoDAO = new Access.ProdutoDAO();
                List<Produto> listaProdutos = produtoDAO.PesquisaProdutos(prod_pesquisa_tbx.Text);
                var bindingProdutos = new BindingList<Produto>(listaProdutos);
                prod_lista_dgv.DataSource = bindingProdutos;
            }
            else
            {
                ListarProdutosAtivos();
            }
        }

        /// Produtos
        private void PesquisarProdutos_TBX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarProdutos();
            }
        }
        private void PesquisarProdutos_BTN_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        // funcoes dos botoes
        private void Estoque_Prod_Click(object sender, EventArgs e)
        {
            EstoqueProduto formEstoqueProduto = new EstoqueProduto();
            formEstoqueProduto.ShowDialog();
            AtualizaListas();
        }

        private void Estoque_Comp_Click(object sender, EventArgs e)
        {
            EstoqueComponente formEstoqueComponente = new EstoqueComponente();
            formEstoqueComponente.ShowDialog();
        }

        private void Fornecedor_Comp_Click(object sender, EventArgs e)
        {
            Fornecedores formFornecedor = new Fornecedores();
            formFornecedor.ShowDialog();
        }

        private void btnCadastrarProducao_Click(object sender, EventArgs e)
        {
            CadastroMPS cadastromps = new CadastroMPS();
            cadastromps.ShowDialog();
            AtualizaListas();
        }

        //funcoes do menu
        private void DemMPS_TSMI_Click(object sender, EventArgs e)
        {
            CadastroMPS formMPS = new CadastroMPS();
            formMPS.ShowDialog();
            AtualizaListas();
        }

        private void EstProdutos_TSMI_Click(object sender, EventArgs e)
        {
            EstoqueProduto formEstoqueProduto = new EstoqueProduto();
            formEstoqueProduto.ShowDialog();
            AtualizaListas();
        }
        private void EstComponentes_TSMI_Click(object sender, EventArgs e)
        {
            EstoqueComponente formEstoqueComponente = new EstoqueComponente();
            formEstoqueComponente.ShowDialog();
        }
        private void EstFornecedores_TSMI_Click(object sender, EventArgs e)
        {
            Fornecedores formFornecedores = new Fornecedores();
            formFornecedores.ShowDialog();
        }

        private void CadProdutos_TSMI_Click(object sender, EventArgs e)
        {
            CadastroProduto formCadProduto = new CadastroProduto();
            formCadProduto.ShowDialog();
            AtualizaListas();
        }
        private void CadComponentes_TSMI_Click(object sender, EventArgs e)
        {
            CadastroComponente formCadComponente = new CadastroComponente();
            formCadComponente.ShowDialog();
        }
        private void CadFornecedores_TSMI_Click(object sender, EventArgs e)
        {
            CadastroFornecedor formCadFornecedor = new CadastroFornecedor();
            formCadFornecedor.ShowDialog();
        }
    }
}
