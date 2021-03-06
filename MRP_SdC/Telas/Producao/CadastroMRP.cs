using MRP_Sdc;
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
        public int quantidadeFinal = 0;

        private void cadastrar_Click(object sender, EventArgs e)
        {
            //Cria o objeto do tipo Pedido.
            Modelos.Pedido ped = new Modelos.Pedido();
            DAOPedido daoPed = new DAOPedido();

            Produto prod = new Produto();
            ProdutoDAO prodDao = new ProdutoDAO();

            //Cria um objeto do tipo componente.
            Componente componente = new Componente();
            //Cria um objeto do tipo ComponenteDAO.
            ComponenteDAO componentedao = new ComponenteDAO();

            DAOBOM daobom = new DAOBOM();
            BOM bom = new BOM();

            MRP mrpObjeto = new MRP();
            DAOMRP daoMrpInsert = new DAOMRP();

            Telas.Producao.ConsultaBOM consultaBom = new Telas.Producao.ConsultaBOM();
            txtIdBom.Text = consultaBom.consultaBomId.ToString();
            var model = daobom.Get(int.Parse(txtIdBom.Text));
            foreach (BOM item in model)
            {
                //Inicializando Variáveis locais importantes para o cálculo de estoque
                int estoquePedido = 0;
                int estoqueAtual = 0;
                int subtraiEstoque = 0;


                //Realiza se o nível do produto for 0, ou seja se for um produto acabado.
                if (item.nivel == 0)
                {
                    //Select do Pedido através do nome do produto.
                    daoPed.Get(item.nome);
                    //Retorna o id do Pedido através do Select.
                    ped.idPedido = daoPed.GetId;

                    //Variável que recebe a quantidade do pedido.
                    estoquePedido = daoPed.qnt;

                    //Método que retorna as informações do produto.
                    prodDao.GetModeloProduto(item.nome);
                    //Variável que recebe o id do Produto.
                    prod.idProduto = prodDao.id;
                    //Variável que recebe o nome do Produto.
                    prod.modelo = prodDao.nomeProdutoBom;

                    //Método que busca a quantidade atual no Estoque.
                    prodDao.Get(item.nome);
                    //Variável que recebe a quantidade atual do produto no Estoque.
                    estoqueAtual = prodDao.qntEst;

                    //Variável que realiza o cálculo de subtração no estoque
                    subtraiEstoque = prodDao.qntEst - estoquePedido;
                    //Método que desconta o valor e atualiza o estoque atual.
                    prodDao.UpdateSaldo(subtraiEstoque, prod.idProduto);

                    //Variável que recebe o valor da quantidade que tem que ser produzida.
                    quantidadeFinal = estoqueAtual - estoquePedido;

                    /*Se quantidade Final for < 0, retorna esse valor == 0.
                    if (quantidadeFinal < 0)
                    {
                        quantidadeFinal = 0;
                    }
                    */
                    if(quantidadeFinal < 0)
                    {
                        DialogResult falta = MessageBox.Show(item.nome + "Falta Produtos" + MessageBoxButtons.YesNo);
                    }
                    //Faz a inserção dos valores na tabela.
                    mrpObjeto = new MRP(ped.idPedido, prod.idProduto, prod.modelo,
                    estoquePedido, estoqueAtual, quantidadeFinal);

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
                    int noPai = item.noPai;

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
                    estoquePedido = necessidadeLiquida * item.quantidadeLista;

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
                    subtraiEstoque = componentedao.quantidadeEstoque - estoquePedido;
                    //Método que desconta o valor e atualiza o estoque atual.
                    componentedao.UpdateSaldo(componentedao.id, subtraiEstoque);

                    //Variável que recebe o valor da quantidade que tem que ser produzida.
                    quantidadeFinal = estoquePedido - estoqueAtual;

                    //Se quantidade Final for < 0, retorna esse valor == 0.
                    if (quantidadeFinal < 0)
                    {
                        quantidadeFinal = 0;
                    }

                    //Faz a inserção dos valores na tabela.
                    MRP mrpObjetoComponente = new MRP(1, componente.id, componente.modelo,
                    estoquePedido, estoqueAtual, quantidadeFinal);

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
            cmbIdPedido.Items.Add(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAOPedido daoPed = new DAOPedido();
            daoPed.GetIdPedido();
            int idPedido = daoPed.idPed;
            int i = 0;
            while (i < 100)
            {
                cmbIdPedido.Items.Add(idPedido);
                idPedido += 1;
                i++;
            }
        }
    }
}

