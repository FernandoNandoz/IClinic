using System;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing;

namespace IClinic.Forms.Cadastro
{
    public partial class frmPerfil : Form
    {
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

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmCadastrarPerfil_Load(object sender, EventArgs e)
        {
            this.perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
            dataGridViewPerfil.Refresh();
            banco.desconectar();
        }

        private void gerarLog()
        {
            Log.gerarLog("");
        }

        private void limparValores()
        {
            //
            textPesquisarNome.Clear();

            //Novo Cadastro
            textBoxCadNomePerfil.Clear();
            textBoxCadDescricaoPerfil.Clear();


            //Editar Cadastro
            textBoxUpdNomePerfil.Clear();
            textBoxUpdDescricaoPerfil.Clear();
        }

        private void insertQuery()
        {
            try
            {
                string Perfil = ("INSERT INTO Perfil (perfil, descricaoPerfil, codigoLog) VALUES (@perfil, @descricao, @codigoLog)");
                SqlCommand cadPerfil = new SqlCommand(Perfil, banco.connection);

                //Passando dados por parametros para inserção no banco.
                cadPerfil.Parameters.AddWithValue("@perfil", textBoxCadNomePerfil.Text);
                cadPerfil.Parameters.AddWithValue("@descricao", textBoxCadDescricaoPerfil.Text);
                cadPerfil.Parameters.AddWithValue("@codigoLog", Log._retornarLog());

                //Abertura do banco, salvando dados informados, e fechando banco.
                banco.conectar();
                cadPerfil.ExecuteNonQuery();
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
                string Perfil = ("UPDATE Perfil SET perfil = @perfil, descricaoPerfil = @descricao, codigoLog = @codigoLog WHERE idPerfil = @ID");
                SqlCommand UpdPerfil = new SqlCommand(Perfil, banco.connection);

                //Passando dados por parametros para inserção no banco.
                UpdPerfil.Parameters.AddWithValue("@perfil", textBoxUpdNomePerfil.Text);
                UpdPerfil.Parameters.AddWithValue("@descricao", textBoxUpdDescricaoPerfil.Text);
                UpdPerfil.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
                UpdPerfil.Parameters.AddWithValue("@ID", dataGridViewPerfil.CurrentRow.Cells[0].Value);

                //Abertura do banco, salvando dados informados, e fechando banco.
                banco.conectar();
                UpdPerfil.ExecuteNonQuery();
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
                string Perfil = ("DELETE FROM Perfil WHERE idPerfil = @ID");
                SqlCommand delPerfil = new SqlCommand(Perfil, banco.connection);

                //Passando dados por parametros para delete no banco.
                delPerfil.Parameters.AddWithValue("@ID", dataGridViewPerfil.CurrentRow.Cells[0].Value);

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                delPerfil.ExecuteNonQuery();
                banco.desconectar();

            }
            catch
            {
                //Menssagem de alerta, caso ocorra algum erro inesperado
                MessageBox.Show("A ação não pôde ser realizada." + "\n" + "Verifique os dados informados e tente novamente." + "\n" + "\n" + "Se persistir no erro, contate o suporte!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }  

        #region Novo Cadastro
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelNovoCadastro.Visible != true)
            {
                panelConsultarPerfil.Visible = false;
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

            if (panelConsultarPerfil.Visible != true)
            {
                panelConsultarPerfil.Visible = true;
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }

            this.frmCadastrarPerfil_Load(sender, e);
        }
        #endregion

        #region Editar Cadastro
        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            if (dataGridViewPerfil.Rows.Count != 0)
            {
                int ID = int.Parse(dataGridViewPerfil.CurrentRow.Cells[0].Value.ToString());

                //Limpa os valores inseridos.
                limparValores();

                //Requisição de dados filtrados
                this.perfilTableAdapter.queryEditarPerfil(this.iClinicDatabaseDataSet.Perfil, ID);

                //Dar foco ao campo de teste.
                textBoxUpdNomePerfil.Focus();

                if (panelEditarCadastro.Visible != true)
                {
                    panelConsultarPerfil.Visible = false;
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
                MessageBox.Show("Não existe Perfil Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltarEditar_Click(object sender, EventArgs e)
        {
            //Limpa os valores inseridos.
            limparValores();

            //Dar foco ao campo de teste.
            textPesquisarNome.Focus();

            if (panelConsultarPerfil.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarPerfil.Visible = true;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnEditarCadastro.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }

            this.frmCadastrarPerfil_Load(sender, e);
        }
        #endregion

        private void btnSalvarNovoCadastro_Click(object sender, EventArgs e)
        {
            //Verifica se todo os Campos foram preenchidos.
            if (textBoxCadNomePerfil.Text != "" && textBoxCadDescricaoPerfil.Text != "")
            {
                gerarLog();

                //chama a função para inserção no banco de dados.
                insertQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
                this.dataGridViewPerfil.Refresh();


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

        private void btnSalvarEditar_Click(object sender, EventArgs e)
        {
            //Verifica se todo os Campos foram preenchidos.
            if (textBoxUpdNomePerfil.Text != "" && textBoxUpdDescricaoPerfil.Text != "")
            {
                gerarLog();

                //chama a função para inserção no banco de dados.
                updateQuery();

                //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                this.perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
                this.dataGridViewPerfil.Refresh();

                //limpa todos os valores
                limparValores();

                MessageBox.Show("Alteração realizada com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparValores();
            }
            else
            {
                //Menssagem de alerta caso algum dos campos esja vazio
                MessageBox.Show("A Alteração não pôde ser realizado." + "\n" + "Verifique se todos os campos foram preenchidos" + "\n" + "\n" + "e tente novamente!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCadastrarPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Notifica um variavel Global sobre o fechamento do formulario.
            //Reposta: 2 = Fechado.
            Verificadores.abertoFechado(2);
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (panelConsultarPerfil.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelEditarCadastro.Visible = false;
                panelConsultarPerfil.Visible = true;

                MessageBox.Show("Selecione o Perfil que deseja Excluir!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridViewPerfil.Rows.Count != 0)
                {
                    //Limpa os valores inseridos.
                    limparValores();

                    dataGridViewPerfil.Focus();

                    //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
                    if (MessageBox.Show("Tem certeza que deseja apagar?" + "\n" + "\n" + "Uma vez apagado, não será mais possivel recupera-lo!", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        gerarLog();

                        //chama a função para delete na tabela.
                        deleteQuery();

                        //limpa todos os valores
                        limparValores();

                        //chama novamente os dados atualizados da tabela Users, e atualiza o datagridUsuarios.
                        this.perfilTableAdapter.Fill(this.iClinicDatabaseDataSet.Perfil);
                        this.dataGridViewPerfil.Refresh();
                        MessageBox.Show("Perfil Excluido com Sucesso!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Menssagem de alerta, caso ocorra algum erro inesperado
                    MessageBox.Show("Não existe Produto Cadastrado.", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            
        }

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No momento está função ainda não esta disponivel para uso." + "\n" + "\n" + "Estamos trabalhando para disponibiliza-la o mais rapido possivel!", "Aviso do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.perfilTableAdapter.queryPesquisarPerfil(this.iClinicDatabaseDataSet.Perfil, textPesquisarNome.Text);
        }

        private void textPesquisarNome_KeyDown(object sender, KeyEventArgs e)
        {
            this.perfilTableAdapter.queryPesquisarPerfil(this.iClinicDatabaseDataSet.Perfil, textPesquisarNome.Text);

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

        private void panelConsultarPerfil_Paint(object sender, PaintEventArgs e)
        {
            panelConsultarPerfil.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConsultarPerfil.Width,
            panelConsultarPerfil.Height, 7, 7));
        }

        private void panelEditarCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelEditarCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEditarCadastro.Width,
            panelEditarCadastro.Height, 7, 7));
        }

        private void panelNovoCadastro_Paint(object sender, PaintEventArgs e)
        {
            panelNovoCadastro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNovoCadastro.Width,
            panelNovoCadastro.Height, 7, 7));
        }

        
    }
}
