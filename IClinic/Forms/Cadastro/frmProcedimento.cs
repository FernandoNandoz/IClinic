using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing;

namespace IClinic.Forms.Cadastro
{
    public partial class frmProcedimento : Form
    {
        //Instancia com a Classe Global.cs
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

        public frmProcedimento()
        {
            InitializeComponent();
        }

        private void frmCadastrarProcedimento_Load(object sender, EventArgs e)
        {
            this.procedimentoTableAdapter.Fill(this.iClinicDatabaseDataSet.Procedimento);
            banco.desconectar();
        }

        private void gerarLog()
        {
            Log.gerarLog("");
        }

        private void limparValores()
        {
            textPesquisarNome.Clear();
            //
            textBoxCadProcedimento.Clear();
            textBoxCadTipoProcedimento.Clear();
            //
            textBoxUpdProcedimento.Clear();
            textBoxUpdTipoProcedimento.Clear();
        }

        private void insertQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string procedimento = ("INSERT INTO Procedimento (procedimento, tipoProcedimento, nomeGenerico, codigoLog) VALUES (@procedimento, @tipoProcedimento, @nomeGenerico, @codigoLog)");
            SqlCommand cadProcedimento = new SqlCommand(procedimento, banco.connection);

            //Passando dados por parametros para inserção no banco.
            cadProcedimento.Parameters.AddWithValue("@procedimento", textBoxCadProcedimento.Text);
            cadProcedimento.Parameters.AddWithValue("@nomeGenerico", textBoxCadProcedimento.Text + " - (" + textBoxCadTipoProcedimento.Text + ")");
            cadProcedimento.Parameters.AddWithValue("@tipoProcedimento", textBoxCadTipoProcedimento.Text);
            cadProcedimento.Parameters.AddWithValue("@descricaoProcedimento", textBoxCadProcedimento.Text + " - (" + textBoxCadTipoProcedimento.Text + ")");
            cadProcedimento.Parameters.AddWithValue("@codigoLog", Log._retornarLog());

            //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
            banco.conectar();
            cadProcedimento.ExecuteNonQuery();
            banco.desconectar();

        }

        private void updateQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string procedimento = ("UPDATE Procedimento SET procedimento = @procedimento, tipoProcedimento = @tipoProcedimento, nomeGenerico = @nomeGenerico, codigoLog = @codigoLog WHERE idProcedimento = @ID");
            SqlCommand UpdProcedimento = new SqlCommand(procedimento, banco.connection);

            //Passando dados por parametros para inserção no banco.
            UpdProcedimento.Parameters.AddWithValue("@procedimento", textBoxUpdProcedimento.Text);
            UpdProcedimento.Parameters.AddWithValue("@nomeGenerico", textBoxUpdProcedimento.Text + " - (" + textBoxUpdTipoProcedimento.Text + ")");
            UpdProcedimento.Parameters.AddWithValue("@tipoProcedimento", textBoxUpdTipoProcedimento.Text);
            UpdProcedimento.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
            UpdProcedimento.Parameters.AddWithValue("@ID", dataGridProcedimento.CurrentRow.Cells[0].Value);

