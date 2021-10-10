
namespace MRP_SdC
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.resultado_lbl = new System.Windows.Forms.Label();
            this.senha_pnl = new System.Windows.Forms.Panel();
            this.senha_tbx = new System.Windows.Forms.TextBox();
            this.senha_lbl = new System.Windows.Forms.Label();
            this.user_pnl = new System.Windows.Forms.Panel();
            this.user_tbx = new System.Windows.Forms.TextBox();
            this.user_lbl = new System.Windows.Forms.Label();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.esp_dir_pnl = new System.Windows.Forms.Panel();
            this.esp_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.senha_pnl.SuspendLayout();
            this.user_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.barraInf_pnl);
            this.corpo_pnl.Controls.Add(this.resultado_lbl);
            this.corpo_pnl.Controls.Add(this.senha_pnl);
            this.corpo_pnl.Controls.Add(this.user_pnl);
            this.corpo_pnl.Controls.Add(this.ttl_lbl);
            this.corpo_pnl.Controls.Add(this.esp_dir_pnl);
            this.corpo_pnl.Controls.Add(this.esp_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(368, 281);
            this.corpo_pnl.TabIndex = 0;
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.cancelar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 233);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(304, 48);
            this.barraInf_pnl.TabIndex = 4;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelar_btn.Location = new System.Drawing.Point(3, 10);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(112, 23);
            this.cancelar_btn.TabIndex = 1;
            this.cancelar_btn.Text = "Sair";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.Sair_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok_btn.Enabled = false;
            this.ok_btn.Location = new System.Drawing.Point(189, 10);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // resultado_lbl
            // 
            this.resultado_lbl.AutoSize = true;
            this.resultado_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultado_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.resultado_lbl.Location = new System.Drawing.Point(32, 148);
            this.resultado_lbl.Name = "resultado_lbl";
            this.resultado_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.resultado_lbl.Size = new System.Drawing.Size(176, 17);
            this.resultado_lbl.TabIndex = 3;
            this.resultado_lbl.Text = "(dica: usuário=admin, senha=admin)";
            // 
            // senha_pnl
            // 
            this.senha_pnl.Controls.Add(this.senha_tbx);
            this.senha_pnl.Controls.Add(this.senha_lbl);
            this.senha_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.senha_pnl.Location = new System.Drawing.Point(32, 100);
            this.senha_pnl.Name = "senha_pnl";
            this.senha_pnl.Size = new System.Drawing.Size(304, 48);
            this.senha_pnl.TabIndex = 2;
            // 
            // senha_tbx
            // 
            this.senha_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.senha_tbx.Location = new System.Drawing.Point(0, 17);
            this.senha_tbx.Name = "senha_tbx";
            this.senha_tbx.Size = new System.Drawing.Size(304, 20);
            this.senha_tbx.TabIndex = 1;
            this.senha_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // senha_lbl
            // 
            this.senha_lbl.AutoSize = true;
            this.senha_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.senha_lbl.Location = new System.Drawing.Point(0, 0);
            this.senha_lbl.Name = "senha_lbl";
            this.senha_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.senha_lbl.Size = new System.Drawing.Size(38, 17);
            this.senha_lbl.TabIndex = 0;
            this.senha_lbl.Text = "Senha";
            // 
            // user_pnl
            // 
            this.user_pnl.Controls.Add(this.user_tbx);
            this.user_pnl.Controls.Add(this.user_lbl);
            this.user_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_pnl.Location = new System.Drawing.Point(32, 52);
            this.user_pnl.Name = "user_pnl";
            this.user_pnl.Size = new System.Drawing.Size(304, 48);
            this.user_pnl.TabIndex = 1;
            // 
            // user_tbx
            // 
            this.user_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_tbx.Location = new System.Drawing.Point(0, 17);
            this.user_tbx.Name = "user_tbx";
            this.user_tbx.Size = new System.Drawing.Size(304, 20);
            this.user_tbx.TabIndex = 1;
            this.user_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_lbl.Location = new System.Drawing.Point(0, 0);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.user_lbl.Size = new System.Drawing.Size(43, 17);
            this.user_lbl.TabIndex = 0;
            this.user_lbl.Text = "Usuário";
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(304, 52);
            this.ttl_lbl.TabIndex = 0;
            this.ttl_lbl.Text = "Login";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esp_dir_pnl
            // 
            this.esp_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.esp_dir_pnl.Location = new System.Drawing.Point(336, 0);
            this.esp_dir_pnl.Name = "esp_dir_pnl";
            this.esp_dir_pnl.Size = new System.Drawing.Size(32, 281);
            this.esp_dir_pnl.TabIndex = 8;
            // 
            // esp_esq_pnl
            // 
            this.esp_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.esp_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.esp_esq_pnl.Name = "esp_esq_pnl";
            this.esp_esq_pnl.Size = new System.Drawing.Size(32, 281);
            this.esp_esq_pnl.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 281);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Usuário";
            this.corpo_pnl.ResumeLayout(false);
            this.corpo_pnl.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.senha_pnl.ResumeLayout(false);
            this.senha_pnl.PerformLayout();
            this.user_pnl.ResumeLayout(false);
            this.user_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel user_pnl;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel esp_dir_pnl;
        private System.Windows.Forms.Panel esp_esq_pnl;
        private System.Windows.Forms.Panel senha_pnl;
        private System.Windows.Forms.Label senha_lbl;
        private System.Windows.Forms.TextBox senha_tbx;
        private System.Windows.Forms.Label resultado_lbl;
        private System.Windows.Forms.TextBox user_tbx;
    }
}