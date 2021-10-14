using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class ConsultaMRP : Form
    {
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
            btnAtualizaMRP.Enabled = false;
        }

        private void MudaInfos()
        {
            MRP mrp = new MRP();
            mrp = mrp_dgv.CurrentRow.DataBoundItem as MRP;

            // textos do produto selecionado
            dados_ttl_lbl.Text = mrp.idNecesLiq.ToString();
            mrp.idNecesLiq = int.Parse(dados_ttl_lbl.Text);
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

        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (pesquisa_tbx.Text != "")
            {
                MySQL.ConexaoMRP conexaomrp = new MySQL.ConexaoMRP();
                List<MRP> listaMRP = conexaomrp.PesquisaMRP(pesquisa_tbx.Text);
                var bindingProdutos = new BindingList<MRP>(listaMRP);
                mrp_dgv.DataSource = bindingProdutos;
            }
            else
            {
                AtualizaListas();
            }
        }

        public void btnAtualizarMRP_Click(object sender, EventArgs e)
        {
            MySQL.ConexaoMRP conexaomrp = new MySQL.ConexaoMRP();
            MRP mrp = new MRP(int.Parse(txtProdId.Text), int.Parse(txtQntdPedido.Text), int.Parse(txtQntdEstoque.Text), int.Parse(txtQntdNecesLiq.Text));
            conexaomrp.Update(mrp);

            AtualizaListas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQL.ConexaoMRP conexaomrp = new MySQL.ConexaoMRP();
            conexaomrp.Delete(int.Parse(pesquisa_tbx.Text));
            AtualizaListas();
        }

        //funcoes da lista
        private void mrp_dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnAtualizaMRP.Enabled = true;
            }
        }

        private void pesquisa_btn_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void btnAtualizaMRP_Click(object sender, EventArgs e)
        {
            MRP mrp = new MRP(int.Parse(txtProdId.Text), int.Parse(txtQntdPedido.Text),
            int.Parse(txtQntdEstoque.Text), int.Parse(txtQntdNecesLiq.Text));

            mrp.idNecesLiq = int.Parse(dados_ttl_lbl.Text);
            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mrp.idProduto + " ?!", "Confirmar Update",
                MessageBoxButtons.YesNo
            );
            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.ConexaoMRP mrpcon = new MySQL.ConexaoMRP();

                mrpcon.Update(mrp);

                AtualizaListas();
            }
        }
    }
}