            //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
            banco.conectar();
            UpdProcedimento.ExecuteNonQuery();
            banco.desconectar();

        }

        private void deleteQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string procedimento = ("DELETE FROM Procedimento WHERE idProcedimento = @ID");
            SqlCommand delProcedimento = new SqlCommand(procedimento, banco.connection);

            //Passando dados por parametros para inserção no banco.
            delProcedimento.Parameters.AddWithValue("@ID", dataGridProcedimento.CurrentRow.Cells[0].Value);

            //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
            banco.conectar();
            delProcedimento.ExecuteNonQuery();
            banco.desconectar();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.procedimentoTableAdapter.queryPesquisarProcedimento(this.iClinicDatabaseDataSet.Procedimento, textPesquisarNome.Text);
        }

        private void textPesquisarNome_KeyDown(object sender, KeyEventArgs e)
        {
            this.procedimentoTableAdapter.queryPesquisarProcedimento(this.iClinicDatabaseDataSet.Procedimento, textPesquisarNome.Text);
        }

        #region Novo Cadastro

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textBoxCadProcedimento.Focus();

            if (panelNovoCadastro.Visible != true)
            {
                panelConsultarProcedimento.Visible = false;
                panelNovoCadastro.Visible = true;
                panelEditarCadastro.Visible = false;

                //
                textPesquisarNome.Enabled = false;
                btnPesquisar.Enabled = false;
                btnNovoCadastro.Enabled = false;
                btnEditarCadastro.Enabled = false;
                btnVizualizarCadastro.Enabled = false;
                btnExcluirCadastro.Enabled = false;
            }
        }

        private void btnSairNovoCadastro_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelConsultarProcedimento.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarProcedimento.Visible = true;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }
        }

        private void btnSalvarNovoCadastro_Click(object sender, EventArgs e)
        {
            if (textBoxCadProcedimento.Text != ("") && textBoxCadTipoProcedimento.Text != (""))
            {
                //
                gerarLog();

                //chama a função para inserção no banco de dados.
                insertQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.procedimentoTableAdapter.Fill(this.iClinicDatabaseDataSet.Procedimento);
                this.dataGridProcedimento.Refresh();


                MessageBox.Show("Cadastro realizado com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa todos os valores
                limparValores();
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Editar Cadastro

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            if (dataGridProcedimento.Rows.Count != 0)
            {
                int ID = int.Parse(dataGridProcedimento.CurrentRow.Cells[0].Value.ToString());

                //limpar valores inseridos
                limparValores();

                //Requisição de dados filtrados
                this.procedimentoTableAdapter.queryEditarProcedimento(this.iClinicDatabaseDataSet.Procedimento, ID);

                if (panelEditarCadastro.Visible != true)
                {
                    panelConsultarProcedimento.Visible = false;
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
                MessageBox.Show("Não existe Procedimento Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltarEditar_Click(object sender, EventArgs e)
        {
            //limpar os valores inseridos
            limparValores();

            //dar foco a campo de pesquisa
            textPesquisarNome.Focus();

            if (panelConsultarProcedimento.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarProcedimento.Visible = true;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }

            this.frmCadastrarProcedimento_Load(sender, e);
        }

        private void btnSalvarEditar_Click(object sender, EventArgs e)
        {
            if (textBoxUpdProcedimento.Text != ("") && textBoxUpdTipoProcedimento.Text != (""))
            {
                //
                gerarLog();

                //chama a função para inserção no banco de dados.
                updateQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.procedimentoTableAdapter.Fill(this.iClinicDatabaseDataSet.Procedimento);
                this.dataGridProcedimento.Refresh();

                limparValores();

                MessageBox.Show("Alteração realizada com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("A Alteração não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion  

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No momento está função ainda não esta disponivel para uso." + "\n" + "\n" + "Estamos trabalhando para disponibiliza-la o mais rapido possivel!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (panelConsultarProcedimento.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarProcedimento.Visible = true;

                MessageBox.Show("Selecione o Perfil que deseja Excluir!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridProcedimento.Rows.Count != 0)
                {
                    gerarLog();

                    //Limpa os valores inseridos.
                    limparValores();

                    dataGridProcedimento.Focus();

                    //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
                    if (MessageBox.Show("Tem certeza que deseja apagar?" + "\n" + "\n" + "Uma vez apagado, não será mais possivel recupera-lo!", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //chama a função para delete na tabela.
                        deleteQuery();

                        //limpa todos os valores
                        limparValores();

                        //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                        this.procedimentoTableAdapter.Fill(this.iClinicDatabaseDataSet.Procedimento);
                        this.dataGridProcedimento.Refresh();

                        MessageBox.Show("Procedimento Excluido com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Menssagem de alerta, caso ocorra algum erro inesperado
                    MessageBox.Show("Não existe Procedimento Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void frmCadastrarProcedimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Verificadores.abertoFechado(2);
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

        private void panelConsultarProcedimento_Paint(object sender, PaintEventArgs e)
        {
            panelConsultarProcedimento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConsultarProcedimento.Width,
            panelConsultarProcedimento.Height, 7, 7));
        }

        private void panelNovoCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelEditarCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEditarCadastro.Width,
            panelEditarCadastro.Height, 7, 7));
        }

        private void panelEditarCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelNovoCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNovoCadastro.Width,
            panelNovoCadastro.Height, 7, 7));
        }
    }
}
