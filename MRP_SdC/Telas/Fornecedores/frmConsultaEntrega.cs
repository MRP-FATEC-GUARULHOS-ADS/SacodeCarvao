using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Fornecedores
{
    public partial class frmConsultaEntrega : Form
    {
        public frmConsultaEntrega()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.EntregaDAO entrega = new MySQL.EntregaDAO();
            List<Modelos.Entrega> listaEntrega = entrega.GetEntrega();

            dgvEntrega.DataSource = listaEntrega;
        }

        private void MudaInfos()
        {
            try
            {
                Modelos.Entrega entrega = new Modelos.Entrega();
                entrega = dgvEntrega.CurrentRow.DataBoundItem as Modelos.Entrega;

                // textos do produto selecionado
                dados_ttl_lbl.Text = entrega.idEntrega.ToString();
                entrega.idEntrega = int.Parse(dados_ttl_lbl.Text);
                dados_subttl_lbl.Text = String.Format(entrega.idProduto.ToString());
                txtProdId.Text = entrega.idProduto.ToString();
                txtNomeProduto.Text = entrega.nomeProduto.ToString();
                txtQuantidade.Text = entrega.quantidade.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmConsultaEntrega_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            MudaInfos();
        }

        private void dgvEntrega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvEntrega.CurrentRow != null)
            {
                MudaInfos();
            }
        }
    }
}
