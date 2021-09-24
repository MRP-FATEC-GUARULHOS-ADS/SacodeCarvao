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
    public partial class CadastroMPS : Form
    {
        public CadastroMPS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MPS mps = new MPS(' ', int.Parse(textBox4.Text), int.Parse(preco_tbx.Text),
                int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));

                DialogResult confirmarInsert = MessageBox.Show(
                    "( ﾉ ﾟｰﾟ)ﾉ " + mps.idProduto + " ?!", "Confirmar Inserção",
                    MessageBoxButtons.YesNo
                );
                if (confirmarInsert == DialogResult.Yes)
                {
                    ConexaoMPS mpss = new ConexaoMPS();

                    mpss.Insert(mps);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
