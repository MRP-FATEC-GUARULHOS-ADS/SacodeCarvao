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
            txtNomeProduto.Text, int.Parse(txtQuantidade.Text), int.Parse(txtValor.Text));

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
    }
}
