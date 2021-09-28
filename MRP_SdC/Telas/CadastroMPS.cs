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
    public partial class CadastroMPS : Form
    {
        public CadastroMPS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPS mps = new MPS(' ', int.Parse(id_tbx.Text), int.Parse(maos_tbx.Text),
            int.Parse(disponivel_tbx.Text), int.Parse(demanda_tbx.Text), int.Parse(produzir_tbx.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ConexaoMPS mpss = new MySQL.ConexaoMPS();

                mpss.Insert(mps);

                Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
