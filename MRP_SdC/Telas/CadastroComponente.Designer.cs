
namespace MRP_SdC
{
    partial class CadastroComponente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroComponente));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.estado_pnl = new System.Windows.Forms.Panel();
            this.estado_clb = new System.Windows.Forms.CheckedListBox();
            this.estado_lbl = new System.Windows.Forms.Label();
            this.especs_pnl = new System.Windows.Forms.Panel();
            this.especs_tbm = new System.Windows.Forms.TextBox();
            this.especs_lbl = new System.Windows.Forms.Label();
            this.modelo_pnl = new System.Windows.Forms.Panel();
            this.modelo_tbx = new System.Windows.Forms.TextBox();
            this.modelo_lbl = new System.Windows.Forms.Label();
            this.marca_pnl = new System.Windows.Forms.Panel();
            this.marca_tbx = new System.Windows.Forms.TextBox();
            this.marca_lbl = new System.Windows.Forms.Label();
            this.tipo_pnl = new System.Windows.Forms.Panel();
            this.tipo_cbb = new System.Windows.Forms.ComboBox();
            this.tipo_lbl = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.estado_pnl.SuspendLayout();
            this.especs_pnl.SuspendLayout();
            this.modelo_pnl.SuspendLayout();
            this.marca_pnl.SuspendLayout();
            this.tipo_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.estado_pnl);
            this.corpo_pnl.Controls.Add(this.especs_pnl);
            this.corpo_pnl.Controls.Add(this.modelo_pnl);
            this.corpo_pnl.Controls.Add(this.marca_pnl);
            this.corpo_pnl.Controls.Add(this.tipo_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(304, 409);
            this.corpo_pnl.TabIndex = 0;
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
            this.estado_pnl.Location = new System.Drawing.Point(32, 284);
            this.estado_pnl.Name = "estado_pnl";
            this.estado_pnl.Size = new System.Drawing.Size(240, 58);
            this.estado_pnl.TabIndex = 5;
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
            // especs_pnl
            // 
            this.especs_pnl.Controls.Add(this.especs_tbm);
            this.especs_pnl.Controls.Add(this.especs_lbl);
            this.especs_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.especs_pnl.Location = new System.Drawing.Point(32, 196);
            this.especs_pnl.Name = "especs_pnl";
            this.especs_pnl.Size = new System.Drawing.Size(240, 88);
            this.especs_pnl.TabIndex = 4;
            // 
            // especs_tbm
            // 
            this.especs_tbm.Dock = System.Windows.Forms.DockStyle.Top;
            this.especs_tbm.Location = new System.Drawing.Point(0, 17);
            this.especs_tbm.Multiline = true;
            this.especs_tbm.Name = "especs_tbm";
            this.especs_tbm.Size = new System.Drawing.Size(240, 60);
            this.especs_tbm.TabIndex = 1;
            // 
            // especs_lbl
            // 
            this.especs_lbl.AutoSize = true;
            this.especs_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.especs_lbl.Location = new System.Drawing.Point(0, 0);
            this.especs_lbl.Name = "especs_lbl";
            this.especs_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.especs_lbl.Size = new System.Drawing.Size(79, 17);
            this.especs_lbl.TabIndex = 0;
            this.especs_lbl.Text = "Especificações";
            // 
            // modelo_pnl
            // 
            this.modelo_pnl.Controls.Add(this.modelo_tbx);
            this.modelo_pnl.Controls.Add(this.modelo_lbl);
            this.modelo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_pnl.Location = new System.Drawing.Point(32, 148);
            this.modelo_pnl.Name = "modelo_pnl";
            this.modelo_pnl.Size = new System.Drawing.Size(240, 48);
            this.modelo_pnl.TabIndex = 3;
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
            this.modelo_lbl.Size = new System.Drawing.Size(120, 17);
            this.modelo_lbl.TabIndex = 0;
            this.modelo_lbl.Text = "Modelo do Componente";
            // 
            // marca_pnl
            // 
            this.marca_pnl.Controls.Add(this.marca_tbx);
            this.marca_pnl.Controls.Add(this.marca_lbl);
            this.marca_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_pnl.Location = new System.Drawing.Point(32, 100);
            this.marca_pnl.Name = "marca_pnl";
            this.marca_pnl.Size = new System.Drawing.Size(240, 48);
            this.marca_pnl.TabIndex = 2;
            // 
            // marca_tbx
            // 
            this.marca_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_tbx.Location = new System.Drawing.Point(0, 17);
            this.marca_tbx.Name = "marca_tbx";
            this.marca_tbx.Size = new System.Drawing.Size(240, 20);
            this.marca_tbx.TabIndex = 1;
            this.marca_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // marca_lbl
            // 
            this.marca_lbl.AutoSize = true;
            this.marca_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_lbl.Location = new System.Drawing.Point(0, 0);
            this.marca_lbl.Name = "marca_lbl";
            this.marca_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.marca_lbl.Size = new System.Drawing.Size(115, 17);
            this.marca_lbl.TabIndex = 0;
            this.marca_lbl.Text = "Marca do Componente";
            // 
            // tipo_pnl
            // 
            this.tipo_pnl.Controls.Add(this.tipo_cbb);
            this.tipo_pnl.Controls.Add(this.tipo_lbl);
            this.tipo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipo_pnl.Location = new System.Drawing.Point(32, 52);
            this.tipo_pnl.Name = "tipo_pnl";
            this.tipo_pnl.Size = new System.Drawing.Size(240, 48);
            this.tipo_pnl.TabIndex = 1;
            // 
            // tipo_cbb
            // 
            this.tipo_cbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipo_cbb.FormattingEnabled = true;
            this.tipo_cbb.Items.AddRange(new object[] {
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
            this.tipo_cbb.Location = new System.Drawing.Point(0, 17);
            this.tipo_cbb.Name = "tipo_cbb";
            this.tipo_cbb.Size = new System.Drawing.Size(240, 21);
            this.tipo_cbb.TabIndex = 1;
            this.tipo_cbb.SelectedIndexChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // tipo_lbl
            // 
            this.tipo_lbl.AutoSize = true;
            this.tipo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipo_lbl.Location = new System.Drawing.Point(0, 0);
            this.tipo_lbl.Name = "tipo_lbl";
            this.tipo_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tipo_lbl.Size = new System.Drawing.Size(106, 17);
            this.tipo_lbl.TabIndex = 0;
            this.tipo_lbl.Text = "Tipo de Componente";
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
            this.ttl_lbl.Text = "Cadastrar componente";
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
            // CadastroComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 409);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroComponente";
            this.Text = "Cadastro de componente";
            this.corpo_pnl.ResumeLayout(false);
            this.barraInf_pnl.ResumeLayout(false);
            this.estado_pnl.ResumeLayout(false);
            this.estado_pnl.PerformLayout();
            this.especs_pnl.ResumeLayout(false);
            this.especs_pnl.PerformLayout();
            this.modelo_pnl.ResumeLayout(false);
            this.modelo_pnl.PerformLayout();
            this.marca_pnl.ResumeLayout(false);
            this.marca_pnl.PerformLayout();
            this.tipo_pnl.ResumeLayout(false);
            this.tipo_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel especs_pnl;
        private System.Windows.Forms.Panel modelo_pnl;
        private System.Windows.Forms.TextBox modelo_tbx;
        private System.Windows.Forms.Label modelo_lbl;
        private System.Windows.Forms.Panel tipo_pnl;
        private System.Windows.Forms.ComboBox tipo_cbb;
        private System.Windows.Forms.Label tipo_lbl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.TextBox especs_tbm;
        private System.Windows.Forms.Label especs_lbl;
        private System.Windows.Forms.Panel marca_pnl;
        private System.Windows.Forms.TextBox marca_tbx;
        private System.Windows.Forms.Label marca_lbl;
        private System.Windows.Forms.Panel estado_pnl;
        private System.Windows.Forms.CheckedListBox estado_clb;
        private System.Windows.Forms.Label estado_lbl;
    }
}