﻿
namespace MRP_SdC.Telas.Estoque
{
    partial class frmConsultaEstoqueComponente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_cont_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_tbx = new System.Windows.Forms.TextBox();
            this.pesquisa_btn = new System.Windows.Forms.Button();
            this.pesquisa_sep_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_descnt_cbx = new System.Windows.Forms.CheckBox();
            this.dados_pnl = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtualizaMRP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dados_estoque_pnl = new System.Windows.Forms.Panel();
            this.estoque_atual_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstoqueSeguranca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidadeAtualEstoque = new System.Windows.Forms.TextBox();
            this.estoque_atual_lbl = new System.Windows.Forms.Label();
            this.estoque_max_pnl = new System.Windows.Forms.Panel();
            this.txtNomeComponente = new System.Windows.Forms.TextBox();
            this.estoque_max_lbl = new System.Windows.Forms.Label();
            this.estoque_min_pnl = new System.Windows.Forms.Panel();
            this.txtIdComponente = new System.Windows.Forms.TextBox();
            this.estoque_min_lbl = new System.Windows.Forms.Label();
            this.chart_cht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dados_subttl_lbl = new System.Windows.Forms.Label();
            this.dados_ttl_lbl = new System.Windows.Forms.Label();
            this.dgvEstoqueComponente = new System.Windows.Forms.DataGridView();
            this.pesquisa_pnl.SuspendLayout();
            this.pesquisa_cont_pnl.SuspendLayout();
            this.dados_pnl.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.dados_estoque_pnl.SuspendLayout();
            this.estoque_atual_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.estoque_max_pnl.SuspendLayout();
            this.estoque_min_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueComponente)).BeginInit();
            this.SuspendLayout();
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(768, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 450);
            this.EspDir_pnl.TabIndex = 10;
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 450);
            this.EspEsq_pnl.TabIndex = 11;
            // 
            // ttl_lbl
            // 
            this.ttl_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttl_lbl.Location = new System.Drawing.Point(32, 0);
            this.ttl_lbl.Name = "ttl_lbl";
            this.ttl_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.ttl_lbl.Size = new System.Drawing.Size(736, 52);
            this.ttl_lbl.TabIndex = 12;
            this.ttl_lbl.Text = "Estoque de Componentes";
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
            this.pesquisa_pnl.TabIndex = 13;
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
            this.dados_pnl.Controls.Add(this.panel6);
            this.dados_pnl.Controls.Add(this.btnAtualizaMRP);
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
            this.dados_pnl.Size = new System.Drawing.Size(240, 362);
            this.dados_pnl.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtLote);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(12, 362);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 48);
            this.panel6.TabIndex = 9;
            // 
            // txtLote
            // 
            this.txtLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLote.Location = new System.Drawing.Point(0, 17);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(199, 20);
            this.txtLote.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lote";
            // 
            // btnAtualizaMRP
            // 
            this.btnAtualizaMRP.Location = new System.Drawing.Point(95, 491);
            this.btnAtualizaMRP.Name = "btnAtualizaMRP";
            this.btnAtualizaMRP.Size = new System.Drawing.Size(107, 23);
            this.btnAtualizaMRP.TabIndex = 0;
            this.btnAtualizaMRP.Text = "Atualizar Estoque";
            this.btnAtualizaMRP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exclusão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 48);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLeadTime);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 48);
            this.panel3.TabIndex = 4;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLeadTime.Location = new System.Drawing.Point(0, 17);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(199, 20);
            this.txtLeadTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lead Time";
            // 
            // dados_estoque_pnl
            // 
            this.dados_estoque_pnl.AutoSize = true;
            this.dados_estoque_pnl.Controls.Add(this.estoque_atual_pnl);
            this.dados_estoque_pnl.Controls.Add(this.estoque_max_pnl);
            this.dados_estoque_pnl.Controls.Add(this.estoque_min_pnl);
            this.dados_estoque_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dados_estoque_pnl.Location = new System.Drawing.Point(12, 133);
            this.dados_estoque_pnl.Name = "dados_estoque_pnl";
            this.dados_estoque_pnl.Size = new System.Drawing.Size(199, 181);
            this.dados_estoque_pnl.TabIndex = 3;
            // 
            // estoque_atual_pnl
            // 
            this.estoque_atual_pnl.Controls.Add(this.panel2);
            this.estoque_atual_pnl.Controls.Add(this.txtQuantidadeAtualEstoque);
            this.estoque_atual_pnl.Controls.Add(this.estoque_atual_lbl);
            this.estoque_atual_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_pnl.Location = new System.Drawing.Point(0, 96);
            this.estoque_atual_pnl.Name = "estoque_atual_pnl";
            this.estoque_atual_pnl.Size = new System.Drawing.Size(199, 85);
            this.estoque_atual_pnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEstoqueSeguranca);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 48);
            this.panel2.TabIndex = 3;
            // 
            // txtEstoqueSeguranca
            // 
            this.txtEstoqueSeguranca.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEstoqueSeguranca.Location = new System.Drawing.Point(0, 17);
            this.txtEstoqueSeguranca.Name = "txtEstoqueSeguranca";
            this.txtEstoqueSeguranca.Size = new System.Drawing.Size(199, 20);
            this.txtEstoqueSeguranca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque de Segurança";
            // 
            // txtQuantidadeAtualEstoque
            // 
            this.txtQuantidadeAtualEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantidadeAtualEstoque.Location = new System.Drawing.Point(0, 17);
            this.txtQuantidadeAtualEstoque.Name = "txtQuantidadeAtualEstoque";
            this.txtQuantidadeAtualEstoque.Size = new System.Drawing.Size(199, 20);
            this.txtQuantidadeAtualEstoque.TabIndex = 1;
            // 
            // estoque_atual_lbl
            // 
            this.estoque_atual_lbl.AutoSize = true;
            this.estoque_atual_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_atual_lbl.Name = "estoque_atual_lbl";
            this.estoque_atual_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_atual_lbl.Size = new System.Drawing.Size(131, 17);
            this.estoque_atual_lbl.TabIndex = 0;
            this.estoque_atual_lbl.Text = "Quantidade Atual Estoque";
            // 
            // estoque_max_pnl
            // 
            this.estoque_max_pnl.Controls.Add(this.txtNomeComponente);
            this.estoque_max_pnl.Controls.Add(this.estoque_max_lbl);
            this.estoque_max_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_pnl.Location = new System.Drawing.Point(0, 48);
            this.estoque_max_pnl.Name = "estoque_max_pnl";
            this.estoque_max_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_max_pnl.TabIndex = 2;
            // 
            // txtNomeComponente
            // 
            this.txtNomeComponente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNomeComponente.Location = new System.Drawing.Point(0, 17);
            this.txtNomeComponente.Name = "txtNomeComponente";
            this.txtNomeComponente.Size = new System.Drawing.Size(199, 20);
            this.txtNomeComponente.TabIndex = 1;
            // 
            // estoque_max_lbl
            // 
            this.estoque_max_lbl.AutoSize = true;
            this.estoque_max_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_max_lbl.Name = "estoque_max_lbl";
            this.estoque_max_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_max_lbl.Size = new System.Drawing.Size(98, 17);
            this.estoque_max_lbl.TabIndex = 0;
            this.estoque_max_lbl.Text = "Nome Componente";
            // 
            // estoque_min_pnl
            // 
            this.estoque_min_pnl.Controls.Add(this.txtIdComponente);
            this.estoque_min_pnl.Controls.Add(this.estoque_min_lbl);
            this.estoque_min_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_pnl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_pnl.Name = "estoque_min_pnl";
            this.estoque_min_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_min_pnl.TabIndex = 1;
            // 
            // txtIdComponente
            // 
            this.txtIdComponente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdComponente.Location = new System.Drawing.Point(0, 17);
            this.txtIdComponente.Name = "txtIdComponente";
            this.txtIdComponente.Size = new System.Drawing.Size(199, 20);
            this.txtIdComponente.TabIndex = 1;
            // 
            // estoque_min_lbl
            // 
            this.estoque_min_lbl.AutoSize = true;
            this.estoque_min_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_lbl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_lbl.Name = "estoque_min_lbl";
            this.estoque_min_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.estoque_min_lbl.Size = new System.Drawing.Size(79, 17);
            this.estoque_min_lbl.TabIndex = 0;
            this.estoque_min_lbl.Text = "Id Componente";
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
            this.chart_cht.Size = new System.Drawing.Size(199, 75);
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
            // dgvEstoqueComponente
            // 
            this.dgvEstoqueComponente.AllowUserToAddRows = false;
            this.dgvEstoqueComponente.AllowUserToDeleteRows = false;
            this.dgvEstoqueComponente.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstoqueComponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueComponente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoqueComponente.Location = new System.Drawing.Point(32, 88);
            this.dgvEstoqueComponente.MultiSelect = false;
            this.dgvEstoqueComponente.Name = "dgvEstoqueComponente";
            this.dgvEstoqueComponente.ReadOnly = true;
            this.dgvEstoqueComponente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoqueComponente.Size = new System.Drawing.Size(496, 362);
            this.dgvEstoqueComponente.StandardTab = true;
            this.dgvEstoqueComponente.TabIndex = 15;
            // 
            // frmConsultaEstoqueComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstoqueComponente);
            this.Controls.Add(this.dados_pnl);
            this.Controls.Add(this.pesquisa_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.EspEsq_pnl);
            this.Controls.Add(this.EspDir_pnl);
            this.Name = "frmConsultaEstoqueComponente";
            this.Text = "frmConsultaEstoqueComponente";
            this.Load += new System.EventHandler(this.frmConsultaEstoqueComponente_Load);
            this.pesquisa_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.PerformLayout();
            this.dados_pnl.ResumeLayout(false);
            this.dados_pnl.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueComponente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel pesquisa_pnl;
        private System.Windows.Forms.Panel pesquisa_cont_pnl;
        private System.Windows.Forms.TextBox pesquisa_tbx;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel pesquisa_sep_pnl;
        private System.Windows.Forms.CheckBox pesquisa_descnt_cbx;
        private System.Windows.Forms.Panel dados_pnl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtualizaMRP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dados_estoque_pnl;
        private System.Windows.Forms.Panel estoque_atual_pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEstoqueSeguranca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidadeAtualEstoque;
        private System.Windows.Forms.Label estoque_atual_lbl;
        private System.Windows.Forms.Panel estoque_max_pnl;
        private System.Windows.Forms.TextBox txtNomeComponente;
        private System.Windows.Forms.Label estoque_max_lbl;
        private System.Windows.Forms.Panel estoque_min_pnl;
        private System.Windows.Forms.TextBox txtIdComponente;
        private System.Windows.Forms.Label estoque_min_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cht;
        private System.Windows.Forms.Label dados_subttl_lbl;
        private System.Windows.Forms.Label dados_ttl_lbl;
        private System.Windows.Forms.DataGridView dgvEstoqueComponente;
    }
}