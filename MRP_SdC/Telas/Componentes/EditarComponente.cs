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
    public partial class EditarComponente : Form
    {
        // componente selecionado
        Componente myComp;

        // funcoes personalizadas
        private void MudaInfos()
        {
            ttl_lbl.Text = String.Format("{0:D6}", myComp.id);
            tipo_cbb.Text = myComp.tipo;
            marca_tbx.Text = myComp.marca;
            modelo_tbx.Text = myComp.modelo;
            especs_tbm.Text = myComp.especificacoes;
            estado_clb.SetItemChecked((myComp.estado ? 0 : 1), true);
        }

        public EditarComponente( Componente comp)
        {
            InitializeComponent();

            myComp = comp;

            MudaInfos();
            ok_btn.Enabled = false;
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            ok_btn.Enabled = (tipo_cbb.Text != "" && marca_tbx.Text != "" && modelo_tbx.Text != "");
        }

        // funcoes da checklist
        private void Estado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < estado_clb.Items.Count; ++ix)
                if (ix != e.Index)
                    estado_clb.SetItemChecked(ix, false);

            ok_btn.Enabled = true;
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            myComp.tipo = tipo_cbb.Text;
            myComp.marca = marca_tbx.Text;
            myComp.modelo = modelo_tbx.Text;
            myComp.especificacoes = especs_tbm.Text;
            myComp.estado = (estado_clb.CheckedIndices[0] == 0 ? true : false);

            // messagebox confirmando edicao
            DialogResult confirmarEdit = MessageBox.Show(
                "( ˘︹˘ ) " + myComp + " ?!", "Confirmar Edição",
                MessageBoxButtons.YesNo
            );
            if (confirmarEdit == DialogResult.Yes)
            {
                Access.ComponenteDAO objCompDAO = new Access.ComponenteDAO();
                objCompDAO.Update(myComp);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
