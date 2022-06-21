
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
            this.id_pnl.SuspendLayout();
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
            this.id_pnl.Controls.Add(this.cmbIdPedido);
            this.id_pnl.Controls.Add(this.lblIdPedido);
            this.id_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.id_pnl.Location = new System.Drawing.Point(32, 56);
            this.id_pnl.Name = "id_pnl";
            this.id_pnl.Size = new System.Drawing.Size(228, 48);
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
            this.lblIdPedido.Size = new System.Drawing.Size(52, 17);
            this.lblIdPedido.TabIndex = 0;
            this.lblIdPedido.Text = "Id Pedido";
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
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // qntdNecesLiq_tbx
            // 
            this.qntdNecesLiq_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.qntdNecesLiq_tbx.Location = new System.Drawing.Point(32, 104);
            this.qntdNecesLiq_tbx.Name = "qntdNecesLiq_tbx";
            this.qntdNecesLiq_tbx.Size = new System.Drawing.Size(228, 10);
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
            this.lblIdBom.Size = new System.Drawing.Size(40, 17);
            this.lblIdBom.TabIndex = 22;
            this.lblIdBom.Text = "Id Bom";
            // 
            // CadastroMRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 395);
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
            this.id_pnl.ResumeLayout(false);
            this.id_pnl.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIdBom;
        private System.Windows.Forms.Label lblIdBom;
        public System.Windows.Forms.ComboBox cmbIdPedido;
    }
}