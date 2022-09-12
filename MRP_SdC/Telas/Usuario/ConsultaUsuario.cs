using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Usuario
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void pesquisa_btn_Click(object sender, EventArgs e)
        {

        }

        private void MudaInfos()
        {
            Modelos.Usuario usu = new Modelos.Usuario();
            usu = dgvBom.CurrentRow.DataBoundItem as Modelos.Usuario;

            // textos do produto selecionado

            pb_Foto.ImageLocation = usu.Foto.ToString();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            AtualizaListas();
            MudaInfos();
        }

        private void AtualizaListas()
        {
            MySQL.UsuarioDAO usu = new MySQL.UsuarioDAO();
            List<Modelos.Usuario> listaUsuario = usu.GetLogin();

            dgvBom.DataSource = listaUsuario;
        }

        private void dgvBom_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.SelectedRows.Count > 0)
            {

            }
        }

        private void dgvBom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvBom.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        private void dgvBom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvBom.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        private void dgvBom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && dgvBom.CurrentRow != null)
            {
                MudaInfos();
            }
        }

        private void pb_Foto_Click(object sender, EventArgs e)
        {

        }
    }
}
