﻿using MRP_Sdc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.MySQL
{
    public partial class CadastroMRP : Form

    {
        public CadastroMRP()
        {
            InitializeComponent();
        }

        //Variável que armazena a quantidade da Necessidade Líquida.
        public int quantidadeFinal;

        
        private void cadastrar_Click(object sender, EventArgs e)
        {
            //Cria o objeto do tipo MPS.
            MPS mps = new MPS();


            ConexaoMPS conMps = new ConexaoMPS();


            Modelos.EstoqueProduto Estprod = new Modelos.EstoqueProduto();
            EstoqueProdutoDao estProdDao = new EstoqueProdutoDao();

            //Cria um objeto do tipo componente.
            Componente componente = new Componente();
            //Cria um objeto do tipo ComponenteDAO.
            ComponenteDAO componentedao = new ComponenteDAO();

            DAOBOM daobom = new DAOBOM();
            BOM bom = new BOM();

            MRP mrpObjeto = new MRP();
            DAOMRP daoMrpInsert = new DAOMRP();

            Telas.Producao.ConsultaBOM consultaBom = new Telas.Producao.ConsultaBOM();
            //txtIdBom.Text = consultaBom.consultaBomId.ToString();
            var model = daobom.Get(int.Parse(txtIdBom.Text));
            foreach (BOM item in model)
            {
                //Inicializando Variáveis locais importantes para o cálculo de estoque
                int planoMestreProducao = 0;
                int estoqueAtual = 0;
                int subtraiEstoque = 0;
                int demandaConsiderada = 0;


                //Realiza se o nível do produto for 0, ou seja se for um produto acabado.
                if (item.nivel == "1")
                {
                    //Select do Pedido através do nome do produto.
                    conMps.GetDemandaMPS(item.nome);
                    //Retorna o id do Pedido através do Select.
                    mps.idMPS = conMps.GetId;

                    //Variável que recebe a quantidade do pedido.
                    planoMestreProducao = conMps.PlanoMestre;
                    demandaConsiderada = conMps.DemandaConsiderada;

                    //Método que retorna as informações do produto.
                    estProdDao.GetModeloProduto(item.nome);
                    //Variável que recebe o id do Produto.
                    Estprod.idProduto = estProdDao.id;
                    //Variável que recebe o nome do Produto.
                    Estprod.modeloProduto = estProdDao.nomeProdutoBom;

                    //Método que busca a quantidade atual no Estoque.
                    estProdDao.Get(item.nome);
                    //Variável que recebe a quantidade atual do produto no Estoque.
                    estoqueAtual = estProdDao.qntAtualEstoque;

                    

                    //Variável que recebe o valor da quantidade que tem que ser produzida.
                    quantidadeFinal = estoqueAtual - planoMestreProducao;

                    //Se quantidade Final for < 0, retorna esse valor == 0.
                    if (quantidadeFinal < 0)
                    {
                        quantidadeFinal = 0;
                    }

                    if(quantidadeFinal == 0)
                    {
                        quantidadeFinal = 0;
                    }

                    //Se a quantidade final for menor do que zero.
                    if (quantidadeFinal < 0)
                    {
                        //Informa ao usuário que precisa repor o estoque.
                        DialogResult falta = MessageBox.Show(item.nome + "Falta Produtos. Emitir ordem de compra???", "Confirmar Inserção", MessageBoxButtons.YesNo);
                        //Se ele confirmar a requisição de compra.
                        if (falta == DialogResult.Yes)
                        {
                            quantidadeFinal = -quantidadeFinal;

                            //Cria um objeto do tipo DAOMRP.
                            DAORequisicao daoReqCompra = new DAORequisicao();

                            //Cria um objeto do tipo RequisicaoCompra
                            Modelos.RequisicaoCompra requisicao = new Modelos.RequisicaoCompra();

                            //Preenche os atributos do objeto requisição.
                            requisicao.idProduto = Estprod.idProduto;
                            requisicao.nomeProduto = item.nome;
                            requisicao.quantidade = -(quantidadeFinal);

                            //Faz o Insert.
                            daoReqCompra.Insert(requisicao);

                            //Fecha a tela após o Cadastro.
                            Close();
                        }
                    }
                    //Faz a inserção dos valores na tabela.
                    mrpObjeto = new MRP(Estprod.idProduto, Estprod.modeloProduto,
                    planoMestreProducao, estoqueAtual, int.Parse(txtRecOrdensPlan.Text),
                    int.Parse(txtLibDeOrdens.Text), int.Parse(txtSemana.Text));

                    //Confirma o cadastro, exibindo uma mensagem.
                    DialogResult confirmarInsert = MessageBox.Show(
                        "( ﾉ ﾟｰﾟ)ﾉ " + item.nome + " ?!", "Confirmar Inserção",
                        MessageBoxButtons.YesNo
                    );
                    //Se o usuário confirmar, cadastra.
                    if (confirmarInsert == DialogResult.Yes)
                    {
                        //Faz o Insert.
                        daoMrpInsert.Insert(mrpObjeto);

                        //Fecha a tela após o Cadastro.
                        Close();
                    }
                }
                //senão
                else
                {
                    //retorna o valor do No Pai.
                    string noPai = item.nivel.Remove(item.nivel.Length - 2, 2);

                    //traz o valor do nome do produto.
                    daobom.GetNomeNoPai(noPai, item.codigoLista);
                    //atribui o valor do nome do produto a esta variável.
                    string nomeProduto = daobom.nomeNoPai;

                    //Busca a necessidade Líquida do produto Nó Pai.
                    daoMrpInsert.GetNecessidadeLiquida(nomeProduto);
                    //Atribui o valor da necessidade Líquida a variável abaixo.
                    int necessidadeLiquida = daoMrpInsert.necessidadeLiquida;

                    //o valor do estoque pedido é o valor da quantidade do nó pai a ser produzido
                    //* o valor da quantidade da lista.
                    planoMestreProducao = necessidadeLiquida * item.quantidadeLista;

                    //Método que retorna as informações do Componente.
                    componentedao.GetModeloComponente(item.nome);
                    //Variável que recebe o id do Componente.
                    componente.id = componentedao.id;
                    //Variável que recebe o nome do Componente.
                    componente.modelo = componentedao.nomeComponenteBom;

                    //Método que busca a quantidade atual no Estoque.
                    componentedao.GetModelo(item.nome);
                    //Variável que recebe a quantidade atual do produto no Estoque.
                    estoqueAtual = componentedao.quantidadeEstoque;

                    //Variável que realiza o cálculo de subtração no estoque
                    subtraiEstoque = componentedao.quantidadeEstoque - planoMestreProducao;

                    if (subtraiEstoque < 0)
                    {
                        subtraiEstoque = 0;
                    }


                    //Método que desconta o valor e atualiza o estoque atual.
                    componentedao.UpdateSaldo(componentedao.id, subtraiEstoque);

                    //Variável que recebe o valor da quantidade que tem que ser produzida.
                    quantidadeFinal = estoqueAtual - planoMestreProducao;

                    if(quantidadeFinal > 0)
                    {
                        quantidadeFinal = 0;
                    }

                    //Se quantidade Final for < 0, retorna esse valor == 0.
                    if (quantidadeFinal < 0)
                    {
                        DialogResult faltaComponente = MessageBox.Show(item.nome + "Falta Produtos. Emitir ordem de compra???", "Confirmar Inserção", MessageBoxButtons.YesNo);

                        if (faltaComponente == DialogResult.Yes)
                        {
                            quantidadeFinal = -quantidadeFinal;

                            //Cria um objeto do tipo DAOMRP.
                            DAORequisicao daoReqCompra = new DAORequisicao();

                            //Cria um objeto do tipo RequisicaoCompra
                            Modelos.RequisicaoCompra requisicao = new Modelos.RequisicaoCompra();

                            //Preenche os atributos do objeto requisição.
                            requisicao.idProduto = Estprod.idProduto;
                            requisicao.nomeProduto = item.nome;
                            requisicao.quantidade = -(quantidadeFinal);

                            //Faz o Insert.
                            daoReqCompra.Insert(requisicao);

                            //Fecha a tela após o Cadastro.
                            Close();
                        }
                    }

                    //Faz a inserção dos valores na tabela.
                    MRP mrpObjetoComponente = new MRP(Estprod.idProduto, Estprod.modeloProduto,
                    planoMestreProducao, estoqueAtual, int.Parse(txtRecOrdensPlan.Text),
                    int.Parse(txtLibDeOrdens.Text), int.Parse(txtSemana.Text));

                    //Confirma o cadastro, exibindo uma mensagem.
                    DialogResult confirmarInsert = MessageBox.Show(
                        "( ﾉ ﾟｰﾟ)ﾉ " + item.nome + " ?!", "Confirmar Inserção",
                        MessageBoxButtons.YesNo
                    );
                    //Se o usuário confirmar, cadastra.
                    if (confirmarInsert == DialogResult.Yes)
                    {
                        //Cria um objeto do tipo DAOMRP.
                        DAOMRP daoMrpInsertComponente = new DAOMRP();

                        //Faz o Insert.
                        daoMrpInsertComponente.Insert(mrpObjetoComponente);

                        //Fecha a tela após o Cadastro.
                        Close();
                    }
                }
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void CadastroMRP_Load(object sender, EventArgs e)
        {

        }

        public void cmbIdPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAOPedido daoPed = new DAOPedido();
            daoPed.GetIdPedido();
            int idPedido = daoPed.idPed;
            cmbModeloComponente.Items.Add(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAOPedido daoPed = new DAOPedido();
            daoPed.GetIdPedido();
            int idPedido = daoPed.idPed;
            int i = 0;
            while (i < 100)
            {
                cmbModeloComponente.Items.Add(idPedido);
                idPedido += 1;
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // funcoes personalizadas
        private void AtualizaListasMrp()
        {
            MySQL.DAOMRP mrp = new MySQL.DAOMRP();
            List<MRP> listaMRP = mrp.GetMRP();

            dgvMrp.DataSource = listaMRP;
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.EstoqueProdutoDao estProdDao = new MySQL.EstoqueProdutoDao();
            List<Modelos.EstoqueProduto> listaEstoqueProduto = estProdDao.GetProdutosEstoque();

            dataGridView1.DataSource = listaEstoqueProduto;
        }

        private void CadastroMRP_Load_1(object sender, EventArgs e)
        {
            //Objeto Produto.
            Modelos.EstoqueComponente estComponente = new Modelos.EstoqueComponente();
            //Objeto ProdutoDAO.
            MySQL.EstoqueComponenteDAO estCompDao = new MySQL.EstoqueComponenteDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = estCompDao.GetComponenteEstoque();

            foreach (Modelos.EstoqueComponente item in model)
            {
                cmbModeloComponente.Items.Add(item);
            }

            AtualizaListas();
            AtualizaListasMrp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            EstoqueComponenteDAO estCompDao = new EstoqueComponenteDAO();
            estCompDao.GetIdEstoque(cmbModeloComponente.Text);

            //Faz a inserção dos valores na tabela.
            MRP mrpObjeto = new MRP(estCompDao.idComponenteGetIdEstoque, cmbModeloComponente.Text,
            int.Parse(txtNecBruta.Text), int.Parse(txtEstoqueDisp.Text), int.Parse(txtRecOrdensPlan.Text),
            int.Parse(txtLibDeOrdens.Text), int.Parse(txtSemana.Text));

            //Confirma o cadastro, exibindo uma mensagem.
            DialogResult confirmarInsert = MessageBox.Show(
                estCompDao.nomeComponenteGetIdEstoque + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            //Se o usuário confirmar, cadastra.
            if (confirmarInsert == DialogResult.Yes)
            {
                //Cria um objeto do tipo DAOMRP.
                DAOMRP daoMrpInsertComponente = new DAOMRP();

                //Faz o Insert.
                daoMrpInsertComponente.Insert(mrpObjeto);

                //Fecha a tela após o Cadastro.
                Close();
            }
        }

        private void cmbIdPedido_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Modelos.EstoqueComponente estComp = new Modelos.EstoqueComponente();
            BOM bom = new BOM();

            MySQL.DAOBOM daoBom = new DAOBOM();
            daoBom.GetNivelBom(cmbModeloComponente.Text, int.Parse(txtIdBom.Text));

            txtNecBruta.Text = daoBom.quantidadeLista.ToString();
            bom.nivel = daoBom.nivelComponente;
            bom.codigoLista = daoBom.GetNivelBomCodigoLista;
            bom.quantidadeLista = daoBom.GetNivelBomQuantidadeLista;

            if (bom.nivel.Length == 3)
            {
                //retorna o valor do No Pai.
                string noPai = bom.nivel.Remove(bom.nivel.Length - 2, 2);

                //traz o valor do nome do produto.
                daoBom.GetNomeNoPai(noPai, bom.codigoLista);
                string nomeNoPai = daoBom.nomeNoPai;

                ConexaoMPS conMps = new ConexaoMPS();
                conMps.GetPlanoMestreProducao(nomeNoPai, int.Parse(txtSemana.Text));

                ConexaoMPS conMps2 = new ConexaoMPS();

                int necBruta = conMps.planoMestreProducao * bom.quantidadeLista;
                txtNecBruta.Text = necBruta.ToString();

                EstoqueComponenteDAO estCompDao = new EstoqueComponenteDAO();
                estCompDao.GetIdEstoque(cmbModeloComponente.Text);

                DAOMRP daoMrp = new DAOMRP();
                DAOMRP daoMrp2 = new DAOMRP();

                if (int.Parse(txtSemana.Text) == 1)
                {
                    estCompDao.GetLeadTimeLote(cmbModeloComponente.Text);
                    int leadTime = estCompDao.GetLeadTime;

                    txtRecOrdensPlan.Text = 0.ToString();

                    int semana = int.Parse(txtSemana.Text) + leadTime;
                    conMps2.GetPlanoMestreProducao(nomeNoPai, semana);
                    int necBruta2 = conMps2.planoMestreProducao * bom.quantidadeLista;

                    daoMrp2.GetLibOrdem(cmbModeloComponente.Text, semana);
                    int estoqueDisponivel = estCompDao.estoqueAtualGetIdEstoque - necBruta;
                    txtEstoqueDisp.Text = estoqueDisponivel.ToString();

                    if (necBruta2 > int.Parse(txtEstoqueDisp.Text) - estCompDao.quantidadeSeguranca)
                    {
                        int liberacao = necBruta2 - estoqueDisponivel;
                        int liberacaoReal;
                        if (liberacao < estCompDao.quantidadeSeguranca)
                        {
                            liberacaoReal = estCompDao.quantidadeSeguranca + liberacao;
                        }
                        else
                        {
                            liberacaoReal = liberacao;
                        }
                        txtLibDeOrdens.Text = liberacaoReal.ToString();
                    }
                    else
                    {
                        txtLibDeOrdens.Text = 0.ToString();
                    }

                }

                if (int.Parse(txtSemana.Text) != 1)
                {
                    estCompDao.GetLeadTimeLote(cmbModeloComponente.Text);
                    int leadTime = estCompDao.GetLeadTime;
                    int lote = estCompDao.getLote;
                    int semana = int.Parse(txtSemana.Text) + leadTime;
                    int semanaLibOrdem = int.Parse(txtSemana.Text) - leadTime;


                    conMps2.GetPlanoMestreProducao(nomeNoPai, semana);

                    int necBruta2 = conMps2.planoMestreProducao * bom.quantidadeLista;

                    daoMrp2.GetLibOrdem(cmbModeloComponente.Text, semana);
                    daoMrp2.GetRecOrdensPlan(cmbModeloComponente.Text, semanaLibOrdem);
                    txtRecOrdensPlan.Text = daoMrp2.GetLibDeOrdensRecPlan.ToString();
                    int estoqueDisponivel = estCompDao.estoqueAtualGetIdEstoque - necBruta + int.Parse(txtRecOrdensPlan.Text);
                    txtEstoqueDisp.Text = estoqueDisponivel.ToString();

                    if (necBruta2 > int.Parse(txtEstoqueDisp.Text) - estCompDao.quantidadeSeguranca)
                    {
                        int liberacao = necBruta2 - estoqueDisponivel;
                        int liberacaoReal;
                        if (liberacao < estCompDao.quantidadeSeguranca)
                        {
                            liberacaoReal = estCompDao.quantidadeSeguranca + liberacao;
                        }
                        else
                        {
                            liberacaoReal = liberacao;
                        }
                        txtLibDeOrdens.Text = liberacaoReal.ToString();
                    }
                    else
                    {
                        txtLibDeOrdens.Text = 0.ToString();
                    }
                }

                estCompDao.UpdateSaldo(cmbModeloComponente.Text, int.Parse(txtEstoqueDisp.Text));
            }
            else
            {
                //retorna o valor do No Pai.
                string noPai = bom.nivel.Remove(bom.nivel.Length - 2, 2);

                //traz o valor do nome do produto.
                daoBom.GetNomeNoPai(noPai, bom.codigoLista);
                string nomeNoPai = daoBom.nomeNoPai;

                EstoqueComponenteDAO estCompDao = new EstoqueComponenteDAO();
                estCompDao.GetIdEstoque(cmbModeloComponente.Text);

                DAOMRP daoMrp = new DAOMRP();
                daoMrp.GetNecessidadeBruta(nomeNoPai, int.Parse(txtSemana.Text));

                DAOMRP daoMrp2 = new DAOMRP();

                int necBruta = daoMrp.GetNecessidadeBrutaNecBruta * bom.quantidadeLista;
                txtNecBruta.Text = necBruta.ToString();

                if (int.Parse(txtSemana.Text) == 1)
                {
                    txtRecOrdensPlan.Text = 0.ToString();
                    estCompDao.GetLeadTimeLote(cmbModeloComponente.Text);
                    int leadTime = estCompDao.GetLeadTime;
                    int semana = int.Parse(txtSemana.Text) + leadTime;

                    daoMrp2.GetNecessidadeBruta(nomeNoPai, semana);

                    daoMrp2.GetLibOrdem(cmbModeloComponente.Text, semana);
                    txtLibDeOrdens.Text = daoMrp2.getLibOrdens.ToString();
                    int estoqueDisponivel = estCompDao.estoqueAtualGetIdEstoque - necBruta;
                    txtEstoqueDisp.Text = estoqueDisponivel.ToString();

                    int necBruta2 = daoMrp2.GetNecessidadeBrutaNecBruta * bom.quantidadeLista;

                    if (necBruta2 > int.Parse(txtEstoqueDisp.Text) - estCompDao.quantidadeSeguranca)
                    {
                        int liberacao = necBruta2 - estoqueDisponivel;
                        int liberacaoReal;
                        if (liberacao < estCompDao.quantidadeSeguranca)
                        {
                            liberacaoReal = estCompDao.quantidadeSeguranca;
                        }
                        else
                        {
                            liberacaoReal = liberacao;
                        }
                        txtLibDeOrdens.Text = liberacaoReal.ToString();
                    }
                    else
                    {
                        txtLibDeOrdens.Text = 0.ToString();
                    }
                }

                if (int.Parse(txtSemana.Text) != 1)
                {
                    estCompDao.GetLeadTimeLote(cmbModeloComponente.Text);
                    int leadTime = estCompDao.GetLeadTime;
                    int lote = estCompDao.getLote;
                    int semana = int.Parse(txtSemana.Text) + leadTime;
                    int semanaLibOrdem = int.Parse(txtSemana.Text) - leadTime;

                    daoMrp2.GetNecessidadeBruta(nomeNoPai, semana);

                    daoMrp2.GetLibOrdem(cmbModeloComponente.Text, semana);
                    daoMrp2.GetRecOrdensPlan(cmbModeloComponente.Text, semanaLibOrdem);
                    txtRecOrdensPlan.Text = daoMrp2.GetLibDeOrdensRecPlan.ToString();
                    int estoqueDisponivel = estCompDao.estoqueAtualGetIdEstoque - necBruta + int.Parse(txtRecOrdensPlan.Text);
                    txtEstoqueDisp.Text = estoqueDisponivel.ToString();

                    int necBruta2 = daoMrp2.GetNecessidadeBrutaNecBruta * bom.quantidadeLista;

                    if (necBruta2 > int.Parse(txtEstoqueDisp.Text) - estCompDao.quantidadeSeguranca)
                    {
                        int liberacao = necBruta2 - estoqueDisponivel;
                        int liberacaoReal;
                        if (liberacao < estCompDao.quantidadeSeguranca)
                        {
                            liberacaoReal = estCompDao.quantidadeSeguranca;
                        }
                        else
                        {
                            liberacaoReal = liberacao;
                        }
                        txtLibDeOrdens.Text = liberacaoReal.ToString();
                    }
                    else
                    {
                        txtLibDeOrdens.Text = 0.ToString();
                    }
                }

                EstoqueComponenteDAO estoqueCompDao = new EstoqueComponenteDAO();
                estoqueCompDao.UpdateSaldo(cmbModeloComponente.Text, int.Parse(txtEstoqueDisp.Text));
            }
        }
    }
}

