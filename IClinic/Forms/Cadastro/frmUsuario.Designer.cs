
namespace IClinic.Forms.Cadastro
{
    partial class frmUsuario
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
            System.Windows.Forms.Label labelCadRepetirSenha;
            System.Windows.Forms.Label labelCadSenha;
            System.Windows.Forms.Label labelCadPerfil;
            System.Windows.Forms.Label labelCadUsuario;
            System.Windows.Forms.Label labelNomeCompleto;
            System.Windows.Forms.Label labelSelecioneProduto;
            System.Windows.Forms.Label labelLinhaSelecione;
            System.Windows.Forms.Label labelUpdRepetirSenha;
            System.Windows.Forms.Label labelUpdSenha;
            System.Windows.Forms.Label labelUpdPerfil;
            System.Windows.Forms.Label labelUpdUsuario;
            System.Windows.Forms.Label labelUpdNomeCompleto;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
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
            this.panelConsultarUsuario = new System.Windows.Forms.Panel();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iClinicDatabaseDataSet = new IClinic.DataSource.IClinicDatabaseDataSet();
            this.panelNovoCadastro = new System.Windows.Forms.Panel();
            this.comboBoxCadPrivilegio = new System.Windows.Forms.ComboBox();
            this.linkLabelCadNovoPerfil = new System.Windows.Forms.LinkLabel();
            this.textBoxCadRepetirSenha = new System.Windows.Forms.TextBox();
            this.textBoxCadSenha = new System.Windows.Forms.TextBox();
            this.comboBoxCadPerfil = new System.Windows.Forms.ComboBox();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCadUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCadNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnSairNovoCadastro = new System.Windows.Forms.Button();
            this.btnSalvarNovoCadastro = new System.Windows.Forms.Button();
            this.panelEditarCadastro = new System.Windows.Forms.Panel();
            this.comboBoxUpdPrivilegio = new System.Windows.Forms.ComboBox();
            this.linkLabelUpdNovoPerfil = new System.Windows.Forms.LinkLabel();
            this.textBoxUpdRepetirSenha = new System.Windows.Forms.TextBox();
            this.textBoxUpdSenha = new System.Windows.Forms.TextBox();
            this.comboBoxUpdPerfil = new System.Windows.Forms.ComboBox();
            this.textBoxUpdUsuario = new System.Windows.Forms.TextBox();
            this.textBoxUpdNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnVoltarEditar = new System.Windows.Forms.Button();
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.perfilTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.PerfilTableAdapter();
            this.colaboradorTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.ColaboradorTableAdapter();
            this.idColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioADM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaTratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conselhoRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemPerfilDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeProfissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            labelPesquisarNome = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            labelLinhaTitulo = new System.Windows.Forms.Label();
            labelNovoCadastro = new System.Windows.Forms.Label();
            labelLinhaNovoCadastro = new System.Windows.Forms.Label();
            labelEditarCadastro = new System.Windows.Forms.Label();
            labelLinhaEditarCadastro = new System.Windows.Forms.Label();
            labelCadRepetirSenha = new System.Windows.Forms.Label();
            labelCadSenha = new System.Windows.Forms.Label();
            labelCadPerfil = new System.Windows.Forms.Label();
            labelCadUsuario = new System.Windows.Forms.Label();
            labelNomeCompleto = new System.Windows.Forms.Label();
            labelSelecioneProduto = new System.Windows.Forms.Label();
            labelLinhaSelecione = new System.Windows.Forms.Label();
            labelUpdRepetirSenha = new System.Windows.Forms.Label();
            labelUpdSenha = new System.Windows.Forms.Label();
            labelUpdPerfil = new System.Windows.Forms.Label();
            labelUpdUsuario = new System.Windows.Forms.Label();
            labelUpdNomeCompleto = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.flpContainerPai.SuspendLayout();
            this.panelConsultarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).BeginInit();
            this.panelNovoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
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
            labelTitulo.Location = new System.Drawing.Point(25, 7);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(74, 24);
            labelTitulo.TabIndex = 33;
            labelTitulo.Text = "Usuario";
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
            labelLinhaNovoCadastro.Size = new System.Drawing.Size(830, 24);
            labelLinhaNovoCadastro.TabIndex = 36;
            labelLinhaNovoCadastro.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // labelEditarCadastro
            // 
            labelEditarCadastro.AutoSize = true;
            labelEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelEditarCadastro.Location = new System.Drawing.Point(44, 8);
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
            labelLinhaEditarCadastro.Location = new System.Drawing.Point(44, 13);
            labelLinhaEditarCadastro.Name = "labelLinhaEditarCadastro";
            labelLinhaEditarCadastro.Size = new System.Drawing.Size(840, 24);
            labelLinhaEditarCadastro.TabIndex = 36;
            labelLinhaEditarCadastro.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // labelCadRepetirSenha
            // 
            labelCadRepetirSenha.AutoSize = true;
            labelCadRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadRepetirSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadRepetirSenha.Location = new System.Drawing.Point(441, 238);
            labelCadRepetirSenha.Name = "labelCadRepetirSenha";
            labelCadRepetirSenha.Size = new System.Drawing.Size(130, 24);
            labelCadRepetirSenha.TabIndex = 85;
            labelCadRepetirSenha.Text = "Repetir Senha";
            // 
            // labelCadSenha
            // 
            labelCadSenha.AutoSize = true;
            labelCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadSenha.Location = new System.Drawing.Point(94, 238);
            labelCadSenha.Name = "labelCadSenha";
            labelCadSenha.Size = new System.Drawing.Size(65, 24);
            labelCadSenha.TabIndex = 83;
            labelCadSenha.Text = "Senha";
            // 
            // labelCadPerfil
            // 
            labelCadPerfil.AutoSize = true;
            labelCadPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadPerfil.Location = new System.Drawing.Point(441, 150);
            labelCadPerfil.Name = "labelCadPerfil";
            labelCadPerfil.Size = new System.Drawing.Size(51, 24);
            labelCadPerfil.TabIndex = 82;
            labelCadPerfil.Text = "Perfil";
            // 
            // labelCadUsuario
            // 
            labelCadUsuario.AutoSize = true;
            labelCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadUsuario.Location = new System.Drawing.Point(94, 151);
            labelCadUsuario.Name = "labelCadUsuario";
            labelCadUsuario.Size = new System.Drawing.Size(74, 24);
            labelCadUsuario.TabIndex = 79;
            labelCadUsuario.Text = "Usuario";
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelNomeCompleto.Location = new System.Drawing.Point(94, 84);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new System.Drawing.Size(148, 24);
            labelNomeCompleto.TabIndex = 77;
            labelNomeCompleto.Text = "Nome Completo";
            // 
            // labelSelecioneProduto
            // 
            labelSelecioneProduto.AutoSize = true;
            labelSelecioneProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            labelSelecioneProduto.ForeColor = System.Drawing.SystemColors.Control;
            labelSelecioneProduto.Location = new System.Drawing.Point(33, 10);
            labelSelecioneProduto.Name = "labelSelecioneProduto";
            labelSelecioneProduto.Size = new System.Drawing.Size(513, 22);
            labelSelecioneProduto.TabIndex = 50;
            labelSelecioneProduto.Text = "Selecione um nome para Editar, Vizualizar ou Excluir Cadastro:";
            labelSelecioneProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaSelecione
            // 
            labelLinhaSelecione.AutoSize = true;
            labelLinhaSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaSelecione.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaSelecione.Location = new System.Drawing.Point(33, 13);
            labelLinhaSelecione.Name = "labelLinhaSelecione";
            labelLinhaSelecione.Size = new System.Drawing.Size(830, 24);
            labelLinhaSelecione.TabIndex = 51;
            labelLinhaSelecione.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // labelUpdRepetirSenha
            // 
            labelUpdRepetirSenha.AutoSize = true;
            labelUpdRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdRepetirSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdRepetirSenha.Location = new System.Drawing.Point(471, 238);
            labelUpdRepetirSenha.Name = "labelUpdRepetirSenha";
            labelUpdRepetirSenha.Size = new System.Drawing.Size(130, 24);
            labelUpdRepetirSenha.TabIndex = 84;
            labelUpdRepetirSenha.Text = "Repetir Senha";
            // 
            // labelUpdSenha
            // 
            labelUpdSenha.AutoSize = true;
            labelUpdSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdSenha.Location = new System.Drawing.Point(124, 238);
            labelUpdSenha.Name = "labelUpdSenha";
            labelUpdSenha.Size = new System.Drawing.Size(65, 24);
            labelUpdSenha.TabIndex = 82;
            labelUpdSenha.Text = "Senha";
            // 
            // labelUpdPerfil
            // 
            labelUpdPerfil.AutoSize = true;
            labelUpdPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdPerfil.Location = new System.Drawing.Point(471, 150);
            labelUpdPerfil.Name = "labelUpdPerfil";
            labelUpdPerfil.Size = new System.Drawing.Size(51, 24);
            labelUpdPerfil.TabIndex = 81;
            labelUpdPerfil.Text = "Perfil";
            // 
            // labelUpdUsuario
            // 
            labelUpdUsuario.AutoSize = true;
            labelUpdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdUsuario.Location = new System.Drawing.Point(124, 151);
            labelUpdUsuario.Name = "labelUpdUsuario";
            labelUpdUsuario.Size = new System.Drawing.Size(74, 24);
            labelUpdUsuario.TabIndex = 78;
            labelUpdUsuario.Text = "Usuario";
            // 
            // labelUpdNomeCompleto
            // 
            labelUpdNomeCompleto.AutoSize = true;
            labelUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNomeCompleto.Location = new System.Drawing.Point(124, 84);
            labelUpdNomeCompleto.Name = "labelUpdNomeCompleto";
            labelUpdNomeCompleto.Size = new System.Drawing.Size(148, 24);
            labelUpdNomeCompleto.TabIndex = 76;
            labelUpdNomeCompleto.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(93, 328);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(327, 25);
            label1.TabIndex = 88;
            label1.Text = "Possui privilegios de administrador ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(123, 329);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(327, 25);
            label2.TabIndex = 90;
            label2.Text = "Possui privilegios de administrador ?";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnPesquisar);
            this.panelMenu.Controls.Add(labelPesquisarNome);
            this.panelMenu.Controls.Add(this.textPesquisarNome);
            this.panelMenu.Controls.Add(this.btnVizualizarCadastro);
            this.panelMenu.Controls.Add(this.btnEditarCadastro);
            this.panelMenu.Controls.Add(this.btnExcluirCadastro);
            this.panelMenu.Controls.Add(this.btnNovoCadastro);
            this.panelMenu.Controls.Add(labelTitulo);
            this.panelMenu.Controls.Add(labelLinhaTitulo);
            this.panelMenu.Location = new System.Drawing.Point(8, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(900, 156);
            this.panelMenu.TabIndex = 42;
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
            this.flpContainerPai.Controls.Add(this.panelConsultarUsuario);
            this.flpContainerPai.Controls.Add(this.panelNovoCadastro);
            this.flpContainerPai.Controls.Add(this.panelEditarCadastro);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(8, 173);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(900, 520);
            this.flpContainerPai.TabIndex = 43;
            this.flpContainerPai.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContainerPai_Paint);
            // 
            // panelConsultarUsuario
            // 
            this.panelConsultarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarUsuario.Controls.Add(labelSelecioneProduto);
            this.panelConsultarUsuario.Controls.Add(labelLinhaSelecione);
            this.panelConsultarUsuario.Controls.Add(this.dataGridUsuarios);
            this.panelConsultarUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarUsuario.Name = "panelConsultarUsuario";
            this.panelConsultarUsuario.Size = new System.Drawing.Size(900, 520);
            this.panelConsultarUsuario.TabIndex = 38;
            this.panelConsultarUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultarUsuario_Paint);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.AllowUserToResizeColumns = false;
            this.dataGridUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuarios.AutoGenerateColumns = false;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColaboradorDataGridViewTextBoxColumn,
            this.nomeColaboradorDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.usuarioADM,
            this.tipoColaboradorDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.formaTratamentoDataGridViewTextBoxColumn,
            this.conselhoRegistroDataGridViewTextBoxColumn,
            this.numeroRegistroDataGridViewTextBoxColumn,
            this.ufRegistroDataGridViewTextBoxColumn,
            this.especialidadeDataGridViewTextBoxColumn,
            this.imagemPerfilDataGridViewImageColumn,
            this.nomeProfissionalDataGridViewTextBoxColumn,
            this.codigoLogDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dataGridUsuarios.DataSource = this.colaboradorBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsuarios.EnableHeadersVisualStyles = false;
            this.dataGridUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridUsuarios.Location = new System.Drawing.Point(35, 40);
            this.dataGridUsuarios.MultiSelect = false;
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsuarios.RowHeadersVisible = false;
            this.dataGridUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridUsuarios.RowTemplate.Height = 30;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(840, 426);
            this.dataGridUsuarios.TabIndex = 44;
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataMember = "Colaborador";
            this.colaboradorBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // iClinicDatabaseDataSet
            // 
            this.iClinicDatabaseDataSet.DataSetName = "IClinicDatabaseDataSet";
            this.iClinicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelNovoCadastro
            // 
            this.panelNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelNovoCadastro.Controls.Add(this.comboBoxCadPrivilegio);
            this.panelNovoCadastro.Controls.Add(label1);
            this.panelNovoCadastro.Controls.Add(this.linkLabelCadNovoPerfil);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadRepetirSenha);
            this.panelNovoCadastro.Controls.Add(labelCadRepetirSenha);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadSenha);
            this.panelNovoCadastro.Controls.Add(labelCadSenha);
            this.panelNovoCadastro.Controls.Add(labelCadPerfil);
            this.panelNovoCadastro.Controls.Add(this.comboBoxCadPerfil);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadUsuario);
            this.panelNovoCadastro.Controls.Add(labelCadUsuario);
            this.panelNovoCadastro.Controls.Add(this.textBoxCadNomeCompleto);
            this.panelNovoCadastro.Controls.Add(labelNomeCompleto);
            this.panelNovoCadastro.Controls.Add(this.btnSairNovoCadastro);
            this.panelNovoCadastro.Controls.Add(this.btnSalvarNovoCadastro);
            this.panelNovoCadastro.Controls.Add(labelNovoCadastro);
            this.panelNovoCadastro.Controls.Add(labelLinhaNovoCadastro);
            this.panelNovoCadastro.Location = new System.Drawing.Point(900, 0);
            this.panelNovoCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelNovoCadastro.Name = "panelNovoCadastro";
            this.panelNovoCadastro.Size = new System.Drawing.Size(900, 519);
            this.panelNovoCadastro.TabIndex = 39;
            this.panelNovoCadastro.Visible = false;
            this.panelNovoCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNovoCadastro_Paint);
            // 
            // comboBoxCadPrivilegio
            // 
            this.comboBoxCadPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxCadPrivilegio.FormattingEnabled = true;
            this.comboBoxCadPrivilegio.Items.AddRange(new object[] {
            "NAO",
            "SIM"});
            this.comboBoxCadPrivilegio.Location = new System.Drawing.Point(445, 327);
            this.comboBoxCadPrivilegio.Name = "comboBoxCadPrivilegio";
            this.comboBoxCadPrivilegio.Size = new System.Drawing.Size(321, 30);
            this.comboBoxCadPrivilegio.TabIndex = 89;
            // 
            // linkLabelCadNovoPerfil
            // 
            this.linkLabelCadNovoPerfil.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.linkLabelCadNovoPerfil.AutoSize = true;
            this.linkLabelCadNovoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelCadNovoPerfil.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.linkLabelCadNovoPerfil.Location = new System.Drawing.Point(442, 208);
            this.linkLabelCadNovoPerfil.Name = "linkLabelCadNovoPerfil";
            this.linkLabelCadNovoPerfil.Size = new System.Drawing.Size(77, 17);
            this.linkLabelCadNovoPerfil.TabIndex = 87;
            this.linkLabelCadNovoPerfil.TabStop = true;
            this.linkLabelCadNovoPerfil.Text = "Novo Perfil";
            this.linkLabelCadNovoPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadNovoPerfil_LinkClicked);
            // 
            // textBoxCadRepetirSenha
            // 
            this.textBoxCadRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadRepetirSenha.Location = new System.Drawing.Point(445, 265);
            this.textBoxCadRepetirSenha.Name = "textBoxCadRepetirSenha";
            this.textBoxCadRepetirSenha.Size = new System.Drawing.Size(322, 29);
            this.textBoxCadRepetirSenha.TabIndex = 14;
            // 
            // textBoxCadSenha
            // 
            this.textBoxCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadSenha.Location = new System.Drawing.Point(98, 265);
            this.textBoxCadSenha.Name = "textBoxCadSenha";
            this.textBoxCadSenha.Size = new System.Drawing.Size(322, 29);
            this.textBoxCadSenha.TabIndex = 13;
            // 
            // comboBoxCadPerfil
            // 
            this.comboBoxCadPerfil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.perfilBindingSource, "idPerfil", true));
            this.comboBoxCadPerfil.DataSource = this.perfilBindingSource;
            this.comboBoxCadPerfil.DisplayMember = "perfil";
            this.comboBoxCadPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxCadPerfil.FormattingEnabled = true;
            this.comboBoxCadPerfil.Location = new System.Drawing.Point(445, 177);
            this.comboBoxCadPerfil.Name = "comboBoxCadPerfil";
            this.comboBoxCadPerfil.Size = new System.Drawing.Size(321, 30);
            this.comboBoxCadPerfil.TabIndex = 12;
            this.comboBoxCadPerfil.ValueMember = "idPerfil";
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // textBoxCadUsuario
            // 
            this.textBoxCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadUsuario.Location = new System.Drawing.Point(98, 178);
            this.textBoxCadUsuario.Name = "textBoxCadUsuario";
            this.textBoxCadUsuario.Size = new System.Drawing.Size(322, 29);
            this.textBoxCadUsuario.TabIndex = 11;
            // 
            // textBoxCadNomeCompleto
            // 
            this.textBoxCadNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomeCompleto.Location = new System.Drawing.Point(98, 111);
            this.textBoxCadNomeCompleto.Name = "textBoxCadNomeCompleto";
            this.textBoxCadNomeCompleto.Size = new System.Drawing.Size(668, 29);
            this.textBoxCadNomeCompleto.TabIndex = 10;
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
            this.panelEditarCadastro.Controls.Add(this.comboBoxUpdPrivilegio);
            this.panelEditarCadastro.Controls.Add(label2);
            this.panelEditarCadastro.Controls.Add(this.linkLabelUpdNovoPerfil);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdRepetirSenha);
            this.panelEditarCadastro.Controls.Add(labelUpdRepetirSenha);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdSenha);
            this.panelEditarCadastro.Controls.Add(labelUpdSenha);
            this.panelEditarCadastro.Controls.Add(labelUpdPerfil);
            this.panelEditarCadastro.Controls.Add(this.comboBoxUpdPerfil);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdUsuario);
            this.panelEditarCadastro.Controls.Add(labelUpdUsuario);
            this.panelEditarCadastro.Controls.Add(this.textBoxUpdNomeCompleto);
            this.panelEditarCadastro.Controls.Add(labelUpdNomeCompleto);
            this.panelEditarCadastro.Controls.Add(this.btnVoltarEditar);
            this.panelEditarCadastro.Controls.Add(this.btnSalvarEditar);
            this.panelEditarCadastro.Controls.Add(labelEditarCadastro);
            this.panelEditarCadastro.Controls.Add(labelLinhaEditarCadastro);
            this.panelEditarCadastro.Location = new System.Drawing.Point(1800, 0);
            this.panelEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditarCadastro.Name = "panelEditarCadastro";
            this.panelEditarCadastro.Size = new System.Drawing.Size(900, 520);
            this.panelEditarCadastro.TabIndex = 40;
            this.panelEditarCadastro.Visible = false;
            this.panelEditarCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEditarCadastro_Paint);
            // 
            // comboBoxUpdPrivilegio
            // 
            this.comboBoxUpdPrivilegio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "usuarioADM", true));
            this.comboBoxUpdPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxUpdPrivilegio.FormattingEnabled = true;
            this.comboBoxUpdPrivilegio.Items.AddRange(new object[] {
            "NAO",
            "SIM"});
            this.comboBoxUpdPrivilegio.Location = new System.Drawing.Point(475, 328);
            this.comboBoxUpdPrivilegio.Name = "comboBoxUpdPrivilegio";
            this.comboBoxUpdPrivilegio.Size = new System.Drawing.Size(321, 30);
            this.comboBoxUpdPrivilegio.TabIndex = 91;
            // 
            // linkLabelUpdNovoPerfil
            // 
            this.linkLabelUpdNovoPerfil.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.linkLabelUpdNovoPerfil.AutoSize = true;
            this.linkLabelUpdNovoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelUpdNovoPerfil.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.linkLabelUpdNovoPerfil.Location = new System.Drawing.Point(472, 208);
            this.linkLabelUpdNovoPerfil.Name = "linkLabelUpdNovoPerfil";
            this.linkLabelUpdNovoPerfil.Size = new System.Drawing.Size(77, 17);
            this.linkLabelUpdNovoPerfil.TabIndex = 86;
            this.linkLabelUpdNovoPerfil.TabStop = true;
            this.linkLabelUpdNovoPerfil.Text = "Novo Perfil";
            this.linkLabelUpdNovoPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdNovoPerfil_LinkClicked);
            // 
            // textBoxUpdRepetirSenha
            // 
            this.textBoxUpdRepetirSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "senha", true));
            this.textBoxUpdRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdRepetirSenha.Location = new System.Drawing.Point(475, 265);
            this.textBoxUpdRepetirSenha.Name = "textBoxUpdRepetirSenha";
            this.textBoxUpdRepetirSenha.Size = new System.Drawing.Size(322, 29);
            this.textBoxUpdRepetirSenha.TabIndex = 19;
            // 
            // textBoxUpdSenha
            // 
            this.textBoxUpdSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "senha", true));
            this.textBoxUpdSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdSenha.Location = new System.Drawing.Point(128, 265);
            this.textBoxUpdSenha.Name = "textBoxUpdSenha";
            this.textBoxUpdSenha.Size = new System.Drawing.Size(322, 29);
            this.textBoxUpdSenha.TabIndex = 18;
            // 
            // comboBoxUpdPerfil
            // 
            this.comboBoxUpdPerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "tipoColaborador", true));
            this.comboBoxUpdPerfil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.colaboradorBindingSource, "idPerfil", true));
            this.comboBoxUpdPerfil.DataSource = this.perfilBindingSource;
            this.comboBoxUpdPerfil.DisplayMember = "perfil";
            this.comboBoxUpdPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxUpdPerfil.FormattingEnabled = true;
            this.comboBoxUpdPerfil.Location = new System.Drawing.Point(475, 177);
            this.comboBoxUpdPerfil.Name = "comboBoxUpdPerfil";
            this.comboBoxUpdPerfil.Size = new System.Drawing.Size(321, 30);
            this.comboBoxUpdPerfil.TabIndex = 17;
            this.comboBoxUpdPerfil.ValueMember = "idPerfil";
            // 
            // textBoxUpdUsuario
            // 
            this.textBoxUpdUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "usuario", true));
            this.textBoxUpdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdUsuario.Location = new System.Drawing.Point(128, 178);
            this.textBoxUpdUsuario.Name = "textBoxUpdUsuario";
            this.textBoxUpdUsuario.Size = new System.Drawing.Size(322, 29);
            this.textBoxUpdUsuario.TabIndex = 16;
            // 
            // textBoxUpdNomeCompleto
            // 
            this.textBoxUpdNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "nomeColaborador", true));
            this.textBoxUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNomeCompleto.Location = new System.Drawing.Point(128, 111);
            this.textBoxUpdNomeCompleto.Name = "textBoxUpdNomeCompleto";
            this.textBoxUpdNomeCompleto.Size = new System.Drawing.Size(668, 29);
            this.textBoxUpdNomeCompleto.TabIndex = 15;
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
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // idColaboradorDataGridViewTextBoxColumn
            // 
            this.idColaboradorDataGridViewTextBoxColumn.DataPropertyName = "idColaborador";
            this.idColaboradorDataGridViewTextBoxColumn.HeaderText = "idColaborador";
            this.idColaboradorDataGridViewTextBoxColumn.Name = "idColaboradorDataGridViewTextBoxColumn";
            this.idColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idColaboradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeColaboradorDataGridViewTextBoxColumn
            // 
            this.nomeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "nomeColaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.HeaderText = "Nome Completo";
            this.nomeColaboradorDataGridViewTextBoxColumn.Name = "nomeColaboradorDataGridViewTextBoxColumn";
            this.nomeColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeColaboradorDataGridViewTextBoxColumn.Width = 380;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 200;
            // 
            // usuarioADM
            // 
            this.usuarioADM.DataPropertyName = "usuarioADM";
            this.usuarioADM.HeaderText = "Administrador";
            this.usuarioADM.Name = "usuarioADM";
            this.usuarioADM.ReadOnly = true;
            this.usuarioADM.Width = 259;
            // 
            // tipoColaboradorDataGridViewTextBoxColumn
            // 
            this.tipoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "tipoColaborador";
            this.tipoColaboradorDataGridViewTextBoxColumn.HeaderText = "Tipo Colaborador";
            this.tipoColaboradorDataGridViewTextBoxColumn.Name = "tipoColaboradorDataGridViewTextBoxColumn";
            this.tipoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoColaboradorDataGridViewTextBoxColumn.Visible = false;
            this.tipoColaboradorDataGridViewTextBoxColumn.Width = 259;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // formaTratamentoDataGridViewTextBoxColumn
            // 
            this.formaTratamentoDataGridViewTextBoxColumn.DataPropertyName = "formaTratamento";
            this.formaTratamentoDataGridViewTextBoxColumn.HeaderText = "formaTratamento";
            this.formaTratamentoDataGridViewTextBoxColumn.Name = "formaTratamentoDataGridViewTextBoxColumn";
            this.formaTratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaTratamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // conselhoRegistroDataGridViewTextBoxColumn
            // 
            this.conselhoRegistroDataGridViewTextBoxColumn.DataPropertyName = "conselhoRegistro";
            this.conselhoRegistroDataGridViewTextBoxColumn.HeaderText = "conselhoRegistro";
            this.conselhoRegistroDataGridViewTextBoxColumn.Name = "conselhoRegistroDataGridViewTextBoxColumn";
            this.conselhoRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.conselhoRegistroDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroRegistroDataGridViewTextBoxColumn
            // 
            this.numeroRegistroDataGridViewTextBoxColumn.DataPropertyName = "numeroRegistro";
            this.numeroRegistroDataGridViewTextBoxColumn.HeaderText = "numeroRegistro";
            this.numeroRegistroDataGridViewTextBoxColumn.Name = "numeroRegistroDataGridViewTextBoxColumn";
            this.numeroRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroRegistroDataGridViewTextBoxColumn.Visible = false;
            // 
            // ufRegistroDataGridViewTextBoxColumn
            // 
            this.ufRegistroDataGridViewTextBoxColumn.DataPropertyName = "ufRegistro";
            this.ufRegistroDataGridViewTextBoxColumn.HeaderText = "ufRegistro";
            this.ufRegistroDataGridViewTextBoxColumn.Name = "ufRegistroDataGridViewTextBoxColumn";
            this.ufRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufRegistroDataGridViewTextBoxColumn.Visible = false;
            // 
            // especialidadeDataGridViewTextBoxColumn
            // 
            this.especialidadeDataGridViewTextBoxColumn.DataPropertyName = "especialidade";
            this.especialidadeDataGridViewTextBoxColumn.HeaderText = "especialidade";
            this.especialidadeDataGridViewTextBoxColumn.Name = "especialidadeDataGridViewTextBoxColumn";
            this.especialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.especialidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // imagemPerfilDataGridViewImageColumn
            // 
            this.imagemPerfilDataGridViewImageColumn.DataPropertyName = "imagemPerfil";
            this.imagemPerfilDataGridViewImageColumn.HeaderText = "imagemPerfil";
            this.imagemPerfilDataGridViewImageColumn.Name = "imagemPerfilDataGridViewImageColumn";
            this.imagemPerfilDataGridViewImageColumn.ReadOnly = true;
            this.imagemPerfilDataGridViewImageColumn.Visible = false;
            // 
            // nomeProfissionalDataGridViewTextBoxColumn
            // 
            this.nomeProfissionalDataGridViewTextBoxColumn.DataPropertyName = "nomeProfissional";
            this.nomeProfissionalDataGridViewTextBoxColumn.HeaderText = "nomeProfissional";
            this.nomeProfissionalDataGridViewTextBoxColumn.Name = "nomeProfissionalDataGridViewTextBoxColumn";
            this.nomeProfissionalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProfissionalDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoLogDataGridViewTextBoxColumn
            // 
            this.codigoLogDataGridViewTextBoxColumn.DataPropertyName = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.HeaderText = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.Name = "codigoLogDataGridViewTextBoxColumn";
            this.codigoLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.senhaDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(914, 701);
            this.Controls.Add(this.flpContainerPai);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmUsuario";
            this.Text = "Cadastrar Usuario";
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flpContainerPai.ResumeLayout(false);
            this.panelConsultarUsuario.ResumeLayout(false);
            this.panelConsultarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).EndInit();
            this.panelNovoCadastro.ResumeLayout(false);
            this.panelNovoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.panelEditarCadastro.ResumeLayout(false);
            this.panelEditarCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisarNome;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelConsultarUsuario;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Panel panelNovoCadastro;
        private System.Windows.Forms.Button btnSairNovoCadastro;
        private System.Windows.Forms.Button btnSalvarNovoCadastro;
        private System.Windows.Forms.Panel panelEditarCadastro;
        private System.Windows.Forms.Button btnVoltarEditar;
        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.LinkLabel linkLabelCadNovoPerfil;
        private System.Windows.Forms.TextBox textBoxCadRepetirSenha;
        private System.Windows.Forms.TextBox textBoxCadSenha;
        private System.Windows.Forms.ComboBox comboBoxCadPerfil;
        private System.Windows.Forms.TextBox textBoxCadUsuario;
        private System.Windows.Forms.TextBox textBoxCadNomeCompleto;
        private System.Windows.Forms.LinkLabel linkLabelUpdNovoPerfil;
        private System.Windows.Forms.TextBox textBoxUpdRepetirSenha;
        private System.Windows.Forms.TextBox textBoxUpdSenha;
        private System.Windows.Forms.ComboBox comboBoxUpdPerfil;
        private System.Windows.Forms.TextBox textBoxUpdUsuario;
        private System.Windows.Forms.TextBox textBoxUpdNomeCompleto;
        private DataSource.IClinicDatabaseDataSet iClinicDatabaseDataSet;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.ColaboradorTableAdapter colaboradorTableAdapter;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ComboBox comboBoxCadPrivilegio;
        private System.Windows.Forms.ComboBox comboBoxUpdPrivilegio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioADM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaTratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conselhoRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemPerfilDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
    }
}