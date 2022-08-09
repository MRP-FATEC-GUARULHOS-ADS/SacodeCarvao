using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class ConsultaReqCompra : Form
    {
        public ConsultaReqCompra()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.DAORequisicao daoReq = new MySQL.DAORequisicao();
            //Chama o método que faz o Get da Lista de Requisição.
            List<Modelos.RequisicaoCompra> listaRequisicao = daoReq.GetRequisicao();

            dgvRequisicao.DataSource = listaRequisicao;
        }

        private void ConsultaReqCompra_Load(object sender, EventArgs e)
        {
            //Chama o Método Atualiza Listas que preenche o DataGridView.
            AtualizaListas();
        }
    }
}
