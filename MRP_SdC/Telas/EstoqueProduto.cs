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
            MySQL.ProdutoDAO objProdDAO = new MySQL.ProdutoDAO();
            List<Produto> listaProdutos = objProdDAO.GetProdutos();

            var bindingProdutos = new BindingList<Produto>(listaProdutos);
            prod_lista_dgv.DataSource = bindingProdutos;
        }
        private void MudaInfos()
        {
            myProd = prod_lista_dgv.CurrentRow.DataBoundItem as Produto;
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

        // funcoes da lista
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
    }
}
