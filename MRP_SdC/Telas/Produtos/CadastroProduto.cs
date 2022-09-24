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

        //funcoes das text-boxes
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

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            

            Produto myProduto = new Produto(
                txt_ModeloProduto.Text, txt_DescricaoProduto.Text, int.Parse(txt_ValorProduto.Text)
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
