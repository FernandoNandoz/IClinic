using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using IClinic.Properties;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;

namespace IClinic.Forms
{
    public partial class frmDashboard : Form
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
        //

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            carregarPerfil();

            monitorarAgenda();
        }

        void monitorarAgenda()
        {
            var updateOfModel = new UpdateOfModel<Models.Agenda>();
            updateOfModel.Add(i => i.status);
            updateOfModel.Add(i => i.codigoLog);

            var tableDependency = new SqlTableDependency<Models.Agenda>(
                conexao.ConnectionString,
                "Agenda",
                updateOf: updateOfModel);

            tableDependency.OnChanged += Dependency_OnChanged;

            tableDependency.Start();

        }

        private void Dependency_OnChanged(object sender, RecordChangedEventArgs<Models.Agenda> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                carregarContent();
            }
        }

        #region Profissional Saude

        private void carregarProfissional()
        {
            carregarHeaderProfissional();

            #region Vizualizacao Atendimento

            if (Autenticacao._usuarioADM() == "SIM")
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string AgendaVizualizacao = ("SELECT Paciente.nomePaciente, Agenda.status,Procedimento.nomeGenerico, Colaborador.nomeProfissional FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento WHERE Agenda.data = @data ORDER BY nomePaciente");
                SqlCommand exeVerificacaoVizualizacao = new SqlCommand(AgendaVizualizacao, banco.connection);
                banco.conectar();

                exeVerificacaoVizualizacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                SqlDataReader datareaderVizualizacao = exeVerificacaoVizualizacao.ExecuteReader();

                dataGridViewVizualizacaoADM.Rows.Clear();
                while (datareaderVizualizacao.Read())
                {
                    dataGridViewVizualizacaoADM.Rows.Add(dataGridViewVizualizacaoADM.Rows.Count + 1,
                                                datareaderVizualizacao[0].ToString(),
                                                datareaderVizualizacao[1].ToString(),
                                                datareaderVizualizacao[2].ToString(),
                                                datareaderVizualizacao[3].ToString());
                }

                banco.desconectar();
                dataGridViewVizualizacaoADM.Refresh();
            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string AgendaVizualizacao = ("SELECT Paciente.nomePaciente, Agenda.status,Procedimento.nomeGenerico, Colaborador.nomeProfissional FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento WHERE Agenda.data = @data AND Agenda.idColaboradorFK = @ID ORDER BY nomePaciente");
                SqlCommand exeVerificacaoVizualizacao = new SqlCommand(AgendaVizualizacao, banco.connection);
                banco.conectar();

                exeVerificacaoVizualizacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacaoVizualizacao.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

                SqlDataReader datareaderVizualizacao = exeVerificacaoVizualizacao.ExecuteReader();

                dataGridViewVizualizacaoADM.Rows.Clear();
                while (datareaderVizualizacao.Read())
                {
                    dataGridViewVizualizacaoADM.Rows.Add(dataGridViewVizualizacaoADM.Rows.Count + 1,
                                                datareaderVizualizacao[0].ToString(),
                                                datareaderVizualizacao[1].ToString(),
                                                datareaderVizualizacao[2].ToString(),
                                                datareaderVizualizacao[3].ToString());
                }

                banco.desconectar();
                dataGridViewVizualizacaoADM.Refresh();
            }

            #endregion

            #region Historico Atendimento

            if(Autenticacao._usuarioADM() == "SIM")
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string AgendaHistorico = ("SELECT Agenda.data, Agenda.periodo, Paciente.nomePaciente, Procedimento.nomeGenerico, Colaborador.nomeProfissional FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento WHERE Agenda.status = 'FINALIZADO' ORDER BY Agenda.data DESC");
                SqlCommand exeVerificacaoHistorico = new SqlCommand(AgendaHistorico, banco.connection);
                banco.conectar();

                exeVerificacaoHistorico.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                SqlDataReader datareaderHistorico = exeVerificacaoHistorico.ExecuteReader();

                dataGridViewHistoricoADM.Rows.Clear();
                while (datareaderHistorico.Read())
                {
                    dataGridViewHistoricoADM.Rows.Add(datareaderHistorico[0],
                                                datareaderHistorico[1].ToString(),
                                                datareaderHistorico[2].ToString(),
                                                datareaderHistorico[3].ToString(),
                                                datareaderHistorico[4].ToString());
                }

                banco.desconectar();
                dataGridViewHistoricoADM.Refresh();
            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string AgendaHistorico = ("SELECT Agenda.data, Agenda.periodo, Paciente.nomePaciente, Procedimento.nomeGenerico, Colaborador.nomeProfissional FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento WHERE Agenda.idColaboradorFK = @ID AND Agenda.status = 'FINALIZADO' ORDER BY Agenda.data DESC");
                SqlCommand exeVerificacaoHistorico = new SqlCommand(AgendaHistorico, banco.connection);
                banco.conectar();

                exeVerificacaoHistorico.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacaoHistorico.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

                SqlDataReader datareaderHistorico = exeVerificacaoHistorico.ExecuteReader();

                dataGridViewHistoricoADM.Rows.Clear();
                while (datareaderHistorico.Read())
                {
                    dataGridViewHistoricoADM.Rows.Add(datareaderHistorico[0],
                                                datareaderHistorico[1].ToString(),
                                                datareaderHistorico[2].ToString(),
                                                datareaderHistorico[3].ToString(),
                                                datareaderHistorico[4].ToString());
                }

                banco.desconectar();
                dataGridViewHistoricoADM.Refresh();
            }

            #endregion

        }

        private void carregarHeaderProfissional()
        {
            int TotalAgendado = 0, TotalConfirmado = 0, TotalAtendido = 0, resultadoNaoCompareceu = 0;

            if(Autenticacao._usuarioADM() == "SIM")
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO'), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'NAO COMPARECEU'), (SELECT COUNT(*) FROM Agenda WHERE data = @dataAtendidos AND status = 'FINALIZADO') FROM Agenda WHERE data = @data");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataAtendidos", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    TotalAgendado = int.Parse(datareader[0].ToString());
                    TotalConfirmado = int.Parse(datareader[1].ToString());
                    TotalAtendido = int.Parse(datareader[3].ToString());

                    resultadoNaoCompareceu = TotalAgendado - TotalConfirmado - TotalAtendido;

                    labelValueTotalAgendadoADM.Text = datareader[0].ToString();
                    labelValueTotalConfirmadoADM.Text = datareader[1].ToString();
                    labelValueTotalNaoCompareceuADM.Text = resultadoNaoCompareceu.ToString();
                    labelValueTotalAtendidoADM.Text = datareader[3].ToString();
                }
                banco.desconectar();
            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO' AND Agenda.idColaboradorFK = @idTotalConfirmado), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'NAO COMPARECEU' AND Agenda.idColaboradorFK = @idTotalNaoCompareceu), (SELECT COUNT(*) FROM Agenda WHERE data = @dataAtendidos AND status = 'FINALIZADO' AND Agenda.idColaboradorFK = @idTotalFinalizado) FROM Agenda WHERE data = @data AND Agenda.idColaboradorFK = @idTotalAgendado");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataAtendidos", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@idTotalAgendado", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idTotalConfirmado", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idTotalNaoCompareceu", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idTotalFinalizado", Autenticacao._idUsuario());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    TotalAgendado = int.Parse(datareader[0].ToString());
                    TotalConfirmado = int.Parse(datareader[1].ToString());
                    TotalAtendido = int.Parse(datareader[3].ToString());

                    resultadoNaoCompareceu = TotalAgendado - TotalConfirmado - TotalAtendido;

                    labelValueTotalAgendadoADM.Text = datareader[0].ToString();
                    labelValueTotalConfirmadoADM.Text = datareader[1].ToString();
                    labelValueTotalNaoCompareceuADM.Text = resultadoNaoCompareceu.ToString();
                    labelValueTotalAtendidoADM.Text = datareader[3].ToString();
                }
                banco.desconectar();
            }
            
        }

        #endregion

        #region Recepcao

        private void carregarRecepcao()
        {
            carregarHeaderRecepcao();

            if(Autenticacao._usuarioADM() == "SIM")
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT Paciente.nomePaciente, Agenda.status,Procedimento.nomeGenerico, Colaborador.nomeProfissional FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento WHERE Agenda.data = @data ORDER BY nomePaciente");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                dataGridViewRecepcao.Rows.Clear();
                while (datareader.Read())
                {
                    dataGridViewRecepcao.Rows.Add(dataGridViewRecepcao.Rows.Count + 1,
                                                datareader[0].ToString(),
                                                datareader[1].ToString(),
                                                datareader[2].ToString(),
                                                datareader[3].ToString());
                }

                banco.desconectar();
                dataGridViewRecepcao.Refresh();
            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT Paciente.nomePaciente, Agenda.status,Procedimento.nomeGenerico, Colaborador.nomeProfissional FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento WHERE Agenda.data = @data AND Agenda.idColaboradorFK = @ID ORDER BY nomePaciente");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                dataGridViewRecepcao.Rows.Clear();
                while (datareader.Read())
                {
                    dataGridViewRecepcao.Rows.Add(dataGridViewRecepcao.Rows.Count + 1,
                                                datareader[0].ToString(),
                                                datareader[1].ToString(),
                                                datareader[2].ToString(),
                                                datareader[3].ToString());
                }

                banco.desconectar();
                dataGridViewRecepcao.Refresh();
            }
            
        }

        private void carregarHeaderRecepcao()
        {
            int TotalAgendado = 0, TotalConfirmado = 0, TotalAtendido = 0, resultadoNaoCompareceu = 0;

            if(Autenticacao._usuarioADM() == "SIM")
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO'), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'NAO COMPARECEU'), (SELECT COUNT(*) FROM Agenda WHERE data = @dataAtendidos AND status = 'FINALIZADO') FROM Agenda WHERE data = @data");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataAtendidos", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    TotalAgendado = int.Parse(datareader[0].ToString());
                    TotalConfirmado = int.Parse(datareader[1].ToString());
                    TotalAtendido = int.Parse(datareader[3].ToString());

                    resultadoNaoCompareceu = TotalAgendado - TotalConfirmado - TotalAtendido;

                    labelValueTotalAgendados.Text = datareader[0].ToString();
                    labelValueTotalConfirmado.Text = datareader[1].ToString();
                    labelValueTotalNaoCompareceu.Text = resultadoNaoCompareceu.ToString();
                    labelValueTotalAtendidos.Text = datareader[3].ToString();
                }
                banco.desconectar();
            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO' AND Agenda.idColaboradorFK = @idTotalConfirmado), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'NAO COMPARECEU' AND Agenda.idColaboradorFK = @idTotalNaoCompareceu), (SELECT COUNT(*) FROM Agenda WHERE data = @dataAtendidos AND status = 'FINALIZADO' AND Agenda.idColaboradorFK = @idTotalFinalizado) FROM Agenda WHERE data = @data AND Agenda.idColaboradorFK = @idTotalAgendado");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataAtendidos", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@idTotalAgendado", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idTotalConfirmado", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idTotalNaoCompareceu", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idTotalFinalizado", Autenticacao._idUsuario());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    TotalAgendado = int.Parse(datareader[0].ToString());
                    TotalConfirmado = int.Parse(datareader[1].ToString());
                    TotalAtendido = int.Parse(datareader[3].ToString());

                    resultadoNaoCompareceu = TotalAgendado - TotalConfirmado - TotalAtendido;

                    labelValueTotalAgendados.Text = datareader[0].ToString();
                    labelValueTotalConfirmado.Text = datareader[1].ToString();
                    labelValueTotalNaoCompareceu.Text = resultadoNaoCompareceu.ToString();
                    labelValueTotalAtendidos.Text = datareader[3].ToString();
                }
                banco.desconectar();
            }
        }

        #endregion

        delegate void RequestContent(); 
        private void carregarContent()
        {
            if (InvokeRequired)
            {
                RequestContent request = carregarContent;
                Invoke(request);
            }
            else
            {
                flpProfissionalSaude.AutoScroll = false;

                if (labelValuePerfilColaborador.Text == "Recepcionista" && Autenticacao._statusCadastro() != "DESATIVADO")
                {
                    panelRecepção.Visible = true;
                    flpProfissionalSaude.Visible = false;
                    panelAtendimentosRecentes.Visible = false;
                    panelExtra.Visible = false;

                    //
                    carregarRecepcao();
                }
                if (labelValuePerfilColaborador.Text == "Profissional da Saude" && Autenticacao._statusCadastro() != "DESATIVADO")
                {
                    panelRecepção.Visible = false;
                    flpProfissionalSaude.Visible = true;

                    panelAtendimentosRecentes.Visible = true;
                    buttonVizualizarAtemdimentoRescentes.Visible = true;

                    panelExtra.Visible = false;

                    carregarProfissional();
                }
                if (Autenticacao._statusCadastro() == "DESATIVADO")
                {
                    panelRecepção.Visible = false;
                    flpProfissionalSaude.Visible = false;
                    panelAtendimentosRecentes.Visible = false;
                    panelExtra.Visible = true;
                }
            }
        }

        delegate void Request();
        private void carregarPerfil()
        {
            if (InvokeRequired)
            {
                Request request = carregarPerfil;
                Invoke(request);
            }
            else
            {
                if(Autenticacao._perfil() == "Recepcionista")
                {
                    string Colaborador = ("SELECT imagemPerfil, nomeColaborador, nomeProfissional, tipoColaborador, especialidade, sexo, (SELECT COUNT(*) FROM Agenda WHERE Agenda.data = @data) FROM Colaborador WHERE idColaborador = @ID");
                    SqlCommand exeColaborador = new SqlCommand(Colaborador, banco.connection);

                    exeColaborador.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());
                    exeColaborador.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                    banco.conectar();

                    SqlDataReader datareader = exeColaborador.ExecuteReader();

                    while (datareader.Read())
                    {
                        labelValueNome.Text = datareader[1].ToString();
                        labelValueNomeProfissional.Text = datareader[2].ToString();
                        labelValuePerfilColaborador.Text = datareader[3].ToString();
                        labelValueEspecialidade.Text = datareader[4].ToString();
                        labelValueTotalAtendimentoHeader.Text = datareader[6].ToString();

                        //var dataRowView = datareader[0] as DataRowView;
                        if (datareader[0].ToString() == "")
                        {
                            if (datareader[5].ToString() == "Homem")
                            {
                                pictureBoxPerfil.Image = Resources.icons8_hmem_126px;
                            }

                            if (datareader[5].ToString() == "Mulher")
                            {
                                pictureBoxPerfil.Image = Resources.icons8_mulher_26px;
                            }

                        }
                        else
                        {
                            using (var stream = new System.IO.MemoryStream((byte[])datareader[0]))
                            {
                                pictureBoxPerfil.Image = Bitmap.FromStream(stream);
                            }
                        }

                    }

                    banco.desconectar();
                }
                else
                {
                    string Colaborador = ("SELECT imagemPerfil, nomeColaborador, nomeProfissional, tipoColaborador, especialidade, sexo, (SELECT COUNT(*) FROM Agenda WHERE Agenda.status = 'FINALIZADO' AND Agenda.data = @data AND Agenda.idColaboradorFK = @idTotalAtendimento) FROM Colaborador WHERE idColaborador = @ID");
                    SqlCommand exeColaborador = new SqlCommand(Colaborador, banco.connection);

                    exeColaborador.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());
                    exeColaborador.Parameters.AddWithValue("@idTotalAtendimento", Autenticacao._idUsuario());
                    exeColaborador.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                    banco.conectar();

                    SqlDataReader datareader = exeColaborador.ExecuteReader();

                    while (datareader.Read())
                    {
                        labelValueNome.Text = datareader[1].ToString();
                        labelValueNomeProfissional.Text = datareader[2].ToString();
                        labelValuePerfilColaborador.Text = datareader[3].ToString();
                        labelValueEspecialidade.Text = datareader[4].ToString();
                        labelValueTotalAtendimentoHeader.Text = datareader[6].ToString();

                        //var dataRowView = datareader[0] as DataRowView;
                        if (datareader[0].ToString() == "")
                        {
                            if (datareader[5].ToString() == "Homem")
                            {
                                pictureBoxPerfil.Image = Resources.icons8_hmem_126px;
                            }

                            if (datareader[5].ToString() == "Mulher")
                            {
                                pictureBoxPerfil.Image = Resources.icons8_mulher_26px;
                            }

                        }
                        else
                        {
                            using (var stream = new System.IO.MemoryStream((byte[])datareader[0]))
                            {
                                pictureBoxPerfil.Image = Bitmap.FromStream(stream);
                            }
                        }
                    }
                    banco.desconectar();
                }  
            }

            carregarContent();
        }

        private void panelInfoPerfil_Paint(object sender, PaintEventArgs e)
        {
            panelInfoPerfil.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInfoPerfil.Width,
            panelInfoPerfil.Height, 7, 7));
        }

        private void flpContent_Paint(object sender, PaintEventArgs e)
        {
            flpContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpContent.Width,
            flpContent.Height, 7, 7));
        }

        private void panelRecepção_Paint(object sender, PaintEventArgs e)
        {
            panelRecepção.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelRecepção.Width,
            panelRecepção.Height, 7, 7));
        }

        private void btnAlterarPerfil_Click(object sender, EventArgs e)
        {
            Verificadores.alterarPerfil(true);

            Forms.Cadastro.frmProfissional window = new Cadastro.frmProfissional();
            window.ShowDialog();
            window.Dispose();

            if(Verificadores._alterarPerfil() == true)
            {
                carregarPerfil();

                Verificadores.alterarPerfil(false);
            }
        }

        private void buttonVizualizarAtemdimentoRescentes_Click(object sender, EventArgs e)
        {
            panelAdministrador.Visible = false;
            panelAtendimentosRecentes.Visible = true;
        }

        private void buttonFecharAtemdimentoRescentes_Click(object sender, EventArgs e)
        {
            panelAtendimentosRecentes.Visible = false;
            panelAdministrador.Visible = true;
        }

    }
}