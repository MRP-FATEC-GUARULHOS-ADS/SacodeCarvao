
namespace MRP_SdC
{
    partial class CadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFornecedor));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.site_pnl = new System.Windows.Forms.Panel();
            this.site_tbx = new System.Windows.Forms.TextBox();
            this.site_lbl = new System.Windows.Forms.Label();
            this.email_pnl = new System.Windows.Forms.Panel();
            this.email_tbx = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.telefones_pnl = new System.Windows.Forms.Panel();
            this.telefone_pnl = new System.Windows.Forms.Panel();
            this.telefone_tbx = new System.Windows.Forms.TextBox();
            this.telefone_lbl = new System.Windows.Forms.Label();
            this.celular_pnl = new System.Windows.Forms.Panel();
            this.celular_tbx = new System.Windows.Forms.TextBox();
            this.celular_lbl = new System.Windows.Forms.Label();
            this.compCEP_pnl = new System.Windows.Forms.Panel();
            this.complemento_pnl = new System.Windows.Forms.Panel();
            this.complemento_tbx = new System.Windows.Forms.TextBox();
            this.complemento_lbl = new System.Windows.Forms.Label();
            this.cep_pnl = new System.Windows.Forms.Panel();
            this.cep_tbx = new System.Windows.Forms.TextBox();
            this.cep_lbl = new System.Windows.Forms.Label();
            this.rua_pnl = new System.Windows.Forms.Panel();
            this.logradouro_pnl = new System.Windows.Forms.Panel();
            this.logradouro_tbx = new System.Windows.Forms.TextBox();
            this.logradouro_lbl = new System.Windows.Forms.Label();
            this.numero_pnl = new System.Windows.Forms.Panel();
            this.numero_tbx = new System.Windows.Forms.TextBox();
            this.numero_lbl = new System.Windows.Forms.Label();
            this.nome_pnl = new System.Windows.Forms.Panel();
            this.nome_tbx = new System.Windows.Forms.TextBox();
            this.nome_lbl = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.site_pnl.SuspendLayout();
            this.email_pnl.SuspendLayout();
            this.telefones_pnl.SuspendLayout();
            this.telefone_pnl.SuspendLayout();
            this.celular_pnl.SuspendLayout();
            this.compCEP_pnl.SuspendLayout();
            this.complemento_pnl.SuspendLayout();
            this.cep_pnl.SuspendLayout();
            this.rua_pnl.SuspendLayout();
            this.logradouro_pnl.SuspendLayout();
            this.numero_pnl.SuspendLayout();
            this.nome_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.site_pnl);
            this.corpo_pnl.Controls.Add(this.email_pnl);
            this.corpo_pnl.Controls.Add(this.telefones_pnl);
            this.corpo_pnl.Controls.Add(this.compCEP_pnl);
            this.corpo_pnl.Controls.Add(this.rua_pnl);
            this.corpo_pnl.Controls.Add(this.nome_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(400, 457);
            this.corpo_pnl.TabIndex = 0;
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 409);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(336, 48);
            this.barraInf_pnl.TabIndex = 7;
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
            this.ok_btn.Location = new System.Drawing.Point(221, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // site_pnl
            // 
            this.site_pnl.Controls.Add(this.site_tbx);
            this.site_pnl.Controls.Add(this.site_lbl);
            this.site_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.site_pnl.Location = new System.Drawing.Point(32, 292);
            this.site_pnl.Name = "site_pnl";
            this.site_pnl.Size = new System.Drawing.Size(336, 48);
            this.site_pnl.TabIndex = 6;
            // 
            // site_tbx
            // 
            this.site_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.site_tbx.Location = new System.Drawing.Point(0, 17);
            this.site_tbx.Name = "site_tbx";
            this.site_tbx.Size = new System.Drawing.Size(336, 20);
            this.site_tbx.TabIndex = 1;
            // 
            // site_lbl
            // 
            this.site_lbl.AutoSize = true;
            this.site_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.site_lbl.Location = new System.Drawing.Point(0, 0);
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.site_lbl.Size = new System.Drawing.Size(97, 17);
            this.site_lbl.TabIndex = 0;
            this.site_lbl.Text = "Site do Fornecedor";
            // 
            // email_pnl
            // 
            this.email_pnl.Controls.Add(this.email_tbx);
            this.email_pnl.Controls.Add(this.email_lbl);
            this.email_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.email_pnl.Location = new System.Drawing.Point(32, 244);
            this.email_pnl.Name = "email_pnl";
            this.email_pnl.Size = new System.Drawing.Size(336, 48);
            this.email_pnl.TabIndex = 5;
            // 
            // email_tbx
            // 
            this.email_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.email_tbx.Location = new System.Drawing.Point(0, 17);
            this.email_tbx.Name = "email_tbx";
            this.email_tbx.Size = new System.Drawing.Size(336, 20);
            this.email_tbx.TabIndex = 1;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.email_lbl.Location = new System.Drawing.Point(0, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.email_lbl.Size = new System.Drawing.Size(34, 17);
            this.email_lbl.TabIndex = 0;
            this.email_lbl.Text = "e-mail";
            // 
            // telefones_pnl
            // 
            this.telefones_pnl.Controls.Add(this.telefone_pnl);
            this.telefones_pnl.Controls.Add(this.celular_pnl);
            this.telefones_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.telefones_pnl.Location = new System.Drawing.Point(32, 196);
            this.telefones_pnl.Name = "telefones_pnl";
            this.telefones_pnl.Size = new System.Drawing.Size(336, 48);
            this.telefones_pnl.TabIndex = 4;
            // 
            // telefone_pnl
            // 
            this.telefone_pnl.Controls.Add(this.telefone_tbx);
            this.telefone_pnl.Controls.Add(this.telefone_lbl);
            this.telefone_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefone_pnl.Location = new System.Drawing.Point(0, 0);
            this.telefone_pnl.Name = "telefone_pnl";
            this.telefone_pnl.Size = new System.Drawing.Size(176, 48);
            this.telefone_pnl.TabIndex = 0;
            // 
            // telefone_tbx
            // 
            this.telefone_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.telefone_tbx.Location = new System.Drawing.Point(0, 17);
            this.telefone_tbx.Name = "telefone_tbx";
            this.telefone_tbx.Size = new System.Drawing.Size(176, 20);
            this.telefone_tbx.TabIndex = 1;
            this.telefone_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // telefone_lbl
            // 
            this.telefone_lbl.AutoSize = true;
            this.telefone_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.telefone_lbl.Location = new System.Drawing.Point(0, 0);
            this.telefone_lbl.Name = "telefone_lbl";
            this.telefone_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.telefone_lbl.Size = new System.Drawing.Size(49, 17);
            this.telefone_lbl.TabIndex = 0;
            this.telefone_lbl.Text = "Telefone";
            // 
            // celular_pnl
            // 
            this.celular_pnl.Controls.Add(this.celular_tbx);
            this.celular_pnl.Controls.Add(this.celular_lbl);
            this.celular_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.celular_pnl.Location = new System.Drawing.Point(176, 0);
            this.celular_pnl.Name = "celular_pnl";
            this.celular_pnl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.celular_pnl.Size = new System.Drawing.Size(160, 48);
            this.celular_pnl.TabIndex = 1;
            // 
            // celular_tbx
            // 
            this.celular_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.celular_tbx.Location = new System.Drawing.Point(8, 17);
            this.celular_tbx.Name = "celular_tbx";
            this.celular_tbx.Size = new System.Drawing.Size(152, 20);
            this.celular_tbx.TabIndex = 1;
            // 
            // celular_lbl
            // 
            this.celular_lbl.AutoSize = true;
            this.celular_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.celular_lbl.Location = new System.Drawing.Point(8, 0);
            this.celular_lbl.Name = "celular_lbl";
            this.celular_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.celular_lbl.Size = new System.Drawing.Size(39, 17);
            this.celular_lbl.TabIndex = 0;
            this.celular_lbl.Text = "Celular";
            // 
            // compCEP_pnl
            // 
            this.compCEP_pnl.Controls.Add(this.complemento_pnl);
            this.compCEP_pnl.Controls.Add(this.cep_pnl);
            this.compCEP_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.compCEP_pnl.Location = new System.Drawing.Point(32, 148);
            this.compCEP_pnl.Name = "compCEP_pnl";
            this.compCEP_pnl.Size = new System.Drawing.Size(336, 48);
            this.compCEP_pnl.TabIndex = 3;
            // 
            // complemento_pnl
            // 
            this.complemento_pnl.Controls.Add(this.complemento_tbx);
            this.complemento_pnl.Controls.Add(this.complemento_lbl);
            this.complemento_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complemento_pnl.Location = new System.Drawing.Point(0, 0);
            this.complemento_pnl.Name = "complemento_pnl";
            this.complemento_pnl.Size = new System.Drawing.Size(208, 48);
            this.complemento_pnl.TabIndex = 0;
            // 
            // complemento_tbx
            // 
            this.complemento_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.complemento_tbx.Location = new System.Drawing.Point(0, 17);
            this.complemento_tbx.Name = "complemento_tbx";
            this.complemento_tbx.Size = new System.Drawing.Size(208, 20);
            this.complemento_tbx.TabIndex = 1;
            // 
            // complemento_lbl
            // 
            this.complemento_lbl.AutoSize = true;
            this.complemento_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.complemento_lbl.Location = new System.Drawing.Point(0, 0);
            this.complemento_lbl.Name = "complemento_lbl";
            this.complemento_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.complemento_lbl.Size = new System.Drawing.Size(71, 17);
            this.complemento_lbl.TabIndex = 0;
            this.complemento_lbl.Text = "Complemento";
            // 
            // cep_pnl
            // 
            this.cep_pnl.Controls.Add(this.cep_tbx);
            this.cep_pnl.Controls.Add(this.cep_lbl);
            this.cep_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.cep_pnl.Location = new System.Drawing.Point(208, 0);
            this.cep_pnl.Name = "cep_pnl";
            this.cep_pnl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cep_pnl.Size = new System.Drawing.Size(128, 48);
            this.cep_pnl.TabIndex = 1;
            // 
            // cep_tbx
            // 
            this.cep_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.cep_tbx.Location = new System.Drawing.Point(8, 17);
            this.cep_tbx.Name = "cep_tbx";
            this.cep_tbx.Size = new System.Drawing.Size(120, 20);
            this.cep_tbx.TabIndex = 1;
            this.cep_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // cep_lbl
            // 
            this.cep_lbl.AutoSize = true;
            this.cep_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cep_lbl.Location = new System.Drawing.Point(8, 0);
            this.cep_lbl.Name = "cep_lbl";
            this.cep_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.cep_lbl.Size = new System.Drawing.Size(28, 17);
            this.cep_lbl.TabIndex = 0;
            this.cep_lbl.Text = "CEP";
            // 
            // rua_pnl
            // 
            this.rua_pnl.Controls.Add(this.logradouro_pnl);
            this.rua_pnl.Controls.Add(this.numero_pnl);
            this.rua_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.rua_pnl.Location = new System.Drawing.Point(32, 100);
            this.rua_pnl.Name = "rua_pnl";
            this.rua_pnl.Size = new System.Drawing.Size(336, 48);
            this.rua_pnl.TabIndex = 2;
            // 
            // logradouro_pnl
            // 
            this.logradouro_pnl.Controls.Add(this.logradouro_tbx);
            this.logradouro_pnl.Controls.Add(this.logradouro_lbl);
            this.logradouro_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logradouro_pnl.Location = new System.Drawing.Point(0, 0);
            this.logradouro_pnl.Name = "logradouro_pnl";
            this.logradouro_pnl.Size = new System.Drawing.Size(256, 48);
            this.logradouro_pnl.TabIndex = 0;
            // 
            // logradouro_tbx
            // 
            this.logradouro_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.logradouro_tbx.Location = new System.Drawing.Point(0, 17);
            this.logradouro_tbx.Name = "logradouro_tbx";
            this.logradouro_tbx.Size = new System.Drawing.Size(256, 20);
            this.logradouro_tbx.TabIndex = 1;
            // 
            // logradouro_lbl
            // 
            this.logradouro_lbl.AutoSize = true;
            this.logradouro_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logradouro_lbl.Location = new System.Drawing.Point(0, 0);
            this.logradouro_lbl.Name = "logradouro_lbl";
            this.logradouro_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.logradouro_lbl.Size = new System.Drawing.Size(61, 17);
            this.logradouro_lbl.TabIndex = 0;
            this.logradouro_lbl.Text = "Logradouro";
            // 
            // numero_pnl
            // 
            this.numero_pnl.Controls.Add(this.numero_tbx);
            this.numero_pnl.Controls.Add(this.numero_lbl);
            this.numero_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.numero_pnl.Location = new System.Drawing.Point(256, 0);
            this.numero_pnl.Name = "numero_pnl";
            this.numero_pnl.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.numero_pnl.Size = new System.Drawing.Size(80, 48);
            this.numero_pnl.TabIndex = 1;
            // 
            // numero_tbx
            // 
            this.numero_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.numero_tbx.Location = new System.Drawing.Point(8, 17);
            this.numero_tbx.Name = "numero_tbx";
            this.numero_tbx.Size = new System.Drawing.Size(72, 20);
            this.numero_tbx.TabIndex = 1;
            // 
            // numero_lbl
            // 
            this.numero_lbl.AutoSize = true;
            this.numero_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.numero_lbl.Location = new System.Drawing.Point(8, 0);
            this.numero_lbl.Name = "numero_lbl";
            this.numero_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.numero_lbl.Size = new System.Drawing.Size(44, 17);
            this.numero_lbl.TabIndex = 0;
            this.numero_lbl.Text = "Número";
            // 
            // nome_pnl
            // 
            this.nome_pnl.Controls.Add(this.nome_tbx);
            this.nome_pnl.Controls.Add(this.nome_lbl);
            this.nome_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nome_pnl.Location = new System.Drawing.Point(32, 52);
            this.nome_pnl.Name = "nome_pnl";
            this.nome_pnl.Size = new System.Drawing.Size(336, 48);
            this.nome_pnl.TabIndex = 1;
            // 
            // nome_tbx
            // 
            this.nome_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.nome_tbx.Location = new System.Drawing.Point(0, 17);
            this.nome_tbx.Name = "nome_tbx";
            this.nome_tbx.Size = new System.Drawing.Size(336, 20);
            this.nome_tbx.TabIndex = 1;
            this.nome_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nome_lbl.Location = new System.Drawing.Point(0, 0);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.nome_lbl.Size = new System.Drawing.Size(107, 17);
            this.nome_lbl.TabIndex = 0;
            this.nome_lbl.Text = "Nome do Fornecedor";
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(336, 52);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Cadastrar fornecedor";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(368, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 457);
            this.esp_dir_pnl.TabIndex = 9;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 457);
            this.esp_esq_pnl.TabIndex = 8;
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 457);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de fornecedores";
            this.corpo_pnl.ResumeLayout(false);
            this.barraInf_pnl.ResumeLayout(false);
            this.site_pnl.ResumeLayout(false);
            this.site_pnl.PerformLayout();
            this.email_pnl.ResumeLayout(false);
            this.email_pnl.PerformLayout();
            this.telefones_pnl.ResumeLayout(false);
            this.telefone_pnl.ResumeLayout(false);
            this.telefone_pnl.PerformLayout();
            this.celular_pnl.ResumeLayout(false);
            this.celular_pnl.PerformLayout();
            this.compCEP_pnl.ResumeLayout(false);
            this.complemento_pnl.ResumeLayout(false);
            this.complemento_pnl.PerformLayout();
            this.cep_pnl.ResumeLayout(false);
            this.cep_pnl.PerformLayout();
            this.rua_pnl.ResumeLayout(false);
            this.logradouro_pnl.ResumeLayout(false);
            this.logradouro_pnl.PerformLayout();
            this.numero_pnl.ResumeLayout(false);
            this.numero_pnl.PerformLayout();
            this.nome_pnl.ResumeLayout(false);
            this.nome_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel compCEP_pnl;
        private System.Windows.Forms.Panel nome_pnl;
        private System.Windows.Forms.Label nome_lbl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel rua_pnl;
        private System.Windows.Forms.TextBox nome_tbx;
        private System.Windows.Forms.Panel site_pnl;
        private System.Windows.Forms.TextBox site_tbx;
        private System.Windows.Forms.Label site_lbl;
        private System.Windows.Forms.Panel email_pnl;
        private System.Windows.Forms.TextBox email_tbx;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Panel telefones_pnl;
        private System.Windows.Forms.Panel telefone_pnl;
        private System.Windows.Forms.TextBox telefone_tbx;
        private System.Windows.Forms.Label telefone_lbl;
        private System.Windows.Forms.Panel celular_pnl;
        private System.Windows.Forms.TextBox celular_tbx;
        private System.Windows.Forms.Label celular_lbl;
        private System.Windows.Forms.Panel complemento_pnl;
        private System.Windows.Forms.TextBox complemento_tbx;
        private System.Windows.Forms.Label complemento_lbl;
        private System.Windows.Forms.Panel cep_pnl;
        private System.Windows.Forms.TextBox cep_tbx;
        private System.Windows.Forms.Label cep_lbl;
        private System.Windows.Forms.Panel logradouro_pnl;
        private System.Windows.Forms.TextBox logradouro_tbx;
        private System.Windows.Forms.Label logradouro_lbl;
        private System.Windows.Forms.Panel numero_pnl;
        private System.Windows.Forms.TextBox numero_tbx;
        private System.Windows.Forms.Label numero_lbl;
    }
}