
namespace MRP_SdC.Telas.Pedido
{
    partial class CadastroPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.produzir_pnl = new System.Windows.Forms.Panel();
            this.qntdEstoque_tbx = new System.Windows.Forms.TextBox();
            this.txt_idProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.produzir_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(334, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 450);
            this.esp_dir_pnl.TabIndex = 11;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 450);
            this.esp_esq_pnl.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.lblTitulo.Size = new System.Drawing.Size(302, 56);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Cadastrar Pedido";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // produzir_pnl
            // 
            this.produzir_pnl.Controls.Add(this.qntdEstoque_tbx);
            this.produzir_pnl.Controls.Add(this.txt_idProduto);
            this.produzir_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.produzir_pnl.Location = new System.Drawing.Point(32, 56);
            this.produzir_pnl.Name = "produzir_pnl";
            this.produzir_pnl.Size = new System.Drawing.Size(302, 48);
            this.produzir_pnl.TabIndex = 16;
            // 
            // qntdEstoque_tbx
            // 
            this.qntdEstoque_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.qntdEstoque_tbx.Location = new System.Drawing.Point(0, 17);
            this.qntdEstoque_tbx.Name = "qntdEstoque_tbx";
            this.qntdEstoque_tbx.Size = new System.Drawing.Size(302, 20);
            this.qntdEstoque_tbx.TabIndex = 1;
            // 
            // txt_idProduto
            // 
            this.txt_idProduto.AutoSize = true;
            this.txt_idProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_idProduto.Location = new System.Drawing.Point(0, 0);
            this.txt_idProduto.Name = "txt_idProduto";
            this.txt_idProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txt_idProduto.Size = new System.Drawing.Size(56, 17);
            this.txt_idProduto.TabIndex = 0;
            this.txt_idProduto.Text = "Id Produto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txt_Quantidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 48);
            this.panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.AutoSize = true;
            this.txt_Quantidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Quantidade.Location = new System.Drawing.Point(0, 0);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txt_Quantidade.Size = new System.Drawing.Size(65, 17);
            this.txt_Quantidade.TabIndex = 0;
            this.txt_Quantidade.Text = "Quantidade ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.lblValor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 48);
            this.panel2.TabIndex = 22;
            // 
            // txtValor
            // 
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValor.Location = new System.Drawing.Point(0, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(302, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValor.Location = new System.Drawing.Point(0, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblValor.Size = new System.Drawing.Size(31, 17);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Lime;
            this.btnCadastro.Location = new System.Drawing.Point(72, 386);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 23;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Red;
            this.btnCancela.Location = new System.Drawing.Point(211, 386);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 24;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.produzir_pnl);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Name = "CadastroPedido";
            this.Text = "CadastroPedido";
            this.produzir_pnl.ResumeLayout(false);
            this.produzir_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel produzir_pnl;
        private System.Windows.Forms.TextBox qntdEstoque_tbx;
        private System.Windows.Forms.Label txt_idProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_Quantidade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCancela;
    }
}