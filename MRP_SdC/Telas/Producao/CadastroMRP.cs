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
    public partial class CadastroMRP : Form
    {
        public CadastroMRP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MRP mrp = new MRP(int.Parse(id_tbx.Text), int.Parse(maos_tbx.Text),
            int.Parse(demanda_tbx.Text), int.Parse(produzir_tbx.Text));

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mrp.idProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ConexaoMRP mrpcon = new MySQL.ConexaoMRP();

                mrpcon.Insert(mrp);

                Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // funcoes personalizadas
        private void AtualizaListas()
        {
            MySQL.ConexaoMRP mrp = new MySQL.ConexaoMRP();
            List<MRP> listaMRP = mrp.GetMRP();
      
            dataGridView1.DataSource = listaMRP;


        }


        // funcoes do formulario
        private void FormMain_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AtualizaListas();
        }
    }
}
