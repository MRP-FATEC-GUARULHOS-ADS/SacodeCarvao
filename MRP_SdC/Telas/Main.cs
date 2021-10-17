﻿using System;
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
        Usuario myUser = null;

        public Main_frm()
        {
            // chama a tela de login
            //myUser = Logar();
            
            InitializeComponent();
            
        }

        // funcoes personalizadas
        private Usuario Logar()
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
            MySQL.ConexaoMRP mrpDAO = new MySQL.ConexaoMRP();
            List<MRP> listaMRP = mrpDAO.GetMRP();
            var bindingMRP = new BindingList<MRP>(listaMRP);
            dem_lista_dgv.DataSource = bindingMRP;

            ListarProdutosAtivos();
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

            AtualizaListas();
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

        private void btnCadastrarProducao_Click(object sender, EventArgs e)
        {
            CadastroMRP cadastromrp = new CadastroMRP();
            cadastromrp.ShowDialog();
            AtualizaListas();
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

        private void UsuarioSair_TSMI_Click(object sender, EventArgs e)
        {
            myUser = Logar();
            AutenticarUsuario();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroMRP formCadMRP = new CadastroMRP();
            formCadMRP.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Producao.ConsultaMRP formConsMRP = new Telas.Producao.ConsultaMRP();
            formConsMRP.ShowDialog();
        }
    }
}
