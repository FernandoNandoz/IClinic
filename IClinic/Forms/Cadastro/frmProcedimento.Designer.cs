namespace IClinic.Forms.Cadastro
{
    partial class frmProcedimento
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
            System.Windows.Forms.Label labelPesquisarNome;
            System.Windows.Forms.Label labelTitulo;
            System.Windows.Forms.Label labelLinhaTitulo;
            System.Windows.Forms.Label labelNovoCadastro;
            System.Windows.Forms.Label labelLinhaNovoCadastro;
            System.Windows.Forms.Label labelEditarCadastro;
            System.Windows.Forms.Label labelLinhaEditarCadastro;
            System.Windows.Forms.Label labelCadNomeCompleto;
            System.Windows.Forms.Label labelSelecioneProduto;
            System.Windows.Forms.Label labelLinhaSelecione;
            System.Windows.Forms.Label labelUpdNomeCompleto;
            System.Windows.Forms.Label labelTipoProcedimento;
            System.Windows.Forms.Label labelUpdTipoProcedimento;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedimento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            this.panelConsultarProcedimento = new System.Windows.Forms.Panel();
            this.dataGridProcedimento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iClinicDatabaseDataSet = new IClinic.DataSource.IClinicDatabaseDataSet();
            this.panelNovoCadastro = new System.Windows.Forms.Panel();
            this.textBoxCadTipoProcedimento = new System.Windows.Forms.TextBox();
            this.textBoxCadProcedimento = new System.Windows.Forms.TextBox();
            this.btnSairNovoCadastro = new System.Windows.Forms.Button();
            this.btnSalvarNovoCadastro = new System.Windows.Forms.Button();
            this.panelEditarCadastro = new System.Windows.Forms.Panel();
            this.textBoxUpdTipoProcedimento = new System.Windows.Forms.TextBox();
            this.textBoxUpdProcedimento = new System.Windows.Forms.TextBox();
            this.btnVoltarEditar = new System.Windows.Forms.Button();
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.procedimentoTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.ProcedimentoTableAdapter();
            labelPesquisarNome = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            labelLinhaTitulo = new System.Windows.Forms.Label();
            labelNovoCadastro = new System.Windows.Forms.Label();
            labelLinhaNovoCadastro = new System.Windows.Forms.Label();
            labelEditarCadastro = new System.Windows.Forms.Label();
            labelLinhaEditarCadastro = new System.Windows.Forms.Label();
            labelCadNomeCompleto = new System.Windows.Forms.Label();
            labelSelecioneProduto = new System.Windows.Forms.Label();
            labelLinhaSelecione = new System.Windows.Forms.Label();
            labelUpdNomeCompleto = new System.Windows.Forms.Label();
            labelTipoProcedimento = new System.Windows.Forms.Label();
            labelUpdTipoProcedimento = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.flpContainerPai.SuspendLayout();
            this.panelConsultarProcedimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcedimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).BeginInit();
            this.panelNovoCadastro.SuspendLayout();
            this.panelEditarCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPesquisarNome
            // 
            labelPesquisarNome.AutoSize = true;
            labelPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPesquisarNome.ForeColor = System.Drawing.SystemColors.Control;
            labelPesquisarNome.Location = new System.Drawing.Point(31, 41);
            labelPesquisarNome.Name = "labelPesquisarNome";
            labelPesquisarNome.Size = new System.Drawing.Size(123, 20);
            labelPesquisarNome.TabIndex = 47;
            labelPesquisarNome.Text = "Pesquisar nome";
            labelPesquisarNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelTitulo.Location = new System.Drawing.Point(25, 8);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(226, 24);
            labelTitulo.TabIndex = 33;
            labelTitulo.Text = "Exames  / Procedimentos";
            labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaTitulo
            // 
            labelLinhaTitulo.AutoSize = true;
            labelLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaTitulo.Location = new System.Drawing.Point(25, 13);
            labelLinhaTitulo.Name = "labelLinhaTitulo";
            labelLinhaTitulo.Size = new System.Drawing.Size(850, 24);
            labelLinhaTitulo.TabIndex = 34;
            labelLinhaTitulo.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // labelNovoCadastro
            // 
            labelNovoCadastro.AutoSize = true;
            labelNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelNovoCadastro.Location = new System.Drawing.Point(20, 8);
            labelNovoCadastro.Name = "labelNovoCadastro";
            labelNovoCadastro.Size = new System.Drawing.Size(134, 24);
            labelNovoCadastro.TabIndex = 35;
            labelNovoCadastro.Text = "Novo Cadastro";
            labelNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaNovoCadastro
            // 
            labelLinhaNovoCadastro.AutoSize = true;
            labelLinhaNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaNovoCadastro.Location = new System.Drawing.Point(20, 13);
            labelLinhaNovoCadastro.Name = "labelLinhaNovoCadastro";
            labelLinhaNovoCadastro.Size = new System.Drawing.Size(850, 24);
            labelLinhaNovoCadastro.TabIndex = 36;
            labelLinhaNovoCadastro.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // labelEditarCadastro
            // 
            labelEditarCadastro.AutoSize = true;
            labelEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelEditarCadastro.Location = new System.Drawing.Point(20, 8);
            labelEditarCadastro.Name = "labelEditarCadastro";
            labelEditarCadastro.Size = new System.Drawing.Size(137, 24);
            labelEditarCadastro.TabIndex = 35;
            labelEditarCadastro.Text = "Editar Cadastro";
            labelEditarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaEditarCadastro
            // 
            labelLinhaEditarCadastro.AutoSize = true;
            labelLinhaEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaEditarCadastro.Location = new System.Drawing.Point(20, 13);
            labelLinhaEditarCadastro.Name = "labelLinhaEditarCadastro";
            labelLinhaEditarCadastro.Size = new System.Drawing.Size(860, 24);
            labelLinhaEditarCadastro.TabIndex = 36;
            labelLinhaEditarCadastro.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // labelCadNomeCompleto
            // 
            labelCadNomeCompleto.AutoSize = true;
            labelCadNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNomeCompleto.Location = new System.Drawing.Point(80, 88);
            labelCadNomeCompleto.Name = "labelCadNomeCompleto";
            labelCadNomeCompleto.Size = new System.Drawing.Size(212, 24);
            labelCadNomeCompleto.TabIndex = 42;
            labelCadNomeCompleto.Text = "Nome do Procedimento";
            // 
            // labelSelecioneProduto
            // 
            labelSelecioneProduto.AutoSize = true;
            labelSelecioneProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            labelSelecioneProduto.ForeColor = System.Drawing.SystemColors.Control;
            labelSelecioneProduto.Location = new System.Drawing.Point(25, 9);
            labelSelecioneProduto.Name = "labelSelecioneProduto";
            labelSelecioneProduto.Size = new System.Drawing.Size(513, 22);
            labelSelecioneProduto.TabIndex = 52;
            labelSelecioneProduto.Text = "Selecione um nome para Editar, Vizualizar ou Excluir Cadastro:";
            labelSelecioneProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaSelecione
            // 
            labelLinhaSelecione.AutoSize = true;
            labelLinhaSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaSelecione.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaSelecione.Location = new System.Drawing.Point(25, 13);
            labelLinhaSelecione.Name = "labelLinhaSelecione";
            labelLinhaSelecione.Size = new System.Drawing.Size(850, 24);
            labelLinhaSelecione.TabIndex = 53;
            labelLinhaSelecione.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // labelUpdNomeCompleto
            // 
            labelUpdNomeCompleto.AutoSize = true;
            labelUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNomeCompleto.Location = new System.Drawing.Point(81, 88);
            labelUpdNomeCompleto.Name = "labelUpdNomeCompleto";
            labelUpdNomeCompleto.Size = new System.Drawing.Size(212, 24);
            labelUpdNomeCompleto.TabIndex = 46;
            labelUpdNomeCompleto.Text = "Nome do Procedimento";
            // 
            // labelTipoProcedimento
            // 
            labelTipoProcedimento.AutoSize = true;
            labelTipoProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelTipoProcedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelTipoProcedimento.Location = new System.Drawing.Point(80, 171);
            labelTipoProcedimento.Name = "labelTipoProcedimento";
            labelTipoProcedimento.Size = new System.Drawing.Size(171, 24);
            labelTipoProcedimento.TabIndex = 46;
            labelTipoProcedimento.Text = "Tipo Procedimento";
            // 
            // labelUpdTipoProcedimento
            // 
            labelUpdTipoProcedimento.AutoSize = true;
            labelUpdTipoProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdTipoProcedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdTipoProcedimento.Location = new System.Drawing.Point(81, 171);
            labelUpdTipoProcedimento.Name = "labelUpdTipoProcedimento";
            labelUpdTipoProcedimento.Size = new System.Drawing.Size(171, 24);
            labelUpdTipoProcedimento.TabIndex = 50;
            labelUpdTipoProcedimento.Text = "Tipo Procedimento";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnPesquisar);
            this.panelMenu.Controls.Add(labelPesquisarNome);
            this.panelMenu.Controls.Add(this.textPesquisarNome);
            this.panelMenu.Controls.Add(this.btnVizualizarCadastro);
            this.panelMenu.Controls.Add(this.btnEditarCadastro);
            this.panelMenu.Controls.Add(labelTitulo);
            this.panelMenu.Controls.Add(this.btnExcluirCadastro);
            this.panelMenu.Controls.Add(labelLinhaTitulo);
            this.panelMenu.Controls.Add(this.btnNovoCadastro);
            this.panelMenu.Location = new System.Drawing.Point(7, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(900, 160);
            this.panelMenu.TabIndex = 36;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(614, 64);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(139, 28);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.Text = "   Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textPesquisarNome
            // 
            this.textPesquisarNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textPesquisarNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textPesquisarNome.Location = new System.Drawing.Point(35, 64);
            this.textPesquisarNome.Name = "textPesquisarNome";
            this.textPesquisarNome.Size = new System.Drawing.Size(573, 27);
            this.textPesquisarNome.TabIndex = 46;
            this.textPesquisarNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPesquisarNome_KeyDown);
            // 
            // btnVizualizarCadastro
            // 
            this.btnVizualizarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVizualizarCadastro.FlatAppearance.BorderSize = 0;
            this.btnVizualizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVizualizarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVizualizarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVizualizarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnVizualizarCadastro.Image")));
            this.btnVizualizarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVizualizarCadastro.Location = new System.Drawing.Point(397, 106);
            this.btnVizualizarCadastro.Name = "btnVizualizarCadastro";
            this.btnVizualizarCadastro.Size = new System.Drawing.Size(175, 35);
            this.btnVizualizarCadastro.TabIndex = 45;
            this.btnVizualizarCadastro.Text = " Vizualizar Cadastro";
            this.btnVizualizarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVizualizarCadastro.UseVisualStyleBackColor = false;
            this.btnVizualizarCadastro.Click += new System.EventHandler(this.btnVizualizarCadastro_Click);
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditarCadastro.FlatAppearance.BorderSize = 0;
            this.btnEditarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCadastro.Image")));
            this.btnEditarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCadastro.Location = new System.Drawing.Point(216, 106);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(175, 35);
            this.btnEditarCadastro.TabIndex = 42;
            this.btnEditarCadastro.Text = " Editar Cadastro";
            this.btnEditarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCadastro.UseVisualStyleBackColor = false;
            this.btnEditarCadastro.Click += new System.EventHandler(this.btnEditarCadastro_Click);
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.Firebrick;
            this.btnExcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExcluirCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluirCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCadastro.Image")));
            this.btnExcluirCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCadastro.Location = new System.Drawing.Point(578, 106);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(175, 35);
            this.btnExcluirCadastro.TabIndex = 44;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackColor = System.Drawing.Color.Teal;
            this.btnNovoCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCadastro.Image")));
            this.btnNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCadastro.Location = new System.Drawing.Point(35, 106);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(175, 35);
            this.btnNovoCadastro.TabIndex = 40;
            this.btnNovoCadastro.Text = " Novo Cadastro";
            this.btnNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoCadastro.UseVisualStyleBackColor = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // flpContainerPai
            // 
            this.flpContainerPai.AutoScroll = true;
            this.flpContainerPai.Controls.Add(this.panelConsultarProcedimento);
            this.flpContainerPai.Controls.Add(this.panelNovoCadastro);
            this.flpContainerPai.Controls.Add(this.panelEditarCadastro);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(7, 177);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(900, 516);
            this.flpContainerPai.TabIndex = 38;
            this.flpContainerPai.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContainerPai_Paint);
            // 
            // panelConsultarProcedimento
            // 
            this.panelConsultarProcedimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarProcedimento.Controls.Add(labelSelecioneProduto);
            this.panelConsultarProcedimento.Controls.Add(labelLinhaSelecione);
            this.panelConsultarProcedimento.Controls.Add(this.dataGridProcedimento);
            this.panelConsultarProcedimento.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarProcedimento.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarProcedimento.Name = "panelConsultarProcedimento";
            this.panelConsultarProcedimento.Size = new System.Drawing.Size(900, 516);
            this.panelConsultarProcedimento.TabIndex = 38;
            this.panelConsultarProcedimento.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultarProcedimento_Paint);
            // 
            // dataGridProcedimento
            // 
            this.dataGridProcedimento.AllowUserToAddRows = false;
            this.dataGridProcedimento.AllowUserToDeleteRows = false;
            this.dataGridProcedimento.AllowUserToResizeColumns = false;
            this.dataGridProcedimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridProcedimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridProcedimento.AutoGenerateColumns = false;
            this.dataGridProcedimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridProcedimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProcedimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProcedimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridProcedimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcedimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.procedimento,
            this.tipoProcedimento,
            this.codigoLogDataGridViewTextBoxColumn});
            this.dataGridProcedimento.DataSource = this.procedimentoBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProcedimento.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridProcedimento.EnableHeadersVisualStyles = false;
            this.dataGridProcedimento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridProcedimento.Location = new System.Drawing.Point(29, 40);
            this.dataGridProcedimento.MultiSelect = false;
            this.dataGridProcedimento.Name = "dataGridProcedimento";
            this.dataGridProcedimento.ReadOnly = true;
            this.dataGridProcedimento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProcedimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridProcedimento.RowHeadersVisible = false;
            this.dataGridProcedimento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridProcedimento.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridProcedimento.RowTemplate.Height = 30;
            this.dataGridProcedimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProcedimento.Size = new System.Drawing.Size(846, 437);
            this.dataGridProcedimento.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProcedimento";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProcedimento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // procedimento
            // 
            this.procedimento.DataPropertyName = "procedimento";
            this.procedimento.HeaderText = "Procedimento";
            this.procedimento.Name = "procedimento";
            this.procedimento.ReadOnly = true;
            this.procedimento.Width = 500;
            // 
            // tipoProcedimento
            // 
            this.tipoProcedimento.DataPropertyName = "tipoProcedimento";
            this.tipoProcedimento.HeaderText = "Tipo Procedimento";
            this.tipoProcedimento.Name = "tipoProcedimento";
            this.tipoProcedimento.ReadOnly = true;
            this.tipoProcedimento.Width = 345;
            // 
            // codigoLogDataGridViewTextBoxColumn
            // 
            this.codigoLogDataGridViewTextBoxColumn.DataPropertyName = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.HeaderText = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.Name = "codigoLogDataGridViewTextBoxColumn";
            this.codigoLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // procedimentoBindingSource
            // 
            this.procedimentoBindingSource.DataMember = "Procedimento";
            this.procedimentoBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // iClinicDatabaseDataSet
            // 
            this.iClinicDatabaseDataSet.DataSetName = "IClinicDatabaseDataSet";
            this.iClinicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelNovoCadastro
            // 
            this.panelNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelNovoCadastro.Controls.Add(labelTipoProcedimento);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadTipoProcedimento);
            this.panelNovoCadastro.Controls.Add(labelCadNomeCompleto);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadProcedimento);
            this.panelNovoCadastro.Controls.Add(this.btnSairNovoCadastro);
            this.panelNovoCadastro.Controls.Add(this.btnSalvarNovoCadastro);
            this.panelNovoCadastro.Controls.Add(labelNovoCadastro);
            this.panelNovoCadastro.Controls.Add(labelLinhaNovoCadastro);
            this.panelNovoCadastro.Location = new System.Drawing.Point(900, 0);
            this.panelNovoCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelNovoCadastro.Name = "panelNovoCadastro";
            this.panelNovoCadastro.Size = new System.Drawing.Size(900, 516);
            this.panelNovoCadastro.TabIndex = 39;
            this.panelNovoCadastro.Visible = false;
            this.panelNovoCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNovoCadastro_Paint);
            // 
            // textBoxCadTipoProcedimento
            // 
            this.textBoxCadTipoProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadTipoProcedimento.Location = new System.Drawing.Point(84, 198);
            this.textBoxCadTipoProcedimento.Name = "textBoxCadTipoProcedimento";
            this.textBoxCadTipoProcedimento.Size = new System.Drawing.Size(699, 29);
            this.textBoxCadTipoProcedimento.TabIndex = 42;
            // 
            // textBoxCadProcedimento
            // 
            this.textBoxCadProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadProcedimento.Location = new System.Drawing.Point(84, 115);
            this.textBoxCadProcedimento.Name = "textBoxCadProcedimento";
            this.textBoxCadProcedimento.Size = new System.Drawing.Size(699, 29);
            this.textBoxCadProcedimento.TabIndex = 41;
            // 
            // btnSairNovoCadastro
            // 
            this.btnSairNovoCadastro.BackColor = System.Drawing.Color.Firebrick;
            this.btnSairNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnSairNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSairNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairNovoCadastro.Image")));
            this.btnSairNovoCadastro.Location = new System.Drawing.Point(444, 421);
            this.btnSairNovoCadastro.Name = "btnSairNovoCadastro";
            this.btnSairNovoCadastro.Size = new System.Drawing.Size(154, 35);
            this.btnSairNovoCadastro.TabIndex = 40;
            this.btnSairNovoCadastro.Text = " Sair";
            this.btnSairNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairNovoCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairNovoCadastro.UseVisualStyleBackColor = false;
            this.btnSairNovoCadastro.Click += new System.EventHandler(this.btnSairNovoCadastro_Click);
            // 
            // btnSalvarNovoCadastro
            // 
            this.btnSalvarNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnSalvarNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnSalvarNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalvarNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarNovoCadastro.Image")));
            this.btnSalvarNovoCadastro.Location = new System.Drawing.Point(284, 421);
            this.btnSalvarNovoCadastro.Name = "btnSalvarNovoCadastro";
            this.btnSalvarNovoCadastro.Size = new System.Drawing.Size(154, 35);
            this.btnSalvarNovoCadastro.TabIndex = 39;
            this.btnSalvarNovoCadastro.Text = "Salvar";
            this.btnSalvarNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarNovoCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarNovoCadastro.UseVisualStyleBackColor = false;
            this.btnSalvarNovoCadastro.Click += new System.EventHandler(this.btnSalvarNovoCadastro_Click);
            // 
            // panelEditarCadastro
            // 
            this.panelEditarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelEditarCadastro.Controls.Add(labelUpdTipoProcedimento);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdTipoProcedimento);
            this.panelEditarCadastro.Controls.Add(labelUpdNomeCompleto);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdProcedimento);
            this.panelEditarCadastro.Controls.Add(this.btnVoltarEditar);
            this.panelEditarCadastro.Controls.Add(this.btnSalvarEditar);
            this.panelEditarCadastro.Controls.Add(labelEditarCadastro);
            this.panelEditarCadastro.Controls.Add(labelLinhaEditarCadastro);
            this.panelEditarCadastro.Location = new System.Drawing.Point(1800, 0);
            this.panelEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditarCadastro.Name = "panelEditarCadastro";
            this.panelEditarCadastro.Size = new System.Drawing.Size(900, 516);
            this.panelEditarCadastro.TabIndex = 40;
            this.panelEditarCadastro.Visible = false;
            this.panelEditarCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEditarCadastro_Paint);
            // 
            // textBoxUpdTipoProcedimento
            // 
            this.textBoxUpdTipoProcedimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimentoBindingSource, "tipoProcedimento", true));
            this.textBoxUpdTipoProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdTipoProcedimento.Location = new System.Drawing.Point(85, 198);
            this.textBoxUpdTipoProcedimento.Name = "textBoxUpdTipoProcedimento";
            this.textBoxUpdTipoProcedimento.Size = new System.Drawing.Size(699, 29);
            this.textBoxUpdTipoProcedimento.TabIndex = 46;
            // 
            // textBoxUpdProcedimento
            // 
            this.textBoxUpdProcedimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimentoBindingSource, "procedimento", true));
            this.textBoxUpdProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdProcedimento.Location = new System.Drawing.Point(85, 115);
            this.textBoxUpdProcedimento.Name = "textBoxUpdProcedimento";
            this.textBoxUpdProcedimento.Size = new System.Drawing.Size(699, 29);
            this.textBoxUpdProcedimento.TabIndex = 45;
            // 
            // btnVoltarEditar
            // 
            this.btnVoltarEditar.BackColor = System.Drawing.Color.Firebrick;
            this.btnVoltarEditar.FlatAppearance.BorderSize = 0;
            this.btnVoltarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltarEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltarEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarEditar.Image")));
            this.btnVoltarEditar.Location = new System.Drawing.Point(450, 421);
            this.btnVoltarEditar.Name = "btnVoltarEditar";
            this.btnVoltarEditar.Size = new System.Drawing.Size(154, 35);
            this.btnVoltarEditar.TabIndex = 42;
            this.btnVoltarEditar.Text = " Sair";
            this.btnVoltarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarEditar.UseVisualStyleBackColor = false;
            this.btnVoltarEditar.Click += new System.EventHandler(this.btnVoltarEditar_Click);
            // 
            // btnSalvarEditar
            // 
            this.btnSalvarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnSalvarEditar.FlatAppearance.BorderSize = 0;
            this.btnSalvarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalvarEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarEditar.Image")));
            this.btnSalvarEditar.Location = new System.Drawing.Point(290, 421);
            this.btnSalvarEditar.Name = "btnSalvarEditar";
            this.btnSalvarEditar.Size = new System.Drawing.Size(154, 35);
            this.btnSalvarEditar.TabIndex = 41;
            this.btnSalvarEditar.Text = "Salvar";
            this.btnSalvarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarEditar.UseVisualStyleBackColor = false;
            this.btnSalvarEditar.Click += new System.EventHandler(this.btnSalvarEditar_Click);
            // 
            // procedimentoTableAdapter
            // 
            this.procedimentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastrarProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(914, 701);
            this.Controls.Add(this.flpContainerPai);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarProcedimento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames / Procedimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrarProcedimento_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastrarProcedimento_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flpContainerPai.ResumeLayout(false);
            this.panelConsultarProcedimento.ResumeLayout(false);
            this.panelConsultarProcedimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcedimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).EndInit();
            this.panelNovoCadastro.ResumeLayout(false);
            this.panelNovoCadastro.PerformLayout();
            this.panelEditarCadastro.ResumeLayout(false);
            this.panelEditarCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisarNome;
        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelConsultarProcedimento;
        private System.Windows.Forms.DataGridView dataGridProcedimento;
        private System.Windows.Forms.Panel panelNovoCadastro;
        private System.Windows.Forms.Panel panelEditarCadastro;
        private System.Windows.Forms.Button btnSairNovoCadastro;
        private System.Windows.Forms.Button btnSalvarNovoCadastro;
        private System.Windows.Forms.Button btnVoltarEditar;
        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.TextBox textBoxCadProcedimento;
        private DataSource.IClinicDatabaseDataSet iClinicDatabaseDataSet;
        private System.Windows.Forms.BindingSource procedimentoBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.ProcedimentoTableAdapter procedimentoTableAdapter;
        private System.Windows.Forms.TextBox textBoxCadTipoProcedimento;
        private System.Windows.Forms.TextBox textBoxUpdProcedimento;
        private System.Windows.Forms.TextBox textBoxUpdTipoProcedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelMenu;
    }
}