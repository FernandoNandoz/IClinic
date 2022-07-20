using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Data;
using System.Runtime.InteropServices;
using IClinic.Properties;

namespace IClinic.Forms.Cadastro
{
    public partial class frmProfissional : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        Banco banco = new Banco();

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

        int tipoAcao = 0, contagem = 0;
        string statusCad, tipoTratamento;
        bool liberado = false;

        public frmProfissional()
        {
            InitializeComponent();
        }

        private void frmCadastrarProfissional_Load(object sender, EventArgs e)
        {
            this.colaboradorTableAdapter.queryDataColaborador(this.iClinicDatabaseDataSet.Colaborador);

            this.perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
            contagemRegistro();

            if (Autenticacao._statusCadastro() == "INCOMPLETO")
            {
                btnNovoCadastro_Click(sender, e);
                //
                MessageBox.Show("Ola, " + Autenticacao._nome() + "!" + "\n" + "\n" + "Seja muito bem vindo!!!" + "\n" + "\n" + "Antes de começar sua atividades, finalize seu cadastro de Usuario inserindo e salvando seus dados Profissionais para que o sistema possa liberar suas aividade!" + "\n" + "\n" + "Ate mais!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Verificadores._alterarPerfil() == true)
            {
                btnEditarCadastro_Click(sender, e);
            }
        }

        private void contagemRegistro()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Colaborador = ("SELECT (SELECT COUNT(*) FROM Colaborador), statusCadastro FROM Colaborador WHERE idColaborador = @ID");
            SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            while (datareader.Read())
            {
                contagem = int.Parse(datareader[0].ToString());
                statusCad = datareader[1].ToString();
            }

            banco.desconectar();


            labelContagem.Text = ("Total: " + contagem + " Registros");
        }

        private void carregarDadosColaborador()
        {
            if (statusCad == "DESATIVADO")
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Colaborador = ("SELECT (SELECT COUNT(*) FROM Colaborador), * FROM Colaborador WHERE idColaborador = @ID");
                SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();
                
                while (datareader.Read())
                {
                    contagem = int.Parse(datareader[0].ToString());
                    //
                    textBoxCadNomeCompleto.Text = datareader[3].ToString();
                    comboBoxCadSexo.Text = datareader[4].ToString();
                    maskCadCpf.Text = datareader[5].ToString();
                    maskCadTelefone.Text = datareader[6].ToString();
                    textBoxCadEmail.Text = datareader[7].ToString();
                    comboBoxCadTipoTratamento.Text = datareader[8].ToString();
                    comboBoxCadConselhoRegistro.Text = datareader[9].ToString();
                    textBoxCadNdeRegistro.Text = datareader[10].ToString();
                    comboBoxCadUFdeRegistro.Text = datareader[11].ToString();
                    textBoxCadEspecialidade.Text = datareader[12].ToString();

                    using (var stream = new System.IO.MemoryStream((byte[])datareader[13]))
                    {
                        pictureBoxCadImgProfile.Image = Bitmap.FromStream(stream);
                    }     
                }

                banco.desconectar();
            }
            
        }

