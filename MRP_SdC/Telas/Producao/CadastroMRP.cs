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
            Modelos.Pedido ped = new Modelos.Pedido();
            DAOPedido daoPed = new DAOPedido();
            

            Produto prod = new Produto();
            ProdutoDAO prodDao = new ProdutoDAO();

            DAOBOM daobom = new DAOBOM();
            BOM bom = new BOM();

            var model = daobom.Get(int.Parse(txtIdBom.Text));
            foreach(BOM item in model)
            {
                //Inicializando Variáveis locais importantes para o cálculo de estoque
                int estoquePedido = 0;
                int estoqueAtual = 0;
                int subtraiEstoque = 0;


                //Realiza se o nível do produto for 0, ou seja se for um produto acabado.
                if(item.nivel == 0)
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

                    //Método que busca a quantidade atual no Estoque.
                    prodDao.Get(item.nome);
                    //Variável que recebe a quantidade atual do produto no Estoque.
                    estoqueAtual = prodDao.qntEst;

                    //Variável que realiza o cálculo de subtração no estoque
                    subtraiEstoque = prodDao.qntEst - estoquePedido;
                    //Método que desconta o valor e atualiza o estoque atual.
                    prodDao.UpdateSaldo(subtraiEstoque, prod.idProduto);

                    //Variável que recebe o valor da quantidade que tem que ser produzida.
                    quantidadeFinal = estoquePedido - estoqueAtual;

                    //Se quantidade Final for < 0, retorna esse valor == 0.
                    if (quantidadeFinal < 0)
                    {
                        quantidadeFinal = 0;
                    }

                    //Faz a inserção dos valores na tabela.
                    MRP mrpObjeto = new MRP(ped.idPedido, prod.idProduto, estoquePedido, estoqueAtual,
                    quantidadeFinal);

                    //Confirma o cadastro, exibindo uma mensagem.
                    DialogResult confirmarInsert = MessageBox.Show(
                        "( ﾉ ﾟｰﾟ)ﾉ " + mrpObjeto.idMRP + " ?!", "Confirmar Inserção",
                        MessageBoxButtons.YesNo
                    );
                    //Se o usuário confirmar, cadastra.
                    if (confirmarInsert == DialogResult.Yes)
                    {
                        //Método de Insert no Banco de Dados.
                        DAOMRP daoMrpInsert = new DAOMRP();

                        //Faz o Insert.
                        daoMrpInsert.Insert(mrpObjeto);

                        //Fecha a tela após o Cadastro.
                        Close();
                    }
                }

                //Realiza se o nível do produto for 0, ou seja se for um produto acabado.
                if (item.nivel != 0)
                {
                    estoquePedido = quantidadeFinal * item.quantidadeLista;

                    //Método que retorna as informações do produto.
                    prodDao.GetModeloProduto(item.nome);
                    //Variável que recebe o id do Produto.
                    prod.idProduto = prodDao.id;

                    //Método que busca a quantidade atual no Estoque.
                    prodDao.Get(item.nome);
                    //Variável que recebe a quantidade atual do produto no Estoque.
                    estoqueAtual = prodDao.qntEst;

                    //Variável que realiza o cálculo de subtração no estoque
                    subtraiEstoque = prodDao.qntEst - estoquePedido;
                    //Método que desconta o valor e atualiza o estoque atual.
                    prodDao.UpdateSaldo(subtraiEstoque, prod.idProduto);

                    //Variável que recebe o valor da quantidade que tem que ser produzida.
                    quantidadeFinal = estoquePedido - estoqueAtual;

                    //Se quantidade Final for < 0, retorna esse valor == 0.
                    if (quantidadeFinal < 0)
                    {
                        quantidadeFinal = 0;
                    }

                    //Faz a inserção dos valores na tabela.
                    MRP mrpObjeto = new MRP(ped.idPedido, prod.idProduto, estoquePedido, estoqueAtual,
                    quantidadeFinal);

                    //Confirma o cadastro, exibindo uma mensagem.
                    DialogResult confirmarInsert = MessageBox.Show(
                        "( ﾉ ﾟｰﾟ)ﾉ " + mrpObjeto.idMRP + " ?!", "Confirmar Inserção",
                        MessageBoxButtons.YesNo
                    );
                    //Se o usuário confirmar, cadastra.
                    if (confirmarInsert == DialogResult.Yes)
                    {
                        //Método de Insert no Banco de Dados.
                        DAOMRP daoMrpInsert = new DAOMRP();

                        //Faz o Insert.
                        daoMrpInsert.Insert(mrpObjeto);

                        //Fecha a tela após o Cadastro.
                        Close();
                    }
                }
            }   
        }

        private void Cancelar_Click(object sender, EventArgs e)
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
            int i=0;
            while (i < 100){
                cmbIdPedido.Items.Add(idPedido);
                idPedido += 1;
                i++;
            }

            ProdutoDAO daoProd = new ProdutoDAO();
            daoProd.GetIdProduto();
            int idProduto = daoProd.idProd;
            int j=0;
            while (j < 100)
            {
                cmbIdProduto.Items.Add(idProduto);
                idProduto += 1;
                j++;
            }
        }
    }
}
