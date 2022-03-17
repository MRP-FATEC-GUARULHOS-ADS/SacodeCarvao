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
            ped.idPedido = int.Parse(id_tbx.Text);

            DAOPedido daoPed = new DAOPedido();
            daoPed.Get(int.Parse(id_tbx.Text));
            maos_tbx.Text = daoPed.qnt.ToString();

            Produto prod = new Produto();
            prod.idProduto = int.Parse(id_tbx.Text);

            ProdutoDAO prodDao = new ProdutoDAO();
            prodDao.Get(int.Parse(id_tbx.Text));
            qntdEstoque_tbx.Text = prodDao.qntEst.ToString();

            MRP mrpObjeto = new MRP(1, 1, int.Parse(id_tbx.Text), int.Parse(maos_tbx.Text), int.Parse(qntdEstoque_tbx.Text),
            100);

            
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
