
namespace MRP_SdC
{
    partial class ComponentesFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentesFornecedor));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.comp_lista_dgv = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.comp_lista_dgv)).BeginInit();
            this.pesquisa_pnl.SuspendLayout();
            this.pesquisa_cont_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.comp_lista_dgv);
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
            // comp_lista_dgv
            // 
            this.comp_lista_dgv.AllowUserToAddRows = false;
            this.comp_lista_dgv.AllowUserToDeleteRows = false;
            this.comp_lista_dgv.BackgroundColor = System.Drawing.Color.White;
            this.comp_lista_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comp_lista_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_lista_dgv.Location = new System.Drawing.Point(32, 88);
            this.comp_lista_dgv.MultiSelect = false;
            this.comp_lista_dgv.Name = "comp_lista_dgv";
            this.comp_lista_dgv.ReadOnly = true;
            this.comp_lista_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comp_lista_dgv.Size = new System.Drawing.Size(640, 345);
            this.comp_lista_dgv.StandardTab = true;
            this.comp_lista_dgv.TabIndex = 2;
            this.comp_lista_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Componentes_DGV_CellClick);
            this.comp_lista_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_DGV_RowEnter);
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
            this.excluir_btn.Location = new System.Drawing.Point(306, 10);
            this.excluir_btn.Name = "excluir_btn";
            this.excluir_btn.Size = new System.Drawing.Size(144, 23);
            this.excluir_btn.TabIndex = 3;
            this.excluir_btn.Text = "Excluir Componente";
            this.excluir_btn.UseVisualStyleBackColor = true;
            // 
            // editar_btn
            // 
            this.editar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editar_btn.Enabled = false;
            this.editar_btn.Location = new System.Drawing.Point(156, 10);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(144, 23);
            this.editar_btn.TabIndex = 2;
            this.editar_btn.Text = "Editar Componente";
            this.editar_btn.UseVisualStyleBackColor = true;
            // 
            // cadastrar_btn
            // 
            this.cadastrar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cadastrar_btn.Location = new System.Drawing.Point(6, 10);
            this.cadastrar_btn.Name = "cadastrar_btn";
            this.cadastrar_btn.Size = new System.Drawing.Size(144, 23);
            this.cadastrar_btn.TabIndex = 1;
            this.cadastrar_btn.Text = "Cadastrar Componente";
            this.cadastrar_btn.UseVisualStyleBackColor = true;
            this.cadastrar_btn.Click += new System.EventHandler(this.Cadastrar_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok_btn.Enabled = false;
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
            this.ttl_lbl.Text = "Fornecedor";
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
            // ComponentesFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComponentesFornecedor";
            this.Text = "Componentes do fornecedor";
            this.Load += new System.EventHandler(this.Form_Load);
            this.corpo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comp_lista_dgv)).EndInit();
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
        private System.Windows.Forms.Button cadastrar_btn;
        private System.Windows.Forms.DataGridView comp_lista_dgv;
        private System.Windows.Forms.Button excluir_btn;
        private System.Windows.Forms.Button editar_btn;
    }
}