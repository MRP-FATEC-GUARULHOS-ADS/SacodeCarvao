using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class ConsultaMPS : Form
    {
        public ConsultaMPS()
        {
            //Método try catch.
            try
            {
                InitializeComponent();
            }catch(Exception ex)
            {
                //Exibe a mensagem de erro.
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                MPS mps = new MPS();
                mps = mps_dgv.CurrentRow.DataBoundItem as MPS;

                // textos do produto selecionado
                dados_ttl_lbl.Text = mps.idMPS.ToString();
                mps.idMPS = int.Parse(dados_ttl_lbl.Text);
                dados_subttl_lbl.Text = String.Format(mps.idProduto.ToString());
                txtProdId.Text = mps.idProduto.ToString();
                txtNomeProduto.Text = mps.nomeProduto.ToString();
                txtQuantidadePedido.Text = mps.quantidadePedido.ToString();
                txtQuantidadePrevisaoDemanda.Text = mps.quantidadePrevisaoDemanda.ToString();
                txtQuantidadeDemandaConsiderada.Text = mps.quantidadeDemandaConsiderada.ToString();
                txtEstoqueAtual.Text = mps.estoqueAtual.ToString();
                txtPlanoMestreProducao.Text = mps.planoMestreProducao.ToString();
                txtSemana.Text = mps.semana.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        // funcoes de pesquisa
        private void PesquisarProdutosSemana()
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

        private void ConsultaMPS_Load_1(object sender, EventArgs e)
        {
            
            //Chama o método atualiza listas.
            AtualizaListas();
            MudaInfos();
        }

        private void btnAtualizaMRP_Click_1(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                //Gerando objeto MPS. 
                MPS mps = new MPS();
                mps.data = DateTime.Now.Hour.ToString();

                //Passando os parâmetros para o objeto do tipo mps.
                mps = new MPS(int.Parse(txtProdId.Text), txtNomeProduto.Text, int.Parse(txtQuantidadePedido.Text),
                int.Parse(txtQuantidadePrevisaoDemanda.Text), int.Parse(txtQuantidadeDemandaConsiderada.Text),
                int.Parse(txtEstoqueAtual.Text), int.Parse(txtPlanoMestreProducao.Text), int.Parse(txtSemana.Text), mps.data);

                mps.idMPS = int.Parse(dados_ttl_lbl.Text);
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método de exclusão no mps.
        private void button1_Click(object sender, EventArgs e)
        {
            //Método try catch
            try
            {
                MPS mps = new MPS();

                //preenche o valor de idMPS.
                mps.idMPS = int.Parse(dados_ttl_lbl.Text);
                //Pergunta se quer realizar a exclusão.
                DialogResult confirmarUpdate = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Delete",
                    MessageBoxButtons.YesNo);

                if (confirmarUpdate == DialogResult.Yes)
                {
                    //Gerar objeto do tipo DAOMRP.
                    MySQL.ConexaoMPS conexaomps = new MySQL.ConexaoMPS();
                    conexaomps.Delete(int.Parse(dados_ttl_lbl.Text));
                    //Atualizar a tabela.
                    AtualizaListas();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buscarÁrvoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySQL.DAOBOM dao = new MySQL.DAOBOM();
                dao.GetCodigoLista(txtNomeProduto.Text);
                MRP_Sdc.BOM bom = new MRP_Sdc.BOM();


                ConsultaBOM consultabom = new ConsultaBOM();
                consultabom.pesquisa_tbx.Text = dao.codigoListaVar.ToString();
                consultabom.Show();
                consultabom.pesquisaBOMProduto();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
           //MessageBox.Show("Escolha a semana que desejar consultar");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PesquisarProdutosSemana();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            PesquisarProdutosSemana();
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            PesquisarProdutosSemana();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PesquisarProdutosSemana();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisarProdutosSemana();
        }
    }
}
