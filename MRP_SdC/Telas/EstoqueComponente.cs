using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC
{
    public partial class EstoqueComponente : Form
    {
        public EstoqueComponente()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista()
        {
            ComponenteDAO objCompDAO = new ComponenteDAO();
            List<Componente> listaComponentes = objCompDAO.GetComponentes();

            var lista = new BindingList<Componente>(listaComponentes);
            comp_lista_dgv.DataSource = lista;
        }

        // funcoes do formulario
        private void FormEstComp_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }
    }
}
