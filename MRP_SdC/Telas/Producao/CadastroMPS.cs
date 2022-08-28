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
                int.Parse(txtPlanoMestreProducao.Text), int.Parse(txtSemana.Text));

                DialogResult confirmarInsert = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Inserção",
                    MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    MySQL.ConexaoMPS mrpcon = new MySQL.ConexaoMPS();

                    mrpcon.Insert(mps);

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

        //Ao carregar o form.
        private void CadastroMPS_Load(object sender, EventArgs e)
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

        //Ao selecionar o valor do combo box.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Faz o cálculo do planejamento mestre da produção.
        private void txtQuantidadeDemandaConsiderada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valorPmp = int.Parse(txtEstoqueAtual.Text) - int.Parse(txtQuantidadeDemandaConsiderada.Text);

                //Se o valor do estoque atual for maior do que a demanda considerada.
                if(int.Parse(txtEstoqueAtual.Text) > int.Parse(txtQuantidadeDemandaConsiderada.Text))
                {
                    valorPmp = 0;
                }

                //Se o valor do plano mestre de produção for negativo;
                if(valorPmp < 0)
                {
                    valorPmp = -valorPmp;
                }
                //Converte o valor de int para texto para preencher o campo.
                txtPlanoMestreProducao.Text = valorPmp.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("A demanda considerada tem que ser preenchida");
            }
        }
    }
}
