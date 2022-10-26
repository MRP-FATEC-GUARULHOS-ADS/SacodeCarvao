using MRP_Sdc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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

        public int consultaBomId;
        public void MudaInfos()
        {
            BOM bom = new BOM();
            bom = dgvBom.CurrentRow.DataBoundItem as BOM;

            // textos do produto selecionado
            dados_ttl_lbl.Text = bom.idBOM.ToString();
            bom.idBOM = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(bom.nome.ToString());
            txtNome.Text = bom.nome.ToString();
            txtCodigoLista.Text = bom.codigoLista.ToString();
            consultaBomId = int.Parse(txtCodigoLista.Text);
            txtNivel.Text = bom.nivel.ToString();
            txtQuantidadeLista.Text = bom.quantidadeLista.ToString();
        }
        
        public void ConsultaBOM_Load(object sender, EventArgs e)
        {
            AtualizaListas();

            MudaInfos();

            //btnAtualizaMRP.Enabled = false;
        }

        private void dgvBom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvBom.CurrentRow != null)
            {
                MudaInfos();
            }
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
            MPS mps = new MPS();

            Pedido.ConsultaPedido consPed = new Pedido.ConsultaPedido();
            cadMrp.cmbModeloComponente.Text = dados_subttl_lbl.Text;
            cadMrp.txtIdBom.Text = txtCodigoLista.Text; 
            cadMrp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOM bom = new BOM();

            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + bom.nome + " ?!", "Confirmar Delete",
                MessageBoxButtons.YesNo);

            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.DAOBOM conexaobom = new MySQL.DAOBOM();
                conexaobom.Delete(int.Parse(dados_ttl_lbl.Text));
                AtualizaListas();
            }
        }

        private void dgvBom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvBom.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        private void btnAtualizaMRP_Click(object sender, EventArgs e)
        {
            BOM bom = new BOM(int.Parse(txtCodigoLista.Text),
            txtNome.Text, txtNivel.Text,
            int.Parse(txtQuantidadeLista.Text));

            bom.idBOM = int.Parse(dados_ttl_lbl.Text);
            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + bom.nome + " ?!", "Confirmar Update",
                MessageBoxButtons.YesNo);

            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.DAOBOM conexaodao = new MySQL.DAOBOM();

                conexaodao.Update(bom);

                AtualizaListas();
            }
        }

        private void exportarExcel(DataGridView dt)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = @"" + fb.SelectedPath + "\\Report_excel" + DateTime.Now.ToShortTimeString().Replace(":", "") + ".xls";
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Unicode))
                    {
                        String cabecalho = "";

                        for (int i = 0; i < dt.ColumnCount; i++)
                        {
                            if (dt.Columns[i].Visible)
                            {
                                if (cabecalho == "")
                                {
                                    cabecalho = dgvBom.Columns[i].HeaderCell.Value.ToString();
                                }
                                else
                                {
                                    cabecalho += "\t" + dgvBom.Columns[i].HeaderCell.Value.ToString();
                                }
                            }
                        }

                        sw.WriteLine(cabecalho);

                        String linha = "";

                        for (int k = 0; k < dt.Rows.Count; k++)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                String valor = dt.Rows[k].Cells[i].Value.ToString();

                                valor = valor.Replace("\n", "");
                                valor = valor.Replace("\r", "");

                                if (dt.Columns[i].Visible)
                                {
                                    if (linha == "")
                                    {
                                        linha = valor;
                                    }
                                    else
                                    {
                                        linha += "\t" + valor;
                                    }
                                }
                            }//FIM FOR COLUNAS
                            sw.WriteLine(linha);
                            linha = "";
                        }//FIM FOR LINHAS
                    } //FIM SW

                    Process.Start(new ProcessStartInfo(@path) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pasta selecionada!");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportarExcel(dgvBom);
        }
    }
}
