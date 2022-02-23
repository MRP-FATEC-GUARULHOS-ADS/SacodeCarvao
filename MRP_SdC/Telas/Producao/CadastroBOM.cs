﻿using System;
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
            BOM bom = new BOM(maos_tbx.Text, int.Parse(qntdEstoque_tbx.Text),
            int.Parse(textBox1.Text), comboBox1.Text);

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + bom.idBOM + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MySQL.ConexaoBOM bomcon = new MySQL.ConexaoBOM();

                bomcon.Insert(bom);

                Close();
            }
        }
    }
}