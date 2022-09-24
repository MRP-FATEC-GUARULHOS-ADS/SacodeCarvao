
namespace MRP_SdC
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.estado_pnl = new System.Windows.Forms.Panel();
            this.estado_clb = new System.Windows.Forms.CheckedListBox();
            this.estado_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ValorProduto = new System.Windows.Forms.TextBox();
            this.lbl_ValorProduto = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.valor_pnl = new System.Windows.Forms.Panel();
            this.txt_DescricaoProduto = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.descr_pnl = new System.Windows.Forms.Panel();
            this.txt_ModeloProduto = new System.Windows.Forms.TextBox();
            this.lbl_ModeloProduto = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.estado_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.valor_pnl.SuspendLayout();
            this.descr_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.estado_pnl);
            this.corpo_pnl.Controls.Add(this.panel1);
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.valor_pnl);
            this.corpo_pnl.Controls.Add(this.descr_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(304, 542);
            this.corpo_pnl.TabIndex = 0;
            // 
            // estado_pnl
            // 
            this.estado_pnl.Controls.Add(this.estado_clb);
            this.estado_pnl.Controls.Add(this.estado_lbl);
            this.estado_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estado_pnl.Location = new System.Drawing.Point(32, 256);
            this.estado_pnl.Name = "estado_pnl";
            this.estado_pnl.Size = new System.Drawing.Size(240, 58);
            this.estado_pnl.TabIndex = 13;
            // 
            // estado_clb
            // 
            this.estado_clb.BackColor = System.Drawing.SystemColors.Control;
            this.estado_clb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado_clb.CheckOnClick = true;
            this.estado_clb.Dock = System.Windows.Forms.DockStyle.Top;
            this.estado_clb.FormattingEnabled = true;
            this.estado_clb.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.estado_clb.Location = new System.Drawing.Point(0, 17);
            this.estado_clb.Name = "estado_clb";
            this.estado_clb.Size = new System.Drawing.Size(240, 30);
            this.estado_clb.TabIndex = 1;
            // 
            // estado_lbl
            // 
            this.estado_lbl.AutoSize = true;
            this.estado_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estado_lbl.Location = new System.Drawing.Point(0, 0);
            this.estado_lbl.Name = "estado_lbl";
            this.estado_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estado_lbl.Size = new System.Drawing.Size(114, 17);
            this.estado_lbl.TabIndex = 0;
            this.estado_lbl.Text = "Adicionar à produção?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ValorProduto);
            this.panel1.Controls.Add(this.lbl_ValorProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 48);
            this.panel1.TabIndex = 9;
            // 
            // txt_ValorProduto
            // 
            this.txt_ValorProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ValorProduto.Location = new System.Drawing.Point(0, 17);
            this.txt_ValorProduto.Name = "txt_ValorProduto";
            this.txt_ValorProduto.Size = new System.Drawing.Size(240, 20);
            this.txt_ValorProduto.TabIndex = 1;
            // 
            // lbl_ValorProduto
            // 
            this.lbl_ValorProduto.AutoSize = true;
            this.lbl_ValorProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ValorProduto.Location = new System.Drawing.Point(0, 0);
            this.lbl_ValorProduto.Name = "lbl_ValorProduto";
            this.lbl_ValorProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_ValorProduto.Size = new System.Drawing.Size(86, 17);
            this.lbl_ValorProduto.TabIndex = 0;
            this.lbl_ValorProduto.Text = "Valor do Produto";
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 494);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(240, 48);
            this.barraInf_pnl.TabIndex = 6;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelar_btn.Location = new System.Drawing.Point(3, 10);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(112, 23);
            this.cancelar_btn.TabIndex = 1;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok_btn.Location = new System.Drawing.Point(125, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // valor_pnl
            // 
            this.valor_pnl.Controls.Add(this.txt_DescricaoProduto);
            this.valor_pnl.Controls.Add(this.lbl_Descricao);
            this.valor_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.valor_pnl.Location = new System.Drawing.Point(32, 100);
            this.valor_pnl.Name = "valor_pnl";
            this.valor_pnl.Size = new System.Drawing.Size(240, 108);
            this.valor_pnl.TabIndex = 3;
            // 
            // txt_DescricaoProduto
            // 
            this.txt_DescricaoProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_DescricaoProduto.Location = new System.Drawing.Point(0, 17);
            this.txt_DescricaoProduto.Multiline = true;
            this.txt_DescricaoProduto.Name = "txt_DescricaoProduto";
            this.txt_DescricaoProduto.Size = new System.Drawing.Size(240, 88);
            this.txt_DescricaoProduto.TabIndex = 2;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Descricao.Location = new System.Drawing.Point(0, 0);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_Descricao.Size = new System.Drawing.Size(110, 17);
            this.lbl_Descricao.TabIndex = 0;
            this.lbl_Descricao.Text = "Descrição do Produto";
            // 
            // descr_pnl
            // 
            this.descr_pnl.Controls.Add(this.txt_ModeloProduto);
            this.descr_pnl.Controls.Add(this.lbl_ModeloProduto);
            this.descr_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_pnl.Location = new System.Drawing.Point(32, 52);
            this.descr_pnl.Name = "descr_pnl";
            this.descr_pnl.Size = new System.Drawing.Size(240, 48);
            this.descr_pnl.TabIndex = 2;
            // 
            // txt_ModeloProduto
            // 
            this.txt_ModeloProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ModeloProduto.Location = new System.Drawing.Point(0, 17);
            this.txt_ModeloProduto.Name = "txt_ModeloProduto";
            this.txt_ModeloProduto.Size = new System.Drawing.Size(240, 20);
            this.txt_ModeloProduto.TabIndex = 2;
            // 
            // lbl_ModeloProduto
            // 
            this.lbl_ModeloProduto.AutoSize = true;
            this.lbl_ModeloProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ModeloProduto.Location = new System.Drawing.Point(0, 0);
            this.lbl_ModeloProduto.Name = "lbl_ModeloProduto";
            this.lbl_ModeloProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_ModeloProduto.Size = new System.Drawing.Size(97, 17);
            this.lbl_ModeloProduto.TabIndex = 0;
            this.lbl_ModeloProduto.Text = "Modelo do Produto";
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(240, 52);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Cadastrar produto";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(272, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 542);
            this.esp_dir_pnl.TabIndex = 8;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 542);
            this.esp_esq_pnl.TabIndex = 7;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 542);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de produto";
            this.corpo_pnl.ResumeLayout(false);
            this.estado_pnl.ResumeLayout(false);
            this.estado_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.valor_pnl.ResumeLayout(false);
            this.valor_pnl.PerformLayout();
            this.descr_pnl.ResumeLayout(false);
            this.descr_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel valor_pnl;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Panel descr_pnl;
        private System.Windows.Forms.Label lbl_ModeloProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ValorProduto;
        private System.Windows.Forms.Label lbl_ValorProduto;
        private System.Windows.Forms.TextBox txt_DescricaoProduto;
        private System.Windows.Forms.TextBox txt_ModeloProduto;
        public System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel estado_pnl;
        private System.Windows.Forms.CheckedListBox estado_clb;
        private System.Windows.Forms.Label estado_lbl;
    }
}