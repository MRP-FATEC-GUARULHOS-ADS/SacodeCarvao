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
    public partial class CadastroMPS : Form
    {
        public CadastroMPS()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            //Método try catch
            try
            {
                //Gerando objeto MPS.   
                MPS mps = new MPS(int.Parse(txtIdProduto.Text), comboBox1.Text,
                int.Parse(txtQuantidadePedido.Text), int.Parse(txtQuantidadePrevisaoDemanda.Text),
                int.Parse(txtQuantidadeDemandaConsiderada.Text), int.Parse(txtEstoqueAtual.Text),
                int.Parse(valorPmp.ToString()), int.Parse(txtSemana.Text));

                DialogResult confirmarInsert = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Inserção",
                    MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    MySQL.ConexaoMPS mpscon = new MySQL.ConexaoMPS();

                    mpscon.Insert(mps);

                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public int valorPmp;
        //Ao selecionar o valor do combo box.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();
                produtoDao.PesquisaProdutos(comboBox1.Text);
                //Chama o get que busca o id do produto e sua quantidade no estoque atual.
                produtoDao.GetIdEstoque(comboBox1.Text);
                txtEstoqueAtual.Text = produtoDao.estoqueAtualGetIdEstoque.ToString();
                //Preenche o valor do txt com o id retornado da consulta.
                txtIdProduto.Text = produtoDao.idProdutoGetIdEstoque.ToString();

                //Cria um objeto do tipo DaoPedido.
                MySQL.DAOPedido pedidoDao = new MySQL.DAOPedido();
                pedidoDao.GetQuantidadePedido(comboBox1.Text);
                // Preenche o valor do txt com a carteira de pedido retornado da consulta.
                txtQuantidadePedido.Text = pedidoDao.QuantidadePedidoMps.ToString();
                MySQL.DAOPrevisaoDemanda previsaoDao = new MySQL.DAOPrevisaoDemanda();
                previsaoDao.GetQuantidadePrevisao(comboBox1.Text);
                txtQuantidadePrevisaoDemanda.Text = previsaoDao.QuantidadePrevisaoMps.ToString();
                txtSemana.Text = previsaoDao.semanaMps.ToString();

                if (pedidoDao.QuantidadePedidoMps > previsaoDao.QuantidadePrevisaoMps)
                {
                    txtQuantidadeDemandaConsiderada.Text = pedidoDao.QuantidadePedidoMps.ToString();
                }
                else
                {
                    txtQuantidadeDemandaConsiderada.Text = previsaoDao.QuantidadePrevisaoMps.ToString();
                }

                valorPmp = int.Parse(txtEstoqueAtual.Text) - int.Parse(txtQuantidadeDemandaConsiderada.Text);

                //Se o valor do plano mestre de produção for negativo;
                if (valorPmp < 0)
                {
                    valorPmp = -valorPmp;
                }
                //Converte o valor de int para texto para preencher o campo.
                txtPlanoMestreProducao.Text = valorPmp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A demanda considerada tem que ser preenchida");
            }
        }

        private void CadastroMPS_Load_1(object sender, EventArgs e)
        {
            //Objeto Produto.
            Produto produto = new Produto();
            //Objeto ProdutoDAO.
            MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = produtoDao.GetListaBom();

            foreach (Produto item in model)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
