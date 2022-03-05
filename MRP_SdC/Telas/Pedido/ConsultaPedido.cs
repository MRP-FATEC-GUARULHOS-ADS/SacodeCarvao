using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MRP_SdC.MySQL;

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
            DAOPedido pedido = new DAOPedido();
            List<Modelos.Pedido> listaPedido = pedido.GetPedido();

            dgvPedido.DataSource = listaPedido;
        }

        private void MudaInfos()
        {
            Modelos.Pedido pedido = new Modelos.Pedido();
            pedido = dgvPedido.CurrentRow.DataBoundItem as Modelos.Pedido;

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
            if (e.RowIndex != -1 && dgvPedido.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (pesquisa_tbx.Text != "")
            {
                DAOPedido conexaoped = new DAOPedido();
                List<Modelos.Pedido> listaPedido = conexaoped.PesquisaPedido(pesquisa_tbx.Text);
                var bindingPedidos = new BindingList<Modelos.Pedido>(listaPedido);
                dgvPedido.DataSource = bindingPedidos;
            }
            else
            {
                AtualizaListas();
            }
        }

        //funcoes da lista
        private void mrp_dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnAtualizaPedido.Enabled = true;
            }
        }

        private void pesquisa_btn_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void btnAtualizaPedido_Click(object sender, EventArgs e)
        {

            Modelos.Pedido pedido = new Modelos.Pedido(int.Parse(txtIdProduto.Text), int.Parse(txtQuantidade.Text),
            int.Parse(txtValor.Text));

            pedido.idPedido = int.Parse(dados_ttl_lbl.Text);
            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + pedido.idPedido + " ?!", "Confirmar Update",
                MessageBoxButtons.YesNo
            );
            if (confirmarUpdate == DialogResult.Yes)
            {
                DAOPedido pedcon = new DAOPedido();

                pedcon.Update(pedido);

                AtualizaListas();
            }
        }

        private void btnExclusao_Click(object sender, EventArgs e)
        {
            Modelos.Pedido pedido = new Modelos.Pedido();

            DialogResult confirmarDelete = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + pedido.idPedido + " ?!", "Confirmar Delete",
                MessageBoxButtons.YesNo);

            if (confirmarDelete == DialogResult.Yes)
            {
                DAOPedido conexaoped = new DAOPedido();
                conexaoped.Delete(int.Parse(dados_ttl_lbl.Text));
                AtualizaListas();
            }
        }
        
        /*
        private void btnProduzir_Click(object sender, EventArgs e)
        {
            string idProdutoPedido = dgvPedido.SelectedCells[1].Value.ToString();


            MRP mrp = new MRP(int.Parse(idProdutoPedido), 100, 50, 50);

            DAOMRP daoMrp = new DAOMRP();

            daoMrp.Insert(mrp);

        }*/

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
