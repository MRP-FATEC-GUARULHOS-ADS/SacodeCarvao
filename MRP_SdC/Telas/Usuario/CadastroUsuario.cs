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

namespace MRP_SdC.Telas.Usuario
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Objeto e seus atributos.
            Modelos.Usuario usuario = new Modelos.Usuario(txtNome.Text,
            txtAcesso.Text, txtSenha.Text);

            //Pergunta se é pra confirmar o Insert.
            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + usuario.Nome + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.UsuarioDAO usuarioConexao = new MySQL.UsuarioDAO();

                usuarioConexao.Insert(usuario);

                Close();
            }
        }
    }
}
