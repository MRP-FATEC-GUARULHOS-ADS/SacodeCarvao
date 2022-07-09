using MRP_Sdc;
using System;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class CadastroBOM : Form
    {
        public CadastroBOM()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            //Objeto e seus atributos.
            BOM bom = new BOM(int.Parse(txtNoPai.Text),
            int.Parse(txtCodigoLista.Text), cmbNome.Text, int.Parse(txtNivel.Text),
            int.Parse(txtQuantidadeUnidade.Text), int.Parse(txtNoProduto.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + bom.idBOM + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.DAOBOM bomcon = new MySQL.DAOBOM();

                bomcon.Insert(bom);

                Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();

            var model = produtoDao.PesquisaProdutosListaBom(cmbNome.Text);

            foreach (Produto item in model)
            {
                cmbNome.Items.Add(produtoDao.pesquisaModelo);
            }                                                                      
        }

        //Ao carregar form.
        private void CadastroBOM_Load_1(object sender, EventArgs e)
        {
            //Objeto Produto.
            Produto produto = new Produto();
            //Objeto ProdutoDAO.
            MySQL.ProdutoDAO produtoDao = new MySQL.ProdutoDAO();

            //Variável que vai trazer os valores do banco de dados.
            var model = produtoDao.GetListaBom();

            foreach (Produto item in model)
            {
                cmbNome.Items.Add(item);
            }
        }
    }
}
