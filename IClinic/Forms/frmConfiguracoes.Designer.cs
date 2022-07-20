namespace IClinic.Forms
{
    partial class frmConfiguracoes
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
            System.Windows.Forms.FlowLayoutPanel flpContainerPai;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnDocumentosImpressoes = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCadastroDePerfil = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCadastroProcedimento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.panelContainerPai = new System.Windows.Forms.Panel();
            flpContainerPai = new System.Windows.Forms.FlowLayoutPanel();
            flpContainerPai.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContainerPai
            // 
            flpContainerPai.Controls.Add(this.panelSubMenu);
            flpContainerPai.Controls.Add(this.panelContainerPai);
            flpContainerPai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpContainerPai.Location = new System.Drawing.Point(0, 0);
            flpContainerPai.Name = "flpContainerPai";
            flpContainerPai.Size = new System.Drawing.Size(1185, 705);
            flpContainerPai.TabIndex = 0;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelSubMenu.Controls.Add(this.btnDocumentosImpressoes);
            this.panelSubMenu.Controls.Add(this.btnUsuario);
            this.panelSubMenu.Controls.Add(this.btnBackup);
            this.panelSubMenu.Controls.Add(this.btnCadastroDePerfil);
            this.panelSubMenu.Controls.Add(this.label14);
            this.panelSubMenu.Controls.Add(this.btnCadastroProcedimento);
            this.panelSubMenu.Controls.Add(this.label2);
            this.panelSubMenu.Controls.Add(this.btnCadastroFuncionario);
            this.panelSubMenu.Location = new System.Drawing.Point(8, 10);
            this.panelSubMenu.Margin = new System.Windows.Forms.Padding(8, 10, 0, 10);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(254, 684);
            this.panelSubMenu.TabIndex = 0;
            this.panelSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubMenu_Paint);
            // 
            // btnDocumentosImpressoes
            // 
            this.btnDocumentosImpressoes.FlatAppearance.BorderSize = 0;
            this.btnDocumentosImpressoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentosImpressoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentosImpressoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnDocumentosImpressoes.Image = ((System.Drawing.Image)(resources.GetObject("btnDocumentosImpressoes.Image")));
            this.btnDocumentosImpressoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentosImpressoes.Location = new System.Drawing.Point(0, 262);
            this.btnDocumentosImpressoes.Name = "btnDocumentosImpressoes";
            this.btnDocumentosImpressoes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDocumentosImpressoes.Size = new System.Drawing.Size(254, 50);
            this.btnDocumentosImpressoes.TabIndex = 40;
            this.btnDocumentosImpressoes.Text = " Documentos e Impressões";
            this.btnDocumentosImpressoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocumentosImpressoes.UseVisualStyleBackColor = true;
            this.btnDocumentosImpressoes.Click += new System.EventHandler(this.btnDocumentosImpressoes_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 48);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(254, 50);
            this.btnUsuario.TabIndex = 39;
            this.btnUsuario.Text = " Usuários";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.bntUsuario_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(0, 632);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(254, 50);
            this.btnBackup.TabIndex = 37;
            this.btnBackup.Text = " Backup";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnCadastroDePerfil
            // 
            this.btnCadastroDePerfil.FlatAppearance.BorderSize = 0;
            this.btnCadastroDePerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroDePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroDePerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadastroDePerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroDePerfil.Image")));
            this.btnCadastroDePerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDePerfil.Location = new System.Drawing.Point(0, 155);
            this.btnCadastroDePerfil.Name = "btnCadastroDePerfil";
            this.btnCadastroDePerfil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastroDePerfil.Size = new System.Drawing.Size(254, 50);
            this.btnCadastroDePerfil.TabIndex = 36;
            this.btnCadastroDePerfil.Text = " Perfil de Usuário";
            this.btnCadastroDePerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroDePerfil.UseVisualStyleBackColor = true;
            this.btnCadastroDePerfil.Click += new System.EventHandler(this.btnCadastroDePerfil_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(8, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 24);
            this.label14.TabIndex = 31;
            this.label14.Text = "Configurações Gerais";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastroProcedimento
            // 
            this.btnCadastroProcedimento.FlatAppearance.BorderSize = 0;
            this.btnCadastroProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProcedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadastroProcedimento.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProcedimento.Image")));
            this.btnCadastroProcedimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProcedimento.Location = new System.Drawing.Point(0, 102);
            this.btnCadastroProcedimento.Name = "btnCadastroProcedimento";
            this.btnCadastroProcedimento.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastroProcedimento.Size = new System.Drawing.Size(254, 50);
            this.btnCadastroProcedimento.TabIndex = 8;
            this.btnCadastroProcedimento.Text = " Procedimentos";
            this.btnCadastroProcedimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroProcedimento.UseVisualStyleBackColor = true;
            this.btnCadastroProcedimento.Click += new System.EventHandler(this.btnCadastroProcedimento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "_______________________";
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btnCadastroFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFuncionario.Image")));
            this.btnCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(0, 208);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(254, 50);
            this.btnCadastroFuncionario.TabIndex = 6;
            this.btnCadastroFuncionario.Text = " Colaboradores";
            this.btnCadastroFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // panelContainerPai
            // 
            this.panelContainerPai.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainerPai.Location = new System.Drawing.Point(262, 0);
            this.panelContainerPai.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainerPai.Name = "panelContainerPai";
            this.panelContainerPai.Size = new System.Drawing.Size(918, 702);
            this.panelContainerPai.TabIndex = 1;
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1178, 706);
            this.Controls.Add(flpContainerPai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConfiguracoes";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            flpContainerPai.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelSubMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelContainerPai;
        private System.Windows.Forms.Button btnCadastroProcedimento;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroDePerfil;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnDocumentosImpressoes;
    }
}