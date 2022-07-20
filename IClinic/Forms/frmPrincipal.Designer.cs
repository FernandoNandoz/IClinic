namespace IClinic
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panelPai;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label labelTitulo;
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogon = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTrocarUsuario = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.panelMenuContent = new System.Windows.Forms.Panel();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnAtendimentos = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelNomeUsuarioHeader = new System.Windows.Forms.Label();
            this.btnDetalhesLogon = new System.Windows.Forms.Button();
            panelPai = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            labelTitulo = new System.Windows.Forms.Label();
            panelPai.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogon.SuspendLayout();
            this.panelMenuContent.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPai
            // 
            panelPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            panelPai.Controls.Add(this.panelDashboard);
            panelPai.Controls.Add(this.panelMenuContent);
            panelPai.Controls.Add(this.panelMenu);
            panelPai.Dock = System.Windows.Forms.DockStyle.Fill;
            panelPai.Location = new System.Drawing.Point(0, 0);
            panelPai.Name = "panelPai";
            panelPai.Size = new System.Drawing.Size(1359, 746);
            panelPai.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panel2);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(180, 40);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1179, 706);
            this.panelDashboard.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelLogon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 706);
            this.panel2.TabIndex = 4;
            // 
            // panelLogon
            // 
            this.panelLogon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelLogon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogon.Controls.Add(this.btnSair);
            this.panelLogon.Controls.Add(this.btnTrocarUsuario);
            this.panelLogon.Controls.Add(this.label24);
            this.panelLogon.Location = new System.Drawing.Point(888, 5);
            this.panelLogon.Name = "panelLogon";
            this.panelLogon.Size = new System.Drawing.Size(286, 100);
            this.panelLogon.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(13, 55);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(261, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "  Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTrocarUsuario
            // 
            this.btnTrocarUsuario.FlatAppearance.BorderSize = 0;
            this.btnTrocarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTrocarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnTrocarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarUsuario.Image")));
            this.btnTrocarUsuario.Location = new System.Drawing.Point(13, 8);
            this.btnTrocarUsuario.Name = "btnTrocarUsuario";
            this.btnTrocarUsuario.Size = new System.Drawing.Size(261, 38);
            this.btnTrocarUsuario.TabIndex = 10;
            this.btnTrocarUsuario.Text = " Trocar de Usuário";
            this.btnTrocarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrocarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrocarUsuario.UseVisualStyleBackColor = true;
            this.btnTrocarUsuario.Click += new System.EventHandler(this.btnTrocarUsuario_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(14, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(261, 20);
            this.label24.TabIndex = 15;
            this.label24.Text = "____________________________";
            // 
            // panelMenuContent
            // 
            this.panelMenuContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenuContent.Controls.Add(this.btnPacientes);
            this.panelMenuContent.Controls.Add(this.btnDashboard);
            this.panelMenuContent.Controls.Add(this.btnConfiguracoes);
            this.panelMenuContent.Controls.Add(this.btnAgenda);
            this.panelMenuContent.Controls.Add(this.btnRelatorios);
            this.panelMenuContent.Controls.Add(this.btnAtendimentos);
            this.panelMenuContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuContent.Location = new System.Drawing.Point(0, 40);
            this.panelMenuContent.Name = "panelMenuContent";
            this.panelMenuContent.Size = new System.Drawing.Size(180, 706);
            this.panelMenuContent.TabIndex = 1;
            this.panelMenuContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuContent_Paint);
            // 
            // btnPacientes
            // 
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 169);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(180, 50);
            this.btnPacientes.TabIndex = 6;
            this.btnPacientes.Text = "    Pacientes";
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 11);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 50);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 649);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(180, 50);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "   Configurações";
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(1, 63);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(180, 50);
            this.btnAgenda.TabIndex = 0;
            this.btnAgenda.Text = "   Agenda";
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(1, 223);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(180, 50);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "    Relatorios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnAtendimentos
            // 
            this.btnAtendimentos.FlatAppearance.BorderSize = 0;
            this.btnAtendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnAtendimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnAtendimentos.Image")));
            this.btnAtendimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendimentos.Location = new System.Drawing.Point(1, 115);
            this.btnAtendimentos.Name = "btnAtendimentos";
            this.btnAtendimentos.Size = new System.Drawing.Size(180, 50);
            this.btnAtendimentos.TabIndex = 1;
            this.btnAtendimentos.Text = "   Atendimentos";
            this.btnAtendimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtendimentos.UseVisualStyleBackColor = true;
            this.btnAtendimentos.Click += new System.EventHandler(this.btnAtendimentos_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(label2);
            this.panelMenu.Controls.Add(this.labelNomeUsuarioHeader);
            this.panelMenu.Controls.Add(labelTitulo);
            this.panelMenu.Controls.Add(this.btnDetalhesLogon);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1359, 40);
            this.panelMenu.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Segoe Print", 22F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(111, -9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(269, 54);
            label2.TabIndex = 3;
            label2.Text = "- Centro Clínico";
            // 
            // labelNomeUsuarioHeader
            // 
            this.labelNomeUsuarioHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomeUsuarioHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelNomeUsuarioHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNomeUsuarioHeader.Location = new System.Drawing.Point(836, 6);
            this.labelNomeUsuarioHeader.Name = "labelNomeUsuarioHeader";
            this.labelNomeUsuarioHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNomeUsuarioHeader.Size = new System.Drawing.Size(467, 30);
            this.labelNomeUsuarioHeader.TabIndex = 1;
            this.labelNomeUsuarioHeader.Text = "Fernando Damasceno | Desenvolvedor ";
            this.labelNomeUsuarioHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelTitulo.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold);
            labelTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelTitulo.Location = new System.Drawing.Point(12, -10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(111, 57);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Clinic";
            // 
            // btnDetalhesLogon
            // 
            this.btnDetalhesLogon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalhesLogon.FlatAppearance.BorderSize = 0;
            this.btnDetalhesLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhesLogon.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalhesLogon.Image")));
            this.btnDetalhesLogon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalhesLogon.Location = new System.Drawing.Point(1308, 3);
            this.btnDetalhesLogon.Name = "btnDetalhesLogon";
            this.btnDetalhesLogon.Size = new System.Drawing.Size(31, 37);
            this.btnDetalhesLogon.TabIndex = 1;
            this.btnDetalhesLogon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalhesLogon.UseVisualStyleBackColor = true;
            this.btnDetalhesLogon.Click += new System.EventHandler(this.btnDetalhesLogon_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 746);
            this.Controls.Add(panelPai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic - Gerenciador de Atendimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            panelPai.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelLogon.ResumeLayout(false);
            this.panelLogon.PerformLayout();
            this.panelMenuContent.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuContent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnAtendimentos;
        private System.Windows.Forms.Label labelNomeUsuarioHeader;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogon;
        private System.Windows.Forms.Button btnDetalhesLogon;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTrocarUsuario;
        private System.Windows.Forms.Label label24;
    }
}

