using System;
using System.Runtime.InteropServices;

namespace IClinic.Forms.Cadastro
{
    partial class frmDocumentosImpressao
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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

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
            System.Windows.Forms.Label labelPesquisarNome;
            System.Windows.Forms.Label labelTitulo;
            System.Windows.Forms.Label labelLinhaTitulo;
            System.Windows.Forms.Label labelSelecioneProduto;
            System.Windows.Forms.Label labelLinhaSelecione;
            System.Windows.Forms.Label label64;
            System.Windows.Forms.Label label62;
            System.Windows.Forms.Label label60;
            System.Windows.Forms.Label label63;
            System.Windows.Forms.Label labelNomeCompleto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentosImpressao));
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            this.panelConsultarDocumento = new System.Windows.Forms.Panel();
            this.dataGridViewDocumento = new System.Windows.Forms.DataGridView();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Extensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNovoCadastro = new System.Windows.Forms.Panel();
            this.textBoxCadNomeModelo = new System.Windows.Forms.TextBox();
            this.labelPorcentagem = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBarImagemAnexo = new System.Windows.Forms.ProgressBar();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.dataGridViewImagemAnexo = new System.Windows.Forms.DataGridView();
            this.ColumnN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExtensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBotao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSairNovoCadastro = new System.Windows.Forms.Button();
            this.btnSalvarNovoCadastro = new System.Windows.Forms.Button();
            this.backgroundWorkerDeterminada = new System.ComponentModel.BackgroundWorker();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            labelNovoCadastro = new System.Windows.Forms.Label();
            labelLinhaNovoCadastro = new System.Windows.Forms.Label();
            labelPesquisarNome = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            labelLinhaTitulo = new System.Windows.Forms.Label();
            labelSelecioneProduto = new System.Windows.Forms.Label();
            labelLinhaSelecione = new System.Windows.Forms.Label();
            label64 = new System.Windows.Forms.Label();
            label62 = new System.Windows.Forms.Label();
            label60 = new System.Windows.Forms.Label();
            label63 = new System.Windows.Forms.Label();
            labelNomeCompleto = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.flpContainerPai.SuspendLayout();
            this.panelConsultarDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumento)).BeginInit();
            this.panelNovoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagemAnexo)).BeginInit();
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
            labelLinhaNovoCadastro.Size = new System.Drawing.Size(830, 24);
            labelLinhaNovoCadastro.TabIndex = 36;
            labelLinhaNovoCadastro.Text = "_________________________________________________________________________________" +
    "_";
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
            labelTitulo.Text = "Documento e impressões";
            labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaTitulo
            // 
            labelLinhaTitulo.AutoSize = true;
            labelLinhaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaTitulo.Location = new System.Drawing.Point(25, 13);
            labelLinhaTitulo.Name = "labelLinhaTitulo";
            labelLinhaTitulo.Size = new System.Drawing.Size(830, 24);
            labelLinhaTitulo.TabIndex = 34;
            labelLinhaTitulo.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // labelSelecioneProduto
            // 
            labelSelecioneProduto.AutoSize = true;
            labelSelecioneProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            labelSelecioneProduto.ForeColor = System.Drawing.SystemColors.Control;
            labelSelecioneProduto.Location = new System.Drawing.Point(25, 9);
            labelSelecioneProduto.Name = "labelSelecioneProduto";
            labelSelecioneProduto.Size = new System.Drawing.Size(560, 22);
            labelSelecioneProduto.TabIndex = 54;
            labelSelecioneProduto.Text = "Selecione um Documento para Editar, Vizualizar ou Excluir Cadastro:";
            labelSelecioneProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinhaSelecione
            // 
            labelLinhaSelecione.AutoSize = true;
            labelLinhaSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaSelecione.ForeColor = System.Drawing.SystemColors.Control;
            labelLinhaSelecione.Location = new System.Drawing.Point(25, 14);
            labelLinhaSelecione.Name = "labelLinhaSelecione";
            labelLinhaSelecione.Size = new System.Drawing.Size(830, 24);
            labelLinhaSelecione.TabIndex = 55;
            labelLinhaSelecione.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // label64
            // 
            label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            label64.Location = new System.Drawing.Point(366, 224);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(490, 24);
            label64.TabIndex = 167;
            label64.Text = "Arquivos de videos não são suportados:";
            label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            label62.Location = new System.Drawing.Point(26, 134);
            label62.Name = "label62";
            label62.Size = new System.Drawing.Size(266, 24);
            label62.TabIndex = 163;
            label62.Text = "Selecione o arquivo desejado:";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            label60.Location = new System.Drawing.Point(23, 221);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(187, 24);
            label60.TabIndex = 161;
            label60.Text = "Arquivos importados:";
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            label63.Location = new System.Drawing.Point(25, 228);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(840, 24);
            label63.TabIndex = 162;
            label63.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelNomeCompleto.Location = new System.Drawing.Point(25, 53);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new System.Drawing.Size(293, 24);
            labelNomeCompleto.TabIndex = 169;
            labelNomeCompleto.Text = "Nome do modelo do Documento:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnPesquisar);
            this.panelMenu.Controls.Add(labelPesquisarNome);
            this.panelMenu.Controls.Add(this.textPesquisarNome);
            this.panelMenu.Controls.Add(this.btnVizualizarCadastro);
            this.panelMenu.Controls.Add(labelTitulo);
            this.panelMenu.Controls.Add(this.btnExcluirCadastro);
            this.panelMenu.Controls.Add(labelLinhaTitulo);
            this.panelMenu.Controls.Add(this.btnNovoCadastro);
            this.panelMenu.Location = new System.Drawing.Point(8, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(900, 160);
            this.panelMenu.TabIndex = 39;
            this.panelMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelMenu.Width,panelMenu.Height, 7, 7));
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
            this.textPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textPesquisarNome.Location = new System.Drawing.Point(35, 64);
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
            this.btnVizualizarCadastro.Location = new System.Drawing.Point(216, 106);
            this.btnVizualizarCadastro.Name = "btnVizualizarCadastro";
            this.btnVizualizarCadastro.Size = new System.Drawing.Size(175, 35);
            this.btnVizualizarCadastro.TabIndex = 45;
            this.btnVizualizarCadastro.Text = " Abrir e vizualizar";
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
            this.btnExcluirCadastro.Location = new System.Drawing.Point(397, 106);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(175, 35);
            this.btnExcluirCadastro.TabIndex = 44;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
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
            this.flpContainerPai.Controls.Add(this.panelConsultarDocumento);
            this.flpContainerPai.Controls.Add(this.panelNovoCadastro);
            this.flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerPai.Location = new System.Drawing.Point(8, 179);
            this.flpContainerPai.Name = "flpContainerPai";
            this.flpContainerPai.Size = new System.Drawing.Size(900, 515);
            this.flpContainerPai.TabIndex = 40;
            this.flpContainerPai.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flpContainerPai.Width, flpContainerPai.Height, 7, 7));
            // 
            // panelConsultarDocumento
            // 
            this.panelConsultarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarDocumento.Controls.Add(labelSelecioneProduto);
            this.panelConsultarDocumento.Controls.Add(labelLinhaSelecione);
            this.panelConsultarDocumento.Controls.Add(this.dataGridViewDocumento);
            this.panelConsultarDocumento.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarDocumento.Name = "panelConsultarDocumento";
            this.panelConsultarDocumento.Size = new System.Drawing.Size(900, 515);
            this.panelConsultarDocumento.TabIndex = 38;
            this.panelConsultarDocumento.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConsultarDocumento.Width, panelConsultarDocumento.Height, 7, 7));
            // 
            // dataGridViewDocumento
            // 
            this.dataGridViewDocumento.AllowUserToAddRows = false;
            this.dataGridViewDocumento.AllowUserToDeleteRows = false;
            this.dataGridViewDocumento.AllowUserToResizeColumns = false;
            this.dataGridViewDocumento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewDocumento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDocumento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDocumento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocumento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModelo,
            this.Column1Extensao,
            this.ColumnLength,
            this.ColumnByte,
            this.ColumnIdDocumento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocumento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDocumento.EnableHeadersVisualStyles = false;
            this.dataGridViewDocumento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewDocumento.Location = new System.Drawing.Point(29, 49);
            this.dataGridViewDocumento.MultiSelect = false;
            this.dataGridViewDocumento.Name = "dataGridViewDocumento";
            this.dataGridViewDocumento.ReadOnly = true;
            this.dataGridViewDocumento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocumento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDocumento.RowHeadersVisible = false;
            this.dataGridViewDocumento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewDocumento.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDocumento.RowTemplate.Height = 30;
            this.dataGridViewDocumento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDocumento.Size = new System.Drawing.Size(826, 427);
            this.dataGridViewDocumento.TabIndex = 44;
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo documento";
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            this.ColumnModelo.Width = 815;
            // 
            // Column1Extensao
            // 
            this.Column1Extensao.HeaderText = "extensao";
            this.Column1Extensao.Name = "Column1Extensao";
            this.Column1Extensao.ReadOnly = true;
            this.Column1Extensao.Visible = false;
            // 
            // ColumnLength
            // 
            this.ColumnLength.HeaderText = "Length";
            this.ColumnLength.Name = "ColumnLength";
            this.ColumnLength.ReadOnly = true;
            this.ColumnLength.Visible = false;
            // 
            // ColumnByte
            // 
            this.ColumnByte.HeaderText = "fileStream";
            this.ColumnByte.Name = "ColumnByte";
            this.ColumnByte.ReadOnly = true;
            this.ColumnByte.Visible = false;
            // 
            // ColumnIdDocumento
            // 
            this.ColumnIdDocumento.HeaderText = "idDocumento";
            this.ColumnIdDocumento.Name = "ColumnIdDocumento";
            this.ColumnIdDocumento.ReadOnly = true;
            this.ColumnIdDocumento.Visible = false;
            // 
            // panelNovoCadastro
            // 
            this.panelNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelNovoCadastro.Controls.Add(this.textBoxCadNomeModelo);
            this.panelNovoCadastro.Controls.Add(labelNomeCompleto);
            this.panelNovoCadastro.Controls.Add(label64);
            this.panelNovoCadastro.Controls.Add(this.labelPorcentagem);
            this.panelNovoCadastro.Controls.Add(this.labelStatus);
            this.panelNovoCadastro.Controls.Add(this.progressBarImagemAnexo);
            this.panelNovoCadastro.Controls.Add(label62);
            this.panelNovoCadastro.Controls.Add(label60);
            this.panelNovoCadastro.Controls.Add(label63);
            this.panelNovoCadastro.Controls.Add(this.btnSelecionarArquivo);
            this.panelNovoCadastro.Controls.Add(this.dataGridViewImagemAnexo);
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
            this.panelNovoCadastro.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNovoCadastro.Width, panelNovoCadastro.Height, 7, 7));
            // 
            // textBoxCadNomeModelo
            // 
            this.textBoxCadNomeModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCadNomeModelo.Location = new System.Drawing.Point(29, 81);
            this.textBoxCadNomeModelo.Name = "textBoxCadNomeModelo";
            this.textBoxCadNomeModelo.Size = new System.Drawing.Size(827, 29);
            this.textBoxCadNomeModelo.TabIndex = 168;
            // 
            // labelPorcentagem
            // 
            this.labelPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPorcentagem.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPorcentagem.Location = new System.Drawing.Point(309, 420);
            this.labelPorcentagem.Name = "labelPorcentagem";
            this.labelPorcentagem.Size = new System.Drawing.Size(100, 23);
            this.labelPorcentagem.TabIndex = 166;
            this.labelPorcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(19, 421);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(279, 23);
            this.labelStatus.TabIndex = 165;
            // 
            // progressBarImagemAnexo
            // 
            this.progressBarImagemAnexo.Location = new System.Drawing.Point(22, 446);
            this.progressBarImagemAnexo.Name = "progressBarImagemAnexo";
            this.progressBarImagemAnexo.Size = new System.Drawing.Size(387, 30);
            this.progressBarImagemAnexo.TabIndex = 164;
            this.progressBarImagemAnexo.Visible = false;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelecionarArquivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionarArquivo.FlatAppearance.BorderSize = 0;
            this.btnSelecionarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelecionarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivo.Image")));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(30, 162);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(826, 37);
            this.btnSelecionarArquivo.TabIndex = 157;
            this.btnSelecionarArquivo.Text = " Selecionar arquivo";
            this.btnSelecionarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = false;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // dataGridViewImagemAnexo
            // 
            this.dataGridViewImagemAnexo.AllowUserToAddRows = false;
            this.dataGridViewImagemAnexo.AllowUserToDeleteRows = false;
            this.dataGridViewImagemAnexo.AllowUserToResizeColumns = false;
            this.dataGridViewImagemAnexo.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewImagemAnexo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImagemAnexo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewImagemAnexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewImagemAnexo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImagemAnexo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImagemAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImagemAnexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnN,
            this.ColumnNomeArquivo,
            this.ColumnExtensao,
            this.ColumnArquivo,
            this.ColumnBotao});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImagemAnexo.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImagemAnexo.EnableHeadersVisualStyles = false;
            this.dataGridViewImagemAnexo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dataGridViewImagemAnexo.Location = new System.Drawing.Point(27, 256);
            this.dataGridViewImagemAnexo.MultiSelect = false;
            this.dataGridViewImagemAnexo.Name = "dataGridViewImagemAnexo";
            this.dataGridViewImagemAnexo.ReadOnly = true;
            this.dataGridViewImagemAnexo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImagemAnexo.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImagemAnexo.RowHeadersVisible = false;
            this.dataGridViewImagemAnexo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridViewImagemAnexo.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImagemAnexo.RowTemplate.Height = 30;
            this.dataGridViewImagemAnexo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewImagemAnexo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImagemAnexo.Size = new System.Drawing.Size(838, 151);
            this.dataGridViewImagemAnexo.TabIndex = 159;
            this.dataGridViewImagemAnexo.TabStop = false;
            this.dataGridViewImagemAnexo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImagemAnexo_CellContentClick);
            // 
            // ColumnN
            // 
            this.ColumnN.HeaderText = "Nº";
            this.ColumnN.Name = "ColumnN";
            this.ColumnN.ReadOnly = true;
            this.ColumnN.Width = 50;
            // 
            // ColumnNomeArquivo
            // 
            this.ColumnNomeArquivo.HeaderText = "Nome Arquivo";
            this.ColumnNomeArquivo.Name = "ColumnNomeArquivo";
            this.ColumnNomeArquivo.ReadOnly = true;
            this.ColumnNomeArquivo.Width = 540;
            // 
            // ColumnExtensao
            // 
            this.ColumnExtensao.HeaderText = "Extensão";
            this.ColumnExtensao.Name = "ColumnExtensao";
            this.ColumnExtensao.ReadOnly = true;
            // 
            // ColumnArquivo
            // 
            this.ColumnArquivo.HeaderText = "arquivo";
            this.ColumnArquivo.Name = "ColumnArquivo";
            this.ColumnArquivo.ReadOnly = true;
            this.ColumnArquivo.Visible = false;
            // 
            // ColumnBotao
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            this.ColumnBotao.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnBotao.HeaderText = "Remover";
            this.ColumnBotao.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBotao.Image")));
            this.ColumnBotao.Name = "ColumnBotao";
            this.ColumnBotao.ReadOnly = true;
            this.ColumnBotao.Width = 120;
            // 
            // btnSairNovoCadastro
            // 
            this.btnSairNovoCadastro.BackColor = System.Drawing.Color.Firebrick;
            this.btnSairNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnSairNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSairNovoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairNovoCadastro.Image")));
            this.btnSairNovoCadastro.Location = new System.Drawing.Point(676, 441);
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
            this.btnSalvarNovoCadastro.Location = new System.Drawing.Point(516, 441);
            this.btnSalvarNovoCadastro.Name = "btnSalvarNovoCadastro";
            this.btnSalvarNovoCadastro.Size = new System.Drawing.Size(154, 35);
            this.btnSalvarNovoCadastro.TabIndex = 39;
            this.btnSalvarNovoCadastro.Text = "Salvar";
            this.btnSalvarNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarNovoCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarNovoCadastro.UseVisualStyleBackColor = false;
            this.btnSalvarNovoCadastro.Click += new System.EventHandler(this.btnSalvarNovoCadastro_Click);
            // 
            // backgroundWorkerDeterminada
            // 
            this.backgroundWorkerDeterminada.WorkerReportsProgress = true;
            this.backgroundWorkerDeterminada.WorkerSupportsCancellation = true;
            this.backgroundWorkerDeterminada.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDeterminada_DoWork);
            this.backgroundWorkerDeterminada.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerDeterminada_ProgressChanged);
            this.backgroundWorkerDeterminada.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDeterminada_RunWorkerCompleted);
            // 
            // timerCronometro
            // 
            this.timerCronometro.Enabled = true;
            this.timerCronometro.Interval = 1;
            // 
            // frmDocumentosImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(914, 701);
            this.Controls.Add(this.flpContainerPai);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmDocumentosImpressao";
            this.Text = "Documentos e impressões";
            this.Load += new System.EventHandler(this.frmDocumentosImpressao_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flpContainerPai.ResumeLayout(false);
            this.panelConsultarDocumento.ResumeLayout(false);
            this.panelConsultarDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumento)).EndInit();
            this.panelNovoCadastro.ResumeLayout(false);
            this.panelNovoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagemAnexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainerPai;
        private System.Windows.Forms.Panel panelConsultarDocumento;
        private System.Windows.Forms.DataGridView dataGridViewDocumento;
        private System.Windows.Forms.Panel panelNovoCadastro;
        private System.Windows.Forms.Button btnSairNovoCadastro;
        private System.Windows.Forms.Button btnSalvarNovoCadastro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisarNome;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelPorcentagem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBarImagemAnexo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.DataGridView dataGridViewImagemAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExtensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArquivo;
        private System.Windows.Forms.DataGridViewImageColumn ColumnBotao;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDeterminada;
        private System.Windows.Forms.Timer timerCronometro;
        private System.Windows.Forms.TextBox textBoxCadNomeModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Extensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdDocumento;
    }
}