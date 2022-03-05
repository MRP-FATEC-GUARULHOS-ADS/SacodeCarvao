
namespace MRP_SdC.Telas.Producao
{
    partial class ConsultaBOM
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizaMRP = new System.Windows.Forms.Button();
            this.dados_estoque_pnl = new System.Windows.Forms.Panel();
            this.estoque_atual_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.estoque_max_pnl = new System.Windows.Forms.Panel();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.estoque_min_pnl = new System.Windows.Forms.Panel();
            this.txtSaidaFinal = new System.Windows.Forms.TextBox();
            this.lblSaidaFinal = new System.Windows.Forms.Label();
            this.chart_cht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dados_subttl_lbl = new System.Windows.Forms.Label();
            this.dados_ttl_lbl = new System.Windows.Forms.Label();
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCustoUnidade = new System.Windows.Forms.TextBox();
            this.lblCustoUnidade = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(768, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 573);
            this.EspDir_pnl.TabIndex = 8;
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 573);
            this.EspEsq_pnl.TabIndex = 9;
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
            this.dados_pnl.Controls.Add(this.panel4);
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
            this.dados_pnl.Size = new System.Drawing.Size(240, 485);
            this.dados_pnl.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exclusão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 48);
            this.panel1.TabIndex = 6;
            // 
            // btnAtualizaMRP
            // 
            this.btnAtualizaMRP.Location = new System.Drawing.Point(15, 436);
            this.btnAtualizaMRP.Name = "btnAtualizaMRP";
            this.btnAtualizaMRP.Size = new System.Drawing.Size(171, 23);
            this.btnAtualizaMRP.TabIndex = 0;
            this.btnAtualizaMRP.Text = "Atualizar MRP";
            this.btnAtualizaMRP.UseVisualStyleBackColor = true;
            // 
            // dados_estoque_pnl
            // 
            this.dados_estoque_pnl.AutoSize = true;
            this.dados_estoque_pnl.Controls.Add(this.estoque_atual_pnl);
            this.dados_estoque_pnl.Controls.Add(this.estoque_max_pnl);
            this.dados_estoque_pnl.Controls.Add(this.estoque_min_pnl);
            this.dados_estoque_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dados_estoque_pnl.Location = new System.Drawing.Point(12, 156);
            this.dados_estoque_pnl.Name = "dados_estoque_pnl";
            this.dados_estoque_pnl.Size = new System.Drawing.Size(199, 181);
            this.dados_estoque_pnl.TabIndex = 3;
            // 
            // estoque_atual_pnl
            // 
            this.estoque_atual_pnl.Controls.Add(this.panel2);
            this.estoque_atual_pnl.Controls.Add(this.txtCategoria);
            this.estoque_atual_pnl.Controls.Add(this.lblCategoria);
            this.estoque_atual_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_pnl.Location = new System.Drawing.Point(0, 96);
            this.estoque_atual_pnl.Name = "estoque_atual_pnl";
            this.estoque_atual_pnl.Size = new System.Drawing.Size(199, 85);
            this.estoque_atual_pnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 48);
            this.panel2.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Location = new System.Drawing.Point(0, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 1;
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
            // txtCategoria
            // 
            this.txtCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCategoria.Location = new System.Drawing.Point(0, 17);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(199, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoria.Location = new System.Drawing.Point(0, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCategoria.Size = new System.Drawing.Size(52, 17);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // estoque_max_pnl
            // 
            this.estoque_max_pnl.Controls.Add(this.txtIdProduto);
            this.estoque_max_pnl.Controls.Add(this.lblIdProduto);
            this.estoque_max_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_pnl.Location = new System.Drawing.Point(0, 48);
            this.estoque_max_pnl.Name = "estoque_max_pnl";
            this.estoque_max_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_max_pnl.TabIndex = 2;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdProduto.Location = new System.Drawing.Point(0, 17);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(199, 20);
            this.txtIdProduto.TabIndex = 1;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIdProduto.Location = new System.Drawing.Point(0, 0);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblIdProduto.Size = new System.Drawing.Size(56, 17);
            this.lblIdProduto.TabIndex = 0;
            this.lblIdProduto.Text = "Id Produto";
            // 
            // estoque_min_pnl
            // 
            this.estoque_min_pnl.Controls.Add(this.txtSaidaFinal);
            this.estoque_min_pnl.Controls.Add(this.lblSaidaFinal);
            this.estoque_min_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_pnl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_pnl.Name = "estoque_min_pnl";
            this.estoque_min_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_min_pnl.TabIndex = 1;
            // 
            // txtSaidaFinal
            // 
            this.txtSaidaFinal.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSaidaFinal.Location = new System.Drawing.Point(0, 17);
            this.txtSaidaFinal.Name = "txtSaidaFinal";
            this.txtSaidaFinal.Size = new System.Drawing.Size(199, 20);
            this.txtSaidaFinal.TabIndex = 1;
            // 
            // lblSaidaFinal
            // 
            this.lblSaidaFinal.AutoSize = true;
            this.lblSaidaFinal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaidaFinal.Location = new System.Drawing.Point(0, 0);
            this.lblSaidaFinal.Name = "lblSaidaFinal";
            this.lblSaidaFinal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblSaidaFinal.Size = new System.Drawing.Size(61, 17);
            this.lblSaidaFinal.TabIndex = 0;
            this.lblSaidaFinal.Text = "Saída Final";
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
            this.chart_cht.Size = new System.Drawing.Size(199, 98);
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
            // dgvBom
            // 
            this.dgvBom.AllowUserToAddRows = false;
            this.dgvBom.AllowUserToDeleteRows = false;
            this.dgvBom.BackgroundColor = System.Drawing.Color.White;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBom.Location = new System.Drawing.Point(32, 88);
            this.dgvBom.MultiSelect = false;
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.ReadOnly = true;
            this.dgvBom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBom.Size = new System.Drawing.Size(496, 485);
            this.dgvBom.StandardTab = true;
            this.dgvBom.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtQuantidade);
            this.panel3.Controls.Add(this.lblQuantidade);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 48);
            this.panel3.TabIndex = 4;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCustoUnidade);
            this.panel4.Controls.Add(this.lblCustoUnidade);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(12, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 48);
            this.panel4.TabIndex = 7;
            // 
            // txtCustoUnidade
            // 
            this.txtCustoUnidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCustoUnidade.Location = new System.Drawing.Point(0, 17);
            this.txtCustoUnidade.Name = "txtCustoUnidade";
            this.txtCustoUnidade.Size = new System.Drawing.Size(199, 20);
            this.txtCustoUnidade.TabIndex = 1;
            // 
            // lblCustoUnidade
            // 
            this.lblCustoUnidade.AutoSize = true;
            this.lblCustoUnidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustoUnidade.Location = new System.Drawing.Point(0, 0);
            this.lblCustoUnidade.Name = "lblCustoUnidade";
            this.lblCustoUnidade.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCustoUnidade.Size = new System.Drawing.Size(77, 17);
            this.lblCustoUnidade.TabIndex = 0;
            this.lblCustoUnidade.Text = "Custo Unidade";
            // 
            // ConsultaBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.dgvBom);
            this.Controls.Add(this.dados_pnl);
            this.Controls.Add(this.pesquisa_pnl);
            this.Controls.Add(this.ttl_lbl);
            this.Controls.Add(this.EspEsq_pnl);
            this.Controls.Add(this.EspDir_pnl);
            this.Name = "ConsultaBOM";
            this.Text = "ConsultaBOM";
            this.Load += new System.EventHandler(this.ConsultaBOM_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel pesquisa_pnl;
        private System.Windows.Forms.Panel pesquisa_cont_pnl;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel pesquisa_sep_pnl;
        private System.Windows.Forms.CheckBox pesquisa_descnt_cbx;
        private System.Windows.Forms.Panel dados_pnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizaMRP;
        private System.Windows.Forms.Panel dados_estoque_pnl;
        private System.Windows.Forms.Panel estoque_atual_pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel estoque_max_pnl;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Panel estoque_min_pnl;
        private System.Windows.Forms.TextBox txtSaidaFinal;
        private System.Windows.Forms.Label lblSaidaFinal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cht;
        private System.Windows.Forms.Label dados_subttl_lbl;
        private System.Windows.Forms.Label dados_ttl_lbl;
        public System.Windows.Forms.DataGridView dgvBom;
        public System.Windows.Forms.TextBox pesquisa_tbx;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCustoUnidade;
        private System.Windows.Forms.Label lblCustoUnidade;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}