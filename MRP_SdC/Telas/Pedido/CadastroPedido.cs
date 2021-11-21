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

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Modelos.Pedido pedido = new Modelos.Pedido(int.Parse(qntdEstoque_tbx.Text),
            int.Parse(textBox1.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + pedido.idPedido + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ConexaoPedido pedidocon = new MySQL.ConexaoPedido();

                pedidocon.Insert(pedido);

                Close();
            }
        }
    }
}
