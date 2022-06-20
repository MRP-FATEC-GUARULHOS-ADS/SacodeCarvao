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
            BOM bom = new BOM(int.Parse(txtNoPai.Text),
            int.Parse(txtCodigoLista.Text), txtNome.Text, int.Parse(txtNivel.Text),
            int.Parse(txtQuantidadeUnidade.Text), int.Parse(txtNoProduto.Text));

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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
