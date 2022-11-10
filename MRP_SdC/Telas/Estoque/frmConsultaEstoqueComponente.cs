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

        private void btnAtualizaMRP_Click(object sender, EventArgs e)
        {
            //Método try catch.
            try
            {
                //Gerando objeto MPS. 
                Modelos.EstoqueComponente estComp = new Modelos.EstoqueComponente();

                //Passando os parâmetros para o objeto do tipo mps.
                estComp = new Modelos.EstoqueComponente(int.Parse(txtIdComponente.Text), txtNomeComponente.Text, int.Parse(txtQuantidadeAtualEstoque.Text),
                int.Parse(txtEstoqueSeguranca.Text), int.Parse(txtLeadTime.Text),
                int.Parse(txtLote.Text));

                estComp.modeloComponente = txtNomeComponente.Text;
                DialogResult confirmarUpdate = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + estComp.modeloComponente + " ?!", "Confirmar Update",
                    MessageBoxButtons.YesNo
                );
                if (confirmarUpdate == DialogResult.Yes)
                {
                    MySQL.EstoqueComponenteDAO estCompCon = new MySQL.EstoqueComponenteDAO();

                    estCompCon.Update(estComp);

                    AtualizaListas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEstoqueComponente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEstoqueComponente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvEstoqueComponente.CurrentRow != null)
            {
                MudaInfos();
            }
        }
    }
}