        private byte[] ImagemParaByte()
        {
            if (pictureBoxCadImgProfile.Image == null)
            {
                if (comboBoxCadSexo.Text == "MASCULINO")
                {
                    pictureBoxCadImgProfile.Image = Resources.icons8_hmem_126px;
                }
                else
                {
                    pictureBoxCadImgProfile.Image = Resources.icons8_mulher_26px;
                }
            }                 

            using (var stream = new System.IO.MemoryStream())
            {
                if (tipoAcao == 1)
                {
                    pictureBoxCadImgProfile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                }

                if(tipoAcao == 2)
                {
                    pictureBoxUpdImgProfile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                }

                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] byteArray = new byte[stream.Length];
                stream.Read(byteArray, 0, System.Convert.ToInt32(stream.Length));
                return byteArray;
            }

        }

        private void carregarImagem()
        {
            var dataRowView = dataGridViewProfissional.CurrentRow.Cells[14].Value as DataRowView; 
            if(dataRowView != null)
            {
                using (var stream = new System.IO.MemoryStream((byte[])dataRowView.Row["imagePerfil"]))
                {
                    if (tipoAcao == 1)
                    {
                        pictureBoxCadImgProfile.Image = Bitmap.FromStream(stream);
                    }

                    if (tipoAcao == 2)
                    {
                        pictureBoxUpdImgProfile.Image = Bitmap.FromStream(stream);
                    }
                }
            }         
        }

        private void verificarComponentesNovoCadastro()
        {
            //Verifica se todo os Campos foram preenchidos.
            if (Autenticacao._perfil() == "Profissional da Saude")
            {
                //Verifica se todo os Campos foram preenchidos.
                if (
                    textBoxCadNomeCompleto.Text != ("")
                    && comboBoxCadSexo.Text != ("")
                    && maskCadCpf.Text != ("")
                    && maskCadTelefone.Text != ("")
                    && textBoxCadEmail.Text != ("")
                    && comboBoxCadConselhoRegistro.Text != ("")
                    && textBoxCadNdeRegistro.Text != ("")
                    && comboBoxCadUFdeRegistro.Text != ("")
                    && textBoxCadEspecialidade.Text != ("")
                    )
                {
                    liberado = true;
                }
                else
                {
                    liberado = false;
                }
            }
            else
            {
                //Verifica se todo os Campos foram preenchidos.
                if (
                    textBoxCadNomeCompleto.Text != ("")
                    && comboBoxCadSexo.Text != ("")
                    && maskCadCpf.Text != ("")
                    && maskCadTelefone.Text != ("")
                    && textBoxCadEmail.Text != ("")
                    )
                {
                    liberado = true;
                }
                else
                {
                    liberado = false;
                }
            }
        }

        private void verificarComponentesEditarCadastro()
        {
            //Verifica se todo os Campos foram preenchidos.
            if (Autenticacao._perfil() == "Profissional da Saude")
            {
                //Verifica se todo os Campos foram preenchidos.
                if (
                    textBoxUpdNomeCompleto.Text != ("")
                    && comboBoxUpdSexo.Text != ("")
                    && maskUpdCpf.Text != ("")
                    && maskUpdTelefone.Text != ("")
                    && textBoxUpdEmail.Text != ("")
                    && comboBoxUpdTipoTratamento.Text != ("")
                    && comboBoxUpdConselhoRegistro.Text != ("")
                    && textBoxUpdNdeRegistro.Text != ("")
                    && comboBoxUpdUFdeRegistro.Text != ("")
                    && textBoxUpdEspecialidade.Text != ("")
                    )
                {
                    liberado = true;
                }
                else
                {
                    liberado = false;
                }
            }
            else
            {
                //Verifica se todo os Campos foram preenchidos.
                if (
                    textBoxUpdNomeCompleto.Text != ("")
                    && comboBoxUpdSexo.Text != ("")
                    && maskUpdCpf.Text != ("")
                    && maskUpdTelefone.Text != ("")
                    && textBoxUpdEmail.Text != ("")
                    )
                {
                    liberado = true;
                }
                else
                {
                    liberado = false;
                }
            }
        }

        private void gerarLog()
        {
            Log.gerarLog("");
        }

        private void limparValores()
        {
            btnNovoCadastro.Enabled = true;
            btnEditarCadastro.Enabled = true;
            btnVizualizarCadastro.Enabled = true;
            btnExcluirCadastro.Enabled = true;
            //
            pictureBoxCadImgProfile.Image = null;
            textBoxCadNomeCompleto.Clear();
            comboBoxCadSexo.Text = "";
            maskCadCpf.Clear();
            maskCadTelefone.Clear();
            textBoxCadEmail.Clear();
            comboBoxCadTipoTratamento.Text = "";
            comboBoxCadConselhoRegistro.Text = "";
            textBoxCadNdeRegistro.Clear();
            comboBoxCadUFdeRegistro.Text = "";
            textBoxCadEspecialidade.Clear();
            //
            pictureBoxUpdImgProfile.Image = null;
            textBoxUpdNomeCompleto.Clear();
            comboBoxUpdSexo.Text = "";
            maskUpdCpf.Clear();
            maskUpdTelefone.Clear();
            textBoxUpdEmail.Clear();
            comboBoxUpdTipoTratamento.Text = "";
            comboBoxUpdConselhoRegistro.Text = "";
            textBoxUpdNdeRegistro.Clear();
            comboBoxUpdUFdeRegistro.Text = "";
            textBoxUpdEspecialidade.Clear();
        }

        private void insertQuery()
        {   
            if(comboBoxCadTipoTratamento.Text == "Nenhum")
            {
                tipoTratamento = textBoxCadNomeCompleto.Text;
            }
            else
            {
                tipoTratamento = comboBoxCadTipoTratamento.Text + "" + textBoxCadNomeCompleto.Text;
            }

            try
            {
                //String de referencia da Tabela Usuario e Conexão da mesma.
                string Colaborador = ("UPDATE Colaborador SET nomeColaborador = @nomeColaborador, nomeProfissional = @nomeProfissional, sexo = @sexo, cpf = @cpf, telefone = @telefone, email = @email, formaTratamento = @formaTratamento, conselhoRegistro = @conselhoRegistro, numeroRegistro = @nRegistro, ufRegistro = @ufRegistro, especialidade = @especialidade, imagemPerfil = @imagemPerfil, statusCadastro = @statusCadastro, codigoLog = @codigoLog WHERE idColaborador = @ID");
                SqlCommand CadColaborador = new SqlCommand(Colaborador, banco.connection);

                //Passando dados por parametros para inserção no banco.
                CadColaborador.Parameters.AddWithValue("@nomeColaborador", textBoxCadNomeCompleto.Text);
                CadColaborador.Parameters.AddWithValue("@nomeProfissional", tipoTratamento);
                CadColaborador.Parameters.AddWithValue("@sexo", comboBoxCadSexo.Text);
                //
                maskCadCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                CadColaborador.Parameters.AddWithValue("@cpf", maskCadCpf.Text);
                maskCadCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                maskCadTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                CadColaborador.Parameters.AddWithValue("@telefone", maskCadTelefone.Text);
                maskCadTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                CadColaborador.Parameters.AddWithValue("@email", textBoxCadEmail.Text);
                CadColaborador.Parameters.AddWithValue("@formaTratamento", comboBoxCadTipoTratamento.Text);
                CadColaborador.Parameters.AddWithValue("@conselhoRegistro", comboBoxCadConselhoRegistro.Text);
                CadColaborador.Parameters.AddWithValue("@nRegistro", textBoxCadNdeRegistro.Text);
                CadColaborador.Parameters.AddWithValue("@ufRegistro", comboBoxCadUFdeRegistro.Text);
                if (Autenticacao._perfil() != "Profissional da Saude")
                {
                    CadColaborador.Parameters.AddWithValue("@especialidade", Autenticacao._perfil());
                }
                else
                {
                    CadColaborador.Parameters.AddWithValue("@especialidade", textBoxCadEspecialidade.Text);
                }
                CadColaborador.Parameters.AddWithValue("@imagemPerfil", ImagemParaByte());
                CadColaborador.Parameters.AddWithValue("@statusCadastro", "COMPLETO");
                CadColaborador.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                CadColaborador.Parameters.AddWithValue("@ID", Autenticacao._idUsuario());

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                CadColaborador.ExecuteNonQuery();
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
            if (comboBoxUpdTipoTratamento.Text == "Nenhum")
            {
                tipoTratamento = textBoxUpdNomeCompleto.Text;
            }
            else
            {
                tipoTratamento = comboBoxUpdTipoTratamento.Text + "" + textBoxUpdNomeCompleto.Text;
            }

            try
            {
                //String de referencia da Tabela Usuario e Conexão da mesma.
                string Colaborador = ("UPDATE Colaborador SET nomeColaborador = @nomeColaborador, nomeProfissional = @nomeProfissional, sexo = @sexo, cpf = @cpf, telefone = @telefone, email = @email, formaTratamento = @formaTratamento, conselhoRegistro = @conselhoRegistro, numeroRegistro = @nRegistro, ufRegistro = @ufRegistro, especialidade = @especialidade, imagemPerfil = @imagemPerfil, codigoLog = @codigoLog WHERE idColaborador = @ID");
                SqlCommand UpdColaborador = new SqlCommand(Colaborador, banco.connection);

                //Passando dados por parametros para inserção no banco.
                UpdColaborador.Parameters.AddWithValue("@nomeColaborador", textBoxUpdNomeCompleto.Text);
                UpdColaborador.Parameters.AddWithValue("@nomeProfissional", tipoTratamento);
                UpdColaborador.Parameters.AddWithValue("@sexo", comboBoxUpdSexo.Text);
                //
                maskUpdCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                UpdColaborador.Parameters.AddWithValue("@cpf", maskUpdCpf.Text);
                maskUpdCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                maskUpdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                UpdColaborador.Parameters.AddWithValue("@telefone", maskUpdTelefone.Text);
                maskUpdTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //
                UpdColaborador.Parameters.AddWithValue("@email", textBoxUpdEmail.Text);
                UpdColaborador.Parameters.AddWithValue("@formaTratamento", comboBoxUpdTipoTratamento.Text);
                UpdColaborador.Parameters.AddWithValue("@conselhoRegistro", comboBoxUpdConselhoRegistro.Text);
                UpdColaborador.Parameters.AddWithValue("@nRegistro", textBoxUpdNdeRegistro.Text);
                UpdColaborador.Parameters.AddWithValue("@ufRegistro", comboBoxUpdUFdeRegistro.Text);
                if (Autenticacao._perfil() != "Profissional da Saude")
                {
                    UpdColaborador.Parameters.AddWithValue("@especialidade", Autenticacao._perfil());
                }
                else
                {
                    UpdColaborador.Parameters.AddWithValue("@especialidade", textBoxUpdEspecialidade.Text);
                }
                UpdColaborador.Parameters.AddWithValue("@imagemPerfil", ImagemParaByte());
                UpdColaborador.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdColaborador.Parameters.AddWithValue("@ID", dataGridViewProfissional.CurrentRow.Cells[0].Value);

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                UpdColaborador.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A Alteração não pôde ser realizada." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteQuery()
        {
            try
            {
                //String de referencia da Tabela Usuario e Conexão da mesma.
                string Colaborador = ("UPDATE Colaborador SET statusCadastro = @status, codigoLog = @codigoLog WHERE idColaborador = @ID");
                SqlCommand UpdColaborador = new SqlCommand(Colaborador, banco.connection);

                //Passando dados por parametros para inserção no banco.
                UpdColaborador.Parameters.AddWithValue("@status", "DESATIVADO");
                UpdColaborador.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdColaborador.Parameters.AddWithValue("@ID", dataGridViewProfissional.CurrentRow.Cells[0].Value);

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                UpdColaborador.ExecuteNonQuery();
                banco.desconectar();
            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A Ação não pôde ser realizada." + "\n" + "Tente novamente, mais tarde." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Novo Cadastro

        #region Abas Novo Cadastro
        private void btnCadDadosPessoais_Click(object sender, EventArgs e)
        {
            btnCadDadosProfissionais.BackColor = Color.FromArgb(23, 24, 27);
            panelCadDadosProfisionais.Visible = false;
            //
            btnCadDadosPessoais.BackColor = Color.FromArgb(33, 34, 38);
            panelCadDadosPessoais.Visible = true;
        }

        private void btnCadDadosProfissionais_Click(object sender, EventArgs e)
        {
            btnCadDadosPessoais.BackColor = Color.FromArgb(23, 24, 27);
            panelCadDadosPessoais.Visible = false;
            //
            btnCadDadosProfissionais.BackColor = Color.FromArgb(33, 34, 38);
            panelCadDadosProfisionais.Visible = true;
        }
        #endregion

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            //Indica a uma variavel que a Açao realizada é a de Cadastro.
            // 1 = Cadastro
            tipoAcao = 1;

            //Limpa os valores inseridos.
            limparValores();

            btnNovoCadastro.Enabled = false;
            btnEditarCadastro.Enabled = false;
            btnVizualizarCadastro.Enabled = false;
            btnExcluirCadastro.Enabled = false;


            //Dar foco ao campo de teste.
            textBoxCadNomeCompleto.Focus();
            textBoxCadNomeCompleto.Text = Autenticacao._nome();

            carregarDadosColaborador();

            if (panelNovoCadastro.Visible != true)
            {
                if (Autenticacao._perfil() == "Profissional da Saude" || Autenticacao._perfil() == "PROFISSIONAL DE SAUDE")
                {
                    btnCadDadosProfissionais.Visible = true;
                }

                panelConsultarProfissional.Visible = false;
                panelEditarCadastro.Visible = false;
                panelNovoCadastro.Visible = true;

                btnCadDadosPessoais_Click(sender, e);

                //Torna os componentes de pesquisa inativos durante os cadastros
                textPesquisarNome.Enabled = false;
                btnPesquisar.Enabled = false;
            }
        }

        private void btnCadSair_Click(object sender, EventArgs e)
        {
            btnNovoCadastro.Enabled = true;
            btnEditarCadastro.Enabled = true;
            btnVizualizarCadastro.Enabled = true;
            btnExcluirCadastro.Enabled = true;

            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelConsultarProfissional.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarProfissional.Visible = true;

                //Torna os componentes de pesquisa inativos durante os cadastros
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
            }

            this.frmCadastrarProfissional_Load(sender, e);
        }

        private void linkLabelCadImportImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Choose Image(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (image.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCadImgProfile.ImageLocation = null;
                pictureBoxCadImgProfile.ImageLocation = image.FileName;

                linkLabelCadExcluirImagem.Visible = true;
            }
        }

        private void linkLabelCadExcluirImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxCadImgProfile.ImageLocation = null;
            linkLabelCadExcluirImagem.Visible = false;
        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            verificarComponentesNovoCadastro();

            if (liberado == true)
            {
                //Gera o Registro interno das acoes efetuadas no sistema 
                gerarLog();

                //chama a função para inserção no banco de dados.
                insertQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.colaboradorTableAdapter.queryDataColaborador(this.iClinicDatabaseDataSet.Colaborador);
                this.dataGridViewProfissional.Refresh();

                MessageBox.Show("Cadastro realizado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa todos os valores
                limparValores();

                btnCadDadosPessoais_Click(sender, e);

                contagemRegistro();

                if (Autenticacao._statusCadastro() == "INCOMPLETO")
                {
                    Autenticacao.status("COMPLETO");
                }

                if(Autenticacao._usuarioADM() == "NAO")
                {
                    this.Close();
                }
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Editar Cadastro

        #region Abas Editar Cadastro
        private void btnUpdDadosPessoais_Click(object sender, EventArgs e)
        {
            btnUpdDadosProfissionais.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdDadosProfissionais.Visible = false;
            //
            btnUpdDadosPessoais.BackColor = Color.FromArgb(33, 34, 38);
            panelUpdDadosPessoais.Visible = true;
        }

        private void btnUpdDadosProfissionais_Click(object sender, EventArgs e)
        {
            btnUpdDadosPessoais.BackColor = Color.FromArgb(23, 24, 27);
            panelUpdDadosPessoais.Visible = false;
            //
            btnUpdDadosProfissionais.BackColor = Color.FromArgb(33, 34, 38);
            panelUpdDadosProfissionais.Visible = true;
        }
        #endregion

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            limparValores();

            if (dataGridViewProfissional.Rows.Count != 0)
            {
                btnNovoCadastro.Enabled = false;
                btnEditarCadastro.Enabled = false;
                btnVizualizarCadastro.Enabled = false;
                btnExcluirCadastro.Enabled = false;

                int ID = 0;

                //Indica a uma variavel que a Açao realizada é a de Cadastro.
                // 2 = Editar
                tipoAcao = 2;

                if (Verificadores._alterarPerfil() == true)
                {
                    ID = int.Parse(Autenticacao._idUsuario().ToString());
                }
                else
                {
                    ID = int.Parse(dataGridViewProfissional.CurrentRow.Cells[0].Value.ToString());
                }


                this.colaboradorTableAdapter.queryEditarColaborador(this.iClinicDatabaseDataSet.Colaborador, ID);

                //Dar foco ao campo de teste.
                textBoxUpdNomeCompleto.Focus();

                if (panelEditarCadastro.Visible != true)
                {
                    if (Autenticacao._perfil() == "Profissional da Saude" || Autenticacao._perfil() == "PROFISSIONAL DE SAUDE")
                    {
                        btnUpdDadosProfissionais.Visible = true;
                    }

                    panelConsultarProfissional.Visible = false;
                    panelNovoCadastro.Visible = false;
                    panelEditarCadastro.Visible = true;

                    //Torna os componentes de pesquisa inativos durante as alteracoes
                    textPesquisarNome.Enabled = false;
                    btnPesquisar.Enabled = false;
                }
            }
            else
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("Não existe Colaborador Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdSair_Click(object sender, EventArgs e)
        {
            btnNovoCadastro.Enabled = true;
            btnEditarCadastro.Enabled = true;
            btnVizualizarCadastro.Enabled = true;
            btnExcluirCadastro.Enabled = true;

            if (Verificadores._alterarPerfil() == true)
            {
                this.Close();
            }

            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelConsultarProfissional.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarProfissional.Visible = true;

                //Torna os componentes de busca acessiveis novamente
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
            }

            this.frmCadastrarProfissional_Load(sender, e);
        }

        private void linkLabelUpdImportImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Choose Image(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (image.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUpdImgProfile.ImageLocation = null;
                pictureBoxUpdImgProfile.ImageLocation = image.FileName;

                linkLabelUpdExcluirImg.Visible = true;
            }
        }

        private void linkLabelUpdExcluirImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxUpdImgProfile.Image = null;
            linkLabelUpdExcluirImg.Visible = false;
        }

        private void btnUpdSalvar_Click(object sender, EventArgs e)
        {
            verificarComponentesEditarCadastro();

            if (liberado == true)
            {
                //Gera o Registro interno das acoes efetuadas no sistema 
                gerarLog();

                //chama a função para inserção no banco de dados.
                updateQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.colaboradorTableAdapter.queryDataColaborador(this.iClinicDatabaseDataSet.Colaborador);
                this.dataGridViewProfissional.Refresh();

                limparValores();

                MessageBox.Show("Alteração realizada com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnUpdDadosPessoais_Click(sender, e);

                if (Verificadores._alterarPerfil() == true)
                {
                    this.Close();
                }
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("A Alteração não pôde ser realizada." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            Reports.ReportCadastros.frmReportColaborador window = new Reports.ReportCadastros.frmReportColaborador();
            window.ShowDialog();
            window.Dispose();
        }

        #region Excluir Cadastro
        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (panelConsultarProfissional.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarProfissional.Visible = true;

                MessageBox.Show("Selecione o Colaborador que deseja Excluir!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridViewProfissional.Rows.Count != 0)
                {
                    gerarLog();

                    //Limpa os valores inseridos.
                    limparValores();

                    dataGridViewProfissional.Focus();

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
                        this.colaboradorTableAdapter.queryDataColaborador(this.iClinicDatabaseDataSet.Colaborador);
                        this.dataGridViewProfissional.Refresh();

                        MessageBox.Show("Colaborador Excluido com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        contagemRegistro();
                    }
                }
                else
                {
                    //Menssagem de alerta, caso ocorra algum erro inesperado
                    MessageBox.Show("Não existe Colaborador Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        #endregion

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

        private void panelConsultarProfissional_Paint(object sender, PaintEventArgs e)
        {
            panelConsultarProfissional.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConsultarProfissional.Width,
            panelConsultarProfissional.Height, 7, 7));
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

        private void panelCadOpcoesCadBottom_Paint(object sender, PaintEventArgs e)
        {
            panelCadOpcoesCadBottom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadOpcoesCadBottom.Width,
            panelCadOpcoesCadBottom.Height, 7, 7));
        }

        private void panelCadDadosProfisionais_Paint(object sender, PaintEventArgs e)
        {
            panelCadDadosProfisionais.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadDadosProfisionais.Width,
            panelCadDadosProfisionais.Height, 7, 7));
        }

        private void panelUpdTituloEditarCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelUpdTituloEditarCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdTituloEditarCadastro.Width,
            panelUpdTituloEditarCadastro.Height, 5, 5));
        }

        private void panelUpdOpcoesCadBottom_Paint(object sender, PaintEventArgs e)
        {
            panelUpdOpcoesCadBottom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdOpcoesCadBottom.Width,
            panelUpdOpcoesCadBottom.Height, 7, 7));
        }

        private void panelUpdDadosPessoais_Paint(object sender, PaintEventArgs e)
        {
            panelUpdDadosPessoais.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdDadosPessoais.Width,
            panelUpdDadosPessoais.Height, 7, 7));
        }

        private void panelUpdDadosProfissionais_Paint(object sender, PaintEventArgs e)
        {
            panelUpdDadosProfissionais.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelUpdDadosProfissionais.Width,
            panelUpdDadosProfissionais.Height, 7, 7));
        }
    }
}
