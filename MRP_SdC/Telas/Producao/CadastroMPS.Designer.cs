
namespace MRP_SdC.Telas.Producao
{
    partial class CadastroMPS
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
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.maos_lbl = new System.Windows.Forms.Label();
            this.produzir_pnl = new System.Windows.Forms.Panel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantidadePedido = new System.Windows.Forms.TextBox();
            this.lblQuantidadePedido = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuantidadePrevisaoDemanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuantidadeDemandaConsiderada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPlanoMestreProducao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maos_pnl.SuspendLayout();
            this.produzir_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(304, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 521);
            this.esp_dir_pnl.TabIndex = 10;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 521);
            this.esp_esq_pnl.TabIndex = 11;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(272, 56);
            this.ttl_lbl.TabIndex = 12;
            this.ttl_lbl.Text = "Cadastrar Produção";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maos_pnl
            // 
            this.maos_pnl.Controls.Add(this.txtIdProduto);
            this.maos_pnl.Controls.Add(this.maos_lbl);
            this.maos_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.maos_pnl.Location = new System.Drawing.Point(32, 56);
            this.maos_pnl.Name = "maos_pnl";
            this.maos_pnl.Size = new System.Drawing.Size(272, 48);
            this.maos_pnl.TabIndex = 14;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdProduto.Location = new System.Drawing.Point(0, 17);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(272, 20);
            this.txtIdProduto.TabIndex = 1;
            // 
            // maos_lbl
            // 
            this.maos_lbl.AutoSize = true;
            this.maos_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.maos_lbl.Location = new System.Drawing.Point(0, 0);
            this.maos_lbl.Name = "maos_lbl";
            this.maos_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.maos_lbl.Size = new System.Drawing.Size(56, 17);
            this.maos_lbl.TabIndex = 0;
            this.maos_lbl.Text = "Id Produto";
            // 
            // produzir_pnl
            // 
            this.produzir_pnl.Controls.Add(this.comboBox1);
            this.produzir_pnl.Controls.Add(this.lblNomeProduto);
            this.produzir_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.produzir_pnl.Location = new System.Drawing.Point(32, 104);
            this.produzir_pnl.Name = "produzir_pnl";
            this.produzir_pnl.Size = new System.Drawing.Size(272, 48);
            this.produzir_pnl.TabIndex = 15;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeProduto.Location = new System.Drawing.Point(0, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNomeProduto.Size = new System.Drawing.Size(75, 17);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.cadastrar);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 460);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(272, 61);
            this.barraInf_pnl.TabIndex = 16;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.Red;
            this.cancelar_btn.Location = new System.Drawing.Point(147, 14);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(90, 32);
            this.cancelar_btn.TabIndex = 20;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = false;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastrar.BackColor = System.Drawing.Color.Lime;
            this.cadastrar.Location = new System.Drawing.Point(37, 14);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(81, 32);
            this.cadastrar.TabIndex = 19;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQuantidadePedido);
            this.panel1.Controls.Add(this.lblQuantidadePedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 48);
            this.panel1.TabIndex = 17;
            // 
            // txtQuantidadePedido
            // 
            this.txtQuantidadePedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadePedido.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadePedido.Name = "txtQuantidadePedido";
            this.txtQuantidadePedido.Size = new System.Drawing.Size(272, 20);
            this.txtQuantidadePedido.TabIndex = 1;
            // 
            // lblQuantidadePedido
            // 
            this.lblQuantidadePedido.AutoSize = true;
            this.lblQuantidadePedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuantidadePedido.Location = new System.Drawing.Point(0, 0);
            this.lblQuantidadePedido.Name = "lblQuantidadePedido";
            this.lblQuantidadePedido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblQuantidadePedido.Size = new System.Drawing.Size(98, 17);
            this.lblQuantidadePedido.TabIndex = 0;
            this.lblQuantidadePedido.Text = "Quantidade Pedido";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQuantidadePrevisaoDemanda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 48);
            this.panel2.TabIndex = 18;
            // 
            // txtQuantidadePrevisaoDemanda
            // 
            this.txtQuantidadePrevisaoDemanda.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadePrevisaoDemanda.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadePrevisaoDemanda.Name = "txtQuantidadePrevisaoDemanda";
            this.txtQuantidadePrevisaoDemanda.Size = new System.Drawing.Size(272, 20);
            this.txtQuantidadePrevisaoDemanda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade Previsão Demanda";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtQuantidadeDemandaConsiderada);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(32, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 48);
            this.panel3.TabIndex = 19;
            // 
            // txtQuantidadeDemandaConsiderada
            // 
            this.txtQuantidadeDemandaConsiderada.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadeDemandaConsiderada.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadeDemandaConsiderada.Name = "txtQuantidadeDemandaConsiderada";
            this.txtQuantidadeDemandaConsiderada.Size = new System.Drawing.Size(272, 20);
            this.txtQuantidadeDemandaConsiderada.TabIndex = 1;
            this.txtQuantidadeDemandaConsiderada.TextChanged += new System.EventHandler(this.txtQuantidadeDemandaConsiderada_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade Demanda Considerada";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEstoqueAtual);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(32, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 48);
            this.panel4.TabIndex = 20;
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEstoqueAtual.Location = new System.Drawing.Point(0, 17);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(272, 20);
            this.txtEstoqueAtual.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estoque Atual";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPlanoMestreProducao);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(32, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 48);
            this.panel5.TabIndex = 21;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtPlanoMestreProducao
            // 
            this.txtPlanoMestreProducao.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPlanoMestreProducao.Location = new System.Drawing.Point(0, 17);
            this.txtPlanoMestreProducao.Name = "txtPlanoMestreProducao";
            this.txtPlanoMestreProducao.Size = new System.Drawing.Size(272, 20);
            this.txtPlanoMestreProducao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plano Mestre de Produção";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSemana);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(32, 392);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 48);
            this.panel6.TabIndex = 22;
            // 
            // txtSemana
            // 
            this.txtSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSemana.Location = new System.Drawing.Point(0, 17);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(272, 20);
            this.txtSemana.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Semana";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CadastroMPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 521);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraInf_pnl);
            this.Controls.Add(this.produzir_pnl);
            this.Controls.Add(this.maos_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Name = "CadastroMPS";
            this.Text = "CadastroMPS";
            this.Load += new System.EventHandler(this.CadastroMPS_Load);
            this.maos_pnl.ResumeLayout(false);
            this.maos_pnl.PerformLayout();
            this.produzir_pnl.ResumeLayout(false);
            this.produzir_pnl.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel maos_pnl;
        private System.Windows.Forms.Label maos_lbl;
        private System.Windows.Forms.Panel produzir_pnl;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantidadePedido;
        private System.Windows.Forms.Label lblQuantidadePedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQuantidadePrevisaoDemanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantidadeDemandaConsiderada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPlanoMestreProducao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}