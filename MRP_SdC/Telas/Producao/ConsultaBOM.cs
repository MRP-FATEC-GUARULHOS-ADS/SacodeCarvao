using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtProdId.Text = bom.idProduto.ToString();
            txtNomeComponente.Text = bom.nomeComponente.ToString();
            txtNivelComponente.Text = bom.nivelComponente.ToString();
            txtQuantidade.Text = bom.quantidade.ToString();
        }

        private void ConsultaBOM_Load(object sender, EventArgs e)
        {
            AtualizaListas();

            MudaInfos();
            btnAtualizaMRP.Enabled = false;
        }

        // funcoes de pesquisa
        public void PesquisarProdutosBOM()
        {

            string pesquisa = dados_ttl_lbl.Text;

            if (pesquisa_tbx.Text != "")
            {
                MySQL.DAOBOM daoBom = new MySQL.DAOBOM();
                List<BOM> listaBom = daoBom.PesquisaBOMPedido(pesquisa);
                var bindingProdutos = new BindingList<BOM>(listaBom);
                dgvBom.DataSource = bindingProdutos;
            }
            else
            {
                AtualizaListas();
            }
        }
    }
}
