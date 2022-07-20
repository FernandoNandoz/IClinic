namespace IClinic.Forms
{
    partial class frmPacientes
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label labelCadTitulo;
            System.Windows.Forms.Label labelCadLinhaTitulo;
            System.Windows.Forms.Panel panelCadPai;
            System.Windows.Forms.FlowLayoutPanel flpCadastroPaciente;
            System.Windows.Forms.Label labelCadSexo;
            System.Windows.Forms.Label labelCadEmail;
            System.Windows.Forms.Label labelCadTelefone;
            System.Windows.Forms.Label labelCadObservacao;
            System.Windows.Forms.Label labelCadRG;
            System.Windows.Forms.Label labelCadCPF;
            System.Windows.Forms.Label labelCadNascimento;
            System.Windows.Forms.Label labelCadNomeCompleto;
            System.Windows.Forms.Label labelCadComplemento;
            System.Windows.Forms.Label labelCadNumero;
            System.Windows.Forms.Label labelCadCEP;
            System.Windows.Forms.Label labelCadBairro;
            System.Windows.Forms.Label labelCadEstado;
            System.Windows.Forms.Label labelCadCidade;
            System.Windows.Forms.Label labelCadEndereco;
            System.Windows.Forms.Label labelCadObservacaoFamiliar;
            System.Windows.Forms.Label labelCadVinculo;
            System.Windows.Forms.Label labelCadNomeFamiliar;
            System.Windows.Forms.Label labelCadTelefoneFamiliar;
            System.Windows.Forms.Label labelCadParentesco;
            System.Windows.Forms.Panel panelCadAbas;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            System.Windows.Forms.Panel panelUpdPai;
            System.Windows.Forms.FlowLayoutPanel flpEditarPaciente;
            System.Windows.Forms.Label labelUpdSexo;
            System.Windows.Forms.Label labelUpdEmail;
            System.Windows.Forms.Label labelUpdTelefone;
            System.Windows.Forms.Label labelUpdObservacoes;
            System.Windows.Forms.Label labelUpdRG;
            System.Windows.Forms.Label labelUpdCPF;
            System.Windows.Forms.Label labelUpdNascimento;
            System.Windows.Forms.Label labelUpdNomeCompleto;
            System.Windows.Forms.Label labelUpdComplemento;
            System.Windows.Forms.Label labelUpdNumero;
            System.Windows.Forms.Label labelUpdCEP;
            System.Windows.Forms.Label labelUpdBairro;
            System.Windows.Forms.Label labelUpdEstado;
            System.Windows.Forms.Label labelUpdCidade;
            System.Windows.Forms.Label labelUpdEndereco;
            System.Windows.Forms.Label labelUpdObservacaoFamiliares;
            System.Windows.Forms.Label labelUpdVinculo;
            System.Windows.Forms.Label labelUpdNomeFamiliar;
            System.Windows.Forms.Label labelUpdTelefoneFamiliar;
            System.Windows.Forms.Label labelUpdParentesco;
            System.Windows.Forms.Panel panelUpdAbas;
            System.Windows.Forms.Label labelUpdTitulo;
            System.Windows.Forms.Label labelUpdLinhaTitulo;
            System.Windows.Forms.Label labelSelecioneProduto;
            System.Windows.Forms.Label labelLinhaSelecione;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCadDadosPessoais = new System.Windows.Forms.Panel();
            this.maskCadDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCadSexo = new System.Windows.Forms.ComboBox();
            this.textBoxCadEmail = new System.Windows.Forms.TextBox();
            this.maskCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCadObservacao = new System.Windows.Forms.TextBox();
            this.textBoxCadNomeCompleto = new System.Windows.Forms.TextBox();
            this.textBoxCadRG = new System.Windows.Forms.TextBox();
            this.maskCadCPF = new System.Windows.Forms.MaskedTextBox();
            this.panelCadEndereco = new System.Windows.Forms.Panel();
            this.textBoxCadEstado = new System.Windows.Forms.TextBox();
            this.textBoxCadCidade = new System.Windows.Forms.TextBox();
            this.textBoxCadComplemento = new System.Windows.Forms.TextBox();
            this.maskCadCEP = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCadNumero = new System.Windows.Forms.TextBox();
            this.textBoxCadBairro = new System.Windows.Forms.TextBox();
            this.textBoxCadEndereco = new System.Windows.Forms.TextBox();
            this.panelCadDadosFamiliar = new System.Windows.Forms.Panel();
            this.textBoxCadVinculo = new System.Windows.Forms.TextBox();
            this.textBoxCadNomeFamiliar = new System.Windows.Forms.TextBox();
            this.maskCadTelefoneFamiliar = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCadParentesco = new System.Windows.Forms.TextBox();
            this.textBoxCadObservacaoFamiliar = new System.Windows.Forms.TextBox();
            this.btnCadDadosFamiliares = new System.Windows.Forms.Button();
            this.btnCadEndereco = new System.Windows.Forms.Button();
            this.btnCadDadosPessoais = new System.Windows.Forms.Button();
            this.panelUpdDadosPessoais = new System.Windows.Forms.Panel();
            this.maskUpdDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iClinicDatabaseDataSet = new IClinic.DataSource.IClinicDatabaseDataSet();
            this.comboBoxUpdSexo = new System.Windows.Forms.ComboBox();
            this.textBoxUpdEmail = new System.Windows.Forms.TextBox();
            this.maskUpdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUpdObservacao = new System.Windows.Forms.TextBox();
            this.textBoxUpdNomeCompleto = new System.Windows.Forms.TextBox();
            this.textBoxUpdRG = new System.Windows.Forms.TextBox();
            this.maskUpdCPF = new System.Windows.Forms.MaskedTextBox();
            this.panelUpdEndereco = new System.Windows.Forms.Panel();
            this.textBoxUpdEstado = new System.Windows.Forms.TextBox();
            this.textBoxUpdCidade = new System.Windows.Forms.TextBox();
            this.textBoxUpdComplemento = new System.Windows.Forms.TextBox();
            this.maskUpdCEP = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUpdNumero = new System.Windows.Forms.TextBox();
            this.textBoxUpdBairro = new System.Windows.Forms.TextBox();
            this.textBoxUpdEndereco = new System.Windows.Forms.TextBox();
            this.panelUpdDadosFamiliares = new System.Windows.Forms.Panel();
            this.textBoxUpdVinculo = new System.Windows.Forms.TextBox();
            this.dadosComplementaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxUpdNomeFamiliar = new System.Windows.Forms.TextBox();
            this.maskUpdTelefoneFamiliar = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUpdParentesco = new System.Windows.Forms.TextBox();
            this.textBoxUpdObservacaoFamiliares = new System.Windows.Forms.TextBox();
            this.btnUpdDadosFamiliares = new System.Windows.Forms.Button();
            this.btnUpdEndereco = new System.Windows.Forms.Button();
            this.btnUpdDadosPessoais = new System.Windows.Forms.Button();
            this.panelCadTitulo = new System.Windows.Forms.Panel();
            this.panelCadOpcoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelUpdOpcoes = new System.Windows.Forms.Panel();
            this.btnSavalEditar = new System.Windows.Forms.Button();
            this.btnSairEditar = new System.Windows.Forms.Button();
            this.panelUpdTitulo = new System.Windows.Forms.Panel();
            this.panelConsultarPaciente = new System.Windows.Forms.Panel();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoBiologicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonePrincipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnFichaAcompanhamento = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovoPaciente = new System.Windows.Forms.Button();
            this.textBoxPesquisarNome = new System.Windows.Forms.TextBox();
            this.labelContagem = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPai = new System.Windows.Forms.Panel();
            this.flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNovoCadastro = new System.Windows.Forms.Panel();
            this.panelEditarCadastro = new System.Windows.Forms.Panel();
            this.pacienteTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.PacienteTableAdapter();
            this.dadosComplementaresTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.DadosComplementaresTableAdapter();
            label6 = new System.Windows.Forms.Label();
            labelCadTitulo = new System.Windows.Forms.Label();
            labelCadLinhaTitulo = new System.Windows.Forms.Label();
            panelCadPai = new System.Windows.Forms.Panel();
            flpCadastroPaciente = new System.Windows.Forms.FlowLayoutPanel();
            labelCadSexo = new System.Windows.Forms.Label();
            labelCadEmail = new System.Windows.Forms.Label();
            labelCadTelefone = new System.Windows.Forms.Label();
            labelCadObservacao = new System.Windows.Forms.Label();
            labelCadRG = new System.Windows.Forms.Label();
            labelCadCPF = new System.Windows.Forms.Label();
            labelCadNascimento = new System.Windows.Forms.Label();
            labelCadNomeCompleto = new System.Windows.Forms.Label();
            labelCadComplemento = new System.Windows.Forms.Label();
            labelCadNumero = new System.Windows.Forms.Label();
            labelCadCEP = new System.Windows.Forms.Label();
            labelCadBairro = new System.Windows.Forms.Label();
            labelCadEstado = new System.Windows.Forms.Label();
            labelCadCidade = new System.Windows.Forms.Label();
            labelCadEndereco = new System.Windows.Forms.Label();
            labelCadObservacaoFamiliar = new System.Windows.Forms.Label();
            labelCadVinculo = new System.Windows.Forms.Label();
            labelCadNomeFamiliar = new System.Windows.Forms.Label();
            labelCadTelefoneFamiliar = new System.Windows.Forms.Label();
            labelCadParentesco = new System.Windows.Forms.Label();
            panelCadAbas = new System.Windows.Forms.Panel();
            panelUpdPai = new System.Windows.Forms.Panel();
            flpEditarPaciente = new System.Windows.Forms.FlowLayoutPanel();
            labelUpdSexo = new System.Windows.Forms.Label();
            labelUpdEmail = new System.Windows.Forms.Label();
            labelUpdTelefone = new System.Windows.Forms.Label();
            labelUpdObservacoes = new System.Windows.Forms.Label();
            labelUpdRG = new System.Windows.Forms.Label();
            labelUpdCPF = new System.Windows.Forms.Label();
            labelUpdNascimento = new System.Windows.Forms.Label();
            labelUpdNomeCompleto = new System.Windows.Forms.Label();
            labelUpdComplemento = new System.Windows.Forms.Label();
            labelUpdNumero = new System.Windows.Forms.Label();
            labelUpdCEP = new System.Windows.Forms.Label();
            labelUpdBairro = new System.Windows.Forms.Label();
            labelUpdEstado = new System.Windows.Forms.Label();
            labelUpdCidade = new System.Windows.Forms.Label();
            labelUpdEndereco = new System.Windows.Forms.Label();
            labelUpdObservacaoFamiliares = new System.Windows.Forms.Label();
            labelUpdVinculo = new System.Windows.Forms.Label();
            labelUpdNomeFamiliar = new System.Windows.Forms.Label();
            labelUpdTelefoneFamiliar = new System.Windows.Forms.Label();
            labelUpdParentesco = new System.Windows.Forms.Label();
            panelUpdAbas = new System.Windows.Forms.Panel();
            labelUpdTitulo = new System.Windows.Forms.Label();
            labelUpdLinhaTitulo = new System.Windows.Forms.Label();
            labelSelecioneProduto = new System.Windows.Forms.Label();
            labelLinhaSelecione = new System.Windows.Forms.Label();
            panelCadPai.SuspendLayout();
            flpCadastroPaciente.SuspendLayout();
            this.panelCadDadosPessoais.SuspendLayout();
            this.panelCadEndereco.SuspendLayout();
            this.panelCadDadosFamiliar.SuspendLayout();
            panelCadAbas.SuspendLayout();
            panelUpdPai.SuspendLayout();
            flpEditarPaciente.SuspendLayout();
            this.panelUpdDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).BeginInit();
            this.panelUpdEndereco.SuspendLayout();
            this.panelUpdDadosFamiliares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosComplementaresBindingSource)).BeginInit();
            panelUpdAbas.SuspendLayout();
            this.panelCadTitulo.SuspendLayout();
            this.panelCadOpcoes.SuspendLayout();
            this.panelUpdOpcoes.SuspendLayout();
            this.panelUpdTitulo.SuspendLayout();
            this.panelConsultarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.containerPai.SuspendLayout();
            this.flpContainerPai.SuspendLayout();
            this.panelNovoCadastro.SuspendLayout();
            this.panelEditarCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(28, 43);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 20);
            label6.TabIndex = 28;
            label6.Text = "Paciente";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadTitulo
            // 
            labelCadTitulo.AutoSize = true;
            labelCadTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelCadTitulo.Location = new System.Drawing.Point(17, 9);
            labelCadTitulo.Name = "labelCadTitulo";
            labelCadTitulo.Size = new System.Drawing.Size(133, 24);
            labelCadTitulo.TabIndex = 13;
            labelCadTitulo.Text = "Novo Paciente";
            // 
            // labelCadLinhaTitulo
            // 
            labelCadLinhaTitulo.AutoSize = true;
            labelCadLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelCadLinhaTitulo.Location = new System.Drawing.Point(17, 15);
            labelCadLinhaTitulo.Name = "labelCadLinhaTitulo";
            labelCadLinhaTitulo.Size = new System.Drawing.Size(1120, 24);
            labelCadLinhaTitulo.TabIndex = 14;
            labelCadLinhaTitulo.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // panelCadPai
            // 
            panelCadPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            panelCadPai.Controls.Add(flpCadastroPaciente);
            panelCadPai.Controls.Add(panelCadAbas);
            panelCadPai.Location = new System.Drawing.Point(0, 51);
            panelCadPai.Margin = new System.Windows.Forms.Padding(0);
            panelCadPai.Name = "panelCadPai";
            panelCadPai.Size = new System.Drawing.Size(1160, 370);
            panelCadPai.TabIndex = 44;
            // 
            // flpCadastroPaciente
            // 
            flpCadastroPaciente.AutoScroll = true;
            flpCadastroPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            flpCadastroPaciente.Controls.Add(this.panelCadDadosPessoais);
            flpCadastroPaciente.Controls.Add(this.panelCadEndereco);
            flpCadastroPaciente.Controls.Add(this.panelCadDadosFamiliar);
            flpCadastroPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            flpCadastroPaciente.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpCadastroPaciente.Location = new System.Drawing.Point(0, 40);
            flpCadastroPaciente.Name = "flpCadastroPaciente";
            flpCadastroPaciente.Size = new System.Drawing.Size(1160, 330);
            flpCadastroPaciente.TabIndex = 1;
            // 
            // panelCadDadosPessoais
            // 
            this.panelCadDadosPessoais.Controls.Add(this.maskCadDataNascimento);
            this.panelCadDadosPessoais.Controls.Add(labelCadSexo);
            this.panelCadDadosPessoais.Controls.Add(this.comboBoxCadSexo);
            this.panelCadDadosPessoais.Controls.Add(labelCadEmail);
            this.panelCadDadosPessoais.Controls.Add(this.textBoxCadEmail);
            this.panelCadDadosPessoais.Controls.Add(this.maskCadTelefone);
            this.panelCadDadosPessoais.Controls.Add(labelCadTelefone);
            this.panelCadDadosPessoais.Controls.Add(labelCadObservacao);
            this.panelCadDadosPessoais.Controls.Add(this.textBoxCadObservacao);
            this.panelCadDadosPessoais.Controls.Add(labelCadRG);
            this.panelCadDadosPessoais.Controls.Add(labelCadCPF);
            this.panelCadDadosPessoais.Controls.Add(labelCadNascimento);
            this.panelCadDadosPessoais.Controls.Add(labelCadNomeCompleto);
            this.panelCadDadosPessoais.Controls.Add(this.textBoxCadNomeCompleto);
            this.panelCadDadosPessoais.Controls.Add(this.textBoxCadRG);
            this.panelCadDadosPessoais.Controls.Add(this.maskCadCPF);
            this.panelCadDadosPessoais.Location = new System.Drawing.Point(0, 0);
            this.panelCadDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadDadosPessoais.Name = "panelCadDadosPessoais";
            this.panelCadDadosPessoais.Size = new System.Drawing.Size(1160, 330);
            this.panelCadDadosPessoais.TabIndex = 0;
            this.panelCadDadosPessoais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadDadosPessoais_Paint);
            // 
            // maskCadDataNascimento
            // 
            this.maskCadDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadDataNascimento.Location = new System.Drawing.Point(695, 61);
            this.maskCadDataNascimento.Mask = "00/00/0000";
            this.maskCadDataNascimento.Name = "maskCadDataNascimento";
            this.maskCadDataNascimento.Size = new System.Drawing.Size(200, 29);
            this.maskCadDataNascimento.TabIndex = 11;
            // 
            // labelCadSexo
            // 
            labelCadSexo.AutoSize = true;
            labelCadSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadSexo.Location = new System.Drawing.Point(902, 35);
            labelCadSexo.Name = "labelCadSexo";
            labelCadSexo.Size = new System.Drawing.Size(54, 24);
            labelCadSexo.TabIndex = 18;
            labelCadSexo.Text = "Sexo";
            // 
            // comboBoxCadSexo
            // 
            this.comboBoxCadSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxCadSexo.FormattingEnabled = true;
            this.comboBoxCadSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTRO"});
            this.comboBoxCadSexo.Location = new System.Drawing.Point(906, 62);
            this.comboBoxCadSexo.Name = "comboBoxCadSexo";
            this.comboBoxCadSexo.Size = new System.Drawing.Size(200, 28);
            this.comboBoxCadSexo.TabIndex = 12;
            // 
            // labelCadEmail
            // 
            labelCadEmail.AutoSize = true;
            labelCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadEmail.Location = new System.Drawing.Point(593, 114);
            labelCadEmail.Name = "labelCadEmail";
            labelCadEmail.Size = new System.Drawing.Size(63, 24);
            labelCadEmail.TabIndex = 16;
            labelCadEmail.Text = "E-mail";
            // 
            // textBoxCadEmail
            // 
            this.textBoxCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadEmail.Location = new System.Drawing.Point(597, 141);
            this.textBoxCadEmail.Name = "textBoxCadEmail";
            this.textBoxCadEmail.Size = new System.Drawing.Size(509, 29);
            this.textBoxCadEmail.TabIndex = 16;
            // 
            // maskCadTelefone
            // 
            this.maskCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadTelefone.Location = new System.Drawing.Point(415, 141);
            this.maskCadTelefone.Mask = "(00) 0 0000-0000";
            this.maskCadTelefone.Name = "maskCadTelefone";
            this.maskCadTelefone.Size = new System.Drawing.Size(170, 29);
            this.maskCadTelefone.TabIndex = 15;
            // 
            // labelCadTelefone
            // 
            labelCadTelefone.AutoSize = true;
            labelCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadTelefone.Location = new System.Drawing.Point(411, 114);
            labelCadTelefone.Name = "labelCadTelefone";
            labelCadTelefone.Size = new System.Drawing.Size(85, 24);
            labelCadTelefone.TabIndex = 11;
            labelCadTelefone.Text = "Telefone";
            // 
            // labelCadObservacao
            // 
            labelCadObservacao.AutoSize = true;
            labelCadObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadObservacao.Location = new System.Drawing.Point(48, 194);
            labelCadObservacao.Name = "labelCadObservacao";
            labelCadObservacao.Size = new System.Drawing.Size(211, 24);
            labelCadObservacao.TabIndex = 10;
            labelCadObservacao.Text = "Observações (opcional)";
            // 
            // textBoxCadObservacao
            // 
            this.textBoxCadObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadObservacao.Location = new System.Drawing.Point(52, 221);
            this.textBoxCadObservacao.Name = "textBoxCadObservacao";
            this.textBoxCadObservacao.Size = new System.Drawing.Size(1054, 29);
            this.textBoxCadObservacao.TabIndex = 17;
            // 
            // labelCadRG
            // 
            labelCadRG.AutoSize = true;
            labelCadRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadRG.Location = new System.Drawing.Point(230, 114);
            labelCadRG.Name = "labelCadRG";
            labelCadRG.Size = new System.Drawing.Size(37, 24);
            labelCadRG.TabIndex = 8;
            labelCadRG.Text = "RG";
            // 
            // labelCadCPF
            // 
            labelCadCPF.AutoSize = true;
            labelCadCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadCPF.Location = new System.Drawing.Point(48, 114);
            labelCadCPF.Name = "labelCadCPF";
            labelCadCPF.Size = new System.Drawing.Size(47, 24);
            labelCadCPF.TabIndex = 5;
            labelCadCPF.Text = "CPF";
            // 
            // labelCadNascimento
            // 
            labelCadNascimento.AutoSize = true;
            labelCadNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNascimento.Location = new System.Drawing.Point(691, 34);
            labelCadNascimento.Name = "labelCadNascimento";
            labelCadNascimento.Size = new System.Drawing.Size(110, 24);
            labelCadNascimento.TabIndex = 3;
            labelCadNascimento.Text = "Nascimento";
            // 
            // labelCadNomeCompleto
            // 
            labelCadNomeCompleto.AutoSize = true;
            labelCadNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNomeCompleto.Location = new System.Drawing.Point(45, 34);
            labelCadNomeCompleto.Name = "labelCadNomeCompleto";
            labelCadNomeCompleto.Size = new System.Drawing.Size(148, 24);
            labelCadNomeCompleto.TabIndex = 1;
            labelCadNomeCompleto.Text = "Nome Completo";
            // 
            // textBoxCadNomeCompleto
            // 
            this.textBoxCadNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomeCompleto.Location = new System.Drawing.Point(49, 61);
            this.textBoxCadNomeCompleto.Name = "textBoxCadNomeCompleto";
            this.textBoxCadNomeCompleto.Size = new System.Drawing.Size(635, 29);
            this.textBoxCadNomeCompleto.TabIndex = 10;
            // 
            // textBoxCadRG
            // 
            this.textBoxCadRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadRG.Location = new System.Drawing.Point(234, 141);
            this.textBoxCadRG.Name = "textBoxCadRG";
            this.textBoxCadRG.Size = new System.Drawing.Size(170, 29);
            this.textBoxCadRG.TabIndex = 14;
            // 
            // maskCadCPF
            // 
            this.maskCadCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadCPF.Location = new System.Drawing.Point(52, 141);
            this.maskCadCPF.Mask = "000.000.000-00";
            this.maskCadCPF.Name = "maskCadCPF";
            this.maskCadCPF.Size = new System.Drawing.Size(170, 29);
            this.maskCadCPF.TabIndex = 13;
            // 
            // panelCadEndereco
            // 
            this.panelCadEndereco.Controls.Add(this.textBoxCadEstado);
            this.panelCadEndereco.Controls.Add(this.textBoxCadCidade);
            this.panelCadEndereco.Controls.Add(labelCadComplemento);
            this.panelCadEndereco.Controls.Add(this.textBoxCadComplemento);
            this.panelCadEndereco.Controls.Add(this.maskCadCEP);
            this.panelCadEndereco.Controls.Add(labelCadNumero);
            this.panelCadEndereco.Controls.Add(this.textBoxCadNumero);
            this.panelCadEndereco.Controls.Add(labelCadCEP);
            this.panelCadEndereco.Controls.Add(labelCadBairro);
            this.panelCadEndereco.Controls.Add(this.textBoxCadBairro);
            this.panelCadEndereco.Controls.Add(labelCadEstado);
            this.panelCadEndereco.Controls.Add(labelCadCidade);
            this.panelCadEndereco.Controls.Add(labelCadEndereco);
            this.panelCadEndereco.Controls.Add(this.textBoxCadEndereco);
            this.panelCadEndereco.Location = new System.Drawing.Point(1160, 0);
            this.panelCadEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadEndereco.Name = "panelCadEndereco";
            this.panelCadEndereco.Size = new System.Drawing.Size(1160, 330);
            this.panelCadEndereco.TabIndex = 1;
            this.panelCadEndereco.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadEndereco_Paint);
            // 
            // textBoxCadEstado
            // 
            this.textBoxCadEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadEstado.Location = new System.Drawing.Point(351, 225);
            this.textBoxCadEstado.Name = "textBoxCadEstado";
            this.textBoxCadEstado.Size = new System.Drawing.Size(290, 29);
            this.textBoxCadEstado.TabIndex = 24;
            // 
            // textBoxCadCidade
            // 
            this.textBoxCadCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadCidade.Location = new System.Drawing.Point(50, 225);
            this.textBoxCadCidade.Name = "textBoxCadCidade";
            this.textBoxCadCidade.Size = new System.Drawing.Size(290, 29);
            this.textBoxCadCidade.TabIndex = 23;
            // 
            // labelCadComplemento
            // 
            labelCadComplemento.AutoSize = true;
            labelCadComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadComplemento.Location = new System.Drawing.Point(347, 114);
            labelCadComplemento.Name = "labelCadComplemento";
            labelCadComplemento.Size = new System.Drawing.Size(129, 24);
            labelCadComplemento.TabIndex = 18;
            labelCadComplemento.Text = "Complemento";
            // 
            // textBoxCadComplemento
            // 
            this.textBoxCadComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadComplemento.Location = new System.Drawing.Point(351, 141);
            this.textBoxCadComplemento.Name = "textBoxCadComplemento";
            this.textBoxCadComplemento.Size = new System.Drawing.Size(662, 29);
            this.textBoxCadComplemento.TabIndex = 22;
            // 
            // maskCadCEP
            // 
            this.maskCadCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadCEP.Location = new System.Drawing.Point(50, 61);
            this.maskCadCEP.Mask = "00000-000";
            this.maskCadCEP.Name = "maskCadCEP";
            this.maskCadCEP.Size = new System.Drawing.Size(170, 29);
            this.maskCadCEP.TabIndex = 18;
            // 
            // labelCadNumero
            // 
            labelCadNumero.AutoSize = true;
            labelCadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNumero.Location = new System.Drawing.Point(849, 34);
            labelCadNumero.Name = "labelCadNumero";
            labelCadNumero.Size = new System.Drawing.Size(79, 24);
            labelCadNumero.TabIndex = 15;
            labelCadNumero.Text = "Numero";
            // 
            // textBoxCadNumero
            // 
            this.textBoxCadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNumero.Location = new System.Drawing.Point(853, 61);
            this.textBoxCadNumero.Name = "textBoxCadNumero";
            this.textBoxCadNumero.Size = new System.Drawing.Size(160, 29);
            this.textBoxCadNumero.TabIndex = 20;
            // 
            // labelCadCEP
            // 
            labelCadCEP.AutoSize = true;
            labelCadCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadCEP.Location = new System.Drawing.Point(46, 35);
            labelCadCEP.Name = "labelCadCEP";
            labelCadCEP.Size = new System.Drawing.Size(48, 24);
            labelCadCEP.TabIndex = 13;
            labelCadCEP.Text = "CEP";
            // 
            // labelCadBairro
            // 
            labelCadBairro.AutoSize = true;
            labelCadBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadBairro.Location = new System.Drawing.Point(46, 114);
            labelCadBairro.Name = "labelCadBairro";
            labelCadBairro.Size = new System.Drawing.Size(59, 24);
            labelCadBairro.TabIndex = 11;
            labelCadBairro.Text = "Bairro";
            // 
            // textBoxCadBairro
            // 
            this.textBoxCadBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadBairro.Location = new System.Drawing.Point(50, 141);
            this.textBoxCadBairro.Name = "textBoxCadBairro";
            this.textBoxCadBairro.Size = new System.Drawing.Size(290, 29);
            this.textBoxCadBairro.TabIndex = 21;
            // 
            // labelCadEstado
            // 
            labelCadEstado.AutoSize = true;
            labelCadEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadEstado.Location = new System.Drawing.Point(347, 198);
            labelCadEstado.Name = "labelCadEstado";
            labelCadEstado.Size = new System.Drawing.Size(68, 24);
            labelCadEstado.TabIndex = 7;
            labelCadEstado.Text = "Estado";
            // 
            // labelCadCidade
            // 
            labelCadCidade.AutoSize = true;
            labelCadCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadCidade.Location = new System.Drawing.Point(46, 197);
            labelCadCidade.Name = "labelCadCidade";
            labelCadCidade.Size = new System.Drawing.Size(70, 24);
            labelCadCidade.TabIndex = 5;
            labelCadCidade.Text = "Cidade";
            // 
            // labelCadEndereco
            // 
            labelCadEndereco.AutoSize = true;
            labelCadEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadEndereco.Location = new System.Drawing.Point(228, 34);
            labelCadEndereco.Name = "labelCadEndereco";
            labelCadEndereco.Size = new System.Drawing.Size(99, 24);
            labelCadEndereco.TabIndex = 3;
            labelCadEndereco.Text = "Endereço ";
            // 
            // textBoxCadEndereco
            // 
            this.textBoxCadEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadEndereco.Location = new System.Drawing.Point(232, 61);
            this.textBoxCadEndereco.Name = "textBoxCadEndereco";
            this.textBoxCadEndereco.Size = new System.Drawing.Size(609, 29);
            this.textBoxCadEndereco.TabIndex = 19;
            // 
            // panelCadDadosFamiliar
            // 
            this.panelCadDadosFamiliar.Controls.Add(labelCadObservacaoFamiliar);
            this.panelCadDadosFamiliar.Controls.Add(labelCadVinculo);
            this.panelCadDadosFamiliar.Controls.Add(this.textBoxCadVinculo);
            this.panelCadDadosFamiliar.Controls.Add(labelCadNomeFamiliar);
            this.panelCadDadosFamiliar.Controls.Add(this.textBoxCadNomeFamiliar);
            this.panelCadDadosFamiliar.Controls.Add(this.maskCadTelefoneFamiliar);
            this.panelCadDadosFamiliar.Controls.Add(labelCadTelefoneFamiliar);
            this.panelCadDadosFamiliar.Controls.Add(labelCadParentesco);
            this.panelCadDadosFamiliar.Controls.Add(this.textBoxCadParentesco);
            this.panelCadDadosFamiliar.Controls.Add(this.textBoxCadObservacaoFamiliar);
            this.panelCadDadosFamiliar.Location = new System.Drawing.Point(2320, 0);
            this.panelCadDadosFamiliar.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadDadosFamiliar.Name = "panelCadDadosFamiliar";
            this.panelCadDadosFamiliar.Size = new System.Drawing.Size(1160, 330);
            this.panelCadDadosFamiliar.TabIndex = 16;
            this.panelCadDadosFamiliar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadDadosFamiliar_Paint);
            // 
            // labelCadObservacaoFamiliar
            // 
            labelCadObservacaoFamiliar.AutoSize = true;
            labelCadObservacaoFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadObservacaoFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadObservacaoFamiliar.Location = new System.Drawing.Point(46, 194);
            labelCadObservacaoFamiliar.Name = "labelCadObservacaoFamiliar";
            labelCadObservacaoFamiliar.Size = new System.Drawing.Size(112, 24);
            labelCadObservacaoFamiliar.TabIndex = 22;
            labelCadObservacaoFamiliar.Text = "Observação";
            // 
            // labelCadVinculo
            // 
            labelCadVinculo.AutoSize = true;
            labelCadVinculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadVinculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadVinculo.Location = new System.Drawing.Point(329, 114);
            labelCadVinculo.Name = "labelCadVinculo";
            labelCadVinculo.Size = new System.Drawing.Size(74, 24);
            labelCadVinculo.TabIndex = 20;
            labelCadVinculo.Text = "Vinculo";
            // 
            // textBoxCadVinculo
            // 
            this.textBoxCadVinculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadVinculo.Location = new System.Drawing.Point(333, 141);
            this.textBoxCadVinculo.Name = "textBoxCadVinculo";
            this.textBoxCadVinculo.Size = new System.Drawing.Size(270, 29);
            this.textBoxCadVinculo.TabIndex = 27;
            // 
            // labelCadNomeFamiliar
            // 
            labelCadNomeFamiliar.AutoSize = true;
            labelCadNomeFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNomeFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadNomeFamiliar.Location = new System.Drawing.Point(46, 32);
            labelCadNomeFamiliar.Name = "labelCadNomeFamiliar";
            labelCadNomeFamiliar.Size = new System.Drawing.Size(133, 24);
            labelCadNomeFamiliar.TabIndex = 16;
            labelCadNomeFamiliar.Text = "Nome Familiar";
            // 
            // textBoxCadNomeFamiliar
            // 
            this.textBoxCadNomeFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomeFamiliar.Location = new System.Drawing.Point(50, 59);
            this.textBoxCadNomeFamiliar.Name = "textBoxCadNomeFamiliar";
            this.textBoxCadNomeFamiliar.Size = new System.Drawing.Size(778, 29);
            this.textBoxCadNomeFamiliar.TabIndex = 25;
            // 
            // maskCadTelefoneFamiliar
            // 
            this.maskCadTelefoneFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadTelefoneFamiliar.Location = new System.Drawing.Point(616, 141);
            this.maskCadTelefoneFamiliar.Mask = "(00) 0 0000-0000";
            this.maskCadTelefoneFamiliar.Name = "maskCadTelefoneFamiliar";
            this.maskCadTelefoneFamiliar.Size = new System.Drawing.Size(212, 29);
            this.maskCadTelefoneFamiliar.TabIndex = 28;
            // 
            // labelCadTelefoneFamiliar
            // 
            labelCadTelefoneFamiliar.AutoSize = true;
            labelCadTelefoneFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadTelefoneFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadTelefoneFamiliar.Location = new System.Drawing.Point(612, 114);
            labelCadTelefoneFamiliar.Name = "labelCadTelefoneFamiliar";
            labelCadTelefoneFamiliar.Size = new System.Drawing.Size(85, 24);
            labelCadTelefoneFamiliar.TabIndex = 13;
            labelCadTelefoneFamiliar.Text = "Telefone";
            // 
            // labelCadParentesco
            // 
            labelCadParentesco.AutoSize = true;
            labelCadParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadParentesco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelCadParentesco.Location = new System.Drawing.Point(46, 114);
            labelCadParentesco.Name = "labelCadParentesco";
            labelCadParentesco.Size = new System.Drawing.Size(105, 24);
            labelCadParentesco.TabIndex = 18;
            labelCadParentesco.Text = "Parentesco";
            // 
            // textBoxCadParentesco
            // 
            this.textBoxCadParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadParentesco.Location = new System.Drawing.Point(50, 141);
            this.textBoxCadParentesco.Name = "textBoxCadParentesco";
            this.textBoxCadParentesco.Size = new System.Drawing.Size(270, 29);
            this.textBoxCadParentesco.TabIndex = 26;
            // 
            // textBoxCadObservacaoFamiliar
            // 
            this.textBoxCadObservacaoFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadObservacaoFamiliar.Location = new System.Drawing.Point(50, 221);
            this.textBoxCadObservacaoFamiliar.Name = "textBoxCadObservacaoFamiliar";
            this.textBoxCadObservacaoFamiliar.Size = new System.Drawing.Size(778, 29);
            this.textBoxCadObservacaoFamiliar.TabIndex = 29;
            // 
            // panelCadAbas
            // 
            panelCadAbas.Controls.Add(this.btnCadDadosFamiliares);
            panelCadAbas.Controls.Add(this.btnCadEndereco);
            panelCadAbas.Controls.Add(this.btnCadDadosPessoais);
            panelCadAbas.Dock = System.Windows.Forms.DockStyle.Top;
            panelCadAbas.Location = new System.Drawing.Point(0, 0);
            panelCadAbas.Margin = new System.Windows.Forms.Padding(0);
            panelCadAbas.Name = "panelCadAbas";
            panelCadAbas.Size = new System.Drawing.Size(1160, 40);
            panelCadAbas.TabIndex = 0;
            // 
            // btnCadDadosFamiliares
            // 
            this.btnCadDadosFamiliares.FlatAppearance.BorderSize = 0;
            this.btnCadDadosFamiliares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDadosFamiliares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadDadosFamiliares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadDadosFamiliares.Image = ((System.Drawing.Image)(resources.GetObject("btnCadDadosFamiliares.Image")));
            this.btnCadDadosFamiliares.Location = new System.Drawing.Point(319, 0);
            this.btnCadDadosFamiliares.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadDadosFamiliares.Name = "btnCadDadosFamiliares";
            this.btnCadDadosFamiliares.Size = new System.Drawing.Size(229, 40);
            this.btnCadDadosFamiliares.TabIndex = 2;
            this.btnCadDadosFamiliares.Text = "  Dados Familiares (Opcional)";
            this.btnCadDadosFamiliares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadDadosFamiliares.UseVisualStyleBackColor = true;
            this.btnCadDadosFamiliares.Click += new System.EventHandler(this.btnCadDadosFamiliares_Click);
            // 
            // btnCadEndereco
            // 
            this.btnCadEndereco.FlatAppearance.BorderSize = 0;
            this.btnCadEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnCadEndereco.Image")));
            this.btnCadEndereco.Location = new System.Drawing.Point(159, 0);
            this.btnCadEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadEndereco.Name = "btnCadEndereco";
            this.btnCadEndereco.Size = new System.Drawing.Size(160, 40);
            this.btnCadEndereco.TabIndex = 1;
            this.btnCadEndereco.Text = "  Endereço";
            this.btnCadEndereco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadEndereco.UseVisualStyleBackColor = true;
            this.btnCadEndereco.Click += new System.EventHandler(this.btnCadEndereco_Click);
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
            this.btnCadDadosPessoais.Size = new System.Drawing.Size(159, 40);
            this.btnCadDadosPessoais.TabIndex = 0;
            this.btnCadDadosPessoais.Text = " Dados Pessoais";
            this.btnCadDadosPessoais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadDadosPessoais.UseVisualStyleBackColor = false;
            this.btnCadDadosPessoais.Click += new System.EventHandler(this.btnCadDadosPessoais_Click);
            // 
            // panelUpdPai
            // 
            panelUpdPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            panelUpdPai.Controls.Add(flpEditarPaciente);
            panelUpdPai.Controls.Add(panelUpdAbas);
            panelUpdPai.Location = new System.Drawing.Point(0, 51);
            panelUpdPai.Margin = new System.Windows.Forms.Padding(0);
            panelUpdPai.Name = "panelUpdPai";
            panelUpdPai.Size = new System.Drawing.Size(1160, 370);
            panelUpdPai.TabIndex = 47;
            // 
            // flpEditarPaciente
            // 
            flpEditarPaciente.AutoScroll = true;
            flpEditarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            flpEditarPaciente.Controls.Add(this.panelUpdDadosPessoais);
            flpEditarPaciente.Controls.Add(this.panelUpdEndereco);
            flpEditarPaciente.Controls.Add(this.panelUpdDadosFamiliares);
            flpEditarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            flpEditarPaciente.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpEditarPaciente.Location = new System.Drawing.Point(0, 40);
            flpEditarPaciente.Name = "flpEditarPaciente";
            flpEditarPaciente.Size = new System.Drawing.Size(1160, 330);
            flpEditarPaciente.TabIndex = 1;
            // 
            // panelUpdDadosPessoais
            // 
            this.panelUpdDadosPessoais.Controls.Add(this.maskUpdDataNascimento);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdSexo);
            this.panelUpdDadosPessoais.Controls.Add(this.comboBoxUpdSexo);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdEmail);
            this.panelUpdDadosPessoais.Controls.Add(this.textBoxUpdEmail);
            this.panelUpdDadosPessoais.Controls.Add(this.maskUpdTelefone);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdTelefone);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdObservacoes);
            this.panelUpdDadosPessoais.Controls.Add(this.textBoxUpdObservacao);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdRG);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdCPF);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdNascimento);
            this.panelUpdDadosPessoais.Controls.Add(labelUpdNomeCompleto);
            this.panelUpdDadosPessoais.Controls.Add(this.textBoxUpdNomeCompleto);
            this.panelUpdDadosPessoais.Controls.Add(this.textBoxUpdRG);
            this.panelUpdDadosPessoais.Controls.Add(this.maskUpdCPF);
            this.panelUpdDadosPessoais.Location = new System.Drawing.Point(0, 0);
            this.panelUpdDadosPessoais.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdDadosPessoais.Name = "panelUpdDadosPessoais";
            this.panelUpdDadosPessoais.Size = new System.Drawing.Size(1160, 330);
            this.panelUpdDadosPessoais.TabIndex = 0;
            this.panelUpdDadosPessoais.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdDadosPessoais_Paint);
            // 
            // maskUpdDataNascimento
            // 
            this.maskUpdDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "dataNascimento", true));
            this.maskUpdDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdDataNascimento.Location = new System.Drawing.Point(696, 62);
            this.maskUpdDataNascimento.Mask = "00/00/0000";
            this.maskUpdDataNascimento.Name = "maskUpdDataNascimento";
            this.maskUpdDataNascimento.Size = new System.Drawing.Size(200, 29);
            this.maskUpdDataNascimento.TabIndex = 31;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // iClinicDatabaseDataSet
            // 
            this.iClinicDatabaseDataSet.DataSetName = "IClinicDatabaseDataSet";
            this.iClinicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelUpdSexo
            // 
            labelUpdSexo.AutoSize = true;
            labelUpdSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdSexo.Location = new System.Drawing.Point(903, 36);
            labelUpdSexo.Name = "labelUpdSexo";
            labelUpdSexo.Size = new System.Drawing.Size(54, 24);
            labelUpdSexo.TabIndex = 18;
            labelUpdSexo.Text = "Sexo";
            // 
            // comboBoxUpdSexo
            // 
            this.comboBoxUpdSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "sexoBiologico", true));
            this.comboBoxUpdSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxUpdSexo.FormattingEnabled = true;
            this.comboBoxUpdSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTRO"});
            this.comboBoxUpdSexo.Location = new System.Drawing.Point(907, 63);
            this.comboBoxUpdSexo.Name = "comboBoxUpdSexo";
            this.comboBoxUpdSexo.Size = new System.Drawing.Size(200, 28);
            this.comboBoxUpdSexo.TabIndex = 32;
            // 
            // labelUpdEmail
            // 
            labelUpdEmail.AutoSize = true;
            labelUpdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdEmail.Location = new System.Drawing.Point(591, 116);
            labelUpdEmail.Name = "labelUpdEmail";
            labelUpdEmail.Size = new System.Drawing.Size(63, 24);
            labelUpdEmail.TabIndex = 16;
            labelUpdEmail.Text = "E-mail";
            // 
            // textBoxUpdEmail
            // 
            this.textBoxUpdEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "email", true));
            this.textBoxUpdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdEmail.Location = new System.Drawing.Point(595, 143);
            this.textBoxUpdEmail.Name = "textBoxUpdEmail";
            this.textBoxUpdEmail.Size = new System.Drawing.Size(509, 29);
            this.textBoxUpdEmail.TabIndex = 36;
            // 
            // maskUpdTelefone
            // 
            this.maskUpdTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "telefonePrincipal", true));
            this.maskUpdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdTelefone.Location = new System.Drawing.Point(413, 143);
            this.maskUpdTelefone.Mask = "(00) 0 0000-0000";
            this.maskUpdTelefone.Name = "maskUpdTelefone";
            this.maskUpdTelefone.Size = new System.Drawing.Size(170, 29);
            this.maskUpdTelefone.TabIndex = 35;
            // 
            // labelUpdTelefone
            // 
            labelUpdTelefone.AutoSize = true;
            labelUpdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdTelefone.Location = new System.Drawing.Point(409, 116);
            labelUpdTelefone.Name = "labelUpdTelefone";
            labelUpdTelefone.Size = new System.Drawing.Size(85, 24);
            labelUpdTelefone.TabIndex = 11;
            labelUpdTelefone.Text = "Telefone";
            // 
            // labelUpdObservacoes
            // 
            labelUpdObservacoes.AutoSize = true;
            labelUpdObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdObservacoes.Location = new System.Drawing.Point(46, 196);
            labelUpdObservacoes.Name = "labelUpdObservacoes";
            labelUpdObservacoes.Size = new System.Drawing.Size(122, 24);
            labelUpdObservacoes.TabIndex = 10;
            labelUpdObservacoes.Text = "Observações";
            // 
            // textBoxUpdObservacao
            // 
            this.textBoxUpdObservacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "observacao", true));
            this.textBoxUpdObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdObservacao.Location = new System.Drawing.Point(50, 223);
            this.textBoxUpdObservacao.Name = "textBoxUpdObservacao";
            this.textBoxUpdObservacao.Size = new System.Drawing.Size(1054, 29);
            this.textBoxUpdObservacao.TabIndex = 37;
            // 
            // labelUpdRG
            // 
            labelUpdRG.AutoSize = true;
            labelUpdRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdRG.Location = new System.Drawing.Point(228, 116);
            labelUpdRG.Name = "labelUpdRG";
            labelUpdRG.Size = new System.Drawing.Size(37, 24);
            labelUpdRG.TabIndex = 8;
            labelUpdRG.Text = "RG";
            // 
            // labelUpdCPF
            // 
            labelUpdCPF.AutoSize = true;
            labelUpdCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdCPF.Location = new System.Drawing.Point(46, 116);
            labelUpdCPF.Name = "labelUpdCPF";
            labelUpdCPF.Size = new System.Drawing.Size(47, 24);
            labelUpdCPF.TabIndex = 5;
            labelUpdCPF.Text = "CPF";
            // 
            // labelUpdNascimento
            // 
            labelUpdNascimento.AutoSize = true;
            labelUpdNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNascimento.Location = new System.Drawing.Point(692, 35);
            labelUpdNascimento.Name = "labelUpdNascimento";
            labelUpdNascimento.Size = new System.Drawing.Size(110, 24);
            labelUpdNascimento.TabIndex = 3;
            labelUpdNascimento.Text = "Nascimento";
            // 
            // labelUpdNomeCompleto
            // 
            labelUpdNomeCompleto.AutoSize = true;
            labelUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNomeCompleto.Location = new System.Drawing.Point(46, 35);
            labelUpdNomeCompleto.Name = "labelUpdNomeCompleto";
            labelUpdNomeCompleto.Size = new System.Drawing.Size(148, 24);
            labelUpdNomeCompleto.TabIndex = 1;
            labelUpdNomeCompleto.Text = "Nome Completo";
            // 
            // textBoxUpdNomeCompleto
            // 
            this.textBoxUpdNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nomePaciente", true));
            this.textBoxUpdNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNomeCompleto.Location = new System.Drawing.Point(50, 62);
            this.textBoxUpdNomeCompleto.Name = "textBoxUpdNomeCompleto";
            this.textBoxUpdNomeCompleto.Size = new System.Drawing.Size(635, 29);
            this.textBoxUpdNomeCompleto.TabIndex = 30;
            // 
            // textBoxUpdRG
            // 
            this.textBoxUpdRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "rg", true));
            this.textBoxUpdRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdRG.Location = new System.Drawing.Point(232, 143);
            this.textBoxUpdRG.Name = "textBoxUpdRG";
            this.textBoxUpdRG.Size = new System.Drawing.Size(170, 29);
            this.textBoxUpdRG.TabIndex = 34;
            // 
            // maskUpdCPF
            // 
            this.maskUpdCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cpf", true));
            this.maskUpdCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdCPF.Location = new System.Drawing.Point(50, 143);
            this.maskUpdCPF.Mask = "000.000.000-00";
            this.maskUpdCPF.Name = "maskUpdCPF";
            this.maskUpdCPF.Size = new System.Drawing.Size(170, 29);
            this.maskUpdCPF.TabIndex = 33;
            // 
            // panelUpdEndereco
            // 
            this.panelUpdEndereco.Controls.Add(this.textBoxUpdEstado);
            this.panelUpdEndereco.Controls.Add(this.textBoxUpdCidade);
            this.panelUpdEndereco.Controls.Add(labelUpdComplemento);
            this.panelUpdEndereco.Controls.Add(this.textBoxUpdComplemento);
            this.panelUpdEndereco.Controls.Add(this.maskUpdCEP);
            this.panelUpdEndereco.Controls.Add(labelUpdNumero);
            this.panelUpdEndereco.Controls.Add(this.textBoxUpdNumero);
            this.panelUpdEndereco.Controls.Add(labelUpdCEP);
            this.panelUpdEndereco.Controls.Add(labelUpdBairro);
            this.panelUpdEndereco.Controls.Add(this.textBoxUpdBairro);
            this.panelUpdEndereco.Controls.Add(labelUpdEstado);
            this.panelUpdEndereco.Controls.Add(labelUpdCidade);
            this.panelUpdEndereco.Controls.Add(labelUpdEndereco);
            this.panelUpdEndereco.Controls.Add(this.textBoxUpdEndereco);
            this.panelUpdEndereco.Location = new System.Drawing.Point(1160, 0);
            this.panelUpdEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdEndereco.Name = "panelUpdEndereco";
            this.panelUpdEndereco.Size = new System.Drawing.Size(1160, 330);
            this.panelUpdEndereco.TabIndex = 1;
            this.panelUpdEndereco.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdEndereco_Paint);
            // 
            // textBoxUpdEstado
            // 
            this.textBoxUpdEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "estado", true));
            this.textBoxUpdEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdEstado.Location = new System.Drawing.Point(351, 225);
            this.textBoxUpdEstado.Name = "textBoxUpdEstado";
            this.textBoxUpdEstado.Size = new System.Drawing.Size(290, 29);
            this.textBoxUpdEstado.TabIndex = 44;
            // 
            // textBoxUpdCidade
            // 
            this.textBoxUpdCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cidade", true));
            this.textBoxUpdCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdCidade.Location = new System.Drawing.Point(50, 225);
            this.textBoxUpdCidade.Name = "textBoxUpdCidade";
            this.textBoxUpdCidade.Size = new System.Drawing.Size(290, 29);
            this.textBoxUpdCidade.TabIndex = 43;
            // 
            // labelUpdComplemento
            // 
            labelUpdComplemento.AutoSize = true;
            labelUpdComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdComplemento.Location = new System.Drawing.Point(347, 114);
            labelUpdComplemento.Name = "labelUpdComplemento";
            labelUpdComplemento.Size = new System.Drawing.Size(129, 24);
            labelUpdComplemento.TabIndex = 18;
            labelUpdComplemento.Text = "Complemento";
            // 
            // textBoxUpdComplemento
            // 
            this.textBoxUpdComplemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "complemento", true));
            this.textBoxUpdComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdComplemento.Location = new System.Drawing.Point(351, 141);
            this.textBoxUpdComplemento.Name = "textBoxUpdComplemento";
            this.textBoxUpdComplemento.Size = new System.Drawing.Size(662, 29);
            this.textBoxUpdComplemento.TabIndex = 42;
            // 
            // maskUpdCEP
            // 
            this.maskUpdCEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cep", true));
            this.maskUpdCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdCEP.Location = new System.Drawing.Point(50, 59);
            this.maskUpdCEP.Mask = "00000-000";
            this.maskUpdCEP.Name = "maskUpdCEP";
            this.maskUpdCEP.Size = new System.Drawing.Size(170, 29);
            this.maskUpdCEP.TabIndex = 38;
            // 
            // labelUpdNumero
            // 
            labelUpdNumero.AutoSize = true;
            labelUpdNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNumero.Location = new System.Drawing.Point(862, 32);
            labelUpdNumero.Name = "labelUpdNumero";
            labelUpdNumero.Size = new System.Drawing.Size(79, 24);
            labelUpdNumero.TabIndex = 15;
            labelUpdNumero.Text = "Numero";
            // 
            // textBoxUpdNumero
            // 
            this.textBoxUpdNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "numero", true));
            this.textBoxUpdNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNumero.Location = new System.Drawing.Point(866, 59);
            this.textBoxUpdNumero.Name = "textBoxUpdNumero";
            this.textBoxUpdNumero.Size = new System.Drawing.Size(160, 29);
            this.textBoxUpdNumero.TabIndex = 40;
            // 
            // labelUpdCEP
            // 
            labelUpdCEP.AutoSize = true;
            labelUpdCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdCEP.Location = new System.Drawing.Point(46, 33);
            labelUpdCEP.Name = "labelUpdCEP";
            labelUpdCEP.Size = new System.Drawing.Size(48, 24);
            labelUpdCEP.TabIndex = 13;
            labelUpdCEP.Text = "CEP";
            // 
            // labelUpdBairro
            // 
            labelUpdBairro.AutoSize = true;
            labelUpdBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdBairro.Location = new System.Drawing.Point(46, 114);
            labelUpdBairro.Name = "labelUpdBairro";
            labelUpdBairro.Size = new System.Drawing.Size(59, 24);
            labelUpdBairro.TabIndex = 11;
            labelUpdBairro.Text = "Bairro";
            // 
            // textBoxUpdBairro
            // 
            this.textBoxUpdBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "bairro", true));
            this.textBoxUpdBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdBairro.Location = new System.Drawing.Point(50, 141);
            this.textBoxUpdBairro.Name = "textBoxUpdBairro";
            this.textBoxUpdBairro.Size = new System.Drawing.Size(290, 29);
            this.textBoxUpdBairro.TabIndex = 41;
            // 
            // labelUpdEstado
            // 
            labelUpdEstado.AutoSize = true;
            labelUpdEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdEstado.Location = new System.Drawing.Point(347, 197);
            labelUpdEstado.Name = "labelUpdEstado";
            labelUpdEstado.Size = new System.Drawing.Size(68, 24);
            labelUpdEstado.TabIndex = 7;
            labelUpdEstado.Text = "Estado";
            // 
            // labelUpdCidade
            // 
            labelUpdCidade.AutoSize = true;
            labelUpdCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdCidade.Location = new System.Drawing.Point(46, 197);
            labelUpdCidade.Name = "labelUpdCidade";
            labelUpdCidade.Size = new System.Drawing.Size(70, 24);
            labelUpdCidade.TabIndex = 5;
            labelUpdCidade.Text = "Cidade";
            // 
            // labelUpdEndereco
            // 
            labelUpdEndereco.AutoSize = true;
            labelUpdEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdEndereco.Location = new System.Drawing.Point(228, 32);
            labelUpdEndereco.Name = "labelUpdEndereco";
            labelUpdEndereco.Size = new System.Drawing.Size(99, 24);
            labelUpdEndereco.TabIndex = 3;
            labelUpdEndereco.Text = "Endereço ";
            // 
            // textBoxUpdEndereco
            // 
            this.textBoxUpdEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "endereco", true));
            this.textBoxUpdEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdEndereco.Location = new System.Drawing.Point(232, 59);
            this.textBoxUpdEndereco.Name = "textBoxUpdEndereco";
            this.textBoxUpdEndereco.Size = new System.Drawing.Size(625, 29);
            this.textBoxUpdEndereco.TabIndex = 39;
            // 
            // panelUpdDadosFamiliares
            // 
            this.panelUpdDadosFamiliares.Controls.Add(labelUpdObservacaoFamiliares);
            this.panelUpdDadosFamiliares.Controls.Add(labelUpdVinculo);
            this.panelUpdDadosFamiliares.Controls.Add(this.textBoxUpdVinculo);
            this.panelUpdDadosFamiliares.Controls.Add(labelUpdNomeFamiliar);
            this.panelUpdDadosFamiliares.Controls.Add(this.textBoxUpdNomeFamiliar);
            this.panelUpdDadosFamiliares.Controls.Add(this.maskUpdTelefoneFamiliar);
            this.panelUpdDadosFamiliares.Controls.Add(labelUpdTelefoneFamiliar);
            this.panelUpdDadosFamiliares.Controls.Add(labelUpdParentesco);
            this.panelUpdDadosFamiliares.Controls.Add(this.textBoxUpdParentesco);
            this.panelUpdDadosFamiliares.Controls.Add(this.textBoxUpdObservacaoFamiliares);
            this.panelUpdDadosFamiliares.Location = new System.Drawing.Point(2320, 0);
            this.panelUpdDadosFamiliares.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdDadosFamiliares.Name = "panelUpdDadosFamiliares";
            this.panelUpdDadosFamiliares.Size = new System.Drawing.Size(1160, 330);
            this.panelUpdDadosFamiliares.TabIndex = 16;
            this.panelUpdDadosFamiliares.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdDadosFamiliares_Paint);
            // 
            // labelUpdObservacaoFamiliares
            // 
            labelUpdObservacaoFamiliares.AutoSize = true;
            labelUpdObservacaoFamiliares.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdObservacaoFamiliares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdObservacaoFamiliares.Location = new System.Drawing.Point(46, 194);
            labelUpdObservacaoFamiliares.Name = "labelUpdObservacaoFamiliares";
            labelUpdObservacaoFamiliares.Size = new System.Drawing.Size(112, 24);
            labelUpdObservacaoFamiliares.TabIndex = 22;
            labelUpdObservacaoFamiliares.Text = "Observação";
            // 
            // labelUpdVinculo
            // 
            labelUpdVinculo.AutoSize = true;
            labelUpdVinculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdVinculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdVinculo.Location = new System.Drawing.Point(329, 114);
            labelUpdVinculo.Name = "labelUpdVinculo";
            labelUpdVinculo.Size = new System.Drawing.Size(74, 24);
            labelUpdVinculo.TabIndex = 20;
            labelUpdVinculo.Text = "Vinculo";
            // 
            // textBoxUpdVinculo
            // 
            this.textBoxUpdVinculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadosComplementaresBindingSource, "vinculo", true));
            this.textBoxUpdVinculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdVinculo.Location = new System.Drawing.Point(333, 141);
            this.textBoxUpdVinculo.Name = "textBoxUpdVinculo";
            this.textBoxUpdVinculo.Size = new System.Drawing.Size(270, 29);
            this.textBoxUpdVinculo.TabIndex = 47;
            // 
            // dadosComplementaresBindingSource
            // 
            this.dadosComplementaresBindingSource.DataMember = "DadosComplementares";
            this.dadosComplementaresBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // labelUpdNomeFamiliar
            // 
            labelUpdNomeFamiliar.AutoSize = true;
            labelUpdNomeFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomeFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdNomeFamiliar.Location = new System.Drawing.Point(46, 33);
            labelUpdNomeFamiliar.Name = "labelUpdNomeFamiliar";
            labelUpdNomeFamiliar.Size = new System.Drawing.Size(133, 24);
            labelUpdNomeFamiliar.TabIndex = 16;
            labelUpdNomeFamiliar.Text = "Nome Familiar";
            // 
            // textBoxUpdNomeFamiliar
            // 
            this.textBoxUpdNomeFamiliar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadosComplementaresBindingSource, "nome", true));
            this.textBoxUpdNomeFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNomeFamiliar.Location = new System.Drawing.Point(50, 61);
            this.textBoxUpdNomeFamiliar.Name = "textBoxUpdNomeFamiliar";
            this.textBoxUpdNomeFamiliar.Size = new System.Drawing.Size(778, 29);
            this.textBoxUpdNomeFamiliar.TabIndex = 45;
            // 
            // maskUpdTelefoneFamiliar
            // 
            this.maskUpdTelefoneFamiliar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadosComplementaresBindingSource, "telefone", true));
            this.maskUpdTelefoneFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdTelefoneFamiliar.Location = new System.Drawing.Point(616, 141);
            this.maskUpdTelefoneFamiliar.Mask = "(00) 0 0000-0000";
            this.maskUpdTelefoneFamiliar.Name = "maskUpdTelefoneFamiliar";
            this.maskUpdTelefoneFamiliar.Size = new System.Drawing.Size(212, 29);
            this.maskUpdTelefoneFamiliar.TabIndex = 48;
            // 
            // labelUpdTelefoneFamiliar
            // 
            labelUpdTelefoneFamiliar.AutoSize = true;
            labelUpdTelefoneFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdTelefoneFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdTelefoneFamiliar.Location = new System.Drawing.Point(612, 114);
            labelUpdTelefoneFamiliar.Name = "labelUpdTelefoneFamiliar";
            labelUpdTelefoneFamiliar.Size = new System.Drawing.Size(85, 24);
            labelUpdTelefoneFamiliar.TabIndex = 13;
            labelUpdTelefoneFamiliar.Text = "Telefone";
            // 
            // labelUpdParentesco
            // 
            labelUpdParentesco.AutoSize = true;
            labelUpdParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdParentesco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelUpdParentesco.Location = new System.Drawing.Point(46, 114);
            labelUpdParentesco.Name = "labelUpdParentesco";
            labelUpdParentesco.Size = new System.Drawing.Size(105, 24);
            labelUpdParentesco.TabIndex = 18;
            labelUpdParentesco.Text = "Parentesco";
            // 
            // textBoxUpdParentesco
            // 
            this.textBoxUpdParentesco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadosComplementaresBindingSource, "parentesco", true));
            this.textBoxUpdParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdParentesco.Location = new System.Drawing.Point(50, 141);
            this.textBoxUpdParentesco.Name = "textBoxUpdParentesco";
            this.textBoxUpdParentesco.Size = new System.Drawing.Size(270, 29);
            this.textBoxUpdParentesco.TabIndex = 46;
            // 
            // textBoxUpdObservacaoFamiliares
            // 
            this.textBoxUpdObservacaoFamiliares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadosComplementaresBindingSource, "observacao", true));
            this.textBoxUpdObservacaoFamiliares.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdObservacaoFamiliares.Location = new System.Drawing.Point(50, 221);
            this.textBoxUpdObservacaoFamiliares.Name = "textBoxUpdObservacaoFamiliares";
            this.textBoxUpdObservacaoFamiliares.Size = new System.Drawing.Size(778, 29);
            this.textBoxUpdObservacaoFamiliares.TabIndex = 49;
            // 
            // panelUpdAbas
            // 
            panelUpdAbas.Controls.Add(this.btnUpdDadosFamiliares);
            panelUpdAbas.Controls.Add(this.btnUpdEndereco);
            panelUpdAbas.Controls.Add(this.btnUpdDadosPessoais);
            panelUpdAbas.Dock = System.Windows.Forms.DockStyle.Top;
            panelUpdAbas.Location = new System.Drawing.Point(0, 0);
            panelUpdAbas.Margin = new System.Windows.Forms.Padding(0);
            panelUpdAbas.Name = "panelUpdAbas";
            panelUpdAbas.Size = new System.Drawing.Size(1160, 40);
            panelUpdAbas.TabIndex = 0;
            // 
            // btnUpdDadosFamiliares
            // 
            this.btnUpdDadosFamiliares.FlatAppearance.BorderSize = 0;
            this.btnUpdDadosFamiliares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdDadosFamiliares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdDadosFamiliares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnUpdDadosFamiliares.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdDadosFamiliares.Image")));
            this.btnUpdDadosFamiliares.Location = new System.Drawing.Point(319, 0);
            this.btnUpdDadosFamiliares.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdDadosFamiliares.Name = "btnUpdDadosFamiliares";
            this.btnUpdDadosFamiliares.Size = new System.Drawing.Size(232, 40);
            this.btnUpdDadosFamiliares.TabIndex = 2;
            this.btnUpdDadosFamiliares.Text = "  Dados Familiar (Opcional)";
            this.btnUpdDadosFamiliares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdDadosFamiliares.UseVisualStyleBackColor = true;
            this.btnUpdDadosFamiliares.Click += new System.EventHandler(this.btnUpdDadosFamiliares_Click);
            // 
            // btnUpdEndereco
            // 
            this.btnUpdEndereco.FlatAppearance.BorderSize = 0;
            this.btnUpdEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnUpdEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdEndereco.Image")));
            this.btnUpdEndereco.Location = new System.Drawing.Point(159, 0);
            this.btnUpdEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdEndereco.Name = "btnUpdEndereco";
            this.btnUpdEndereco.Size = new System.Drawing.Size(160, 40);
            this.btnUpdEndereco.TabIndex = 1;
            this.btnUpdEndereco.Text = "  Endereço";
            this.btnUpdEndereco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdEndereco.UseVisualStyleBackColor = true;
            this.btnUpdEndereco.Click += new System.EventHandler(this.btnUpdEndereco_Click);
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
            this.btnUpdDadosPessoais.Size = new System.Drawing.Size(159, 40);
            this.btnUpdDadosPessoais.TabIndex = 0;
            this.btnUpdDadosPessoais.Text = " Dados Pessoais";
            this.btnUpdDadosPessoais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdDadosPessoais.UseVisualStyleBackColor = false;
            this.btnUpdDadosPessoais.Click += new System.EventHandler(this.btnUpdDadosPessoais_Click);
            // 
            // labelUpdTitulo
            // 
            labelUpdTitulo.AutoSize = true;
            labelUpdTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdTitulo.Location = new System.Drawing.Point(17, 9);
            labelUpdTitulo.Name = "labelUpdTitulo";
            labelUpdTitulo.Size = new System.Drawing.Size(136, 24);
            labelUpdTitulo.TabIndex = 13;
            labelUpdTitulo.Text = "Editar Paciente";
            // 
            // labelUpdLinhaTitulo
            // 
            labelUpdLinhaTitulo.AutoSize = true;
            labelUpdLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdLinhaTitulo.Location = new System.Drawing.Point(17, 15);
            labelUpdLinhaTitulo.Name = "labelUpdLinhaTitulo";
            labelUpdLinhaTitulo.Size = new System.Drawing.Size(1120, 24);
            labelUpdLinhaTitulo.TabIndex = 14;
            labelUpdLinhaTitulo.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // labelSelecioneProduto
            // 
            labelSelecioneProduto.AutoSize = true;
            labelSelecioneProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            labelSelecioneProduto.ForeColor = System.Drawing.SystemColors.Control;
            labelSelecioneProduto.Location = new System.Drawing.Point(23, 6);
            labelSelecioneProduto.Name = "labelSelecioneProduto";
            labelSelecioneProduto.Size = new System.Drawing.Size(612, 22);
            labelSelecioneProduto.TabIndex = 50;
            labelSelecioneProduto.Text = "Selecione um nome para ver a Ficha, Editar, Vizualizar ou Excluir Cadastro:";
            labelSelecioneProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaSelecione
            // 
            labelLinhaSelecione.AutoSize = true;
            labelLinhaSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaSelecione.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaSelecione.Location = new System.Drawing.Point(23, 11);
            labelLinhaSelecione.Name = "labelLinhaSelecione";
            labelLinhaSelecione.Size = new System.Drawing.Size(1110, 24);
            labelLinhaSelecione.TabIndex = 51;
            labelLinhaSelecione.Text = "_________________________________________________________________________________" +
    "_____________________________";
            // 
            // panelCadTitulo
            // 
            this.panelCadTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelCadTitulo.Controls.Add(labelCadTitulo);
            this.panelCadTitulo.Controls.Add(labelCadLinhaTitulo);
            this.panelCadTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelCadTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelCadTitulo.Name = "panelCadTitulo";
            this.panelCadTitulo.Size = new System.Drawing.Size(1160, 44);
            this.panelCadTitulo.TabIndex = 42;
            this.panelCadTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadTitulo_Paint);
            // 
            // panelCadOpcoes
            // 
            this.panelCadOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelCadOpcoes.Controls.Add(this.btnSalvar);
            this.panelCadOpcoes.Controls.Add(this.btnSair);
            this.panelCadOpcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCadOpcoes.Location = new System.Drawing.Point(0, 431);
            this.panelCadOpcoes.Name = "panelCadOpcoes";
            this.panelCadOpcoes.Size = new System.Drawing.Size(1160, 49);
            this.panelCadOpcoes.TabIndex = 43;
            this.panelCadOpcoes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadOpcoes_Paint);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(416, 9);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 35);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(582, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(160, 35);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Voltar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelUpdOpcoes
            // 
            this.panelUpdOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelUpdOpcoes.Controls.Add(this.btnSavalEditar);
            this.panelUpdOpcoes.Controls.Add(this.btnSairEditar);
            this.panelUpdOpcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpdOpcoes.Location = new System.Drawing.Point(0, 431);
            this.panelUpdOpcoes.Name = "panelUpdOpcoes";
            this.panelUpdOpcoes.Size = new System.Drawing.Size(1160, 49);
            this.panelUpdOpcoes.TabIndex = 46;
            this.panelUpdOpcoes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdOpcoes_Paint);
            // 
            // btnSavalEditar
            // 
            this.btnSavalEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnSavalEditar.FlatAppearance.BorderSize = 0;
            this.btnSavalEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavalEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSavalEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSavalEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnSavalEditar.Image")));
            this.btnSavalEditar.Location = new System.Drawing.Point(416, 9);
            this.btnSavalEditar.Name = "btnSavalEditar";
            this.btnSavalEditar.Size = new System.Drawing.Size(160, 35);
            this.btnSavalEditar.TabIndex = 37;
            this.btnSavalEditar.Text = "Salvar";
            this.btnSavalEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavalEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavalEditar.UseVisualStyleBackColor = false;
            this.btnSavalEditar.Click += new System.EventHandler(this.btnSavalEditar_Click);
            // 
            // btnSairEditar
            // 
            this.btnSairEditar.BackColor = System.Drawing.Color.Firebrick;
            this.btnSairEditar.FlatAppearance.BorderSize = 0;
            this.btnSairEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSairEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnSairEditar.Image")));
            this.btnSairEditar.Location = new System.Drawing.Point(582, 9);
            this.btnSairEditar.Name = "btnSairEditar";
            this.btnSairEditar.Size = new System.Drawing.Size(160, 35);
            this.btnSairEditar.TabIndex = 38;
            this.btnSairEditar.Text = "Voltar";
            this.btnSairEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairEditar.UseVisualStyleBackColor = false;
            this.btnSairEditar.Click += new System.EventHandler(this.btnSairEditar_Click);
            // 
            // panelUpdTitulo
            // 
            this.panelUpdTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelUpdTitulo.Controls.Add(labelUpdTitulo);
            this.panelUpdTitulo.Controls.Add(labelUpdLinhaTitulo);
            this.panelUpdTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelUpdTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdTitulo.Name = "panelUpdTitulo";
            this.panelUpdTitulo.Size = new System.Drawing.Size(1160, 44);
            this.panelUpdTitulo.TabIndex = 45;
            this.panelUpdTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpdTitulo_Paint);
            // 
            // panelConsultarPaciente
            // 
            this.panelConsultarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarPaciente.Controls.Add(labelSelecioneProduto);
            this.panelConsultarPaciente.Controls.Add(labelLinhaSelecione);
            this.panelConsultarPaciente.Controls.Add(this.dataGridViewPacientes);
            this.panelConsultarPaciente.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarPaciente.Name = "panelConsultarPaciente";
            this.panelConsultarPaciente.Size = new System.Drawing.Size(1160, 523);
            this.panelConsultarPaciente.TabIndex = 6;
            this.panelConsultarPaciente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultarPaciente_Paint);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToAddRows = false;
            this.dataGridViewPacientes.AllowUserToDeleteRows = false;
            this.dataGridViewPacientes.AllowUserToResizeColumns = false;
            this.dataGridViewPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPacientes.AutoGenerateColumns = false;
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacienteDataGridViewTextBoxColumn,
            this.nomePacienteDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoBiologicoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.telefonePrincipalDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.codigoLogDataGridViewTextBoxColumn});
            this.dataGridViewPacientes.DataSource = this.pacienteBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPacientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPacientes.EnableHeadersVisualStyles = false;
            this.dataGridViewPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewPacientes.Location = new System.Drawing.Point(27, 42);
            this.dataGridViewPacientes.MultiSelect = false;
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPacientes.RowHeadersVisible = false;
            this.dataGridViewPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewPacientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPacientes.RowTemplate.Height = 30;
            this.dataGridViewPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(1102, 451);
            this.dataGridViewPacientes.TabIndex = 16;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomePacienteDataGridViewTextBoxColumn
            // 
            this.nomePacienteDataGridViewTextBoxColumn.DataPropertyName = "nomePaciente";
            this.nomePacienteDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente";
            this.nomePacienteDataGridViewTextBoxColumn.Name = "nomePacienteDataGridViewTextBoxColumn";
            this.nomePacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomePacienteDataGridViewTextBoxColumn.Width = 601;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dataNascimento";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataNascimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 250;
            // 
            // sexoBiologicoDataGridViewTextBoxColumn
            // 
            this.sexoBiologicoDataGridViewTextBoxColumn.DataPropertyName = "sexoBiologico";
            this.sexoBiologicoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoBiologicoDataGridViewTextBoxColumn.Name = "sexoBiologicoDataGridViewTextBoxColumn";
            this.sexoBiologicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoBiologicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            this.rgDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonePrincipalDataGridViewTextBoxColumn
            // 
            this.telefonePrincipalDataGridViewTextBoxColumn.DataPropertyName = "telefonePrincipal";
            this.telefonePrincipalDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefonePrincipalDataGridViewTextBoxColumn.Name = "telefonePrincipalDataGridViewTextBoxColumn";
            this.telefonePrincipalDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonePrincipalDataGridViewTextBoxColumn.Width = 250;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            this.cepDataGridViewTextBoxColumn.Visible = false;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            this.complementoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoLogDataGridViewTextBoxColumn
            // 
            this.codigoLogDataGridViewTextBoxColumn.DataPropertyName = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.HeaderText = "codigoLog";
            this.codigoLogDataGridViewTextBoxColumn.Name = "codigoLogDataGridViewTextBoxColumn";
            this.codigoLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnVizualizarCadastro);
            this.panelMenu.Controls.Add(this.btnExcluirCadastro);
            this.panelMenu.Controls.Add(this.btnEditarCadastro);
            this.panelMenu.Controls.Add(this.btnFichaAcompanhamento);
            this.panelMenu.Controls.Add(this.btnPesquisar);
            this.panelMenu.Controls.Add(this.btnNovoPaciente);
            this.panelMenu.Controls.Add(label6);
            this.panelMenu.Controls.Add(this.textBoxPesquisarNome);
            this.panelMenu.Controls.Add(this.labelContagem);
            this.panelMenu.Controls.Add(this.label11);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(10, 11);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1160, 152);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
            this.btnVizualizarCadastro.Location = new System.Drawing.Point(449, 108);
            this.btnVizualizarCadastro.Name = "btnVizualizarCadastro";
            this.btnVizualizarCadastro.Size = new System.Drawing.Size(183, 35);
            this.btnVizualizarCadastro.TabIndex = 35;
            this.btnVizualizarCadastro.Text = " Vizualizar Cadastro";
            this.btnVizualizarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVizualizarCadastro.UseVisualStyleBackColor = false;
            this.btnVizualizarCadastro.Click += new System.EventHandler(this.btnVizualizarCadastro_Click);
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
            this.btnExcluirCadastro.Location = new System.Drawing.Point(815, 108);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(158, 35);
            this.btnExcluirCadastro.TabIndex = 37;
            this.btnExcluirCadastro.Text = " Excluir Cadastro";
            this.btnExcluirCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
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
            this.btnEditarCadastro.Location = new System.Drawing.Point(643, 108);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(161, 35);
            this.btnEditarCadastro.TabIndex = 36;
            this.btnEditarCadastro.Text = " Editar Cadastro";
            this.btnEditarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCadastro.UseVisualStyleBackColor = false;
            this.btnEditarCadastro.Click += new System.EventHandler(this.btnEditarCadastro_Click);
            // 
            // btnFichaAcompanhamento
            // 
            this.btnFichaAcompanhamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnFichaAcompanhamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFichaAcompanhamento.FlatAppearance.BorderSize = 0;
            this.btnFichaAcompanhamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaAcompanhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFichaAcompanhamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFichaAcompanhamento.Image = ((System.Drawing.Image)(resources.GetObject("btnFichaAcompanhamento.Image")));
            this.btnFichaAcompanhamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaAcompanhamento.Location = new System.Drawing.Point(189, 108);
            this.btnFichaAcompanhamento.Name = "btnFichaAcompanhamento";
            this.btnFichaAcompanhamento.Size = new System.Drawing.Size(248, 35);
            this.btnFichaAcompanhamento.TabIndex = 34;
            this.btnFichaAcompanhamento.Text = " Ficha de Acompanhamento";
            this.btnFichaAcompanhamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFichaAcompanhamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFichaAcompanhamento.UseVisualStyleBackColor = false;
            this.btnFichaAcompanhamento.Click += new System.EventHandler(this.btnFichaAcompanhamento_Click);
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
            this.btnPesquisar.Location = new System.Drawing.Point(729, 64);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(139, 28);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.Text = "   Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovoPaciente
            // 
            this.btnNovoPaciente.BackColor = System.Drawing.Color.Teal;
            this.btnNovoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoPaciente.FlatAppearance.BorderSize = 0;
            this.btnNovoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNovoPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoPaciente.Image")));
            this.btnNovoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoPaciente.Location = new System.Drawing.Point(32, 108);
            this.btnNovoPaciente.Name = "btnNovoPaciente";
            this.btnNovoPaciente.Size = new System.Drawing.Size(146, 35);
            this.btnNovoPaciente.TabIndex = 30;
            this.btnNovoPaciente.Text = "Novo Paciente";
            this.btnNovoPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoPaciente.UseVisualStyleBackColor = false;
            this.btnNovoPaciente.Click += new System.EventHandler(this.btnNovoPaciente_Click);
            // 
            // textBoxPesquisarNome
            // 
            this.textBoxPesquisarNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPesquisarNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxPesquisarNome.Location = new System.Drawing.Point(32, 65);
            this.textBoxPesquisarNome.Name = "textBoxPesquisarNome";
            this.textBoxPesquisarNome.Size = new System.Drawing.Size(691, 27);
            this.textBoxPesquisarNome.TabIndex = 27;
            this.textBoxPesquisarNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisarNome_KeyDown);
            // 
            // labelContagem
            // 
            this.labelContagem.AutoSize = true;
            this.labelContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelContagem.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContagem.Location = new System.Drawing.Point(980, 9);
            this.labelContagem.Name = "labelContagem";
            this.labelContagem.Size = new System.Drawing.Size(158, 24);
            this.labelContagem.TabIndex = 12;
            this.labelContagem.Text = "Total: N Registros";
            this.labelContagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(23, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "Pacientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1116, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // containerPai
            // 
            this.containerPai.Controls.Add(this.panelMenu);
            this.containerPai.Controls.Add(this.flpContainerPai);
            this.containerPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPai.Location = new System.Drawing.Point(0, 0);
            this.containerPai.Name = "containerPai";
            this.containerPai.Size = new System.Drawing.Size(1178, 706);
            this.containerPai.TabIndex = 7;
            // 
            // flpContainerPai
            // 
            this.flpContainerPai.AutoScroll = true;
            this.flpContainerPai.Controls.Add(this.panelConsultarPaciente);
            this.flpContainerPai.Controls.Add(this.panelNovoCadastro);
            this.flpContainerPai.Controls.Add(this.panelEditarCadastro);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(10, 173);
            this.flpContainerPai.Margin = new System.Windows.Forms.Padding(0);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(1160, 523);
            this.flpContainerPai.TabIndex = 7;
            this.flpContainerPai.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContainerPai_Paint);
            // 
            // panelNovoCadastro
            // 
            this.panelNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelNovoCadastro.Controls.Add(panelCadPai);
            this.panelNovoCadastro.Controls.Add(this.panelCadOpcoes);
            this.panelNovoCadastro.Controls.Add(this.panelCadTitulo);
            this.panelNovoCadastro.Location = new System.Drawing.Point(1160, 0);
            this.panelNovoCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelNovoCadastro.Name = "panelNovoCadastro";
            this.panelNovoCadastro.Size = new System.Drawing.Size(1160, 480);
            this.panelNovoCadastro.TabIndex = 17;
            this.panelNovoCadastro.Visible = false;
            // 
            // panelEditarCadastro
            // 
            this.panelEditarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelEditarCadastro.Controls.Add(panelUpdPai);
            this.panelEditarCadastro.Controls.Add(this.panelUpdOpcoes);
            this.panelEditarCadastro.Controls.Add(this.panelUpdTitulo);
            this.panelEditarCadastro.Location = new System.Drawing.Point(2320, 0);
            this.panelEditarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditarCadastro.Name = "panelEditarCadastro";
            this.panelEditarCadastro.Size = new System.Drawing.Size(1160, 480);
            this.panelEditarCadastro.TabIndex = 18;
            this.panelEditarCadastro.Visible = false;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // dadosComplementaresTableAdapter
            // 
            this.dadosComplementaresTableAdapter.ClearBeforeFill = true;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1178, 706);
            this.Controls.Add(this.containerPai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPacientes_FormClosing);
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            panelCadPai.ResumeLayout(false);
            flpCadastroPaciente.ResumeLayout(false);
            this.panelCadDadosPessoais.ResumeLayout(false);
            this.panelCadDadosPessoais.PerformLayout();
            this.panelCadEndereco.ResumeLayout(false);
            this.panelCadEndereco.PerformLayout();
            this.panelCadDadosFamiliar.ResumeLayout(false);
            this.panelCadDadosFamiliar.PerformLayout();
            panelCadAbas.ResumeLayout(false);
            panelUpdPai.ResumeLayout(false);
            flpEditarPaciente.ResumeLayout(false);
            this.panelUpdDadosPessoais.ResumeLayout(false);
            this.panelUpdDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).EndInit();
            this.panelUpdEndereco.ResumeLayout(false);
            this.panelUpdEndereco.PerformLayout();
            this.panelUpdDadosFamiliares.ResumeLayout(false);
            this.panelUpdDadosFamiliares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosComplementaresBindingSource)).EndInit();
            panelUpdAbas.ResumeLayout(false);
            this.panelCadTitulo.ResumeLayout(false);
            this.panelCadTitulo.PerformLayout();
            this.panelCadOpcoes.ResumeLayout(false);
            this.panelUpdOpcoes.ResumeLayout(false);
            this.panelUpdTitulo.ResumeLayout(false);
            this.panelUpdTitulo.PerformLayout();
            this.panelConsultarPaciente.ResumeLayout(false);
            this.panelConsultarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.containerPai.ResumeLayout(false);
            this.flpContainerPai.ResumeLayout(false);
            this.panelNovoCadastro.ResumeLayout(false);
            this.panelEditarCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarPaciente;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelContagem;
        private System.Windows.Forms.TextBox textBoxPesquisarNome;
        private System.Windows.Forms.Button btnNovoPaciente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFichaAcompanhamento;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Panel containerPai;
        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelNovoCadastro;
        private System.Windows.Forms.Panel panelEditarCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelCadDadosPessoais;
        private System.Windows.Forms.TextBox textBoxCadEmail;
        private System.Windows.Forms.MaskedTextBox maskCadTelefone;
        private System.Windows.Forms.TextBox textBoxCadObservacao;
        private System.Windows.Forms.TextBox textBoxCadRG;
        private System.Windows.Forms.MaskedTextBox maskCadCPF;
        private System.Windows.Forms.TextBox textBoxCadNomeCompleto;
        private System.Windows.Forms.Panel panelCadEndereco;
        private System.Windows.Forms.TextBox textBoxCadBairro;
        private System.Windows.Forms.TextBox textBoxCadEndereco;
        private System.Windows.Forms.Panel panelCadDadosFamiliar;
        private System.Windows.Forms.Button btnCadDadosFamiliares;
        private System.Windows.Forms.Button btnCadEndereco;
        private System.Windows.Forms.Button btnCadDadosPessoais;
        private System.Windows.Forms.ComboBox comboBoxCadSexo;
        private System.Windows.Forms.MaskedTextBox maskCadCEP;
        private System.Windows.Forms.TextBox textBoxCadNumero;
        private System.Windows.Forms.TextBox textBoxCadEstado;
        private System.Windows.Forms.TextBox textBoxCadCidade;
        private System.Windows.Forms.TextBox textBoxCadComplemento;
        private System.Windows.Forms.TextBox textBoxCadVinculo;
        private System.Windows.Forms.TextBox textBoxCadNomeFamiliar;
        private System.Windows.Forms.MaskedTextBox maskCadTelefoneFamiliar;
        private System.Windows.Forms.TextBox textBoxCadParentesco;
        private System.Windows.Forms.TextBox textBoxCadObservacaoFamiliar;
        private System.Windows.Forms.Panel panelUpdDadosPessoais;
        private System.Windows.Forms.ComboBox comboBoxUpdSexo;
        private System.Windows.Forms.TextBox textBoxUpdEmail;
        private System.Windows.Forms.MaskedTextBox maskUpdTelefone;
        private System.Windows.Forms.TextBox textBoxUpdObservacao;
        private System.Windows.Forms.TextBox textBoxUpdNomeCompleto;
        private System.Windows.Forms.TextBox textBoxUpdRG;
        private System.Windows.Forms.MaskedTextBox maskUpdCPF;
        private System.Windows.Forms.Panel panelUpdEndereco;
        private System.Windows.Forms.TextBox textBoxUpdEstado;
        private System.Windows.Forms.TextBox textBoxUpdCidade;
        private System.Windows.Forms.TextBox textBoxUpdComplemento;
        private System.Windows.Forms.MaskedTextBox maskUpdCEP;
        private System.Windows.Forms.TextBox textBoxUpdNumero;
        private System.Windows.Forms.TextBox textBoxUpdBairro;
        private System.Windows.Forms.TextBox textBoxUpdEndereco;
        private System.Windows.Forms.Panel panelUpdDadosFamiliares;
        private System.Windows.Forms.TextBox textBoxUpdVinculo;
        private System.Windows.Forms.TextBox textBoxUpdNomeFamiliar;
        private System.Windows.Forms.MaskedTextBox maskUpdTelefoneFamiliar;
        private System.Windows.Forms.TextBox textBoxUpdParentesco;
        private System.Windows.Forms.TextBox textBoxUpdObservacaoFamiliares;
        private System.Windows.Forms.Button btnUpdDadosFamiliares;
        private System.Windows.Forms.Button btnUpdEndereco;
        private System.Windows.Forms.Button btnUpdDadosPessoais;
        private System.Windows.Forms.Button btnSavalEditar;
        private System.Windows.Forms.Button btnSairEditar;
        private DataSource.IClinicDatabaseDataSet iClinicDatabaseDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoBiologicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonePrincipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskUpdDataNascimento;
        private System.Windows.Forms.MaskedTextBox maskCadDataNascimento;
        private System.Windows.Forms.BindingSource dadosComplementaresBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.DadosComplementaresTableAdapter dadosComplementaresTableAdapter;
        private System.Windows.Forms.Panel panelCadTitulo;
        private System.Windows.Forms.Panel panelCadOpcoes;
        private System.Windows.Forms.Panel panelUpdOpcoes;
        private System.Windows.Forms.Panel panelUpdTitulo;
    }
}