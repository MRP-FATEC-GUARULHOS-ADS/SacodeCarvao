﻿
namespace MRP_SdC.Telas.Pedido
{
    partial class ConsultaPedido
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnProduzir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnAtualizaPedido = new System.Windows.Forms.Button();
            this.btnExclusao = new System.Windows.Forms.Button();
            this.dados_estoque_pnl = new System.Windows.Forms.Panel();
            this.txt_Quantidade = new System.Windows.Forms.Panel();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.estoque_min_pnl = new System.Windows.Forms.Panel();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.estoque_min_lbl = new System.Windows.Forms.Label();
            this.chart_cht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dados_subttl_lbl = new System.Windows.Forms.Label();
            this.dados_ttl_lbl = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buscarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisa_pnl.SuspendLayout();
            this.pesquisa_cont_pnl.SuspendLayout();
            this.dados_pnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dados_estoque_pnl.SuspendLayout();
            this.txt_Quantidade.SuspendLayout();
            this.estoque_min_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 450);
            this.EspEsq_pnl.TabIndex = 8;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(768, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 450);
            this.EspDir_pnl.TabIndex = 9;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(736, 52);
            this.ttl_lbl.TabIndex = 10;
            this.ttl_lbl.Text = "Pedido - Consulta";
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
            this.pesquisa_pnl.TabIndex = 11;
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
            this.pesquisa_btn.Click += new System.EventHandler(this.pesquisa_btn_Click_1);
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
            this.dados_pnl.Controls.Add(this.panel3);
            this.dados_pnl.Controls.Add(this.panel2);
            this.dados_pnl.Controls.Add(this.btnProduzir);
            this.dados_pnl.Controls.Add(this.panel1);
            this.dados_pnl.Controls.Add(this.btnAtualizaPedido);
            this.dados_pnl.Controls.Add(this.btnExclusao);
            this.dados_pnl.Controls.Add(this.dados_estoque_pnl);
            this.dados_pnl.Controls.Add(this.chart_cht);
            this.dados_pnl.Controls.Add(this.dados_subttl_lbl);
            this.dados_pnl.Controls.Add(this.dados_ttl_lbl);
            this.dados_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.dados_pnl.Location = new System.Drawing.Point(528, 88);
            this.dados_pnl.Name = "dados_pnl";
            this.dados_pnl.Padding = new System.Windows.Forms.Padding(12, 24, 12, 12);
            this.dados_pnl.Size = new System.Drawing.Size(240, 362);
            this.dados_pnl.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSemana);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(12, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 48);
            this.panel3.TabIndex = 7;
            // 
            // txtSemana
            // 
            this.txtSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSemana.Location = new System.Drawing.Point(0, 17);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(199, 20);
            this.txtSemana.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semana";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.lblValor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(12, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 48);
            this.panel2.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValor.Location = new System.Drawing.Point(0, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(199, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValor.Location = new System.Drawing.Point(0, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblValor.Size = new System.Drawing.Size(31, 17);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // btnProduzir
            // 
            this.btnProduzir.Location = new System.Drawing.Point(127, 436);
            this.btnProduzir.Name = "btnProduzir";
            this.btnProduzir.Size = new System.Drawing.Size(91, 23);
            this.btnProduzir.TabIndex = 5;
            this.btnProduzir.Text = "Buscar Produto";
            this.btnProduzir.UseVisualStyleBackColor = true;
            this.btnProduzir.Click += new System.EventHandler(this.btnProduzir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.lblQuantidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 48);
            this.panel1.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidade.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(199, 20);
            this.txtQuantidade.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuantidade.Location = new System.Drawing.Point(0, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblQuantidade.Size = new System.Drawing.Size(62, 17);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // btnAtualizaPedido
            // 
            this.btnAtualizaPedido.Location = new System.Drawing.Point(15, 436);
            this.btnAtualizaPedido.Name = "btnAtualizaPedido";
            this.btnAtualizaPedido.Size = new System.Drawing.Size(100, 23);
            this.btnAtualizaPedido.TabIndex = 0;
            this.btnAtualizaPedido.Text = "Atualizar Pedido";
            this.btnAtualizaPedido.UseVisualStyleBackColor = true;
            this.btnAtualizaPedido.Click += new System.EventHandler(this.btnAtualizaPedido_Click);
            // 
            // btnExclusao
            // 
            this.btnExclusao.Location = new System.Drawing.Point(15, 465);
            this.btnExclusao.Name = "btnExclusao";
            this.btnExclusao.Size = new System.Drawing.Size(171, 23);
            this.btnExclusao.TabIndex = 1;
            this.btnExclusao.Text = "Exclusão";
            this.btnExclusao.UseVisualStyleBackColor = true;
            this.btnExclusao.Click += new System.EventHandler(this.btnExclusao_Click);
            // 
            // dados_estoque_pnl
            // 
            this.dados_estoque_pnl.AutoSize = true;
            this.dados_estoque_pnl.Controls.Add(this.txt_Quantidade);
            this.dados_estoque_pnl.Controls.Add(this.estoque_min_pnl);
            this.dados_estoque_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dados_estoque_pnl.Location = new System.Drawing.Point(12, 193);
            this.dados_estoque_pnl.Name = "dados_estoque_pnl";
            this.dados_estoque_pnl.Size = new System.Drawing.Size(199, 96);
            this.dados_estoque_pnl.TabIndex = 3;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Controls.Add(this.txtNomeProduto);
            this.txt_Quantidade.Controls.Add(this.lblNomeProduto);
            this.txt_Quantidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Quantidade.Location = new System.Drawing.Point(0, 48);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(199, 48);
            this.txt_Quantidade.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNomeProduto.Location = new System.Drawing.Point(0, 17);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(199, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeProduto.Location = new System.Drawing.Point(0, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNomeProduto.Size = new System.Drawing.Size(75, 17);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // estoque_min_pnl
            // 
            this.estoque_min_pnl.Controls.Add(this.txtIdProduto);
            this.estoque_min_pnl.Controls.Add(this.estoque_min_lbl);
            this.estoque_min_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_pnl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_pnl.Name = "estoque_min_pnl";
            this.estoque_min_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_min_pnl.TabIndex = 1;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdProduto.Location = new System.Drawing.Point(0, 17);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(199, 20);
            this.txtIdProduto.TabIndex = 1;
            // 
            // estoque_min_lbl
            // 
            this.estoque_min_lbl.AutoSize = true;
            this.estoque_min_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_lbl.Name = "estoque_min_lbl";
            this.estoque_min_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_min_lbl.Size = new System.Drawing.Size(56, 17);
            this.estoque_min_lbl.TabIndex = 0;
            this.estoque_min_lbl.Text = "Id Produto";
            // 
            // chart_cht
            // 
            this.chart_cht.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart_cht.ChartAreas.Add(chartArea1);
            this.chart_cht.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart_cht.Legends.Add(legend1);
            this.chart_cht.Location = new System.Drawing.Point(12, 58);
            this.chart_cht.Name = "chart_cht";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_cht.Series.Add(series1);
            this.chart_cht.Size = new System.Drawing.Size(199, 135);
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
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedido.Location = new System.Drawing.Point(32, 88);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(496, 362);
            this.dgvPedido.StandardTab = true;
            this.dgvPedido.TabIndex = 13;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedido_dgv_CellClick);
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarListaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // buscarListaToolStripMenuItem
            // 
            this.buscarListaToolStripMenuItem.Name = "buscarListaToolStripMenuItem";
            this.buscarListaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.buscarListaToolStripMenuItem.Text = "Buscar Lista";
            this.buscarListaToolStripMenuItem.Click += new System.EventHandler(this.buscarListaToolStripMenuItem_Click);
            // 
            // ConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.dados_pnl);
            this.Controls.Add(this.pesquisa_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.EspDir_pnl);
            this.Controls.Add(this.EspEsq_pnl);
            this.Name = "ConsultaPedido";
            this.Text = "ConsultaPedido";
            this.Load += new System.EventHandler(this.ConsultaPedido_Load);
            this.pesquisa_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.PerformLayout();
            this.dados_pnl.ResumeLayout(false);
            this.dados_pnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dados_estoque_pnl.ResumeLayout(false);
            this.txt_Quantidade.ResumeLayout(false);
            this.txt_Quantidade.PerformLayout();
            this.estoque_min_pnl.ResumeLayout(false);
            this.estoque_min_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAtualizaPedido;
        private System.Windows.Forms.Button btnExclusao;
        private System.Windows.Forms.Panel dados_estoque_pnl;
        private System.Windows.Forms.Panel estoque_min_pnl;
        private System.Windows.Forms.Label estoque_min_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cht;
        private System.Windows.Forms.Label dados_subttl_lbl;
        private System.Windows.Forms.Label dados_ttl_lbl;
        private System.Windows.Forms.Panel txt_Quantidade;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnProduzir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarListaToolStripMenuItem;
        public System.Windows.Forms.TextBox txtIdProduto;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.Label label1;
    }
}