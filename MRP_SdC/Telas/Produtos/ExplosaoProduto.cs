using MRP_Sdc;
using MRP_SdC.Telas.Producao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SdC
{
    public partial class ExplosaoProduto : Form
    {
        // produto selecionado
        public Produto myProd;

        // funcoes personalizadas
        public void ListaComponentes(ComboBox cbb)
        {
            MySQL.ComponenteDAO compDAO = new MySQL.ComponenteDAO();
            BindingSource bindingComp = new BindingSource();
            bindingComp.DataSource = compDAO.GetComponentes();
            cbb.DataSource = bindingComp;
        }

        public ExplosaoProduto(Produto prod)
        {
            InitializeComponent();

            myProd = prod;

            // seleciona o estado de produção do produto
            estado_clb.SetItemChecked((prod.estado ? 0 : 1), true);

            ListaComponentes(comp_nome_cbb);
        }

        // funcoes da checklist
        /// pra ter só um item marcado por vez
        private void Estado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ok_btn.Enabled = true;

            for (int ix = 0; ix < estado_clb.Items.Count; ++ix)
                if (ix != e.Index)
                    estado_clb.SetItemChecked(ix, false);
        }

        // funcoes dos botoes
        private void OK_btn_Click(object sender, EventArgs e)
        {
            MySQL.ProdutoDAO prodDAO = new MySQL.ProdutoDAO();
            myProd.estado = estado_clb.GetItemChecked(0);
            prodDAO.UpdateEstado(myProd);
            Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizaListasBOM()
        {
            MySQL.DAOBOM daoBom = new MySQL.DAOBOM();
            List<BOM> listaBom = daoBom.GetBOM();
            var bindingBom = new BindingList<BOM>(listaBom);
        }

        private void btnConsultaArvoreProduto_Click(object sender, EventArgs e)
        {
            ConsultaBOM consultabom = new ConsultaBOM();
            consultabom.ShowDialog();
            AtualizaListasBOM();
        }


        private void ExplosaoProduto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                comboBox2.Items.Add(i);
                comboBox4.Items.Add(i);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            BOM bom = new BOM(
            int.Parse(comboBox2.Text), comp_nome_cbb.Text, 
            textBox1.Text, int.Parse(comboBox4.Text));

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
