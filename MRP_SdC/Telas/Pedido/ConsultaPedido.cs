using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MRP_SdC.Modelos;

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
            dados_ttl_lbl.Text = pedido.idPedido.ToString();
            pedido.idPedido = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(pedido.idProduto.ToString());
            txtIdProduto.Text = pedido.idProduto.ToString();
            txtQuantidade.Text = pedido.quantidade.ToString();
            txtValor.Text = pedido.valor.ToString();
        }

        private void ConsultaPedido_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            MudaInfos();
        }

        private void pedido_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && mps_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        private void btnAtualizaPedido_Click(object sender, EventArgs e)
        {

            Modelos.Pedido pedido = new Modelos.Pedido();

            pedido.idPedido = (int.Parse(dados_ttl_lbl.Text));

            pedido = new Modelos.Pedido(int.Parse(txtIdProduto.Text), int.Parse(txtQuantidade.Text),
            int.Parse(txtValor.Text));

       
            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + pedido.idProduto + " ?!", "Confirmar Update",
                MessageBoxButtons.YesNo
            );
            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.DAOPedido pedcon = new MySQL.DAOPedido();

                pedcon.Update(pedido);

                AtualizaListas();
            }
        }
    }
}
