using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Estoque
{
    public partial class frmConsultaEstoqueProduto : Form
    {
        public frmConsultaEstoqueProduto()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        public void AtualizaListas()
        {
            MySQL.EstoqueProdutoDao estProdDao = new MySQL.EstoqueProdutoDao();
            List<Modelos.EstoqueProduto> listaEstoqueProduto = estProdDao.GetProdutosEstoque();

            dgvEstoqueProduto.DataSource = listaEstoqueProduto;
        }

        private void frmConsultaEstoqueProduto_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }
    }
}
