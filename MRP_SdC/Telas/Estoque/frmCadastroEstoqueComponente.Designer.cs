
namespace MRP_SdC.Telas.Estoque
{
    partial class frmCadastroEstoqueComponente
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
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.descr_pnl = new System.Windows.Forms.Panel();
            this.cmbModeloComponente = new System.Windows.Forms.ComboBox();
            this.lbl_ModeloProduto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdComponente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantidadeAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEstoqueSeguranca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.descr_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 450);
            this.esp_esq_pnl.TabIndex = 11;
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(291, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 450);
            this.esp_dir_pnl.TabIndex = 12;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(259, 70);
            this.ttl_lbl.TabIndex = 13;
            this.ttl_lbl.Text = "Cadastrar Componente no Estoque";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descr_pnl
            // 
            this.descr_pnl.Controls.Add(this.cmbModeloComponente);
            this.descr_pnl.Controls.Add(this.lbl_ModeloProduto);
            this.descr_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_pnl.Location = new System.Drawing.Point(32, 70);
            this.descr_pnl.Name = "descr_pnl";
            this.descr_pnl.Size = new System.Drawing.Size(259, 48);
            this.descr_pnl.TabIndex = 14;
            // 
            // cmbModeloComponente
            // 
            this.cmbModeloComponente.FormattingEnabled = true;
            this.cmbModeloComponente.Location = new System.Drawing.Point(4, 21);
            this.cmbModeloComponente.Name = "cmbModeloComponente";
            this.cmbModeloComponente.Size = new System.Drawing.Size(219, 21);
            this.cmbModeloComponente.TabIndex = 1;
            // 
            // lbl_ModeloProduto
            // 
            this.lbl_ModeloProduto.AutoSize = true;
            this.lbl_ModeloProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ModeloProduto.Location = new System.Drawing.Point(0, 0);
            this.lbl_ModeloProduto.Name = "lbl_ModeloProduto";
            this.lbl_ModeloProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_ModeloProduto.Size = new System.Drawing.Size(120, 17);
            this.lbl_ModeloProduto.TabIndex = 0;
            this.lbl_ModeloProduto.Text = "Modelo do Componente";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIdComponente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 48);
            this.panel2.TabIndex = 15;
            // 
            // txtIdComponente
            // 
            this.txtIdComponente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdComponente.Location = new System.Drawing.Point(0, 17);
            this.txtIdComponente.Name = "txtIdComponente";
            this.txtIdComponente.Size = new System.Drawing.Size(259, 20);
            this.txtIdComponente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Componente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQuantidadeAtual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 48);
            this.panel1.TabIndex = 16;
            // 
            // txtQuantidadeAtual
            // 
            this.txtQuantidadeAtual.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadeAtual.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadeAtual.Name = "txtQuantidadeAtual";
            this.txtQuantidadeAtual.Size = new System.Drawing.Size(259, 20);
            this.txtQuantidadeAtual.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade Atual Estoque";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEstoqueSeguranca);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(32, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 48);
            this.panel3.TabIndex = 17;
            // 
            // txtEstoqueSeguranca
            // 
            this.txtEstoqueSeguranca.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEstoqueSeguranca.Location = new System.Drawing.Point(0, 17);
            this.txtEstoqueSeguranca.Name = "txtEstoqueSeguranca";
            this.txtEstoqueSeguranca.Size = new System.Drawing.Size(259, 20);
            this.txtEstoqueSeguranca.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estoque de Segurança";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtLeadTime);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(32, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 48);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 48);
            this.panel5.TabIndex = 19;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLeadTime.Location = new System.Drawing.Point(0, 17);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(259, 20);
            this.txtLeadTime.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lead Time";
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 402);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(259, 48);
            this.barraInf_pnl.TabIndex = 19;
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
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok_btn.Location = new System.Drawing.Point(144, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtLote);
            this.panel6.Controls.Add(this.lblLote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(32, 310);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(259, 92);
            this.panel6.TabIndex = 20;
            // 
            // txtLote
            // 
            this.txtLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLote.Location = new System.Drawing.Point(0, 17);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(259, 20);
            this.txtLote.TabIndex = 1;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLote.Location = new System.Drawing.Point(0, 0);
            this.lblLote.Name = "lblLote";
            this.lblLote.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblLote.Size = new System.Drawing.Size(28, 17);
            this.lblLote.TabIndex = 0;
            this.lblLote.Text = "Lote";
            // 
            // frmCadastroEstoqueComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.barraInf_pnl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.descr_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Name = "frmCadastroEstoqueComponente";
            this.Text = "Estoque de Componentes";
            this.Load += new System.EventHandler(this.frmCadastroEstoqueComponente_Load);
            this.descr_pnl.ResumeLayout(false);
            this.descr_pnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel descr_pnl;
        private System.Windows.Forms.ComboBox cmbModeloComponente;
        private System.Windows.Forms.Label lbl_ModeloProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdComponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantidadeAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEstoqueSeguranca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        public System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
    }
}