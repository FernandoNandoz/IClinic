namespace IClinic.Forms
{
    partial class frmBackup
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
            System.Windows.Forms.Label labelTitulo;
            System.Windows.Forms.Label labelLinhaTitulo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panelConsultarUsuario = new System.Windows.Forms.Panel();
            labelTitulo = new System.Windows.Forms.Label();
            labelLinhaTitulo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(labelTitulo);
            this.panelMenu.Controls.Add(labelLinhaTitulo);
            this.panelMenu.Controls.Add(this.btnBackup);
            this.panelMenu.Location = new System.Drawing.Point(7, 8);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(900, 123);
            this.panelMenu.TabIndex = 43;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelTitulo.ForeColor = System.Drawing.SystemColors.Control;
            labelTitulo.Location = new System.Drawing.Point(25, 8);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(73, 24);
            labelTitulo.TabIndex = 33;
            labelTitulo.Text = "Backup";
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
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Teal;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(35, 62);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(828, 35);
            this.btnBackup.TabIndex = 40;
            this.btnBackup.Text = " Novo Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            // 
            // panelConsultarUsuario
            // 
            this.panelConsultarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelConsultarUsuario.Location = new System.Drawing.Point(7, 139);
            this.panelConsultarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarUsuario.Name = "panelConsultarUsuario";
            this.panelConsultarUsuario.Size = new System.Drawing.Size(900, 553);
            this.panelConsultarUsuario.TabIndex = 44;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(914, 701);
            this.Controls.Add(this.panelConsultarUsuario);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmBackup";
            this.Text = "Backup";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panelConsultarUsuario;
    }
}