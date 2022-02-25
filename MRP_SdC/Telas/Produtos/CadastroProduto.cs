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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        /* funcoes das text-boxes
        private void Required_TextChanged(object sender, EventArgs e)
        {
            if (txt_ModeloProduto.Text != "")
            {
                ok_btn.Enabled = false;
            }
            else
            {
                ok_btn.Enabled = true;
            }
        }
        */
        // funcoes dos botoes
        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            double valor = double.TryParse(txt_DescricaoProduto.Text, out _) ? double.Parse(txt_DescricaoProduto.Text) : 0;

            Produto myProduto = new Produto(
                txt_ModeloProduto.Text, txt_DescricaoProduto.Text, valor
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + myProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ProdutoDAO objProdDAO = new MySQL.ProdutoDAO();
                objProdDAO.Insert(myProduto);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
