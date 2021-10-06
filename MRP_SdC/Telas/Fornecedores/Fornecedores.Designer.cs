
namespace MRP_SdC
{
    partial class Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.forn_lista_dgv = new System.Windows.Forms.DataGridView();
            this.fornecedor_pnl = new System.Windows.Forms.Panel();
            this.componentes_pnl = new System.Windows.Forms.Panel();
            this.componentes_btn = new System.Windows.Forms.Button();
            this.site_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.celular_lbl = new System.Windows.Forms.Label();
            this.telefone_lbl = new System.Windows.Forms.Label();
            this.cep_lbl = new System.Windows.Forms.Label();
            this.logradouro_lbl = new System.Windows.Forms.Label();
            this.nome_lbl = new System.Windows.Forms.Label();
            this.codigo_lbl = new System.Windows.Forms.Label();
            this.pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_cont_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_tbx = new System.Windows.Forms.TextBox();
            this.pesquisa_btn = new System.Windows.Forms.Button();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.excluir_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.cadastrar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forn_lista_dgv)).BeginInit();
            this.fornecedor_pnl.SuspendLayout();
            this.componentes_pnl.SuspendLayout();
            this.pesquisa_pnl.SuspendLayout();
            this.pesquisa_cont_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.forn_lista_dgv);
            this.corpo_pnl.Controls.Add(this.fornecedor_pnl);
            this.corpo_pnl.Controls.Add(this.pesquisa_pnl);
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.EspDir_pnl);
            this.corpo_pnl.Controls.Add(this.EspEsq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(704, 481);
            this.corpo_pnl.TabIndex = 0;
            // 
            // forn_lista_dgv
            // 
            this.forn_lista_dgv.AllowUserToAddRows = false;
            this.forn_lista_dgv.AllowUserToDeleteRows = false;
            this.forn_lista_dgv.BackgroundColor = System.Drawing.Color.White;
            this.forn_lista_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forn_lista_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forn_lista_dgv.Location = new System.Drawing.Point(32, 88);
            this.forn_lista_dgv.MultiSelect = false;
            this.forn_lista_dgv.Name = "forn_lista_dgv";
            this.forn_lista_dgv.ReadOnly = true;
            this.forn_lista_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.forn_lista_dgv.Size = new System.Drawing.Size(400, 345);
            this.forn_lista_dgv.StandardTab = true;
            this.forn_lista_dgv.TabIndex = 2;
            this.forn_lista_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Fornecedores_DGV_CellClick);
            this.forn_lista_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_DGV_RowEnter);
            // 
            // fornecedor_pnl
            // 
            this.fornecedor_pnl.AutoScroll = true;
            this.fornecedor_pnl.Controls.Add(this.componentes_pnl);
            this.fornecedor_pnl.Controls.Add(this.site_lbl);
            this.fornecedor_pnl.Controls.Add(this.email_lbl);
            this.fornecedor_pnl.Controls.Add(this.celular_lbl);
            this.fornecedor_pnl.Controls.Add(this.telefone_lbl);
            this.fornecedor_pnl.Controls.Add(this.cep_lbl);
            this.fornecedor_pnl.Controls.Add(this.logradouro_lbl);
            this.fornecedor_pnl.Controls.Add(this.nome_lbl);
            this.fornecedor_pnl.Controls.Add(this.codigo_lbl);
            this.fornecedor_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.fornecedor_pnl.Location = new System.Drawing.Point(432, 88);
            this.fornecedor_pnl.Name = "fornecedor_pnl";
            this.fornecedor_pnl.Padding = new System.Windows.Forms.Padding(12, 24, 12, 12);
            this.fornecedor_pnl.Size = new System.Drawing.Size(240, 345);
            this.fornecedor_pnl.TabIndex = 3;
            // 
            // componentes_pnl
            // 
            this.componentes_pnl.Controls.Add(this.componentes_btn);
            this.componentes_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.componentes_pnl.Location = new System.Drawing.Point(12, 220);
            this.componentes_pnl.Name = "componentes_pnl";
            this.componentes_pnl.Size = new System.Drawing.Size(216, 48);
            this.componentes_pnl.TabIndex = 8;
            // 
            // componentes_btn
            // 
            this.componentes_btn.Enabled = false;
            this.componentes_btn.Location = new System.Drawing.Point(3, 10);
            this.componentes_btn.Name = "componentes_btn";
            this.componentes_btn.Size = new System.Drawing.Size(192, 23);
            this.componentes_btn.TabIndex = 0;
            this.componentes_btn.Text = "Componentes do fornecedor";
            this.componentes_btn.UseVisualStyleBackColor = true;
            this.componentes_btn.Click += new System.EventHandler(this.Componentes_btn_Click);
            // 
            // site_lbl
            // 
            this.site_lbl.AutoSize = true;
            this.site_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.site_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_lbl.Location = new System.Drawing.Point(12, 191);
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.site_lbl.Size = new System.Drawing.Size(25, 29);
            this.site_lbl.TabIndex = 7;
            this.site_lbl.Text = "Site";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(12, 162);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.email_lbl.Size = new System.Drawing.Size(31, 29);
            this.email_lbl.TabIndex = 6;
            this.email_lbl.Text = "email";
            // 
            // celular_lbl
            // 
            this.celular_lbl.AutoSize = true;
            this.celular_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.celular_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular_lbl.Location = new System.Drawing.Point(12, 141);
            this.celular_lbl.Name = "celular_lbl";
            this.celular_lbl.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.celular_lbl.Size = new System.Drawing.Size(39, 21);
            this.celular_lbl.TabIndex = 5;
            this.celular_lbl.Text = "Celular";
            // 
            // telefone_lbl
            // 
            this.telefone_lbl.AutoSize = true;
            this.telefone_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.telefone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone_lbl.Location = new System.Drawing.Point(12, 112);
            this.telefone_lbl.Name = "telefone_lbl";
            this.telefone_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.telefone_lbl.Size = new System.Drawing.Size(49, 29);
            this.telefone_lbl.TabIndex = 4;
            this.telefone_lbl.Text = "Telefone";
            // 
            // cep_lbl
            // 
            this.cep_lbl.AutoSize = true;
            this.cep_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cep_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep_lbl.Location = new System.Drawing.Point(12, 91);
            this.cep_lbl.Name = "cep_lbl";
            this.cep_lbl.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cep_lbl.Size = new System.Drawing.Size(28, 21);
            this.cep_lbl.TabIndex = 3;
            this.cep_lbl.Text = "CEP";
            // 
            // logradouro_lbl
            // 
            this.logradouro_lbl.AutoSize = true;
            this.logradouro_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logradouro_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logradouro_lbl.Location = new System.Drawing.Point(12, 62);
            this.logradouro_lbl.Name = "logradouro_lbl";
            this.logradouro_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.logradouro_lbl.Size = new System.Drawing.Size(107, 29);
            this.logradouro_lbl.TabIndex = 2;
            this.logradouro_lbl.Text = "Logradouro - Numero";
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_lbl.Location = new System.Drawing.Point(12, 37);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.nome_lbl.Size = new System.Drawing.Size(49, 25);
            this.nome_lbl.TabIndex = 1;
            this.nome_lbl.Text = "Nome";
            // 
            // codigo_lbl
            // 
            this.codigo_lbl.AutoSize = true;
            this.codigo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.codigo_lbl.Location = new System.Drawing.Point(12, 24);
            this.codigo_lbl.Name = "codigo_lbl";
            this.codigo_lbl.Size = new System.Drawing.Size(39, 13);
            this.codigo_lbl.TabIndex = 0;
            this.codigo_lbl.Text = "codigo";
            // 
            // pesquisa_pnl
            // 
            this.pesquisa_pnl.Controls.Add(this.pesquisa_cont_pnl);
            this.pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisa_pnl.Location = new System.Drawing.Point(32, 52);
            this.pesquisa_pnl.Name = "pesquisa_pnl";
            this.pesquisa_pnl.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pesquisa_pnl.Size = new System.Drawing.Size(640, 36);
            this.pesquisa_pnl.TabIndex = 1;
            // 
            // pesquisa_cont_pnl
            // 
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_tbx);
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_btn);
            this.pesquisa_cont_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisa_cont_pnl.Location = new System.Drawing.Point(0, 6);
            this.pesquisa_cont_pnl.Name = "pesquisa_cont_pnl";
            this.pesquisa_cont_pnl.Size = new System.Drawing.Size(640, 20);
            this.pesquisa_cont_pnl.TabIndex = 0;
            // 
            // pesquisa_tbx
            // 
            this.pesquisa_tbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesquisa_tbx.Location = new System.Drawing.Point(0, 0);
            this.pesquisa_tbx.Name = "pesquisa_tbx";
            this.pesquisa_tbx.Size = new System.Drawing.Size(608, 20);
            this.pesquisa_tbx.TabIndex = 0;
            this.pesquisa_tbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pesquisar_TBX_KeyUp);
            // 
            // pesquisa_btn
            // 
            this.pesquisa_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_btn.Location = new System.Drawing.Point(608, 0);
            this.pesquisa_btn.Name = "pesquisa_btn";
            this.pesquisa_btn.Size = new System.Drawing.Size(32, 20);
            this.pesquisa_btn.TabIndex = 1;
            this.pesquisa_btn.Text = "👁";
            this.pesquisa_btn.UseVisualStyleBackColor = true;
            this.pesquisa_btn.Click += new System.EventHandler(this.Pesquisar_BTN_Click);
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.excluir_btn);
            this.barraInf_pnl.Controls.Add(this.editar_btn);
            this.barraInf_pnl.Controls.Add(this.cadastrar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 433);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(640, 48);
            this.barraInf_pnl.TabIndex = 4;
            // 
            // excluir_btn
            // 
            this.excluir_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.excluir_btn.Enabled = false;
            this.excluir_btn.Location = new System.Drawing.Point(304, 10);
            this.excluir_btn.Name = "excluir_btn";
            this.excluir_btn.Size = new System.Drawing.Size(144, 23);
            this.excluir_btn.TabIndex = 3;
            this.excluir_btn.Text = "Excluir Fornecedor";
            this.excluir_btn.UseVisualStyleBackColor = true;
            this.excluir_btn.Click += new System.EventHandler(this.Exclur_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editar_btn.Enabled = false;
            this.editar_btn.Location = new System.Drawing.Point(152, 10);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(144, 23);
            this.editar_btn.TabIndex = 2;
            this.editar_btn.Text = "Editar Fornecedor";
            this.editar_btn.UseVisualStyleBackColor = true;
            this.editar_btn.Click += new System.EventHandler(this.Editar_btn_Click);
            // 
            // cadastrar_btn
            // 
            this.cadastrar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cadastrar_btn.Location = new System.Drawing.Point(0, 10);
            this.cadastrar_btn.Name = "cadastrar_btn";
            this.cadastrar_btn.Size = new System.Drawing.Size(144, 23);
            this.cadastrar_btn.TabIndex = 1;
            this.cadastrar_btn.Text = "Cadastrar Fornecedor";
            this.cadastrar_btn.UseVisualStyleBackColor = true;
            this.cadastrar_btn.Click += new System.EventHandler(this.Cadastrar_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok_btn.Location = new System.Drawing.Point(522, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(640, 52);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Fornecedores";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(672, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 481);
            this.EspDir_pnl.TabIndex = 6;
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 481);
            this.EspEsq_pnl.TabIndex = 5;
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Form_Load);
            this.corpo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forn_lista_dgv)).EndInit();
            this.fornecedor_pnl.ResumeLayout(false);
            this.fornecedor_pnl.PerformLayout();
            this.componentes_pnl.ResumeLayout(false);
            this.pesquisa_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Panel pesquisa_pnl;
        private System.Windows.Forms.Panel pesquisa_cont_pnl;
        private System.Windows.Forms.TextBox pesquisa_tbx;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel fornecedor_pnl;
        private System.Windows.Forms.Button cadastrar_btn;
        private System.Windows.Forms.DataGridView forn_lista_dgv;
        private System.Windows.Forms.Label nome_lbl;
        private System.Windows.Forms.Label codigo_lbl;
        private System.Windows.Forms.Button excluir_btn;
        private System.Windows.Forms.Button editar_btn;
        private System.Windows.Forms.Label site_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label celular_lbl;
        private System.Windows.Forms.Label telefone_lbl;
        private System.Windows.Forms.Label cep_lbl;
        private System.Windows.Forms.Label logradouro_lbl;
        private System.Windows.Forms.Panel componentes_pnl;
        private System.Windows.Forms.Button componentes_btn;
    }
}