using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC;

namespace MRP_SdC.Telas.Estoque
{
    public partial class frmCadastroEstoqueComponente : Form
    {
        public frmCadastroEstoqueComponente()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            //Objeto e seus atributos.
            Modelos.EstoqueComponente estComp = new Modelos.EstoqueComponente(int.Parse(txtIdProduto.Text),
            cmbModeloComponente.Text, int.Parse(txtQuantidadeAtual.Text), int.Parse(txtEstoqueSeguranca.Text),
            int.Parse(txtLeadTime.Text), int.Parse(txtLote.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + estComp.modeloComponente + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.EstoqueComponenteDAO estCompDao = new MySQL.EstoqueComponenteDAO();

                estCompDao.Insert(estComp);

                Close();
            }
        }

        private void frmCadastroEstoqueComponente_Load(object sender, EventArgs e)
        {
            //Objeto Produto.
            Componente componente = new Componente();
            //Objeto ProdutoDAO.
            MySQL.ComponenteDAO componenteDao = new MySQL.ComponenteDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = componenteDao.GetComponentesAtivos();

            foreach (Componente item in model)
            {
                cmbModeloComponente.Items.Add(item);
            }
        }
    }
}