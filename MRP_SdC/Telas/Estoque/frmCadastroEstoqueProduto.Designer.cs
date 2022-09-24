
namespace MRP_SdC.Telas.Estoque
{
    partial class frmCadastroEstoqueProduto
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
            this.descr_pnl = new System.Windows.Forms.Panel();
            this.cmbModeloProduto = new System.Windows.Forms.ComboBox();
            this.lbl_ModeloProduto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuantidadeAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstoqueSeguranca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descr_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(261, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 450);
            this.esp_dir_pnl.TabIndex = 9;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 450);
            this.esp_esq_pnl.TabIndex = 10;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(229, 52);
            this.ttl_lbl.TabIndex = 11;
            this.ttl_lbl.Text = "Cadastrar produto";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descr_pnl
            // 
            this.descr_pnl.Controls.Add(this.cmbModeloProduto);
            this.descr_pnl.Controls.Add(this.lbl_ModeloProduto);
            this.descr_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_pnl.Location = new System.Drawing.Point(32, 52);
            this.descr_pnl.Name = "descr_pnl";
            this.descr_pnl.Size = new System.Drawing.Size(229, 48);
            this.descr_pnl.TabIndex = 12;
            // 
            // cmbModeloProduto
            // 
            this.cmbModeloProduto.FormattingEnabled = true;
            this.cmbModeloProduto.Location = new System.Drawing.Point(4, 21);
            this.cmbModeloProduto.Name = "cmbModeloProduto";
            this.cmbModeloProduto.Size = new System.Drawing.Size(219, 21);
            this.cmbModeloProduto.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQuantidadeAtual);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 48);
            this.panel2.TabIndex = 13;
            // 
            // txtQuantidadeAtual
            // 
            this.txtQuantidadeAtual.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadeAtual.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadeAtual.Name = "txtQuantidadeAtual";
            this.txtQuantidadeAtual.Size = new System.Drawing.Size(229, 20);
            this.txtQuantidadeAtual.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade Atual Estoque";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEstoqueSeguranca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 48);
            this.panel1.TabIndex = 14;
            // 
            // txtEstoqueSeguranca
            // 
            this.txtEstoqueSeguranca.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEstoqueSeguranca.Location = new System.Drawing.Point(0, 17);
            this.txtEstoqueSeguranca.Name = "txtEstoqueSeguranca";
            this.txtEstoqueSeguranca.Size = new System.Drawing.Size(229, 20);
            this.txtEstoqueSeguranca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estoque de Segurança";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLeadTime);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(32, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 48);
            this.panel3.TabIndex = 15;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLeadTime.Location = new System.Drawing.Point(0, 17);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(229, 20);
            this.txtLeadTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lead Time";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtLote);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(32, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 48);
            this.panel4.TabIndex = 16;
            // 
            // txtLote
            // 
            this.txtLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLote.Location = new System.Drawing.Point(0, 17);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(229, 20);
            this.txtLote.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lote";
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.btnCadastrar);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 402);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(229, 48);
            this.barraInf_pnl.TabIndex = 17;
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
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadastrar.Location = new System.Drawing.Point(114, 10);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "OK";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIdProduto);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(32, 292);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 48);
            this.panel5.TabIndex = 18;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdProduto.Location = new System.Drawing.Point(0, 17);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(229, 20);
            this.txtIdProduto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id Produto";
            // 
            // frmCadastroEstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.barraInf_pnl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.descr_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Name = "frmCadastroEstoqueProduto";
            this.Text = "frmEstoqueProduto";
            this.Load += new System.EventHandler(this.frmCadastroEstoqueProduto_Load);
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel descr_pnl;
        private System.Windows.Forms.ComboBox cmbModeloProduto;
        private System.Windows.Forms.Label lbl_ModeloProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQuantidadeAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEstoqueSeguranca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        public System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label5;
    }
}