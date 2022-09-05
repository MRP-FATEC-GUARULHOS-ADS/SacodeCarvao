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
    public partial class EditarComponenteFornecedor : Form
    {
        // fornecedor selecionado
        FornecedorComponente myFornComp;

        public EditarComponenteFornecedor(FornecedorComponente forncomp)
        {
            InitializeComponent();

            myFornComp = forncomp;

            MudaInfos();
            ok_btn.Enabled = false;
        }

        // funcoes
        private void MudaInfos()
        {
            try
            {
                ttl_lbl.Text = myFornComp.fornecedor.ToString();
                comp_cbb.Text = myFornComp.componente.ToString();
                lead_tbx.Text = myFornComp.leadTime.ToString();
                custo_tbx.Text = myFornComp.custo.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            ok_btn.Enabled = (comp_cbb.Text != "" && lead_tbx.Text != "" && custo_tbx.Text != "");
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            myFornComp.leadTime = Int32.Parse(lead_tbx.Text);
            myFornComp.custo = Double.Parse(custo_tbx.Text);

            // confirmando insercao
            DialogResult confirmarEdit = MessageBox.Show(
                "( •̀ ω •́ )✧ " + myFornComp + " ?!", "Confirmar Edição",
                MessageBoxButtons.YesNo
            );
            if (confirmarEdit == DialogResult.Yes)
            {
                MySQL.FornecedorComponenteDAO objFornCompDAO = new MySQL.FornecedorComponenteDAO();
                objFornCompDAO.Update(myFornComp);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
