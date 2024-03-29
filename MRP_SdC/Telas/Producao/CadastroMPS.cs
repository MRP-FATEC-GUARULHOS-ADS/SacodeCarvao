﻿using System;
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
                int.Parse(valorPmp.ToString()), int.Parse(txtSemana.Text), DateTime.Now.ToString());

                DialogResult confirmarInsert = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Inserção",
                    MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    MySQL.ConexaoMPS mpscon = new MySQL.ConexaoMPS();

                    mpscon.Insert(mps);

                    Produto prod = new Produto();
                    MySQL.ProdutoDAO prodDao = new MySQL.ProdutoDAO();
                    //Método que retorna as informações do produto.
                    prodDao.GetIdEstoque(comboBox1.Text);
                    //Variável que recebe o id do Produto.
                    prod.idProduto = prodDao.idProdutoGetIdEstoque;

                    //Variável que realiza o cálculo de subtração no estoque
                    int subtraiEstoque = prodDao.estoqueAtualGetIdEstoque - int.Parse(txtQuantidadeDemandaConsiderada.Text);

                    if (subtraiEstoque < 0)
                    {
                        subtraiEstoque = 0;
                    }

                    MySQL.EstoqueProdutoDao estProdDao = new MySQL.EstoqueProdutoDao();
                    //Método que desconta o valor e atualiza o estoque atual.
                    estProdDao.UpdateSaldo(comboBox1.Text, subtraiEstoque);

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
                MySQL.EstoqueProdutoDao EstoqueprodutoDao = new MySQL.EstoqueProdutoDao();
                EstoqueprodutoDao.PesquisaEstoqueProdutos(comboBox1.Text);
                //Chama o get que busca o id do produto e sua quantidade no estoque atual.
                EstoqueprodutoDao.GetIdEstoque(comboBox1.Text);
                txtEstoqueAtual.Text = EstoqueprodutoDao.estoqueAtualGetIdEstoque.ToString();
                //Preenche o valor do txt com o id retornado da consulta.
                txtIdProduto.Text = EstoqueprodutoDao.idProdutoGetIdEstoque.ToString();

                //Cria um objeto do tipo DaoPedido.
                MySQL.DAOPedido pedidoDao = new MySQL.DAOPedido();
                pedidoDao.GetQuantidadePedidoSemana(comboBox1.Text, int.Parse(txtSemana.Text));
                // Preenche o valor do txt com a carteira de pedido retornado da consulta.
                txtQuantidadePedido.Text = pedidoDao.QuantidadePedidoMps.ToString();
                MySQL.DAOPrevisaoDemanda previsaoDao = new MySQL.DAOPrevisaoDemanda();
                previsaoDao.GetQuantidadePrevisaoSemana(comboBox1.Text, int.Parse(txtSemana.Text));
                txtQuantidadePrevisaoDemanda.Text = previsaoDao.QuantidadePrevisaoMps.ToString();

                if (pedidoDao.QuantidadePedidoMps > previsaoDao.QuantidadePrevisaoMps)
                {
                    txtQuantidadeDemandaConsiderada.Text = pedidoDao.QuantidadePedidoMps.ToString();
                }
                else
                {
                    txtQuantidadeDemandaConsiderada.Text = previsaoDao.QuantidadePrevisaoMps.ToString();
                }

                valorPmp = int.Parse(txtEstoqueAtual.Text) - int.Parse(txtQuantidadeDemandaConsiderada.Text);

                //Se o valor do plano mestre de produção é maior que 0 significa que o estoque atende.
                if(valorPmp > 0)
                {
                    valorPmp = 0;
                }

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
