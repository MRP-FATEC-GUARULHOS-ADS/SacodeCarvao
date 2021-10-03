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
            ok_btn.Enabled = false;
        }

        // adaptando informações
        private void MudaInfos()
        {
            ttl_lbl.Text = String.Format("{0:D6}", myProd.id);
            modelo_tbx.Text = myProd.modelo;
            descr_tbm.Text = myProd.descricao;
            valor_tbx.Text = myProd.valor.ToString();
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

            // messagebox confirmando edicao
            DialogResult confirmarEdit = MessageBox.Show(
                "(′д｀σ)σ " + myProd + " ?!", "Confirmar Edição",
                MessageBoxButtons.YesNo
            );
            if (confirmarEdit == DialogResult.Yes)
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
