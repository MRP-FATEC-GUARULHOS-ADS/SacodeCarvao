using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC.Controladores;

namespace MRP_SdC
{
    public partial class CadastroComponente : Form
    {
        ComponenteControlador compControl = new ComponenteControlador();

        Componente myComponente = new Componente();

        public CadastroComponente()
        {
            InitializeComponent();

            // as gambiarra
            estado_clb.SetItemChecked(0, true);
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            compControl.verificarCamposVazios(tipo_cbb.Text, marca_tbx.Text, modelo_tbx.Text, ok_btn);
        }

        // funcoes da checklist
        private void Estado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int ix=0;
            compControl.checarEstado(e, estado_clb, ix);
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            myComponente = new Componente(
                tipo_cbb.Text, marca_tbx.Text, modelo_tbx.Text, especs_tbm.Text, (estado_clb.CheckedIndices[0] == 0 ? true : false)
            );

            compControl.cadastrarComponente(myComponente);

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
