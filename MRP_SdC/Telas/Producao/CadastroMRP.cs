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

        private void cadastrar_Click(object sender, EventArgs e)
        {

            Modelos.Pedido ped = new Modelos.Pedido();
            ped.idPedido = int.Parse(txtIdPedido.Text);

            DAOPedido daoPed = new DAOPedido();
            daoPed.Get(int.Parse(txtIdPedido.Text));
            int estoquePedido = daoPed.qnt;

            Produto prod = new Produto();
            prod.idProduto = int.Parse(txtIdPedido.Text);

            ProdutoDAO prodDao = new ProdutoDAO();
            prodDao.Get(int.Parse(txtIdProduto.Text));
            int estoqueAtual = prodDao.qntEst;

            int subtraiEstoque = prodDao.qntEst - estoquePedido;
            prodDao.UpdateSaldo(subtraiEstoque, int.Parse(txtIdProduto.Text));

            int qntdFinal = estoquePedido - estoqueAtual;

            if(qntdFinal < 0)
            {
                qntdFinal = 0;
            }
            MRP mrpObjeto = new MRP(int.Parse(txtIdPedido.Text), int.Parse(txtIdProduto.Text), estoquePedido, estoqueAtual, 
            qntdFinal);

            
            DAOMRP daoMrp = new DAOMRP();

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mrpObjeto.idMRP+ " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                DAOMRP daoMrpInsert = new DAOMRP();

                daoMrp.Insert(mrpObjeto);

                Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroMRP_Load(object sender, EventArgs e)
        {

        }
    }
}
