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

        // funcoes do formulario
        private void FormEstProd_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }
    }
}
