
namespace MRP_SdC.MySQL
{
    partial class CadastroMRP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMRP));
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.id_pnl = new System.Windows.Forms.Panel();
            this.cmbIdPedido = new System.Windows.Forms.ComboBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cadastrar = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.qntdNecesLiq_tbx = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtIdBom = new System.Windows.Forms.TextBox();
            this.lblIdBom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNecBruta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEstoqueDisp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtRecOrdensPlan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtLibDeOrdens = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.esp_dir_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.esp_esq_pnl.SuspendLayout();
            this.id_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Controls.Add(this.label1);
            this.esp_dir_pnl.Controls.Add(this.dataGridView1);
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(308, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(624, 471);
            this.esp_dir_pnl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque Produtos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Controls.Add(this.panel6);
            this.esp_esq_pnl.Controls.Add(this.panel3);
            this.esp_esq_pnl.Controls.Add(this.panel1);
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 471);
            this.esp_esq_pnl.TabIndex = 10;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(276, 56);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Cadastrar Produção";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_pnl
            // 
            this.id_pnl.Controls.Add(this.panel8);
            this.id_pnl.Controls.Add(this.cmbIdPedido);
            this.id_pnl.Controls.Add(this.lblIdPedido);
            this.id_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.id_pnl.Location = new System.Drawing.Point(32, 56);
            this.id_pnl.Name = "id_pnl";
            this.id_pnl.Size = new System.Drawing.Size(276, 48);
            this.id_pnl.TabIndex = 1;
            // 
            // cmbIdPedido
            // 
            this.cmbIdPedido.FormattingEnabled = true;
            this.cmbIdPedido.Location = new System.Drawing.Point(6, 17);
            this.cmbIdPedido.Name = "cmbIdPedido";
            this.cmbIdPedido.Size = new System.Drawing.Size(121, 21);
            this.cmbIdPedido.TabIndex = 3;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdPedido.Location = new System.Drawing.Point(0, 0);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblIdPedido.Size = new System.Drawing.Size(75, 17);
            this.lblIdPedido.TabIndex = 0;
            this.lblIdPedido.Text = "Nome Produto";
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 429);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(276, 42);
            this.barraInf_pnl.TabIndex = 6;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastrar.BackColor = System.Drawing.Color.Lime;
            this.cadastrar.Location = new System.Drawing.Point(48, 400);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(81, 32);
            this.cadastrar.TabIndex = 18;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.Red;
            this.cancelar_btn.Location = new System.Drawing.Point(142, 400);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(90, 32);
            this.cancelar_btn.TabIndex = 2;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = false;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // qntdNecesLiq_tbx
            // 
            this.qntdNecesLiq_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.qntdNecesLiq_tbx.Location = new System.Drawing.Point(32, 104);
            this.qntdNecesLiq_tbx.Name = "qntdNecesLiq_tbx";
            this.qntdNecesLiq_tbx.Size = new System.Drawing.Size(276, 10);
            this.qntdNecesLiq_tbx.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtIdBom
            // 
            this.txtIdBom.Location = new System.Drawing.Point(35, 134);
            this.txtIdBom.Name = "txtIdBom";
            this.txtIdBom.Size = new System.Drawing.Size(100, 20);
            this.txtIdBom.TabIndex = 21;
            // 
            // lblIdBom
            // 
            this.lblIdBom.AutoSize = true;
            this.lblIdBom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdBom.Location = new System.Drawing.Point(32, 114);
            this.lblIdBom.Name = "lblIdBom";
            this.lblIdBom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblIdBom.Size = new System.Drawing.Size(105, 17);
            this.lblIdBom.TabIndex = 22;
            this.lblIdBom.Text = "Id Árvore do Produto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Produto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNecBruta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(32, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 48);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Necessidade Bruta";
            // 
            // txtNecBruta
            // 
            this.txtNecBruta.Location = new System.Drawing.Point(3, 17);
            this.txtNecBruta.Name = "txtNecBruta";
            this.txtNecBruta.Size = new System.Drawing.Size(176, 20);
            this.txtNecBruta.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(32, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 48);
            this.panel3.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Necessidade Bruta";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEstoqueDisp);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(32, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 48);
            this.panel4.TabIndex = 24;
            // 
            // txtEstoqueDisp
            // 
            this.txtEstoqueDisp.Location = new System.Drawing.Point(3, 17);
            this.txtEstoqueDisp.Name = "txtEstoqueDisp";
            this.txtEstoqueDisp.Size = new System.Drawing.Size(176, 20);
            this.txtEstoqueDisp.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estoque Disponível";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtRecOrdensPlan);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(32, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 48);
            this.panel5.TabIndex = 25;
            // 
            // txtRecOrdensPlan
            // 
            this.txtRecOrdensPlan.Location = new System.Drawing.Point(3, 17);
            this.txtRecOrdensPlan.Name = "txtRecOrdensPlan";
            this.txtRecOrdensPlan.Size = new System.Drawing.Size(176, 20);
            this.txtRecOrdensPlan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Requisição Ordem Planejada";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(32, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 48);
            this.panel6.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Requisição Ordem Planejada";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtLibDeOrdens);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(32, 331);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 48);
            this.panel7.TabIndex = 26;
            // 
            // txtLibDeOrdens
            // 
            this.txtLibDeOrdens.Location = new System.Drawing.Point(3, 17);
            this.txtLibDeOrdens.Name = "txtLibDeOrdens";
            this.txtLibDeOrdens.Size = new System.Drawing.Size(176, 20);
            this.txtLibDeOrdens.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Liberação de Ordens";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtSemana);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(133, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(124, 40);
            this.panel8.TabIndex = 27;
            // 
            // txtSemana
            // 
            this.txtSemana.Location = new System.Drawing.Point(3, 17);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(118, 20);
            this.txtSemana.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Semana";
            // 
            // CadastroMRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 471);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblIdBom);
            this.Controls.Add(this.txtIdBom);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.barraInf_pnl);
            this.Controls.Add(this.qntdNecesLiq_tbx);
            this.Controls.Add(this.id_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroMRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Produção";
            this.Load += new System.EventHandler(this.CadastroMRP_Load_1);
            this.esp_dir_pnl.ResumeLayout(false);
            this.esp_dir_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.esp_esq_pnl.ResumeLayout(false);
            this.id_pnl.ResumeLayout(false);
            this.id_pnl.PerformLayout();
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel id_pnl;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Panel qntdNecesLiq_tbx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblIdBom;
        public System.Windows.Forms.ComboBox cmbIdPedido;
        public System.Windows.Forms.TextBox txtIdBom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNecBruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEstoqueDisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtRecOrdensPlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtLibDeOrdens;
        private System.Windows.Forms.Label label8;
    }
}