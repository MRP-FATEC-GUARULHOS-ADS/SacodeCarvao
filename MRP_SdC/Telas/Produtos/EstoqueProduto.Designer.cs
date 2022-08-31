
namespace MRP_SdC
{
    partial class EstoqueProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueProduto));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.prod_lista_dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.árvoreDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dados_pnl = new System.Windows.Forms.Panel();
            this.atualizar_pnl = new System.Windows.Forms.Panel();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.dados_estoque_pnl = new System.Windows.Forms.Panel();
            this.estoque_atual_pnl = new System.Windows.Forms.Panel();
            this.estoque_atual_tbx = new System.Windows.Forms.TextBox();
            this.estoque_atual_lbl = new System.Windows.Forms.Label();
            this.estoque_max_pnl = new System.Windows.Forms.Panel();
            this.estoque_max_tbx = new System.Windows.Forms.TextBox();
            this.estoque_max_lbl = new System.Windows.Forms.Label();
            this.estoque_min_pnl = new System.Windows.Forms.Panel();
            this.estoque_min_tbx = new System.Windows.Forms.TextBox();
            this.estoque_min_lbl = new System.Windows.Forms.Label();
            this.chart_cht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dados_subttl_lbl = new System.Windows.Forms.Label();
            this.dados_ttl_lbl = new System.Windows.Forms.Label();
            this.pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_cont_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_tbx = new System.Windows.Forms.TextBox();
            this.pesquisa_btn = new System.Windows.Forms.Button();
            this.pesquisa_sep_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_descnt_cbx = new System.Windows.Forms.CheckBox();
            this.barraInf_pnl = new System.Windows.Forms.Panel();
            this.descnt_btn = new System.Windows.Forms.Button();
            this.arvore_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.ttl_lbl = new System.Windows.Forms.Label();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_lista_dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.dados_pnl.SuspendLayout();
            this.atualizar_pnl.SuspendLayout();
            this.dados_estoque_pnl.SuspendLayout();
            this.estoque_atual_pnl.SuspendLayout();
            this.estoque_max_pnl.SuspendLayout();
            this.estoque_min_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).BeginInit();
            this.pesquisa_pnl.SuspendLayout();
            this.pesquisa_cont_pnl.SuspendLayout();
            this.barraInf_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.AutoSize = true;
            this.corpo_pnl.Controls.Add(this.prod_lista_dgv);
            this.corpo_pnl.Controls.Add(this.dados_pnl);
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
            // prod_lista_dgv
            // 
            this.prod_lista_dgv.AllowUserToAddRows = false;
            this.prod_lista_dgv.AllowUserToDeleteRows = false;
            this.prod_lista_dgv.BackgroundColor = System.Drawing.Color.White;
            this.prod_lista_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prod_lista_dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.prod_lista_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prod_lista_dgv.Location = new System.Drawing.Point(32, 88);
            this.prod_lista_dgv.MultiSelect = false;
            this.prod_lista_dgv.Name = "prod_lista_dgv";
            this.prod_lista_dgv.ReadOnly = true;
            this.prod_lista_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prod_lista_dgv.Size = new System.Drawing.Size(400, 345);
            this.prod_lista_dgv.StandardTab = true;
            this.prod_lista_dgv.TabIndex = 2;
            this.prod_lista_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prod_lista_dgv_CellClick);
            this.prod_lista_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_DGV_RowEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.árvoreDoProdutoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // árvoreDoProdutoToolStripMenuItem
            // 
            this.árvoreDoProdutoToolStripMenuItem.Name = "árvoreDoProdutoToolStripMenuItem";
            this.árvoreDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.árvoreDoProdutoToolStripMenuItem.Text = "árvore do produto";
            this.árvoreDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.árvoreDoProdutoToolStripMenuItem_Click);
            // 
            // dados_pnl
            // 
            this.dados_pnl.AutoScroll = true;
            this.dados_pnl.Controls.Add(this.atualizar_pnl);
            this.dados_pnl.Controls.Add(this.dados_estoque_pnl);
            this.dados_pnl.Controls.Add(this.chart_cht);
            this.dados_pnl.Controls.Add(this.dados_subttl_lbl);
            this.dados_pnl.Controls.Add(this.dados_ttl_lbl);
            this.dados_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.dados_pnl.Location = new System.Drawing.Point(432, 88);
            this.dados_pnl.Name = "dados_pnl";
            this.dados_pnl.Padding = new System.Windows.Forms.Padding(12, 24, 12, 12);
            this.dados_pnl.Size = new System.Drawing.Size(240, 345);
            this.dados_pnl.TabIndex = 3;
            // 
            // atualizar_pnl
            // 
            this.atualizar_pnl.Controls.Add(this.atualizar_btn);
            this.atualizar_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.atualizar_pnl.Location = new System.Drawing.Point(12, 362);
            this.atualizar_pnl.Name = "atualizar_pnl";
            this.atualizar_pnl.Size = new System.Drawing.Size(199, 48);
            this.atualizar_pnl.TabIndex = 5;
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Enabled = false;
            this.atualizar_btn.Location = new System.Drawing.Point(3, 10);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(176, 23);
            this.atualizar_btn.TabIndex = 0;
            this.atualizar_btn.Text = "Atualizar estoque";
            this.atualizar_btn.UseVisualStyleBackColor = true;
            this.atualizar_btn.Click += new System.EventHandler(this.Estoque_btn_Click);
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
            this.dados_estoque_pnl.Size = new System.Drawing.Size(199, 144);
            this.dados_estoque_pnl.TabIndex = 3;
            // 
            // estoque_atual_pnl
            // 
            this.estoque_atual_pnl.Controls.Add(this.estoque_atual_tbx);
            this.estoque_atual_pnl.Controls.Add(this.estoque_atual_lbl);
            this.estoque_atual_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_pnl.Location = new System.Drawing.Point(0, 96);
            this.estoque_atual_pnl.Name = "estoque_atual_pnl";
            this.estoque_atual_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_atual_pnl.TabIndex = 0;
            // 
            // estoque_atual_tbx
            // 
            this.estoque_atual_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_atual_tbx.Location = new System.Drawing.Point(0, 17);
            this.estoque_atual_tbx.Name = "estoque_atual_tbx";
            this.estoque_atual_tbx.Size = new System.Drawing.Size(199, 20);
            this.estoque_atual_tbx.TabIndex = 1;
            this.estoque_atual_tbx.TextChanged += new System.EventHandler(this.Estoque_tbx_TextChanged);
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
            this.estoque_max_pnl.Controls.Add(this.estoque_max_tbx);
            this.estoque_max_pnl.Controls.Add(this.estoque_max_lbl);
            this.estoque_max_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_pnl.Location = new System.Drawing.Point(0, 48);
            this.estoque_max_pnl.Name = "estoque_max_pnl";
            this.estoque_max_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_max_pnl.TabIndex = 2;
            // 
            // estoque_max_tbx
            // 
            this.estoque_max_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_max_tbx.Location = new System.Drawing.Point(0, 17);
            this.estoque_max_tbx.Name = "estoque_max_tbx";
            this.estoque_max_tbx.Size = new System.Drawing.Size(199, 20);
            this.estoque_max_tbx.TabIndex = 1;
            this.estoque_max_tbx.TextChanged += new System.EventHandler(this.Estoque_tbx_TextChanged);
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
            this.estoque_min_pnl.Controls.Add(this.estoque_min_tbx);
            this.estoque_min_pnl.Controls.Add(this.estoque_min_lbl);
            this.estoque_min_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_pnl.Location = new System.Drawing.Point(0, 0);
            this.estoque_min_pnl.Name = "estoque_min_pnl";
            this.estoque_min_pnl.Size = new System.Drawing.Size(199, 48);
            this.estoque_min_pnl.TabIndex = 1;
            // 
            // estoque_min_tbx
            // 
            this.estoque_min_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.estoque_min_tbx.Location = new System.Drawing.Point(0, 17);
            this.estoque_min_tbx.Name = "estoque_min_tbx";
            this.estoque_min_tbx.Size = new System.Drawing.Size(199, 20);
            this.estoque_min_tbx.TabIndex = 1;
            this.estoque_min_tbx.TextChanged += new System.EventHandler(this.Estoque_tbx_TextChanged);
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
            this.chart_cht.Size = new System.Drawing.Size(199, 160);
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
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_sep_pnl);
            this.pesquisa_cont_pnl.Controls.Add(this.pesquisa_descnt_cbx);
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
            this.pesquisa_tbx.Size = new System.Drawing.Size(495, 20);
            this.pesquisa_tbx.TabIndex = 0;
            this.pesquisa_tbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pesquisar_TBX_KeyUp);
            // 
            // pesquisa_btn
            // 
            this.pesquisa_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_btn.Location = new System.Drawing.Point(495, 0);
            this.pesquisa_btn.Name = "pesquisa_btn";
            this.pesquisa_btn.Size = new System.Drawing.Size(32, 20);
            this.pesquisa_btn.TabIndex = 1;
            this.pesquisa_btn.Text = "👁";
            this.pesquisa_btn.UseVisualStyleBackColor = true;
            this.pesquisa_btn.Click += new System.EventHandler(this.Pesquisar_BTN_Click);
            // 
            // pesquisa_sep_pnl
            // 
            this.pesquisa_sep_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_sep_pnl.Location = new System.Drawing.Point(527, 0);
            this.pesquisa_sep_pnl.Name = "pesquisa_sep_pnl";
            this.pesquisa_sep_pnl.Size = new System.Drawing.Size(12, 20);
            this.pesquisa_sep_pnl.TabIndex = 3;
            // 
            // pesquisa_descnt_cbx
            // 
            this.pesquisa_descnt_cbx.AutoSize = true;
            this.pesquisa_descnt_cbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisa_descnt_cbx.Location = new System.Drawing.Point(539, 0);
            this.pesquisa_descnt_cbx.Name = "pesquisa_descnt_cbx";
            this.pesquisa_descnt_cbx.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pesquisa_descnt_cbx.Size = new System.Drawing.Size(101, 20);
            this.pesquisa_descnt_cbx.TabIndex = 4;
            this.pesquisa_descnt_cbx.Text = "descontinuados";
            this.pesquisa_descnt_cbx.UseVisualStyleBackColor = true;
            this.pesquisa_descnt_cbx.CheckedChanged += new System.EventHandler(this.Pesquisar_CBX_CheckedChanged);
            // 
            // barraInf_pnl
            // 
            this.barraInf_pnl.Controls.Add(this.descnt_btn);
            this.barraInf_pnl.Controls.Add(this.arvore_btn);
            this.barraInf_pnl.Controls.Add(this.editar_btn);
            this.barraInf_pnl.Controls.Add(this.ok_btn);
            this.barraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInf_pnl.Location = new System.Drawing.Point(32, 433);
            this.barraInf_pnl.Name = "barraInf_pnl";
            this.barraInf_pnl.Size = new System.Drawing.Size(640, 48);
            this.barraInf_pnl.TabIndex = 4;
            // 
            // descnt_btn
            // 
            this.descnt_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descnt_btn.Enabled = false;
            this.descnt_btn.Location = new System.Drawing.Point(272, 10);
            this.descnt_btn.Name = "descnt_btn";
            this.descnt_btn.Size = new System.Drawing.Size(128, 23);
            this.descnt_btn.TabIndex = 2;
            this.descnt_btn.Text = "Descontinuar Produto";
            this.descnt_btn.UseVisualStyleBackColor = true;
            this.descnt_btn.Click += new System.EventHandler(this.Descnt_btn_Click);
            // 
            // arvore_btn
            // 
            this.arvore_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arvore_btn.Enabled = false;
            this.arvore_btn.Location = new System.Drawing.Point(136, 10);
            this.arvore_btn.Name = "arvore_btn";
            this.arvore_btn.Size = new System.Drawing.Size(128, 23);
            this.arvore_btn.TabIndex = 1;
            this.arvore_btn.Text = "Árvore do Produto";
            this.arvore_btn.UseVisualStyleBackColor = true;
            this.arvore_btn.Click += new System.EventHandler(this.Arvore_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editar_btn.Enabled = false;
            this.editar_btn.Location = new System.Drawing.Point(0, 10);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(128, 23);
            this.editar_btn.TabIndex = 3;
            this.editar_btn.Text = "Editar Produto";
            this.editar_btn.UseVisualStyleBackColor = true;
            this.editar_btn.Click += new System.EventHandler(this.Editar_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.ttl_lbl.Text = "Estoque de produtos";
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
            // EstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstoqueProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estoque de produtos";
            this.Load += new System.EventHandler(this.FormEstProd_Load);
            this.corpo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prod_lista_dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.dados_pnl.ResumeLayout(false);
            this.dados_pnl.PerformLayout();
            this.atualizar_pnl.ResumeLayout(false);
            this.dados_estoque_pnl.ResumeLayout(false);
            this.estoque_atual_pnl.ResumeLayout(false);
            this.estoque_atual_pnl.PerformLayout();
            this.estoque_max_pnl.ResumeLayout(false);
            this.estoque_max_pnl.PerformLayout();
            this.estoque_min_pnl.ResumeLayout(false);
            this.estoque_min_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cht)).EndInit();
            this.pesquisa_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.ResumeLayout(false);
            this.pesquisa_cont_pnl.PerformLayout();
            this.barraInf_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel dados_pnl;
        private System.Windows.Forms.Panel dados_estoque_pnl;
        private System.Windows.Forms.Panel estoque_max_pnl;
        private System.Windows.Forms.TextBox estoque_max_tbx;
        private System.Windows.Forms.Label estoque_max_lbl;
        private System.Windows.Forms.Panel estoque_min_pnl;
        private System.Windows.Forms.TextBox estoque_min_tbx;
        private System.Windows.Forms.Label estoque_min_lbl;
        private System.Windows.Forms.Panel estoque_atual_pnl;
        private System.Windows.Forms.TextBox estoque_atual_tbx;
        private System.Windows.Forms.Label estoque_atual_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cht;
        private System.Windows.Forms.Label dados_subttl_lbl;
        private System.Windows.Forms.Label dados_ttl_lbl;
        private System.Windows.Forms.Panel pesquisa_pnl;
        private System.Windows.Forms.Panel pesquisa_cont_pnl;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel barraInf_pnl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button arvore_btn;
        private System.Windows.Forms.Label ttl_lbl;
        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.DataGridView prod_lista_dgv;
        private System.Windows.Forms.Button descnt_btn;
        private System.Windows.Forms.Panel pesquisa_sep_pnl;
        private System.Windows.Forms.CheckBox pesquisa_descnt_cbx;
        private System.Windows.Forms.Panel atualizar_pnl;
        private System.Windows.Forms.Button atualizar_btn;
        private System.Windows.Forms.Button editar_btn;
        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem árvoreDoProdutoToolStripMenuItem;
        public System.Windows.Forms.TextBox pesquisa_tbx;
    }
}