using IClinic.Properties;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IClinic.Forms
{
    public partial class FichaItem : UserControl
    {
        #region Dll - Arredondando paineis

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

        Banco banco = new Banco();

        bool aberto = false;
        int sizeFull = 0, sizeContent = 0, sizeVariavel = 0;
        string protocoloAtendimento;

        public FichaItem()
        {
            InitializeComponent();
        }

        #region Header

        private string _protocolo;
        private string _dia;
        private string _Mes;
        private string _Ano;
        private string _titulo;
        private string _resumo;
        private string _dataHora;
        private string _tempoAtendimento;
        private bool _verticalSuperior;

        [Category("Custom Props")]
        public string Protocolo
        {
            get { return _protocolo; }
            set { _protocolo = value; protocoloAtendimento = value; }
        }

        [Category("Custom Props")]
        public string Dia
        {
            get { return _dia; }
            set { _dia = value; labelDia.Text = value; }
        }

        [Category("Custom Props")]
        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; labelMes.Text = value; }
        }

        [Category("Custom Props")]
        public string Ano
        {
            get { return _Ano; }
            set { _Ano = value; labelAno.Text = value; }
        }

        [Category("Custom Props")]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; labelTitulo.Text = value; labelColaborado.Text = value; }
        }

        [Category("Custom Props")]
        public string Resumo
        {
            get { return _resumo; }
            set { _resumo = value; labelEspecialidade.Text = value; }
        }

        [Category("Custom Props")]
        public string DataHora
        {
            get { return _dataHora; }
            set { _dataHora = value; labelDataHora.Text = value; }
        }

        [Category("Custom Props")]
        public string TempoAtendimento
        {
            get { return _tempoAtendimento; }
            set { _tempoAtendimento = value; labelTempo.Text = (value + " minutos"); }
        }

        [Category("Custom Props")]
        public bool VerticalSuperior
        {
            get { return _verticalSuperior; }
            set { _verticalSuperior = value; lineShapeVerticalSuperior.Visible = value; }
        }

        #endregion

        private void FichaItem_Load(object sender, EventArgs e)
        {
            #region Dados carregamento

            Height = 140;
            this.panelContent.Size = new System.Drawing.Size(1016, 120);
            this.panelHeader.Size = new System.Drawing.Size(1016, 120);

            #endregion

            carregarAnamnese();
            carregarExamesFisico();
            carregarResultadoExame();
            carregarHipoteseDiagnostico();
            carregarConduta();
            carregarComentarioMedico();
            carregarExameProcedimento();
            carregarPrescricao();
            carregarDocumentoAtestado();
            carregarImagemAnexo();

            sizeContent = sizeVariavel;
            sizeFull = sizeVariavel + 5;
        }

        private void carregarAnamnese()
        {
            string Anamnese = ("SELECT * FROM Anamnese WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(Anamnese, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            while(datareader.Read())
            {
                panelHeaderAnamnese.Visible = true;

                sizeVariavel += 100;

                labelValueQueixaPrincipal.Text = datareader[2].ToString();
                labelValueHistoriaMolestia.Text = datareader[3].ToString();
                labelValuePele.Text = datareader[4].ToString();
                labelValueCabeca.Text = datareader[5].ToString();
                labelValueOlhos.Text = datareader[6].ToString();
                labelValueNariz.Text = datareader[7].ToString();
                labelValueOuvidos.Text = datareader[8].ToString();
                labelValueGarganta.Text = datareader[9].ToString();
                labelValueSistemaRespiratorio.Text = datareader[10].ToString();
                labelValueSistemaCardiovascular.Text = datareader[11].ToString();
                labelValueSistemaDigestorio.Text = datareader[12].ToString();
                labelValueSistemaGenitoUrinario.Text = datareader[13].ToString();
                labelValueSistemaLinfoHematopoletico.Text = datareader[14].ToString();
                labelValueSistemaEndocrinoMetabolico.Text = datareader[15].ToString();
                labelValueNeuroPsiquico.Text = datareader[16].ToString();
                labelValueSistemaLocomotor.Text = datareader[17].ToString();
                labelValueEstadoGeralSaude.Text = datareader[18].ToString();
                labelValueMedicacoesUso.Text = datareader[21].ToString();
                labelValueHospitalizacoesATC.Text = datareader[22].ToString();
                labelValueDoencasMentais.Text = datareader[23].ToString();
                labelValueAntecedentesReprodutivos.Text = datareader[24].ToString();
                labelValueAlergias.Text = datareader[25].ToString();
                labelValueImunizacoes.Text = datareader[26].ToString();
                labelValueHistoricoFamiliar.Text = datareader[27].ToString();
                labelValueFatoresRisco.Text = datareader[29].ToString();
                labelValueHistoriaOcupacional.Text = datareader[30].ToString();
                labelValueHabitos.Text = datareader[31].ToString();
                labelValueEstiloVida.Text = datareader[33].ToString();
                labelValueQueixaSexual.Text = datareader[34].ToString();
            }

            banco.desconectar();
        }

        private void carregarExamesFisico()
        {
            string ExameFisico = ("SELECT * FROM ExamesFisicos WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(ExameFisico, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            while (datareader.Read())
            {
                panelHeaderExameFisico.Visible = true;

                sizeVariavel += 100;


                labelValueExameFisicoGeral.Text = datareader[2].ToString();
                labelValueExameCabecaPescoco.Text = datareader[3].ToString();
                labelValueExameAparelhoRespiratorio.Text = datareader[4].ToString();
                labelValueExameAparelhoCardiovascular.Text = datareader[5].ToString();
                labelValueExameAbdomen.Text = datareader[6].ToString();
                labelValueExameAparelhoLocomotor.Text = datareader[7].ToString();
                labelValueExameSistemaNervoso.Text = datareader[8].ToString();
                labelValueExameAparelhoReprodutor.Text = datareader[9].ToString();

            }
            banco.desconectar();

        }

        private void carregarResultadoExame()
        {
            string ResultadoExame = ("SELECT resultadoExameLabo, resultadoExameImagem FROM FichaClinica WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(ResultadoExame, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            while (datareader.Read())
            {
                panelHeaderResultadoExame.Visible = true;

                sizeVariavel += 100;


                labelValueResultadoLaboratorial.Text = datareader[0].ToString();
                labelValueResultadoImagem.Text = datareader[1].ToString();

            }
            banco.desconectar();
        }

        private void carregarHipoteseDiagnostico()
        {
            string Diagnostico = ("SELECT hipoteseDiagnostica, observacaoHipoteseDiagnostica FROM FichaClinica WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(Diagnostico, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            while (datareader.Read())
            {
                panelHeaderHipoteseDiagnostica.Visible = true;

                sizeVariavel += 100;


                labelValueDiagnostico.Text = datareader[0].ToString();
                labelValueObservacaoHipotese.Text = datareader[1].ToString();

            }
            banco.desconectar();
        }

        private void carregarConduta()
        {
            string Conduta = ("SELECT conduta FROM FichaClinica WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(Conduta, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            while (datareader.Read())
            {
                panelHeaderConduta.Visible = true;

                sizeVariavel += 100;


                labelValueDescricaoConduta.Text = datareader[0].ToString();

            }
            banco.desconectar();
        }

        private void carregarComentarioMedico()
        {
            string ComentarioMedico = ("SELECT comentarioMedico FROM FichaClinica WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(ComentarioMedico, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            while (datareader.Read())
            {
                panelHeaderComentarioMedico.Visible = true;

                sizeVariavel += 100;
                
                labelValueComentarioMedico.Text = datareader[0].ToString();

            }
            banco.desconectar();
        }

        private void carregarExameProcedimento()
        {
            bool alterarEstado = false;

            string ExameProcedimento = ("SELECT Procedimento.procedimento, Procedimento.tipoProcedimento, SolicitacaoExame.quantidade FROM SolicitacaoExame INNER JOIN Procedimento ON SolicitacaoExame.idProcedimentoFK = Procedimento.idProcedimento WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(ExameProcedimento, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            dataGridViewExameProcedimento.Rows.Clear();
            while (datareader.Read())
            {
                if (alterarEstado == false)
                {
                    panelHeaderExameProcedimento.Visible = true;
                    sizeVariavel += 100;
                    alterarEstado = true;
                }

                dataGridViewExameProcedimento.Rows.Add(dataGridViewExameProcedimento.Rows.Count + 1,
                                                       datareader[0].ToString(),
                                                       datareader[1].ToString(),
                                                       datareader[2].ToString());
            }
            banco.desconectar();
            dataGridViewExameProcedimento.Refresh();
        }

        private void carregarPrescricao()
        {
            bool alterarEstado = false;

            string Anamnese = ("SELECT * FROM Prescricoes WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(Anamnese, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            dataGridViewPrescricao.Rows.Clear();
            while (datareader.Read())
            {
                if (alterarEstado == false)
                {
                    panelHeaderPrescricao.Visible = true;
                    sizeVariavel += 100;
                    alterarEstado = true;
                }

                dataGridViewPrescricao.Rows.Add(dataGridViewPrescricao.Rows.Count + 1,
                                                datareader[3].ToString(),
                                                datareader[7].ToString(),
                                                datareader[4].ToString());
            }
            banco.desconectar();
            dataGridViewPrescricao.Refresh();
        }

        private void carregarDocumentoAtestado()
        {
            bool alterarEstado = false;

            string Anamnese = ("SELECT * FROM Atestados WHERE idPaciente = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(Anamnese, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();              

            dataGridViewDocumentosAtestado.Rows.Clear();
            while (datareader.Read())
            {
                if (alterarEstado == false)
                {
                    panelHeaderDocumentoAtestado.Visible = true;
                    sizeVariavel += 100;
                    alterarEstado = true;
                }

                dataGridViewDocumentosAtestado.Rows.Add(dataGridViewDocumentosAtestado.Rows.Count + 1,
                                                        datareader[6].ToString());
                                                        
            }
            banco.desconectar();
            dataGridViewDocumentosAtestado.Refresh();
        }

        private void carregarImagemAnexo()
        {
            bool alterarEstado = false;

            string Anamnese = ("SELECT * FROM Arquivos WHERE idPacienteFK = @ID AND protocoloAtendimento = @protocolo");
            SqlCommand exeData = new SqlCommand(Anamnese, banco.connection);

            exeData.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
            exeData.Parameters.AddWithValue("@protocolo", protocoloAtendimento);

            banco.conectar();
            SqlDataReader datareader = exeData.ExecuteReader();

            dataGridViewImagemAnexo.Rows.Clear();
            while (datareader.Read())
            {
                if(alterarEstado == false)
                {
                    panelHeaderImagemAnexo.Visible = true;
                    sizeVariavel += 100;
                    alterarEstado = true;
                }

                dataGridViewImagemAnexo.Rows.Add(dataGridViewImagemAnexo.Rows.Count + 1,
                                                 datareader[1].ToString(),
                                                 datareader[2].ToString());

            }
            banco.desconectar();
            dataGridViewImagemAnexo.Refresh();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (aberto == true)
            {
                aberto = false;
                Size = new Size(1140, 140);
                this.panelContent.Size = new System.Drawing.Size(1016, 120);

                btnDetalhes.Text = "Mostrar detalhes do atendimento";
                
            }
            else
            {
                // Valor referencia: Tamanho total de 10085, e ContentPai = 10056

                aberto = true;
                Size = new Size(1140, sizeFull);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent);

                btnDetalhes.Text = "Ocultar detalhes do atendimento";
            }
        }

        private void panelData_Paint(object sender, PaintEventArgs e)
        {
            panelData.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelData.Width,
            panelData.Height, 7, 7));
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            panelContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContent.Width,
            panelContent.Height, 9, 9));
        }

        private void btnVizualizarAnamnese_Click(object sender, EventArgs e)
        {
            if (panelAnamnese.Visible == false)
            {
                panelAnamnese.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelAnamnese.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelAnamnese.Size.Height);

                btnVizualizarAnamnese.Image = Resources.icons8_invisible_30px;
            }
            else
            {      
                panelAnamnese.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelAnamnese.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelAnamnese.Size.Height);

                btnVizualizarAnamnese.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarExamesFisicos_Click(object sender, EventArgs e)
        {
            if (panelExamesFisicos.Visible == false)
            {
                panelExamesFisicos.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelExamesFisicos.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelExamesFisicos.Size.Height);

                btnVizualizarExamesFisicos.Image = Resources.icons8_invisible_30px;
            }
            else
            { 
                panelExamesFisicos.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelExamesFisicos.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelExamesFisicos.Size.Height);

                btnVizualizarExamesFisicos.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarResultadoExame_Click(object sender, EventArgs e)
        {
            if (panelResultadoExames.Visible == false)
            {
                panelResultadoExames.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelResultadoExames.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelResultadoExames.Size.Height);

                btnVizualizarResultadoExame.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelResultadoExames.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelResultadoExames.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelResultadoExames.Size.Height);

                btnVizualizarResultadoExame.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarHipoteseDiagnostica_Click(object sender, EventArgs e)
        {
            if (panelHipoteseDiagnostica.Visible == false)
            {
                panelHipoteseDiagnostica.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelHipoteseDiagnostica.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelHipoteseDiagnostica.Size.Height);

                btnVizualizarHipoteseDiagnostica.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelHipoteseDiagnostica.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelHipoteseDiagnostica.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelHipoteseDiagnostica.Size.Height);

                btnVizualizarHipoteseDiagnostica.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarConduta_Click(object sender, EventArgs e)
        {
            if (panelConduta.Visible == false)
            {
                panelConduta.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelConduta.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelConduta.Size.Height);

                btnVizualizarConduta.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelConduta.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelConduta.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelConduta.Size.Height);

                btnVizualizarConduta.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarComentarioMedico_Click(object sender, EventArgs e)
        {
            if (panelComentarioMedico.Visible == false)
            {
                panelComentarioMedico.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelComentarioMedico.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelComentarioMedico.Size.Height);

                btnVizualizarComentarioMedico.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelComentarioMedico.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelComentarioMedico.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelComentarioMedico.Size.Height);

                btnVizualizarComentarioMedico.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarExameProcedimento_Click(object sender, EventArgs e)
        {
            if (panelExamesProcedimentos.Visible == false)
            {
                panelExamesProcedimentos.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelExamesProcedimentos.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelExamesProcedimentos.Size.Height);

                btnVizualizarExameProcedimento.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelExamesProcedimentos.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelExamesProcedimentos.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelExamesProcedimentos.Size.Height);

                btnVizualizarExameProcedimento.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarPrescricao_Click(object sender, EventArgs e)
        {
            if (panelPrescricao.Visible == false)
            {
                panelPrescricao.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelPrescricao.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelPrescricao.Size.Height);

                btnVizualizarPrescricao.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelPrescricao.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelPrescricao.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelPrescricao.Size.Height);

                btnVizualizarPrescricao.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarDocumentoAtestado_Click(object sender, EventArgs e)
        {
            if (panelDocumentosAtestados.Visible == false)
            {
                panelDocumentosAtestados.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelDocumentosAtestados.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelDocumentosAtestados.Size.Height);

                btnVizualizarDocumentoAtestado.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelDocumentosAtestados.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelDocumentosAtestados.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelDocumentosAtestados.Size.Height);

                btnVizualizarDocumentoAtestado.Image = Resources.icons8_eye_30px;
            }
        }

        private void btnVizualizarImagemAnexo_Click(object sender, EventArgs e)
        {
            if (panelImagemAnexo.Visible == false)
            {
                panelImagemAnexo.Visible = true;

                Size = new Size(1140, sizeFull = sizeFull + panelImagemAnexo.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent + panelImagemAnexo.Size.Height);

                btnVizualizarImagemAnexo.Image = Resources.icons8_invisible_30px;
            }
            else
            {
                panelImagemAnexo.Visible = false;

                Size = new Size(1140, sizeFull = sizeFull - panelImagemAnexo.Size.Height);
                this.panelContent.Size = new System.Drawing.Size(1016, sizeContent = sizeContent - panelImagemAnexo.Size.Height);

                btnVizualizarImagemAnexo.Image = Resources.icons8_eye_30px;
            }
        }
    }
}
