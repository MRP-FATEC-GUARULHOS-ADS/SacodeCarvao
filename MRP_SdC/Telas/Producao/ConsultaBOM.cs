using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class ConsultaBOM : Form
    {
        public ConsultaBOM()
        {
            InitializeComponent();
        }
        
        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.DAOBOM bom = new MySQL.DAOBOM();
            List<BOM> listaBom = bom.GetBOM();

            dgvBom.DataSource = listaBom;
        }

        private void MudaInfos()
        {
            BOM bom = new BOM();
            bom = dgvBom.CurrentRow.DataBoundItem as BOM;

            // textos do produto selecionado
            dados_ttl_lbl.Text = bom.idBOM.ToString();
            bom.idBOM = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(bom.idProduto.ToString());
            txtSaidaFinal.Text = bom.saidaFinal.ToString();
            txtIdProduto.Text = bom.nome.ToString();
            txtCategoria.Text = bom.categoria.ToString();
            txtNome.Text = bom.quantidade.ToString();
            txtQuantidade.Text = bom.quantidade.ToString();
            txtCustoUnidade.Text = bom.custoUnidade.ToString();
        }
        
        public void ConsultaBOM_Load(object sender, EventArgs e)
        {
            AtualizaListas();

            MudaInfos();
            btnAtualizaMRP.Enabled = false;
        }

        // funcoes de pesquisa
        public void PesquisarProdutosBOM(String pesquisa)
        {

            pesquisa = pesquisa_tbx.Text;

            if (pesquisa_tbx.Text != "")
            {
                MySQL.DAOBOM daoBom = new MySQL.DAOBOM();
                List<BOM> listaBom = daoBom.PesquisaBOM(pesquisa);
                var bindingProdutos = new BindingList<BOM>(listaBom);
                dgvBom.DataSource = bindingProdutos;
            }
            else
            {
                AtualizaListas();
            }
            
        }

        private void pesquisa_btn_Click(object sender, EventArgs e)
        {
            PesquisarProdutosBOM(pesquisa_tbx.Text);
        }

        public void pesquisaBOMProduto()
        {
            PesquisarProdutosBOM(pesquisa_tbx.Text);
        }


        public int q;
        public void produzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySQL.CadastroMRP cadMrp = new MySQL.CadastroMRP();
            Pedido.ConsultaPedido consPed = new Pedido.ConsultaPedido();
            cadMrp.cmbIdPedido.Text = dados_subttl_lbl.Text;
            cadMrp.cmbIdProduto.Text = q.ToString();
            cadMrp.Show();
        }
    }
}
