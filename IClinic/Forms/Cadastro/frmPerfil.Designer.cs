namespace IClinic.Forms.Cadastro
{
    partial class frmPerfil
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
            System.Windows.Forms.Label labelNovoCadastro;
            System.Windows.Forms.Label labelLinhaNovoCadastro;
            System.Windows.Forms.Label labelEditarCadastro;
            System.Windows.Forms.Label labelLinhaEditarCadastro;
            System.Windows.Forms.Label labelPesquisarNome;
            System.Windows.Forms.Label labelTitulo;
            System.Windows.Forms.Label labelLinhaTitulo;
            System.Windows.Forms.Label labelSelecioneProduto;
            System.Windows.Forms.Label labelLinhaSelecione;
            System.Windows.Forms.Label labelCadDescricaoPerfil;
            System.Windows.Forms.Label labelCadNomePerfil;
            System.Windows.Forms.Label labelUpdDescricaoPerfil;
            System.Windows.Forms.Label labelUpdNomePerfil;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            this.panelConsultarPerfil = new System.Windows.Forms.Panel();
            this.dataGridViewPerfil = new System.Windows.Forms.DataGridView();
            this.idPerfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoPerfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iClinicDatabaseDataSet = new IClinic.DataSource.IClinicDatabaseDataSet();
            this.panelNovoCadastro = new System.Windows.Forms.Panel();
            this.textBoxCadDescricaoPerfil = new System.Windows.Forms.TextBox();
            this.textBoxCadNomePerfil = new System.Windows.Forms.TextBox();
            this.btnSairNovoCadastro = new System.Windows.Forms.Button();
            this.btnSalvarNovoCadastro = new System.Windows.Forms.Button();
            this.panelEditarCadastro = new System.Windows.Forms.Panel();
            this.textBoxUpdDescricaoPerfil = new System.Windows.Forms.TextBox();
            this.textBoxUpdNomePerfil = new System.Windows.Forms.TextBox();
            this.btnVoltarEditar = new System.Windows.Forms.Button();
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.perfilTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.PerfilTableAdapter();
            labelNovoCadastro = new System.Windows.Forms.Label();
            labelLinhaNovoCadastro = new System.Windows.Forms.Label();
            labelEditarCadastro = new System.Windows.Forms.Label();
            labelLinhaEditarCadastro = new System.Windows.Forms.Label();
            labelPesquisarNome = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            labelLinhaTitulo = new System.Windows.Forms.Label();
            labelSelecioneProduto = new System.Windows.Forms.Label();
            labelLinhaSelecione = new System.Windows.Forms.Label();
            labelCadDescricaoPerfil = new System.Windows.Forms.Label();
            labelCadNomePerfil = new System.Windows.Forms.Label();
            labelUpdDescricaoPerfil = new System.Windows.Forms.Label();
            labelUpdNomePerfil = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.flpContainerPai.SuspendLayout();
            this.panelConsultarPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).BeginInit();
            this.panelNovoCadastro.SuspendLayout();
            this.panelEditarCadastro.SuspendLayout();
            this.SuspendLayout();
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
            labelLinhaNovoCadastro.Size = new System.Drawing.Size(840, 24);
            labelLinhaNovoCadastro.TabIndex = 36;
            labelLinhaNovoCadastro.Text = "_________________________________________________________________________________" +
    "__";
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
            labelLinhaEditarCadastro.Size = new System.Drawing.Size(840, 24);
            labelLinhaEditarCadastro.TabIndex = 36;
            labelLinhaEditarCadastro.Text = "_________________________________________________________________________________" +
    "__";
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
            labelTitulo.Size = new System.Drawing.Size(231, 24);
            labelTitulo.TabIndex = 33;
            labelTitulo.Text = "Cadastrar Perfil de Usuário";
            labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaTitulo
            // 
            labelLinhaTitulo.AutoSize = true;
            labelLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaTitulo.Location = new System.Drawing.Point(25, 13);
            labelLinhaTitulo.Name = "labelLinhaTitulo";
            labelLinhaTitulo.Size = new System.Drawing.Size(840, 24);
            labelLinhaTitulo.TabIndex = 34;
            labelLinhaTitulo.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // labelSelecioneProduto
            // 
            labelSelecioneProduto.AutoSize = true;
            labelSelecioneProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            labelSelecioneProduto.ForeColor = System.Drawing.SystemColors.Control;
            labelSelecioneProduto.Location = new System.Drawing.Point(27, 9);
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
            labelLinhaSelecione.Location = new System.Drawing.Point(27, 13);
            labelLinhaSelecione.Name = "labelLinhaSelecione";
            labelLinhaSelecione.Size = new System.Drawing.Size(830, 24);
            labelLinhaSelecione.TabIndex = 53;
            labelLinhaSelecione.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // labelCadDescricaoPerfil
            // 
            labelCadDescricaoPerfil.AutoSize = true;
            labelCadDescricaoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadDescricaoPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadDescricaoPerfil.Location = new System.Drawing.Point(104, 157);
            labelCadDescricaoPerfil.Name = "labelCadDescricaoPerfil";
            labelCadDescricaoPerfil.Size = new System.Drawing.Size(179, 24);
            labelCadDescricaoPerfil.TabIndex = 63;
            labelCadDescricaoPerfil.Text = "Descrição do Perfil *";
            // 
            // labelCadNomePerfil
            // 
            labelCadNomePerfil.AutoSize = true;
            labelCadNomePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNomePerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNomePerfil.Location = new System.Drawing.Point(104, 81);
            labelCadNomePerfil.Name = "labelCadNomePerfil";
            labelCadNomePerfil.Size = new System.Drawing.Size(147, 24);
            labelCadNomePerfil.TabIndex = 61;
            labelCadNomePerfil.Text = "Nome do Perfil *";
            // 
            // labelUpdDescricaoPerfil
            // 
            labelUpdDescricaoPerfil.AutoSize = true;
            labelUpdDescricaoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdDescricaoPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdDescricaoPerfil.Location = new System.Drawing.Point(96, 157);
            labelUpdDescricaoPerfil.Name = "labelUpdDescricaoPerfil";
            labelUpdDescricaoPerfil.Size = new System.Drawing.Size(179, 24);
            labelUpdDescricaoPerfil.TabIndex = 67;
            labelUpdDescricaoPerfil.Text = "Descrição do Perfil *";
            // 
            // labelUpdNomePerfil
            // 
            labelUpdNomePerfil.AutoSize = true;
            labelUpdNomePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomePerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNomePerfil.Location = new System.Drawing.Point(96, 81);
            labelUpdNomePerfil.Name = "labelUpdNomePerfil";
            labelUpdNomePerfil.Size = new System.Drawing.Size(147, 24);
            labelUpdNomePerfil.TabIndex = 65;
            labelUpdNomePerfil.Text = "Nome do Perfil *";
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
            this.panelMenu.TabIndex = 39;
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
            this.flpContainerPai.Controls.Add(this.panelConsultarPerfil);
            this.flpContainerPai.Controls.Add(this.panelNovoCadastro);
            this.flpContainerPai.Controls.Add(this.panelEditarCadastro);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(7, 178);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(900, 515);
            this.flpContainerPai.TabIndex = 40;
            this.flpContainerPai.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContainerPai_Paint);
            // 
            // panelConsultarPerfil
            // 
            this.panelConsultarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarPerfil.Controls.Add(labelSelecioneProduto);
            this.panelConsultarPerfil.Controls.Add(labelLinhaSelecione);
            this.panelConsultarPerfil.Controls.Add(this.dataGridViewPerfil);
            this.panelConsultarPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarPerfil.Name = "panelConsultarPerfil";
            this.panelConsultarPerfil.Size = new System.Drawing.Size(900, 515);
            this.panelConsultarPerfil.TabIndex = 38;
            this.panelConsultarPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultarPerfil_Paint);
            // 
            // dataGridViewPerfil
            // 
            this.dataGridViewPerfil.AllowUserToAddRows = false;
            this.dataGridViewPerfil.AllowUserToDeleteRows = false;
            this.dataGridViewPerfil.AllowUserToResizeColumns = false;
            this.dataGridViewPerfil.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewPerfil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPerfil.AutoGenerateColumns = false;
            this.dataGridViewPerfil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPerfil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPerfilDataGridViewTextBoxColumn,
            this.perfilDataGridViewTextBoxColumn,
            this.descricaoPerfilDataGridViewTextBoxColumn,
            this.codigoLogDataGridViewTextBoxColumn});
            this.dataGridViewPerfil.DataSource = this.perfilBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPerfil.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPerfil.EnableHeadersVisualStyles = false;
            this.dataGridViewPerfil.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewPerfil.Location = new System.Drawing.Point(29, 40);
            this.dataGridViewPerfil.MultiSelect = false;
            this.dataGridViewPerfil.Name = "dataGridViewPerfil";
            this.dataGridViewPerfil.ReadOnly = true;
            this.dataGridViewPerfil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerfil.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPerfil.RowHeadersVisible = false;
            this.dataGridViewPerfil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewPerfil.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPerfil.RowTemplate.Height = 30;
            this.dataGridViewPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerfil.Size = new System.Drawing.Size(826, 426);
            this.dataGridViewPerfil.TabIndex = 44;
            // 
            // idPerfilDataGridViewTextBoxColumn
            // 
            this.idPerfilDataGridViewTextBoxColumn.DataPropertyName = "idPerfil";
            this.idPerfilDataGridViewTextBoxColumn.HeaderText = "idPerfil";
            this.idPerfilDataGridViewTextBoxColumn.Name = "idPerfilDataGridViewTextBoxColumn";
            this.idPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPerfilDataGridViewTextBoxColumn.Visible = false;
            // 
            // perfilDataGridViewTextBoxColumn
            // 
            this.perfilDataGridViewTextBoxColumn.DataPropertyName = "perfil";
            this.perfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.perfilDataGridViewTextBoxColumn.Name = "perfilDataGridViewTextBoxColumn";
            this.perfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.perfilDataGridViewTextBoxColumn.Width = 325;
            // 
            // descricaoPerfilDataGridViewTextBoxColumn
            // 
            this.descricaoPerfilDataGridViewTextBoxColumn.DataPropertyName = "descricaoPerfil";
            this.descricaoPerfilDataGridViewTextBoxColumn.HeaderText = "Descrição Perfil";
            this.descricaoPerfilDataGridViewTextBoxColumn.Name = "descricaoPerfilDataGridViewTextBoxColumn";
            this.descricaoPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoPerfilDataGridViewTextBoxColumn.Width = 500;
            // 
            // codigoLogDataGridViewTextBoxColumn
            // 
            this.codigoLogDataGridViewTextBoxColumn.DataPropertyName = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.HeaderText = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.Name = "codigoLogDataGridViewTextBoxColumn";
            this.codigoLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // iClinicDatabaseDataSet
            // 
            this.iClinicDatabaseDataSet.DataSetName = "IClinicDatabaseDataSet";
            this.iClinicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelNovoCadastro
            // 
            this.panelNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelNovoCadastro.Controls.Add(this.textBoxCadDescricaoPerfil);
            this.panelNovoCadastro.Controls.Add(labelCadDescricaoPerfil);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadNomePerfil);
            this.panelNovoCadastro.Controls.Add(labelCadNomePerfil);
            this.panelNovoCadastro.Controls.Add(this.btnSairNovoCadastro);
            this.panelNovoCadastro.Controls.Add(this.btnSalvarNovoCadastro);
            this.panelNovoCadastro.Controls.Add(labelNovoCadastro);
            this.panelNovoCadastro.Controls.Add(labelLinhaNovoCadastro);
            this.panelNovoCadastro.Location = new System.Drawing.Point(900, 0);
            this.panelNovoCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelNovoCadastro.Name = "panelNovoCadastro";
            this.panelNovoCadastro.Size = new System.Drawing.Size(900, 515);
            this.panelNovoCadastro.TabIndex = 39;
            this.panelNovoCadastro.Visible = false;
            this.panelNovoCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNovoCadastro_Paint);
            // 
            // textBoxCadDescricaoPerfil
            // 
            this.textBoxCadDescricaoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadDescricaoPerfil.Location = new System.Drawing.Point(108, 184);
            this.textBoxCadDescricaoPerfil.Multiline = true;
            this.textBoxCadDescricaoPerfil.Name = "textBoxCadDescricaoPerfil";
            this.textBoxCadDescricaoPerfil.Size = new System.Drawing.Size(668, 101);
            this.textBoxCadDescricaoPerfil.TabIndex = 63;
            // 
            // textBoxCadNomePerfil
            // 
            this.textBoxCadNomePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomePerfil.Location = new System.Drawing.Point(108, 108);
            this.textBoxCadNomePerfil.Name = "textBoxCadNomePerfil";
            this.textBoxCadNomePerfil.Size = new System.Drawing.Size(668, 29);
            this.textBoxCadNomePerfil.TabIndex = 62;
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
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdDescricaoPerfil);
            this.panelEditarCadastro.Controls.Add(labelUpdDescricaoPerfil);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdNomePerfil);
            this.panelEditarCadastro.Controls.Add(labelUpdNomePerfil);
            this.panelEditarCadastro.Controls.Add(this.btnVoltarEditar);
            this.panelEditarCadastro.Controls.Add(this.btnSalvarEditar);
            this.panelEditarCadastro.Controls.Add(labelEditarCadastro);
            this.panelEditarCadastro.Controls.Add(labelLinhaEditarCadastro);
            this.panelEditarCadastro.Location = new System.Drawing.Point(1800, 0);
            this.panelEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditarCadastro.Name = "panelEditarCadastro";
            this.panelEditarCadastro.Size = new System.Drawing.Size(900, 515);
            this.panelEditarCadastro.TabIndex = 40;
            this.panelEditarCadastro.Visible = false;
            this.panelEditarCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEditarCadastro_Paint);
            // 
            // textBoxUpdDescricaoPerfil
            // 
            this.textBoxUpdDescricaoPerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "descricaoPerfil", true));
            this.textBoxUpdDescricaoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdDescricaoPerfil.Location = new System.Drawing.Point(100, 184);
            this.textBoxUpdDescricaoPerfil.Multiline = true;
            this.textBoxUpdDescricaoPerfil.Name = "textBoxUpdDescricaoPerfil";
            this.textBoxUpdDescricaoPerfil.Size = new System.Drawing.Size(668, 101);
            this.textBoxUpdDescricaoPerfil.TabIndex = 67;
            // 
            // textBoxUpdNomePerfil
            // 
            this.textBoxUpdNomePerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "perfil", true));
            this.textBoxUpdNomePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNomePerfil.Location = new System.Drawing.Point(100, 108);
            this.textBoxUpdNomePerfil.Name = "textBoxUpdNomePerfil";
            this.textBoxUpdNomePerfil.Size = new System.Drawing.Size(668, 29);
            this.textBoxUpdNomePerfil.TabIndex = 66;
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
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastrarPerfil
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
            this.Name = "frmCadastrarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Perfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrarPerfil_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastrarPerfil_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flpContainerPai.ResumeLayout(false);
            this.panelConsultarPerfil.ResumeLayout(false);
            this.panelConsultarPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).EndInit();
            this.panelNovoCadastro.ResumeLayout(false);
            this.panelNovoCadastro.PerformLayout();
            this.panelEditarCadastro.ResumeLayout(false);
            this.panelEditarCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelConsultarPerfil;
        private System.Windows.Forms.DataGridView dataGridViewPerfil;
        private System.Windows.Forms.Panel panelNovoCadastro;
        private System.Windows.Forms.Button btnSairNovoCadastro;
        private System.Windows.Forms.Button btnSalvarNovoCadastro;
        private System.Windows.Forms.Panel panelEditarCadastro;
        private System.Windows.Forms.Button btnVoltarEditar;
        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisarNome;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.TextBox textBoxCadDescricaoPerfil;
        private System.Windows.Forms.TextBox textBoxCadNomePerfil;
        private System.Windows.Forms.TextBox textBoxUpdDescricaoPerfil;
        private System.Windows.Forms.TextBox textBoxUpdNomePerfil;
        private DataSource.IClinicDatabaseDataSet iClinicDatabaseDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoPerfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelMenu;
    }
}