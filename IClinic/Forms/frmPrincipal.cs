using IClinic.Models;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace IClinic
{
    public partial class frmPrincipal : Form
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

        Banco banco = new Banco();
        //
        SqlConnection conexao = new SqlConnection("Data Source=10.0.0.42,1433;Initial Catalog=IClinicDataBase;Integrated Security=False;User ID=sa;Password=145989");

        public frmPrincipal()
        {
            InitializeComponent();

            monitorar();
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
            panelDashboard.Controls.Add(childForm);
            panelDashboard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            if (Autenticacao._statusCadastro() == "COMPLETO")
            {
                labelNomeUsuarioHeader.Text = (Autenticacao._usuario() + " | " + Autenticacao._perfil());

                btnDashboard_Click(sender, e);
            }

            if (Autenticacao._statusCadastro() == "INCOMPLETO" )
            {
                labelNomeUsuarioHeader.Text = ("aguardando informações profissionais");

                btnConfiguracoes_Click(sender, e);
            }

            if (Autenticacao._statusCadastro() == "DESATIVADO")
            {
                labelNomeUsuarioHeader.Text = (Autenticacao._usuario() + " | " + Autenticacao._perfil());

                btnDashboard_Click(sender, e);
            }

        }

        void monitorar()
        {
            var updateOfModel = new UpdateOfModel<Models.Colaborador>();
            updateOfModel.Add(i => i.usuario);
            updateOfModel.Add(i => i.tipoColaborador);
            updateOfModel.Add(i => i.sexo);
            updateOfModel.Add(i => i.cpf);
            updateOfModel.Add(i => i.telefone);

            var tableDependency = new SqlTableDependency<Models.Colaborador>(
                conexao.ConnectionString,
                "Colaborador",
                updateOf: updateOfModel);

            tableDependency.OnChanged += Dependency_OnChanged;

            tableDependency.Start();

        }

        private void Dependency_OnChanged(object sender, RecordChangedEventArgs<Models.Colaborador> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                requestData();
            }
        }

        delegate void Request();
        private void requestData()
        {
            if (InvokeRequired)
            {
                Request request = requestData; 
                Invoke(request);
            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Colaborador = ("SELECT * FROM Colaborador WHERE usuario = @usuario AND senha = @senha");
                SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@usuario", Autenticacao._usuario());
                exeVerificacao.Parameters.AddWithValue("@senha", Autenticacao._senha());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                if (datareader.Read())
                {
                    Autenticacao.login(
                        int.Parse(datareader[0].ToString()),
                        datareader[2].ToString(),
                        datareader[13].ToString(),
                        datareader[14].ToString(),
                        datareader[15].ToString(),
                        datareader[1].ToString(),
                        datareader[11].ToString(),
                        datareader[19].ToString());

                    Autenticacao.status(datareader[18].ToString());

                }
                else
                {
                    MessageBox.Show("Usuário e senhsa invalidos!");
                }
                banco.desconectar();
            }

            labelNomeUsuarioHeader.Text = (Autenticacao._usuario() + " | " + Autenticacao._perfil());
        }

        #region Metodo responsavel por chamar o Panel de Logon
        private Panel activePanel = null;
        private void openChildPanel(Panel childPanel)
        {
            activePanel = childPanel;
            panelDashboard.Controls.Add(childPanel);
            panelDashboard.Tag = childPanel;
            childPanel.BringToFront();
            childPanel.Show();
        }
        #endregion

        #region Configurações dos Botoes do Menu Lateral
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (Autenticacao._statusCadastro() != "INCOMPLETO")
            {
                //Muda a coloração dos botoes do menu
                btnDashboard.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnAgenda.BackColor = Color.FromArgb(33, 34, 38);
                btnAtendimentos.BackColor = Color.FromArgb(33, 34, 38);
                btnPacientes.BackColor = Color.FromArgb(33, 34, 38);
                btnRelatorios.BackColor = Color.FromArgb(33, 34, 38);
                btnConfiguracoes.BackColor = Color.FromArgb(33, 34, 38);


                openChildForm(new Forms.frmDashboard());
            }
            else
            {
                MessageBox.Show("Ola, Seja bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            if (Autenticacao._perfil() == "Recepcionista" || Autenticacao._usuarioADM() == "SIM")
            {
                if (Autenticacao._statusCadastro() != "INCOMPLETO")
                {
                    //Muda a coloração dos botoes do menu
                    btnAgenda.BackColor = Color.FromArgb(23, 24, 27);
                    //
                    btnDashboard.BackColor = Color.FromArgb(33, 34, 38);
                    btnAtendimentos.BackColor = Color.FromArgb(33, 34, 38);
                    btnPacientes.BackColor = Color.FromArgb(33, 34, 38);
                    btnRelatorios.BackColor = Color.FromArgb(33, 34, 38);
                    btnConfiguracoes.BackColor = Color.FromArgb(33, 34, 38);

                    openChildForm(new Forms.frmAgenda());
                }
                else
                {
                    MessageBox.Show("Ola, Seja bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Este usuário não possui permissão para acessar a Agenda.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAtendimentos_Click(object sender, EventArgs e)
        {
            if (Autenticacao._perfil() == "Profissional da Saude" || Autenticacao._usuarioADM() == "SIM")
            {
                if (Autenticacao._statusCadastro() != "INCOMPLETO")
                {
                    //Muda a coloração dos botoes do menu
                    btnAtendimentos.BackColor = Color.FromArgb(23, 24, 27);
                    //
                    btnDashboard.BackColor = Color.FromArgb(33, 34, 38);
                    btnAgenda.BackColor = Color.FromArgb(33, 34, 38);
                    btnPacientes.BackColor = Color.FromArgb(33, 34, 38);
                    btnRelatorios.BackColor = Color.FromArgb(33, 34, 38);
                    btnConfiguracoes.BackColor = Color.FromArgb(33, 34, 38);


                    openChildForm(new Forms.frmAtendimento());
                }
                else
                {
                    MessageBox.Show("Ola, Seja bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Este usuário não possui permissão para acessar o Atendimentos.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if (Autenticacao._statusCadastro() != "INCOMPLETO")
            {
                //Muda a coloração dos botoes do menu
                btnPacientes.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnDashboard.BackColor = Color.FromArgb(33, 34, 38);
                btnAgenda.BackColor = Color.FromArgb(33, 34, 38);
                btnAtendimentos.BackColor = Color.FromArgb(33, 34, 38);
                btnRelatorios.BackColor = Color.FromArgb(33, 34, 38);
                btnConfiguracoes.BackColor = Color.FromArgb(33, 34, 38);


                openChildForm(new Forms.frmPacientes());
            }
            else
            {
                MessageBox.Show("Ola, Seja bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (Autenticacao._statusCadastro() != "INCOMPLETO")
            {
                MessageBox.Show("No momento essa função encotra-se em manutenção.");
                /*//Muda a coloração dos botoes do menu
                btnRelatorios.BackColor = Color.FromArgb(23, 24, 27);
                //
                btnDashboard.BackColor = Color.FromArgb(33, 34, 38);
                btnAgenda.BackColor = Color.FromArgb(33, 34, 38);
                btnAtendimentos.BackColor = Color.FromArgb(33, 34, 38);
                btnPacientes.BackColor = Color.FromArgb(33, 34, 38);
                btnConfiguracoes.BackColor = Color.FromArgb(33, 34, 38);
                 
                 
                openChildForm(new Forms.frmRelatorio());*/
            }
            else
            {
                MessageBox.Show("Ola, Seja bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            //Muda a coloração dos botoes do menu
            btnConfiguracoes.BackColor = Color.FromArgb(23, 24, 27);
            //
            btnDashboard.BackColor = Color.FromArgb(33, 34, 38);
            btnAgenda.BackColor = Color.FromArgb(33, 34, 38);
            btnAtendimentos.BackColor = Color.FromArgb(33, 34, 38);
            btnPacientes.BackColor = Color.FromArgb(33, 34, 38);
            btnRelatorios.BackColor = Color.FromArgb(33, 34, 38);


            openChildForm(new Forms.frmConfiguracoes());
        }
        #endregion

        private void btnDetalhesLogon_Click(object sender, EventArgs e)
        {
            if (activePanel != null)
            {
                activePanel.SendToBack();
                activePanel = null;
            }
            else
            {
                openChildPanel(panelLogon);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMenuContent_Paint(object sender, PaintEventArgs e)
        {
            panelMenuContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelMenuContent.Width,
            panelMenuContent.Height, 7, 7));
        }

        private void btnTrocarUsuario_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new Forms.frmLogin()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
