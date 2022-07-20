namespace IClinic.Forms
{
    partial class frmAtendimento
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
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label labelPesquisaData;
            System.Windows.Forms.Label labelPesquisaPeriodo;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendimento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.comboBoxPesquisaPeriodo = new System.Windows.Forms.ComboBox();
            this.datePesquisaData = new System.Windows.Forms.DateTimePicker();
            this.btnFichaAcompanhamento = new System.Windows.Forms.Button();
            this.btnNovoAtendimento = new System.Windows.Forms.Button();
            this.labelDataHeader = new System.Windows.Forms.Label();
            this.btnCancelarAtendimento = new System.Windows.Forms.Button();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.panelViewAtendimento = new System.Windows.Forms.Panel();
            this.dataGridViewAtendimentos = new System.Windows.Forms.DataGridView();
            this.ColumnIdAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdPacienteFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdColaboradorFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdProcedimentoFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelValuePacientesAtendidos = new System.Windows.Forms.Label();
            this.labelValuePacientesConfirmados = new System.Windows.Forms.Label();
            this.labelValuePacientesAgendados = new System.Windows.Forms.Label();
            this.panelContentAtendimento = new System.Windows.Forms.Panel();
            this.panelContentPai = new System.Windows.Forms.Panel();
            label18 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelPesquisaData = new System.Windows.Forms.Label();
            labelPesquisaPeriodo = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelViewAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtendimentos)).BeginInit();
            this.panelContentAtendimento.SuspendLayout();
            this.panelContentPai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label18.ForeColor = System.Drawing.SystemColors.Control;
            label18.Location = new System.Drawing.Point(459, 15);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(173, 20);
            label18.TabIndex = 28;
            label18.Text = "Pacientes Confirmados";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(855, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 20);
            label3.TabIndex = 32;
            label3.Text = "Pacientes Atendidos";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPesquisaData
            // 
            labelPesquisaData.AutoSize = true;
            labelPesquisaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPesquisaData.ForeColor = System.Drawing.SystemColors.Control;
            labelPesquisaData.Location = new System.Drawing.Point(32, 47);
            labelPesquisaData.Name = "labelPesquisaData";
            labelPesquisaData.Size = new System.Drawing.Size(44, 20);
            labelPesquisaData.TabIndex = 47;
            labelPesquisaData.Text = "Data";
            labelPesquisaData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPesquisaPeriodo
            // 
            labelPesquisaPeriodo.AutoSize = true;
            labelPesquisaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelPesquisaPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            labelPesquisaPeriodo.Location = new System.Drawing.Point(225, 47);
            labelPesquisaPeriodo.Name = "labelPesquisaPeriodo";
            labelPesquisaPeriodo.Size = new System.Drawing.Size(63, 20);
            labelPesquisaPeriodo.TabIndex = 46;
            labelPesquisaPeriodo.Text = "Periodo";
            labelPesquisaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label11.ForeColor = System.Drawing.SystemColors.Control;
            label11.Location = new System.Drawing.Point(26, 8);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(135, 26);
            label11.TabIndex = 7;
            label11.Text = "Atendimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(25, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1116, 26);
            label1.TabIndex = 8;
            label1.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label14.ForeColor = System.Drawing.SystemColors.Control;
            label14.Location = new System.Drawing.Point(61, 15);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(165, 20);
            label14.TabIndex = 24;
            label14.Text = "Pacientes Agendados";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(31, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1100, 24);
            label2.TabIndex = 30;
            label2.Text = "_________________________________________________________________________________" +
    "____________________________";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.comboBoxPesquisaPeriodo);
            this.panelMenu.Controls.Add(this.datePesquisaData);
            this.panelMenu.Controls.Add(labelPesquisaData);
            this.panelMenu.Controls.Add(labelPesquisaPeriodo);
            this.panelMenu.Controls.Add(this.btnFichaAcompanhamento);
            this.panelMenu.Controls.Add(this.btnNovoAtendimento);
            this.panelMenu.Controls.Add(this.labelDataHeader);
            this.panelMenu.Controls.Add(label11);
            this.panelMenu.Controls.Add(this.btnCancelarAtendimento);
            this.panelMenu.Controls.Add(label1);
            this.panelMenu.Controls.Add(this.btnVizualizarCadastro);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1162, 165);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // comboBoxPesquisaPeriodo
            // 
            this.comboBoxPesquisaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxPesquisaPeriodo.FormattingEnabled = true;
            this.comboBoxPesquisaPeriodo.Items.AddRange(new object[] {
            "Manha",
            "Tarde"});
            this.comboBoxPesquisaPeriodo.Location = new System.Drawing.Point(232, 70);
            this.comboBoxPesquisaPeriodo.Name = "comboBoxPesquisaPeriodo";
            this.comboBoxPesquisaPeriodo.Size = new System.Drawing.Size(231, 26);
            this.comboBoxPesquisaPeriodo.TabIndex = 45;
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
            this.datePesquisaData.Location = new System.Drawing.Point(36, 70);
            this.datePesquisaData.Name = "datePesquisaData";
            this.datePesquisaData.Size = new System.Drawing.Size(190, 26);
            this.datePesquisaData.TabIndex = 44;
            this.datePesquisaData.ValueChanged += new System.EventHandler(this.datePesquisaData_ValueChanged);
            // 
            // btnFichaAcompanhamento
            // 
            this.btnFichaAcompanhamento.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFichaAcompanhamento.FlatAppearance.BorderSize = 0;
            this.btnFichaAcompanhamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaAcompanhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFichaAcompanhamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFichaAcompanhamento.Image = ((System.Drawing.Image)(resources.GetObject("btnFichaAcompanhamento.Image")));
            this.btnFichaAcompanhamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaAcompanhamento.Location = new System.Drawing.Point(232, 116);
            this.btnFichaAcompanhamento.Name = "btnFichaAcompanhamento";
            this.btnFichaAcompanhamento.Size = new System.Drawing.Size(231, 35);
            this.btnFichaAcompanhamento.TabIndex = 42;
            this.btnFichaAcompanhamento.Text = "Ficha de Acompanhamento";
            this.btnFichaAcompanhamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFichaAcompanhamento.UseVisualStyleBackColor = false;
            this.btnFichaAcompanhamento.Click += new System.EventHandler(this.btnFichaAcompanhamento_Click);
            // 
            // btnNovoAtendimento
            // 
            this.btnNovoAtendimento.BackColor = System.Drawing.Color.Teal;
            this.btnNovoAtendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoAtendimento.FlatAppearance.BorderSize = 0;
            this.btnNovoAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNovoAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAtendimento.Image")));
            this.btnNovoAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAtendimento.Location = new System.Drawing.Point(36, 116);
            this.btnNovoAtendimento.Name = "btnNovoAtendimento";
            this.btnNovoAtendimento.Size = new System.Drawing.Size(190, 35);
            this.btnNovoAtendimento.TabIndex = 35;
            this.btnNovoAtendimento.Text = " Iniciar Atendimento";
            this.btnNovoAtendimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoAtendimento.UseVisualStyleBackColor = false;
            this.btnNovoAtendimento.Click += new System.EventHandler(this.btnNovoAtendimento_Click);
            // 
            // labelDataHeader
            // 
            this.labelDataHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDataHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDataHeader.Location = new System.Drawing.Point(799, 11);
            this.labelDataHeader.Name = "labelDataHeader";
            this.labelDataHeader.Size = new System.Drawing.Size(341, 24);
            this.labelDataHeader.TabIndex = 16;
            this.labelDataHeader.Text = "Sabado, 31 Outubro de 2019";
            this.labelDataHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelarAtendimento
            // 
            this.btnCancelarAtendimento.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarAtendimento.FlatAppearance.BorderSize = 0;
            this.btnCancelarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelarAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAtendimento.Image")));
            this.btnCancelarAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAtendimento.Location = new System.Drawing.Point(658, 116);
            this.btnCancelarAtendimento.Name = "btnCancelarAtendimento";
            this.btnCancelarAtendimento.Size = new System.Drawing.Size(198, 35);
            this.btnCancelarAtendimento.TabIndex = 41;
            this.btnCancelarAtendimento.Text = "Cancelar Atendimento";
            this.btnCancelarAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarAtendimento.UseVisualStyleBackColor = false;
            this.btnCancelarAtendimento.Click += new System.EventHandler(this.btnCancelarAtendimento_Click);
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
            this.btnVizualizarCadastro.Location = new System.Drawing.Point(469, 116);
            this.btnVizualizarCadastro.Name = "btnVizualizarCadastro";
            this.btnVizualizarCadastro.Size = new System.Drawing.Size(183, 35);
            this.btnVizualizarCadastro.TabIndex = 36;
            this.btnVizualizarCadastro.Text = " Vizualizar Cadastro";
            this.btnVizualizarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVizualizarCadastro.UseVisualStyleBackColor = false;
            this.btnVizualizarCadastro.Click += new System.EventHandler(this.btnVizualizarCadastro_Click);
            // 
            // panelViewAtendimento
            // 
            this.panelViewAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelViewAtendimento.Controls.Add(this.dataGridViewAtendimentos);
            this.panelViewAtendimento.Controls.Add(label3);
            this.panelViewAtendimento.Controls.Add(this.labelValuePacientesAtendidos);
            this.panelViewAtendimento.Controls.Add(label18);
            this.panelViewAtendimento.Controls.Add(this.labelValuePacientesConfirmados);
            this.panelViewAtendimento.Controls.Add(this.labelValuePacientesAgendados);
            this.panelViewAtendimento.Controls.Add(label14);
            this.panelViewAtendimento.Controls.Add(label2);
            this.panelViewAtendimento.Location = new System.Drawing.Point(0, 175);
            this.panelViewAtendimento.Margin = new System.Windows.Forms.Padding(0);
            this.panelViewAtendimento.Name = "panelViewAtendimento";
            this.panelViewAtendimento.Size = new System.Drawing.Size(1162, 508);
            this.panelViewAtendimento.TabIndex = 4;
            this.panelViewAtendimento.Paint += new System.Windows.Forms.PaintEventHandler(this.panelViewAtendimento_Paint);
            // 
            // dataGridViewAtendimentos
            // 
            this.dataGridViewAtendimentos.AllowUserToAddRows = false;
            this.dataGridViewAtendimentos.AllowUserToDeleteRows = false;
            this.dataGridViewAtendimentos.AllowUserToResizeColumns = false;
            this.dataGridViewAtendimentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewAtendimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAtendimentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewAtendimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAtendimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAtendimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdAgenda,
            this.ColumnNumero,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
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
            this.dataGridViewAtendimentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAtendimentos.EnableHeadersVisualStyles = false;
            this.dataGridViewAtendimentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewAtendimentos.Location = new System.Drawing.Point(29, 92);
            this.dataGridViewAtendimentos.MultiSelect = false;
            this.dataGridViewAtendimentos.Name = "dataGridViewAtendimentos";
            this.dataGridViewAtendimentos.ReadOnly = true;
            this.dataGridViewAtendimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAtendimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAtendimentos.RowHeadersVisible = false;
            this.dataGridViewAtendimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewAtendimentos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAtendimentos.RowTemplate.Height = 30;
            this.dataGridViewAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAtendimentos.Size = new System.Drawing.Size(1106, 395);
            this.dataGridViewAtendimentos.TabIndex = 33;
            this.dataGridViewAtendimentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAtendimentos_CellFormatting);
            // 
            // ColumnIdAgenda
            // 
            this.ColumnIdAgenda.HeaderText = "idAgenda";
            this.ColumnIdAgenda.Name = "ColumnIdAgenda";
            this.ColumnIdAgenda.ReadOnly = true;
            this.ColumnIdAgenda.Visible = false;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Nº";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            this.ColumnNumero.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 395;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Procedimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // profissional
            // 
            this.profissional.HeaderText = "Profissional";
            this.profissional.Name = "profissional";
            this.profissional.ReadOnly = true;
            this.profissional.Visible = false;
            this.profissional.Width = 220;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 190;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Visible = false;
            // 
            // ColumnIdPacienteFK
            // 
            this.ColumnIdPacienteFK.HeaderText = "idPacienteFK";
            this.ColumnIdPacienteFK.Name = "ColumnIdPacienteFK";
            this.ColumnIdPacienteFK.ReadOnly = true;
            this.ColumnIdPacienteFK.Visible = false;
            // 
            // ColumnIdColaboradorFK
            // 
            this.ColumnIdColaboradorFK.HeaderText = "idColaboradorFK";
            this.ColumnIdColaboradorFK.Name = "ColumnIdColaboradorFK";
            this.ColumnIdColaboradorFK.ReadOnly = true;
            this.ColumnIdColaboradorFK.Visible = false;
            // 
            // ColumnIdProcedimentoFK
            // 
            this.ColumnIdProcedimentoFK.HeaderText = "idProcedimentoFK";
            this.ColumnIdProcedimentoFK.Name = "ColumnIdProcedimentoFK";
            this.ColumnIdProcedimentoFK.ReadOnly = true;
            this.ColumnIdProcedimentoFK.Visible = false;
            // 
            // labelValuePacientesAtendidos
            // 
            this.labelValuePacientesAtendidos.AutoSize = true;
            this.labelValuePacientesAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelValuePacientesAtendidos.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValuePacientesAtendidos.Location = new System.Drawing.Point(916, 38);
            this.labelValuePacientesAtendidos.Name = "labelValuePacientesAtendidos";
            this.labelValuePacientesAtendidos.Size = new System.Drawing.Size(35, 37);
            this.labelValuePacientesAtendidos.TabIndex = 31;
            this.labelValuePacientesAtendidos.Text = "0";
            // 
            // labelValuePacientesConfirmados
            // 
            this.labelValuePacientesConfirmados.AutoSize = true;
            this.labelValuePacientesConfirmados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelValuePacientesConfirmados.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValuePacientesConfirmados.Location = new System.Drawing.Point(520, 38);
            this.labelValuePacientesConfirmados.Name = "labelValuePacientesConfirmados";
            this.labelValuePacientesConfirmados.Size = new System.Drawing.Size(35, 37);
            this.labelValuePacientesConfirmados.TabIndex = 25;
            this.labelValuePacientesConfirmados.Text = "0";
            // 
            // labelValuePacientesAgendados
            // 
            this.labelValuePacientesAgendados.AutoSize = true;
            this.labelValuePacientesAgendados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelValuePacientesAgendados.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValuePacientesAgendados.Location = new System.Drawing.Point(122, 40);
            this.labelValuePacientesAgendados.Name = "labelValuePacientesAgendados";
            this.labelValuePacientesAgendados.Size = new System.Drawing.Size(35, 37);
            this.labelValuePacientesAgendados.TabIndex = 26;
            this.labelValuePacientesAgendados.Text = "0";
            // 
            // panelContentAtendimento
            // 
            this.panelContentAtendimento.Controls.Add(this.panelViewAtendimento);
            this.panelContentAtendimento.Controls.Add(this.panelMenu);
            this.panelContentAtendimento.Location = new System.Drawing.Point(9, 10);
            this.panelContentAtendimento.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentAtendimento.Name = "panelContentAtendimento";
            this.panelContentAtendimento.Size = new System.Drawing.Size(1162, 683);
            this.panelContentAtendimento.TabIndex = 5;
            // 
            // panelContentPai
            // 
            this.panelContentPai.Controls.Add(this.panelContentAtendimento);
            this.panelContentPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentPai.Location = new System.Drawing.Point(0, 0);
            this.panelContentPai.Name = "panelContentPai";
            this.panelContentPai.Size = new System.Drawing.Size(1178, 706);
            this.panelContentPai.TabIndex = 33;
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1178, 706);
            this.Controls.Add(this.panelContentPai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAtendimento";
            this.Text = "Atendimentos";
            this.Load += new System.EventHandler(this.frmAtendimento_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelViewAtendimento.ResumeLayout(false);
            this.panelViewAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtendimentos)).EndInit();
            this.panelContentAtendimento.ResumeLayout(false);
            this.panelContentPai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewAtendimento;
        private System.Windows.Forms.Label labelValuePacientesConfirmados;
        private System.Windows.Forms.Label labelValuePacientesAgendados;
        private System.Windows.Forms.Label labelValuePacientesAtendidos;
        private System.Windows.Forms.Label labelDataHeader;
        private System.Windows.Forms.Button btnNovoAtendimento;
        private System.Windows.Forms.Button btnCancelarAtendimento;
        private System.Windows.Forms.Button btnFichaAcompanhamento;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Panel panelContentAtendimento;
        private System.Windows.Forms.Panel panelContentPai;
        private System.Windows.Forms.DataGridView dataGridViewAtendimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPacienteFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdColaboradorFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProcedimentoFK;
        private System.Windows.Forms.ComboBox comboBoxPesquisaPeriodo;
        private System.Windows.Forms.DateTimePicker datePesquisaData;
        private System.Windows.Forms.Panel panelMenu;
    }
}