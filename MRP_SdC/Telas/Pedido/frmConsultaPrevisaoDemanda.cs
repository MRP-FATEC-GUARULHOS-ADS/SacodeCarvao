using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRP_SdC.MySQL;

namespace MRP_SdC.Telas.Pedido
{
    public partial class frmConsultaPrevisaoDemanda : Form
    {
        public frmConsultaPrevisaoDemanda()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        public void AtualizaListas()
        {
            DAOPrevisaoDemanda previsaoDemanda = new DAOPrevisaoDemanda();
            //Cria uma lista que pega os dados de previsão de demanda.
            List<Modelos.PrevisaoDemanda> listaPrevisaoDemanda = previsaoDemanda.GetPrevisaoDemanda();

            dgvPrevisaoDemanda.DataSource = listaPrevisaoDemanda;
        }

        //Quando o forms carregar.
        private void frmConsultaPrevisaoDemanda_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }
    }
}
