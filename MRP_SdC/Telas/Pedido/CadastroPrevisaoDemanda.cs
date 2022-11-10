using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Pedido
{
    public partial class CadastroPrevisaoDemanda : Form
    {
        public CadastroPrevisaoDemanda()
        {
            InitializeComponent();
        }

        private void CadastroPrevisaoDemanda_Load(object sender, EventArgs e)
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //Método que trata as excessões.
            try
            {
                Modelos.PrevisaoDemanda previsao = new Modelos.PrevisaoDemanda(int.Parse(txtIdProduto.Text),
                cmbNomeProduto.Text, int.Parse(txtQuantidade.Text), int.Parse(txtSemana.Text));

                DialogResult confirmarInsert = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + previsao.idPrevisaoDemanda + " ?!", "Confirmar Inserção",
                    MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    MySQL.DAOPrevisaoDemanda previsaocon = new MySQL.DAOPrevisaoDemanda();

                    previsaocon.Insert(previsao);

                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
