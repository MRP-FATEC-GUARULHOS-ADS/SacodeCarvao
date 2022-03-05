using System;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class CadastroBOM : Form
    {
        public CadastroBOM()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            BOM bom = new BOM(txtSaidaFinal.Text,
            int.Parse(txtIdProduto.Text), txtCategoria.Text, txtNome.Text, int.Parse(txtQuantidade.Text),
            int.Parse(txtCustoUnidade.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + bom.idBOM + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.DAOBOM bomcon = new MySQL.DAOBOM();

                bomcon.Insert(bom);

                Close();
            }
        }

    }
}
