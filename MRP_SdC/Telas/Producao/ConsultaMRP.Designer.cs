﻿
namespace MRP_SdC.Telas.Producao
{
    partial class ConsultaMRP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_cont_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_tbx = new System.Windows.Forms.TextBox();
            this.pesquisa_btn = new System.Windows.Forms.Button();
            this.pesquisa_sep_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_descnt_cbx = new System.Windows.Forms.CheckBox();
            this.dados_pnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizaMRP = new System.Windows.Forms.Button();
            this.dados_estoque_pnl = new System.Windows.Forms.Panel();
            this.estoque_atual_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQntdNecesLiq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQntdEstoque = new System.Windows.Forms.TextBox();
            this.estoque_atual_lbl = new System.Windows.Forms.Label();
            this.estoque_max_pnl = new System.Windows.Forms.Panel();
            this.txtQntdPedido = new System.Windows.Forms.TextBox();
            this.estoque_max_lbl = new System.Windows.Forms.Label();
            this.estoque_min_pnl = new System.Windows.Forms.Panel();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.estoque_min_lbl = new System.Windows.Forms.Label();
            this.chart_cht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dados_subttl_lbl = new System.Windows.Forms.Label();
            this.dados_ttl_lbl = new System.Windows.Forms.Label();
            this.mrp_dgv = new System.Windows.Forms.DataGridView();
            this.pesquisa_pnl.SuspendLayout();
            this.pesquisa_cont_pnl.SuspendLayout();
            this.dados_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dados_estoque_pnl.SuspendLayout();
            this.estoque_atual_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.estoque_max_pnl.SuspendLayout();
            this.estoque_min_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrp_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 600);
            this.EspEsq_pnl.TabIndex = 6;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(768, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 600);
            this.EspDir_pnl.TabIndex = 7;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(736, 52);
            this.ttl_lbl.TabIndex = 8;
            this.ttl_lbl.Text = "Estoque de produtos";
            this.ttl_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pesquisa_pnl
            // 
            this.pesquisa_pnl.Controls.Add(this.pesquisa_cont_pnl);
            this.pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisa_pnl.Location = new System.Drawing.Point(32, 52);
            this.pesquisa_pnl.Name = "pesquisa_pnl";
            this.pesquisa_pnl.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pesquisa_pnl.Size = new System.Drawing.Size(736, 36);
            this.pesquisa_pnl.TabIndex = 9;
            // 
            // pesquisa_cont_pnl
            // 
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_tbx);
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_btn);
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_sep_pnl);
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_descnt_cbx);
            this.pesquisa_cont_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisa_cont_pnl.Location = new System.Drawing.Point(0, 6);
            this.pesquisa_cont_pnl.Name = "pesquisa_cont_pnl";
            this.pesquisa_cont_pnl.Size = new System.Drawing.Size(736, 20);
            this.pesquisa_cont_pnl.TabIndex = 0;
            // 
            // pesquisa_tbx
            // 
            this.pesquisa_tbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesquisa_tbx.Location = new System.Drawing.Point(0, 0);
            this.pesquisa_tbx.Name = "pesquisa_tbx";
            this.pesquisa_tbx.Size = new System.Drawing.Size(591, 20);
            this.pesquisa_tbx.TabIndex = 0;
            // 
            // pesquisa_btn
            // 
            this.pesquisa_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_btn.Location = new System.Drawing.Point(591, 0);
            this.pesquisa_btn.Name = "pesquisa_btn";
            this.pesquisa_btn.Size = new System.Drawing.Size(32, 20);
            this.pesquisa_btn.TabIndex = 1;
            this.pesquisa_btn.Text = "👁";
            this.pesquisa_btn.UseVisualStyleBackColor = true;
            this.pesquisa_btn.Click += new System.EventHandler(this.pesquisa_btn_Click);
            // 
            // pesquisa_sep_pnl
            // 
            this.pesquisa_sep_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_sep_pnl.Location = new System.Drawing.Point(623, 0);
            this.pesquisa_sep_pnl.Name = "pesquisa_sep_pnl";
            this.pesquisa_sep_pnl.Size = new System.Drawing.Size(12, 20);
            this.pesquisa_sep_pnl.TabIndex = 3;
            // 
            // pesquisa_descnt_cbx
            // 
            this.pesquisa_descnt_cbx.AutoSize = true;
            this.pesquisa_descnt_cbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_descnt_cbx.Location = new System.Drawing.Point(635, 0);
            this.pesquisa_descnt_cbx.Name = "pesquisa_descnt_cbx";
            this.pesquisa_descnt_cbx.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pesquisa_descnt_cbx.Size = new System.Drawing.Size(101, 20);
            this.pesquisa_descnt_cbx.TabIndex = 4;
            this.pesquisa_descnt_cbx.Text = "descontinuados";
            this.pesquisa_descnt_cbx.UseVisualStyleBackColor = true;
            // 
            // dados_pnl
            // 
            this.dados_pnl.AutoScroll = true;
            this.dados_pnl.Controls.Add(this.button1);
            this.dados_pnl.Controls.Add(this.panel1);
            this.dados_pnl.Controls.Add(this.dados_estoque_pnl);
            this.dados_pnl.Controls.Add(this.chart_cht);
            this.dados_pnl.Controls.Add(this.dados_subttl_lbl);
            this.dados_pnl.Controls.Add(this.dados_ttl_lbl);
            this.dados_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.dados_pnl.Location = new System.Drawing.Point(528, 88);
            this.dados_pnl.Name = "dados_pnl";
            this.dados_pnl.Padding = new System.Windows.Forms.Padding(12, 24, 12, 12);
            this.dados_pnl.Size = new System.Drawing.Size(240, 512);
            this.dados_pnl.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exclusão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAtualizaMRP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 48);
            this.panel1.TabIndex = 6;
            // 
            // btnAtualizaMRP
            // 
            this.btnAtualizaMRP.Location = new System.Drawing.Point(10, 13);
            this.btnAtualizaMRP.Name = "btnAtualizaMRP";
            this.btnAtualizaMRP.Size = new System.Drawing.Size(171, 23);
            this.btnAtualizaMRP.TabIndex = 0;
            this.btnAtualizaMRP.Text = "Atualizar MRP";
            this.btnAtualizaMRP.UseVisualStyleBackColor = true;
            this.btnAtualizaMRP.Click += new System.EventHandler(this.btnAtualizaMRP_Click);
            // 
            // dados_estoque_pnl
            // 
            this.dados_estoque_pnl.AutoSize = true;
            this.dados_estoque_pnl.Controls.Add(this.estoque_atual_pnl);
            this.dados_estoque_pnl.Controls.Add(this.estoque_max_pnl);
            this.dados_estoque_pnl.Controls.Add(this.estoque_min_pnl);
            this.dados_estoque_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dados_estoque_pnl.Location = new System.Drawing.Point(12, 218);
            this.dados_estoque_pnl.Name = "dados_estoque_pnl";
            this.dados_estoque_pnl.Size = new System.Drawing.Size(216, 181);
            this.dados_estoque_pnl.TabIndex = 3;
            // 
            // estoque_atual_pnl
            // 
            this.estoque_atual_pnl.Controls.Add(this.panel2);
            this.estoque_atual_pnl.Controls.Add(this.txtQntdEstoque);
            this.estoque_atual_pnl.Controls.Add(this.estoque_atual_lbl);
            this.estoque_atual_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_pnl.Location = new System.Drawing.Point(0, 96);
            this.estoque_atual_pnl.Name = "estoque_atual_pnl";
            this.estoque_atual_pnl.Size = new System.Drawing.Size(216, 85);
            this.estoque_atual_pnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQntdNecesLiq);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 48);
            this.panel2.TabIndex = 3;
            // 
            // txtQntdNecesLiq
            // 
            this.txtQntdNecesLiq.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQntdNecesLiq.Location = new System.Drawing.Point(0, 17);
            this.txtQntdNecesLiq.Name = "txtQntdNecesLiq";
            this.txtQntdNecesLiq.Size = new System.Drawing.Size(216, 20);
            this.txtQntdNecesLiq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque Máximo";
            // 
            // txtQntdEstoque
            // 
            this.txtQntdEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQntdEstoque.Location = new System.Drawing.Point(0, 17);
            this.txtQntdEstoque.Name = "txtQntdEstoque";
            this.txtQntdEstoque.Size = new System.Drawing.Size(216, 20);
            this.txtQntdEstoque.TabIndex = 1;
            // 
            // estoque_atual_lbl
            // 
            this.estoque_atual_lbl.AutoSize = true;
            this.estoque_atual_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_atual_lbl.Name = "estoque_atual_lbl";
            this.estoque_atual_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_atual_lbl.Size = new System.Drawing.Size(73, 17);
            this.estoque_atual_lbl.TabIndex = 0;
            this.estoque_atual_lbl.Text = "Estoque Atual";
            // 
            // estoque_max_pnl
            // 
            this.estoque_max_pnl.Controls.Add(this.txtQntdPedido);
            this.estoque_max_pnl.Controls.Add(this.estoque_max_lbl);
            this.estoque_max_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_pnl.Location = new System.Drawing.Point(0, 48);
            this.estoque_max_pnl.Name = "estoque_max_pnl";
            this.estoque_max_pnl.Size = new System.Drawing.Size(216, 48);
            this.estoque_max_pnl.TabIndex = 2;
            // 
            // txtQntdPedido
            // 
            this.txtQntdPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQntdPedido.Location = new System.Drawing.Point(0, 17);
            this.txtQntdPedido.Name = "txtQntdPedido";
            this.txtQntdPedido.Size = new System.Drawing.Size(216, 20);
            this.txtQntdPedido.TabIndex = 1;
            // 
            // estoque_max_lbl
            // 
            this.estoque_max_lbl.AutoSize = true;
            this.estoque_max_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_max_lbl.Name = "estoque_max_lbl";
            this.estoque_max_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_max_lbl.Size = new System.Drawing.Size(85, 17);
            this.estoque_max_lbl.TabIndex = 0;
            this.estoque_max_lbl.Text = "Estoque Máximo";
            // 
            // estoque_min_pnl
            // 
            this.estoque_min_pnl.Controls.Add(this.txtProdId);
            this.estoque_min_pnl.Controls.Add(this.estoque_min_lbl);
            this.estoque_min_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_pnl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_pnl.Name = "estoque_min_pnl";
            this.estoque_min_pnl.Size = new System.Drawing.Size(216, 48);
            this.estoque_min_pnl.TabIndex = 1;
            // 
            // txtProdId
            // 
            this.txtProdId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProdId.Location = new System.Drawing.Point(0, 17);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(216, 20);
            this.txtProdId.TabIndex = 1;
            // 
            // estoque_min_lbl
            // 
            this.estoque_min_lbl.AutoSize = true;
            this.estoque_min_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_lbl.Name = "estoque_min_lbl";
            this.estoque_min_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_min_lbl.Size = new System.Drawing.Size(84, 17);
            this.estoque_min_lbl.TabIndex = 0;
            this.estoque_min_lbl.Text = "Estoque Mínimo";
            // 
            // chart_cht
            // 
            this.chart_cht.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart_cht.ChartAreas.Add(chartArea2);
            this.chart_cht.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart_cht.Legends.Add(legend2);
            this.chart_cht.Location = new System.Drawing.Point(12, 58);
            this.chart_cht.Name = "chart_cht";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_cht.Series.Add(series2);
            this.chart_cht.Size = new System.Drawing.Size(216, 160);
            this.chart_cht.TabIndex = 2;
            this.chart_cht.Text = "chart1";
            // 
            // dados_subttl_lbl
            // 
            this.dados_subttl_lbl.AutoSize = true;
            this.dados_subttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dados_subttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_subttl_lbl.Location = new System.Drawing.Point(12, 37);
            this.dados_subttl_lbl.Name = "dados_subttl_lbl";
            this.dados_subttl_lbl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dados_subttl_lbl.Size = new System.Drawing.Size(60, 21);
            this.dados_subttl_lbl.TabIndex = 1;
            this.dados_subttl_lbl.Text = "Modelo";
            // 
            // dados_ttl_lbl
            // 
            this.dados_ttl_lbl.AutoSize = true;
            this.dados_ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dados_ttl_lbl.Location = new System.Drawing.Point(12, 24);
            this.dados_ttl_lbl.Name = "dados_ttl_lbl";
            this.dados_ttl_lbl.Size = new System.Drawing.Size(39, 13);
            this.dados_ttl_lbl.TabIndex = 0;
            this.dados_ttl_lbl.Text = "codigo";
            // 
            // mrp_dgv
            // 
            this.mrp_dgv.AllowUserToAddRows = false;
            this.mrp_dgv.AllowUserToDeleteRows = false;
            this.mrp_dgv.BackgroundColor = System.Drawing.Color.White;
            this.mrp_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mrp_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrp_dgv.Location = new System.Drawing.Point(32, 88);
            this.mrp_dgv.MultiSelect = false;
            this.mrp_dgv.Name = "mrp_dgv";
            this.mrp_dgv.ReadOnly = true;
            this.mrp_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mrp_dgv.Size = new System.Drawing.Size(496, 512);
            this.mrp_dgv.StandardTab = true;
            this.mrp_dgv.TabIndex = 11;
            this.mrp_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mrp_dgv_CellClick);
            this.mrp_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mrp_dgv_RowEnter);
            // 
            // ConsultaMRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mrp_dgv);
            this.Controls.Add(this.dados_pnl);
            this.Controls.Add(this.pesquisa_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.EspDir_pnl);
            this.Controls.Add(this.EspEsq_pnl);
            this.Name = "ConsultaMRP";
            this.Text = "ConsultaMRP";
            this.Load += new System.EventHandler(this.ConsultaMRP_Load);
            this.pesquisa_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.PerformLayout();
            this.dados_pnl.ResumeLayout(false);
            this.dados_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.dados_estoque_pnl.ResumeLayout(false);
            this.estoque_atual_pnl.ResumeLayout(false);
            this.estoque_atual_pnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.estoque_max_pnl.ResumeLayout(false);
            this.estoque_max_pnl.PerformLayout();
            this.estoque_min_pnl.ResumeLayout(false);
            this.estoque_min_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrp_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel pesquisa_pnl;
        private System.Windows.Forms.Panel pesquisa_cont_pnl;
        private System.Windows.Forms.TextBox pesquisa_tbx;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel pesquisa_sep_pnl;
        private System.Windows.Forms.CheckBox pesquisa_descnt_cbx;
        private System.Windows.Forms.Panel dados_pnl;
        private System.Windows.Forms.Panel dados_estoque_pnl;
        private System.Windows.Forms.Panel estoque_atual_pnl;
        private System.Windows.Forms.TextBox txtQntdEstoque;
        private System.Windows.Forms.Label estoque_atual_lbl;
        private System.Windows.Forms.Panel estoque_max_pnl;
        private System.Windows.Forms.TextBox txtQntdPedido;
        private System.Windows.Forms.Label estoque_max_lbl;
        private System.Windows.Forms.Panel estoque_min_pnl;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label estoque_min_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cht;
        private System.Windows.Forms.Label dados_subttl_lbl;
        private System.Windows.Forms.Label dados_ttl_lbl;
        private System.Windows.Forms.DataGridView mrp_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizaMRP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQntdNecesLiq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}