﻿using MRP_SdC.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC
{
    public partial class Main_frm : Form
    {
        //Tipo de objeto e depois iguala a nulo.
        Modelos.Usuario myUser = null;

        public Main_frm()
        {
            // chama a tela de login
            //myUser = Logar();
            
            InitializeComponent();
            
        }

        // funcoes personalizadas
        private Modelos.Usuario Logar()
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();

            return formLogin.myUser;
        }
        private void AutenticarUsuario()
        {
            // se não logou, fecha o programa
            if (myUser == null)
                Application.Exit();
            // muda o nome exibido do usuário
            else
                user_name_txb.Text = myUser.Nome;
        }

        private void AtualizaListas()
        {
            MySQL.DAOMRP mrpDAO = new MySQL.DAOMRP();
            List<MRP> listaMRP = mrpDAO.GetMRP();
            var bindingMRP = new BindingList<MRP>(listaMRP);

            ListarProdutosAtivos();
        }

        // funcoes personalizadas
        private void atualizalistaspedido()
        {
            MySQL.DAOPedido pedido = new MySQL.DAOPedido();
            List<Modelos.Pedido> listaPedido = pedido.GetPedido();

            dem_lista_dgv.DataSource = listaPedido;
        }

        private void ListarProdutosAtivos()
        {
            MySQL.ProdutoDAO produtoDAO = new MySQL.ProdutoDAO();
            List<Produto> listaProdutos = produtoDAO.GetProdutosAtivos();
            var bindingProdutos = new BindingList<Produto>(listaProdutos);
            prod_lista_dgv.DataSource = bindingProdutos;
        }

        // funcoes do formulario
        private void FormMain_Load(object sender, EventArgs e)
        {
            //AutenticarUsuario();
            Modelos.Usuario usu = new Modelos.Usuario();


            // textos do produto selecionado
            Login login = new Login();
     

            atualizalistaspedido();

        }

        // funcoes das listas


        // funcoes de pesquisa
        private void PesquisarProdutos()
        {
            if (prod_pesquisa_tbx.Text != "")
            {
                MySQL.ProdutoDAO produtoDAO = new MySQL.ProdutoDAO();
                List<Produto> listaProdutos = produtoDAO.PesquisaProdutos(prod_pesquisa_tbx.Text);
                var bindingProdutos = new BindingList<Produto>(listaProdutos);
                prod_lista_dgv.DataSource = bindingProdutos;
            }
            else
            {
                ListarProdutosAtivos();
            }
        }

        /// Produtos
        private void PesquisarProdutos_TBX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarProdutos();
            }
        }
        private void PesquisarProdutos_BTN_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        // funcoes dos botoes
        private void Estoque_Prod_Click(object sender, EventArgs e)
        {
            EstoqueProduto formEstoqueProduto = new EstoqueProduto();
            formEstoqueProduto.ShowDialog();
            AtualizaListas();
        }

        private void Estoque_Comp_Click(object sender, EventArgs e)
        {
            EstoqueComponente formEstoqueComponente = new EstoqueComponente();
            formEstoqueComponente.ShowDialog();
        }

        private void Fornecedor_Comp_Click(object sender, EventArgs e)
        {
            Fornecedores formFornecedor = new Fornecedores();
            formFornecedor.ShowDialog();
        }

        //funcoes do menu
        private void Salir_TSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DemMPS_TSMI_Click(object sender, EventArgs e)
        {
            CadastroMRP formMRP = new CadastroMRP();
            formMRP.ShowDialog();
            AtualizaListas();
        }

        private void EstProdutos_TSMI_Click(object sender, EventArgs e)
        {
            EstoqueProduto formEstoqueProduto = new EstoqueProduto();
            formEstoqueProduto.ShowDialog();
            AtualizaListas();
        }
        private void EstComponentes_TSMI_Click(object sender, EventArgs e)
        {
            EstoqueComponente formEstoqueComponente = new EstoqueComponente();
            formEstoqueComponente.ShowDialog();
        }
        private void EstFornecedores_TSMI_Click(object sender, EventArgs e)
        {
            Fornecedores formFornecedores = new Fornecedores();
            formFornecedores.ShowDialog();
        }

        private void CadProdutos_TSMI_Click(object sender, EventArgs e)
        {
            CadastroProduto formCadProduto = new CadastroProduto();
            formCadProduto.ShowDialog();
            AtualizaListas();
        }
        private void CadComponentes_TSMI_Click(object sender, EventArgs e)
        {
            CadastroComponente formCadComponente = new CadastroComponente();
            formCadComponente.ShowDialog();
        }
        private void CadFornecedores_TSMI_Click(object sender, EventArgs e)
        {
            CadastroFornecedor formCadFornecedor = new CadastroFornecedor();
            formCadFornecedor.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Pedido.CadastroPedido formPedido = new Telas.Pedido.CadastroPedido();
            formPedido.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Telas.Producao.CadastroBOM formCadastroBOM = new Telas.Producao.CadastroBOM();
            formCadastroBOM.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Producao.CadastroMPS formCadastroMPS = new Telas.Producao.CadastroMPS();
            formCadastroMPS.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Producao.ConsultaMPS formConsultaMPS = new Telas.Producao.ConsultaMPS();
            formConsultaMPS.ShowDialog();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Pedido.ConsultaPedido formConsultaPedido = new Telas.Pedido.ConsultaPedido();
            formConsultaPedido.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroMRP formCadastroMRP = new CadastroMRP();
            formCadastroMRP.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Producao.ConsultaMRP formConsultaMRP = new Telas.Producao.ConsultaMRP();
            formConsultaMRP.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Producao.ConsultaBOM formConsultaBOM = new Telas.Producao.ConsultaBOM();
            formConsultaBOM.ShowDialog();
        }

        private void requisiçãoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Telas.Producao.ConsultaReqCompra formConsultaReqCompra = new Telas.Producao.ConsultaReqCompra();
            formConsultaReqCompra.ShowDialog();
        }

        //Desloga o usuário.
        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            myUser = Logar();
            AutenticarUsuario();
        }

        //Abre a tela de consultas de usuários.
        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telas.Usuario.ConsultaUsuario formConsultaUsuario = new Telas.Usuario.ConsultaUsuario();
            formConsultaUsuario.ShowDialog();
        }

        //Abre a tela de cadastro de usuarios.
        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Telas.Usuario.CadastroUsuario formCadastroUsuario = new Telas.Usuario.CadastroUsuario();
            //Abre o form.
            formCadastroUsuario.ShowDialog();
        }

        //Abre a tela de cadastro de demanda.
        private void demandaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Pedido.CadastroPrevisaoDemanda formCadastroPrevisaoDemanda = new Telas.Pedido.CadastroPrevisaoDemanda();
            //Abre o form.
            formCadastroPrevisaoDemanda.ShowDialog();
        }

        //Abre o forms de consulta de previsão de demanda.
        private void demandaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Pedido.frmConsultaPrevisaoDemanda frmConsultaPrevisaoDemanda = new Telas.Pedido.frmConsultaPrevisaoDemanda();
            //Abre o form.
            frmConsultaPrevisaoDemanda.ShowDialog();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.frmConsultaEntrega frmConsEntrega = new Telas.Fornecedores.frmConsultaEntrega();
            frmConsEntrega.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void componenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmCadastroEstoqueComponente frmEstoqueEntrega = new Telas.Estoque.frmCadastroEstoqueComponente();
            frmEstoqueEntrega.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmCadastroEstoqueProduto frmEstoqueProduto = new Telas.Estoque.frmCadastroEstoqueProduto();
            frmEstoqueProduto.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmConsultaEstoqueProduto frmConsultaEstoqueProduto = new Telas.Estoque.frmConsultaEstoqueProduto();
            frmConsultaEstoqueProduto.ShowDialog();
        }

        private void componentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmConsultaEstoqueComponente frmConsultaEstoqueComponente = new Telas.Estoque.frmConsultaEstoqueComponente();
            frmConsultaEstoqueComponente.ShowDialog();
        }
    }
}