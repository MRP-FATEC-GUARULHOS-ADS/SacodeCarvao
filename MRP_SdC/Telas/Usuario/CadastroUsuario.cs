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
using System.IO;

namespace MRP_SdC.Telas.Usuario
{
    public partial class CadastroUsuario : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto =="")
            {
                if(MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    textbox_foto.ImageLocation = origemCompleto;
                }
                else
                {
                    if(MessageBox.Show("Erro ao localizar foto, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            textbox_foto.ImageLocation = destinoCompleto;
            //Objeto e seus atributos.
            Modelos.Usuario usuario = new Modelos.Usuario(txtNome.Text,
            txtAcesso.Text, txtSenha.Text, destinoCompleto);

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

        private void btn_addFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir?","Substituir",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                textbox_foto.ImageLocation = origemCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }
    }
}
