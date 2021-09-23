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
            Access.ComponenteDAO objCompDAO = new Access.ComponenteDAO();
            ProdutoDAO objProdDAO = new ProdutoDAO();

            List<Componente> listaComponentes = objCompDAO.GetComponentes();
            List<Produto> listaProdutos = objProdDAO.GetProdutos();

            var bindingComponentes = new BindingList<Componente>(listaComponentes);
            var bindingProdutos = new BindingList<Produto>(listaProdutos);

            comp_lista_dgv.DataSource = bindingComponentes;
            prod_lista_dgv.DataSource = bindingProdutos;
        }

        // funcoes do formulario
        private void FormMain_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }

        // funcoes das listas
        private void Produtos_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                prod_exp_btn.Enabled = true;
            }
        }
        private void Componentes_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                comp_edt_btn.Enabled = true;
                comp_forn_btn.Enabled = true;
            }
        }

        // funcoes dos botoes
        private void Cadastro_Comp_Click(object sender, EventArgs e)
        {
            CadastroComponente formCadastroComponente = new CadastroComponente();
            formCadastroComponente.ShowDialog();
            AtualizaListas();
        }
        private void Estoque_Comp_Click(object sender, EventArgs e)
        {
            EstoqueComponente formEstoqueComponente = new EstoqueComponente();
            formEstoqueComponente.ShowDialog();
            AtualizaListas();
        }

        private void Cadastro_Prod_Click(object sender, EventArgs e)
        {
            CadastroProduto formCadastroProduto = new CadastroProduto();
            formCadastroProduto.ShowDialog();
            AtualizaListas();
        }
        private void Explosao_Prod_Click(object sender, EventArgs e)
        {
            ExplosaoProduto formExplosaoProduto = new ExplosaoProduto();
            formExplosaoProduto.ShowDialog();
            AtualizaListas();
        }
        private void Estoque_Prod_Click(object sender, EventArgs e)
        {
            EstoqueProduto formEstoqueProduto = new EstoqueProduto();
            formEstoqueProduto.ShowDialog();
            AtualizaListas();
        }
    }
}
