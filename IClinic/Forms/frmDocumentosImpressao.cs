using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace IClinic.Forms.Cadastro
{
    public partial class frmDocumentosImpressao : Form
    {
        Banco banco = new Banco();


        public frmDocumentosImpressao()
        {
            InitializeComponent();
        }

        private void frmDocumentosImpressao_Load(object sender, EventArgs e)
        {
            carregarDocumentos();
        }


        private string importarArquivo()
        {
            var retorno = string.Empty;

            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    retorno = dialog.FileName;
                }
            }
            return retorno;
        }

        public void carregarArquivo(string importFile)
        {
            var arquivo = new FileInfo(importFile);

            if (arquivo.Exists)
            {
                var fileName = arquivo.Name.Substring(0, arquivo.Name.Length - arquivo.Extension.Length);
                var fileExtensao = arquivo.Extension.Substring(1);

                dataGridViewImagemAnexo.Rows.Add(dataGridViewImagemAnexo.Rows.Count + 1, textBoxCadNomeModelo.Text, fileExtensao, arquivo);

                textBoxCadNomeModelo.Clear();
            }
        }

        private void carregarDocumentos()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Documento = ("SELECT * FROM Documentos ORDER BY modeloDocumento");
            SqlCommand exeVerificacao = new SqlCommand(Documento, banco.connection);
            banco.conectar();

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            dataGridViewDocumento.Rows.Clear();
            while (datareader.Read())
            {
                dataGridViewDocumento.Rows.Add(
                    datareader[1].ToString(),
                    datareader[3].ToString(),
                    datareader[4].ToString(),
                    datareader[5].ToString(),
                    datareader[0].ToString()
                );
            }

            banco.desconectar();
            dataGridViewDocumento.Refresh();
        }

        #region Novo Cadastro
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            if (panelNovoCadastro.Visible != true)
            {
                panelConsultarDocumento.Visible = false;
                panelNovoCadastro.Visible = true;

                //
                textPesquisarNome.Enabled = false;
                btnPesquisar.Enabled = false;
                btnNovoCadastro.Enabled = false;
                btnVizualizarCadastro.Enabled = false;
                btnExcluirCadastro.Enabled = false;
            }
        }

        private void btnSairNovoCadastro_Click(object sender, EventArgs e)
        {
            if (panelConsultarDocumento.Visible != true)
            {
                panelNovoCadastro.Visible = false;
                panelConsultarDocumento.Visible = true;

                //
                textPesquisarNome.Enabled = true;
                btnPesquisar.Enabled = true;
                btnNovoCadastro.Enabled = true;
                btnVizualizarCadastro.Enabled = true;
                btnExcluirCadastro.Enabled = true;
            }
        }
        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Documento = ("SELECT * FROM Documentos WHERE modeloDocumento LIKE @documento + '%' ORDER BY modeloDocumento");
            SqlCommand exeVerificacao = new SqlCommand(Documento, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@documento", textPesquisarNome.Text);

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            dataGridViewDocumento.Rows.Clear();
            while (datareader.Read())
            {
                dataGridViewDocumento.Rows.Add(
                    datareader[1].ToString(),
                    datareader[3].ToString(),
                    datareader[4].ToString(),
                    datareader[5].ToString(),
                    datareader[0].ToString()
                );
            }

            banco.desconectar();
            dataGridViewDocumento.Refresh();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if (textBoxCadNomeModelo.Text != "")
            {
                var arquivo = importarArquivo();
                //
                carregarArquivo(arquivo);
            }
            else
            {
                MessageBox.Show("O campo (Nome modelo de Documento) naõ pode estar vazio." + "\n" + "\n" + "Informe um nome para esse documento por favor.");
            }
        }

        private void backgroundWorkerDeterminada_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int progress = 0;
            int contGrid = dataGridViewImagemAnexo.Rows.Count;
            int contResult = 100 / contGrid;

            string ImagemAnexo = ("INSERT INTO Documentos (modeloDocumento, extensao, length, fileStream) VALUES (@modeloDocumento, @extensao, @length, @fileStream)");
            SqlCommand exeImagemAnexo = new SqlCommand(ImagemAnexo, banco.connection);

            for (int i = 0; i < dataGridViewImagemAnexo.Rows.Count - 0; i++)
            {
                progress += contResult;

                var arquivo = new FileInfo(dataGridViewImagemAnexo.Rows[i].Cells[3].Value.ToString());

                if (arquivo.Exists)
                {
                    var fileBinary = new byte[arquivo.Length];
                    using (var fileStream = arquivo.OpenRead())
                    {
                        fileStream.Read(fileBinary, 0, (int)arquivo.Length);
                    }

                    var fileName = arquivo.Name.Substring(0, arquivo.Name.Length - arquivo.Extension.Length);
                    var fileExtensao = arquivo.Extension.Substring(1);
                    var fileSelect = new Arquivo
                    {
                        nomeArquivo = fileName,
                        extensao = fileExtensao,
                        length = arquivo.Length,
                        FileStream = fileBinary
                    };

                    exeImagemAnexo.Parameters.Clear();
                    exeImagemAnexo.Parameters.AddWithValue("@modeloDocumento", dataGridViewDocumento.CurrentRow.Cells[0].Value.ToString());
                    exeImagemAnexo.Parameters.AddWithValue("@extensao", fileSelect.extensao);
                    exeImagemAnexo.Parameters.AddWithValue("@length", fileSelect.length);
                    exeImagemAnexo.Parameters.AddWithValue("@fileStream", fileSelect.FileStream);

                    banco.conectar();
                    exeImagemAnexo.ExecuteNonQuery();
                    banco.desconectar();
                }



                //incrementa o progresso do backgroundWorker
                //a cada passagem do loop.
                this.backgroundWorkerDeterminada.ReportProgress(progress);

                //Verifica se houve uma requisição para cancelar a operação.
                if (backgroundWorkerDeterminada.CancellationPending)
                {
                    //se sim, define a propriedade Cancel para true
                    //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                    e.Cancel = true;

                    //zera o percentual de progresso do backgroundWorker1.
                    backgroundWorkerDeterminada.ReportProgress(0);
                    return;
                }
            }

            //Finalmente, caso tudo esteja ok, finaliza
            //o progresso em 100%.
            backgroundWorkerDeterminada.ReportProgress(100);
        }

        private void backgroundWorkerDeterminada_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            progressBarImagemAnexo.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            labelPorcentagem.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorkerDeterminada_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                labelStatus.Text = "Operação Cancelada pelo Usuário!";

                //habilita o Botao cancelar
                //btnCancelar.Enabled = true;
                //limpa a label
                labelPorcentagem.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                labelStatus.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                labelStatus.Text = "Tarefa Concluida com sucesso!";
            }

            labelStatus.Visible = false;
            labelPorcentagem.Visible = false;
            progressBarImagemAnexo.Visible = false;
        }

        private void btnSalvarNovoCadastro_Click(object sender, EventArgs e)
        {

            progressBarImagemAnexo.Visible = true;
            progressBarImagemAnexo.Style = ProgressBarStyle.Blocks;
            progressBarImagemAnexo.Value = 0;

            labelStatus.Visible = true;
            labelPorcentagem.Visible = true;
            progressBarImagemAnexo.Visible = true;

            backgroundWorkerDeterminada.RunWorkerAsync();

            MessageBox.Show("Salvo com sucesso!");

            dataGridViewImagemAnexo.Rows.Clear();

            carregarDocumentos();

        }

        private void dataGridViewImagemAnexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGridViewImagemAnexo.Rows.RemoveAt(dataGridViewImagemAnexo.CurrentRow.Index);
            }
        }

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Documento = ("SELECT fileStream FROM Documentos WHERE idDocumento = @ID");
                SqlCommand exeVerificacao = new SqlCommand(Documento, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@ID", dataGridViewDocumento.CurrentRow.Cells[4].Value);

                var bytes = exeVerificacao.ExecuteScalar() as byte[];

                if (bytes != null)
                {
                    var nomeArquivo = dataGridViewDocumento.CurrentRow.Cells[0].Value.ToString() + "." + dataGridViewDocumento.CurrentRow.Cells[1].Value.ToString();
                    var arquivoTemp = Path.GetTempFileName();

                    arquivoTemp = Path.ChangeExtension(arquivoTemp, Path.GetExtension(nomeArquivo));
                    File.WriteAllBytes(arquivoTemp, bytes);
                    Process.Start(arquivoTemp);
                }

                banco.desconectar();
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }       
    }
}
