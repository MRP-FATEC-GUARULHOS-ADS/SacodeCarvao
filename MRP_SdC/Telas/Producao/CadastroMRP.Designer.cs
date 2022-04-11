
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMRP));
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.id_pnl = new System.Windows.Forms.Panel();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.maos_pnl = new System.Windows.Forms.Panel();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.maos_lbl = new System.Windows.Forms.Label();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cadastrar = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.qntdNecesLiq_tbx = new System.Windows.Forms.Panel();
            this.id_pnl.SuspendLayout();
            this.maos_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(260, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 395);
            this.esp_dir_pnl.TabIndex = 9;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 395);
            this.esp_esq_pnl.TabIndex = 10;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(228, 56);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Cadastrar Produção";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_pnl
            // 
            this.id_pnl.Controls.Add(this.txtIdPedido);
            this.id_pnl.Controls.Add(this.lblIdPedido);
            this.id_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.id_pnl.Location = new System.Drawing.Point(32, 56);
            this.id_pnl.Name = "id_pnl";
            this.id_pnl.Size = new System.Drawing.Size(228, 48);
            this.id_pnl.TabIndex = 1;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdPedido.Location = new System.Drawing.Point(0, 17);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(228, 20);
            this.txtIdPedido.TabIndex = 1;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdPedido.Location = new System.Drawing.Point(0, 0);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblIdPedido.Size = new System.Drawing.Size(52, 17);
            this.lblIdPedido.TabIndex = 0;
            this.lblIdPedido.Text = "Id Pedido";
            // 
            // maos_pnl
            // 
            this.maos_pnl.Controls.Add(this.txtIdProduto);
            this.maos_pnl.Controls.Add(this.maos_lbl);
            this.maos_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.maos_pnl.Location = new System.Drawing.Point(32, 104);
            this.maos_pnl.Name = "maos_pnl";
            this.maos_pnl.Size = new System.Drawing.Size(228, 48);
            this.maos_pnl.TabIndex = 2;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdProduto.Location = new System.Drawing.Point(0, 17);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(228, 20);
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
            // barraInf_pnl
            // 
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 334);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(228, 61);
            this.barraInf_pnl.TabIndex = 6;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastrar.BackColor = System.Drawing.Color.Lime;
            this.cadastrar.Location = new System.Drawing.Point(49, 274);
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
            this.cancelar_btn.Location = new System.Drawing.Point(136, 274);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(90, 32);
            this.cancelar_btn.TabIndex = 2;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = false;
            this.cancelar_btn.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // qntdNecesLiq_tbx
            // 
            this.qntdNecesLiq_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.qntdNecesLiq_tbx.Location = new System.Drawing.Point(32, 152);
            this.qntdNecesLiq_tbx.Name = "qntdNecesLiq_tbx";
            this.qntdNecesLiq_tbx.Size = new System.Drawing.Size(228, 10);
            this.qntdNecesLiq_tbx.TabIndex = 4;
            // 
            // CadastroMRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 395);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.barraInf_pnl);
            this.Controls.Add(this.qntdNecesLiq_tbx);
            this.Controls.Add(this.maos_pnl);
            this.Controls.Add(this.id_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroMRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Produção";
            this.Load += new System.EventHandler(this.CadastroMRP_Load);
            this.id_pnl.ResumeLayout(false);
            this.id_pnl.PerformLayout();
            this.maos_pnl.ResumeLayout(false);
            this.maos_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel id_pnl;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Panel maos_pnl;
        private System.Windows.Forms.Label maos_lbl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Panel qntdNecesLiq_tbx;
        public System.Windows.Forms.TextBox txtIdPedido;
        public System.Windows.Forms.TextBox txtIdProduto;
    }
}