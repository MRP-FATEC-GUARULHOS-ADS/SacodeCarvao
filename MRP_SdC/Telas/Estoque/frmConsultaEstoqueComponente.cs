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

        public void MudaInfos()
        {
            Modelos.EstoqueComponente estComp = new Modelos.EstoqueComponente();
            estComp = dgvEstoqueComponente.CurrentRow.DataBoundItem as Modelos.EstoqueComponente;

            // textos do produto selecionado
            dados_ttl_lbl.Text = estComp.idEstoqueComponente.ToString();
            estComp.idEstoqueComponente = int.Parse(dados_ttl_lbl.Text);
            dados_subttl_lbl.Text = String.Format(estComp.modeloComponente.ToString());
            txtIdComponente.Text = estComp.idComponente.ToString();
            txtNomeComponente.Text = estComp.modeloComponente.ToString();
            txtQuantidadeAtualEstoque.Text = estComp.qtdeAtualEstoque.ToString();
            txtEstoqueSeguranca.Text = estComp.estoqueSeguranca.ToString();
            txtLeadTime.Text = estComp.leadTime.ToString();
            txtLote.Text = estComp.lote.ToString();
        }

        private void frmConsultaEstoqueComponente_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            MudaInfos();
        }
    }
}
