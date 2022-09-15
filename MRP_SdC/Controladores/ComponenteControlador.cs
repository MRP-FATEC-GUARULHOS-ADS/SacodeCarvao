using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC.Telas;

namespace MRP_SdC.Controladores
{
    class ComponenteControlador
    {
        public void cadastrarComponente(Componente componente)
        {
            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                componente.modelo + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ComponenteDAO objCompDAO = new MySQL.ComponenteDAO();
                objCompDAO.Insert(componente);
            }
        }

        public void verificarCamposVazios(string tipo, string marca, string modelo, Button ok)
        {
            if (tipo != "" && marca != "" && modelo != "")
            {
                ok.Enabled = true;
            }
            else
            {
                ok.Enabled = false;
            }
        }

        public void checarEstado(ItemCheckEventArgs e, CheckedListBox estado, int ix)
        {
            for (ix = 0; ix < estado.Items.Count; ++ix)
                if (ix != e.Index) estado.SetItemChecked(ix, false);
        }
    }
}
