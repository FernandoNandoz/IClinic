using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace IClinic.Forms.Cadastro
{
    public partial class frmUsuario : Form
    {
        Banco banco = new Banco();

        string codigoLog;

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

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            this.colaboradorTableAdapter.queryDataUsuario(this.iClinicDatabaseDataSet.Colaborador);
            this.perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
            dataGridUsuarios.Refresh();
            banco.desconectar();
        }

        private void gerarLog()
        {
            codigoLog = ("" + DateTime.Now.Minute + ""
                        + DateTime.Now.Hour + ""
                        + DateTime.Now.Day + ""
                        + DateTime.Now.Month + ""
                        + DateTime.Now.Year + ""
                        + Autenticacao._idUsuario()
                        );

            string LogSistema = ("");
        }

        private void limparValores()
        {
            //
            textPesquisarNome.Clear();

            //Novo Cadastro
            textBoxCadNomeCompleto.Clear();
            textBoxCadUsuario.Clear();
            comboBoxCadPerfil.Text = "";
            textBoxCadSenha.Clear();
            textBoxCadRepetirSenha.Clear();

            //Editar Cadastro
            textBoxUpdNomeCompleto.Clear();
            textBoxUpdUsuario.Clear();
            comboBoxUpdPerfil.Text = "";
            textBoxUpdSenha.Clear();
            textBoxUpdRepetirSenha.Clear();
        }

        private void insertQuery()
        {
            try
            {
                string Usuario = ("INSERT INTO Colaborador (nomeColaborador, usuario, idPerfil, senha, statusCadastro, tipoColaborador, usuarioADM, codigoLog) VALUES (@nome, @usuario, @idPerfil, @senha, @statusCadastro, @tipoColaborador, @usuarioADM, @codigoLog)");
                SqlCommand cadUsuario = new SqlCommand(Usuario, banco.connection);

                //Passando dados por parametros para inserção no banco.
                cadUsuario.Parameters.AddWithValue("@nome", textBoxCadNomeCompleto.Text);
                cadUsuario.Parameters.AddWithValue("@usuario", textBoxCadUsuario.Text);
                cadUsuario.Parameters.AddWithValue("@idPerfil", comboBoxCadPerfil.SelectedValue);
                cadUsuario.Parameters.AddWithValue("@tipoColaborador", comboBoxCadPerfil.Text);
                cadUsuario.Parameters.AddWithValue("@senha", textBoxCadSenha.Text);
                cadUsuario.Parameters.AddWithValue("@statusCadastro", "INCOMPLETO");
                cadUsuario.Parameters.AddWithValue("@usuarioADM", comboBoxCadPrivilegio.Text);
                cadUsuario.Parameters.AddWithValue("@codigoLog", codigoLog);

                //Abertura do banco, salvando dados informados, e fechando banco.
                banco.conectar();
                cadUsuario.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void updateQuery()
        {
            try
            {
                string Usuario = ("UPDATE Colaborador SET nomeColaborador = @nome, usuario = @usuario, idPerfil = @idPerfil, senha = @senha, tipoColaborador = @tipoColaborador, usuarioADM = @usuarioADM, codigoLog = @codigoLog WHERE idColaborador = @ID");
                SqlCommand updUsuario = new SqlCommand(Usuario, banco.connection);

                //Passando dados por parametros para inserção no banco.
                updUsuario.Parameters.AddWithValue("@nome", textBoxUpdNomeCompleto.Text);
                updUsuario.Parameters.AddWithValue("@usuario", textBoxUpdUsuario.Text);
                updUsuario.Parameters.AddWithValue("@senha", textBoxUpdSenha.Text);
                updUsuario.Parameters.AddWithValue("@idPerfil", comboBoxUpdPerfil.SelectedValue);
                updUsuario.Parameters.AddWithValue("@tipoColaborador", comboBoxUpdPerfil.Text);
                updUsuario.Parameters.AddWithValue("@usuarioADM", comboBoxUpdPrivilegio.Text);
                updUsuario.Parameters.AddWithValue("@codigoLog", codigoLog);
                updUsuario.Parameters.AddWithValue("@ID", dataGridUsuarios.CurrentRow.Cells[0].Value.ToString());

                //Abertura do banco, salvando dados informados, e fechando banco.
                banco.conectar();
                updUsuario.ExecuteNonQuery();
                banco.desconectar();

            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A Alteração não pôde ser realizado." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteQuery()
        {
            try
            {
                string Usuario = ("DELETE FROM Colaborador WHERE idColaborador = @ID");
                SqlCommand delUsuario = new SqlCommand(Usuario, banco.connection);

                //Passando dados por parametros para delete no banco.
                delUsuario.Parameters.AddWithValue("@ID", dataGridUsuarios.CurrentRow.Cells[0].Value);

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                delUsuario.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A ação não pôde ser realizado." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.colaboradorTableAdapter.queryPesquisarUsuario(this.iClinicDatabaseDataSet.Colaborador, textPesquisarNome.Text);
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textBoxCadNomeCompleto.Focus();

            comboBoxCadPrivilegio.SelectedIndex = 0;

            if (panelNovoCadastro.Visible != true)
            {
                panelConsultarUsuario.Visible = false;
                panelEditarCadastro.Visible = false;
                panelNovoCadastro.Visible = true;

                //
                textPesquisarNome.Enabled = false;
                btnPesquisar.Enabled = false;
                btnNovoCadastro.Enabled = false;
                btnEditarCadastro.Enabled = false;
                btnVizualizarCadastro.Enabled = false;
                btnExcluirCadastro.Enabled = false;
            }
        }

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.Rows.Count != 0)
            {
                int ID = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString());

                //Limpa os valores inseridos.
                limparValores();

                //Requisição de dados filtrados
                this.colaboradorTableAdapter.queryEditarUsuario(this.iClinicDatabaseDataSet.Colaborador, ID);

                //Dar foco ao campo de teste.
                textBoxUpdNomeCompleto.Focus();

                if (panelEditarCadastro.Visible != true)
                {
                    panelConsultarUsuario.Visible = false;
                    panelNovoCadastro.Visible = false;
                    panelEditarCadastro.Visible = true;

                    //
                    textPesquisarNome.Enabled = false;
                    btnPesquisar.Enabled = false;
                    btnNovoCadastro.Enabled = false;
                    btnEditarCadastro.Enabled = false;
                    btnVizualizarCadastro.Enabled = false;
                    btnExcluirCadastro.Enabled = false;
                }
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não existe Usuarios Cadastrados.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            Reports.ReportCadastros.frmReportUsuario windows = new Reports.ReportCadastros.frmReportUsuario();
            windows.ShowDialog();
            windows.Dispose();
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (panelConsultarUsuario.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarUsuario.Visible = true;

                MessageBox.Show("Selecione o Usuario que deseja Excluir!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Autenticacao._idUsuario() != int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString()))
                {
                    if (dataGridUsuarios.Rows.Count != 0)
                    {
                        //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
                        if (MessageBox.Show("Tem certeza que deseja apagar?" + "\n" + "\n" + "Uma vez apagado, não será mais possivel recupera-lo!", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            //Limpa os valores inseridos.
                            limparValores();

                            dataGridUsuarios.Focus();

                            //chama a função para delete na tabela.
                            deleteQuery();

                            //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                            this.colaboradorTableAdapter.queryDataUsuario(this.iClinicDatabaseDataSet.Colaborador);
                            this.dataGridUsuarios.Refresh();
                            MessageBox.Show("Usuário Excluido com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //limpa todos os valores
                            limparValores();
                        }
                    }
                    else
                    {
                        //Menssagem de alerta, caso ocorra algum erro inesperado
                        MessageBox.Show("Não existe Usuarios Cadastrados.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Menssagem de alerta, caso ocorra algum erro inesperado
                    MessageBox.Show("O Sistema não permite que o Usuario delete a propria conta.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnSairNovoCadastro_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelConsultarUsuario.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarUsuario.Visible = true;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }

            this.frmCadastrarUsuario_Load(sender, e);
        }

        private void btnVoltarEditar_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelConsultarUsuario.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarUsuario.Visible = true;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }

            this.frmCadastrarUsuario_Load(sender, e);
        }

        private void btnSalvarNovoCadastro_Click(object sender, EventArgs e)
        {
            //Verifica se todo os Campos foram preenchidos.
            if (textBoxCadNomeCompleto.Text != ("")
                && textBoxCadUsuario.Text != ("")
                && comboBoxCadPerfil.Text != ("")
                && comboBoxCadPerfil.SelectedValue != ("")
                && textBoxCadSenha.Text != ("")
                )
            {
                //Verifica se as senhas informadas são iguais
                if (textBoxCadSenha.Text == textBoxCadRepetirSenha.Text)
                {
                    gerarLog();

                    //chama a função para inserção no banco de dados.
                    insertQuery();

                    //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                    this.colaboradorTableAdapter.queryDataUsuario(this.iClinicDatabaseDataSet.Colaborador);
                    this.dataGridUsuarios.Refresh();


                    MessageBox.Show("Cadastro realizado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //limpa todos os valores
                    limparValores();
                }
                else
                {
                    //Menssagem de alerta, caso a senhas sejam diferentes
                    MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "As Senhas informadas são diferente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvarEditar_Click(object sender, EventArgs e)
        {
            //Verifica se todo os Campos foram preenchidos.
            if (textBoxUpdNomeCompleto.Text != ("")
                && textBoxUpdUsuario.Text != ("")
                && comboBoxUpdPerfil.Text != ("")
                && comboBoxUpdPerfil.SelectedValue != ("")
                && textBoxUpdSenha.Text != ("")
                )
            {
                //Verifica se as senhas informadas são iguais
                if (textBoxUpdSenha.Text == textBoxUpdRepetirSenha.Text)
                {
                    gerarLog();

                    //chama a função para inserção no banco de dados.
                    updateQuery();

                    //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                    this.colaboradorTableAdapter.queryDataUsuario(this.iClinicDatabaseDataSet.Colaborador);
                    this.dataGridUsuarios.Refresh();

                    MessageBox.Show("Alteração realizada com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //limpa todos os valores
                    limparValores();
                }
                else
                {
                    //Menssagem de alerta, caso a senhas sejam diferentes
                    MessageBox.Show("A Alteração não pôde ser realizado." + "\n" + "As Senhas informadas são diferente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("A Alteração não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textPesquisarNome_KeyDown(object sender, KeyEventArgs e)
        {
            this.colaboradorTableAdapter.queryPesquisarUsuario(this.iClinicDatabaseDataSet.Colaborador, textPesquisarNome.Text);
        }

        private void linkLabelCadNovoPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Cadastro.frmPerfil newWindows = new Forms.Cadastro.frmPerfil();
            newWindows.ShowDialog();
            newWindows.Dispose();

            //Verifica por meio de uma Variavel Global o valor armazendado
            //Se for 2 (2 = Fechado), executara o codigo
            if (Verificadores._abertoFechado() == 2)
            {
                perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
                comboBoxCadPerfil.Refresh();
            }
        }

        private void linkLabelUpdNovoPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Cadastro.frmPerfil newWindows = new Forms.Cadastro.frmPerfil();
            newWindows.ShowDialog();
            newWindows.Dispose();

            //Verifica por meio de uma Variavel Global o valor armazendado
            //Se for 2 (2 = Fechado), executara o codigo
            if (Verificadores._abertoFechado() == 2)
            {
                perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
                comboBoxCadPerfil.Refresh();
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            panelMenu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelMenu.Width,
            panelMenu.Height, 7, 7));
        }

        private void flpContainerPai_Paint(object sender, PaintEventArgs e)
        {
            flpContainerPai.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpContainerPai.Width,
            flpContainerPai.Height, 7, 7));
        }

        private void panelConsultarUsuario_Paint(object sender, PaintEventArgs e)
        {
            panelConsultarUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConsultarUsuario.Width,
            panelConsultarUsuario.Height, 7, 7));
        }

        private void panelNovoCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelNovoCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNovoCadastro.Width,
            panelNovoCadastro.Height, 7, 7));
        }

        private void panelEditarCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelEditarCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEditarCadastro.Width,
            panelEditarCadastro.Height, 7, 7));
        }
    }
}
