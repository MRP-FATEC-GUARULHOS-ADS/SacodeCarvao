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
    public partial class Login : Form
    {
        public Modelos.Usuario myUser = null;

        public Login()
        {
            InitializeComponent();
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (user_tbx.Text != "" && senha_tbx.Text != "")
            {
                ok_btn.Enabled = true;
            }
            else
            {
                ok_btn.Enabled = false;
            }
        }

        // funcoes dos botoes

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            MySQL.UsuarioDAO objUserDAO = new MySQL.UsuarioDAO();
            myUser = objUserDAO.Get(user_tbx.Text, senha_tbx.Text);

            //abre a tela principal do MRP
            Main_frm main = new Main_frm();
            main.ShowDialog();

            if (myUser != null)
            {
                Close();
            }
            else
            {
                resultado_lbl.Text = "Usuário ou senha não encontrados.";
            }
        }

        private void Sair_btn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
