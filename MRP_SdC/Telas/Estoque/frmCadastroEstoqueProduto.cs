using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Estoque
{
    public partial class frmCadastroEstoqueProduto : Form
    {
        public frmCadastroEstoqueProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Objeto e seus atributos.
            Modelos.EstoqueProduto estProd = new Modelos.EstoqueProduto(int.Parse(txtIdProduto.Text),
            cmbModeloProduto.Text, int.Parse(txtQuantidadeAtual.Text), int.Parse(txtEstoqueSeguranca.Text),
            int.Parse(txtLeadTime.Text), int.Parse(txtLote.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + estProd.modeloProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.EstoqueProdutoDao estCompDao = new MySQL.EstoqueProdutoDao();

                estCompDao.Insert(estProd);

                Close();
            }
        }

        private void frmCadastroEstoqueProduto_Load(object sender, EventArgs e)
        {
            //Objeto Produto.
            Produto produto = new Produto();
            //Objeto ProdutoDAO.
            MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = produtoDao.GetProdutosAtivos();

            foreach (Produto item in model)
            {
                cmbModeloProduto.Items.Add(item);
            }
        }

        private void cmbModeloProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();
                produtoDao.GetModeloProduto(cmbModeloProduto.Text);
    
                txtIdProduto.Text = produtoDao.id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
