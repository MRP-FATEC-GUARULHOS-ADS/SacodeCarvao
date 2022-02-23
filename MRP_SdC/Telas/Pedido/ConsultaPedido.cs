using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Pedido
{
    public partial class ConsultaPedido : Form
    {
        public ConsultaPedido()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.DAOPedido pedido = new MySQL.DAOPedido();
            List<Modelos.Pedido> listaPedido = pedido.GetPedido();

            mps_dgv.DataSource = listaPedido;
        }

        private void MudaInfos()
        {
            Modelos.Pedido pedido = new Modelos.Pedido();
            pedido = mps_dgv.CurrentRow.DataBoundItem as Modelos.Pedido;

            // textos do produto selecionado
            dados_ttl_lbl.Text = String.Format(pedido.idPedido.ToString());
            pedido.idPedido = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(pedido.idProduto.ToString());
            txt_IdProduto.Text = pedido.idProduto.ToString();
            txt_QntdPedido.Text = pedido.quantidade.ToString();
        }

        private void ConsultaPedido_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            MudaInfos();
        }

        private void mps_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && mps_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }
    }
}
