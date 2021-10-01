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
    public partial class EditarProduto : Form
    {
        // produto selecionado
        Produto myProd;

        public EditarProduto(Produto prod)
        {
            InitializeComponent();

            myProd = prod;

            MudaInfos();
        }

        // adaptando informações
        private void MudaInfos()
        {
            ttl_lbl.Text = myProd.id.ToString();
            modelo_tbx.Text = myProd.modelo;
            descr_tbm.Text = myProd.descricao;
            valor_tbx.Text = myProd.valor.ToString();

            ok_btn.Enabled = false;
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            ok_btn.Enabled = modelo_tbx.Text != "";
        }

        // funcoes dos botoes
        private void Explosao_Prod_Click(object sender, EventArgs e)
        {
            ExplosaoProduto formExplosaoProduto = new ExplosaoProduto( myProd );
            formExplosaoProduto.ShowDialog();
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            double valor = double.TryParse(valor_tbx.Text, out _) ? double.Parse(valor_tbx.Text) : 0;

            myProd.modelo = modelo_tbx.Text;
            myProd.descricao = descr_tbm.Text;
            myProd.valor = valor;

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "(′д｀σ)σ " + myProd + " ?!", "Confirmar Edição",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                Access.ProdutoDAO objProdDAO = new Access.ProdutoDAO();
                objProdDAO.Update(myProd);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
