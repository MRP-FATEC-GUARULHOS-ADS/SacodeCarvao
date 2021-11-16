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
            ttl_lbl.Text = String.Format("{0:D6}", myProd.idProduto);

            txt_IdProduto.Text = myProd.idProduto;
            txt_ModeloProduto.Text = myProd.modelo;
            txt_DescricaoProduto.Text = myProd.descricao;
            txt_ValorProduto.Text = myProd.valor.ToString();
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            ok_btn.Enabled = txt_ModeloProduto.Text != "";
        }

        // funcoes dos botoes
        private void Explosao_Prod_Click(object sender, EventArgs e)
        {
            ExplosaoProduto formExplosaoProduto = new ExplosaoProduto( myProd );
            formExplosaoProduto.ShowDialog();
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            double valor = double.TryParse(txt_ValorProduto.Text, out _) ? double.Parse(txt_ValorProduto.Text) : 0;

            myProd.modelo = txt_ModeloProduto.Text;
            myProd.descricao = txt_DescricaoProduto.Text;
            myProd.valor = valor;

            // messagebox confirmando edicao
            DialogResult confirmarEdit = MessageBox.Show(
                "(′д｀σ)σ " + myProd + " ?!", "Confirmar Edição",
                MessageBoxButtons.YesNo
            );
            if (confirmarEdit == DialogResult.Yes)
            {
                MySQL.ProdutoDAO objProdDAO = new MySQL.ProdutoDAO();
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
