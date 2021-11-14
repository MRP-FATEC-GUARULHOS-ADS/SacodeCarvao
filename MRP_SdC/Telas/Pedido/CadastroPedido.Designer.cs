
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
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.maos_pnl = new System.Windows.Forms.Panel();
            this.txt_idPedido = new System.Windows.Forms.TextBox();
            this.maos_lbl = new System.Windows.Forms.Label();
            this.produzir_pnl = new System.Windows.Forms.Panel();
            this.qntdEstoque_tbx = new System.Windows.Forms.TextBox();
            this.txt_idProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.maos_pnl.SuspendLayout();
            this.produzir_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(302, 56);
            this.ttl_lbl.TabIndex = 13;
            this.ttl_lbl.Text = "Cadastrar Produção";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maos_pnl
            // 
            this.maos_pnl.Controls.Add(this.txt_idPedido);
            this.maos_pnl.Controls.Add(this.maos_lbl);
            this.maos_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.maos_pnl.Location = new System.Drawing.Point(32, 56);
            this.maos_pnl.Name = "maos_pnl";
            this.maos_pnl.Size = new System.Drawing.Size(302, 48);
            this.maos_pnl.TabIndex = 15;
            // 
            // txt_idPedido
            // 
            this.txt_idPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_idPedido.Location = new System.Drawing.Point(0, 17);
            this.txt_idPedido.Name = "txt_idPedido";
            this.txt_idPedido.Size = new System.Drawing.Size(302, 20);
            this.txt_idPedido.TabIndex = 1;
            // 
            // maos_lbl
            // 
            this.maos_lbl.AutoSize = true;
            this.maos_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.maos_lbl.Location = new System.Drawing.Point(0, 0);
            this.maos_lbl.Name = "maos_lbl";
            this.maos_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.maos_lbl.Size = new System.Drawing.Size(52, 17);
            this.maos_lbl.TabIndex = 0;
            this.maos_lbl.Text = "Id Pedido";
            // 
            // produzir_pnl
            // 
            this.produzir_pnl.Controls.Add(this.qntdEstoque_tbx);
            this.produzir_pnl.Controls.Add(this.txt_idProduto);
            this.produzir_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.produzir_pnl.Location = new System.Drawing.Point(32, 104);
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
            this.panel1.Location = new System.Drawing.Point(32, 152);
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
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastrar.BackColor = System.Drawing.Color.Lime;
            this.cadastrar.Location = new System.Drawing.Point(65, 386);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(81, 32);
            this.cadastrar.TabIndex = 20;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.Red;
            this.cancelar_btn.Location = new System.Drawing.Point(203, 386);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(90, 32);
            this.cancelar_btn.TabIndex = 21;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = false;
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.produzir_pnl);
            this.Controls.Add(this.maos_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Name = "CadastroPedido";
            this.Text = "CadastroPedido";
            this.maos_pnl.ResumeLayout(false);
            this.maos_pnl.PerformLayout();
            this.produzir_pnl.ResumeLayout(false);
            this.produzir_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel maos_pnl;
        private System.Windows.Forms.TextBox txt_idPedido;
        private System.Windows.Forms.Label maos_lbl;
        private System.Windows.Forms.Panel produzir_pnl;
        private System.Windows.Forms.TextBox qntdEstoque_tbx;
        private System.Windows.Forms.Label txt_idProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_Quantidade;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button cancelar_btn;
    }
}