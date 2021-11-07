using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC
{
    public partial class CadastroMRP : Form
    {
        public CadastroMRP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qntdNecesLiq = int.Parse(maos_tbx.Text) - int.Parse(qntdEstoque_tbx.Text);
            MRP mrp = new MRP(int.Parse(id_tbx.Text), int.Parse(maos_tbx.Text),
            int.Parse(qntdEstoque_tbx.Text), qntdNecesLiq);

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mrp.idProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ConexaoMRP mrpcon = new MySQL.ConexaoMRP();

                mrpcon.Insert(mrp);

                Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
