using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;

namespace IClinic.Forms
{
    public partial class frmPacientes : Form
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
        int idPaciente = 0, contagem = 0, idFicha = 0;
        bool liberado = false;

        public frmPacientes()
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
            containerPai.Controls.Add(childForm);
            containerPai.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.dadosComplementaresTableAdapter.Fill(this.iClinicDatabaseDataSet.DadosComplementares);
            this.pacienteTableAdapter.queryExibirData(this.iClinicDatabaseDataSet.Paciente);
            verificarQuantidadePacientes();
        }

        void monitorar()
        {
            var updateOfModel = new UpdateOfModel<Models.Paciente>();
            updateOfModel.Add(i => i.codigoLog);

            var tableDependency = new SqlTableDependency<Models.Paciente>(
                conexao.ConnectionString,
                "Paciente",
                updateOf: updateOfModel);

            tableDependency.OnChanged += Dependency_OnChanged;

            tableDependency.Start();
        }

        private void Dependency_OnChanged(object sender, RecordChangedEventArgs<Models.Paciente> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                requestDadoPaciente();
            }
        }

        delegate void requestPaciente();
        private void requestDadoPaciente()
        {
            if(InvokeRequired)
            {
                requestPaciente request = requestDadoPaciente;
                Invoke(request);
            }
            else
            {
                this.dadosComplementaresTableAdapter.Fill(this.iClinicDatabaseDataSet.DadosComplementares);
                this.pacienteTableAdapter.queryExibirData(this.iClinicDatabaseDataSet.Paciente);
                verificarQuantidadePacientes();
            }
        }
        
        private void consultarFichaClinica()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Colaborador = ("SELECT idFichaClinica FROM FichaClinica WHERE idPaciente = @ID");
            SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@ID", int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            while (datareader.Read())
            {
                idFicha = int.Parse(datareader[0].ToString());
            }

            banco.desconectar();
        }

        private void verificarQuantidadePacientes()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Colaborador = ("SELECT COUNT(*) FROM Paciente");
            SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
            banco.conectar();

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            while (datareader.Read())
            {
                contagem = int.Parse(datareader[0].ToString());
            }

            banco.desconectar();

            labelContagem.Text = ("Total: " + contagem + " Registros");
        }

        private void verificarComponentesNovoCadastro()
        {
            //Verifica se todo os Campos foram preenchidos.
            if (textBoxCadNomeCompleto.Text != ("")
                && comboBoxCadSexo.Text != ("")
                && maskCadTelefone.Text != ("")
                && textBoxCadEndereco.Text != ("")
                && textBoxCadNumero.Text != ("")
                && textBoxCadBairro.Text != ("")
                )
            {
                liberado = true;
            }
            else
            {
                liberado = false;
            }
        }

        private void verificarComponentesEditarCadastro()
        {
            //Verifica se todo os Campos foram preenchidos.
            if (textBoxUpdNomeCompleto.Text != ("")
                && comboBoxUpdSexo.Text != ("")
                && maskUpdTelefone.Text != ("")
                && textBoxUpdEndereco.Text != ("")
                && textBoxUpdNumero.Text != ("")
                && textBoxUpdBairro.Text != ("")
                )
            {
                liberado = true;
            }
            else
            {
                liberado = false;
            }
        }

        private void consultarIdPaciente()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Colaborador = ("SELECT idPaciente FROM Paciente WHERE idPaciente=(SELECT MAX(idPaciente) FROM Paciente)");
            SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
            banco.conectar();

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            while (datareader.Read())
            {
                idPaciente = int.Parse(datareader[0].ToString());
            }

            banco.desconectar();
        }

        private void gerarLog()
        {
            Log.gerarLog("");

        }

        private void limparValores()
        {
            textBoxPesquisarNome.Clear();
            //
            textBoxCadNomeCompleto.Clear();
            maskCadDataNascimento.Clear();
            comboBoxCadSexo.Text = "";
            maskCadCPF.Clear();
            textBoxCadRG.Clear();
            maskCadTelefone.Clear();
            textBoxCadEmail.Clear();
            textBoxCadObservacao.Clear();
            maskCadCEP.Clear();
            textBoxCadEndereco.Clear();
            textBoxCadNumero.Clear();
            textBoxCadBairro.Clear();
            textBoxCadComplemento.Clear();
            textBoxCadCidade.Clear();
            textBoxCadEstado.Clear();
            textBoxCadNomeFamiliar.Clear();
            textBoxCadParentesco.Clear();
            textBoxCadVinculo.Clear();
            maskCadTelefoneFamiliar.Clear();
            textBoxCadObservacaoFamiliar.Clear();
            //
            textBoxUpdNomeCompleto.Clear();
            maskUpdDataNascimento.Clear();
            comboBoxUpdSexo.Text = "";
            maskUpdCPF.Clear();
            textBoxUpdRG.Clear();
            maskUpdTelefone.Clear();
            textBoxUpdEmail.Clear();
            textBoxUpdObservacao.Clear();
            maskUpdCEP.Clear();
            textBoxUpdEndereco.Clear();
            textBoxUpdNumero.Clear();
            textBoxUpdBairro.Clear();
            textBoxUpdComplemento.Clear();
            textBoxUpdCidade.Clear();
            textBoxUpdEstado.Clear();
            textBoxUpdNomeFamiliar.Clear();
            textBoxUpdParentesco.Clear();
            textBoxUpdVinculo.Clear();
            maskUpdTelefoneFamiliar.Clear();
            textBoxUpdObservacaoFamiliares.Clear();
        }

        private void insertQuery()
        {
            try
            {
                string Paciente = ("INSERT INTO Paciente (nomePaciente, dataNascimento, sexoBiologico, email, cpf, rg, observacao, telefonePrincipal, cep, endereco, numero, complemento, bairro, cidade, estado, codigoLog) VALUES (@nomePaciente, @dataNascimento, @sexoBiologico, @email, @cpf, @rg, @observacao, @telefonePrincipal, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @codigoLog)");
                string DadosComplementares = ("INSERT INTO DadosComplementares (nome, parentesco, vinculo, telefone, observacao, idPacienteFK) VALUES (@nome, @parentesco, @vinculo, @telefone, @observacao, @idPacienteFK)");
                SqlCommand cadPaciente = new SqlCommand(Paciente, banco.connection);
                SqlCommand cadDadosComplementares = new SqlCommand(DadosComplementares, banco.connection);

                cadPaciente.Parameters.AddWithValue("@nomePaciente", textBoxCadNomeCompleto.Text);
                cadPaciente.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(maskCadDataNascimento.Text));
                cadPaciente.Parameters.AddWithValue("@sexoBiologico", comboBoxCadSexo.Text);
                cadPaciente.Parameters.AddWithValue("@email", textBoxCadEmail.Text);
                //
                maskCadCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                cadPaciente.Parameters.AddWithValue("@cpf", maskCadCPF.Text);
                maskCadCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                cadPaciente.Parameters.AddWithValue("@rg", textBoxCadRG.Text);
                cadPaciente.Parameters.AddWithValue("@observacao", textBoxCadObservacao.Text);
                cadPaciente.Parameters.AddWithValue("@telefonePrincipal", maskCadTelefone.Text);
                maskCadCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                cadPaciente.Parameters.AddWithValue("@cep", maskCadCEP.Text);
                maskCadCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                cadPaciente.Parameters.AddWithValue("@endereco", textBoxCadEndereco.Text);
                cadPaciente.Parameters.AddWithValue("@numero", textBoxCadNumero.Text);
                cadPaciente.Parameters.AddWithValue("@complemento", textBoxCadComplemento.Text);
                cadPaciente.Parameters.AddWithValue("@bairro", textBoxCadBairro.Text);
                cadPaciente.Parameters.AddWithValue("@cidade", textBoxCadCidade.Text);
                cadPaciente.Parameters.AddWithValue("@estado", textBoxCadEstado.Text);
                cadPaciente.Parameters.AddWithValue("@codigoLog", Log._retornarLog());

                banco.conectar();
                cadPaciente.ExecuteNonQuery();
                banco.desconectar();

                //
                consultarIdPaciente();

                cadDadosComplementares.Parameters.AddWithValue("@nome", textBoxCadNomeFamiliar.Text);
                cadDadosComplementares.Parameters.AddWithValue("@parentesco", textBoxCadParentesco.Text);
                cadDadosComplementares.Parameters.AddWithValue("@vinculo", textBoxCadVinculo.Text);
                cadDadosComplementares.Parameters.AddWithValue("@telefone", maskCadTelefoneFamiliar.Text);
                cadDadosComplementares.Parameters.AddWithValue("@observacao", textBoxCadObservacaoFamiliar.Text);
                cadDadosComplementares.Parameters.AddWithValue("@idPacienteFK", int.Parse(idPaciente.ToString()));

                banco.conectar();
                cadDadosComplementares.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A Ação não pôde ser realizada." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateQuery()
        {
            try
            {
                string Paciente = ("UPDATE Paciente SET nomePaciente = @nomePaciente, dataNascimento = @dataNascimento, sexoBiologico = @sexoBiologico, email = @email, cpf = @cpf, rg = @rg, observacao = @observacao, telefonePrincipal = @telefonePrincipal, cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, codigoLog = @codigoLog WHERE idPaciente = @ID");
                string DadosComplementares = ("UPDATE DadosComplementares SET nome = @nome, parentesco = @parentesco, vinculo = @vinculo, telefone = @telefone, observacao = @observacao, idPacienteFK = @idPacienteFK WHERE idPacienteFK = @ID");
                SqlCommand UpdPaciente = new SqlCommand(Paciente, banco.connection);
                SqlCommand UpdDadosComplementares = new SqlCommand(DadosComplementares, banco.connection);

                UpdPaciente.Parameters.AddWithValue("@nomePaciente", textBoxUpdNomeCompleto.Text);
                UpdPaciente.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(maskUpdDataNascimento.Text));
                UpdPaciente.Parameters.AddWithValue("@sexoBiologico", comboBoxUpdSexo.Text);
                UpdPaciente.Parameters.AddWithValue("@email", textBoxUpdEmail.Text);
                //
                maskUpdCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                UpdPaciente.Parameters.AddWithValue("@cpf", maskUpdCPF.Text);
                maskUpdCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                UpdPaciente.Parameters.AddWithValue("@rg", textBoxUpdRG.Text);
                UpdPaciente.Parameters.AddWithValue("@observacao", textBoxUpdObservacao.Text);
                UpdPaciente.Parameters.AddWithValue("@telefonePrincipal", maskUpdTelefone.Text);
                maskUpdCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                UpdPaciente.Parameters.AddWithValue("@cep", maskUpdCEP.Text);
                maskUpdCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                UpdPaciente.Parameters.AddWithValue("@endereco", textBoxUpdEndereco.Text);
                UpdPaciente.Parameters.AddWithValue("@numero", textBoxUpdNumero.Text);
                UpdPaciente.Parameters.AddWithValue("@complemento", textBoxUpdComplemento.Text);
                UpdPaciente.Parameters.AddWithValue("@bairro", textBoxUpdBairro.Text);
                UpdPaciente.Parameters.AddWithValue("@cidade", textBoxUpdCidade.Text);
                UpdPaciente.Parameters.AddWithValue("@estado", textBoxUpdEstado.Text);
                UpdPaciente.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdPaciente.Parameters.AddWithValue("@ID", int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                UpdPaciente.ExecuteNonQuery();
                banco.desconectar();


                UpdDadosComplementares.Parameters.AddWithValue("@nome", textBoxUpdNomeFamiliar.Text);
                UpdDadosComplementares.Parameters.AddWithValue("@parentesco", textBoxUpdParentesco.Text);
                UpdDadosComplementares.Parameters.AddWithValue("@vinculo", textBoxUpdVinculo.Text);
                UpdDadosComplementares.Parameters.AddWithValue("@telefone", maskUpdTelefoneFamiliar.Text);
                UpdDadosComplementares.Parameters.AddWithValue("@observacao", textBoxUpdObservacaoFamiliares.Text);
                UpdDadosComplementares.Parameters.AddWithValue("@idPacienteFK", int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));
                UpdDadosComplementares.Parameters.AddWithValue("@ID", int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                UpdDadosComplementares.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A Ação não pôde ser realizada." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void deleteQuery()
        {
            try
            {
                string Paciente = ("DELETE FROM Paciente WHERE idPaciente = @ID");
                string DadosComplementares = ("DELETE FROM DadosComplementares WHERE idPacienteFK = @ID");
                SqlCommand delPaciente = new SqlCommand(Paciente, banco.connection);
                SqlCommand delDadosComplementares = new SqlCommand(DadosComplementares, banco.connection);

                delPaciente.Parameters.AddWithValue("@ID", int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                delPaciente.ExecuteNonQuery();
                banco.desconectar();

                delDadosComplementares.Parameters.AddWithValue("@ID", int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));

                banco.conectar();
                delDadosComplementares.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A Ação não pôde ser realizada." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.pacienteTableAdapter.queryPesquisarPaciente(this.iClinicDatabaseDataSet.Paciente, textBoxPesquisarNome.Text);
        }

        private void textBoxPesquisarNome_KeyDown(object sender, KeyEventArgs e)
        {
            this.pacienteTableAdapter.queryPesquisarPaciente(this.iClinicDatabaseDataSet.Paciente, textBoxPesquisarNome.Text);
        }

        #region Novo Cadastro

        #region Abas Novo Cadastro

        private void btnCadDadosPessoais_Click(object sender, EventArgs e)
        {
            //
            btnCadEndereco.BackColor = Color.FromArgb(23, 24, 27);
            panelCadEndereco.Visible = false;
            //
            btnCadDadosFamiliares.BackColor = Color.FromArgb(23, 24, 27);
            panelCadDadosFamiliar.Visible = false;
            //
            btnCadDadosPessoais.BackColor = Color.FromArgb(33, 34, 38);
            panelCadDadosPessoais.Visible = true;
        }

        private void btnCadEndereco_Click(object sender, EventArgs e)
        {
            btnCadDadosPessoais.BackColor = Color.FromArgb(23, 24, 27);
            panelCadDadosPessoais.Visible = false;       
            //
            btnCadDadosFamiliares.BackColor = Color.FromArgb(23, 24, 27);
            panelCadDadosFamiliar.Visible = false;
            //
            btnCadEndereco.BackColor = Color.FromArgb(33, 34, 38);
            panelCadEndereco.Visible = true;
        }

        private void btnCadDadosFamiliares_Click(object sender, EventArgs e)
        {
            btnCadDadosPessoais.BackColor = Color.FromArgb(23, 24, 27);
            panelCadDadosPessoais.Visible = false;
            //
            btnCadEndereco.BackColor = Color.FromArgb(23, 24, 27);
            panelCadEndereco.Visible = false;
            //
            btnCadDadosFamiliares.BackColor = Color.FromArgb(33, 34, 38);
            panelCadDadosFamiliar.Visible = true;
        }

        #endregion

        private void btnNovoPaciente_Click(object sender, EventArgs e)
        {
            limparValores();

            textBoxCadNomeCompleto.Focus();

            if (panelNovoCadastro.Visible != true)
            {
                panelConsultarPaciente.Visible = false;
                panelEditarCadastro.Visible = false;
                panelNovoCadastro.Visible = true;

                btnCadDadosPessoais_Click(sender, e);

                //Torna os componentes de pesquisa inativos durante as alteracoes
                textBoxPesquisarNome.Enabled = false;
                btnPesquisar.Enabled = false;
                btnNovoPaciente.Enabled = false;
                btnFichaAcompanhamento.Enabled = false;
                btnVizualizarCadastro.Enabled = false;
                btnEditarCadastro.Enabled = false;
                btnExcluirCadastro.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            verificarComponentesNovoCadastro();

            if (liberado == true)
            {
                //Gera o Registro interno das acoes efetuadas no sistema 
                gerarLog();

                //chama a função para inserção no banco de dados.
                insertQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.dadosComplementaresTableAdapter.Fill(this.iClinicDatabaseDataSet.DadosComplementares);
                this.pacienteTableAdapter.queryExibirData(this.iClinicDatabaseDataSet.Paciente);
                this.dataGridViewPacientes.Refresh();

                MessageBox.Show("Cadastro realizado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa todos os valores
                limparValores();

                btnCadDadosPessoais_Click(sender, e);

                verificarQuantidadePacientes();
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            limparValores();

            textBoxPesquisarNome.Focus();

            if (panelConsultarPaciente.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarPaciente.Visible = true;

                //Torna os componentes de pesquisa inativos durante as alteracoes
                textBoxPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoPaciente.Enabled = true;
                btnFichaAcompanhamento.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }

            this.frmPacientes_Load(sender, e);

        }

        #endregion

        private void btnFichaAcompanhamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.Rows.Count != 0)
            {
                //Passa o ID do Paciente para uma variavel global.
                //Para que outro form possa le-la
                FichaClinicaId.receberID(int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString()));

                openChildForm(new Forms.frmFichaClinica());
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não existe Paciente Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            Reports.ReportCadastros.frmReportPaciente windows = new Reports.ReportCadastros.frmReportPaciente();
            windows.ShowDialog();
            windows.Dispose();
        }

        #region Editar Cadastro

        #region Abas Editar Cadastro

        private void btnUpdDadosPessoais_Click(object sender, EventArgs e)
        {
            btnUpdEndereco.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdEndereco.Visible = false;
            //
            btnUpdDadosFamiliares.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdDadosFamiliares.Visible = false;
            //
            btnUpdDadosPessoais.BackColor = Color.FromArgb(33, 34, 38);
            panelUpdDadosPessoais.Visible = true;
        }

        private void btnUpdEndereco_Click(object sender, EventArgs e)
        {
            btnUpdDadosPessoais.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdDadosPessoais.Visible = false;
            //
            btnUpdDadosFamiliares.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdDadosFamiliares.Visible = false;
            //
            btnUpdEndereco.BackColor = Color.FromArgb(33, 34, 38);
            panelUpdEndereco.Visible = true;
        }

        private void btnUpdDadosFamiliares_Click(object sender, EventArgs e)
        {
            btnUpdDadosPessoais.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdDadosPessoais.Visible = false;
            //
            btnUpdEndereco.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdEndereco.Visible = false;
            //
            btnUpdDadosFamiliares.BackColor = Color.FromArgb(33, 34, 38);
            panelUpdDadosFamiliares.Visible = true;
        }

        #endregion

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.Rows.Count != 0)
            {
                int ID = 0;

                ID = int.Parse(dataGridViewPacientes.CurrentRow.Cells[0].Value.ToString());

                limparValores();

                this.pacienteTableAdapter.queryEditarCadastro(this.iClinicDatabaseDataSet.Paciente, ID);
                this.dadosComplementaresTableAdapter.queryEditarDadosComplementares(this.iClinicDatabaseDataSet.DadosComplementares, ID);

                textBoxUpdNomeCompleto.Focus();

                if (panelEditarCadastro.Visible != true)
                {
                    panelConsultarPaciente.Visible = false;
                    panelNovoCadastro.Visible = false;
                    panelEditarCadastro.Visible = true;

                    btnUpdDadosPessoais_Click(sender, e);

                    //Torna os componentes de pesquisa inativos durante as alteracoes
                    textBoxPesquisarNome.Enabled = false;
                    btnPesquisar.Enabled = false;
                    btnNovoPaciente.Enabled = false;
                    btnFichaAcompanhamento.Enabled = false;
                    btnVizualizarCadastro.Enabled = false;
                    btnEditarCadastro.Enabled = false;
                    btnExcluirCadastro.Enabled = false;
                }
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não existe Paciente Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSavalEditar_Click(object sender, EventArgs e)
        {
            verificarComponentesEditarCadastro();

            if (liberado == true)
            {
                //Gera o Registro interno das acoes efetuadas no sistema 
                gerarLog();

                //chama a função para inserção no banco de dados.
                updateQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.dadosComplementaresTableAdapter.Fill(this.iClinicDatabaseDataSet.DadosComplementares);
                this.pacienteTableAdapter.queryExibirData(this.iClinicDatabaseDataSet.Paciente);
                this.dataGridViewPacientes.Refresh();

                //limpa todos os valores
                limparValores();

                MessageBox.Show("Alteração realizada com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnCadDadosPessoais_Click(sender, e);     
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("A Alteração não pôde ser realizada." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSairEditar_Click(object sender, EventArgs e)
        {
            if (panelConsultarPaciente.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarPaciente.Visible = true;

                //Torna os componentes de pesquisa inativos durante as alteracoes
                textBoxPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoPaciente.Enabled = true;
                btnFichaAcompanhamento.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;

                this.frmPacientes_Load(sender, e);
            }
        }

        #endregion

        #region Excluir Cadastro

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (panelConsultarPaciente.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarPaciente.Visible = true;

                MessageBox.Show("Selecione o Paciente que deseja Excluir!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridViewPacientes.Rows.Count != 0)
                {
                    //Limpa os valores inseridos.
                    limparValores();

                    dataGridViewPacientes.Focus();

                    //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
                    if (MessageBox.Show("Tem certeza que deseja apagar?" + "\n" + "\n" + "Uma vez apagado, não será mais possivel recupera-lo!", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //Gera o Registro interno das acoes efetuadas no sistema 
                        gerarLog();

                        //chama a função para delete na tabela.
                        deleteQuery();

                        //limpa todos os valores
                        limparValores();

                        //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                        this.dadosComplementaresTableAdapter.Fill(this.iClinicDatabaseDataSet.DadosComplementares);
                        this.pacienteTableAdapter.queryExibirData(this.iClinicDatabaseDataSet.Paciente);
                        this.dataGridViewPacientes.Refresh();

                        MessageBox.Show("Paciente Excluido com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        verificarQuantidadePacientes();
                    }
                }
                else
                {
                    //Menssagem de alerta, caso ocorra algum erro inesperado
                    MessageBox.Show("Não existe Paciente Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        #endregion

        private void frmPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Verificadores.abertoFechado(2);
        }

        #region Paneis bordas evento - Paint

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

        private void panelConsultarPaciente_Paint(object sender, PaintEventArgs e)
        {
            panelConsultarPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConsultarPaciente.Width,
            panelConsultarPaciente.Height, 7, 7));
        }

        private void panelCadTitulo_Paint(object sender, PaintEventArgs e)
        {
            panelCadTitulo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadTitulo.Width,
            panelCadTitulo.Height, 5, 5));
        }

        private void panelCadDadosPessoais_Paint(object sender, PaintEventArgs e)
        {
            panelCadDadosPessoais.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadDadosPessoais.Width,
            panelCadDadosPessoais.Height, 7, 7));
        }

        private void panelCadOpcoes_Paint(object sender, PaintEventArgs e)
        {
            panelCadOpcoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadOpcoes.Width,
            panelCadOpcoes.Height, 7, 7));
        }

        private void panelCadEndereco_Paint(object sender, PaintEventArgs e)
        {
            panelCadEndereco.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadEndereco.Width,
            panelCadEndereco.Height, 7, 7));
        }

        private void panelCadDadosFamiliar_Paint(object sender, PaintEventArgs e)
        {
            panelCadDadosFamiliar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadDadosFamiliar.Width,
            panelCadDadosFamiliar.Height, 7, 7));
        }

        private void panelUpdTitulo_Paint(object sender, PaintEventArgs e)
        {
            panelUpdTitulo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdTitulo.Width,
            panelUpdTitulo.Height, 5, 5));
        }

        private void panelUpdDadosPessoais_Paint(object sender, PaintEventArgs e)
        {
            panelUpdDadosPessoais.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdDadosPessoais.Width,
            panelUpdDadosPessoais.Height, 7, 7));
        }

        private void panelUpdOpcoes_Paint(object sender, PaintEventArgs e)
        {
            panelUpdOpcoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdOpcoes.Width,
            panelUpdOpcoes.Height, 7, 7));
        }

        private void panelUpdEndereco_Paint(object sender, PaintEventArgs e)
        {
            panelUpdEndereco.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdEndereco.Width,
            panelUpdEndereco.Height, 7, 7));
        }

        private void panelUpdDadosFamiliares_Paint(object sender, PaintEventArgs e)
        {
            panelUpdDadosFamiliares.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdDadosFamiliares.Width,
            panelUpdDadosFamiliares.Height, 7, 7));
        }

        #endregion
    }
}
