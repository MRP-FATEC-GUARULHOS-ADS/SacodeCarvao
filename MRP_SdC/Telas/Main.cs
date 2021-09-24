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
            ComponenteDAO objCompDAO = new ComponenteDAO();
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
        private void Estoque_Prod_Click(object sender, EventArgs e)
        {
            EstoqueProduto formEstoqueProduto = new EstoqueProduto();
            formEstoqueProduto.ShowDialog();
            AtualizaListas();
        }

        private void btnCadastrarProducao_Click(object sender, EventArgs e)
        {
            CadastroMPS cadastromps = new CadastroMPS();
            cadastromps.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ConexaoMPS mps = new ConexaoMPS();
            mps.AtualizarLista(dem_lista_dgv);
        }

    }
}
