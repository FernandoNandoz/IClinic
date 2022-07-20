using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;

namespace IClinic.Forms
{
    public partial class frmAgenda : Form
    {
        #region Modelagem Panel

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

        #endregion
        //
        SqlConnection conexao = new SqlConnection("Data Source=10.0.0.42,1433;Initial Catalog=IClinicDataBase;Integrated Security=False;User ID=sa;Password=145989");

        Banco banco = new Banco();

        int tipoAcao = 0, idProcedimento = 0, idColaborador = 0;
        string status, idPacienteCad, idPacienteUpd;
        string tipoProcedimento;

        public frmAgenda()
        {
            InitializeComponent();

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            labelDataHeader.Text = DateTime.Now.ToLongDateString();
            this.pacienteTableAdapter.Fill(this.iClinicDatabaseDataSet.Paciente);
            comboBoxPesquisaPeriodo.SelectedIndex = 1;
            dadosRequestAgenda();

            monitorar();
        }

        void monitorar()
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
                dadosRequestAgenda();
            }
        }

        delegate void requestHeader();
        public void carregarHeader()
        {
            if (InvokeRequired)
            {
                requestHeader request = carregarHeader;
                Invoke(request);
            }
            else
            {
                if (comboBoxPesquisaPeriodo.Text != "Todos")
                {
                    //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                    string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO'), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'NAO COMPARECEU') FROM Agenda WHERE data = @data AND periodo = @periodo");
                    SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                    banco.conectar();

                    exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxPesquisaPeriodo.Text);

                    SqlDataReader datareader = exeVerificacao.ExecuteReader();

                    while (datareader.Read())
                    {
                        labelValueTotalAgendados.Text = datareader[0].ToString();
                        labelValueAtendimentosConfirmandos.Text = datareader[1].ToString();
                        labelValuePacienteFaltou.Text = datareader[2].ToString();
                    }
                    banco.desconectar();

                    preenchendoDataGridView();
                }
                else
                {
                    //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                    string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO'), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'NAO COMPARECEU') FROM Agenda WHERE data = @data");
                    SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                    banco.conectar();

                    exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));

                    SqlDataReader datareader = exeVerificacao.ExecuteReader();

                    while (datareader.Read())
                    {
                        labelValueTotalAgendados.Text = datareader[0].ToString();
                        labelValueAtendimentosConfirmandos.Text = datareader[1].ToString();
                        labelValuePacienteFaltou.Text = datareader[2].ToString();
                    }
                    banco.desconectar();

                    preenchendoDataGridView();
                }
            }
        }

        private void carregarDadosEditar()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Agenda = ("SELECT Agenda.periodo, Agenda.tipoProcedimento, Paciente.nomePaciente, Agenda.data, Colaborador.nomeProfissional, Agenda.observacao, Procedimento.nomeGenerico, Paciente.telefonePrincipal, Agenda.idPacienteFK, Agenda.idColaboradorFK, Agenda.idProcedimentoFK, Agenda.status FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador WHERE Agenda.idAgenda = @ID");
            SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@ID", int.Parse(dataGridViewAgendamentos.CurrentRow.Cells[0].Value.ToString()));

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            while (datareader.Read())
            {
                dateTimeUpdDataAtendimento.Text = datareader[3].ToString();
                comboBoxUpdPeriodo.Text = datareader[0].ToString();
                textBoxUpdProcedimento.Text = datareader[6].ToString();
                textBoxUpdNomePaciente.Text = datareader[2].ToString();
                maskUpdTelefone.Text = datareader[7].ToString();
                textBoxUpdColaborador.Text = datareader[4].ToString();
                textBoxUpdObservacao.Text = datareader[5].ToString();
                comboBoxStatus.Text = datareader[11].ToString();
                tipoProcedimento = datareader[1].ToString();
                idColaborador = int.Parse(datareader[9].ToString());
                idProcedimento = int.Parse(datareader[10].ToString());
            }
            banco.desconectar();

            preenchendoDataGridView();
        }

        delegate void dadosRequestGrid();
        public void dadosRequestAgenda()
        {
            if (InvokeRequired)
            {
                dadosRequestGrid request = dadosRequestAgenda;
                Invoke(request);

            }
            else
            {

                //Solicitacao Normal
                if (comboBoxPesquisaPeriodo.Text != "Todos" && comboBoxPesquisaPeriodo.Text != "TODOS")
                {
                    //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                    string Agenda = ("SELECT Agenda.idAgenda, Agenda.periodo, Paciente.nomePaciente, Procedimento.procedimento, Agenda.tipoProcedimento, Colaborador.nomeProfissional, Agenda.status, Agenda.data, Agenda.idPacienteFK, Agenda.idColaboradorFK, Agenda.idProcedimentoFK FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador WHERE Agenda.data = @data AND Agenda.periodo = @periodo AND Agenda.status != 'EM ATENDIMENTO' ORDER BY nomePaciente");
                    SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                    banco.conectar();

                    exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxPesquisaPeriodo.Text);

                    SqlDataReader datareader = exeVerificacao.ExecuteReader();

                    dataGridViewAgendamentos.Rows.Clear();
                    while (datareader.Read())
                    {
                        dataGridViewAgendamentos.Rows.Add(datareader[0],
                                                    dataGridViewAgendamentos.Rows.Count + 1,
                                                    datareader[1].ToString(),
                                                    datareader[2].ToString(),
                                                    datareader[3].ToString(),
                                                    datareader[4].ToString(),
                                                    datareader[5].ToString(),
                                                    datareader[6].ToString(),
                                                    datareader[7].ToString(),
                                                    datareader[8].ToString(),
                                                    datareader[9].ToString(),
                                                    datareader[10].ToString());
                    }

                    banco.desconectar();
                    dataGridViewAgendamentos.Refresh();
                }
                else
                {
                    //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                    string Agenda = ("SELECT Agenda.idAgenda, Agenda.periodo, Paciente.nomePaciente, Procedimento.procedimento, Agenda.tipoProcedimento, Colaborador.nomeProfissional, Agenda.status, Agenda.data, Agenda.idPacienteFK, Agenda.idColaboradorFK, Agenda.idProcedimentoFK FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador WHERE Agenda.data = @data AND Agenda.status != 'EM ATENDIMENTO' ORDER BY nomePaciente");
                    SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                    banco.conectar();

                    exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                    SqlDataReader datareader = exeVerificacao.ExecuteReader();

                    dataGridViewAgendamentos.Rows.Clear();

                    while (datareader.Read())
                    {
                        dataGridViewAgendamentos.Rows.Add(datareader[0].ToString(),
                                                    dataGridViewAgendamentos.Rows.Count + 1,
                                                    datareader[1].ToString(),
                                                    datareader[2].ToString(),
                                                    datareader[3].ToString(),
                                                    datareader[4].ToString(),
                                                    datareader[5].ToString(),
                                                    datareader[6].ToString(),
                                                    datareader[7].ToString(),
                                                    datareader[8].ToString(),
                                                    datareader[9].ToString(),
                                                    datareader[10].ToString());
                    }

                    banco.desconectar();
                    dataGridViewAgendamentos.Refresh();
                }
            }

            carregarHeader();
        }

        private void dadosRequestPesquisaPaciente()
        {
            if (tipoAcao == 1)
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT idPaciente, telefonePrincipal FROM Paciente WHERE (nomePaciente LIKE @nome + '%') ORDER BY nomePaciente");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@nome", textBoxCadNomePaciente.Text);

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    idPacienteCad = datareader[0].ToString();
                    maskCadTelefone.Text = datareader[1].ToString();
                }
                banco.desconectar();
            }

            if (tipoAcao == 2)
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT idPaciente, telefonePrincipal FROM Paciente WHERE (nomePaciente LIKE @nome + '%') ORDER BY nomePaciente");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@nome", textBoxUpdNomePaciente.Text);

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    idPacienteUpd = datareader[0].ToString();
                    maskUpdTelefone.Text = datareader[1].ToString();
                }
                banco.desconectar();
            }
        }

        private void preenchendoDataGridView()
        {
            if (tipoAcao == 1)
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT Agenda.periodo, Agenda.tipoProcedimento, Paciente.nomePaciente FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente WHERE Agenda.periodo = @periodo AND Agenda.data = @data");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxCadPeriodo.Text);
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(dateTimeCadDataAtendimento.Text));

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                dataGridViewCadHorarios.Rows.Clear();

                while (datareader.Read())
                {
                    dataGridViewCadHorarios.Rows.Add(dataGridViewCadHorarios.Rows.Count + 1,
                                              datareader[0].ToString(),
                                              datareader[1].ToString(),
                                              datareader[2].ToString());
                }

                banco.desconectar();
                dataGridViewCadHorarios.Refresh();
            }

            if (tipoAcao == 2)
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT Agenda.periodo, Agenda.tipoProcedimento, Paciente.nomePaciente FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador WHERE Agenda.periodo = @periodo AND Agenda.data = @data");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxUpdPeriodo.Text);
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(DateTime.Now).ToShortDateString()));

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                dataGridViewUpdHorarios.Rows.Clear();
                while (datareader.Read())
                {
                    dataGridViewUpdHorarios.Rows.Add(dataGridViewUpdHorarios.Rows.Count + 1,
                                              datareader[0].ToString(),
                                              datareader[1].ToString(),
                                              datareader[2].ToString());
                }

                banco.desconectar();
                dataGridViewUpdHorarios.Refresh();
            }
        }

        private void pesquisaAutoCompleteProcedimento()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nomeGenerico FROM Procedimento", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxProcedimento.AutoCompleteCustomSource = lista;

                banco.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisaAutoCompleteUpdProcedimento()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nomeGenerico FROM Procedimento", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();


                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxUpdProcedimento.AutoCompleteCustomSource = lista;

                banco.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisaAutoCompletaColaborador()
        {
            SqlCommand exePesquisa = new SqlCommand("SELECT nomeProfissional FROM Colaborador WHERE tipoColaborador = 'Profissional da Saude'", banco.connection);
            banco.conectar();
            SqlDataReader dr = exePesquisa.ExecuteReader();
            var lista = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
            }

            textBoxColaborador.AutoCompleteCustomSource = lista;

            banco.desconectar();
        }

        private void pesquisaAutoCompleteUpdColaborador()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nomeProfissional FROM Colaborador WHERE tipoColaborador = 'Profissional da Saude'", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxColaborador.AutoCompleteCustomSource = lista;

                banco.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisaAutoCompleteCadPaciente()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nomePaciente FROM Paciente", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxCadNomePaciente.AutoCompleteCustomSource = lista;

                banco.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisaAutoCompleteUpdPaciente()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nomePaciente FROM Paciente", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxUpdNomePaciente.AutoCompleteCustomSource = lista;

                banco.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gerarLog()
        {
            Log.gerarLog("");
        }

        private void limparValores()
        {
            //
            textBoxPesquisaNome.Clear();
            //
            dateTimeCadDataAtendimento.Text = DateTime.Now.ToString();
            comboBoxCadPeriodo.Text = ("");
            textBoxProcedimento.Text = ("");
            textBoxCadNomePaciente.Clear();
            maskCadTelefone.Clear();
            textBoxColaborador.Text = ("");
            textBoxCadObservacao.Clear();
            dataGridViewCadHorarios.Rows.Clear();
            //
            dateTimeUpdDataAtendimento.Text = DateTime.Now.ToString();
            comboBoxUpdPeriodo.Text = ("");
            textBoxUpdProcedimento.Text = ("");
            textBoxUpdNomePaciente.Clear();
            maskUpdTelefone.Clear();
            textBoxUpdColaborador.Text = ("");
            textBoxUpdObservacao.Clear();
            dataGridViewUpdHorarios.Rows.Clear();
        }

        private void insertQuery()
        {
            string Agenda = ("INSERT INTO Agenda (status, data, observacao, periodo, tipoProcedimento, idProcedimentoFK, idPacienteFK, idColaboradorFK, codigoLog) VALUES (@status, @data, @observacao, @periodo, @tipoProcedimento, @idProcedimentoFK, @idPacienteFK, @idColaboradorFK, @codigoLog)");
            SqlCommand CadAgenda = new SqlCommand(Agenda, banco.connection);

            CadAgenda.Parameters.AddWithValue("@status", status);
            CadAgenda.Parameters.AddWithValue("@data", DateTime.Parse(dateTimeCadDataAtendimento.Text));
            CadAgenda.Parameters.AddWithValue("@observacao", textBoxCadObservacao.Text);
            CadAgenda.Parameters.AddWithValue("@periodo", comboBoxCadPeriodo.Text);
            CadAgenda.Parameters.AddWithValue("@tipoProcedimento", tipoProcedimento);
            CadAgenda.Parameters.AddWithValue("@idProcedimentoFK", idProcedimento);
            CadAgenda.Parameters.AddWithValue("@idPacienteFK", int.Parse(idPacienteCad));
            CadAgenda.Parameters.AddWithValue("@idColaboradorFK", idColaborador);
            CadAgenda.Parameters.AddWithValue("@codigoLog", Log._retornarLog());


            banco.conectar();
            CadAgenda.ExecuteNonQuery();
            banco.desconectar();
        }

        private void updateQuery()
        {
            string Agenda = ("UPDATE Agenda SET status = @status, data = @data, observacao = @observacao, periodo = @periodo, tipoProcedimento = @tipoProcedimento, idProcedimentoFK = @idProcedimentoFK, idPacienteFK = @idPacienteFK, idColaboradorFK = @idColaboradorFK, codigoLog = @codigoLog WHERE idAgenda = @ID");
            SqlCommand UpdAgenda = new SqlCommand(Agenda, banco.connection);

            UpdAgenda.Parameters.AddWithValue("@status", comboBoxStatus.Text);
            UpdAgenda.Parameters.AddWithValue("@data", DateTime.Parse(dateTimeUpdDataAtendimento.Text));
            UpdAgenda.Parameters.AddWithValue("@observacao", textBoxUpdObservacao.Text);
            UpdAgenda.Parameters.AddWithValue("@periodo", comboBoxUpdPeriodo.Text);
            UpdAgenda.Parameters.AddWithValue("@tipoProcedimento", tipoProcedimento);
            UpdAgenda.Parameters.AddWithValue("@idProcedimentoFK", idProcedimento);
            UpdAgenda.Parameters.AddWithValue("@idPacienteFK", int.Parse(dataGridViewAgendamentos.CurrentRow.Cells[9].Value.ToString()));
            UpdAgenda.Parameters.AddWithValue("@idColaboradorFK", idColaborador);
            UpdAgenda.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
            UpdAgenda.Parameters.AddWithValue("@ID", int.Parse(dataGridViewAgendamentos.CurrentRow.Cells[0].Value.ToString()));


            banco.conectar();
            UpdAgenda.ExecuteNonQuery();
            banco.desconectar();
        }

        #region Pesquisa

        private void datePesquisaData_ValueChanged(object sender, EventArgs e)
        {
            dadosRequestAgenda();
        }

        private void comboBoxPesquisaPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadosRequestAgenda();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Agenda = ("SELECT Agenda.idAgenda, Agenda.periodo, Paciente.nomePaciente, Procedimento.procedimento, Agenda.tipoProcedimento, Colaborador.nomeProfissional, Agenda.status, Agenda.data, Agenda.idPacienteFK, Agenda.idColaboradorFK, Agenda.idProcedimentoFK FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador WHERE Agenda.data = @data AND Agenda.periodo = @periodo AND Paciente.nomePaciente LIKE @nome + '%' ORDER BY nomePaciente");
            SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Text).ToShortDateString()));
            exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxPesquisaPeriodo.Text);
            exeVerificacao.Parameters.AddWithValue("@nome", textBoxPesquisaNome.Text);

            SqlDataReader datareader = exeVerificacao.ExecuteReader();


            dataGridViewAgendamentos.Rows.Clear();
            for (int i = 0; i < 100; i++)
            {
                while (datareader.Read())
                {
                    dataGridViewAgendamentos.Rows.Add(datareader[0].ToString(),
                                                dataGridViewAgendamentos.Rows.Count + 1,
                                                datareader[1].ToString(),
                                                datareader[2].ToString(),
                                                datareader[3].ToString(),
                                                datareader[4].ToString(),
                                                datareader[5].ToString(),
                                                datareader[6].ToString(),
                                                datareader[7].ToString(),
                                                datareader[8].ToString(),
                                                datareader[9].ToString(),
                                                datareader[10].ToString());
                }
            }
            banco.desconectar();
            dataGridViewAgendamentos.Refresh();
        }

        #endregion

        #region Novo Agendamento

        private void btnNovoAgendamento_Click(object sender, EventArgs e)
        {
            pesquisaAutoCompleteCadPaciente();
            pesquisaAutoCompleteProcedimento();
            pesquisaAutoCompletaColaborador();

            limparValores();

            tipoAcao = 1;

            if (panelNovoAgendamento.Visible != true)
            {
                panelAgenda.Visible = false;
                panelEditarAgenda.Visible = false;
                panelNovoAgendamento.Visible = true;
            }

            datePesquisaData.Enabled = false;
            comboBoxPesquisaPeriodo.Enabled = false;
            textBoxPesquisaNome.Enabled = false;
            btnPesquisar.Enabled = false;
            //
            btnNovoAgendamento.Enabled = false;
            btnConfirmarChegada.Enabled = false;
            btnNaoCompareceu.Enabled = false;
            btnEditarAgendamento.Enabled = false;
            btnCancelarAgendamento.Enabled = false;

            labelCadTituloDataGrid.Text = "Agenda do dia...";
            comboBoxCadPeriodo.Focus();
        }

        private void btnCadConcluir_Click(object sender, EventArgs e)
        {
            if (comboBoxCadPeriodo.Text != ("")
                && textBoxCadNomePaciente.Text != ("")
                && textBoxProcedimento.Text != ("")
                && textBoxColaborador.Text != ("")
                )
            {
                status = "AGENDADO";

                gerarLog();

                insertQuery();

                preenchendoDataGridView();
                dadosRequestAgenda();
                carregarHeader();

                //limpa todos os valores
                limparValores();

                MessageBox.Show("Agendamento realizado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Menssagem de alerta, caso a senhas sejam diferentes
                MessageBox.Show("O Agendamento não pôde ser realizado." + "\n" + "As Senhas informadas são diferente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCadSair_Click(object sender, EventArgs e)
        {
            limparValores();

            if (panelAgenda.Visible != true)
            {
                panelNovoAgendamento.Visible = false;
                panelEditarAgenda.Visible = false;
                panelAgenda.Visible = true;
            }

            datePesquisaData.Enabled = true;
            comboBoxPesquisaPeriodo.Enabled = true;
            textBoxPesquisaNome.Enabled = true;
            btnPesquisar.Enabled = true;
            //
            btnNovoAgendamento.Enabled = true;
            btnConfirmarChegada.Enabled = true;
            btnNaoCompareceu.Enabled = true;
            btnEditarAgendamento.Enabled = true;
            btnCancelarAgendamento.Enabled = true;
        }

        private void dateTimeCadDataAtendimento_ValueChanged(object sender, EventArgs e)
        {
            comboBoxCadPeriodo.Text = "";
            //
            dataGridViewCadHorarios.Rows.Clear();
            //
            labelCadTituloDataGrid.Text = ("Agenda do dia - " + dateTimeCadDataAtendimento.Text + " - " + comboBoxCadPeriodo.Text);
        }

        private void comboBoxCadPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCadTituloDataGrid.Text = ("Agenda do dia - " + dateTimeCadDataAtendimento.Text + " - " + comboBoxCadPeriodo.Text);
            //
            preenchendoDataGridView();
        }

        private void textBoxCadNomePaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxCadNomePaciente.Text != "")
                {
                    dadosRequestPesquisaPaciente();

                    textBoxColaborador.Focus();
                }
            }
        }

        private void linkLabelCadNovoPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPacientes newWindow = new frmPacientes();
            newWindow.ShowDialog();
            newWindow.Dispose();

            //Verifica por meio de uma Variavel Global o valor armazendado
            //Se for 2 (2 = Fechado), executara o codigo
            if (Verificadores._abertoFechado() == 2)
            {
                this.pacienteTableAdapter.Fill(this.iClinicDatabaseDataSet.Paciente);
            }
        }

        #endregion

        private void btnConfirmarChegada_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgendamentos.Rows.Count != 0)
            {
                status = "CONFIRMADO";

                gerarLog();

                string Agenda = ("UPDATE Agenda SET status = @status, codigoLog = @codigoLog WHERE idAgenda = @ID");
                SqlCommand UpdAgenda = new SqlCommand(Agenda, banco.connection);

                UpdAgenda.Parameters.AddWithValue("@status", status);
                UpdAgenda.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdAgenda.Parameters.AddWithValue("@ID", int.Parse(dataGridViewAgendamentos.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                UpdAgenda.ExecuteNonQuery();
                banco.desconectar();

                dadosRequestAgenda();
                carregarHeader();

                //limpa todos os valores
                limparValores();
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não foi possivel completar a ação, pois, existe Agendamento feito nesta data.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNaoCompareceu_Click(object sender, EventArgs e)
        {

            if (dataGridViewAgendamentos.Rows.Count != 0)
            {
                status = "NAO COMPARECEU";

                gerarLog();

                string Agenda = ("UPDATE Agenda SET status = @status, codigoLog = @codigoLog WHERE idAgenda = @ID");
                SqlCommand UpdAgenda = new SqlCommand(Agenda, banco.connection);

                UpdAgenda.Parameters.AddWithValue("@status", status);
                UpdAgenda.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdAgenda.Parameters.AddWithValue("@ID", int.Parse(dataGridViewAgendamentos.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                UpdAgenda.ExecuteNonQuery();
                banco.desconectar();

                dadosRequestAgenda();
                carregarHeader();

                //limpa todos os valores
                limparValores();
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não foi possivel completar a ação, pois, existe Agendamento feito nesta data.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Editar Agenda

        private void btnEditarAgendamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgendamentos.Rows.Count != 0)
            {
                limparValores();

                tipoAcao = 2;
                pesquisaAutoCompleteUpdPaciente();

                if (panelEditarAgenda.Visible != true)
                {
                    panelAgenda.Visible = false;
                    panelNovoAgendamento.Visible = false;
                    panelEditarAgenda.Visible = true;
                }

                datePesquisaData.Enabled = false;
                comboBoxPesquisaPeriodo.Enabled = false;
                textBoxPesquisaNome.Enabled = false;
                btnPesquisar.Enabled = false;
                //
                btnNovoAgendamento.Enabled = false;
                btnConfirmarChegada.Enabled = false;
                btnNaoCompareceu.Enabled = false;
                btnEditarAgendamento.Enabled = false;
                btnCancelarAgendamento.Enabled = false;

                labelUpdTituloDataGrid.Text = ("Agenda do dia - ");

                carregarDadosEditar();
                pesquisaAutoCompleteUpdProcedimento();
                pesquisaAutoCompleteUpdColaborador();
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não foi possivel completar a ação, pois, existe Agendamento feito nesta data.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdConcluir_Click(object sender, EventArgs e)
        {
            if (comboBoxUpdPeriodo.Text != ("")
                && textBoxUpdNomePaciente.Text != ("")
                && textBoxUpdProcedimento.Text != ("")
                && textBoxUpdColaborador.Text != ("")
                )
            {
                gerarLog();
                dadosRequestPesquisaPaciente();

                updateQuery();

                preenchendoDataGridView();
                dadosRequestAgenda();
                carregarHeader();

                //limpa todos os valores
                limparValores();

                MessageBox.Show("Alteração realizada com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Menssagem de alerta, caso a senhas sejam diferentes
                MessageBox.Show("A Alteração não pôde ser realizada." + "\n" + "As Senhas informadas são diferente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdSair_Click(object sender, EventArgs e)
        {
            limparValores();

            if (panelAgenda.Visible != true)
            {
                panelNovoAgendamento.Visible = false;
                panelEditarAgenda.Visible = false;
                panelAgenda.Visible = true;
            }

            datePesquisaData.Enabled = true;
            comboBoxPesquisaPeriodo.Enabled = true;
            textBoxPesquisaNome.Enabled = true;
            btnPesquisar.Enabled = true;
            //
            btnNovoAgendamento.Enabled = true;
            btnConfirmarChegada.Enabled = true;
            btnNaoCompareceu.Enabled = true;
            btnEditarAgendamento.Enabled = true;
            btnCancelarAgendamento.Enabled = true;
        }

        private void dateTimeUpdDataAtendimento_ValueChanged(object sender, EventArgs e)
        {
            comboBoxUpdPeriodo.Text = "";
            //
            dataGridViewUpdHorarios.Rows.Clear();
            //
            labelUpdTituloDataGrid.Text = ("Agenda do dia - " + dateTimeUpdDataAtendimento.Text + " - " + comboBoxUpdPeriodo.Text);

        }

        private void comboBoxUpdPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelUpdTituloDataGrid.Text = ("Agenda do dia - " + dateTimeUpdDataAtendimento.Text + " - " + comboBoxUpdPeriodo.Text);
        }

        private void linkLabelUpdNovoPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPacientes newWindow = new frmPacientes();
            newWindow.ShowDialog();
            newWindow.Dispose();

            //Verifica por meio de uma Variavel Global o valor armazendado
            //Se for 2 (2 = Fechado), executara o codigo
            if (Verificadores._abertoFechado() == 2)
            {
                this.pacienteTableAdapter.Fill(this.iClinicDatabaseDataSet.Paciente);
            }
        }

        private void textBoxUpdNomePaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxUpdNomePaciente.Text == "")
                {
                    dadosRequestPesquisaPaciente();

                    textBoxUpdColaborador.Focus();
                }
            }
        }

        #endregion

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgendamentos.Rows.Count != 0)
            {
                status = "CANCELADO";

                //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
                if (MessageBox.Show("Tem certeza que deseja Cancelar esse Agendamento?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    gerarLog();

                    string Agenda = ("UPDATE Agenda SET status = @status, codigoLog = @codigoLog WHERE idAgenda = @ID");
                    SqlCommand UpdAgenda = new SqlCommand(Agenda, banco.connection);

                    UpdAgenda.Parameters.AddWithValue("@status", status);
                    UpdAgenda.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                    UpdAgenda.Parameters.AddWithValue("@ID", int.Parse(dataGridViewAgendamentos.CurrentRow.Cells[0].Value.ToString()));

                    banco.conectar();
                    UpdAgenda.ExecuteNonQuery();
                    banco.desconectar();

                    MessageBox.Show("Agendamento Cancelado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dadosRequestAgenda();
                    carregarHeader();

                    //limpa todos os valores
                    limparValores();
                }
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não foi possivel completar a ação, pois, existe Agendamento feito nesta data.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewAgendamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridViewAgendamentos.Rows.Count - 0; ++i)
            {
                if (dataGridViewAgendamentos.Rows[i].Cells[7].Value.ToString() == "AGENDADO")
                {
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.BackColor = Color.Teal;
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.DarkCyan;
                }

                if (dataGridViewAgendamentos.Rows[i].Cells[7].Value.ToString() == "CONFIRMADO")
                {
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.BackColor = Color.SeaGreen;
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.FromArgb(1, 147, 59);
                }

                if (dataGridViewAgendamentos.Rows[i].Cells[7].Value.ToString() == "NAO COMPARECEU")
                {
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(192, 64, 0);
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.OrangeRed;
                }

                if (dataGridViewAgendamentos.Rows[i].Cells[7].Value.ToString() == "REAGENDADO")
                {
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.BackColor = Color.DarkOrange;
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.Orange;
                }

                if (dataGridViewAgendamentos.Rows[i].Cells[7].Value.ToString() == "CANCELADO")
                {
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.BackColor = Color.Firebrick;
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.Brown;
                }

                if (dataGridViewAgendamentos.Rows[i].Cells[7].Value.ToString() == "FINALIZADO")
                {
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.BackColor = SystemColors.GrayText;
                    dataGridViewAgendamentos.Rows[i].Cells[7].Style.SelectionBackColor = SystemColors.WindowFrame;
                }
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

        private void panelAgenda_Paint(object sender, PaintEventArgs e)
        {
            panelAgenda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAgenda.Width,
            panelAgenda.Height, 7, 7));
        }

        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dependency.Stop();
        }

        private void textBoxColaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Colaborador = ("SELECT idColaborador, nomeProfissional FROM Colaborador WHERE nomeProfissional = @nome");
                SqlCommand exePesquisa = new SqlCommand(Colaborador, banco.connection);

                exePesquisa.Parameters.AddWithValue("@nome", textBoxColaborador.Text);

                banco.conectar();

                SqlDataReader datareader = exePesquisa.ExecuteReader();

                textBoxColaborador.Clear();
                while (datareader.Read())
                {
                    idColaborador = int.Parse(datareader[0].ToString());
                    textBoxColaborador.Text = datareader[1].ToString();
                }
                banco.desconectar();
            }
        }

        private void panelNovoAgendamento_Paint(object sender, PaintEventArgs e)
        {
            panelNovoAgendamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNovoAgendamento.Width,
            panelNovoAgendamento.Height, 7, 7));
        }

        private void panelEditarAgenda_Paint(object sender, PaintEventArgs e)
        {
            panelEditarAgenda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEditarAgenda.Width,
            panelEditarAgenda.Height, 7, 7));
        }

        private void textBoxProcedimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Procedimento = ("SELECT idProcedimento, tipoProcedimento, nomeGenerico FROM Procedimento WHERE nomeGenerico = @nome");
                SqlCommand exePesquisa = new SqlCommand(Procedimento, banco.connection);

                exePesquisa.Parameters.AddWithValue("@nome", textBoxProcedimento.Text);

                banco.conectar();

                SqlDataReader datareader = exePesquisa.ExecuteReader();

                textBoxProcedimento.Clear();
                while (datareader.Read())
                {
                    idProcedimento = int.Parse(datareader[0].ToString());
                    tipoProcedimento = datareader[1].ToString();
                    textBoxProcedimento.Text = datareader[2].ToString();
                }
                banco.desconectar();
            }
        }

    }

}
