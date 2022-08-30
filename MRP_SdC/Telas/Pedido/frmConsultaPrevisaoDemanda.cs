using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC.MySQL;

namespace MRP_SdC.Telas.Pedido
{
    public partial class frmConsultaPrevisaoDemanda : Form
    {
        public frmConsultaPrevisaoDemanda()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        public void AtualizaListas()
        {
            //Método try catch para capturar o erro.
            try
            {
                DAOPrevisaoDemanda previsaoDemanda = new DAOPrevisaoDemanda();
                //Cria uma lista que pega os dados de previsão de demanda.
                List<Modelos.PrevisaoDemanda> listaPrevisaoDemanda = previsaoDemanda.GetPrevisaoDemanda();

                dgvPrevisaoDemanda.DataSource = listaPrevisaoDemanda;
            }catch(Exception ex)
            {
                //Exibir a mensagem de erro para o usuário.
                MessageBox.Show(ex.Message);
            }
        }

        //Quando o forms carregar.
        private void frmConsultaPrevisaoDemanda_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            //Chama o método Muda Infos.
            MudaInfos();
        }

        //Muda as informações na label.
        public void MudaInfos()
        {
            Modelos.PrevisaoDemanda previsao = new Modelos.PrevisaoDemanda();
            //Preenche os valores com a linha selecionada atual.
            previsao = dgvPrevisaoDemanda.CurrentRow.DataBoundItem as Modelos.PrevisaoDemanda;

            // textos do produto selecionado
            dados_ttl_lbl.Text = previsao.idPrevisaoDemanda.ToString();
            previsao.idPrevisaoDemanda = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(previsao.idProduto.ToString());
            txtIdProduto.Text = previsao.idProduto.ToString();
            txtNomeProduto.Text = previsao.nomeProduto.ToString();
            txtQuantidade.Text = previsao.quantidade.ToString();
        }

        //Ao clicar no dgvPrevisaoDemanda.
        private void dgvPrevisaoDemanda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtém o índice da linha pai da célula.
            if (e.RowIndex != -1 && dgvPrevisaoDemanda.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        //botão que vai atualizar a previsão de demanda.
        private void btnAtualizaPedido_Click(object sender, EventArgs e)
        {
            try
            {


                Modelos.PrevisaoDemanda previsao = new Modelos.PrevisaoDemanda(int.Parse(txtIdProduto.Text), txtNomeProduto.Text,
                int.Parse(txtQuantidade.Text), int.Parse(txtSemana.Text));

                //objeto previsão de demanda.
                previsao.idPrevisaoDemanda = int.Parse(dados_ttl_lbl.Text);
                //Confirmar a atualizãção.
                DialogResult confirmarUpdate = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + previsao.idPrevisaoDemanda + " ?!", "Confirmar Update",
                    MessageBoxButtons.YesNo
                );
                if (confirmarUpdate == DialogResult.Yes)
                {
                    DAOPrevisaoDemanda previsaocon = new DAOPrevisaoDemanda();

                    previsaocon.Update(previsao);

                    AtualizaListas();
                }
            }
            catch (Exception ex)
            {
                //Retorna a mensagem de erro para o usuário.
                MessageBox.Show(ex.Message);
            }
        }

        //Método que realiza a exclusão.
        private void btnExclusao_Click(object sender, EventArgs e)
        {
            Modelos.PrevisaoDemanda previsao = new Modelos.PrevisaoDemanda();

            //Confirmar a exclusão.
            DialogResult confirmarDelete = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + previsao.idPrevisaoDemanda + " ?!", "Confirmar Delete",
                MessageBoxButtons.YesNo);

            if (confirmarDelete == DialogResult.Yes)
            {
                DAOPrevisaoDemanda conexaoprevisao = new DAOPrevisaoDemanda();
                //Chama o método da classe do banco e exclui.
                conexaoprevisao.Delete(int.Parse(dados_ttl_lbl.Text));
                AtualizaListas();
            }
        }

        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (pesquisa_tbx.Text != "")
            {
                //Criação do objeto previsão de demanda.
                DAOPrevisaoDemanda daoprevisao = new DAOPrevisaoDemanda();
                List<Modelos.PrevisaoDemanda> listaPrevisao = daoprevisao.PesquisaPrevisao(pesquisa_tbx.Text);
                //Fornece uma coleção genérica que dá suporte à vinculação de dados..
                var bindingProdutos = new BindingList<Modelos.PrevisaoDemanda>(listaPrevisao);
                dgvPrevisaoDemanda.DataSource = bindingProdutos;
            }
            else
            {
                //Se não acontecer atualiza listas.
                AtualizaListas();
            }
        }

        private void pesquisa_btn_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }
    }
}
