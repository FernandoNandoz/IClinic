namespace IClinic.Forms
{
    partial class frmAgenda
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
            System.Windows.Forms.Label labelAtendimentosConfirmados;
            System.Windows.Forms.Label labelPesquisaPeriodo;
            System.Windows.Forms.Label labelPesquisaData;
            System.Windows.Forms.Label labelPesquisaNome;
            System.Windows.Forms.Label labelCadPeriodo;
            System.Windows.Forms.Label labelCadTelefone;
            System.Windows.Forms.Label labelCadLinhaHorario;
            System.Windows.Forms.Label labelCadDataAtendimento;
            System.Windows.Forms.Label labelCadObservacao;
            System.Windows.Forms.Label labelCadProcedimento;
            System.Windows.Forms.Label labelCadNomePaciente;
            System.Windows.Forms.Label labelCadProfissional;
            System.Windows.Forms.Label labelCadTitulo;
            System.Windows.Forms.Label labelCadLinhaTitulo;
            System.Windows.Forms.Label labelAgendaTitulo;
            System.Windows.Forms.Label labelLinhaTituloAgenda;
            System.Windows.Forms.Label labelUpdPeriodo;
            System.Windows.Forms.Label labelUpdTelefone;
            System.Windows.Forms.Label labelUpdLinhaHorario;
            System.Windows.Forms.Label labelUpdDataAtendimento;
            System.Windows.Forms.Label labelUpdObservacao;
            System.Windows.Forms.Label labelUpdProcedimento;
            System.Windows.Forms.Label labelUpdNomePaciente;
            System.Windows.Forms.Label labelUpdProfissional;
            System.Windows.Forms.Label labelUpdTitulo;
            System.Windows.Forms.Label labelUpdLinhaTitulo;
            System.Windows.Forms.Label labelPacienteFaltou;
            System.Windows.Forms.Label labelTotalAgendados;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCancelarAgendamento = new System.Windows.Forms.Button();
            this.btnNaoCompareceu = new System.Windows.Forms.Button();
            this.btnEditarAgendamento = new System.Windows.Forms.Button();
            this.btnConfirmarChegada = new System.Windows.Forms.Button();
            this.btnNovoAgendamento = new System.Windows.Forms.Button();
            this.textBoxPesquisaNome = new System.Windows.Forms.TextBox();
            this.comboBoxPesquisaPeriodo = new System.Windows.Forms.ComboBox();
            this.datePesquisaData = new System.Windows.Forms.DateTimePicker();
            this.labelDataHeader = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panelAgenda = new System.Windows.Forms.Panel();
            this.labelValuePacienteFaltou = new System.Windows.Forms.Label();
            this.labelValueAtendimentosConfirmandos = new System.Windows.Forms.Label();
            this.labelValueTotalAgendados = new System.Windows.Forms.Label();
            this.dataGridViewAgendamentos = new System.Windows.Forms.DataGridView();
            this.ColumnIdAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdPacienteFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdColaboradorFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdProcedimentoFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLinhaHeaderAgenda = new System.Windows.Forms.Label();
            this.flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNovoAgendamento = new System.Windows.Forms.Panel();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.textBoxProcedimento = new System.Windows.Forms.TextBox();
            this.linkLabelCadNovoPaciente = new System.Windows.Forms.LinkLabel();
            this.comboBoxCadPeriodo = new System.Windows.Forms.ComboBox();
            this.maskCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelCadTituloDataGrid = new System.Windows.Forms.Label();
            this.dateTimeCadDataAtendimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxCadObservacao = new System.Windows.Forms.TextBox();
            this.dataGridViewCadHorarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCadNomePaciente = new System.Windows.Forms.TextBox();
            this.btnCadSair = new System.Windows.Forms.Button();
            this.btnCadConcluir = new System.Windows.Forms.Button();
            this.panelEditarAgenda = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxUpdColaborador = new System.Windows.Forms.TextBox();
            this.textBoxUpdProcedimento = new System.Windows.Forms.TextBox();
            this.linkLabelUpdNovoPaciente = new System.Windows.Forms.LinkLabel();
            this.comboBoxUpdPeriodo = new System.Windows.Forms.ComboBox();
            this.maskUpdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelUpdTituloDataGrid = new System.Windows.Forms.Label();
            this.dateTimeUpdDataAtendimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxUpdObservacao = new System.Windows.Forms.TextBox();
            this.dataGridViewUpdHorarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxUpdNomePaciente = new System.Windows.Forms.TextBox();
            this.btnUpdSair = new System.Windows.Forms.Button();
            this.btnUpdConcluir = new System.Windows.Forms.Button();
            this.iClinicDatabaseDataSet = new IClinic.DataSource.IClinicDatabaseDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.PacienteTableAdapter();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new IClinic.DataSource.IClinicDatabaseDataSetTableAdapters.AgendaTableAdapter();
            labelAtendimentosConfirmados = new System.Windows.Forms.Label();
            labelPesquisaPeriodo = new System.Windows.Forms.Label();
            labelPesquisaData = new System.Windows.Forms.Label();
            labelPesquisaNome = new System.Windows.Forms.Label();
            labelCadPeriodo = new System.Windows.Forms.Label();
            labelCadTelefone = new System.Windows.Forms.Label();
            labelCadLinhaHorario = new System.Windows.Forms.Label();
            labelCadDataAtendimento = new System.Windows.Forms.Label();
            labelCadObservacao = new System.Windows.Forms.Label();
            labelCadProcedimento = new System.Windows.Forms.Label();
            labelCadNomePaciente = new System.Windows.Forms.Label();
            labelCadProfissional = new System.Windows.Forms.Label();
            labelCadTitulo = new System.Windows.Forms.Label();
            labelCadLinhaTitulo = new System.Windows.Forms.Label();
            labelAgendaTitulo = new System.Windows.Forms.Label();
            labelLinhaTituloAgenda = new System.Windows.Forms.Label();
            labelUpdPeriodo = new System.Windows.Forms.Label();
            labelUpdTelefone = new System.Windows.Forms.Label();
            labelUpdLinhaHorario = new System.Windows.Forms.Label();
            labelUpdDataAtendimento = new System.Windows.Forms.Label();
            labelUpdObservacao = new System.Windows.Forms.Label();
            labelUpdProcedimento = new System.Windows.Forms.Label();
            labelUpdNomePaciente = new System.Windows.Forms.Label();
            labelUpdProfissional = new System.Windows.Forms.Label();
            labelUpdTitulo = new System.Windows.Forms.Label();
            labelUpdLinhaTitulo = new System.Windows.Forms.Label();
            labelPacienteFaltou = new System.Windows.Forms.Label();
            labelTotalAgendados = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).BeginInit();
            this.flpContainerPai.SuspendLayout();
            this.panelNovoAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadHorarios)).BeginInit();
            this.panelEditarAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAtendimentosConfirmados
            // 
            labelAtendimentosConfirmados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelAtendimentosConfirmados.ForeColor = System.Drawing.SystemColors.Control;
            labelAtendimentosConfirmados.Location = new System.Drawing.Point(482, 9);
            labelAtendimentosConfirmados.Name = "labelAtendimentosConfirmados";
            labelAtendimentosConfirmados.Size = new System.Drawing.Size(174, 49);
            labelAtendimentosConfirmados.TabIndex = 20;
            labelAtendimentosConfirmados.Text = "Total de Pacientes Confirmados";
            labelAtendimentosConfirmados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPesquisaPeriodo
            // 
            labelPesquisaPeriodo.AutoSize = true;
            labelPesquisaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPesquisaPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            labelPesquisaPeriodo.Location = new System.Drawing.Point(222, 47);
            labelPesquisaPeriodo.Name = "labelPesquisaPeriodo";
            labelPesquisaPeriodo.Size = new System.Drawing.Size(63, 20);
            labelPesquisaPeriodo.TabIndex = 23;
            labelPesquisaPeriodo.Text = "Periodo";
            labelPesquisaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPesquisaData
            // 
            labelPesquisaData.AutoSize = true;
            labelPesquisaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPesquisaData.ForeColor = System.Drawing.SystemColors.Control;
            labelPesquisaData.Location = new System.Drawing.Point(27, 47);
            labelPesquisaData.Name = "labelPesquisaData";
            labelPesquisaData.Size = new System.Drawing.Size(44, 20);
            labelPesquisaData.TabIndex = 24;
            labelPesquisaData.Text = "Data";
            labelPesquisaData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPesquisaNome
            // 
            labelPesquisaNome.AutoSize = true;
            labelPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPesquisaNome.ForeColor = System.Drawing.SystemColors.Control;
            labelPesquisaNome.Location = new System.Drawing.Point(406, 47);
            labelPesquisaNome.Name = "labelPesquisaNome";
            labelPesquisaNome.Size = new System.Drawing.Size(71, 20);
            labelPesquisaNome.TabIndex = 26;
            labelPesquisaNome.Text = "Paciente";
            labelPesquisaNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadPeriodo
            // 
            labelCadPeriodo.AutoSize = true;
            labelCadPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            labelCadPeriodo.Location = new System.Drawing.Point(265, 53);
            labelCadPeriodo.Name = "labelCadPeriodo";
            labelCadPeriodo.Size = new System.Drawing.Size(76, 24);
            labelCadPeriodo.TabIndex = 109;
            labelCadPeriodo.Text = "Periodo";
            labelCadPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadTelefone
            // 
            labelCadTelefone.AutoSize = true;
            labelCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadTelefone.ForeColor = System.Drawing.SystemColors.Control;
            labelCadTelefone.Location = new System.Drawing.Point(454, 175);
            labelCadTelefone.Name = "labelCadTelefone";
            labelCadTelefone.Size = new System.Drawing.Size(85, 24);
            labelCadTelefone.TabIndex = 108;
            labelCadTelefone.Text = "Telefone";
            // 
            // labelCadLinhaHorario
            // 
            labelCadLinhaHorario.AutoSize = true;
            labelCadLinhaHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadLinhaHorario.ForeColor = System.Drawing.SystemColors.Control;
            labelCadLinhaHorario.Location = new System.Drawing.Point(625, 17);
            labelCadLinhaHorario.Name = "labelCadLinhaHorario";
            labelCadLinhaHorario.Size = new System.Drawing.Size(530, 24);
            labelCadLinhaHorario.TabIndex = 107;
            labelCadLinhaHorario.Text = "____________________________________________________";
            // 
            // labelCadDataAtendimento
            // 
            labelCadDataAtendimento.AutoSize = true;
            labelCadDataAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadDataAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            labelCadDataAtendimento.Location = new System.Drawing.Point(32, 55);
            labelCadDataAtendimento.Name = "labelCadDataAtendimento";
            labelCadDataAtendimento.Size = new System.Drawing.Size(47, 24);
            labelCadDataAtendimento.TabIndex = 105;
            labelCadDataAtendimento.Text = "Data";
            labelCadDataAtendimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadObservacao
            // 
            labelCadObservacao.AutoSize = true;
            labelCadObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadObservacao.ForeColor = System.Drawing.SystemColors.Control;
            labelCadObservacao.Location = new System.Drawing.Point(32, 318);
            labelCadObservacao.Name = "labelCadObservacao";
            labelCadObservacao.Size = new System.Drawing.Size(201, 24);
            labelCadObservacao.TabIndex = 104;
            labelCadObservacao.Text = "Observação (opcional)";
            labelCadObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadProcedimento
            // 
            labelCadProcedimento.AutoSize = true;
            labelCadProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadProcedimento.ForeColor = System.Drawing.SystemColors.Control;
            labelCadProcedimento.Location = new System.Drawing.Point(32, 114);
            labelCadProcedimento.Name = "labelCadProcedimento";
            labelCadProcedimento.Size = new System.Drawing.Size(128, 24);
            labelCadProcedimento.TabIndex = 103;
            labelCadProcedimento.Text = "Procedimento";
            labelCadProcedimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadNomePaciente
            // 
            labelCadNomePaciente.AutoSize = true;
            labelCadNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadNomePaciente.ForeColor = System.Drawing.SystemColors.Control;
            labelCadNomePaciente.Location = new System.Drawing.Point(32, 175);
            labelCadNomePaciente.Name = "labelCadNomePaciente";
            labelCadNomePaciente.Size = new System.Drawing.Size(167, 24);
            labelCadNomePaciente.TabIndex = 101;
            labelCadNomePaciente.Text = "Nome do Paciente";
            labelCadNomePaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadProfissional
            // 
            labelCadProfissional.AutoSize = true;
            labelCadProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadProfissional.ForeColor = System.Drawing.SystemColors.Control;
            labelCadProfissional.Location = new System.Drawing.Point(32, 253);
            labelCadProfissional.Name = "labelCadProfissional";
            labelCadProfissional.Size = new System.Drawing.Size(105, 24);
            labelCadProfissional.TabIndex = 100;
            labelCadProfissional.Text = "Profissional";
            labelCadProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCadTitulo
            // 
            labelCadTitulo.AutoSize = true;
            labelCadTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelCadTitulo.Location = new System.Drawing.Point(32, 10);
            labelCadTitulo.Name = "labelCadTitulo";
            labelCadTitulo.Size = new System.Drawing.Size(180, 24);
            labelCadTitulo.TabIndex = 91;
            labelCadTitulo.Text = "Novo Agendamento";
            // 
            // labelCadLinhaTitulo
            // 
            labelCadLinhaTitulo.AutoSize = true;
            labelCadLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelCadLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelCadLinhaTitulo.Location = new System.Drawing.Point(32, 16);
            labelCadLinhaTitulo.Name = "labelCadLinhaTitulo";
            labelCadLinhaTitulo.Size = new System.Drawing.Size(580, 24);
            labelCadLinhaTitulo.TabIndex = 92;
            labelCadLinhaTitulo.Text = "_________________________________________________________";
            // 
            // labelAgendaTitulo
            // 
            labelAgendaTitulo.AutoSize = true;
            labelAgendaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            labelAgendaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelAgendaTitulo.Location = new System.Drawing.Point(22, 7);
            labelAgendaTitulo.Name = "labelAgendaTitulo";
            labelAgendaTitulo.Size = new System.Drawing.Size(87, 26);
            labelAgendaTitulo.TabIndex = 9;
            labelAgendaTitulo.Text = "Agenda";
            // 
            // labelLinhaTituloAgenda
            // 
            labelLinhaTituloAgenda.AutoSize = true;
            labelLinhaTituloAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaTituloAgenda.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaTituloAgenda.Location = new System.Drawing.Point(22, 16);
            labelLinhaTituloAgenda.Name = "labelLinhaTituloAgenda";
            labelLinhaTituloAgenda.Size = new System.Drawing.Size(1120, 24);
            labelLinhaTituloAgenda.TabIndex = 10;
            labelLinhaTituloAgenda.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // labelUpdPeriodo
            // 
            labelUpdPeriodo.AutoSize = true;
            labelUpdPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdPeriodo.Location = new System.Drawing.Point(427, 47);
            labelUpdPeriodo.Name = "labelUpdPeriodo";
            labelUpdPeriodo.Size = new System.Drawing.Size(76, 24);
            labelUpdPeriodo.TabIndex = 109;
            labelUpdPeriodo.Text = "Periodo";
            labelUpdPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdTelefone
            // 
            labelUpdTelefone.AutoSize = true;
            labelUpdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdTelefone.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdTelefone.Location = new System.Drawing.Point(454, 169);
            labelUpdTelefone.Name = "labelUpdTelefone";
            labelUpdTelefone.Size = new System.Drawing.Size(85, 24);
            labelUpdTelefone.TabIndex = 108;
            labelUpdTelefone.Text = "Telefone";
            // 
            // labelUpdLinhaHorario
            // 
            labelUpdLinhaHorario.AutoSize = true;
            labelUpdLinhaHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdLinhaHorario.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdLinhaHorario.Location = new System.Drawing.Point(625, 18);
            labelUpdLinhaHorario.Name = "labelUpdLinhaHorario";
            labelUpdLinhaHorario.Size = new System.Drawing.Size(530, 24);
            labelUpdLinhaHorario.TabIndex = 107;
            labelUpdLinhaHorario.Text = "____________________________________________________";
            // 
            // labelUpdDataAtendimento
            // 
            labelUpdDataAtendimento.AutoSize = true;
            labelUpdDataAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdDataAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdDataAtendimento.Location = new System.Drawing.Point(32, 49);
            labelUpdDataAtendimento.Name = "labelUpdDataAtendimento";
            labelUpdDataAtendimento.Size = new System.Drawing.Size(47, 24);
            labelUpdDataAtendimento.TabIndex = 105;
            labelUpdDataAtendimento.Text = "Data";
            labelUpdDataAtendimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdObservacao
            // 
            labelUpdObservacao.AutoSize = true;
            labelUpdObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdObservacao.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdObservacao.Location = new System.Drawing.Point(32, 313);
            labelUpdObservacao.Name = "labelUpdObservacao";
            labelUpdObservacao.Size = new System.Drawing.Size(201, 24);
            labelUpdObservacao.TabIndex = 104;
            labelUpdObservacao.Text = "Observação (opcional)";
            labelUpdObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdProcedimento
            // 
            labelUpdProcedimento.AutoSize = true;
            labelUpdProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdProcedimento.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdProcedimento.Location = new System.Drawing.Point(32, 108);
            labelUpdProcedimento.Name = "labelUpdProcedimento";
            labelUpdProcedimento.Size = new System.Drawing.Size(128, 24);
            labelUpdProcedimento.TabIndex = 103;
            labelUpdProcedimento.Text = "Procedimento";
            labelUpdProcedimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdNomePaciente
            // 
            labelUpdNomePaciente.AutoSize = true;
            labelUpdNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdNomePaciente.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdNomePaciente.Location = new System.Drawing.Point(32, 169);
            labelUpdNomePaciente.Name = "labelUpdNomePaciente";
            labelUpdNomePaciente.Size = new System.Drawing.Size(167, 24);
            labelUpdNomePaciente.TabIndex = 101;
            labelUpdNomePaciente.Text = "Nome do Paciente";
            labelUpdNomePaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdProfissional
            // 
            labelUpdProfissional.AutoSize = true;
            labelUpdProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdProfissional.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdProfissional.Location = new System.Drawing.Point(32, 247);
            labelUpdProfissional.Name = "labelUpdProfissional";
            labelUpdProfissional.Size = new System.Drawing.Size(105, 24);
            labelUpdProfissional.TabIndex = 100;
            labelUpdProfissional.Text = "Profissional";
            labelUpdProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdTitulo
            // 
            labelUpdTitulo.AutoSize = true;
            labelUpdTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdTitulo.Location = new System.Drawing.Point(32, 11);
            labelUpdTitulo.Name = "labelUpdTitulo";
            labelUpdTitulo.Size = new System.Drawing.Size(183, 24);
            labelUpdTitulo.TabIndex = 91;
            labelUpdTitulo.Text = "Editar Agendamento";
            // 
            // labelUpdLinhaTitulo
            // 
            labelUpdLinhaTitulo.AutoSize = true;
            labelUpdLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelUpdLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelUpdLinhaTitulo.Location = new System.Drawing.Point(32, 17);
            labelUpdLinhaTitulo.Name = "labelUpdLinhaTitulo";
            labelUpdLinhaTitulo.Size = new System.Drawing.Size(580, 24);
            labelUpdLinhaTitulo.TabIndex = 92;
            labelUpdLinhaTitulo.Text = "_________________________________________________________";
            // 
            // labelPacienteFaltou
            // 
            labelPacienteFaltou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPacienteFaltou.ForeColor = System.Drawing.SystemColors.Control;
            labelPacienteFaltou.Location = new System.Drawing.Point(855, 8);
            labelPacienteFaltou.Name = "labelPacienteFaltou";
            labelPacienteFaltou.Size = new System.Drawing.Size(178, 49);
            labelPacienteFaltou.TabIndex = 19;
            labelPacienteFaltou.Text = "Total de Pacientes que Faltaram";
            labelPacienteFaltou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalAgendados
            // 
            labelTotalAgendados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelTotalAgendados.ForeColor = System.Drawing.SystemColors.Control;
            labelTotalAgendados.Location = new System.Drawing.Point(74, 10);
            labelTotalAgendados.Name = "labelTotalAgendados";
            labelTotalAgendados.Size = new System.Drawing.Size(174, 47);
            labelTotalAgendados.TabIndex = 16;
            labelTotalAgendados.Text = "Total de Pacientes Agendados";
            labelTotalAgendados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(235, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 24);
            label1.TabIndex = 114;
            label1.Text = "Status";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnCancelarAgendamento);
            this.panelMenu.Controls.Add(this.btnNaoCompareceu);
            this.panelMenu.Controls.Add(this.btnEditarAgendamento);
            this.panelMenu.Controls.Add(this.btnConfirmarChegada);
            this.panelMenu.Controls.Add(this.btnNovoAgendamento);
            this.panelMenu.Controls.Add(labelPesquisaNome);
            this.panelMenu.Controls.Add(this.textBoxPesquisaNome);
            this.panelMenu.Controls.Add(labelPesquisaData);
            this.panelMenu.Controls.Add(labelPesquisaPeriodo);
            this.panelMenu.Controls.Add(this.comboBoxPesquisaPeriodo);
            this.panelMenu.Controls.Add(this.datePesquisaData);
            this.panelMenu.Controls.Add(this.labelDataHeader);
            this.panelMenu.Controls.Add(this.btnPesquisar);
            this.panelMenu.Controls.Add(labelAgendaTitulo);
            this.panelMenu.Controls.Add(labelLinhaTituloAgenda);
            this.panelMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Location = new System.Drawing.Point(9, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1162, 155);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarAgendamento.FlatAppearance.BorderSize = 0;
            this.btnCancelarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelarAgendamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAgendamento.Image")));
            this.btnCancelarAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(763, 111);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(198, 35);
            this.btnCancelarAgendamento.TabIndex = 34;
            this.btnCancelarAgendamento.Text = "Cancelar Agendamento";
            this.btnCancelarAgendamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarAgendamento.UseVisualStyleBackColor = false;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
            // 
            // btnNaoCompareceu
            // 
            this.btnNaoCompareceu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNaoCompareceu.FlatAppearance.BorderSize = 0;
            this.btnNaoCompareceu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaoCompareceu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNaoCompareceu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNaoCompareceu.Image = ((System.Drawing.Image)(resources.GetObject("btnNaoCompareceu.Image")));
            this.btnNaoCompareceu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNaoCompareceu.Location = new System.Drawing.Point(410, 111);
            this.btnNaoCompareceu.Name = "btnNaoCompareceu";
            this.btnNaoCompareceu.Size = new System.Drawing.Size(161, 35);
            this.btnNaoCompareceu.TabIndex = 33;
            this.btnNaoCompareceu.Text = " Não compareceu";
            this.btnNaoCompareceu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNaoCompareceu.UseVisualStyleBackColor = false;
            this.btnNaoCompareceu.Click += new System.EventHandler(this.btnNaoCompareceu_Click);
            // 
            // btnEditarAgendamento
            // 
            this.btnEditarAgendamento.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditarAgendamento.FlatAppearance.BorderSize = 0;
            this.btnEditarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEditarAgendamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAgendamento.Image")));
            this.btnEditarAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAgendamento.Location = new System.Drawing.Point(577, 111);
            this.btnEditarAgendamento.Name = "btnEditarAgendamento";
            this.btnEditarAgendamento.Size = new System.Drawing.Size(180, 35);
            this.btnEditarAgendamento.TabIndex = 32;
            this.btnEditarAgendamento.Text = " Editar Agendamento";
            this.btnEditarAgendamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarAgendamento.UseVisualStyleBackColor = false;
            this.btnEditarAgendamento.Click += new System.EventHandler(this.btnEditarAgendamento_Click);
            // 
            // btnConfirmarChegada
            // 
            this.btnConfirmarChegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnConfirmarChegada.FlatAppearance.BorderSize = 0;
            this.btnConfirmarChegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConfirmarChegada.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmarChegada.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarChegada.Image")));
            this.btnConfirmarChegada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarChegada.Location = new System.Drawing.Point(226, 110);
            this.btnConfirmarChegada.Name = "btnConfirmarChegada";
            this.btnConfirmarChegada.Size = new System.Drawing.Size(178, 35);
            this.btnConfirmarChegada.TabIndex = 30;
            this.btnConfirmarChegada.Text = "Confirmar Chegada";
            this.btnConfirmarChegada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarChegada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarChegada.UseVisualStyleBackColor = false;
            this.btnConfirmarChegada.Click += new System.EventHandler(this.btnConfirmarChegada_Click);
            // 
            // btnNovoAgendamento
            // 
            this.btnNovoAgendamento.BackColor = System.Drawing.Color.Teal;
            this.btnNovoAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoAgendamento.FlatAppearance.BorderSize = 0;
            this.btnNovoAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNovoAgendamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAgendamento.Image")));
            this.btnNovoAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAgendamento.Location = new System.Drawing.Point(31, 110);
            this.btnNovoAgendamento.Name = "btnNovoAgendamento";
            this.btnNovoAgendamento.Size = new System.Drawing.Size(188, 35);
            this.btnNovoAgendamento.TabIndex = 29;
            this.btnNovoAgendamento.Text = " Novo Agendamento";
            this.btnNovoAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoAgendamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoAgendamento.UseVisualStyleBackColor = false;
            this.btnNovoAgendamento.Click += new System.EventHandler(this.btnNovoAgendamento_Click);
            // 
            // textBoxPesquisaNome
            // 
            this.textBoxPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPesquisaNome.Location = new System.Drawing.Point(410, 70);
            this.textBoxPesquisaNome.Name = "textBoxPesquisaNome";
            this.textBoxPesquisaNome.Size = new System.Drawing.Size(551, 26);
            this.textBoxPesquisaNome.TabIndex = 25;
            // 
            // comboBoxPesquisaPeriodo
            // 
            this.comboBoxPesquisaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxPesquisaPeriodo.FormattingEnabled = true;
            this.comboBoxPesquisaPeriodo.Items.AddRange(new object[] {
            "Todos",
            "Manha",
            "Tarde"});
            this.comboBoxPesquisaPeriodo.Location = new System.Drawing.Point(226, 70);
            this.comboBoxPesquisaPeriodo.Name = "comboBoxPesquisaPeriodo";
            this.comboBoxPesquisaPeriodo.Size = new System.Drawing.Size(178, 26);
            this.comboBoxPesquisaPeriodo.TabIndex = 17;
            this.comboBoxPesquisaPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPesquisaPeriodo_SelectedIndexChanged);
            // 
            // datePesquisaData
            // 
            this.datePesquisaData.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.datePesquisaData.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.datePesquisaData.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.datePesquisaData.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.datePesquisaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePesquisaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePesquisaData.Location = new System.Drawing.Point(31, 70);
            this.datePesquisaData.Name = "datePesquisaData";
            this.datePesquisaData.Size = new System.Drawing.Size(189, 26);
            this.datePesquisaData.TabIndex = 16;
            this.datePesquisaData.ValueChanged += new System.EventHandler(this.datePesquisaData_ValueChanged);
            // 
            // labelDataHeader
            // 
            this.labelDataHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDataHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDataHeader.Location = new System.Drawing.Point(770, 9);
            this.labelDataHeader.Name = "labelDataHeader";
            this.labelDataHeader.Size = new System.Drawing.Size(372, 24);
            this.labelDataHeader.TabIndex = 15;
            this.labelDataHeader.Text = "Sabado, 31 Outubro de 2019";
            this.labelDataHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(967, 70);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(139, 26);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "   Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelAgenda
            // 
            this.panelAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelAgenda.Controls.Add(this.labelValuePacienteFaltou);
            this.panelAgenda.Controls.Add(labelAtendimentosConfirmados);
            this.panelAgenda.Controls.Add(labelPacienteFaltou);
            this.panelAgenda.Controls.Add(this.labelValueAtendimentosConfirmandos);
            this.panelAgenda.Controls.Add(this.labelValueTotalAgendados);
            this.panelAgenda.Controls.Add(labelTotalAgendados);
            this.panelAgenda.Controls.Add(this.dataGridViewAgendamentos);
            this.panelAgenda.Controls.Add(this.labelLinhaHeaderAgenda);
            this.panelAgenda.Location = new System.Drawing.Point(0, 0);
            this.panelAgenda.Margin = new System.Windows.Forms.Padding(0);
            this.panelAgenda.Name = "panelAgenda";
            this.panelAgenda.Size = new System.Drawing.Size(1162, 520);
            this.panelAgenda.TabIndex = 2;
            this.panelAgenda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAgenda_Paint);
            // 
            // labelValuePacienteFaltou
            // 
            this.labelValuePacienteFaltou.AutoSize = true;
            this.labelValuePacienteFaltou.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelValuePacienteFaltou.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValuePacienteFaltou.Location = new System.Drawing.Point(930, 57);
            this.labelValuePacienteFaltou.Name = "labelValuePacienteFaltou";
            this.labelValuePacienteFaltou.Size = new System.Drawing.Size(29, 31);
            this.labelValuePacienteFaltou.TabIndex = 21;
            this.labelValuePacienteFaltou.Text = "0";
            // 
            // labelValueAtendimentosConfirmandos
            // 
            this.labelValueAtendimentosConfirmandos.AutoSize = true;
            this.labelValueAtendimentosConfirmandos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelValueAtendimentosConfirmandos.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValueAtendimentosConfirmandos.Location = new System.Drawing.Point(554, 57);
            this.labelValueAtendimentosConfirmandos.Name = "labelValueAtendimentosConfirmandos";
            this.labelValueAtendimentosConfirmandos.Size = new System.Drawing.Size(29, 31);
            this.labelValueAtendimentosConfirmandos.TabIndex = 17;
            this.labelValueAtendimentosConfirmandos.Text = "0";
            // 
            // labelValueTotalAgendados
            // 
            this.labelValueTotalAgendados.AutoSize = true;
            this.labelValueTotalAgendados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelValueTotalAgendados.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValueTotalAgendados.Location = new System.Drawing.Point(143, 57);
            this.labelValueTotalAgendados.Name = "labelValueTotalAgendados";
            this.labelValueTotalAgendados.Size = new System.Drawing.Size(29, 31);
            this.labelValueTotalAgendados.TabIndex = 18;
            this.labelValueTotalAgendados.Text = "0";
            // 
            // dataGridViewAgendamentos
            // 
            this.dataGridViewAgendamentos.AllowUserToAddRows = false;
            this.dataGridViewAgendamentos.AllowUserToDeleteRows = false;
            this.dataGridViewAgendamentos.AllowUserToResizeColumns = false;
            this.dataGridViewAgendamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAgendamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewAgendamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAgendamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdAgenda,
            this.ColumnNumero,
            this.horarioInicio,
            this.paciente,
            this.procedimento,
            this.tipoPaciente,
            this.profissional,
            this.ColumnStatus,
            this.ColumnData,
            this.ColumnIdPacienteFK,
            this.ColumnIdColaboradorFK,
            this.ColumnIdProcedimentoFK});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAgendamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAgendamentos.EnableHeadersVisualStyles = false;
            this.dataGridViewAgendamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewAgendamentos.Location = new System.Drawing.Point(17, 104);
            this.dataGridViewAgendamentos.MultiSelect = false;
            this.dataGridViewAgendamentos.Name = "dataGridViewAgendamentos";
            this.dataGridViewAgendamentos.ReadOnly = true;
            this.dataGridViewAgendamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgendamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAgendamentos.RowHeadersVisible = false;
            this.dataGridViewAgendamentos.RowHeadersWidth = 51;
            this.dataGridViewAgendamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewAgendamentos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAgendamentos.RowTemplate.Height = 30;
            this.dataGridViewAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAgendamentos.Size = new System.Drawing.Size(1127, 400);
            this.dataGridViewAgendamentos.TabIndex = 15;
            this.dataGridViewAgendamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAgendamentos_CellFormatting);
            // 
            // ColumnIdAgenda
            // 
            this.ColumnIdAgenda.HeaderText = "idAgenda";
            this.ColumnIdAgenda.MinimumWidth = 6;
            this.ColumnIdAgenda.Name = "ColumnIdAgenda";
            this.ColumnIdAgenda.ReadOnly = true;
            this.ColumnIdAgenda.Visible = false;
            this.ColumnIdAgenda.Width = 125;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Nº";
            this.ColumnNumero.MinimumWidth = 6;
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            this.ColumnNumero.Width = 40;
            // 
            // horarioInicio
            // 
            this.horarioInicio.HeaderText = "Periodo";
            this.horarioInicio.MinimumWidth = 6;
            this.horarioInicio.Name = "horarioInicio";
            this.horarioInicio.ReadOnly = true;
            this.horarioInicio.Width = 80;
            // 
            // paciente
            // 
            this.paciente.HeaderText = "Paciente";
            this.paciente.MinimumWidth = 6;
            this.paciente.Name = "paciente";
            this.paciente.ReadOnly = true;
            this.paciente.Width = 300;
            // 
            // procedimento
            // 
            this.procedimento.HeaderText = "Procedimento";
            this.procedimento.MinimumWidth = 6;
            this.procedimento.Name = "procedimento";
            this.procedimento.ReadOnly = true;
            this.procedimento.Width = 216;
            // 
            // tipoPaciente
            // 
            this.tipoPaciente.HeaderText = "Tipo ";
            this.tipoPaciente.MinimumWidth = 6;
            this.tipoPaciente.Name = "tipoPaciente";
            this.tipoPaciente.ReadOnly = true;
            this.tipoPaciente.Width = 90;
            // 
            // profissional
            // 
            this.profissional.HeaderText = "Profissional";
            this.profissional.MinimumWidth = 6;
            this.profissional.Name = "profissional";
            this.profissional.ReadOnly = true;
            this.profissional.Width = 220;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 170;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "data";
            this.ColumnData.MinimumWidth = 6;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Visible = false;
            this.ColumnData.Width = 125;
            // 
            // ColumnIdPacienteFK
            // 
            this.ColumnIdPacienteFK.HeaderText = "idPacienteFK";
            this.ColumnIdPacienteFK.MinimumWidth = 6;
            this.ColumnIdPacienteFK.Name = "ColumnIdPacienteFK";
            this.ColumnIdPacienteFK.ReadOnly = true;
            this.ColumnIdPacienteFK.Visible = false;
            this.ColumnIdPacienteFK.Width = 125;
            // 
            // ColumnIdColaboradorFK
            // 
            this.ColumnIdColaboradorFK.HeaderText = "idColaboradorFK";
            this.ColumnIdColaboradorFK.MinimumWidth = 6;
            this.ColumnIdColaboradorFK.Name = "ColumnIdColaboradorFK";
            this.ColumnIdColaboradorFK.ReadOnly = true;
            this.ColumnIdColaboradorFK.Visible = false;
            this.ColumnIdColaboradorFK.Width = 125;
            // 
            // ColumnIdProcedimentoFK
            // 
            this.ColumnIdProcedimentoFK.HeaderText = "idProcedimentoFK";
            this.ColumnIdProcedimentoFK.MinimumWidth = 6;
            this.ColumnIdProcedimentoFK.Name = "ColumnIdProcedimentoFK";
            this.ColumnIdProcedimentoFK.ReadOnly = true;
            this.ColumnIdProcedimentoFK.Visible = false;
            this.ColumnIdProcedimentoFK.Width = 125;
            // 
            // labelLinhaHeaderAgenda
            // 
            this.labelLinhaHeaderAgenda.AutoSize = true;
            this.labelLinhaHeaderAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLinhaHeaderAgenda.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLinhaHeaderAgenda.Location = new System.Drawing.Point(14, 78);
            this.labelLinhaHeaderAgenda.Name = "labelLinhaHeaderAgenda";
            this.labelLinhaHeaderAgenda.Size = new System.Drawing.Size(1130, 24);
            this.labelLinhaHeaderAgenda.TabIndex = 22;
            this.labelLinhaHeaderAgenda.Text = "_________________________________________________________________________________" +
    "_______________________________";
            // 
            // flpContainerPai
            // 
            this.flpContainerPai.AutoScroll = true;
            this.flpContainerPai.Controls.Add(this.panelAgenda);
            this.flpContainerPai.Controls.Add(this.panelNovoAgendamento);
            this.flpContainerPai.Controls.Add(this.panelEditarAgenda);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(9, 177);
            this.flpContainerPai.Margin = new System.Windows.Forms.Padding(0);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(1162, 520);
            this.flpContainerPai.TabIndex = 23;
            this.flpContainerPai.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContainerPai_Paint);
            // 
            // panelNovoAgendamento
            // 
            this.panelNovoAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelNovoAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelNovoAgendamento.Controls.Add(this.textBoxColaborador);
            this.panelNovoAgendamento.Controls.Add(this.textBoxProcedimento);
            this.panelNovoAgendamento.Controls.Add(this.linkLabelCadNovoPaciente);
            this.panelNovoAgendamento.Controls.Add(labelCadPeriodo);
            this.panelNovoAgendamento.Controls.Add(this.comboBoxCadPeriodo);
            this.panelNovoAgendamento.Controls.Add(this.maskCadTelefone);
            this.panelNovoAgendamento.Controls.Add(labelCadTelefone);
            this.panelNovoAgendamento.Controls.Add(this.labelCadTituloDataGrid);
            this.panelNovoAgendamento.Controls.Add(labelCadLinhaHorario);
            this.panelNovoAgendamento.Controls.Add(this.dateTimeCadDataAtendimento);
            this.panelNovoAgendamento.Controls.Add(labelCadDataAtendimento);
            this.panelNovoAgendamento.Controls.Add(this.textBoxCadObservacao);
            this.panelNovoAgendamento.Controls.Add(labelCadObservacao);
            this.panelNovoAgendamento.Controls.Add(labelCadProcedimento);
            this.panelNovoAgendamento.Controls.Add(this.dataGridViewCadHorarios);
            this.panelNovoAgendamento.Controls.Add(this.textBoxCadNomePaciente);
            this.panelNovoAgendamento.Controls.Add(labelCadNomePaciente);
            this.panelNovoAgendamento.Controls.Add(labelCadProfissional);
            this.panelNovoAgendamento.Controls.Add(this.btnCadSair);
            this.panelNovoAgendamento.Controls.Add(this.btnCadConcluir);
            this.panelNovoAgendamento.Controls.Add(labelCadTitulo);
            this.panelNovoAgendamento.Controls.Add(labelCadLinhaTitulo);
            this.panelNovoAgendamento.Location = new System.Drawing.Point(1162, 0);
            this.panelNovoAgendamento.Margin = new System.Windows.Forms.Padding(0);
            this.panelNovoAgendamento.Name = "panelNovoAgendamento";
            this.panelNovoAgendamento.Size = new System.Drawing.Size(1162, 520);
            this.panelNovoAgendamento.TabIndex = 3;
            this.panelNovoAgendamento.Visible = false;
            this.panelNovoAgendamento.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNovoAgendamento_Paint);
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxColaborador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxColaborador.Location = new System.Drawing.Point(36, 280);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.Size = new System.Drawing.Size(576, 29);
            this.textBoxColaborador.TabIndex = 8;
            this.textBoxColaborador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxColaborador_KeyDown);
            // 
            // textBoxProcedimento
            // 
            this.textBoxProcedimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxProcedimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxProcedimento.Location = new System.Drawing.Point(36, 141);
            this.textBoxProcedimento.Name = "textBoxProcedimento";
            this.textBoxProcedimento.Size = new System.Drawing.Size(576, 29);
            this.textBoxProcedimento.TabIndex = 6;
            this.textBoxProcedimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProcedimento_KeyDown);
            // 
            // linkLabelCadNovoPaciente
            // 
            this.linkLabelCadNovoPaciente.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.linkLabelCadNovoPaciente.AutoSize = true;
            this.linkLabelCadNovoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabelCadNovoPaciente.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.linkLabelCadNovoPaciente.Location = new System.Drawing.Point(276, 232);
            this.linkLabelCadNovoPaciente.Name = "linkLabelCadNovoPaciente";
            this.linkLabelCadNovoPaciente.Size = new System.Drawing.Size(174, 18);
            this.linkLabelCadNovoPaciente.TabIndex = 110;
            this.linkLabelCadNovoPaciente.TabStop = true;
            this.linkLabelCadNovoPaciente.Text = "Cadastrar Novo Paciente";
            this.linkLabelCadNovoPaciente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadNovoPaciente_LinkClicked);
            // 
            // comboBoxCadPeriodo
            // 
            this.comboBoxCadPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxCadPeriodo.FormattingEnabled = true;
            this.comboBoxCadPeriodo.ItemHeight = 20;
            this.comboBoxCadPeriodo.Items.AddRange(new object[] {
            "Manha",
            "Tarde"});
            this.comboBoxCadPeriodo.Location = new System.Drawing.Point(269, 80);
            this.comboBoxCadPeriodo.Name = "comboBoxCadPeriodo";
            this.comboBoxCadPeriodo.Size = new System.Drawing.Size(181, 28);
            this.comboBoxCadPeriodo.TabIndex = 5;
            this.comboBoxCadPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCadPeriodo_SelectedIndexChanged);
            // 
            // maskCadTelefone
            // 
            this.maskCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskCadTelefone.Location = new System.Drawing.Point(458, 202);
            this.maskCadTelefone.Mask = "(00) 0 0000-0000";
            this.maskCadTelefone.Name = "maskCadTelefone";
            this.maskCadTelefone.Size = new System.Drawing.Size(154, 29);
            this.maskCadTelefone.TabIndex = 96;
            this.maskCadTelefone.TabStop = false;
            // 
            // labelCadTituloDataGrid
            // 
            this.labelCadTituloDataGrid.AutoSize = true;
            this.labelCadTituloDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCadTituloDataGrid.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCadTituloDataGrid.Location = new System.Drawing.Point(625, 10);
            this.labelCadTituloDataGrid.Name = "labelCadTituloDataGrid";
            this.labelCadTituloDataGrid.Size = new System.Drawing.Size(71, 24);
            this.labelCadTituloDataGrid.TabIndex = 106;
            this.labelCadTituloDataGrid.Text = "Titulo...";
            // 
            // dateTimeCadDataAtendimento
            // 
            this.dateTimeCadDataAtendimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeCadDataAtendimento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeCadDataAtendimento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeCadDataAtendimento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeCadDataAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dateTimeCadDataAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCadDataAtendimento.Location = new System.Drawing.Point(36, 81);
            this.dateTimeCadDataAtendimento.Name = "dateTimeCadDataAtendimento";
            this.dateTimeCadDataAtendimento.Size = new System.Drawing.Size(223, 27);
            this.dateTimeCadDataAtendimento.TabIndex = 4;
            this.dateTimeCadDataAtendimento.TabStop = false;
            this.dateTimeCadDataAtendimento.ValueChanged += new System.EventHandler(this.dateTimeCadDataAtendimento_ValueChanged);
            // 
            // textBoxCadObservacao
            // 
            this.textBoxCadObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxCadObservacao.Location = new System.Drawing.Point(36, 345);
            this.textBoxCadObservacao.Name = "textBoxCadObservacao";
            this.textBoxCadObservacao.Size = new System.Drawing.Size(576, 27);
            this.textBoxCadObservacao.TabIndex = 9;
            // 
            // dataGridViewCadHorarios
            // 
            this.dataGridViewCadHorarios.AllowUserToAddRows = false;
            this.dataGridViewCadHorarios.AllowUserToDeleteRows = false;
            this.dataGridViewCadHorarios.AllowUserToResizeColumns = false;
            this.dataGridViewCadHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewCadHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCadHorarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewCadHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCadHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCadHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCadHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.horarioTermino});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCadHorarios.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCadHorarios.EnableHeadersVisualStyles = false;
            this.dataGridViewCadHorarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewCadHorarios.Location = new System.Drawing.Point(627, 56);
            this.dataGridViewCadHorarios.MultiSelect = false;
            this.dataGridViewCadHorarios.Name = "dataGridViewCadHorarios";
            this.dataGridViewCadHorarios.ReadOnly = true;
            this.dataGridViewCadHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCadHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCadHorarios.RowHeadersVisible = false;
            this.dataGridViewCadHorarios.RowHeadersWidth = 51;
            this.dataGridViewCadHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewCadHorarios.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewCadHorarios.RowTemplate.Height = 30;
            this.dataGridViewCadHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCadHorarios.Size = new System.Drawing.Size(521, 373);
            this.dataGridViewCadHorarios.TabIndex = 102;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // horarioTermino
            // 
            this.horarioTermino.HeaderText = "Paciente";
            this.horarioTermino.MinimumWidth = 6;
            this.horarioTermino.Name = "horarioTermino";
            this.horarioTermino.ReadOnly = true;
            this.horarioTermino.Width = 290;
            // 
            // textBoxCadNomePaciente
            // 
            this.textBoxCadNomePaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCadNomePaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCadNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomePaciente.Location = new System.Drawing.Point(36, 202);
            this.textBoxCadNomePaciente.Name = "textBoxCadNomePaciente";
            this.textBoxCadNomePaciente.Size = new System.Drawing.Size(414, 29);
            this.textBoxCadNomePaciente.TabIndex = 7;
            this.textBoxCadNomePaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCadNomePaciente_KeyDown);
            // 
            // btnCadSair
            // 
            this.btnCadSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnCadSair.FlatAppearance.BorderSize = 0;
            this.btnCadSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadSair.Image = ((System.Drawing.Image)(resources.GetObject("btnCadSair.Image")));
            this.btnCadSair.Location = new System.Drawing.Point(321, 394);
            this.btnCadSair.Name = "btnCadSair";
            this.btnCadSair.Size = new System.Drawing.Size(160, 35);
            this.btnCadSair.TabIndex = 99;
            this.btnCadSair.Text = "Voltar";
            this.btnCadSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadSair.UseVisualStyleBackColor = false;
            this.btnCadSair.Click += new System.EventHandler(this.btnCadSair_Click);
            // 
            // btnCadConcluir
            // 
            this.btnCadConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnCadConcluir.FlatAppearance.BorderSize = 0;
            this.btnCadConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadConcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnCadConcluir.Image")));
            this.btnCadConcluir.Location = new System.Drawing.Point(155, 394);
            this.btnCadConcluir.Name = "btnCadConcluir";
            this.btnCadConcluir.Size = new System.Drawing.Size(160, 35);
            this.btnCadConcluir.TabIndex = 98;
            this.btnCadConcluir.Text = "Concluir";
            this.btnCadConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadConcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadConcluir.UseVisualStyleBackColor = false;
            this.btnCadConcluir.Click += new System.EventHandler(this.btnCadConcluir_Click);
            // 
            // panelEditarAgenda
            // 
            this.panelEditarAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelEditarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelEditarAgenda.Controls.Add(label1);
            this.panelEditarAgenda.Controls.Add(this.comboBoxStatus);
            this.panelEditarAgenda.Controls.Add(this.textBoxUpdColaborador);
            this.panelEditarAgenda.Controls.Add(this.textBoxUpdProcedimento);
            this.panelEditarAgenda.Controls.Add(this.linkLabelUpdNovoPaciente);
            this.panelEditarAgenda.Controls.Add(labelUpdPeriodo);
            this.panelEditarAgenda.Controls.Add(this.comboBoxUpdPeriodo);
            this.panelEditarAgenda.Controls.Add(this.maskUpdTelefone);
            this.panelEditarAgenda.Controls.Add(labelUpdTelefone);
            this.panelEditarAgenda.Controls.Add(this.labelUpdTituloDataGrid);
            this.panelEditarAgenda.Controls.Add(labelUpdLinhaHorario);
            this.panelEditarAgenda.Controls.Add(this.dateTimeUpdDataAtendimento);
            this.panelEditarAgenda.Controls.Add(labelUpdDataAtendimento);
            this.panelEditarAgenda.Controls.Add(this.textBoxUpdObservacao);
            this.panelEditarAgenda.Controls.Add(labelUpdObservacao);
            this.panelEditarAgenda.Controls.Add(labelUpdProcedimento);
            this.panelEditarAgenda.Controls.Add(this.dataGridViewUpdHorarios);
            this.panelEditarAgenda.Controls.Add(this.textBoxUpdNomePaciente);
            this.panelEditarAgenda.Controls.Add(labelUpdNomePaciente);
            this.panelEditarAgenda.Controls.Add(labelUpdProfissional);
            this.panelEditarAgenda.Controls.Add(this.btnUpdSair);
            this.panelEditarAgenda.Controls.Add(this.btnUpdConcluir);
            this.panelEditarAgenda.Controls.Add(labelUpdTitulo);
            this.panelEditarAgenda.Controls.Add(labelUpdLinhaTitulo);
            this.panelEditarAgenda.Location = new System.Drawing.Point(2324, 0);
            this.panelEditarAgenda.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditarAgenda.Name = "panelEditarAgenda";
            this.panelEditarAgenda.Size = new System.Drawing.Size(1162, 520);
            this.panelEditarAgenda.TabIndex = 4;
            this.panelEditarAgenda.Visible = false;
            this.panelEditarAgenda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEditarAgenda_Paint);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.ItemHeight = 20;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "AGENDADO",
            "REAGENDADO",
            "NAO COMPARECEU",
            "CANCELADO"});
            this.comboBoxStatus.Location = new System.Drawing.Point(239, 74);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(186, 28);
            this.comboBoxStatus.TabIndex = 113;
            // 
            // textBoxUpdColaborador
            // 
            this.textBoxUpdColaborador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxUpdColaborador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUpdColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdColaborador.Location = new System.Drawing.Point(36, 274);
            this.textBoxUpdColaborador.Name = "textBoxUpdColaborador";
            this.textBoxUpdColaborador.Size = new System.Drawing.Size(576, 29);
            this.textBoxUpdColaborador.TabIndex = 112;
            // 
            // textBoxUpdProcedimento
            // 
            this.textBoxUpdProcedimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxUpdProcedimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUpdProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdProcedimento.Location = new System.Drawing.Point(36, 135);
            this.textBoxUpdProcedimento.Name = "textBoxUpdProcedimento";
            this.textBoxUpdProcedimento.Size = new System.Drawing.Size(576, 29);
            this.textBoxUpdProcedimento.TabIndex = 111;
            // 
            // linkLabelUpdNovoPaciente
            // 
            this.linkLabelUpdNovoPaciente.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.linkLabelUpdNovoPaciente.AutoSize = true;
            this.linkLabelUpdNovoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabelUpdNovoPaciente.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.linkLabelUpdNovoPaciente.Location = new System.Drawing.Point(276, 226);
            this.linkLabelUpdNovoPaciente.Name = "linkLabelUpdNovoPaciente";
            this.linkLabelUpdNovoPaciente.Size = new System.Drawing.Size(174, 18);
            this.linkLabelUpdNovoPaciente.TabIndex = 110;
            this.linkLabelUpdNovoPaciente.TabStop = true;
            this.linkLabelUpdNovoPaciente.Text = "Cadastrar Novo Paciente";
            this.linkLabelUpdNovoPaciente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdNovoPaciente_LinkClicked);
            // 
            // comboBoxUpdPeriodo
            // 
            this.comboBoxUpdPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUpdPeriodo.FormattingEnabled = true;
            this.comboBoxUpdPeriodo.ItemHeight = 20;
            this.comboBoxUpdPeriodo.Items.AddRange(new object[] {
            "Manha",
            "Tarde"});
            this.comboBoxUpdPeriodo.Location = new System.Drawing.Point(431, 74);
            this.comboBoxUpdPeriodo.Name = "comboBoxUpdPeriodo";
            this.comboBoxUpdPeriodo.Size = new System.Drawing.Size(181, 28);
            this.comboBoxUpdPeriodo.TabIndex = 90;
            this.comboBoxUpdPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdPeriodo_SelectedIndexChanged);
            // 
            // maskUpdTelefone
            // 
            this.maskUpdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskUpdTelefone.Location = new System.Drawing.Point(458, 196);
            this.maskUpdTelefone.Mask = "(00) 0 0000-0000";
            this.maskUpdTelefone.Name = "maskUpdTelefone";
            this.maskUpdTelefone.Size = new System.Drawing.Size(154, 29);
            this.maskUpdTelefone.TabIndex = 96;
            // 
            // labelUpdTituloDataGrid
            // 
            this.labelUpdTituloDataGrid.AutoSize = true;
            this.labelUpdTituloDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUpdTituloDataGrid.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUpdTituloDataGrid.Location = new System.Drawing.Point(625, 11);
            this.labelUpdTituloDataGrid.Name = "labelUpdTituloDataGrid";
            this.labelUpdTituloDataGrid.Size = new System.Drawing.Size(71, 24);
            this.labelUpdTituloDataGrid.TabIndex = 106;
            this.labelUpdTituloDataGrid.Text = "Titulo...";
            // 
            // dateTimeUpdDataAtendimento
            // 
            this.dateTimeUpdDataAtendimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeUpdDataAtendimento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeUpdDataAtendimento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeUpdDataAtendimento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dateTimeUpdDataAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dateTimeUpdDataAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeUpdDataAtendimento.Location = new System.Drawing.Point(36, 75);
            this.dateTimeUpdDataAtendimento.Name = "dateTimeUpdDataAtendimento";
            this.dateTimeUpdDataAtendimento.Size = new System.Drawing.Size(197, 27);
            this.dateTimeUpdDataAtendimento.TabIndex = 94;
            this.dateTimeUpdDataAtendimento.ValueChanged += new System.EventHandler(this.dateTimeUpdDataAtendimento_ValueChanged);
            // 
            // textBoxUpdObservacao
            // 
            this.textBoxUpdObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxUpdObservacao.Location = new System.Drawing.Point(36, 339);
            this.textBoxUpdObservacao.Name = "textBoxUpdObservacao";
            this.textBoxUpdObservacao.Size = new System.Drawing.Size(576, 27);
            this.textBoxUpdObservacao.TabIndex = 97;
            // 
            // dataGridViewUpdHorarios
            // 
            this.dataGridViewUpdHorarios.AllowUserToAddRows = false;
            this.dataGridViewUpdHorarios.AllowUserToDeleteRows = false;
            this.dataGridViewUpdHorarios.AllowUserToResizeColumns = false;
            this.dataGridViewUpdHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewUpdHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewUpdHorarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewUpdHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUpdHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpdHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewUpdHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUpdHorarios.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewUpdHorarios.EnableHeadersVisualStyles = false;
            this.dataGridViewUpdHorarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewUpdHorarios.Location = new System.Drawing.Point(627, 50);
            this.dataGridViewUpdHorarios.MultiSelect = false;
            this.dataGridViewUpdHorarios.Name = "dataGridViewUpdHorarios";
            this.dataGridViewUpdHorarios.ReadOnly = true;
            this.dataGridViewUpdHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpdHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewUpdHorarios.RowHeadersVisible = false;
            this.dataGridViewUpdHorarios.RowHeadersWidth = 51;
            this.dataGridViewUpdHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewUpdHorarios.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewUpdHorarios.RowTemplate.Height = 30;
            this.dataGridViewUpdHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpdHorarios.Size = new System.Drawing.Size(521, 373);
            this.dataGridViewUpdHorarios.TabIndex = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 290;
            // 
            // textBoxUpdNomePaciente
            // 
            this.textBoxUpdNomePaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxUpdNomePaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUpdNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUpdNomePaciente.Location = new System.Drawing.Point(36, 196);
            this.textBoxUpdNomePaciente.Name = "textBoxUpdNomePaciente";
            this.textBoxUpdNomePaciente.Size = new System.Drawing.Size(414, 29);
            this.textBoxUpdNomePaciente.TabIndex = 93;
            this.textBoxUpdNomePaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUpdNomePaciente_KeyDown);
            // 
            // btnUpdSair
            // 
            this.btnUpdSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnUpdSair.FlatAppearance.BorderSize = 0;
            this.btnUpdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdSair.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdSair.Image")));
            this.btnUpdSair.Location = new System.Drawing.Point(321, 388);
            this.btnUpdSair.Name = "btnUpdSair";
            this.btnUpdSair.Size = new System.Drawing.Size(160, 35);
            this.btnUpdSair.TabIndex = 99;
            this.btnUpdSair.Text = "Voltar";
            this.btnUpdSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdSair.UseVisualStyleBackColor = false;
            this.btnUpdSair.Click += new System.EventHandler(this.btnUpdSair_Click);
            // 
            // btnUpdConcluir
            // 
            this.btnUpdConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.btnUpdConcluir.FlatAppearance.BorderSize = 0;
            this.btnUpdConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdConcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdConcluir.Image")));
            this.btnUpdConcluir.Location = new System.Drawing.Point(155, 388);
            this.btnUpdConcluir.Name = "btnUpdConcluir";
            this.btnUpdConcluir.Size = new System.Drawing.Size(160, 35);
            this.btnUpdConcluir.TabIndex = 98;
            this.btnUpdConcluir.Text = "Concluir";
            this.btnUpdConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdConcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdConcluir.UseVisualStyleBackColor = false;
            this.btnUpdConcluir.Click += new System.EventHandler(this.btnUpdConcluir_Click);
            // 
            // iClinicDatabaseDataSet
            // 
            this.iClinicDatabaseDataSet.DataSetName = "IClinicDatabaseDataSet";
            this.iClinicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.iClinicDatabaseDataSet;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1178, 706);
            this.Controls.Add(this.flpContainerPai);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgenda_FormClosing);
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelAgenda.ResumeLayout(false);
            this.panelAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).EndInit();
            this.flpContainerPai.ResumeLayout(false);
            this.panelNovoAgendamento.ResumeLayout(false);
            this.panelNovoAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadHorarios)).EndInit();
            this.panelEditarAgenda.ResumeLayout(false);
            this.panelEditarAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iClinicDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgenda;
        private System.Windows.Forms.Label labelValuePacienteFaltou;
        private System.Windows.Forms.Label labelValueAtendimentosConfirmandos;
        private System.Windows.Forms.Label labelValueTotalAgendados;
        private System.Windows.Forms.Label labelLinhaHeaderAgenda;
        private System.Windows.Forms.ComboBox comboBoxPesquisaPeriodo;
        private System.Windows.Forms.DateTimePicker datePesquisaData;
        private System.Windows.Forms.Label labelDataHeader;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisaNome;
        private System.Windows.Forms.Button btnNaoCompareceu;
        private System.Windows.Forms.Button btnEditarAgendamento;
        private System.Windows.Forms.Button btnConfirmarChegada;
        private System.Windows.Forms.Button btnNovoAgendamento;
        private System.Windows.Forms.Button btnCancelarAgendamento;
        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelNovoAgendamento;
        private System.Windows.Forms.LinkLabel linkLabelCadNovoPaciente;
        private System.Windows.Forms.ComboBox comboBoxCadPeriodo;
        private System.Windows.Forms.MaskedTextBox maskCadTelefone;
        private System.Windows.Forms.Label labelCadTituloDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimeCadDataAtendimento;
        private System.Windows.Forms.TextBox textBoxCadObservacao;
        private System.Windows.Forms.DataGridView dataGridViewCadHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioTermino;
        private System.Windows.Forms.TextBox textBoxCadNomePaciente;
        private System.Windows.Forms.Button btnCadSair;
        private System.Windows.Forms.Button btnCadConcluir;
        private System.Windows.Forms.Panel panelEditarAgenda;
        private System.Windows.Forms.LinkLabel linkLabelUpdNovoPaciente;
        private System.Windows.Forms.ComboBox comboBoxUpdPeriodo;
        private System.Windows.Forms.MaskedTextBox maskUpdTelefone;
        private System.Windows.Forms.Label labelUpdTituloDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimeUpdDataAtendimento;
        private System.Windows.Forms.TextBox textBoxUpdObservacao;
        private System.Windows.Forms.DataGridView dataGridViewUpdHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox textBoxUpdNomePaciente;
        private System.Windows.Forms.Button btnUpdSair;
        private System.Windows.Forms.Button btnUpdConcluir;
        private DataSource.IClinicDatabaseDataSet iClinicDatabaseDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private DataSource.IClinicDatabaseDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TextBox textBoxProcedimento;
        private System.Windows.Forms.TextBox textBoxUpdColaborador;
        private System.Windows.Forms.TextBox textBoxUpdProcedimento;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPacienteFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdColaboradorFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProcedimentoFK;
        private System.Windows.Forms.TextBox textBoxColaborador;
        public System.Windows.Forms.DataGridView dataGridViewAgendamentos;
    }
}