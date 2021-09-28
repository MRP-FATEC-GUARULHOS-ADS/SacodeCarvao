
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
            this.explosao_pnl = new System.Windows.Forms.Panel();
            this.explosao_btn = new System.Windows.Forms.Button();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.estado_pnl = new System.Windows.Forms.Panel();
            this.estado_clb = new System.Windows.Forms.CheckedListBox();
            this.estado_lbl = new System.Windows.Forms.Label();
            this.valor_pnl = new System.Windows.Forms.Panel();
            this.valor_tbx = new System.Windows.Forms.TextBox();
            this.valor_lbl = new System.Windows.Forms.Label();
            this.descr_pnl = new System.Windows.Forms.Panel();
            this.descr_tbm = new System.Windows.Forms.TextBox();
            this.descr_lbl = new System.Windows.Forms.Label();
            this.modelo_pnl = new System.Windows.Forms.Panel();
            this.modelo_tbx = new System.Windows.Forms.TextBox();
            this.modelo_lbl = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.explosao_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.estado_pnl.SuspendLayout();
            this.valor_pnl.SuspendLayout();
            this.descr_pnl.SuspendLayout();
            this.modelo_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.explosao_pnl);
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.estado_pnl);
            this.corpo_pnl.Controls.Add(this.valor_pnl);
            this.corpo_pnl.Controls.Add(this.descr_pnl);
            this.corpo_pnl.Controls.Add(this.modelo_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(304, 409);
            this.corpo_pnl.TabIndex = 0;
            // 
            // explosao_pnl
            // 
            this.explosao_pnl.Controls.Add(this.explosao_btn);
            this.explosao_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.explosao_pnl.Location = new System.Drawing.Point(32, 313);
            this.explosao_pnl.Name = "explosao_pnl";
            this.explosao_pnl.Size = new System.Drawing.Size(240, 48);
            this.explosao_pnl.TabIndex = 5;
            // 
            // explosao_btn
            // 
            this.explosao_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.explosao_btn.Location = new System.Drawing.Point(3, 10);
            this.explosao_btn.Name = "explosao_btn";
            this.explosao_btn.Size = new System.Drawing.Size(234, 23);
            this.explosao_btn.TabIndex = 0;
            this.explosao_btn.Text = "Cadastrar Componentes do Produto";
            this.explosao_btn.UseVisualStyleBackColor = true;
            this.explosao_btn.Click += new System.EventHandler(this.Explosao_Prod_Click);
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 361);
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
            this.ok_btn.Enabled = false;
            this.ok_btn.Location = new System.Drawing.Point(125, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // estado_pnl
            // 
            this.estado_pnl.Controls.Add(this.estado_clb);
            this.estado_pnl.Controls.Add(this.estado_lbl);
            this.estado_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estado_pnl.Location = new System.Drawing.Point(32, 240);
            this.estado_pnl.Name = "estado_pnl";
            this.estado_pnl.Size = new System.Drawing.Size(240, 58);
            this.estado_pnl.TabIndex = 4;
            // 
            // estado_clb
            // 
            this.estado_clb.BackColor = System.Drawing.SystemColors.Control;
            this.estado_clb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado_clb.CheckOnClick = true;
            this.estado_clb.Dock = System.Windows.Forms.DockStyle.Top;
            this.estado_clb.Enabled = false;
            this.estado_clb.FormattingEnabled = true;
            this.estado_clb.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.estado_clb.Location = new System.Drawing.Point(0, 17);
            this.estado_clb.Name = "estado_clb";
            this.estado_clb.Size = new System.Drawing.Size(240, 30);
            this.estado_clb.TabIndex = 1;
            this.estado_clb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Estado_ItemCheck);
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
            // valor_pnl
            // 
            this.valor_pnl.Controls.Add(this.valor_tbx);
            this.valor_pnl.Controls.Add(this.valor_lbl);
            this.valor_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.valor_pnl.Location = new System.Drawing.Point(32, 192);
            this.valor_pnl.Name = "valor_pnl";
            this.valor_pnl.Size = new System.Drawing.Size(240, 48);
            this.valor_pnl.TabIndex = 3;
            // 
            // valor_tbx
            // 
            this.valor_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.valor_tbx.Location = new System.Drawing.Point(0, 17);
            this.valor_tbx.Name = "valor_tbx";
            this.valor_tbx.Size = new System.Drawing.Size(240, 20);
            this.valor_tbx.TabIndex = 1;
            // 
            // valor_lbl
            // 
            this.valor_lbl.AutoSize = true;
            this.valor_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.valor_lbl.Location = new System.Drawing.Point(0, 0);
            this.valor_lbl.Name = "valor_lbl";
            this.valor_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.valor_lbl.Size = new System.Drawing.Size(86, 17);
            this.valor_lbl.TabIndex = 0;
            this.valor_lbl.Text = "Valor do Produto";
            // 
            // descr_pnl
            // 
            this.descr_pnl.Controls.Add(this.descr_tbm);
            this.descr_pnl.Controls.Add(this.descr_lbl);
            this.descr_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_pnl.Location = new System.Drawing.Point(32, 100);
            this.descr_pnl.Name = "descr_pnl";
            this.descr_pnl.Size = new System.Drawing.Size(240, 92);
            this.descr_pnl.TabIndex = 2;
            // 
            // descr_tbm
            // 
            this.descr_tbm.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_tbm.Location = new System.Drawing.Point(0, 17);
            this.descr_tbm.Multiline = true;
            this.descr_tbm.Name = "descr_tbm";
            this.descr_tbm.Size = new System.Drawing.Size(240, 64);
            this.descr_tbm.TabIndex = 1;
            // 
            // descr_lbl
            // 
            this.descr_lbl.AutoSize = true;
            this.descr_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_lbl.Location = new System.Drawing.Point(0, 0);
            this.descr_lbl.Name = "descr_lbl";
            this.descr_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.descr_lbl.Size = new System.Drawing.Size(110, 17);
            this.descr_lbl.TabIndex = 0;
            this.descr_lbl.Text = "Descrição do Produto";
            // 
            // modelo_pnl
            // 
            this.modelo_pnl.Controls.Add(this.modelo_tbx);
            this.modelo_pnl.Controls.Add(this.modelo_lbl);
            this.modelo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_pnl.Location = new System.Drawing.Point(32, 52);
            this.modelo_pnl.Name = "modelo_pnl";
            this.modelo_pnl.Size = new System.Drawing.Size(240, 48);
            this.modelo_pnl.TabIndex = 1;
            // 
            // modelo_tbx
            // 
            this.modelo_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_tbx.Location = new System.Drawing.Point(0, 17);
            this.modelo_tbx.Name = "modelo_tbx";
            this.modelo_tbx.Size = new System.Drawing.Size(240, 20);
            this.modelo_tbx.TabIndex = 1;
            this.modelo_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // modelo_lbl
            // 
            this.modelo_lbl.AutoSize = true;
            this.modelo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_lbl.Location = new System.Drawing.Point(0, 0);
            this.modelo_lbl.Name = "modelo_lbl";
            this.modelo_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.modelo_lbl.Size = new System.Drawing.Size(97, 17);
            this.modelo_lbl.TabIndex = 0;
            this.modelo_lbl.Text = "Modelo do Produto";
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
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 409);
            this.esp_dir_pnl.TabIndex = 8;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 409);
            this.esp_esq_pnl.TabIndex = 7;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 409);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de produto";
            this.corpo_pnl.ResumeLayout(false);
            this.explosao_pnl.ResumeLayout(false);
            this.barraInf_pnl.ResumeLayout(false);
            this.estado_pnl.ResumeLayout(false);
            this.estado_pnl.PerformLayout();
            this.valor_pnl.ResumeLayout(false);
            this.valor_pnl.PerformLayout();
            this.descr_pnl.ResumeLayout(false);
            this.descr_pnl.PerformLayout();
            this.modelo_pnl.ResumeLayout(false);
            this.modelo_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel modelo_pnl;
        private System.Windows.Forms.TextBox modelo_tbx;
        private System.Windows.Forms.Label modelo_lbl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel valor_pnl;
        private System.Windows.Forms.TextBox valor_tbx;
        private System.Windows.Forms.Label valor_lbl;
        private System.Windows.Forms.Panel explosao_pnl;
        private System.Windows.Forms.Button explosao_btn;
        private System.Windows.Forms.Panel descr_pnl;
        private System.Windows.Forms.TextBox descr_tbm;
        private System.Windows.Forms.Label descr_lbl;
        private System.Windows.Forms.Panel estado_pnl;
        private System.Windows.Forms.CheckedListBox estado_clb;
        private System.Windows.Forms.Label estado_lbl;
    }
}