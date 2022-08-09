using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
            MySQL.DAOMRP mrp = new MySQL.DAOMRP();
            List<MRP> listaMRP = mrp.GetMRP();

            mrp_dgv.DataSource = listaMRP;
        }

        private void MudaInfos()
        {
            MRP mrp = new MRP();
            mrp = mrp_dgv.CurrentRow.DataBoundItem as MRP;

            // textos do produto selecionado
            dados_ttl_lbl.Text = mrp.idMRP.ToString();
            mrp.idMRP = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(mrp.idProduto.ToString());
            txtProdId.Text = mrp.idProduto.ToString();
            txtQntdPedido.Text = mrp.quantidadePedido.ToString();
            txtQntdEstoque.Text = mrp.quantidadeEstoque.ToString();
            txtQntdNecesLiq.Text = mrp.quantidadeFinal.ToString();
        }

        private void ConsultaMRP_Load(object sender, EventArgs e)
        {
            AtualizaListas();

            MudaInfos();
            btnAtualizaMRP.Enabled = false;
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
                MySQL.DAOMRP conexaomrp = new MySQL.DAOMRP();
                List<MRP> listaMRP = conexaomrp.PesquisaMRP(pesquisa_tbx.Text);
                var bindingProdutos = new BindingList<MRP>(listaMRP);
                mrp_dgv.DataSource = bindingProdutos;
            }
            else
            {
                AtualizaListas();
            }
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

        /*
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
        */

        private void btnAtualizaMRP_Click(object sender, EventArgs e)
        {
            MRP mrp = new MRP();

            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mrp.idProduto + " ?!", "Confirmar Delete",
                MessageBoxButtons.YesNo);

            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.DAOMRP conexaomrp = new MySQL.DAOMRP();

                conexaomrp.Update(mrp);

                AtualizaListas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MRP mrp = new MRP();

            DialogResult confirmarUpdate = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mrp.idProduto + " ?!", "Confirmar Delete",
                MessageBoxButtons.YesNo);

            if (confirmarUpdate == DialogResult.Yes)
            {
                MySQL.DAOMRP conexaomrp = new MySQL.DAOMRP();
                conexaomrp.Delete(int.Parse(dados_ttl_lbl.Text));
                AtualizaListas();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportarParaExcel(mrp_dgv);
        }

        private void exportarParaExcel(DataGridView dt)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK) {
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
                                    cabecalho = mrp_dgv.Columns[i].HeaderCell.Value.ToString();
                                }
                                else
                                {
                                    cabecalho += "\t" + mrp_dgv.Columns[i].HeaderCell.Value.ToString();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Nenhuma pasta selecionada!");
            }
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            exportarParaExcel(mrp_dgv);
        }
    }
}
