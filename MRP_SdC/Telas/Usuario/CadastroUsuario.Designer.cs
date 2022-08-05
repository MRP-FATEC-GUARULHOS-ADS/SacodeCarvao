
namespace MRP_SdC.Telas.Usuario
{
    partial class CadastroUsuario
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
            this.lblCadastrarUsuario = new System.Windows.Forms.Label();
            this.descr_pnl = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.descr_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(262, 0);
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
            // lblCadastrarUsuario
            // 
            this.lblCadastrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarUsuario.Location = new System.Drawing.Point(32, 0);
            this.lblCadastrarUsuario.Name = "lblCadastrarUsuario";
            this.lblCadastrarUsuario.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.lblCadastrarUsuario.Size = new System.Drawing.Size(230, 52);
            this.lblCadastrarUsuario.TabIndex = 11;
            this.lblCadastrarUsuario.Text = "Cadastrar Usuário";
            this.lblCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descr_pnl
            // 
            this.descr_pnl.Controls.Add(this.txtNome);
            this.descr_pnl.Controls.Add(this.lblNome);
            this.descr_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.descr_pnl.Location = new System.Drawing.Point(32, 52);
            this.descr_pnl.Name = "descr_pnl";
            this.descr_pnl.Size = new System.Drawing.Size(230, 48);
            this.descr_pnl.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Location = new System.Drawing.Point(0, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAcesso);
            this.panel1.Controls.Add(this.lblAcesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 48);
            this.panel1.TabIndex = 13;
            // 
            // txtAcesso
            // 
            this.txtAcesso.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAcesso.Location = new System.Drawing.Point(0, 17);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Size = new System.Drawing.Size(230, 20);
            this.txtAcesso.TabIndex = 2;
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAcesso.Location = new System.Drawing.Point(0, 0);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblAcesso.Size = new System.Drawing.Size(42, 17);
            this.lblAcesso.TabIndex = 0;
            this.lblAcesso.Text = "Acesso";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.lblSenha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 48);
            this.panel2.TabIndex = 14;
            // 
            // txtSenha
            // 
            this.txtSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSenha.Location = new System.Drawing.Point(0, 17);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(230, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenha.Location = new System.Drawing.Point(0, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblSenha.Size = new System.Drawing.Size(38, 17);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(47, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadastrar.Location = new System.Drawing.Point(150, 396);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descr_pnl);
            this.Controls.Add(this.lblCadastrarUsuario);
            this.Controls.Add(this.esp_esq_pnl);
            this.Controls.Add(this.esp_dir_pnl);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.descr_pnl.ResumeLayout(false);
            this.descr_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Label lblCadastrarUsuario;
        private System.Windows.Forms.Panel descr_pnl;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnCadastrar;
    }
}