using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SdC.Telas.Producao
{
    public partial class CadastroMPS : Form
    {
        public CadastroMPS()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            
            MPS mps = new MPS(int.Parse(qntdEstoque_tbx.Text), int.Parse(textBox1.Text), 
            int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            mps.idMPS = maos_tbx.Text;
            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ConexaoMPS mrpcon = new MySQL.ConexaoMPS();

                mrpcon.Insert(mps, mps.idMPS);

                Close();
            }
        }
    }
}
