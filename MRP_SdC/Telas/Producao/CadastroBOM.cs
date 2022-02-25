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
            BOM bom = new BOM(int.Parse(qntdEstoque_tbx.Text),
            txtNomeComponente.Text, int.Parse(cmbNivelComponente.Text), int.Parse(txtQuantidade.Text));

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
