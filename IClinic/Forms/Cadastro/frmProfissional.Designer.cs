namespace IClinic.Forms.Cadastro
{
    partial class frmProfissional
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
            System.Windows.Forms.Label labelCadLinhaNovoCadastro;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNovoCadastro;
            System.Windows.Forms.Label labelCadCpf;
            System.Windows.Forms.Label labelCadSexo;
            System.Windows.Forms.Label labelCadEmail;
            System.Windows.Forms.Label labelCadTelefone;
            System.Windows.Forms.Label labelCadNomeCompleto;
            System.Windows.Forms.Label labelSelecioneProduto;
            System.Windows.Forms.Label labelLinhaSelecione;
            System.Windows.Forms.Label labelCadNovoCadastro;
            System.Windows.Forms.Label labelUpdLinhaEditarCadastro;
            System.Windows.Forms.Label labelUpdNomeCompleto;
            System.Windows.Forms.Label labelUpdUpd;
            System.Windows.Forms.Label labelUpdEmail;
            System.Windows.Forms.Label labelUpdSexo;
            System.Windows.Forms.Label labelUpdCpf;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUpdEditarCadastro;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfissional));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCadDadosPessoais = new System.Windows.Forms.Panel();
            this.linkLabelCadExcluirImagem = new System.Windows.Forms.LinkLabel();
            this.maskCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskCadCpf = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCadSexo = new System.Windows.Forms.ComboBox();
            this.textBoxCadEmail = new System.Windows.Forms.TextBox();
            this.linkLabelCadImportImg = new System.Windows.Forms.LinkLabel();
            this.pictureBoxCadImgProfile = new System.Windows.Forms.PictureBox();
            this.textBoxCadNomeCompleto = new System.Windows.Forms.TextBox();
            this.panelCadDadosProfisionais = new System.Windows.Forms.Panel();
            this.labelCadEspecialidade = new System.Windows.Forms.Label();
            this.textBoxCadEspecialidade = new System.Windows.Forms.TextBox();
            this.comboBoxCadUFdeRegistro = new System.Windows.Forms.ComboBox();
            this.labelCadUFdeRegistro = new System.Windows.Forms.Label();
            this.comboBoxCadConselhoRegistro = new System.Windows.Forms.ComboBox();
            this.labelCadNdeRegistro = new System.Windows.Forms.Label();
            this.textBoxCadNdeRegistro = new System.Windows.Forms.TextBox();
            this.labelCadTipoTratamento = new System.Windows.Forms.Label();
            this.comboBoxCadTipoTratamento = new System.Windows.Forms.ComboBox();
            this.labelCadConselhoRegistro = new System.Windows.Forms.Label();
            this.panelUpdDadosPessoais = new System.Windows.Forms.Panel();
            this.linkLabelUpdExcluirImg = new System.Windows.Forms.LinkLabel();
            this.maskUpdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iClinicDatabaseDataSet = new IClinic.DataSource.IClinicDatabaseDataSet();
            this.maskUpdCpf = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxUpdSexo = new System.Windows.Forms.ComboBox();
            this.textBoxUpdEmail = new System.Windows.Forms.TextBox();
            this.linkLabelUpdImportImg = new System.Windows.Forms.LinkLabel();
            this.pictureBoxUpdImgProfile = new System.Windows.Forms.PictureBox();
            this.textBoxUpdNomeCompleto = new System.Windows.Forms.TextBox();
            this.panelUpdDadosProfissionais = new System.Windows.Forms.Panel();
            this.labelUpdEspecialidade = new System.Windows.Forms.Label();
            this.textBoxUpdEspecialidade = new System.Windows.Forms.TextBox();
            this.comboBoxUpdUFdeRegistro = new System.Windows.Forms.ComboBox();
            this.labelUpdUFdeRegistro = new System.Windows.Forms.Label();
            this.comboBoxUpdConselhoRegistro = new System.Windows.Forms.ComboBox();
            this.labelUpdNdeRegistro = new System.Windows.Forms.Label();
            this.textBoxUpdNdeRegistro = new System.Windows.Forms.TextBox();
            this.labelUpdTipoTratamento = new System.Windows.Forms.Label();
            this.comboBoxUpdTipoTratamento = new System.Windows.Forms.ComboBox();
            this.labelUpdConselhoRegistro = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelContagem = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.panelCadOpcoesCadBottom = new System.Windows.Forms.Panel();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.btnCadSair = new System.Windows.Forms.Button();
            this.panelCadTitulo = new System.Windows.Forms.Panel();
            this.panelUpdOpcoesCadBottom = new System.Windows.Forms.Panel();
            this.btnUpdSalvar = new System.Windows.Forms.Button();
            this.btnUpdSair = new System.Windows.Forms.Button();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            this.panelConsultarProfissional = new System.Windows.Forms.Panel();
            this.dataGridViewProfissional = new System.Windows.Forms.DataGridView();
            this.idColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.codigoLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNovoCadastro = new System.Windows.Forms.Panel();
            this.panelCadAbas = new System.Windows.Forms.Panel();
            this.btnCadDadosPessoais = new System.Windows.Forms.Button();
            this.btnCadDadosProfissionais = new System.Windows.Forms.Button();
            this.panelEditarCadastro = new System.Windows.Forms.Panel();
            this.panelUpdTituloEditarCadastro = new System.Windows.Forms.Panel();
            this.labelUpdEditarCadastro = new System.Windows.Forms.Label();
            this.panelUpdAbas = new System.Windows.Forms.Panel();
            this.btnUpdDadosPessoais = new System.Windows.Forms.Button();
            this.btnUpdDadosProfissionais = new System.Windows.Forms.Button();
            this.colaboradorTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.ColaboradorTableAdapter();
            this.perfilTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.PerfilTableAdapter();
            labelPesquisarNome = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            labelLinhaTitulo = new System.Windows.Forms.Label();
            labelCadLinhaNovoCadastro = new System.Windows.Forms.Label();
            flowLayoutPanelNovoCadastro = new System.Windows.Forms.FlowLayoutPanel();
            labelCadCpf = new System.Windows.Forms.Label();
            labelCadSexo = new System.Windows.Forms.Label();
            labelCadEmail = new System.Windows.Forms.Label();
            labelCadTelefone = new System.Windows.Forms.Label();
            labelCadNomeCompleto = new System.Windows.Forms.Label();
            labelSelecioneProduto = new System.Windows.Forms.Label();
            labelLinhaSelecione = new System.Windows.Forms.Label();
            labelCadNovoCadastro = new System.Windows.Forms.Label();
            labelUpdLinhaEditarCadastro = new System.Windows.Forms.Label();
            labelUpdNomeCompleto = new System.Windows.Forms.Label();
            labelUpdUpd = new System.Windows.Forms.Label();
            labelUpdEmail = new System.Windows.Forms.Label();
            labelUpdSexo = new System.Windows.Forms.Label();
            labelUpdCpf = new System.Windows.Forms.Label();
            flowLayoutPanelUpdEditarCadastro = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelNovoCadastro.SuspendLayout();
            this.panelCadDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadImgProfile)).BeginInit();
            this.panelCadDadosProfisionais.SuspendLayout();
            flowLayoutPanelUpdEditarCadastro.SuspendLayout();
            this.panelUpdDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdImgProfile)).BeginInit();
            this.panelUpdDadosProfissionais.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelCadOpcoesCadBottom.SuspendLayout();
            this.panelCadTitulo.SuspendLayout();
            this.panelUpdOpcoesCadBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.flpContainerPai.SuspendLayout();
            this.panelConsultarProfissional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfissional)).BeginInit();
            this.panelNovoCadastro.SuspendLayout();
            this.panelCadAbas.SuspendLayout();
            this.panelEditarCadastro.SuspendLayout();
            this.panelUpdTituloEditarCadastro.SuspendLayout();
            this.panelUpdAbas.SuspendLayout();
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
            labelTitulo.Size = new System.Drawing.Size(105, 24);
            labelTitulo.TabIndex = 33;
            labelTitulo.Text = "Profissional";
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
            // labelCadLinhaNovoCadastro
            // 
            labelCadLinhaNovoCadastro.AutoSize = true;
            labelCadLinhaNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadLinhaNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelCadLinhaNovoCadastro.Location = new System.Drawing.Point(24, 10);
            labelCadLinhaNovoCadastro.Name = "labelCadLinhaNovoCadastro";
            labelCadLinhaNovoCadastro.Size = new System.Drawing.Size(830, 24);
            labelCadLinhaNovoCadastro.TabIndex = 36;
            labelCadLinhaNovoCadastro.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // flowLayoutPanelNovoCadastro
            // 
            flowLayoutPanelNovoCadastro.AutoScroll = true;
            flowLayoutPanelNovoCadastro.Controls.Add(this.panelCadDadosPessoais);
            flowLayoutPanelNovoCadastro.Controls.Add(this.panelCadDadosProfisionais);
            flowLayoutPanelNovoCadastro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelNovoCadastro.Location = new System.Drawing.Point(1, 82);
            flowLayoutPanelNovoCadastro.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanelNovoCadastro.Name = "flowLayoutPanelNovoCadastro";
            flowLayoutPanelNovoCadastro.Size = new System.Drawing.Size(900, 373);
            flowLayoutPanelNovoCadastro.TabIndex = 53;
            // 
            // panelCadDadosPessoais
            // 
            this.panelCadDadosPessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelCadDadosPessoais.Controls.Add(this.linkLabelCadExcluirImagem);
            this.panelCadDadosPessoais.Controls.Add(this.maskCadTelefone);
            this.panelCadDadosPessoais.Controls.Add(this.maskCadCpf);
            this.panelCadDadosPessoais.Controls.Add(labelCadCpf);
            this.panelCadDadosPessoais.Controls.Add(labelCadSexo);
            this.panelCadDadosPessoais.Controls.Add(this.comboBoxCadSexo);
            this.panelCadDadosPessoais.Controls.Add(this.textBoxCadEmail);
            this.panelCadDadosPessoais.Controls.Add(this.linkLabelCadImportImg);
            this.panelCadDadosPessoais.Controls.Add(labelCadEmail);
            this.panelCadDadosPessoais.Controls.Add(labelCadTelefone);
            this.panelCadDadosPessoais.Controls.Add(this.pictureBoxCadImgProfile);
            this.panelCadDadosPessoais.Controls.Add(labelCadNomeCompleto);
            this.panelCadDadosPessoais.Controls.Add(this.textBoxCadNomeCompleto);
            this.panelCadDadosPessoais.Location = new System.Drawing.Point(0, 0);
            this.panelCadDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadDadosPessoais.Name = "panelCadDadosPessoais";
            this.panelCadDadosPessoais.Size = new System.Drawing.Size(900, 373);
            this.panelCadDadosPessoais.TabIndex = 0;
            this.panelCadDadosPessoais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadDadosPessoais_Paint);
            // 
            // linkLabelCadExcluirImagem
            // 
            this.linkLabelCadExcluirImagem.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelCadExcluirImagem.AutoSize = true;
            this.linkLabelCadExcluirImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelCadExcluirImagem.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabelCadExcluirImagem.Location = new System.Drawing.Point(156, 195);
            this.linkLabelCadExcluirImagem.Name = "linkLabelCadExcluirImagem";
            this.linkLabelCadExcluirImagem.Size = new System.Drawing.Size(49, 17);
            this.linkLabelCadExcluirImagem.TabIndex = 37;
            this.linkLabelCadExcluirImagem.TabStop = true;
            this.linkLabelCadExcluirImagem.Text = "Excluir";
            this.linkLabelCadExcluirImagem.Visible = false;
            this.linkLabelCadExcluirImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadExcluirImagem_LinkClicked);
            // 
            // maskCadTelefone
            // 
            this.maskCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadTelefone.Location = new System.Drawing.Point(626, 133);
            this.maskCadTelefone.Mask = "(00) 0 0000-0000";
            this.maskCadTelefone.Name = "maskCadTelefone";
            this.maskCadTelefone.Size = new System.Drawing.Size(235, 29);
            this.maskCadTelefone.TabIndex = 16;
            // 
            // maskCadCpf
            // 
            this.maskCadCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadCpf.Location = new System.Drawing.Point(418, 132);
            this.maskCadCpf.Mask = "000.000.000-00";
            this.maskCadCpf.Name = "maskCadCpf";
            this.maskCadCpf.Size = new System.Drawing.Size(195, 29);
            this.maskCadCpf.TabIndex = 15;
            // 
            // labelCadCpf
            // 
            labelCadCpf.AutoSize = true;
            labelCadCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadCpf.Location = new System.Drawing.Point(414, 106);
            labelCadCpf.Name = "labelCadCpf";
            labelCadCpf.Size = new System.Drawing.Size(59, 24);
            labelCadCpf.TabIndex = 33;
            labelCadCpf.Text = "CPF *";
            // 
            // labelCadSexo
            // 
            labelCadSexo.AutoSize = true;
            labelCadSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadSexo.Location = new System.Drawing.Point(227, 105);
            labelCadSexo.Name = "labelCadSexo";
            labelCadSexo.Size = new System.Drawing.Size(66, 24);
            labelCadSexo.TabIndex = 32;
            labelCadSexo.Text = "Sexo *";
            // 
            // comboBoxCadSexo
            // 
            this.comboBoxCadSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxCadSexo.FormattingEnabled = true;
            this.comboBoxCadSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.comboBoxCadSexo.Location = new System.Drawing.Point(231, 133);
            this.comboBoxCadSexo.Name = "comboBoxCadSexo";
            this.comboBoxCadSexo.Size = new System.Drawing.Size(175, 28);
            this.comboBoxCadSexo.TabIndex = 14;
            // 
            // textBoxCadEmail
            // 
            this.textBoxCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadEmail.Location = new System.Drawing.Point(231, 215);
            this.textBoxCadEmail.Name = "textBoxCadEmail";
            this.textBoxCadEmail.Size = new System.Drawing.Size(630, 29);
            this.textBoxCadEmail.TabIndex = 17;
            // 
            // linkLabelCadImportImg
            // 
            this.linkLabelCadImportImg.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabelCadImportImg.AutoSize = true;
            this.linkLabelCadImportImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelCadImportImg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.linkLabelCadImportImg.Location = new System.Drawing.Point(30, 194);
            this.linkLabelCadImportImg.Name = "linkLabelCadImportImg";
            this.linkLabelCadImportImg.Size = new System.Drawing.Size(113, 17);
            this.linkLabelCadImportImg.TabIndex = 28;
            this.linkLabelCadImportImg.TabStop = true;
            this.linkLabelCadImportImg.Text = "Importar Imagem";
            this.linkLabelCadImportImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadImportImg_LinkClicked);
            // 
            // labelCadEmail
            // 
            labelCadEmail.AutoSize = true;
            labelCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadEmail.Location = new System.Drawing.Point(227, 188);
            labelCadEmail.Name = "labelCadEmail";
            labelCadEmail.Size = new System.Drawing.Size(75, 24);
            labelCadEmail.TabIndex = 23;
            labelCadEmail.Text = "E-mail *";
            // 
            // labelCadTelefone
            // 
            labelCadTelefone.AutoSize = true;
            labelCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadTelefone.Location = new System.Drawing.Point(622, 106);
            labelCadTelefone.Name = "labelCadTelefone";
            labelCadTelefone.Size = new System.Drawing.Size(97, 24);
            labelCadTelefone.TabIndex = 21;
            labelCadTelefone.Text = "Telefone *";
            // 
            // pictureBoxCadImgProfile
            // 
            this.pictureBoxCadImgProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxCadImgProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCadImgProfile.Location = new System.Drawing.Point(33, 31);
            this.pictureBoxCadImgProfile.Name = "pictureBoxCadImgProfile";
            this.pictureBoxCadImgProfile.Size = new System.Drawing.Size(171, 160);
            this.pictureBoxCadImgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCadImgProfile.TabIndex = 19;
            this.pictureBoxCadImgProfile.TabStop = false;
            // 
            // labelCadNomeCompleto
            // 
            labelCadNomeCompleto.AutoSize = true;
            labelCadNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNomeCompleto.Location = new System.Drawing.Point(227, 27);
            labelCadNomeCompleto.Name = "labelCadNomeCompleto";
            labelCadNomeCompleto.Size = new System.Drawing.Size(160, 24);
            labelCadNomeCompleto.TabIndex = 14;
            labelCadNomeCompleto.Text = "Nome Completo *";
            // 
            // textBoxCadNomeCompleto
            // 
            this.textBoxCadNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomeCompleto.Location = new System.Drawing.Point(231, 54);
            this.textBoxCadNomeCompleto.Name = "textBoxCadNomeCompleto";
            this.textBoxCadNomeCompleto.ReadOnly = true;
            this.textBoxCadNomeCompleto.Size = new System.Drawing.Size(630, 29);
            this.textBoxCadNomeCompleto.TabIndex = 13;
            // 
            // panelCadDadosProfisionais
            // 
            this.panelCadDadosProfisionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelCadDadosProfisionais.Controls.Add(this.labelCadEspecialidade);
            this.panelCadDadosProfisionais.Controls.Add(this.textBoxCadEspecialidade);
            this.panelCadDadosProfisionais.Controls.Add(this.comboBoxCadUFdeRegistro);
            this.panelCadDadosProfisionais.Controls.Add(this.labelCadUFdeRegistro);
            this.panelCadDadosProfisionais.Controls.Add(this.comboBoxCadConselhoRegistro);
            this.panelCadDadosProfisionais.Controls.Add(this.labelCadNdeRegistro);
            this.panelCadDadosProfisionais.Controls.Add(this.textBoxCadNdeRegistro);
            this.panelCadDadosProfisionais.Controls.Add(this.labelCadTipoTratamento);
            this.panelCadDadosProfisionais.Controls.Add(this.comboBoxCadTipoTratamento);
            this.panelCadDadosProfisionais.Controls.Add(this.labelCadConselhoRegistro);
            this.panelCadDadosProfisionais.Location = new System.Drawing.Point(900, 0);
            this.panelCadDadosProfisionais.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadDadosProfisionais.Name = "panelCadDadosProfisionais";
            this.panelCadDadosProfisionais.Size = new System.Drawing.Size(900, 373);
            this.panelCadDadosProfisionais.TabIndex = 1;
            this.panelCadDadosProfisionais.Visible = false;
            this.panelCadDadosProfisionais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadDadosProfisionais_Paint);
            // 
            // labelCadEspecialidade
            // 
            this.labelCadEspecialidade.AutoSize = true;
            this.labelCadEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCadEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelCadEspecialidade.Location = new System.Drawing.Point(30, 189);
            this.labelCadEspecialidade.Name = "labelCadEspecialidade";
            this.labelCadEspecialidade.Size = new System.Drawing.Size(141, 24);
            this.labelCadEspecialidade.TabIndex = 37;
            this.labelCadEspecialidade.Text = "Especialidade *";
            // 
            // textBoxCadEspecialidade
            // 
            this.textBoxCadEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadEspecialidade.Location = new System.Drawing.Point(34, 215);
            this.textBoxCadEspecialidade.Name = "textBoxCadEspecialidade";
            this.textBoxCadEspecialidade.Size = new System.Drawing.Size(775, 29);
            this.textBoxCadEspecialidade.TabIndex = 23;
            // 
            // comboBoxCadUFdeRegistro
            // 
            this.comboBoxCadUFdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxCadUFdeRegistro.FormattingEnabled = true;
            this.comboBoxCadUFdeRegistro.Items.AddRange(new object[] {
            "ACRE",
            "ALAGOAS",
            "AMAPA",
            "AMAZONAS",
            "BAHIA",
            "CEARA",
            "DISTRITO FEDERAL",
            "ESPIRITO SANTO",
            "GOIAS",
            "MARANHAO",
            "MATO GROSSO",
            "MATO GROSSO DO SUL",
            "MINAS GERAIS",
            "PARA",
            "PARAIBA",
            "PARANA",
            "PERNAMBUCO",
            "PIAUI",
            "RIO DE JANEIRO",
            "RIO GRANDE DO NORTE",
            "RIO GRANDE DO SUL",
            "RONDONIA",
            "RORAIMA",
            "SANTA CATARINA",
            "SAO PAULO",
            "SERGIPE",
            "TOCANTINS"});
            this.comboBoxCadUFdeRegistro.Location = new System.Drawing.Point(559, 138);
            this.comboBoxCadUFdeRegistro.Name = "comboBoxCadUFdeRegistro";
            this.comboBoxCadUFdeRegistro.Size = new System.Drawing.Size(250, 28);
            this.comboBoxCadUFdeRegistro.TabIndex = 22;
            // 
            // labelCadUFdeRegistro
            // 
            this.labelCadUFdeRegistro.AutoSize = true;
            this.labelCadUFdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCadUFdeRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelCadUFdeRegistro.Location = new System.Drawing.Point(555, 111);
            this.labelCadUFdeRegistro.Name = "labelCadUFdeRegistro";
            this.labelCadUFdeRegistro.Size = new System.Drawing.Size(148, 24);
            this.labelCadUFdeRegistro.TabIndex = 34;
            this.labelCadUFdeRegistro.Text = "UF de Registro *";
            // 
            // comboBoxCadConselhoRegistro
            // 
            this.comboBoxCadConselhoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxCadConselhoRegistro.FormattingEnabled = true;
            this.comboBoxCadConselhoRegistro.Items.AddRange(new object[] {
            "CBOO",
            "CONAHOM",
            "CRAS",
            "CRBM",
            "CREFITO",
            "COREN",
            "CREF",
            "CRF",
            "CRFA",
            "CRM",
            "CRN",
            "CRO",
            "CRP",
            "CRT",
            "CRNT"});
            this.comboBoxCadConselhoRegistro.Location = new System.Drawing.Point(34, 136);
            this.comboBoxCadConselhoRegistro.Name = "comboBoxCadConselhoRegistro";
            this.comboBoxCadConselhoRegistro.Size = new System.Drawing.Size(250, 28);
            this.comboBoxCadConselhoRegistro.TabIndex = 20;
            // 
            // labelCadNdeRegistro
            // 
            this.labelCadNdeRegistro.AutoSize = true;
            this.labelCadNdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCadNdeRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelCadNdeRegistro.Location = new System.Drawing.Point(292, 110);
            this.labelCadNdeRegistro.Name = "labelCadNdeRegistro";
            this.labelCadNdeRegistro.Size = new System.Drawing.Size(144, 24);
            this.labelCadNdeRegistro.TabIndex = 32;
            this.labelCadNdeRegistro.Text = "Nº de Registro *";
            // 
            // textBoxCadNdeRegistro
            // 
            this.textBoxCadNdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNdeRegistro.Location = new System.Drawing.Point(296, 137);
            this.textBoxCadNdeRegistro.Name = "textBoxCadNdeRegistro";
            this.textBoxCadNdeRegistro.Size = new System.Drawing.Size(250, 29);
            this.textBoxCadNdeRegistro.TabIndex = 21;
            // 
            // labelCadTipoTratamento
            // 
            this.labelCadTipoTratamento.AutoSize = true;
            this.labelCadTipoTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCadTipoTratamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelCadTipoTratamento.Location = new System.Drawing.Point(30, 30);
            this.labelCadTipoTratamento.Name = "labelCadTipoTratamento";
            this.labelCadTipoTratamento.Size = new System.Drawing.Size(187, 24);
            this.labelCadTipoTratamento.TabIndex = 30;
            this.labelCadTipoTratamento.Text = "Tipo de Tratamento *";
            // 
            // comboBoxCadTipoTratamento
            // 
            this.comboBoxCadTipoTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxCadTipoTratamento.FormattingEnabled = true;
            this.comboBoxCadTipoTratamento.Items.AddRange(new object[] {
            "Nenhum",
            "Dr. ",
            "Dra. ",
            "Sr. ",
            "Sra. "});
            this.comboBoxCadTipoTratamento.Location = new System.Drawing.Point(34, 57);
            this.comboBoxCadTipoTratamento.Name = "comboBoxCadTipoTratamento";
            this.comboBoxCadTipoTratamento.Size = new System.Drawing.Size(250, 28);
            this.comboBoxCadTipoTratamento.TabIndex = 19;
            // 
            // labelCadConselhoRegistro
            // 
            this.labelCadConselhoRegistro.AutoSize = true;
            this.labelCadConselhoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCadConselhoRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelCadConselhoRegistro.Location = new System.Drawing.Point(30, 109);
            this.labelCadConselhoRegistro.Name = "labelCadConselhoRegistro";
            this.labelCadConselhoRegistro.Size = new System.Drawing.Size(204, 24);
            this.labelCadConselhoRegistro.TabIndex = 24;
            this.labelCadConselhoRegistro.Text = "Conselho de Registro *";
            // 
            // labelSelecioneProduto
            // 
            labelSelecioneProduto.AutoSize = true;
            labelSelecioneProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            labelSelecioneProduto.ForeColor = System.Drawing.SystemColors.Control;
            labelSelecioneProduto.Location = new System.Drawing.Point(22, 7);
            labelSelecioneProduto.Name = "labelSelecioneProduto";
            labelSelecioneProduto.Size = new System.Drawing.Size(513, 22);
            labelSelecioneProduto.TabIndex = 48;
            labelSelecioneProduto.Text = "Selecione um nome para Editar, Vizualizar ou Excluir Cadastro:";
            labelSelecioneProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaSelecione
            // 
            labelLinhaSelecione.AutoSize = true;
            labelLinhaSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaSelecione.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaSelecione.Location = new System.Drawing.Point(22, 10);
            labelLinhaSelecione.Name = "labelLinhaSelecione";
            labelLinhaSelecione.Size = new System.Drawing.Size(860, 24);
            labelLinhaSelecione.TabIndex = 49;
            labelLinhaSelecione.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // labelCadNovoCadastro
            // 
            labelCadNovoCadastro.AutoSize = true;
            labelCadNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelCadNovoCadastro.Location = new System.Drawing.Point(24, 5);
            labelCadNovoCadastro.Name = "labelCadNovoCadastro";
            labelCadNovoCadastro.Size = new System.Drawing.Size(134, 24);
            labelCadNovoCadastro.TabIndex = 35;
            labelCadNovoCadastro.Text = "Novo Cadastro";
            labelCadNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdLinhaEditarCadastro
            // 
            labelUpdLinhaEditarCadastro.AutoSize = true;
            labelUpdLinhaEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdLinhaEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdLinhaEditarCadastro.Location = new System.Drawing.Point(24, 10);
            labelUpdLinhaEditarCadastro.Name = "labelUpdLinhaEditarCadastro";
            labelUpdLinhaEditarCadastro.Size = new System.Drawing.Size(830, 24);
            labelUpdLinhaEditarCadastro.TabIndex = 36;
            labelUpdLinhaEditarCadastro.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // labelUpdNomeCompleto
            // 
            labelUpdNomeCompleto.AutoSize = true;
            labelUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNomeCompleto.Location = new System.Drawing.Point(227, 27);
            labelUpdNomeCompleto.Name = "labelUpdNomeCompleto";
            labelUpdNomeCompleto.Size = new System.Drawing.Size(160, 24);
            labelUpdNomeCompleto.TabIndex = 14;
            labelUpdNomeCompleto.Text = "Nome Completo *";
            // 
            // labelUpdUpd
            // 
            labelUpdUpd.AutoSize = true;
            labelUpdUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdUpd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdUpd.Location = new System.Drawing.Point(622, 106);
            labelUpdUpd.Name = "labelUpdUpd";
            labelUpdUpd.Size = new System.Drawing.Size(97, 24);
            labelUpdUpd.TabIndex = 21;
            labelUpdUpd.Text = "Telefone *";
            // 
            // labelUpdEmail
            // 
            labelUpdEmail.AutoSize = true;
            labelUpdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdEmail.Location = new System.Drawing.Point(227, 188);
            labelUpdEmail.Name = "labelUpdEmail";
            labelUpdEmail.Size = new System.Drawing.Size(75, 24);
            labelUpdEmail.TabIndex = 23;
            labelUpdEmail.Text = "E-mail *";
            // 
            // labelUpdSexo
            // 
            labelUpdSexo.AutoSize = true;
            labelUpdSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdSexo.Location = new System.Drawing.Point(227, 105);
            labelUpdSexo.Name = "labelUpdSexo";
            labelUpdSexo.Size = new System.Drawing.Size(66, 24);
            labelUpdSexo.TabIndex = 32;
            labelUpdSexo.Text = "Sexo *";
            // 
            // labelUpdCpf
            // 
            labelUpdCpf.AutoSize = true;
            labelUpdCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdCpf.Location = new System.Drawing.Point(414, 106);
            labelUpdCpf.Name = "labelUpdCpf";
            labelUpdCpf.Size = new System.Drawing.Size(59, 24);
            labelUpdCpf.TabIndex = 33;
            labelUpdCpf.Text = "CPF *";
            // 
            // flowLayoutPanelUpdEditarCadastro
            // 
            flowLayoutPanelUpdEditarCadastro.AutoScroll = true;
            flowLayoutPanelUpdEditarCadastro.Controls.Add(this.panelUpdDadosPessoais);
            flowLayoutPanelUpdEditarCadastro.Controls.Add(this.panelUpdDadosProfissionais);
            flowLayoutPanelUpdEditarCadastro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelUpdEditarCadastro.Location = new System.Drawing.Point(0, 82);
            flowLayoutPanelUpdEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanelUpdEditarCadastro.Name = "flowLayoutPanelUpdEditarCadastro";
            flowLayoutPanelUpdEditarCadastro.Size = new System.Drawing.Size(900, 373);
            flowLayoutPanelUpdEditarCadastro.TabIndex = 56;
            // 
            // panelUpdDadosPessoais
            // 
            this.panelUpdDadosPessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelUpdDadosPessoais.Controls.Add(this.linkLabelUpdExcluirImg);
            this.panelUpdDadosPessoais.Controls.Add(this.maskUpdTelefone);
            this.panelUpdDadosPessoais.Controls.Add(this.maskUpdCpf);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdCpf);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdSexo);
            this.panelUpdDadosPessoais.Controls.Add(this.comboBoxUpdSexo);
            this.panelUpdDadosPessoais.Controls.Add(this.textBoxUpdEmail);
            this.panelUpdDadosPessoais.Controls.Add(this.linkLabelUpdImportImg);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdEmail);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdUpd);
            this.panelUpdDadosPessoais.Controls.Add(this.pictureBoxUpdImgProfile);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdNomeCompleto);
            this.panelUpdDadosPessoais.Controls.Add(this.textBoxUpdNomeCompleto);
            this.panelUpdDadosPessoais.Location = new System.Drawing.Point(0, 0);
            this.panelUpdDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdDadosPessoais.Name = "panelUpdDadosPessoais";
            this.panelUpdDadosPessoais.Size = new System.Drawing.Size(900, 373);
            this.panelUpdDadosPessoais.TabIndex = 0;
            this.panelUpdDadosPessoais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdDadosPessoais_Paint);
            // 
            // linkLabelUpdExcluirImg
            // 
            this.linkLabelUpdExcluirImg.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelUpdExcluirImg.AutoSize = true;
            this.linkLabelUpdExcluirImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelUpdExcluirImg.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabelUpdExcluirImg.Location = new System.Drawing.Point(156, 195);
            this.linkLabelUpdExcluirImg.Name = "linkLabelUpdExcluirImg";
            this.linkLabelUpdExcluirImg.Size = new System.Drawing.Size(49, 17);
            this.linkLabelUpdExcluirImg.TabIndex = 37;
            this.linkLabelUpdExcluirImg.TabStop = true;
            this.linkLabelUpdExcluirImg.Text = "Excluir";
            this.linkLabelUpdExcluirImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdExcluirImg_LinkClicked);
            // 
            // maskUpdTelefone
            // 
            this.maskUpdTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "telefone", true));
            this.maskUpdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdTelefone.Location = new System.Drawing.Point(626, 133);
            this.maskUpdTelefone.Mask = "(00) 0 0000-0000";
            this.maskUpdTelefone.Name = "maskUpdTelefone";
            this.maskUpdTelefone.Size = new System.Drawing.Size(235, 29);
            this.maskUpdTelefone.TabIndex = 27;
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
            // maskUpdCpf
            // 
            this.maskUpdCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "cpf", true));
            this.maskUpdCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdCpf.Location = new System.Drawing.Point(418, 132);
            this.maskUpdCpf.Mask = "000.000.000-00";
            this.maskUpdCpf.Name = "maskUpdCpf";
            this.maskUpdCpf.Size = new System.Drawing.Size(195, 29);
            this.maskUpdCpf.TabIndex = 26;
            // 
            // comboBoxUpdSexo
            // 
            this.comboBoxUpdSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "sexo", true));
            this.comboBoxUpdSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxUpdSexo.FormattingEnabled = true;
            this.comboBoxUpdSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.comboBoxUpdSexo.Location = new System.Drawing.Point(231, 133);
            this.comboBoxUpdSexo.Name = "comboBoxUpdSexo";
            this.comboBoxUpdSexo.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUpdSexo.TabIndex = 25;
            // 
            // textBoxUpdEmail
            // 
            this.textBoxUpdEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "email", true));
            this.textBoxUpdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdEmail.Location = new System.Drawing.Point(231, 215);
            this.textBoxUpdEmail.Name = "textBoxUpdEmail";
            this.textBoxUpdEmail.Size = new System.Drawing.Size(630, 29);
            this.textBoxUpdEmail.TabIndex = 28;
            // 
            // linkLabelUpdImportImg
            // 
            this.linkLabelUpdImportImg.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabelUpdImportImg.AutoSize = true;
            this.linkLabelUpdImportImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelUpdImportImg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.linkLabelUpdImportImg.Location = new System.Drawing.Point(30, 194);
            this.linkLabelUpdImportImg.Name = "linkLabelUpdImportImg";
            this.linkLabelUpdImportImg.Size = new System.Drawing.Size(113, 17);
            this.linkLabelUpdImportImg.TabIndex = 28;
            this.linkLabelUpdImportImg.TabStop = true;
            this.linkLabelUpdImportImg.Text = "Importar Imagem";
            this.linkLabelUpdImportImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdImportImg_LinkClicked);
            // 
            // pictureBoxUpdImgProfile
            // 
            this.pictureBoxUpdImgProfile.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxUpdImgProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUpdImgProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.colaboradorBindingSource, "imagemPerfil", true));
            this.pictureBoxUpdImgProfile.Location = new System.Drawing.Point(33, 31);
            this.pictureBoxUpdImgProfile.Name = "pictureBoxUpdImgProfile";
            this.pictureBoxUpdImgProfile.Size = new System.Drawing.Size(171, 160);
            this.pictureBoxUpdImgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUpdImgProfile.TabIndex = 19;
            this.pictureBoxUpdImgProfile.TabStop = false;
            // 
            // textBoxUpdNomeCompleto
            // 
            this.textBoxUpdNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "nomeColaborador", true));
            this.textBoxUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNomeCompleto.Location = new System.Drawing.Point(231, 54);
            this.textBoxUpdNomeCompleto.Name = "textBoxUpdNomeCompleto";
            this.textBoxUpdNomeCompleto.Size = new System.Drawing.Size(630, 29);
            this.textBoxUpdNomeCompleto.TabIndex = 24;
            // 
            // panelUpdDadosProfissionais
            // 
            this.panelUpdDadosProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelUpdDadosProfissionais.Controls.Add(this.labelUpdEspecialidade);
            this.panelUpdDadosProfissionais.Controls.Add(this.textBoxUpdEspecialidade);
            this.panelUpdDadosProfissionais.Controls.Add(this.comboBoxUpdUFdeRegistro);
            this.panelUpdDadosProfissionais.Controls.Add(this.labelUpdUFdeRegistro);
            this.panelUpdDadosProfissionais.Controls.Add(this.comboBoxUpdConselhoRegistro);
            this.panelUpdDadosProfissionais.Controls.Add(this.labelUpdNdeRegistro);
            this.panelUpdDadosProfissionais.Controls.Add(this.textBoxUpdNdeRegistro);
            this.panelUpdDadosProfissionais.Controls.Add(this.labelUpdTipoTratamento);
            this.panelUpdDadosProfissionais.Controls.Add(this.comboBoxUpdTipoTratamento);
            this.panelUpdDadosProfissionais.Controls.Add(this.labelUpdConselhoRegistro);
            this.panelUpdDadosProfissionais.Location = new System.Drawing.Point(900, 0);
            this.panelUpdDadosProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdDadosProfissionais.Name = "panelUpdDadosProfissionais";
            this.panelUpdDadosProfissionais.Size = new System.Drawing.Size(900, 373);
            this.panelUpdDadosProfissionais.TabIndex = 1;
            this.panelUpdDadosProfissionais.Visible = false;
            this.panelUpdDadosProfissionais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdDadosProfissionais_Paint);
            // 
            // labelUpdEspecialidade
            // 
            this.labelUpdEspecialidade.AutoSize = true;
            this.labelUpdEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdEspecialidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelUpdEspecialidade.Location = new System.Drawing.Point(30, 189);
            this.labelUpdEspecialidade.Name = "labelUpdEspecialidade";
            this.labelUpdEspecialidade.Size = new System.Drawing.Size(141, 24);
            this.labelUpdEspecialidade.TabIndex = 37;
            this.labelUpdEspecialidade.Text = "Especialidade *";
            // 
            // textBoxUpdEspecialidade
            // 
            this.textBoxUpdEspecialidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "especialidade", true));
            this.textBoxUpdEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdEspecialidade.Location = new System.Drawing.Point(34, 215);
            this.textBoxUpdEspecialidade.Name = "textBoxUpdEspecialidade";
            this.textBoxUpdEspecialidade.Size = new System.Drawing.Size(775, 29);
            this.textBoxUpdEspecialidade.TabIndex = 34;
            // 
            // comboBoxUpdUFdeRegistro
            // 
            this.comboBoxUpdUFdeRegistro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "ufRegistro", true));
            this.comboBoxUpdUFdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxUpdUFdeRegistro.FormattingEnabled = true;
            this.comboBoxUpdUFdeRegistro.Items.AddRange(new object[] {
            "ACRE",
            "ALAGOAS",
            "AMAPA",
            "AMAZONAS",
            "BAHIA",
            "CEARA",
            "DISTRITO FEDERAL",
            "ESPIRITO SANTO",
            "GOIAS",
            "MARANHAO",
            "MATO GROSSO",
            "MATO GROSSO DO SUL",
            "MINAS GERAIS",
            "PARA",
            "PARAIBA",
            "PARANA",
            "PERNAMBUCO",
            "PIAUI",
            "RIO DE JANEIRO",
            "RIO GRANDE DO NORTE",
            "RIO GRANDE DO SUL",
            "RONDONIA",
            "RORAIMA",
            "SANTA CATARINA",
            "SAO PAULO",
            "SERGIPE",
            "TOCANTINS"});
            this.comboBoxUpdUFdeRegistro.Location = new System.Drawing.Point(559, 138);
            this.comboBoxUpdUFdeRegistro.Name = "comboBoxUpdUFdeRegistro";
            this.comboBoxUpdUFdeRegistro.Size = new System.Drawing.Size(250, 28);
            this.comboBoxUpdUFdeRegistro.TabIndex = 33;
            // 
            // labelUpdUFdeRegistro
            // 
            this.labelUpdUFdeRegistro.AutoSize = true;
            this.labelUpdUFdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdUFdeRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelUpdUFdeRegistro.Location = new System.Drawing.Point(555, 111);
            this.labelUpdUFdeRegistro.Name = "labelUpdUFdeRegistro";
            this.labelUpdUFdeRegistro.Size = new System.Drawing.Size(148, 24);
            this.labelUpdUFdeRegistro.TabIndex = 34;
            this.labelUpdUFdeRegistro.Text = "UF de Registro *";
            // 
            // comboBoxUpdConselhoRegistro
            // 
            this.comboBoxUpdConselhoRegistro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "conselhoRegistro", true));
            this.comboBoxUpdConselhoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxUpdConselhoRegistro.FormattingEnabled = true;
            this.comboBoxUpdConselhoRegistro.Items.AddRange(new object[] {
            "CBOO",
            "CONAHOM",
            "CRAS",
            "CRBM",
            "CREFITO",
            "COREN",
            "CREF",
            "CRF",
            "CRFA",
            "CRM",
            "CRN",
            "CRO",
            "CRP",
            "CRT",
            "CRNT"});
            this.comboBoxUpdConselhoRegistro.Location = new System.Drawing.Point(34, 136);
            this.comboBoxUpdConselhoRegistro.Name = "comboBoxUpdConselhoRegistro";
            this.comboBoxUpdConselhoRegistro.Size = new System.Drawing.Size(250, 28);
            this.comboBoxUpdConselhoRegistro.TabIndex = 31;
            // 
            // labelUpdNdeRegistro
            // 
            this.labelUpdNdeRegistro.AutoSize = true;
            this.labelUpdNdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdNdeRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelUpdNdeRegistro.Location = new System.Drawing.Point(292, 110);
            this.labelUpdNdeRegistro.Name = "labelUpdNdeRegistro";
            this.labelUpdNdeRegistro.Size = new System.Drawing.Size(144, 24);
            this.labelUpdNdeRegistro.TabIndex = 32;
            this.labelUpdNdeRegistro.Text = "Nº de Registro *";
            // 
            // textBoxUpdNdeRegistro
            // 
            this.textBoxUpdNdeRegistro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "numeroRegistro", true));
            this.textBoxUpdNdeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNdeRegistro.Location = new System.Drawing.Point(296, 137);
            this.textBoxUpdNdeRegistro.Name = "textBoxUpdNdeRegistro";
            this.textBoxUpdNdeRegistro.Size = new System.Drawing.Size(250, 29);
            this.textBoxUpdNdeRegistro.TabIndex = 32;
            // 
            // labelUpdTipoTratamento
            // 
            this.labelUpdTipoTratamento.AutoSize = true;
            this.labelUpdTipoTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdTipoTratamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelUpdTipoTratamento.Location = new System.Drawing.Point(30, 27);
            this.labelUpdTipoTratamento.Name = "labelUpdTipoTratamento";
            this.labelUpdTipoTratamento.Size = new System.Drawing.Size(187, 24);
            this.labelUpdTipoTratamento.TabIndex = 30;
            this.labelUpdTipoTratamento.Text = "Tipo de Tratamento *";
            // 
            // comboBoxUpdTipoTratamento
            // 
            this.comboBoxUpdTipoTratamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "formaTratamento", true));
            this.comboBoxUpdTipoTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxUpdTipoTratamento.FormattingEnabled = true;
            this.comboBoxUpdTipoTratamento.Items.AddRange(new object[] {
            "Nenhum",
            "Dr. ",
            "Dra. ",
            "Sr. ",
            "Sra. "});
            this.comboBoxUpdTipoTratamento.Location = new System.Drawing.Point(34, 54);
            this.comboBoxUpdTipoTratamento.Name = "comboBoxUpdTipoTratamento";
            this.comboBoxUpdTipoTratamento.Size = new System.Drawing.Size(250, 28);
            this.comboBoxUpdTipoTratamento.TabIndex = 30;
            // 
            // labelUpdConselhoRegistro
            // 
            this.labelUpdConselhoRegistro.AutoSize = true;
            this.labelUpdConselhoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdConselhoRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelUpdConselhoRegistro.Location = new System.Drawing.Point(30, 109);
            this.labelUpdConselhoRegistro.Name = "labelUpdConselhoRegistro";
            this.labelUpdConselhoRegistro.Size = new System.Drawing.Size(204, 24);
            this.labelUpdConselhoRegistro.TabIndex = 24;
            this.labelUpdConselhoRegistro.Text = "Conselho de Registro *";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.labelContagem);
            this.panelMenu.Controls.Add(this.btnPesquisar);
            this.panelMenu.Controls.Add(labelPesquisarNome);
            this.panelMenu.Controls.Add(this.textPesquisarNome);
            this.panelMenu.Controls.Add(this.btnVizualizarCadastro);
            this.panelMenu.Controls.Add(this.btnEditarCadastro);
            this.panelMenu.Controls.Add(labelTitulo);
            this.panelMenu.Controls.Add(this.btnExcluirCadastro);
            this.panelMenu.Controls.Add(labelLinhaTitulo);
            this.panelMenu.Controls.Add(this.btnNovoCadastro);
            this.panelMenu.Location = new System.Drawing.Point(8, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(900, 155);
            this.panelMenu.TabIndex = 39;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // labelContagem
            // 
            this.labelContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelContagem.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContagem.Location = new System.Drawing.Point(568, 8);
            this.labelContagem.Name = "labelContagem";
            this.labelContagem.Size = new System.Drawing.Size(307, 24);
            this.labelContagem.TabIndex = 54;
            this.labelContagem.Text = "Total: N Registros";
            this.labelContagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // textPesquisarNome
            // 
            this.textPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textPesquisarNome.Location = new System.Drawing.Point(35, 64);
            this.textPesquisarNome.Margin = new System.Windows.Forms.Padding(0);
            this.textPesquisarNome.Name = "textPesquisarNome";
            this.textPesquisarNome.Size = new System.Drawing.Size(573, 27);
            this.textPesquisarNome.TabIndex = 46;
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
            this.btnExcluirCadastro.Text = "Desativar Cadastro";
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
            // panelCadOpcoesCadBottom
            // 
            this.panelCadOpcoesCadBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelCadOpcoesCadBottom.Controls.Add(this.btnCadSalvar);
            this.panelCadOpcoesCadBottom.Controls.Add(this.btnCadSair);
            this.panelCadOpcoesCadBottom.Location = new System.Drawing.Point(1, 468);
            this.panelCadOpcoesCadBottom.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelCadOpcoesCadBottom.Name = "panelCadOpcoesCadBottom";
            this.panelCadOpcoesCadBottom.Size = new System.Drawing.Size(900, 50);
            this.panelCadOpcoesCadBottom.TabIndex = 54;
            this.panelCadOpcoesCadBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadOpcoesCadBottom_Paint);
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnCadSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadSalvar.Image")));
            this.btnCadSalvar.Location = new System.Drawing.Point(276, 7);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(154, 35);
            this.btnCadSalvar.TabIndex = 39;
            this.btnCadSalvar.Text = "Salvar";
            this.btnCadSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadSalvar.UseVisualStyleBackColor = false;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // btnCadSair
            // 
            this.btnCadSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnCadSair.FlatAppearance.BorderSize = 0;
            this.btnCadSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadSair.Image = ((System.Drawing.Image)(resources.GetObject("btnCadSair.Image")));
            this.btnCadSair.Location = new System.Drawing.Point(436, 7);
            this.btnCadSair.Name = "btnCadSair";
            this.btnCadSair.Size = new System.Drawing.Size(154, 35);
            this.btnCadSair.TabIndex = 40;
            this.btnCadSair.Text = " Sair";
            this.btnCadSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadSair.UseVisualStyleBackColor = false;
            this.btnCadSair.Click += new System.EventHandler(this.btnCadSair_Click);
            // 
            // panelCadTitulo
            // 
            this.panelCadTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelCadTitulo.Controls.Add(labelCadNovoCadastro);
            this.panelCadTitulo.Controls.Add(labelCadLinhaNovoCadastro);
            this.panelCadTitulo.Location = new System.Drawing.Point(1, 0);
            this.panelCadTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadTitulo.Name = "panelCadTitulo";
            this.panelCadTitulo.Size = new System.Drawing.Size(900, 36);
            this.panelCadTitulo.TabIndex = 51;
            this.panelCadTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadTitulo_Paint);
            // 
            // panelUpdOpcoesCadBottom
            // 
            this.panelUpdOpcoesCadBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelUpdOpcoesCadBottom.Controls.Add(this.btnUpdSalvar);
            this.panelUpdOpcoesCadBottom.Controls.Add(this.btnUpdSair);
            this.panelUpdOpcoesCadBottom.Location = new System.Drawing.Point(0, 468);
            this.panelUpdOpcoesCadBottom.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelUpdOpcoesCadBottom.Name = "panelUpdOpcoesCadBottom";
            this.panelUpdOpcoesCadBottom.Size = new System.Drawing.Size(900, 50);
            this.panelUpdOpcoesCadBottom.TabIndex = 57;
            this.panelUpdOpcoesCadBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdOpcoesCadBottom_Paint);
            // 
            // btnUpdSalvar
            // 
            this.btnUpdSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnUpdSalvar.FlatAppearance.BorderSize = 0;
            this.btnUpdSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdSalvar.Image")));
            this.btnUpdSalvar.Location = new System.Drawing.Point(276, 7);
            this.btnUpdSalvar.Name = "btnUpdSalvar";
            this.btnUpdSalvar.Size = new System.Drawing.Size(154, 35);
            this.btnUpdSalvar.TabIndex = 39;
            this.btnUpdSalvar.Text = "Salvar";
            this.btnUpdSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdSalvar.UseVisualStyleBackColor = false;
            this.btnUpdSalvar.Click += new System.EventHandler(this.btnUpdSalvar_Click);
            // 
            // btnUpdSair
            // 
            this.btnUpdSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnUpdSair.FlatAppearance.BorderSize = 0;
            this.btnUpdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdSair.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdSair.Image")));
            this.btnUpdSair.Location = new System.Drawing.Point(436, 7);
            this.btnUpdSair.Name = "btnUpdSair";
            this.btnUpdSair.Size = new System.Drawing.Size(154, 35);
            this.btnUpdSair.TabIndex = 40;
            this.btnUpdSair.Text = " Sair";
            this.btnUpdSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdSair.UseVisualStyleBackColor = false;
            this.btnUpdSair.Click += new System.EventHandler(this.btnUpdSair_Click);
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // flpContainerPai
            // 
            this.flpContainerPai.AutoScroll = true;
            this.flpContainerPai.Controls.Add(this.panelConsultarProfissional);
            this.flpContainerPai.Controls.Add(this.panelNovoCadastro);
            this.flpContainerPai.Controls.Add(this.panelEditarCadastro);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(8, 174);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(900, 520);
            this.flpContainerPai.TabIndex = 40;
            this.flpContainerPai.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContainerPai_Paint);
            // 
            // panelConsultarProfissional
            // 
            this.panelConsultarProfissional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarProfissional.Controls.Add(labelSelecioneProduto);
            this.panelConsultarProfissional.Controls.Add(labelLinhaSelecione);
            this.panelConsultarProfissional.Controls.Add(this.dataGridViewProfissional);
            this.panelConsultarProfissional.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarProfissional.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarProfissional.Name = "panelConsultarProfissional";
            this.panelConsultarProfissional.Size = new System.Drawing.Size(900, 520);
            this.panelConsultarProfissional.TabIndex = 38;
            this.panelConsultarProfissional.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultarProfissional_Paint);
            // 
            // dataGridViewProfissional
            // 
            this.dataGridViewProfissional.AllowUserToAddRows = false;
            this.dataGridViewProfissional.AllowUserToDeleteRows = false;
            this.dataGridViewProfissional.AllowUserToResizeColumns = false;
            this.dataGridViewProfissional.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewProfissional.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfissional.AutoGenerateColumns = false;
            this.dataGridViewProfissional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewProfissional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProfissional.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfissional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfissional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfissional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColaboradorDataGridViewTextBoxColumn,
            this.nomeProfissionalDataGridViewTextBoxColumn,
            this.nomeColaboradorDataGridViewTextBoxColumn,
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
            this.codigoLogDataGridViewTextBoxColumn,
            this.usuario,
            this.senha,
            this.idPerfil,
            this.statusCadastro});
            this.dataGridViewProfissional.DataSource = this.colaboradorBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfissional.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProfissional.EnableHeadersVisualStyles = false;
            this.dataGridViewProfissional.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewProfissional.Location = new System.Drawing.Point(26, 37);
            this.dataGridViewProfissional.MultiSelect = false;
            this.dataGridViewProfissional.Name = "dataGridViewProfissional";
            this.dataGridViewProfissional.ReadOnly = true;
            this.dataGridViewProfissional.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfissional.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProfissional.RowHeadersVisible = false;
            this.dataGridViewProfissional.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewProfissional.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProfissional.RowTemplate.Height = 30;
            this.dataGridViewProfissional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProfissional.Size = new System.Drawing.Size(851, 418);
            this.dataGridViewProfissional.TabIndex = 44;
            // 
            // idColaboradorDataGridViewTextBoxColumn
            // 
            this.idColaboradorDataGridViewTextBoxColumn.DataPropertyName = "idColaborador";
            this.idColaboradorDataGridViewTextBoxColumn.HeaderText = "idColaborador";
            this.idColaboradorDataGridViewTextBoxColumn.Name = "idColaboradorDataGridViewTextBoxColumn";
            this.idColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idColaboradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeProfissionalDataGridViewTextBoxColumn
            // 
            this.nomeProfissionalDataGridViewTextBoxColumn.DataPropertyName = "nomeProfissional";
            this.nomeProfissionalDataGridViewTextBoxColumn.HeaderText = "Nome Profissional";
            this.nomeProfissionalDataGridViewTextBoxColumn.Name = "nomeProfissionalDataGridViewTextBoxColumn";
            this.nomeProfissionalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProfissionalDataGridViewTextBoxColumn.Width = 550;
            // 
            // nomeColaboradorDataGridViewTextBoxColumn
            // 
            this.nomeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "nomeColaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.HeaderText = "nomeColaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.Name = "nomeColaboradorDataGridViewTextBoxColumn";
            this.nomeColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeColaboradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoColaboradorDataGridViewTextBoxColumn
            // 
            this.tipoColaboradorDataGridViewTextBoxColumn.DataPropertyName = "tipoColaborador";
            this.tipoColaboradorDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoColaboradorDataGridViewTextBoxColumn.Name = "tipoColaboradorDataGridViewTextBoxColumn";
            this.tipoColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoColaboradorDataGridViewTextBoxColumn.Width = 300;
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
            this.especialidadeDataGridViewTextBoxColumn.HeaderText = "Especialidade";
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
            // codigoLogDataGridViewTextBoxColumn
            // 
            this.codigoLogDataGridViewTextBoxColumn.DataPropertyName = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.HeaderText = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.Name = "codigoLogDataGridViewTextBoxColumn";
            this.codigoLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // idPerfil
            // 
            this.idPerfil.DataPropertyName = "idPerfil";
            this.idPerfil.HeaderText = "idPerfil";
            this.idPerfil.Name = "idPerfil";
            this.idPerfil.ReadOnly = true;
            this.idPerfil.Visible = false;
            // 
            // statusCadastro
            // 
            this.statusCadastro.DataPropertyName = "statusCadastro";
            this.statusCadastro.HeaderText = "statusCadastro";
            this.statusCadastro.Name = "statusCadastro";
            this.statusCadastro.ReadOnly = true;
            this.statusCadastro.Visible = false;
            // 
            // panelNovoCadastro
            // 
            this.panelNovoCadastro.Controls.Add(this.panelCadTitulo);
            this.panelNovoCadastro.Controls.Add(this.panelCadAbas);
            this.panelNovoCadastro.Controls.Add(flowLayoutPanelNovoCadastro);
            this.panelNovoCadastro.Controls.Add(this.panelCadOpcoesCadBottom);
            this.panelNovoCadastro.Location = new System.Drawing.Point(900, 0);
            this.panelNovoCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelNovoCadastro.Name = "panelNovoCadastro";
            this.panelNovoCadastro.Size = new System.Drawing.Size(900, 520);
            this.panelNovoCadastro.TabIndex = 39;
            this.panelNovoCadastro.Visible = false;
            // 
            // panelCadAbas
            // 
            this.panelCadAbas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelCadAbas.Controls.Add(this.btnCadDadosPessoais);
            this.panelCadAbas.Controls.Add(this.btnCadDadosProfissionais);
            this.panelCadAbas.Location = new System.Drawing.Point(1, 41);
            this.panelCadAbas.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelCadAbas.Name = "panelCadAbas";
            this.panelCadAbas.Size = new System.Drawing.Size(900, 43);
            this.panelCadAbas.TabIndex = 52;
            // 
            // btnCadDadosPessoais
            // 
            this.btnCadDadosPessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnCadDadosPessoais.FlatAppearance.BorderSize = 0;
            this.btnCadDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadDadosPessoais.Image = ((System.Drawing.Image)(resources.GetObject("btnCadDadosPessoais.Image")));
            this.btnCadDadosPessoais.Location = new System.Drawing.Point(0, 0);
            this.btnCadDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadDadosPessoais.Name = "btnCadDadosPessoais";
            this.btnCadDadosPessoais.Size = new System.Drawing.Size(162, 43);
            this.btnCadDadosPessoais.TabIndex = 0;
            this.btnCadDadosPessoais.Text = " Dados Pessoais";
            this.btnCadDadosPessoais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadDadosPessoais.UseVisualStyleBackColor = false;
            this.btnCadDadosPessoais.Click += new System.EventHandler(this.btnCadDadosPessoais_Click);
            // 
            // btnCadDadosProfissionais
            // 
            this.btnCadDadosProfissionais.FlatAppearance.BorderSize = 0;
            this.btnCadDadosProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDadosProfissionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadDadosProfissionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadDadosProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("btnCadDadosProfissionais.Image")));
            this.btnCadDadosProfissionais.Location = new System.Drawing.Point(162, 0);
            this.btnCadDadosProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadDadosProfissionais.Name = "btnCadDadosProfissionais";
            this.btnCadDadosProfissionais.Size = new System.Drawing.Size(189, 43);
            this.btnCadDadosProfissionais.TabIndex = 1;
            this.btnCadDadosProfissionais.Text = "  Dados Profissionais";
            this.btnCadDadosProfissionais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadDadosProfissionais.UseVisualStyleBackColor = true;
            this.btnCadDadosProfissionais.Visible = false;
            this.btnCadDadosProfissionais.Click += new System.EventHandler(this.btnCadDadosProfissionais_Click);
            // 
            // panelEditarCadastro
            // 
            this.panelEditarCadastro.Controls.Add(this.panelUpdOpcoesCadBottom);
            this.panelEditarCadastro.Controls.Add(this.panelUpdTituloEditarCadastro);
            this.panelEditarCadastro.Controls.Add(this.panelUpdAbas);
            this.panelEditarCadastro.Controls.Add(flowLayoutPanelUpdEditarCadastro);
            this.panelEditarCadastro.Location = new System.Drawing.Point(1800, 0);
            this.panelEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditarCadastro.Name = "panelEditarCadastro";
            this.panelEditarCadastro.Size = new System.Drawing.Size(900, 520);
            this.panelEditarCadastro.TabIndex = 40;
            this.panelEditarCadastro.Visible = false;
            // 
            // panelUpdTituloEditarCadastro
            // 
            this.panelUpdTituloEditarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelUpdTituloEditarCadastro.Controls.Add(this.labelUpdEditarCadastro);
            this.panelUpdTituloEditarCadastro.Controls.Add(labelUpdLinhaEditarCadastro);
            this.panelUpdTituloEditarCadastro.Location = new System.Drawing.Point(0, 0);
            this.panelUpdTituloEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdTituloEditarCadastro.Name = "panelUpdTituloEditarCadastro";
            this.panelUpdTituloEditarCadastro.Size = new System.Drawing.Size(900, 36);
            this.panelUpdTituloEditarCadastro.TabIndex = 54;
            this.panelUpdTituloEditarCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdTituloEditarCadastro_Paint);
            // 
            // labelUpdEditarCadastro
            // 
            this.labelUpdEditarCadastro.AutoSize = true;
            this.labelUpdEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUpdEditarCadastro.Location = new System.Drawing.Point(24, 5);
            this.labelUpdEditarCadastro.Name = "labelUpdEditarCadastro";
            this.labelUpdEditarCadastro.Size = new System.Drawing.Size(137, 24);
            this.labelUpdEditarCadastro.TabIndex = 35;
            this.labelUpdEditarCadastro.Text = "Editar Cadastro";
            this.labelUpdEditarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUpdAbas
            // 
            this.panelUpdAbas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelUpdAbas.Controls.Add(this.btnUpdDadosPessoais);
            this.panelUpdAbas.Controls.Add(this.btnUpdDadosProfissionais);
            this.panelUpdAbas.Location = new System.Drawing.Point(0, 41);
            this.panelUpdAbas.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelUpdAbas.Name = "panelUpdAbas";
            this.panelUpdAbas.Size = new System.Drawing.Size(900, 43);
            this.panelUpdAbas.TabIndex = 55;
            // 
            // btnUpdDadosPessoais
            // 
            this.btnUpdDadosPessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnUpdDadosPessoais.FlatAppearance.BorderSize = 0;
            this.btnUpdDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnUpdDadosPessoais.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdDadosPessoais.Image")));
            this.btnUpdDadosPessoais.Location = new System.Drawing.Point(0, 0);
            this.btnUpdDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdDadosPessoais.Name = "btnUpdDadosPessoais";
            this.btnUpdDadosPessoais.Size = new System.Drawing.Size(162, 43);
            this.btnUpdDadosPessoais.TabIndex = 0;
            this.btnUpdDadosPessoais.Text = " Dados Pessoais";
            this.btnUpdDadosPessoais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdDadosPessoais.UseVisualStyleBackColor = false;
            this.btnUpdDadosPessoais.Click += new System.EventHandler(this.btnUpdDadosPessoais_Click);
            // 
            // btnUpdDadosProfissionais
            // 
            this.btnUpdDadosProfissionais.FlatAppearance.BorderSize = 0;
            this.btnUpdDadosProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdDadosProfissionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdDadosProfissionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnUpdDadosProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdDadosProfissionais.Image")));
            this.btnUpdDadosProfissionais.Location = new System.Drawing.Point(162, 0);
            this.btnUpdDadosProfissionais.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdDadosProfissionais.Name = "btnUpdDadosProfissionais";
            this.btnUpdDadosProfissionais.Size = new System.Drawing.Size(189, 43);
            this.btnUpdDadosProfissionais.TabIndex = 1;
            this.btnUpdDadosProfissionais.Text = "  Dados Profissionais";
            this.btnUpdDadosProfissionais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdDadosProfissionais.UseVisualStyleBackColor = true;
            this.btnUpdDadosProfissionais.Visible = false;
            this.btnUpdDadosProfissionais.Click += new System.EventHandler(this.btnUpdDadosProfissionais_Click);
            // 
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // frmProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(914, 703);
            this.Controls.Add(this.flpContainerPai);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profissional";
            this.Load += new System.EventHandler(this.frmCadastrarProfissional_Load);
            flowLayoutPanelNovoCadastro.ResumeLayout(false);
            this.panelCadDadosPessoais.ResumeLayout(false);
            this.panelCadDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadImgProfile)).EndInit();
            this.panelCadDadosProfisionais.ResumeLayout(false);
            this.panelCadDadosProfisionais.PerformLayout();
            flowLayoutPanelUpdEditarCadastro.ResumeLayout(false);
            this.panelUpdDadosPessoais.ResumeLayout(false);
            this.panelUpdDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdImgProfile)).EndInit();
            this.panelUpdDadosProfissionais.ResumeLayout(false);
            this.panelUpdDadosProfissionais.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelCadOpcoesCadBottom.ResumeLayout(false);
            this.panelCadTitulo.ResumeLayout(false);
            this.panelCadTitulo.PerformLayout();
            this.panelUpdOpcoesCadBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.flpContainerPai.ResumeLayout(false);
            this.panelConsultarProfissional.ResumeLayout(false);
            this.panelConsultarProfissional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfissional)).EndInit();
            this.panelNovoCadastro.ResumeLayout(false);
            this.panelCadAbas.ResumeLayout(false);
            this.panelEditarCadastro.ResumeLayout(false);
            this.panelUpdTituloEditarCadastro.ResumeLayout(false);
            this.panelUpdTituloEditarCadastro.PerformLayout();
            this.panelUpdAbas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelConsultarProfissional;
        private System.Windows.Forms.DataGridView dataGridViewProfissional;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisarNome;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Panel panelNovoCadastro;
        private System.Windows.Forms.Panel panelCadAbas;
        private System.Windows.Forms.Button btnCadDadosPessoais;
        private System.Windows.Forms.Button btnCadDadosProfissionais;
        private System.Windows.Forms.Panel panelCadDadosPessoais;
        private System.Windows.Forms.Panel panelCadDadosProfisionais;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.Button btnCadSair;
        private System.Windows.Forms.TextBox textBoxCadNomeCompleto;
        private System.Windows.Forms.PictureBox pictureBoxCadImgProfile;
        private System.Windows.Forms.LinkLabel linkLabelCadImportImg;
        private System.Windows.Forms.TextBox textBoxCadEmail;
        private System.Windows.Forms.ComboBox comboBoxCadSexo;
        private System.Windows.Forms.MaskedTextBox maskCadTelefone;
        private System.Windows.Forms.MaskedTextBox maskCadCpf;
        private System.Windows.Forms.ComboBox comboBoxCadTipoTratamento;
        private System.Windows.Forms.TextBox textBoxCadEspecialidade;
        private System.Windows.Forms.ComboBox comboBoxCadUFdeRegistro;
        private System.Windows.Forms.ComboBox comboBoxCadConselhoRegistro;
        private System.Windows.Forms.TextBox textBoxCadNdeRegistro;
        private DataSource.IClinicDatabaseDataSet iClinicDatabaseDataSet;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.ColaboradorTableAdapter colaboradorTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabelCadExcluirImagem;
        private System.Windows.Forms.Label labelCadEspecialidade;
        private System.Windows.Forms.Label labelCadUFdeRegistro;
        private System.Windows.Forms.Label labelCadNdeRegistro;
        private System.Windows.Forms.Label labelCadTipoTratamento;
        private System.Windows.Forms.Label labelCadConselhoRegistro;
        private System.Windows.Forms.Label labelContagem;
        private System.Windows.Forms.Panel panelEditarCadastro;
        private System.Windows.Forms.Panel panelUpdTituloEditarCadastro;
        private System.Windows.Forms.Label labelUpdEditarCadastro;
        private System.Windows.Forms.Button btnUpdSalvar;
        private System.Windows.Forms.Button btnUpdSair;
        private System.Windows.Forms.Panel panelUpdAbas;
        private System.Windows.Forms.Button btnUpdDadosPessoais;
        private System.Windows.Forms.Button btnUpdDadosProfissionais;
        private System.Windows.Forms.Panel panelUpdDadosPessoais;
        private System.Windows.Forms.LinkLabel linkLabelUpdExcluirImg;
        private System.Windows.Forms.MaskedTextBox maskUpdTelefone;
        private System.Windows.Forms.MaskedTextBox maskUpdCpf;
        private System.Windows.Forms.ComboBox comboBoxUpdSexo;
        private System.Windows.Forms.TextBox textBoxUpdEmail;
        private System.Windows.Forms.LinkLabel linkLabelUpdImportImg;
        private System.Windows.Forms.PictureBox pictureBoxUpdImgProfile;
        private System.Windows.Forms.TextBox textBoxUpdNomeCompleto;
        private System.Windows.Forms.Panel panelUpdDadosProfissionais;
        private System.Windows.Forms.Label labelUpdEspecialidade;
        private System.Windows.Forms.TextBox textBoxUpdEspecialidade;
        private System.Windows.Forms.ComboBox comboBoxUpdUFdeRegistro;
        private System.Windows.Forms.Label labelUpdUFdeRegistro;
        private System.Windows.Forms.ComboBox comboBoxUpdConselhoRegistro;
        private System.Windows.Forms.Label labelUpdNdeRegistro;
        private System.Windows.Forms.TextBox textBoxUpdNdeRegistro;
        private System.Windows.Forms.Label labelUpdTipoTratamento;
        private System.Windows.Forms.ComboBox comboBoxUpdTipoTratamento;
        private System.Windows.Forms.Label labelUpdConselhoRegistro;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColaboradorDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCadastro;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelCadTitulo;
        private System.Windows.Forms.Panel panelCadOpcoesCadBottom;
        private System.Windows.Forms.Panel panelUpdOpcoesCadBottom;
    }
}