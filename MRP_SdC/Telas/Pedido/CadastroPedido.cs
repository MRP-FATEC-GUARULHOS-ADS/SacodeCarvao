using System;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Pedido
{
    public partial class CadastroPedido : Form
    {
        public CadastroPedido()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Modelos.Pedido pedido = new Modelos.Pedido(int.Parse(txtIdProduto.Text),
            cmbNomeProduto.Text, int.Parse(txtQuantidade.Text), int.Parse(txtValor.Text), int.Parse(txtSemana.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + pedido.idPedido + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.DAOPedido pedidocon = new MySQL.DAOPedido();

                pedidocon.Insert(pedido);

                Close();
            }
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            //Objeto Produto.
            Produto produto = new Produto();
            //Objeto ProdutoDAO.
            MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = produtoDao.GetListaBom();

            foreach (Produto item in model)
            {
                cmbNomeProduto.Items.Add(item);
            }
        }

        private void cmbNomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();
                produtoDao.GetModeloProduto(cmbNomeProduto.Text);

                txtIdProduto.Text = produtoDao.id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
