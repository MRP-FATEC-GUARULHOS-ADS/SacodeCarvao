using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC.Modelos;

namespace MRP_SdC.Telas.Producao
{
    public partial class ConsultaReqCompra : Form
    {
        public ConsultaReqCompra()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.DAORequisicao daoReq = new MySQL.DAORequisicao();
            //Chama o método que faz o Get da Lista de Requisição.
            List<Modelos.RequisicaoCompra> listaRequisicao = daoReq.GetRequisicao();

            dgvRequisicao.DataSource = listaRequisicao;
        }

        public void MudaInfos()
        {
            RequisicaoCompra reqCompra = new RequisicaoCompra();
            reqCompra = dgvRequisicao.CurrentRow.DataBoundItem as RequisicaoCompra;

            // textos do produto selecionado
            dados_ttl_lbl.Text = reqCompra.idReqCompra.ToString();
            reqCompra.idReqCompra = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(reqCompra.nomeProduto.ToString());
            txtProdId.Text = reqCompra.idProduto.ToString();
            txtNomeProduto.Text = reqCompra.nomeProduto.ToString();
            txtQuantidade.Text = reqCompra.quantidade.ToString();
        }

            private void ConsultaReqCompra_Load(object sender, EventArgs e)
        {
            //Chama o Método Atualiza Listas que preenche o DataGridView.
            AtualizaListas();
            MudaInfos();
        }

        private void btnCadastrarEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                //Objeto e seus atributos.
                Entrega entrega = new Entrega(int.Parse(txtProdId.Text),
                txtNomeProduto.Text, int.Parse(txtQuantidade.Text)
                );

                DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + entrega.nomeProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    MySQL.EntregaDAO entregacon = new MySQL.EntregaDAO();

                    entregacon.Insert(entrega);

                    MySQL.ProdutoDAO prodDao = new MySQL.ProdutoDAO();
                    prodDao.Get(entrega.nomeProduto);
                    int saldoAtual = entrega.quantidade + prodDao.qntEst;
                    prodDao.UpdateSaldo(saldoAtual, entrega.idProduto);

                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRequisicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvRequisicao.CurrentRow != null)
            {
                MudaInfos();
            }
        }
    }
}
