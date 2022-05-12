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
            ped.idPedido = int.Parse(cmbIdPedido.Text);

            DAOPedido daoPed = new DAOPedido();
            daoPed.Get(int.Parse(cmbIdPedido.Text));
            int estoquePedido = daoPed.qnt;

            Produto prod = new Produto();
            prod.idProduto = int.Parse(cmbIdPedido.Text);

            ProdutoDAO prodDao = new ProdutoDAO();
            prodDao.Get(int.Parse(cmbIdProduto.Text));
            int estoqueAtual = prodDao.qntEst;

            int subtraiEstoque = prodDao.qntEst - estoquePedido;
            prodDao.UpdateSaldo(subtraiEstoque, int.Parse(cmbIdProduto.Text));

            int qntdFinal = estoquePedido - estoqueAtual;

            if(qntdFinal < 0)
            {
                qntdFinal = 0;
            }
            MRP mrpObjeto = new MRP(int.Parse(cmbIdPedido.Text), int.Parse(cmbIdProduto.Text), estoquePedido, estoqueAtual, 
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
