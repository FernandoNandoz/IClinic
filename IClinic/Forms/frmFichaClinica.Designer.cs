namespace IClinic.Forms
{
    partial class frmFichaClinica
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
            System.Windows.Forms.Label labelAttendanceHeaderT;
            System.Windows.Forms.Label labelAbsencesHeaderT;
            System.Windows.Forms.Label labelConcludedHeaderT;
            System.Windows.Forms.Label labelTituloHeaderContent;
            System.Windows.Forms.Label labelLinhaHeaderContent;
            System.Windows.Forms.Label labelLinhaHeader;
            System.Windows.Forms.Label labelTituloOpcoesHeader;
            System.Windows.Forms.Label labelLinhaTituloOpcoes;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichaClinica));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.panelInfoHeader = new System.Windows.Forms.Panel();
            this.labelNamePatientHeader = new System.Windows.Forms.Label();
            this.labelAbsencesPatientHeader = new System.Windows.Forms.Label();
            this.labelConcludedPatientHeader = new System.Windows.Forms.Label();
            this.labelAttendancePatientHeader = new System.Windows.Forms.Label();
            this.panelOpcoesHeader = new System.Windows.Forms.Panel();
            this.btnVizualizarCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.labelValuePrimeiraConsulta = new System.Windows.Forms.Label();
            this.labelValueIdade = new System.Windows.Forms.Label();
            labelAttendanceHeaderT = new System.Windows.Forms.Label();
            labelAbsencesHeaderT = new System.Windows.Forms.Label();
            labelConcludedHeaderT = new System.Windows.Forms.Label();
            labelTituloHeaderContent = new System.Windows.Forms.Label();
            labelLinhaHeaderContent = new System.Windows.Forms.Label();
            labelLinhaHeader = new System.Windows.Forms.Label();
            labelTituloOpcoesHeader = new System.Windows.Forms.Label();
            labelLinhaTituloOpcoes = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelInfoHeader.SuspendLayout();
            this.panelOpcoesHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAttendanceHeaderT
            // 
            labelAttendanceHeaderT.AutoSize = true;
            labelAttendanceHeaderT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelAttendanceHeaderT.ForeColor = System.Drawing.SystemColors.Control;
            labelAttendanceHeaderT.Location = new System.Drawing.Point(593, 10);
            labelAttendanceHeaderT.Name = "labelAttendanceHeaderT";
            labelAttendanceHeaderT.Size = new System.Drawing.Size(126, 24);
            labelAttendanceHeaderT.TabIndex = 32;
            labelAttendanceHeaderT.Text = "Atendimentos";
            labelAttendanceHeaderT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAbsencesHeaderT
            // 
            labelAbsencesHeaderT.AutoSize = true;
            labelAbsencesHeaderT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelAbsencesHeaderT.ForeColor = System.Drawing.SystemColors.Control;
            labelAbsencesHeaderT.Location = new System.Drawing.Point(841, 10);
            labelAbsencesHeaderT.Name = "labelAbsencesHeaderT";
            labelAbsencesHeaderT.Size = new System.Drawing.Size(59, 24);
            labelAbsencesHeaderT.TabIndex = 35;
            labelAbsencesHeaderT.Text = "Faltas";
            labelAbsencesHeaderT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConcludedHeaderT
            // 
            labelConcludedHeaderT.AutoSize = true;
            labelConcludedHeaderT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelConcludedHeaderT.ForeColor = System.Drawing.SystemColors.Control;
            labelConcludedHeaderT.Location = new System.Drawing.Point(725, 10);
            labelConcludedHeaderT.Name = "labelConcludedHeaderT";
            labelConcludedHeaderT.Size = new System.Drawing.Size(105, 24);
            labelConcludedHeaderT.TabIndex = 37;
            labelConcludedHeaderT.Text = "Concluidos";
            labelConcludedHeaderT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTituloHeaderContent
            // 
            labelTituloHeaderContent.AutoSize = true;
            labelTituloHeaderContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelTituloHeaderContent.ForeColor = System.Drawing.SystemColors.Control;
            labelTituloHeaderContent.Location = new System.Drawing.Point(19, 8);
            labelTituloHeaderContent.Name = "labelTituloHeaderContent";
            labelTituloHeaderContent.Size = new System.Drawing.Size(307, 24);
            labelTituloHeaderContent.TabIndex = 15;
            labelTituloHeaderContent.Text = "Ficha de Acompanhamento Clínico";
            // 
            // labelLinhaHeaderContent
            // 
            labelLinhaHeaderContent.AutoSize = true;
            labelLinhaHeaderContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaHeaderContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelLinhaHeaderContent.Location = new System.Drawing.Point(19, 15);
            labelLinhaHeaderContent.Name = "labelLinhaHeaderContent";
            labelLinhaHeaderContent.Size = new System.Drawing.Size(1100, 24);
            labelLinhaHeaderContent.TabIndex = 16;
            labelLinhaHeaderContent.Text = "_________________________________________________________________________________" +
    "____________________________";
            // 
            // labelLinhaHeader
            // 
            labelLinhaHeader.AutoSize = true;
            labelLinhaHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelLinhaHeader.Location = new System.Drawing.Point(22, 89);
            labelLinhaHeader.Name = "labelLinhaHeader";
            labelLinhaHeader.Size = new System.Drawing.Size(880, 24);
            labelLinhaHeader.TabIndex = 33;
            labelLinhaHeader.Text = "_________________________________________________________________________________" +
    "______";
            // 
            // labelTituloOpcoesHeader
            // 
            labelTituloOpcoesHeader.AutoSize = true;
            labelTituloOpcoesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelTituloOpcoesHeader.ForeColor = System.Drawing.SystemColors.Control;
            labelTituloOpcoesHeader.Location = new System.Drawing.Point(14, 3);
            labelTituloOpcoesHeader.Name = "labelTituloOpcoesHeader";
            labelTituloOpcoesHeader.Size = new System.Drawing.Size(77, 24);
            labelTituloOpcoesHeader.TabIndex = 41;
            labelTituloOpcoesHeader.Text = "Opções";
            // 
            // labelLinhaTituloOpcoes
            // 
            labelLinhaTituloOpcoes.AutoSize = true;
            labelLinhaTituloOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelLinhaTituloOpcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            labelLinhaTituloOpcoes.Location = new System.Drawing.Point(14, 11);
            labelLinhaTituloOpcoes.Name = "labelLinhaTituloOpcoes";
            labelLinhaTituloOpcoes.Size = new System.Drawing.Size(220, 24);
            labelLinhaTituloOpcoes.TabIndex = 40;
            labelLinhaTituloOpcoes.Text = "_____________________";
            // 
            // panelInfoHeader
            // 
            this.panelInfoHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelInfoHeader.Controls.Add(label1);
            this.panelInfoHeader.Controls.Add(this.labelValueIdade);
            this.panelInfoHeader.Controls.Add(label2);
            this.panelInfoHeader.Controls.Add(this.labelValuePrimeiraConsulta);
            this.panelInfoHeader.Controls.Add(this.labelNamePatientHeader);
            this.panelInfoHeader.Controls.Add(labelConcludedHeaderT);
            this.panelInfoHeader.Controls.Add(this.labelAbsencesPatientHeader);
            this.panelInfoHeader.Controls.Add(labelAbsencesHeaderT);
            this.panelInfoHeader.Controls.Add(this.labelConcludedPatientHeader);
            this.panelInfoHeader.Controls.Add(labelAttendanceHeaderT);
            this.panelInfoHeader.Controls.Add(this.labelAttendancePatientHeader);
            this.panelInfoHeader.Controls.Add(labelLinhaHeader);
            this.panelInfoHeader.Location = new System.Drawing.Point(11, 10);
            this.panelInfoHeader.Name = "panelInfoHeader";
            this.panelInfoHeader.Size = new System.Drawing.Size(912, 120);
            this.panelInfoHeader.TabIndex = 40;
            this.panelInfoHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfoHeader_Paint);
            // 
            // labelNamePatientHeader
            // 
            this.labelNamePatientHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelNamePatientHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNamePatientHeader.Location = new System.Drawing.Point(22, 8);
            this.labelNamePatientHeader.Name = "labelNamePatientHeader";
            this.labelNamePatientHeader.Size = new System.Drawing.Size(562, 31);
            this.labelNamePatientHeader.TabIndex = 38;
            this.labelNamePatientHeader.Text = "Nome paciente";
            // 
            // labelAbsencesPatientHeader
            // 
            this.labelAbsencesPatientHeader.AutoSize = true;
            this.labelAbsencesPatientHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelAbsencesPatientHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAbsencesPatientHeader.Location = new System.Drawing.Point(853, 40);
            this.labelAbsencesPatientHeader.Name = "labelAbsencesPatientHeader";
            this.labelAbsencesPatientHeader.Size = new System.Drawing.Size(35, 37);
            this.labelAbsencesPatientHeader.TabIndex = 36;
            this.labelAbsencesPatientHeader.Text = "0";
            // 
            // labelConcludedPatientHeader
            // 
            this.labelConcludedPatientHeader.AutoSize = true;
            this.labelConcludedPatientHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelConcludedPatientHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelConcludedPatientHeader.Location = new System.Drawing.Point(760, 40);
            this.labelConcludedPatientHeader.Name = "labelConcludedPatientHeader";
            this.labelConcludedPatientHeader.Size = new System.Drawing.Size(35, 37);
            this.labelConcludedPatientHeader.TabIndex = 34;
            this.labelConcludedPatientHeader.Text = "0";
            // 
            // labelAttendancePatientHeader
            // 
            this.labelAttendancePatientHeader.AutoSize = true;
            this.labelAttendancePatientHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelAttendancePatientHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAttendancePatientHeader.Location = new System.Drawing.Point(639, 39);
            this.labelAttendancePatientHeader.Name = "labelAttendancePatientHeader";
            this.labelAttendancePatientHeader.Size = new System.Drawing.Size(35, 37);
            this.labelAttendancePatientHeader.TabIndex = 31;
            this.labelAttendancePatientHeader.Text = "0";
            // 
            // panelOpcoesHeader
            // 
            this.panelOpcoesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcoesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelOpcoesHeader.Controls.Add(this.btnVizualizarCadastro);
            this.panelOpcoesHeader.Controls.Add(this.btnSair);
            this.panelOpcoesHeader.Controls.Add(labelTituloOpcoesHeader);
            this.panelOpcoesHeader.Controls.Add(labelLinhaTituloOpcoes);
            this.panelOpcoesHeader.Location = new System.Drawing.Point(929, 10);
            this.panelOpcoesHeader.Name = "panelOpcoesHeader";
            this.panelOpcoesHeader.Size = new System.Drawing.Size(240, 120);
            this.panelOpcoesHeader.TabIndex = 41;
            this.panelOpcoesHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpcoesHeader_Paint);
            // 
            // btnVizualizarCadastro
            // 
            this.btnVizualizarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVizualizarCadastro.FlatAppearance.BorderSize = 0;
            this.btnVizualizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVizualizarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVizualizarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVizualizarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnVizualizarCadastro.Image")));
            this.btnVizualizarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVizualizarCadastro.Location = new System.Drawing.Point(18, 43);
            this.btnVizualizarCadastro.Name = "btnVizualizarCadastro";
            this.btnVizualizarCadastro.Size = new System.Drawing.Size(210, 30);
            this.btnVizualizarCadastro.TabIndex = 43;
            this.btnVizualizarCadastro.Text = " Vizualiza Cadastro";
            this.btnVizualizarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVizualizarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVizualizarCadastro.UseVisualStyleBackColor = false;
            this.btnVizualizarCadastro.Click += new System.EventHandler(this.btnVizualizarCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(18, 81);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(210, 30);
            this.btnSair.TabIndex = 42;
            this.btnSair.Text = " Voltar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelContent.Controls.Add(this.flowLayoutPanelContent);
            this.panelContent.Controls.Add(labelTituloHeaderContent);
            this.panelContent.Controls.Add(labelLinhaHeaderContent);
            this.panelContent.Location = new System.Drawing.Point(11, 141);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1158, 551);
            this.panelContent.TabIndex = 17;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelContent.AutoScroll = true;
            this.flowLayoutPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanelContent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(1158, 504);
            this.flowLayoutPanelContent.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            label2.Location = new System.Drawing.Point(35, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 22);
            label2.TabIndex = 45;
            label2.Text = "Primeira consultar:";
            // 
            // labelValuePrimeiraConsulta
            // 
            this.labelValuePrimeiraConsulta.AutoSize = true;
            this.labelValuePrimeiraConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelValuePrimeiraConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelValuePrimeiraConsulta.Location = new System.Drawing.Point(190, 79);
            this.labelValuePrimeiraConsulta.Name = "labelValuePrimeiraConsulta";
            this.labelValuePrimeiraConsulta.Size = new System.Drawing.Size(45, 22);
            this.labelValuePrimeiraConsulta.TabIndex = 44;
            this.labelValuePrimeiraConsulta.Text = "data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            label1.Location = new System.Drawing.Point(35, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 22);
            label1.TabIndex = 47;
            label1.Text = "Idade:";
            // 
            // labelValueIdade
            // 
            this.labelValueIdade.AutoSize = true;
            this.labelValueIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelValueIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.labelValueIdade.Location = new System.Drawing.Point(89, 47);
            this.labelValueIdade.Name = "labelValueIdade";
            this.labelValueIdade.Size = new System.Drawing.Size(63, 22);
            this.labelValueIdade.TabIndex = 46;
            this.labelValueIdade.Text = "x anos";
            // 
            // frmFichaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1178, 706);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelOpcoesHeader);
            this.Controls.Add(this.panelInfoHeader);
            this.Name = "frmFichaClinica";
            this.Text = "Ficha Clinica";
            this.Load += new System.EventHandler(this.frmFichaClinica_Load);
            this.panelInfoHeader.ResumeLayout(false);
            this.panelInfoHeader.PerformLayout();
            this.panelOpcoesHeader.ResumeLayout(false);
            this.panelOpcoesHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNamePatientHeader;
        private System.Windows.Forms.Label labelAbsencesPatientHeader;
        private System.Windows.Forms.Label labelConcludedPatientHeader;
        private System.Windows.Forms.Label labelAttendancePatientHeader;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVizualizarCadastro;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContent;
        private System.Windows.Forms.Panel panelInfoHeader;
        private System.Windows.Forms.Panel panelOpcoesHeader;
        private System.Windows.Forms.Label labelValuePrimeiraConsulta;
        private System.Windows.Forms.Label labelValueIdade;
    }
}