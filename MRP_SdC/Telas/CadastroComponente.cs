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
    public partial class CadastroComponente : Form
    {
        public CadastroComponente()
        {
            InitializeComponent();

            // as gambiarra denovo
            estado_clb.SetItemChecked(0, true);
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (tipo_cbb.Text != "" && marca_tbx.Text != "" && modelo_tbx.Text != "")
            {
                ok_btn.Enabled = true;
            }
            else
            {
                ok_btn.Enabled = false;
            }
        }

        // funcoes da checklist
        private void Estado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < estado_clb.Items.Count; ++ix)
                if (ix != e.Index) estado_clb.SetItemChecked(ix, false);
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            Componente myComponente = new Componente(
                tipo_cbb.Text, marca_tbx.Text, modelo_tbx.Text, especs_tbm.Text, (estado_clb.CheckedIndices[0] == 0 ? true : false)
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "〜(￣▽￣〜) " + myComponente + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                Access.ComponenteDAO objCompDAO = new Access.ComponenteDAO();
                objCompDAO.Insert(myComponente);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
