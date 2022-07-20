using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IClinic.Forms
{
    public partial class frmConfiguracoes : Form
    {
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

        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panelContainerPai.Controls.Add(childForm);
            panelContainerPai.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            if (Autenticacao._statusCadastro() == "INCOMPLETO")
            {
                btnCadastroFuncionario_Click(sender, e);
            }
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (Autenticacao._statusCadastro() == "INCOMPLETO")
            {
                //Muda a coloração dos botoes do menu
                btnCadastroFuncionario.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnCadastroProcedimento.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroDePerfil.BackColor = Color.FromArgb(33, 34, 38);
                btnUsuario.BackColor = Color.FromArgb(33, 34, 38);
                btnDocumentosImpressoes.BackColor = Color.FromArgb(33, 34, 38);
                btnBackup.BackColor = Color.FromArgb(33, 34, 38);

                openChildForm(new Forms.Cadastro.frmProfissional());
            }
            else
            {
                if(Autenticacao._usuarioADM() == "SIM")
                {
                    //Muda a coloração dos botoes do menu
                    btnCadastroFuncionario.BackColor = Color.FromArgb(23, 24, 27);
                    //
                    btnCadastroProcedimento.BackColor = Color.FromArgb(33, 34, 38);
                    btnCadastroDePerfil.BackColor = Color.FromArgb(33, 34, 38);
                    btnUsuario.BackColor = Color.FromArgb(33, 34, 38);
                    btnDocumentosImpressoes.BackColor = Color.FromArgb(33, 34, 38);
                    btnBackup.BackColor = Color.FromArgb(33, 34, 38);

                    openChildForm(new Forms.Cadastro.frmProfissional());
                }
                else
                {
                    MessageBox.Show("Este Usuário não possui privigelios de Administrador.");
                }
            }
        }

        private void btnCadastroProcedimento_Click(object sender, EventArgs e)
        {
            if (Autenticacao._usuarioADM() == "SIM")
            {
                //Muda a coloração dos botoes do menu
                btnCadastroProcedimento.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnCadastroFuncionario.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroDePerfil.BackColor = Color.FromArgb(33, 34, 38);
                btnUsuario.BackColor = Color.FromArgb(33, 34, 38);
                btnDocumentosImpressoes.BackColor = Color.FromArgb(33, 34, 38);
                btnBackup.BackColor = Color.FromArgb(33, 34, 38);

                openChildForm(new Forms.Cadastro.frmProcedimento());
            }
            else
            {
                MessageBox.Show("Este Usuário não possui privigelios de Administrador.");
            }
        }

        private void btnCadastroDePerfil_Click(object sender, EventArgs e)
        {

            if (Autenticacao._usuarioADM() == "SIM")
            {
                //Muda a coloração dos botoes do menu
                btnCadastroDePerfil.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnCadastroFuncionario.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroProcedimento.BackColor = Color.FromArgb(33, 34, 38);
                btnUsuario.BackColor = Color.FromArgb(33, 34, 38);
                btnDocumentosImpressoes.BackColor = Color.FromArgb(33, 34, 38);
                btnBackup.BackColor = Color.FromArgb(33, 34, 38);

                openChildForm(new Forms.Cadastro.frmPerfil());
            }
            else
            {
                MessageBox.Show("Este Usuário não possui privigelios de Administrador.");
            }



        }

        private void bntUsuario_Click(object sender, EventArgs e)
        {
            if (Autenticacao._usuarioADM() == "SIM")
            {
                //Muda a coloração dos botoes do menu
                btnUsuario.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnCadastroFuncionario.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroProcedimento.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroDePerfil.BackColor = Color.FromArgb(33, 34, 38);
                btnDocumentosImpressoes.BackColor = Color.FromArgb(33, 34, 38);
                btnBackup.BackColor = Color.FromArgb(33, 34, 38);

                openChildForm(new Forms.Cadastro.frmUsuario());
            }
            else
            {
                MessageBox.Show("Este Usuário não possui privigelios de Administrador.");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (Autenticacao._usuarioADM() == "SIM")
            {
                //Muda a coloração dos botoes do menu
                btnBackup.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnCadastroFuncionario.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroProcedimento.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroDePerfil.BackColor = Color.FromArgb(33, 34, 38);
                btnUsuario.BackColor = Color.FromArgb(33, 34, 38);
                btnDocumentosImpressoes.BackColor = Color.FromArgb(33, 34, 38);

                openChildForm(new frmBackup());
            }
            else
            {
                MessageBox.Show("Este Usuário não possui privigelios de Administrador.");
            }
        }

        private void btnDocumentosImpressoes_Click(object sender, EventArgs e)
        {
            if (Autenticacao._statusCadastro() != "INCOMPLETO")
            {
                //
                openChildForm(new Forms.Cadastro.frmDocumentosImpressao());

                //Muda a coloração dos botoes do menu
                btnDocumentosImpressoes.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnCadastroFuncionario.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroProcedimento.BackColor = Color.FromArgb(33, 34, 38);
                btnCadastroDePerfil.BackColor = Color.FromArgb(33, 34, 38);
                btnUsuario.BackColor = Color.FromArgb(33, 34, 38);
                btnBackup.BackColor = Color.FromArgb(33, 34, 38);

            }
            else
            {
                MessageBox.Show("Ola, Seja bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {
            panelSubMenu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelSubMenu.Width,
            panelSubMenu.Height, 7, 7));
        } 
    }
}
