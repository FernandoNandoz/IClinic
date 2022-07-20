using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;

namespace IClinic.Forms
{
    public partial class frmAtendimento : Form
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


        public frmAtendimento()
        {
            InitializeComponent();
        }

        //Usado exclusivamente para os botões do menu Atendimento!
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
            panelContentPai.Controls.Add(childForm);
            panelContentPai.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //
        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            labelDataHeader.Text = DateTime.Now.ToLongDateString();
            //
            comboBoxPesquisaPeriodo.SelectedIndex = 0; 
            //
            dadosRequestAtendimentos();

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
                dadosRequestAtendimentos();
            }
        }

        private void gerarDadosAtendimento()
        {
            //Gera um protoclo de atendimento.
            FichaClinicaId.receberProtocolo(("" + DateTime.Now.Minute + ""
                        + DateTime.Now.Hour + ""
                        + DateTime.Now.Day + ""
                        + DateTime.Now.Month + ""
                        + DateTime.Now.Year + ""
                        + dataGridViewAtendimentos.CurrentRow.Cells[9].Value.ToString() + ""
                        + dataGridViewAtendimentos.CurrentRow.Cells[10].Value.ToString() + ""
                        + dataGridViewAtendimentos.CurrentRow.Cells[11].Value.ToString()
                        ));

            //Passa o ID do Paciente para uma variavel global.
            //Para que outro form possa le-la
            FichaClinicaId.receberID(int.Parse(dataGridViewAtendimentos.CurrentRow.Cells[9].Value.ToString()));
            FichaClinicaId.receberIdProcedimento(int.Parse(dataGridViewAtendimentos.CurrentRow.Cells[11].Value.ToString()));
            FichaClinicaId.receberIdColaborador(int.Parse(dataGridViewAtendimentos.CurrentRow.Cells[10].Value.ToString()));
            FichaClinicaId.receberIdAgenda(int.Parse(dataGridViewAtendimentos.CurrentRow.Cells[0].Value.ToString()));
        }

        delegate void requestHeader();
        private void carregarHeader()
        {
            if (InvokeRequired)
            {
                requestHeader request = carregarHeader;
                Invoke(request);

            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT COUNT(*), (SELECT COUNT(*) FROM Agenda WHERE data = @dataConfirmado AND status = 'CONFIRMADO' AND idColaboradorFK = @idConfirmado), (SELECT COUNT(*) FROM Agenda WHERE data = @dataFalta AND status = 'FINALIZADO' AND idColaboradorFK = @idFinalizado) FROM Agenda WHERE data = @data AND periodo = @periodo AND idColaboradorFK = @ID");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@dataConfirmado", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@dataFalta", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxPesquisaPeriodo.Text);
                exeVerificacao.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idConfirmado", Autenticacao._idUsuario());
                exeVerificacao.Parameters.AddWithValue("@idFinalizado", Autenticacao._idUsuario());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    labelValuePacientesAgendados.Text = datareader[0].ToString();
                    labelValuePacientesConfirmados.Text = datareader[1].ToString();
                    labelValuePacientesAtendidos.Text = datareader[2].ToString();
                }
                banco.desconectar();
            }
        }

        delegate void dadosRequestGrid();
        private void dadosRequestAtendimentos()
        {
            if (InvokeRequired)
            {
                dadosRequestGrid request = dadosRequestAtendimentos;
                Invoke(request);

            }
            else
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Agenda = ("SELECT Agenda.idAgenda, Agenda.periodo, Paciente.nomePaciente, Procedimento.procedimento, Agenda.tipoProcedimento, Colaborador.nomeProfissional, Agenda.status, Agenda.data, Agenda.idPacienteFK, Agenda.idColaboradorFK, Agenda.idProcedimentoFK FROM Agenda INNER JOIN Paciente ON Agenda.idPacienteFK = Paciente.idPaciente INNER JOIN Procedimento ON Agenda.idProcedimentoFK = Procedimento.idProcedimento INNER JOIN Colaborador ON Agenda.idColaboradorFK = Colaborador.idColaborador WHERE Agenda.data = @data AND Agenda.periodo = @periodo AND idColaboradorFK = @ID ORDER BY nomePaciente");
                SqlCommand exeVerificacao = new SqlCommand(Agenda, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                exeVerificacao.Parameters.AddWithValue("@periodo", comboBoxPesquisaPeriodo.Text);
                exeVerificacao.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();


                dataGridViewAtendimentos.Rows.Clear();

                while (datareader.Read())
                {
                    dataGridViewAtendimentos.Rows.Add(datareader[0].ToString(),
                                                dataGridViewAtendimentos.Rows.Count + 1,
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
                dataGridViewAtendimentos.Refresh();
            }

            carregarHeader();
        }

        private void gerarLog()
        {
            Log.gerarLog("");
        }

        private void refreshStatus(string status)
        {
            if (dataGridViewAtendimentos.Rows.Count != 0)
            {
                gerarLog();

                string Agenda = ("UPDATE Agenda SET status = @status, codigoLog = @codigoLog WHERE idAgenda = @ID");
                SqlCommand UpdAgenda = new SqlCommand(Agenda, banco.connection);

                UpdAgenda.Parameters.AddWithValue("@status", status);
                UpdAgenda.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdAgenda.Parameters.AddWithValue("@ID", int.Parse(dataGridViewAtendimentos.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                UpdAgenda.ExecuteNonQuery();
                banco.desconectar();

                dadosRequestAtendimentos();

                if (status == "CANCELADO")
                {
                    MessageBox.Show("Atendimento Cancelado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #region Menu

        private void datePesquisaData_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxPesquisaPeriodo.Text != "")
            {
                dadosRequestAtendimentos();
                carregarHeader();
            }
            else
            {
                MessageBox.Show("Informe um periodo!");
            }
        }

        private void comboBoxPesquisaPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadosRequestAtendimentos();
            carregarHeader();
        }

        #endregion

        private void btnNovoAtendimento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtendimentos.Rows.Count != 0)
            {
                if (dataGridViewAtendimentos.CurrentRow.Cells[7].Value.ToString() == "CANCELADO")
                {
                    MessageBox.Show("Esse Atendimento foi CANCELADO. " + "\n" + "E não pode mas ser iniciado.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (dataGridViewAtendimentos.CurrentRow.Cells[7].Value.ToString() == "AGENDADO")
                {
                    if (MessageBox.Show("Esse Paciente ainda não foi CONFIRMADO. " + "\n" + "Tem certeza que deseja Inciar esse Atendimento?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        gerarDadosAtendimento();

                        openChildForm(new Forms.frmIniciarAtendimento());

                        refreshStatus("EM ATENDIMENTO");
                       
                    }
                }

                if (dataGridViewAtendimentos.CurrentRow.Cells[7].Value.ToString() == "CONFIRMADO")
                {
                    gerarDadosAtendimento();

                    openChildForm(new Forms.frmIniciarAtendimento());

                    refreshStatus("EM ATENDIMENTO");
                }   
                
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Você não possui agendamentos para esse periodo.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Verificadores._abertoFechado() == 2)
            {
                dadosRequestAtendimentos();
            }
        }

        private void btnFichaAcompanhamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtendimentos.Rows.Count != 0)
            {
                //Passa o ID do Paciente para uma variavel global.
                //Para que outro form possa le-la
                FichaClinicaId.receberID(int.Parse(dataGridViewAtendimentos.CurrentRow.Cells[9].Value.ToString()));

                openChildForm(new Forms.frmFichaClinica());
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Você não possui agendamentos para esse periodo.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtendimentos.Rows.Count != 0)
            {
                
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Você não possui agendamentos para esse periodo.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelarAtendimento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtendimentos.Rows.Count != 0)
            {
                if (dataGridViewAtendimentos.CurrentRow.Cells[7].Value.ToString() == "CANCELADO")
                {
                    MessageBox.Show("Esse Atendimento ja está CANCELADO. " + "\n" + "E não pode mas ser cancelado.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
                    if (MessageBox.Show("Tem certeza que deseja Cancelar esse Atendimento?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        refreshStatus("CANCELADO");
                    }
                }
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Você não possui agendamentos para esse periodo.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dataGridViewAtendimentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridViewAtendimentos.Rows.Count - 0; ++i)
            {
                if (dataGridViewAtendimentos.Rows[i].Cells[7].Value.ToString() == "AGENDADO")
                {
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.BackColor = Color.Teal;
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.DarkCyan;
                }

                if (dataGridViewAtendimentos.Rows[i].Cells[7].Value.ToString() == "CONFIRMADO")
                {
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.BackColor = Color.SeaGreen;
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.FromArgb(1, 147, 59);
                }

                if (dataGridViewAtendimentos.Rows[i].Cells[7].Value.ToString() == "EM ATENDIMENTO")
                {
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.BackColor = Color.DarkSlateGray;
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.DarkSlateGray;
                }

                if (dataGridViewAtendimentos.Rows[i].Cells[7].Value.ToString() == "CANCELADO")
                {
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.BackColor = Color.Firebrick;
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.SelectionBackColor = Color.Brown;
                }

                if (dataGridViewAtendimentos.Rows[i].Cells[7].Value.ToString() == "FINALIZADO")
                {
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.BackColor = SystemColors.GrayText;
                    dataGridViewAtendimentos.Rows[i].Cells[7].Style.SelectionBackColor = SystemColors.WindowFrame;
                }
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            panelMenu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelMenu.Width,
            panelMenu.Height, 7, 7));
        }

        private void panelViewAtendimento_Paint(object sender, PaintEventArgs e)
        {
            panelViewAtendimento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelViewAtendimento.Width,
            panelViewAtendimento.Height, 7, 7));
        }

    }
}
