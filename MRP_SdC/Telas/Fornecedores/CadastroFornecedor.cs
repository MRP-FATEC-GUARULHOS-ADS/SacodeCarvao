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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (nome_tbx.Text != "" && cep_tbx.Text != "" && telefone_tbx.Text != "")
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
            Fornecedor myFornecedor = new Fornecedor(
                nome_tbx.Text, cep_tbx.Text, telefone_tbx.Text, logradouro_tbx.Text,
                numero_tbx.Text, complemento_tbx.Text, celular_tbx.Text, email_tbx.Text, site_tbx.Text
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "〜(￣▽￣〜) " + myFornecedor + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                Access.FornecedorDAO objFornDAO = new Access.FornecedorDAO();
                objFornDAO.Insert(myFornecedor);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
