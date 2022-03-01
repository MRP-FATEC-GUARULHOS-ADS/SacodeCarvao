
namespace MRP_SdC
{
    partial class ExplosaoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplosaoProduto));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.estado_pnl = new System.Windows.Forms.Panel();
            this.estado_clb = new System.Windows.Forms.CheckedListBox();
            this.estado_lbl = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.comps_pnl = new System.Windows.Forms.Panel();
            this.add_pnl = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.comp_pnl = new System.Windows.Forms.Panel();
            this.comp_nome_pnl = new System.Windows.Forms.Panel();
            this.comp_nome_cbb = new System.Windows.Forms.ComboBox();
            this.comp_nome_lbl = new System.Windows.Forms.Label();
            this.comp_qnt_pnl = new System.Windows.Forms.Panel();
            this.comp_qnt_cbb = new System.Windows.Forms.ComboBox();
            this.comp_qnt_lbl = new System.Windows.Forms.Label();
            this.fechar_pnl = new System.Windows.Forms.Panel();
            this.fechar_btn = new System.Windows.Forms.Button();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultaArvoreProduto = new System.Windows.Forms.Button();
            this.corpo_pnl.SuspendLayout();
            this.estado_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.comps_pnl.SuspendLayout();
            this.add_pnl.SuspendLayout();
            this.comp_pnl.SuspendLayout();
            this.comp_nome_pnl.SuspendLayout();
            this.comp_qnt_pnl.SuspendLayout();
            this.fechar_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.panel1);
            this.corpo_pnl.Controls.Add(this.estado_pnl);
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.comps_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(352, 537);
            this.corpo_pnl.TabIndex = 0;
            // 
            // estado_pnl
            // 
            this.estado_pnl.Controls.Add(this.estado_clb);
            this.estado_pnl.Controls.Add(this.estado_lbl);
            this.estado_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.estado_pnl.Location = new System.Drawing.Point(32, 431);
            this.estado_pnl.Name = "estado_pnl";
            this.estado_pnl.Size = new System.Drawing.Size(288, 58);
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
            this.estado_clb.Size = new System.Drawing.Size(288, 30);
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
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 489);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(288, 48);
            this.barraInf_pnl.TabIndex = 10;
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
            this.cancelar_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok_btn.Enabled = false;
            this.ok_btn.Location = new System.Drawing.Point(173, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // comps_pnl
            // 
            this.comps_pnl.AutoSize = true;
            this.comps_pnl.Controls.Add(this.add_pnl);
            this.comps_pnl.Controls.Add(this.comp_pnl);
            this.comps_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.comps_pnl.Location = new System.Drawing.Point(32, 52);
            this.comps_pnl.Name = "comps_pnl";
            this.comps_pnl.Size = new System.Drawing.Size(288, 136);
            this.comps_pnl.TabIndex = 1;
            // 
            // add_pnl
            // 
            this.add_pnl.Controls.Add(this.add_btn);
            this.add_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_pnl.Location = new System.Drawing.Point(0, 68);
            this.add_pnl.Name = "add_pnl";
            this.add_pnl.Size = new System.Drawing.Size(288, 68);
            this.add_pnl.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(24, 14);
            this.add_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(240, 41);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "adicionar componente";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // comp_pnl
            // 
            this.comp_pnl.Controls.Add(this.comp_nome_pnl);
            this.comp_pnl.Controls.Add(this.comp_qnt_pnl);
            this.comp_pnl.Controls.Add(this.fechar_pnl);
            this.comp_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.comp_pnl.Location = new System.Drawing.Point(0, 0);
            this.comp_pnl.Name = "comp_pnl";
            this.comp_pnl.Size = new System.Drawing.Size(288, 68);
            this.comp_pnl.TabIndex = 0;
            // 
            // comp_nome_pnl
            // 
            this.comp_nome_pnl.Controls.Add(this.comp_nome_cbb);
            this.comp_nome_pnl.Controls.Add(this.comp_nome_lbl);
            this.comp_nome_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_nome_pnl.Location = new System.Drawing.Point(0, 20);
            this.comp_nome_pnl.Name = "comp_nome_pnl";
            this.comp_nome_pnl.Size = new System.Drawing.Size(232, 48);
            this.comp_nome_pnl.TabIndex = 1;
            // 
            // comp_nome_cbb
            // 
            this.comp_nome_cbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_nome_cbb.FormattingEnabled = true;
            this.comp_nome_cbb.Items.AddRange(new object[] {
            "HD",
            "SSD",
            "Memória RAM",
            "Placa de Vídeo",
            "Placa Mãe",
            "Processador",
            "Sistema",
            "Tela"});
            this.comp_nome_cbb.Location = new System.Drawing.Point(0, 17);
            this.comp_nome_cbb.Name = "comp_nome_cbb";
            this.comp_nome_cbb.Size = new System.Drawing.Size(232, 21);
            this.comp_nome_cbb.TabIndex = 1;
            // 
            // comp_nome_lbl
            // 
            this.comp_nome_lbl.AutoSize = true;
            this.comp_nome_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.comp_nome_lbl.Location = new System.Drawing.Point(0, 0);
            this.comp_nome_lbl.Name = "comp_nome_lbl";
            this.comp_nome_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.comp_nome_lbl.Size = new System.Drawing.Size(67, 17);
            this.comp_nome_lbl.TabIndex = 0;
            this.comp_nome_lbl.Text = "Componente";
            // 
            // comp_qnt_pnl
            // 
            this.comp_qnt_pnl.Controls.Add(this.comp_qnt_cbb);
            this.comp_qnt_pnl.Controls.Add(this.comp_qnt_lbl);
            this.comp_qnt_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.comp_qnt_pnl.Location = new System.Drawing.Point(232, 20);
            this.comp_qnt_pnl.Name = "comp_qnt_pnl";
            this.comp_qnt_pnl.Size = new System.Drawing.Size(56, 48);
            this.comp_qnt_pnl.TabIndex = 2;
            // 
            // comp_qnt_cbb
            // 
            this.comp_qnt_cbb.Dock = System.Windows.Forms.DockStyle.Right;
            this.comp_qnt_cbb.FormattingEnabled = true;
            this.comp_qnt_cbb.Items.AddRange(new object[] {
            "HD",
            "SSD",
            "Memória RAM",
            "Placa de Vídeo",
            "Placa Mãe",
            "Processador",
            "Sistema",
            "Tela"});
            this.comp_qnt_cbb.Location = new System.Drawing.Point(8, 17);
            this.comp_qnt_cbb.Name = "comp_qnt_cbb";
            this.comp_qnt_cbb.Size = new System.Drawing.Size(48, 21);
            this.comp_qnt_cbb.TabIndex = 1;
            // 
            // comp_qnt_lbl
            // 
            this.comp_qnt_lbl.AutoSize = true;
            this.comp_qnt_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.comp_qnt_lbl.Location = new System.Drawing.Point(0, 0);
            this.comp_qnt_lbl.Name = "comp_qnt_lbl";
            this.comp_qnt_lbl.Padding = new System.Windows.Forms.Padding(6, 0, 0, 4);
            this.comp_qnt_lbl.Size = new System.Drawing.Size(30, 17);
            this.comp_qnt_lbl.TabIndex = 0;
            this.comp_qnt_lbl.Text = "Qnt";
            this.comp_qnt_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fechar_pnl
            // 
            this.fechar_pnl.Controls.Add(this.fechar_btn);
            this.fechar_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.fechar_pnl.Location = new System.Drawing.Point(0, 0);
            this.fechar_pnl.Name = "fechar_pnl";
            this.fechar_pnl.Size = new System.Drawing.Size(288, 20);
            this.fechar_pnl.TabIndex = 0;
            // 
            // fechar_btn
            // 
            this.fechar_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.fechar_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fechar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar_btn.Location = new System.Drawing.Point(266, 0);
            this.fechar_btn.Margin = new System.Windows.Forms.Padding(0);
            this.fechar_btn.Name = "fechar_btn";
            this.fechar_btn.Size = new System.Drawing.Size(22, 20);
            this.fechar_btn.TabIndex = 0;
            this.fechar_btn.Text = "×";
            this.fechar_btn.UseVisualStyleBackColor = true;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(288, 52);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Árvore do produto";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(320, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 537);
            this.esp_dir_pnl.TabIndex = 12;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 537);
            this.esp_esq_pnl.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultaArvoreProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 68);
            this.panel1.TabIndex = 14;
            // 
            // btnConsultaArvoreProduto
            // 
            this.btnConsultaArvoreProduto.Location = new System.Drawing.Point(24, 14);
            this.btnConsultaArvoreProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultaArvoreProduto.Name = "btnConsultaArvoreProduto";
            this.btnConsultaArvoreProduto.Size = new System.Drawing.Size(240, 41);
            this.btnConsultaArvoreProduto.TabIndex = 0;
            this.btnConsultaArvoreProduto.Text = "consultar árvore produto";
            this.btnConsultaArvoreProduto.UseVisualStyleBackColor = true;
            this.btnConsultaArvoreProduto.Click += new System.EventHandler(this.btnConsultaArvoreProduto_Click);
            // 
            // ExplosaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 537);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExplosaoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Árvore do produto";
            this.corpo_pnl.ResumeLayout(false);
            this.corpo_pnl.PerformLayout();
            this.estado_pnl.ResumeLayout(false);
            this.estado_pnl.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.comps_pnl.ResumeLayout(false);
            this.add_pnl.ResumeLayout(false);
            this.comp_pnl.ResumeLayout(false);
            this.comp_nome_pnl.ResumeLayout(false);
            this.comp_nome_pnl.PerformLayout();
            this.comp_qnt_pnl.ResumeLayout(false);
            this.comp_qnt_pnl.PerformLayout();
            this.fechar_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel comp_pnl;
        private System.Windows.Forms.Panel comp_nome_pnl;
        private System.Windows.Forms.ComboBox comp_nome_cbb;
        private System.Windows.Forms.Panel comp_qnt_pnl;
        private System.Windows.Forms.ComboBox comp_qnt_cbb;
        private System.Windows.Forms.Label comp_nome_lbl;
        private System.Windows.Forms.Label comp_qnt_lbl;
        private System.Windows.Forms.Panel comps_pnl;
        private System.Windows.Forms.Panel add_pnl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel fechar_pnl;
        private System.Windows.Forms.Button fechar_btn;
        private System.Windows.Forms.Panel estado_pnl;
        private System.Windows.Forms.CheckedListBox estado_clb;
        private System.Windows.Forms.Label estado_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultaArvoreProduto;
    }
}