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
    public partial class frmConsultaEstoqueComponente : Form
    {
        public frmConsultaEstoqueComponente()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        public void AtualizaListas()
        {
            MySQL.EstoqueComponenteDAO estCompDao = new MySQL.EstoqueComponenteDAO();
            List<Modelos.EstoqueComponente> listaEstoqueComponente = estCompDao.GetComponenteEstoque();

            dgvEstoqueComponente.DataSource = listaEstoqueComponente;
        }

        private void frmConsultaEstoqueComponente_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }
    }
}
