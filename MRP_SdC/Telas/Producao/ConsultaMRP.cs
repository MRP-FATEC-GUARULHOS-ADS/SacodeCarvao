using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class ConsultaMRP : Form
    {
        MRP mrp = new MRP();

        public ConsultaMRP()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.ConexaoMRP mrp = new MySQL.ConexaoMRP();
            List<MRP> listaMRP = mrp.GetMRP();

            mrp_dgv.DataSource = listaMRP;
        }

        private void ConsultaMRP_Load(object sender, EventArgs e)
        {
            AtualizaListas();

            MudaInfos();
            button2.Enabled = true;
        }

        private void MudaInfos()
        {
            mrp = mrp_dgv.CurrentRow.DataBoundItem as MRP;

            // textos do produto selecionado
            dados_ttl_lbl.Text = String.Format("{0:D6}", mrp.idNecesLiq);
            dados_subttl_lbl.Text = String.Format(mrp.idProduto.ToString());
            txtProdId.Text = mrp.idProduto.ToString();
            txtQntdPedido.Text = mrp.qntdPedido.ToString();
            txtQntdEstoque.Text = mrp.qntdEstoque.ToString();
            txtQntdNecesLiq.Text = mrp.qntdNecesLiq.ToString();
        }


        private void mrp_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && mrp_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySQL.ConexaoMRP conexaomrp = new MySQL.ConexaoMRP();

            mrp.idProduto = Int32.Parse(txtProdId.Text);
            mrp.qntdPedido= Int32.Parse(txtQntdPedido.Text);
            mrp.qntdEstoque = Int32.Parse(txtQntdEstoque.Text);
            mrp.qntdNecesLiq = Int32.Parse(txtQntdNecesLiq.Text);

            conexaomrp.Update(mrp);

            AtualizaListas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQL.ConexaoMRP conexaomrp = new MySQL.ConexaoMRP();
            conexaomrp.Delete(int.Parse(pesquisa_tbx.Text));
            AtualizaListas();

            button2.Enabled = false;
        }
    }
}
