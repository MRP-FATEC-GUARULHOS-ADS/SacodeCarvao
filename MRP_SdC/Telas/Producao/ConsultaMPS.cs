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
    public partial class ConsultaMPS : Form
    {
        public ConsultaMPS()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.ConexaoMPS mps = new MySQL.ConexaoMPS();
            List<MPS> listaMPS = mps.GetMPS();

            mps_dgv.DataSource = listaMPS;
        }

        private void MudaInfos()
        {
            MPS mps = new MPS();
            mps = mps_dgv.CurrentRow.DataBoundItem as MPS;

            // textos do produto selecionado
            dados_ttl_lbl.Text = mps.idMPS.ToString();
            mps.idMPS = dados_ttl_lbl.Text;
            dados_subttl_lbl.Text = String.Format(mps.idProduto.ToString());
            txtProdId.Text = mps.idProduto.ToString();
            txtQntdPedido.Text = mps.quantidadeemMaos.ToString();
            txtQntdEstoque.Text = mps.quantidadeDisponivel.ToString();
            txtQntdNecesLiq.Text = mps.quantidadeDemanda.ToString();
            textBox1.Text = mps.quantidadeProduzir.ToString();
        }

        private void ConsultaMPS_Load(object sender, EventArgs e)
        {
            AtualizaListas();

            MudaInfos();
        }

        private void mrp_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && mps_dgv.CurrentRow != null)
            {
                MudaInfos();
            }
        }


        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (pesquisa_tbx.Text != "")
            {
                MySQL.ConexaoMPS conexaomps = new MySQL.ConexaoMPS();
                List<MPS> listaMPS = conexaomps.PesquisaMPS(pesquisa_tbx.Text);
                var bindingProdutos = new BindingList<MPS>(listaMPS);
                mps_dgv.DataSource = bindingProdutos;
            }
            else
            {
                AtualizaListas();
            }
        }

        private void pesquisa_btn_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        public void btnAtualizaMRP_Click(object sender, EventArgs e)
        {
            MPS mps = new MPS(int.Parse(txtProdId.Text), int.Parse(txtQntdPedido.Text),int.Parse(txtQntdEstoque.Text),
            int.Parse(txtQntdNecesLiq.Text), int.Parse(textBox1.Text));

            mps.idMPS = dados_ttl_lbl.Text;
            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Update",
                MessageBoxButtons.YesNo
            );
            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.ConexaoMPS mpscon = new MySQL.ConexaoMPS();

                mpscon.Update(mps);

                AtualizaListas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPS mps = new MPS();

            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mps.idMPS + " ?!", "Confirmar Delete",
                MessageBoxButtons.YesNo);

            if(confirmarUpdate == DialogResult.Yes)
            {
                MySQL.ConexaoMPS conexaomps = new MySQL.ConexaoMPS();
                conexaomps.Delete(int.Parse(dados_ttl_lbl.Text));
                AtualizaListas();
            }
        }
    }
}
