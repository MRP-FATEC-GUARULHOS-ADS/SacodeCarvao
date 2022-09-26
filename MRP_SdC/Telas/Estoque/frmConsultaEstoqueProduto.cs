using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC;

namespace MRP_SdC.Telas.Estoque
{
    public partial class frmConsultaEstoqueProduto : Form
    {
        public frmConsultaEstoqueProduto()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        public void AtualizaListas()
        {
            MySQL.EstoqueProdutoDao estProdDao = new MySQL.EstoqueProdutoDao();
            List<Modelos.EstoqueProduto> listaEstoqueProduto = estProdDao.GetProdutosEstoque();

            dgvEstoqueProduto.DataSource = listaEstoqueProduto;
        }

        public void MudaInfos()
        {
            Modelos.EstoqueProduto estProd = new Modelos.EstoqueProduto();
            estProd = dgvEstoqueProduto.CurrentRow.DataBoundItem as Modelos.EstoqueProduto;

            // textos do produto selecionado
            dados_ttl_lbl.Text = estProd.idEstoqueProduto.ToString();
            estProd.idEstoqueProduto = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(estProd.modeloProduto.ToString());
            txtProdId.Text = estProd.idProduto.ToString();
            txtNomeProduto.Text = estProd.modeloProduto.ToString();
            txtQuantidadeAtualEstoque.Text = estProd.qtdeAtualEstoque.ToString();
            txtEstoqueSeguranca.Text = estProd.estoqueSeguranca.ToString();
            txtLeadTime.Text = estProd.leadTime.ToString();
            txtLote.Text = estProd.lote.ToString();
        }

        private void frmConsultaEstoqueProduto_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            MudaInfos();
        }

        private void dgvEstoqueProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvEstoqueProduto.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        public void btnAtualizaMRP_Click(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                //Gerando objeto MPS. 
                Modelos.EstoqueProduto estProd = new Modelos.EstoqueProduto();

                //Passando os parâmetros para o objeto do tipo mps.
                estProd = new Modelos.EstoqueProduto(int.Parse(txtProdId.Text), txtNomeProduto.Text, int.Parse(txtQuantidadeAtualEstoque.Text),
                int.Parse(txtEstoqueSeguranca.Text), int.Parse(txtLeadTime.Text),
                int.Parse(txtLote.Text));

                estProd.idEstoqueProduto = int.Parse(dados_ttl_lbl.Text);
                DialogResult confirmarUpdate = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + estProd.idProduto + " ?!", "Confirmar Update",
                    MessageBoxButtons.YesNo
                );
                if (confirmarUpdate == DialogResult.Yes)
                {
                    MySQL.EstoqueProdutoDao estProdCon = new MySQL.EstoqueProdutoDao();

                    estProdCon.UpdateEstoqueProduto(estProd);

                    AtualizaListas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
