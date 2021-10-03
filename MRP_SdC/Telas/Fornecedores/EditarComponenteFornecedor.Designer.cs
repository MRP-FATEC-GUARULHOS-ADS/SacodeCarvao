
namespace MRP_SdC
{
    partial class EditarComponenteFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarComponenteFornecedor));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.custo_pnl = new System.Windows.Forms.Panel();
            this.custo_tbx = new System.Windows.Forms.TextBox();
            this.custo_lbl = new System.Windows.Forms.Label();
            this.lead_pnl = new System.Windows.Forms.Panel();
            this.lead_tbx = new System.Windows.Forms.TextBox();
            this.lead_lbl = new System.Windows.Forms.Label();
            this.comp_pnl = new System.Windows.Forms.Panel();
            this.comp_cbb = new System.Windows.Forms.ComboBox();
            this.comp_lbl = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.custo_pnl.SuspendLayout();
            this.lead_pnl.SuspendLayout();
            this.comp_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.custo_pnl);
            this.corpo_pnl.Controls.Add(this.lead_pnl);
            this.corpo_pnl.Controls.Add(this.comp_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(416, 281);
            this.corpo_pnl.TabIndex = 0;
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 233);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(352, 48);
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
            this.ok_btn.Location = new System.Drawing.Point(237, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // custo_pnl
            // 
            this.custo_pnl.Controls.Add(this.custo_tbx);
            this.custo_pnl.Controls.Add(this.custo_lbl);
            this.custo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.custo_pnl.Location = new System.Drawing.Point(32, 148);
            this.custo_pnl.Name = "custo_pnl";
            this.custo_pnl.Size = new System.Drawing.Size(352, 48);
            this.custo_pnl.TabIndex = 3;
            // 
            // custo_tbx
            // 
            this.custo_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.custo_tbx.Location = new System.Drawing.Point(0, 17);
            this.custo_tbx.Name = "custo_tbx";
            this.custo_tbx.Size = new System.Drawing.Size(352, 20);
            this.custo_tbx.TabIndex = 1;
            this.custo_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // custo_lbl
            // 
            this.custo_lbl.AutoSize = true;
            this.custo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.custo_lbl.Location = new System.Drawing.Point(0, 0);
            this.custo_lbl.Name = "custo_lbl";
            this.custo_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.custo_lbl.Size = new System.Drawing.Size(112, 17);
            this.custo_lbl.TabIndex = 0;
            this.custo_lbl.Text = "Custo do Componente";
            // 
            // lead_pnl
            // 
            this.lead_pnl.Controls.Add(this.lead_tbx);
            this.lead_pnl.Controls.Add(this.lead_lbl);
            this.lead_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lead_pnl.Location = new System.Drawing.Point(32, 100);
            this.lead_pnl.Name = "lead_pnl";
            this.lead_pnl.Size = new System.Drawing.Size(352, 48);
            this.lead_pnl.TabIndex = 2;
            // 
            // lead_tbx
            // 
            this.lead_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.lead_tbx.Location = new System.Drawing.Point(0, 17);
            this.lead_tbx.Name = "lead_tbx";
            this.lead_tbx.Size = new System.Drawing.Size(352, 20);
            this.lead_tbx.TabIndex = 2;
            this.lead_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // lead_lbl
            // 
            this.lead_lbl.AutoSize = true;
            this.lead_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lead_lbl.Location = new System.Drawing.Point(0, 0);
            this.lead_lbl.Name = "lead_lbl";
            this.lead_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lead_lbl.Size = new System.Drawing.Size(57, 17);
            this.lead_lbl.TabIndex = 0;
            this.lead_lbl.Text = "Lead Time";
            // 
            // comp_pnl
            // 
            this.comp_pnl.Controls.Add(this.comp_cbb);
            this.comp_pnl.Controls.Add(this.comp_lbl);
            this.comp_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.comp_pnl.Location = new System.Drawing.Point(32, 52);
            this.comp_pnl.Name = "comp_pnl";
            this.comp_pnl.Size = new System.Drawing.Size(352, 48);
            this.comp_pnl.TabIndex = 1;
            // 
            // comp_cbb
            // 
            this.comp_cbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.comp_cbb.Enabled = false;
            this.comp_cbb.FormattingEnabled = true;
            this.comp_cbb.Items.AddRange(new object[] {
            "HD",
            "SSD",
            "Memória RAM",
            "Placa de Vídeo",
            "Placa Mãe",
            "Processador",
            "Sistema Operacional",
            "Monitor",
            "Torre",
            "Parafuso"});
            this.comp_cbb.Location = new System.Drawing.Point(0, 17);
            this.comp_cbb.Name = "comp_cbb";
            this.comp_cbb.Size = new System.Drawing.Size(352, 21);
            this.comp_cbb.TabIndex = 1;
            this.comp_cbb.SelectedIndexChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // comp_lbl
            // 
            this.comp_lbl.AutoSize = true;
            this.comp_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.comp_lbl.Location = new System.Drawing.Point(0, 0);
            this.comp_lbl.Name = "comp_lbl";
            this.comp_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.comp_lbl.Size = new System.Drawing.Size(67, 17);
            this.comp_lbl.TabIndex = 0;
            this.comp_lbl.Text = "Componente";
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(352, 52);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Fornecedor";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(384, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 281);
            this.esp_dir_pnl.TabIndex = 8;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 281);
            this.esp_esq_pnl.TabIndex = 7;
            // 
            // EditarComponenteFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 281);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarComponenteFornecedor";
            this.Text = "Cadastro de componente";
            this.corpo_pnl.ResumeLayout(false);
            this.barraInf_pnl.ResumeLayout(false);
            this.custo_pnl.ResumeLayout(false);
            this.custo_pnl.PerformLayout();
            this.lead_pnl.ResumeLayout(false);
            this.lead_pnl.PerformLayout();
            this.comp_pnl.ResumeLayout(false);
            this.comp_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel custo_pnl;
        private System.Windows.Forms.TextBox custo_tbx;
        private System.Windows.Forms.Label custo_lbl;
        private System.Windows.Forms.Panel comp_pnl;
        private System.Windows.Forms.ComboBox comp_cbb;
        private System.Windows.Forms.Label comp_lbl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel lead_pnl;
        private System.Windows.Forms.Label lead_lbl;
        private System.Windows.Forms.TextBox lead_tbx;
    }
}