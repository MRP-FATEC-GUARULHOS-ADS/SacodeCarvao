
namespace MRP_SdC.Telas.Producao
{
    partial class CadastroBOM
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
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodigoLista = new System.Windows.Forms.TextBox();
            this.lblCodigoLista = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQuantidadeUnidade = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLista = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.barraInf_pnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(347, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 505);
            this.esp_dir_pnl.TabIndex = 11;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 505);
            this.esp_esq_pnl.TabIndex = 12;
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.cadastrar);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 444);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(315, 61);
            this.barraInf_pnl.TabIndex = 20;
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
            this.cadastrar.Location = new System.Drawing.Point(46, 14);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(81, 32);
            this.cadastrar.TabIndex = 19;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCodigoLista);
            this.panel3.Controls.Add(this.lblCodigoLista);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(32, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 48);
            this.panel3.TabIndex = 21;
            // 
            // txtCodigoLista
            // 
            this.txtCodigoLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigoLista.Location = new System.Drawing.Point(0, 17);
            this.txtCodigoLista.Name = "txtCodigoLista";
            this.txtCodigoLista.Size = new System.Drawing.Size(315, 20);
            this.txtCodigoLista.TabIndex = 1;
            // 
            // lblCodigoLista
            // 
            this.lblCodigoLista.AutoSize = true;
            this.lblCodigoLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigoLista.Location = new System.Drawing.Point(0, 0);
            this.lblCodigoLista.Name = "lblCodigoLista";
            this.lblCodigoLista.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCodigoLista.Size = new System.Drawing.Size(65, 17);
            this.lblCodigoLista.TabIndex = 0;
            this.lblCodigoLista.Text = "Codigo Lista";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.cmbNome);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 48);
            this.panel2.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(234, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbNome
            // 
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(3, 21);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(225, 21);
            this.cmbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNome.Size = new System.Drawing.Size(35, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtNivel);
            this.panel4.Controls.Add(this.lblNivel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(32, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 48);
            this.panel4.TabIndex = 23;
            // 
            // txtNivel
            // 
            this.txtNivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNivel.Location = new System.Drawing.Point(0, 17);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(315, 20);
            this.txtNivel.TabIndex = 1;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNivel.Location = new System.Drawing.Point(0, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNivel.Size = new System.Drawing.Size(31, 17);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtQuantidadeUnidade);
            this.panel5.Controls.Add(this.lblQuantidadeLista);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(32, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 48);
            this.panel5.TabIndex = 24;
            // 
            // txtQuantidadeUnidade
            // 
            this.txtQuantidadeUnidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadeUnidade.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadeUnidade.Name = "txtQuantidadeUnidade";
            this.txtQuantidadeUnidade.Size = new System.Drawing.Size(315, 20);
            this.txtQuantidadeUnidade.TabIndex = 1;
            // 
            // lblQuantidadeLista
            // 
            this.lblQuantidadeLista.AutoSize = true;
            this.lblQuantidadeLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuantidadeLista.Location = new System.Drawing.Point(0, 0);
            this.lblQuantidadeLista.Name = "lblQuantidadeLista";
            this.lblQuantidadeLista.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblQuantidadeLista.Size = new System.Drawing.Size(87, 17);
            this.lblQuantidadeLista.TabIndex = 0;
            this.lblQuantidadeLista.Text = "Quantidade Lista";
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(315, 70);
            this.ttl_lbl.TabIndex = 13;
            this.ttl_lbl.Text = "Cadastrar BOM";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadastroBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 505);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barraInf_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Name = "CadastroBOM";
            this.Text = "CadastroBOM";
            this.Load += new System.EventHandler(this.CadastroBOM_Load_1);
            this.barraInf_pnl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCodigoLista;
        private System.Windows.Forms.Label lblCodigoLista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtQuantidadeUnidade;
        private System.Windows.Forms.Label lblQuantidadeLista;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Button btnBuscar;
    }
}