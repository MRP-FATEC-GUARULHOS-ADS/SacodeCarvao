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
    public partial class CadastroComponenteFornecedor : Form
    {
        // fornecedor selecionado
        Fornecedor myForn;

        public CadastroComponenteFornecedor(Fornecedor forn)
        {
            InitializeComponent();

            myForn = forn;

            ListaComponentes();
        }

        // funcoes
        public void ListaComponentes()
        {
            MySQL.ComponenteDAO compDAO = new MySQL.ComponenteDAO();
            BindingSource bindingComp = new BindingSource();
            bindingComp.DataSource = compDAO.GetComponentes();
            comp_cbb.DataSource = bindingComp;
        }

        // funcoes das text-boxes
        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (comp_cbb.Text != "" && lead_tbx.Text != "" && custo_tbx.Text != "")
            {
                ok_btn.Enabled = true;
            }
            else
            {
                ok_btn.Enabled = false;
            }
        }

        // funcoes dos botoes
        private void NovoComp_btn_Click(object sender, System.EventArgs e)
        {
            CadastroComponente formCadComp = new CadastroComponente();
            formCadComp.ShowDialog();
            ListaComponentes();
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            FornecedorComponente myFornComp = new FornecedorComponente(
                myForn, comp_cbb.SelectedItem as Componente, Int32.Parse(lead_tbx.Text), Double.Parse(custo_tbx.Text)
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "╚(•⌂•)╝ " + myFornComp + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.FornecedorComponenteDAO objFornCompDAO = new MySQL.FornecedorComponenteDAO();
                objFornCompDAO.Insert(myFornComp);
            }

            Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
