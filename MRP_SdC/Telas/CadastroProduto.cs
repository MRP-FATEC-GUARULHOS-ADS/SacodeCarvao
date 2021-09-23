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
    public partial class CadastroProduto : Form
    {
        private List<Componente> componentes = null;

        public CadastroProduto()
        {
            InitializeComponent();

            // as gambiarra
            estado_clb.SetItemChecked(1, true);
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (modelo_tbx.Text != "")
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
        private void Explosao_Prod_Click(object sender, EventArgs e)
        {
            ExplosaoProduto formExplosaoProduto = new ExplosaoProduto();
            formExplosaoProduto.ShowDialog();

            componentes = formExplosaoProduto.componentes;
            if (componentes != null)
                estado_clb.Enabled = true;
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            double valor = (double.TryParse(valor_tbx.Text, out valor) ? double.Parse(valor_tbx.Text) : 0);

            Produto myProduto = new Produto(
                modelo_tbx.Text, descr_tbm.Text, valor, (estado_clb.CheckedIndices[0] == 0 ? true : false)
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + myProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                Access.ProdutoDAO objProdDAO = new Access.ProdutoDAO();
                objProdDAO.Insert(myProduto);
            }

            myProduto.componentes = componentes;
            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
