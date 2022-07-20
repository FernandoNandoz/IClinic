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
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace IClinic.Forms
{
    public partial class frmIniciarAtendimento : Form
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

        Stopwatch cronometro = new Stopwatch();

        int tipoGuia = 0;
        string historiaFamiliar, habitos, estiloVida, mes;
        bool liberadoAnamnese = true, liberadoExameFisico = true, liberadoFichaClinica = true;


        public frmIniciarAtendimento()
        {
            InitializeComponent();
        }

        private void frmIniciarAtendimento_Load(object sender, EventArgs e)
        {
            carregarHeader();
            carregarGuia();

            //
            labelValueNomeProfissional.Text = Autenticacao._nome();
            cronometro.Start();
        }

        private void limparProcessosFinalizados()
        {
            //
            labelValueQueixaPrincipal.Text = null;
            labelValueHistoriaMolestia.Text = null;
            labelValuePele.Text = null;
            labelValueCabeca.Text = null;
            labelValueOlhos.Text = null;
            labelValueNariz.Text = null;
            labelValueOuvidos.Text = null;
            labelValueGarganta.Text = null;
            labelValueSistemaRespiratorio.Text = null;
            labelValueSistemaCardiovascular.Text = null;
            labelValueSistemaDigestorio.Text = null;
            labelValueSistemaGenitoUrinario.Text = null;
            labelValueSistemaLinfoHematopoletico.Text = null;
            labelValueSistemaEndocrinoMetabolico.Text = null;
            labelValueNeuroPsiquico.Text = null;
            labelValueSistemaLocomotor.Text = null;
            labelValueEstadoGeralSaude.Text = null;
            labelValueMedicacoesUso.Text = null;
            labelValueHospitalizacoesATC.Text = null;
            labelValueDoencasMentais.Text = null;
            labelValueAntecedentesReprodutivos.Text = null;
            labelValueAlergias.Text = null;
            labelValueImunizacoes.Text = null;
            labelValueHistoricoFamiliar.Text = null;
            labelValueFatoresRisco.Text = null;
            labelValueHistoriaOcupacional.Text = null;
            labelValueHabitos.Text = null;
            labelValueEstiloVida.Text = null;
            labelValueQueixaSexual.Text = null;

            //
            labelValueExameFisicoGeral.Text = null;
            labelValueExameCabecaPescoco.Text = null;
            labelValueExameAparelhoRespiratorio.Text = null;
            labelValueExameAparelhoCardiovascular.Text = null;
            labelValueExameAbdomen.Text = null;
            labelValueExameAparelhoLocomotor.Text = null;
            labelValueExameSistemaNervoso.Text = null;
            labelValueExameAparelhoReprodutor.Text = null;

            //
            labelValueResultadoLaboratorial.Text = null;
            labelValueResultadoImagem.Text = null;

            //
            labelValueDiagnostico.Text = null;
            labelValueObservacaoHipotese.Text = null;

            //
            labelValueDescricaoConduta.Text = null;

            //
            labelValueComentarioMedico.Text = null;
        }

        private void carregarProcessoFinalizado()
        {
            limparProcessosFinalizados();
            //
            labelValueQueixaPrincipal.Text = textBoxQueixaPrincipal.Text;
            labelValueHistoriaMolestia.Text = textBoxHistoriaMolestiaAtual.Text;
            labelValuePele.Text = textBoxPele.Text;
            labelValueCabeca.Text = textBoxCabeca.Text;
            labelValueOlhos.Text = textBoxOlhos.Text;
            labelValueNariz.Text = textBoxNariz.Text;
            labelValueOuvidos.Text = textBoxOuvidos.Text;
            labelValueGarganta.Text = textBoxGarganta.Text;
            labelValueSistemaRespiratorio.Text = textBoxSistemaRespiratorio.Text;
            labelValueSistemaCardiovascular.Text = textBoxSistemaCardiovascular.Text;
            labelValueSistemaDigestorio.Text = textBoxSistemaDigestorio.Text;
            labelValueSistemaGenitoUrinario.Text = textBoxSistemaGenitoUrinario.Text;
            labelValueSistemaLinfoHematopoletico.Text = textBoxSistemaLinfoHematopoletico.Text;
            labelValueSistemaEndocrinoMetabolico.Text = textBoxSistemaEndocrinoMeabolico.Text;
            labelValueNeuroPsiquico.Text = textBoxNeuroPsiquico.Text;
            labelValueSistemaLocomotor.Text = textBoxSistemaLocomotor.Text;
            labelValueEstadoGeralSaude.Text = textBoxEstadoGeralSaude.Text;
            labelValueMedicacoesUso.Text = textBoxMedicacoesUso.Text;
            labelValueHospitalizacoesATC.Text = textBoxHospitalizacoesATC.Text;
            labelValueDoencasMentais.Text = textBoxDoencasMentais.Text;
            labelValueAntecedentesReprodutivos.Text = textBoxAntencedentesReprodutivos.Text;
            labelValueAlergias.Text = textBoxAlergias.Text;
            labelValueImunizacoes.Text = textBoxImunizacoes.Text;
            labelValueHistoricoFamiliar.Text = historiaFamiliar;
            labelValueFatoresRisco.Text = textBoxFatoresRiscoDEE.Text;
            labelValueHistoriaOcupacional.Text = textBoxHistoriaOcupacional.Text;
            labelValueHabitos.Text = habitos;
            labelValueEstiloVida.Text = estiloVida;
            labelValueQueixaSexual.Text = textBoxQueixasSexual.Text;

            //
            labelValueExameFisicoGeral.Text = textBoxExameFisicoGeral.Text;
            labelValueExameCabecaPescoco.Text = textBoxExameCabecaPescoco.Text;
            labelValueExameAparelhoRespiratorio.Text = textBoxExameRespiratorio.Text;
            labelValueExameAparelhoCardiovascular.Text = textBoxExameCardiovascular.Text;
            labelValueExameAbdomen.Text = textBoxExameAbdomen.Text;
            labelValueExameAparelhoLocomotor.Text = textBoxExameLocomotor.Text;
            labelValueExameSistemaNervoso.Text = textBoxExameSistemaNervoso.Text;
            labelValueExameAparelhoReprodutor.Text = textBoxExameReprodutor.Text;

            //
            labelValueResultadoLaboratorial.Text = textBoxResultadoLaboratoriais.Text;
            labelValueResultadoImagem.Text = textBoxResultadoImagem.Text;

            //
            labelValueDiagnostico.Text = textBoxHipoteseDiagnostico.Text;
            labelValueObservacaoHipotese.Text = textBoxObservacaoHipoteseDiagnostico.Text;

            //
            labelValueDescricaoConduta.Text = textBoxCondutas.Text;

            //
            labelValueComentarioMedico.Text = textBoxComentarioMedico.Text;
        }

        private void gerarLog()
        {
            Log.gerarLog("");
        }

        private void verificarTodosOsCampos()
        {
            if (textBoxQueixaPrincipal.Text == ""
                && textBoxHistoriaMolestiaAtual.Text == ""
                && textBoxPele.Text == ""
                && textBoxCabeca.Text == ""
                && textBoxOlhos.Text == ""
                && textBoxNariz.Text == ""
                && textBoxOuvidos.Text == ""
                && textBoxGarganta.Text == ""
                && textBoxSistemaRespiratorio.Text == ""
                && textBoxSistemaCardiovascular.Text == ""
                && textBoxSistemaDigestorio.Text == ""
                && textBoxSistemaGenitoUrinario.Text == ""
                && textBoxSistemaLinfoHematopoletico.Text == ""
                && textBoxSistemaEndocrinoMeabolico.Text == ""
                && textBoxNeuroPsiquico.Text == ""
                && textBoxSistemaLocomotor.Text == ""
                && textBoxEstadoGeralSaude.Text == ""
                && textBoxMedicacoesUso.Text == ""
                && textBoxHospitalizacoesATC.Text == ""
                && textBoxDoencasMentais.Text == ""
                && textBoxAntencedentesReprodutivos.Text == ""
                && textBoxAlergias.Text == ""
                && textBoxImunizacoes.Text == ""
                && checkBoxHAS.Checked == false
                && checkBoxDM.Checked == false
                && checkBoxTrombose.Checked == false
                && checkBoxDislipidemia.Checked == false
                && checkBoxCancer.Checked == false
                && checkBoxAutoImune.Checked == false
                && checkBoxOutrasDoencas.Checked == false
                && textBoxOutrasDrogas.Text == ""
                && textBoxFatoresRiscoDEE.Text == ""
                && textBoxHistoriaOcupacional.Text == ""
                && checkBoxEtilismo.Checked == false
                && checkBoxTabagismo.Checked == false
                && checkBoxOutrasDrogas.Checked == false
                && textBoxOutrasDrogas.Text == ""
                && radioButtonSedentario.Checked == false
                && radioButtonAtividadeFisicaRegular.Checked == false
                && textBoxQueixasSexual.Text == ""
                )
            {
                liberadoAnamnese = false;
            }

            if (textBoxExameFisicoGeral.Text == ""
                && textBoxExameCabecaPescoco.Text == ""
                && textBoxExameRespiratorio.Text == ""
                && textBoxExameCardiovascular.Text == ""
                && textBoxExameAbdomen.Text == ""
                && textBoxExameLocomotor.Text == ""
                && textBoxExameSistemaNervoso.Text == ""
                && textBoxExameReprodutor.Text == ""
                )
            {
                liberadoExameFisico = false;
            }

            if(textBoxResultadoLaboratoriais.Text == ""
                && textBoxResultadoImagem.Text == ""
                && textBoxHipoteseDiagnostico.Text == ""
                && textBoxObservacaoHipoteseDiagnostico.Text == ""
                && textBoxCondutas.Text == ""
                && textBoxComentarioMedico.Text == "")
            {
                liberadoFichaClinica = false;
            }
        }

        private void verificarMes()
        {
            if (DateTime.Now.Month == 01)
            {
                mes = "JAN";
            }

            if (DateTime.Now.Month == 02)
            {
                mes = "FEV";
            }

            if (DateTime.Now.Month == 03)
            {
                mes = "MAR";
            }

            if (DateTime.Now.Month == 04)
            {
                mes = "ABR";
            }

            if (DateTime.Now.Month == 05)
            {
                mes = "MAI";
            }

            if (DateTime.Now.Month == 06)
            {
                mes = "JUN";
            }

            if (DateTime.Now.Month == 07)
            {
                mes = "JUL";
            }

            if (DateTime.Now.Month == 08)
            {
                mes = "AGO";
            }

            if (DateTime.Now.Month == 09)
            {
                mes = "SET";
            }

            if (DateTime.Now.Month == 10)
            {
                mes = "OUT";
            }

            if (DateTime.Now.Month == 11)
            {
                mes = "NOV";
            }

            if (DateTime.Now.Month == 12)
            {
                mes = "DEZ";
            }
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            string hora, minuto, segundo;

            if (cronometro.Elapsed.Hours < 10)
            {
                hora = "0" + cronometro.Elapsed.Hours.ToString();
            }
            else
            {
                hora = cronometro.Elapsed.Hours.ToString();
            }

            if (cronometro.Elapsed.Minutes < 10)
            {
                minuto = "0" + cronometro.Elapsed.Minutes.ToString();
            }
            else
            {
                minuto = cronometro.Elapsed.Minutes.ToString();
            }

            if (cronometro.Elapsed.Seconds < 10)
            {
                segundo = "0" + cronometro.Elapsed.Seconds.ToString();
            }
            else
            {
                segundo = cronometro.Elapsed.Seconds.ToString();
            }

            labelValueTempo.Text = hora + ":" + minuto + ":" + segundo;
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

                dataGridViewImagemAnexo.Rows.Add(dataGridViewImagemAnexo.Rows.Count + 1, fileName, fileExtensao, arquivo);             
            }
        }

        private void AutoCompleteHipoteseDiagnostico()
        {
            if (comboBoxSugestaoDiagnosico.Text == "ATIVADO")
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT hipoteseDiagnostica FROM FichaClinica", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxHipoteseDiagnostico.AutoCompleteCustomSource = lista;

                banco.desconectar();
            }
            else
            {
                textBoxHipoteseDiagnostico.AutoCompleteCustomSource = null;
            }
        }

        private void AutoCompleteExamesProcedimentos()
        {
            SqlCommand exePesquisa = new SqlCommand("SELECT nomeGenerico FROM Procedimento", banco.connection);
            banco.conectar();
            SqlDataReader dr = exePesquisa.ExecuteReader();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                lista.Add(dr.GetString(0));
            }

            textBoxExamesProcedimentos.AutoCompleteCustomSource = lista;

            banco.desconectar();
        }

        private void AutoCompletePrescricao()
        {
            if (comboBoxSugestaoPrescricao.Text == "ATIVADO")
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT medicamento FROM Prescricoes", banco.connection);
                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }

                textBoxMedicamento.AutoCompleteCustomSource = lista;
                banco.desconectar();
            }
            else
            {
                textBoxMedicamento.AutoCompleteCustomSource = null;
            }
        }

        private void carregarDadosCheckBoxAnamnese()
        {
            #region Historico familia

            if (checkBoxHAS.Checked == true)
            {
                historiaFamiliar = "Hipertensão Arterial Sistêmica - " + checkBoxHAS.Text;
            }

            if (checkBoxDM.Checked == true)
            {
                historiaFamiliar = "Diabetes mellitus - " + checkBoxDM.Text;
            }

            if (checkBoxTrombose.Checked == true)
            {
                historiaFamiliar = checkBoxTrombose.Text;
            }

            if (checkBoxDislipidemia.Checked == true)
            {
                historiaFamiliar = checkBoxDislipidemia.Text;
            }

            if (checkBoxCancer.Checked == true)
            {
                historiaFamiliar = checkBoxCancer.Text;
            }

            if (checkBoxAutoImune.Checked == true)
            {
                historiaFamiliar = textBoxAutoImune.Text;
            }

            if (checkBoxOutrasDoencas.Checked == true)
            {
                historiaFamiliar = textBoxOutrasDoencasFamilia.Text;
            }

            #endregion

            #region Habitos

            if (checkBoxEtilismo.Checked == true)
            {
                habitos = "Alcoólatra " + checkBoxEtilismo.Text;
            }

            if (checkBoxTabagismo.Checked == true)
            {
                habitos = checkBoxTabagismo.Text;
            }

            if (checkBoxOutrasDrogas.Checked == true)
            {
                habitos = textBoxOutrasDrogas.Text;
            }

            #endregion

            #region Estilo de vida

            if (radioButtonSedentario.Checked == true)
            {
                estiloVida = radioButtonSedentario.Text;
            }

            if (radioButtonAtividadeFisicaRegular.Checked == true)
            {
                estiloVida = radioButtonAtividadeFisicaRegular.Text;
            }

            #endregion
        }

        private void carregarHeader()
        {
            string Header = ("SELECT nomePaciente, DATEDIFF(YEAR, dataNascimento, GETDATE()), DATEDIFF(MONTH, dataNascimento, GETDATE()), DATEDIFF(DAY, dataNascimento, GETDATE()), (SELECT MIN(data) FROM FichaClinica WHERE idPacienteFK = @idPrimeiraConsulta), (SELECT COUNT(*) FROM Agenda WHERE status = 'FINALIZADO' AND idPacienteFK = @idPacienteFinalizado), (SELECT COUNT(*) FROM Agenda WHERE status = 'FALTOU' AND idPacienteFK = @idPacienteFaltou) FROM Paciente WHERE idPaciente = @idPaciente");
            SqlCommand exeHeader = new SqlCommand(Header, banco.connection);

            exeHeader.Parameters.AddWithValue("@idPaciente", FichaClinicaId._retornarID());
            exeHeader.Parameters.AddWithValue("@idPacienteFinalizado", FichaClinicaId._retornarID());
            exeHeader.Parameters.AddWithValue("@idPacienteFaltou", FichaClinicaId._retornarID());
            exeHeader.Parameters.AddWithValue("@idPrimeiraConsulta", FichaClinicaId._retornarID());

            banco.conectar();
            SqlDataReader datareader = exeHeader.ExecuteReader();

            while(datareader.Read())
            {
                labelValuePatientHeader.Text = datareader[0].ToString();
                labelValueIdade.Text = (datareader[1].ToString() + " anos, " + datareader[2].ToString() + " meses, " + datareader[3].ToString() + " dias");
                labelValuePrimeiraConsulta.Text = datareader[4].ToString();
                labelValueAttendanceHeader.Text = datareader[5].ToString();
                labelValueAbsencesHeader.Text = datareader[6].ToString();
            }
            banco.desconectar();
        }

        private void carregarGuia()
        {
            if (tipoGuia == 0)
            {
                //Defini a cor dos botoes
                btnExamesFisicosGuia.ForeColor = SystemColors.Control;
                btnResultadoExamesGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = SystemColors.Control;
                btnAnamneseGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelAnamnese.Visible == false)
                {
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelAnamnese.Visible = true;
                }

                textBoxQueixaPrincipal.Focus();
            }

            if (tipoGuia == 1)
            {
                //Defini a cor dos botoes
                btnAnamneseGuia.ForeColor = SystemColors.Control;             
                btnResultadoExamesGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = SystemColors.Control;
                btnExamesFisicosGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelExamesFisicos.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelExamesFisicos.Visible = true;

                    textBoxExameFisicoGeral.Focus();
                }
            }

            if (tipoGuia == 2)
            {
                //Defini a cor dos botoes
                btnAnamneseGuia.ForeColor = SystemColors.Control;
                btnExamesFisicosGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = SystemColors.Control;
                btnResultadoExamesGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelResultadoExames.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelResultadoExames.Visible = true;

                    textBoxResultadoLaboratoriais.Focus();
                }
            }

            if (tipoGuia == 3)
            {
                //Defini a cor dos botoes
                btnAnamneseGuia.ForeColor = SystemColors.Control;
                btnExamesFisicosGuia.ForeColor = SystemColors.Control;
                btnResultadoExamesGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelHipoteseDiagnostica.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelHipoteseDiagnostica.Visible = true;

                    comboBoxSugestaoDiagnosico.SelectedIndex = 0;
                }
            }

            if (tipoGuia == 4)
            {
                //Defini a cor dos botoes
                btnAnamneseGuia.ForeColor = SystemColors.Control;
                btnExamesFisicosGuia.ForeColor = SystemColors.Control;
                btnResultadoExamesGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelCondutas.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelCondutas.Visible = true;
                }
            }

            if (tipoGuia == 5)
            {
                //Defini a cor dos botoes
                btnAnamneseGuia.ForeColor = SystemColors.Control;
                btnExamesFisicosGuia.ForeColor = SystemColors.Control;
                btnResultadoExamesGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelComentarioMedico.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelComentarioMedico.Visible = true;
                }
            }

            if (tipoGuia == 6)
            {
                labelTituloGuia.Text = "Exames e Procedimentos";

                if (panelTituloGuia.Visible == false)
                {
                    panelGuiaAnamnese.Visible = false;
                    panelTituloGuia.Visible = true;
                }

                //Defini qual Panel irá ficar visivel
                if (panelExamesProcedimentos.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelPrescricao.Visible = false;
                    panelImagemAnexo.Visible = false;
                    panelDocumentosAtestados.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelExamesProcedimentos.Visible = true;
                }
            }

            if(tipoGuia == 7)
            {
                labelTituloGuia.Text = "Documentos e atestados";

                if (panelTituloGuia.Visible == false)
                {
                    panelGuiaAnamnese.Visible = false;
                    panelTituloGuia.Visible = true;
                }

                //Defini qual Panel irá ficar visivel
                if (panelDocumentosAtestados.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelPrescricao.Visible = false;
                    panelImagemAnexo.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelDocumentosAtestados.Visible = true;
                }
            }

            if (tipoGuia == 8)
            {
                labelTituloGuia.Text = "Imagens e anexos";

                if (panelTituloGuia.Visible == false)
                {
                    panelGuiaAnamnese.Visible = false;
                    panelTituloGuia.Visible = true;
                }

                //Defini qual Panel irá ficar visivel
                if (panelImagemAnexo.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelDocumentosAtestados.Visible = false;
                    panelPrescricao.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelImagemAnexo.Visible = true;
                }
            }

            if (tipoGuia == 9)
            {
                labelTituloGuia.Text = "Prescrições";

                if (panelTituloGuia.Visible == false)
                {
                    panelGuiaAnamnese.Visible = false;
                    panelTituloGuia.Visible = true;
                }

                //Defini qual Panel irá ficar visivel
                if (panelPrescricao.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelDocumentosAtestados.Visible = false;
                    panelImagemAnexo.Visible = false;
                    panelProcessoFinalizado.Visible = false;
                    panelPrescricao.Visible = true;
                }
            }

            if (tipoGuia == 10)
            {

                if (panelTituloGuia.Visible == true)
                {
                    panelTituloGuia.Visible = false;
                    panelGuiaAnamnese.Visible = true;
                }

                //Defini a cor dos botoes
                btnAnamneseGuia.ForeColor = SystemColors.Control;
                btnExamesFisicosGuia.ForeColor = SystemColors.Control;
                btnResultadoExamesGuia.ForeColor = SystemColors.Control;
                btnHipoteseDiagnosticaGuia.ForeColor = SystemColors.Control;
                btnCondutasGuia.ForeColor = SystemColors.Control;
                btnComentarioMedicoGuia.ForeColor = SystemColors.Control;
                btnProcessoFinalizadoGuia.ForeColor = Color.DarkOrange;

                //Defini qual Panel irá ficar visivel
                if (panelProcessoFinalizado.Visible == false)
                {
                    panelAnamnese.Visible = false;
                    panelExamesFisicos.Visible = false;
                    panelResultadoExames.Visible = false;
                    panelHipoteseDiagnostica.Visible = false;
                    panelCondutas.Visible = false;
                    panelComentarioMedico.Visible = false;
                    panelExamesProcedimentos.Visible = false;
                    panelDocumentosAtestados.Visible = false;
                    panelImagemAnexo.Visible = false;
                    panelPrescricao.Visible = false;
                    panelProcessoFinalizado.Visible = true;
                }
            }
        }

        private void limparValores()
        {
            //Anamnese
            textBoxQueixaPrincipal.Clear();
            textBoxHistoriaMolestiaAtual.Clear();
            textBoxPele.Clear();
            textBoxCabeca.Clear();
            textBoxOlhos.Clear();
            textBoxNariz.Clear();
            textBoxOuvidos.Clear();
            textBoxGarganta.Clear();
            textBoxSistemaRespiratorio.Clear();
            textBoxSistemaCardiovascular.Clear();
            textBoxSistemaDigestorio.Clear();
            textBoxSistemaGenitoUrinario.Clear();
            textBoxSistemaLinfoHematopoletico.Clear();
            textBoxSistemaEndocrinoMeabolico.Clear();
            textBoxNeuroPsiquico.Clear();
            textBoxSistemaLocomotor.Clear();
            textBoxEstadoGeralSaude.Clear();
            textBoxMedicacoesUso.Clear();
            textBoxHospitalizacoesATC.Clear();
            textBoxDoencasMentais.Clear();
            textBoxAntencedentesReprodutivos.Clear();
            textBoxAlergias.Clear();
            textBoxImunizacoes.Clear();
            checkBoxHAS.Checked = false;
            checkBoxDM.Checked = false;
            checkBoxTrombose.Checked = false;
            checkBoxDislipidemia.Checked = false;
            checkBoxCancer.Checked = false;
            checkBoxAutoImune.Checked = false;
            checkBoxOutrasDoencas.Checked = false;
            textBoxOutrasDrogas.Clear();
            textBoxFatoresRiscoDEE.Clear();
            textBoxHistoriaOcupacional.Clear();
            checkBoxEtilismo.Checked = false;
            checkBoxTabagismo.Checked = false;
            checkBoxOutrasDrogas.Checked = false;
            textBoxOutrasDrogas.Clear();
            radioButtonSedentario.Checked = false;
            radioButtonAtividadeFisicaRegular.Checked = false;
            textBoxQueixasSexual.Clear();

            //Exames fisicos
            textBoxExameFisicoGeral.Clear();
            textBoxExameCabecaPescoco.Clear();
            textBoxExameRespiratorio.Clear();
            textBoxExameCardiovascular.Clear();
            textBoxExameAbdomen.Clear();
            textBoxExameLocomotor.Clear();
            textBoxExameSistemaNervoso.Clear();
            textBoxExameReprodutor.Clear();

            //Resultados Exames
            textBoxResultadoLaboratoriais.Clear();
            textBoxResultadoImagem.Clear();

            //Hipotese Diagnostica
            textBoxHipoteseDiagnostico.Clear();
            textBoxObservacaoHipoteseDiagnostico.Clear();

            //Conduta
            textBoxCondutas.Clear();

            //Comentario Medico
            textBoxComentarioMedico.Clear();

            //Exames Procedimentos
            textBoxExamesProcedimentos.Clear();
            textBoxQuantidadeExamesProcedimento.Text = "1";
            dataGridViewExameProcedimento.Rows.Clear();

            //Documentos Atestados
            textBoxDescricaoAtestado.Clear();

            //Imagem e Anexo
            dataGridViewImagemAnexo.Rows.Clear();

            //Prescricoes
            textBoxMedicamento.Clear();
            textBoxQuantidadeMedicamento.Text = "1";
            textBoxPosologia.Clear();
            dataGridViewPrescricao.Rows.Clear();
        }

        private void insertQuery()
        {
            string Anamnese = ("INSERT INTO Anamnese (idPacienteFK, queixaPrincipal, historiaQueixa, pele, cabeca, olho, nariz, ouvidos, garganta, sistemaRespiratorio, sistemaCardioVascular, sistemaDigestorio, sistemaGenitoUrinario, sistemaLinfoHematopoietico, sistemaEndocrinoMetabolico, neuroPsiquico, sistemaLocomotor, estadoGeralSaude, medicacoesUso, hospitalizacoesAcidentesCirurgia, doencasMentais, antecedentesReprodutivos, alergias, imunizazoes, historiaFamiliar, outrasDoencasFamilia, fatoresRiscoEdemicaEpidemica, historiaOcupacional, habitos, outrasDrogas, estiloVida, vidaSexual, protocoloAtendimento) VALUES (@idPacienteFK, @queixaPrincipal, @historiaQueixa, @pele, @cabeca, @olho, @nariz, @ouvidos, @garganta, @sistemaRespiratorio, @sistemaCardioVascular, @sistemaDigestorio, @sistemaGenitoUrinario, @sistemaLinfoHematopoietico, @sistemaEndocrinoMetabolico, @neuroPsiquico, @sistemaLocomotor, @estadoGeralSaude, @medicacoesUso, @hospitalizacoesAcidentesCirurgia, @doencasMentais, @antecedentesReprodutivos, @alergias, @imunizazoes, @historiaFamiliar, @outrasDoencasFamilia, @fatoresRiscoEdemicaEpidemica, @historiaOcupacional, @habitos, @outrasDrogas, @estiloVida, @vidaSexual, @protocoloAtendimento)");
            string ExameFisico = ("INSERT INTO ExamesFisicos (idPacienteFK, FisicoGeral, CabecaPescoco, aparelhoRespiratotio, aparelhoCardioVascular, abdomen, aparelhoLocomotor, sistemaNervoso, aparelhoReprodutor, protocoloAtendimento) VALUES (@idPacienteFK, @FisicoGeral, @CabecaPescoco, @aparelhoRespiratotio, @aparelhoCardioVascular, @abdomen, @aparelhoLocomotor, @sistemaNervoso, @aparelhoReprodutor, @protocoloAtendimento)");
            string FichaClinica = ("INSERT INTO FichaClinica (data, dia, mes, ano, resultadoExameLabo, resultadoExameImagem, hipoteseDiagnostica, observacaoHipoteseDiagnostica, conduta, idPacienteFK, idProcedimentoFK, idColaboradorFK, status, comentarioMedico, protocoloAtendimento, tempoAtendimento, codigoLog, dataHora) VALUES (@data, @dia, @mes, @ano, @resultadoExameLabo, @resultadoExameImagem, @hipoteseDiagnostica, @observacaoHipoteseDiagnostica, @conduta, @idPacienteFK, @idProcedimentoFK, @idColaboradorFK, @status, @comentarioMedico, @protocoloAtendimento, @tempoAtendimento, @codigoLog, @hora)");
            string Agenda = ("UPDATE Agenda SET status = @status WHERE idAgenda = @ID");
            SqlCommand exeAnamnese = new SqlCommand(Anamnese, banco.connection);
            SqlCommand exeExameFisico = new SqlCommand(ExameFisico, banco.connection);
            SqlCommand exeFichaClinica = new SqlCommand(FichaClinica, banco.connection);
            SqlCommand exeAgenda = new SqlCommand(Agenda, banco.connection);

            #region Anamnese

            //Anamnese
            exeAnamnese.Parameters.AddWithValue("@idPacienteFK", int.Parse(FichaClinicaId._retornarID().ToString()));
            exeAnamnese.Parameters.AddWithValue("@queixaPrincipal", textBoxQueixaPrincipal.Text);
            exeAnamnese.Parameters.AddWithValue("@historiaQueixa", textBoxHistoriaMolestiaAtual.Text);
            exeAnamnese.Parameters.AddWithValue("@pele", textBoxPele.Text);
            exeAnamnese.Parameters.AddWithValue("@cabeca", textBoxCabeca.Text);
            exeAnamnese.Parameters.AddWithValue("@olho", textBoxOlhos.Text);
            exeAnamnese.Parameters.AddWithValue("@nariz", textBoxNariz.Text);
            exeAnamnese.Parameters.AddWithValue("@ouvidos", textBoxOuvidos.Text);
            exeAnamnese.Parameters.AddWithValue("@garganta", textBoxGarganta.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaRespiratorio", textBoxSistemaRespiratorio.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaCardioVascular", textBoxSistemaCardiovascular.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaDigestorio", textBoxSistemaDigestorio.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaGenitoUrinario", textBoxSistemaGenitoUrinario.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaLinfoHematopoietico", textBoxSistemaLinfoHematopoletico.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaEndocrinoMetabolico", textBoxSistemaEndocrinoMeabolico.Text);
            exeAnamnese.Parameters.AddWithValue("@neuroPsiquico", textBoxNeuroPsiquico.Text);
            exeAnamnese.Parameters.AddWithValue("@sistemaLocomotor", textBoxSistemaLocomotor.Text);
            exeAnamnese.Parameters.AddWithValue("@estadoGeralSaude", textBoxEstadoGeralSaude.Text);
            exeAnamnese.Parameters.AddWithValue("@medicacoesUso", textBoxMedicacoesUso.Text);
            exeAnamnese.Parameters.AddWithValue("@hospitalizacoesAcidentesCirurgia", textBoxHospitalizacoesATC.Text);
            exeAnamnese.Parameters.AddWithValue("@doencasMentais", textBoxDoencasMentais.Text);
            exeAnamnese.Parameters.AddWithValue("@antecedentesReprodutivos", textBoxAntencedentesReprodutivos.Text);
            exeAnamnese.Parameters.AddWithValue("@alergias", textBoxAlergias.Text);
            exeAnamnese.Parameters.AddWithValue("@imunizazoes", textBoxImunizacoes.Text);
            exeAnamnese.Parameters.AddWithValue("@historiaFamiliar", historiaFamiliar);
            exeAnamnese.Parameters.AddWithValue("@outrasDoencasFamilia", textBoxAutoImune.Text);
            exeAnamnese.Parameters.AddWithValue("@fatoresRiscoEdemicaEpidemica", textBoxFatoresRiscoDEE.Text);
            exeAnamnese.Parameters.AddWithValue("@historiaOcupacional", textBoxHistoriaOcupacional.Text);
            exeAnamnese.Parameters.AddWithValue("@habitos", habitos);
            exeAnamnese.Parameters.AddWithValue("@outrasDrogas", textBoxOutrasDrogas.Text);
            exeAnamnese.Parameters.AddWithValue("@estiloVida", estiloVida);
            exeAnamnese.Parameters.AddWithValue("@vidaSexual", textBoxQueixasSexual.Text);
            exeAnamnese.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());

            if (liberadoAnamnese == true)
            {
                banco.conectar();
                exeAnamnese.ExecuteNonQuery();
                banco.desconectar();
                //end
            }

            #endregion

            #region Exame Fisico

            exeExameFisico.Parameters.AddWithValue("@idPacienteFK", FichaClinicaId._retornarID());
            exeExameFisico.Parameters.AddWithValue("@FisicoGeral", textBoxExameFisicoGeral.Text);
            exeExameFisico.Parameters.AddWithValue("@CabecaPescoco", textBoxExameCabecaPescoco.Text);
            exeExameFisico.Parameters.AddWithValue("@aparelhoRespiratotio", textBoxExameRespiratorio.Text);
            exeExameFisico.Parameters.AddWithValue("@aparelhoCardioVascular", textBoxExameCardiovascular.Text);
            exeExameFisico.Parameters.AddWithValue("@abdomen", textBoxExameAbdomen.Text);
            exeExameFisico.Parameters.AddWithValue("@aparelhoLocomotor", textBoxExameLocomotor.Text);
            exeExameFisico.Parameters.AddWithValue("@sistemaNervoso", textBoxExameSistemaNervoso.Text);
            exeExameFisico.Parameters.AddWithValue("@aparelhoReprodutor", textBoxExameReprodutor.Text);
            exeExameFisico.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());

            if (liberadoExameFisico == true)
            {
                banco.conectar();
                exeExameFisico.ExecuteNonQuery();
                banco.desconectar();
            }

            #endregion

            #region Ficha Clinica

            verificarMes();

            exeFichaClinica.Parameters.AddWithValue("@data", DateTime.Parse(DateTime.Now.ToShortDateString()));
            exeFichaClinica.Parameters.AddWithValue("@dia", DateTime.Now.Day);
            exeFichaClinica.Parameters.AddWithValue("@mes", mes);
            exeFichaClinica.Parameters.AddWithValue("@ano", DateTime.Now.Year);
            exeFichaClinica.Parameters.AddWithValue("@resultadoExameLabo", textBoxResultadoLaboratoriais.Text);
            exeFichaClinica.Parameters.AddWithValue("@resultadoExameImagem", textBoxResultadoImagem.Text);
            exeFichaClinica.Parameters.AddWithValue("@hipoteseDiagnostica", textBoxHipoteseDiagnostico.Text);
            exeFichaClinica.Parameters.AddWithValue("@observacaoHipoteseDiagnostica", textBoxObservacaoHipoteseDiagnostico.Text);
            exeFichaClinica.Parameters.AddWithValue("@conduta", textBoxCondutas.Text);
            exeFichaClinica.Parameters.AddWithValue("@comentarioMedico", textBoxComentarioMedico.Text);
            exeFichaClinica.Parameters.AddWithValue("@idPacienteFK", FichaClinicaId._retornarID());
            exeFichaClinica.Parameters.AddWithValue("@idProcedimentoFK", FichaClinicaId._retornarIdProcedimento());
            exeFichaClinica.Parameters.AddWithValue("@idColaboradorFK", FichaClinicaId._retornarIdColaborador());
            exeFichaClinica.Parameters.AddWithValue("@status", "CONCLUIDO");
            exeFichaClinica.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());
            exeFichaClinica.Parameters.AddWithValue("@tempoAtendimento", labelValueTempo.Text);
            exeFichaClinica.Parameters.AddWithValue("@codigoLog", Log._retornarLog());
            exeFichaClinica.Parameters.AddWithValue("@hora", DateTime.Now.ToLongTimeString());

            if (liberadoFichaClinica == true)
            {
                banco.conectar();
                exeFichaClinica.ExecuteNonQuery();
                banco.desconectar();
            }

            #endregion

            #region Agenda

            exeAgenda.Parameters.AddWithValue("@status", "FINALIZADO");
            exeAgenda.Parameters.AddWithValue("@ID", FichaClinicaId._retornarIdAgenda());

            banco.conectar();
            exeAgenda.ExecuteNonQuery();
            banco.desconectar();

            #endregion
        }

        #region Header - objects

        private void btnExamesProcedimentos_Click(object sender, EventArgs e)
        {
            tipoGuia = 6;
            //
            carregarGuia();
            AutoCompleteExamesProcedimentos();
        }

        private void btnDocumentoAtestado_Click(object sender, EventArgs e)
        {
            tipoGuia = 7;
            //
            carregarGuia();
        }

        private void btnImagemAnexo_Click(object sender, EventArgs e)
        {
            tipoGuia = 8;
            //
            carregarGuia();
        }

        private void btnEncaminharPrescricao_Click(object sender, EventArgs e)
        {
            tipoGuia = 9;
            //
            carregarGuia();

            comboBoxSugestaoPrescricao.SelectedIndex = 0;
        }

        private void btnFinalizarAtendimento_Click(object sender, EventArgs e)
        {
            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (MessageBox.Show("Tem certeza que deseja Finalizar o atendimeno?" + "\n" + "\n" + " Certifique-se de que verificar se está tudo correto antes de finaliza." + "\n" + "\n" + "Uma vez finalizado não será possivel reenicia-lo novamente.", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                gerarLog();

                cronometro.Stop();
                //
                verificarTodosOsCampos();
                //
                insertQuery();
                //
                limparValores();
                //

                this.Close();
            }
        }

        #endregion

        #region Guia - objects

        private void btnAnamneseGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 0;
            //
            carregarGuia();

            //
            labelValueQueixaPrincipal.Text += ("  " + textBoxQueixaPrincipal.Text);
            labelValueHistoriaMolestia.Text += ("  " + textBoxHistoriaMolestiaAtual.Text);
            labelValuePele.Text += ("  " + textBoxPele.Text);
            labelValueCabeca.Text += ("  " + textBoxCabeca.Text);
            labelValueOlhos.Text += ("  " + textBoxOlhos.Text);
            labelValueNariz.Text += ("  " + textBoxNariz.Text);
            labelValueOuvidos.Text += ("  " + textBoxOuvidos.Text);
            labelValueGarganta.Text += ("  " + textBoxGarganta.Text);
            labelValueSistemaRespiratorio.Text += ("  " + textBoxSistemaRespiratorio.Text);
            labelValueSistemaCardiovascular.Text += ("  " + textBoxSistemaCardiovascular.Text);
            labelValueSistemaDigestorio.Text += ("  " + textBoxSistemaDigestorio.Text);
            labelValueSistemaGenitoUrinario.Text += ("  " + textBoxSistemaGenitoUrinario.Text);
            labelValueSistemaLinfoHematopoletico.Text += ("  " + textBoxSistemaLinfoHematopoletico.Text);
            labelValueSistemaEndocrinoMetabolico.Text += ("  " + textBoxSistemaEndocrinoMeabolico.Text);
            labelValueNeuroPsiquico.Text += ("  " + textBoxNeuroPsiquico.Text);
            labelValueSistemaLocomotor.Text += ("  " + textBoxSistemaLocomotor.Text);
            labelValueEstadoGeralSaude.Text += ("  " + textBoxEstadoGeralSaude.Text);
            labelValueMedicacoesUso.Text += ("  " + textBoxMedicacoesUso.Text);
            labelValueHospitalizacoesATC.Text += ("  " + textBoxHospitalizacoesATC.Text);
            labelValueDoencasMentais.Text += ("  " + textBoxDoencasMentais.Text);
            labelValueAntecedentesReprodutivos.Text += ("  " + textBoxAntencedentesReprodutivos.Text);
            labelValueAlergias.Text += ("  " + textBoxAlergias.Text);
            labelValueImunizacoes.Text += ("  " + textBoxImunizacoes.Text);
            labelValueHistoricoFamiliar.Text += ("  " + historiaFamiliar);
            labelValueFatoresRisco.Text += ("  " + textBoxFatoresRiscoDEE.Text);
            labelValueHistoriaOcupacional.Text += ("  " + textBoxHistoriaOcupacional.Text);
            labelValueHabitos.Text += ("  " + habitos);
            labelValueEstiloVida.Text += ("  " + estiloVida);
            labelValueQueixaSexual.Text += ("  " + textBoxQueixasSexual.Text);
        }

        private void btnExamesFisicosGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 1;
            //
            carregarGuia();

            //
            labelValueExameFisicoGeral.Text += ("  " + textBoxExameFisicoGeral.Text);
            labelValueExameCabecaPescoco.Text += ("  " + textBoxExameCabecaPescoco.Text);
            labelValueExameAparelhoRespiratorio.Text += ("  " + textBoxExameRespiratorio.Text);
            labelValueExameAparelhoCardiovascular.Text += ("  " + textBoxExameCardiovascular.Text);
            labelValueExameAbdomen.Text += ("  " + textBoxExameAbdomen.Text);
            labelValueExameAparelhoLocomotor.Text += ("  " + textBoxExameLocomotor.Text);
            labelValueExameSistemaNervoso.Text += ("  " + textBoxExameSistemaNervoso.Text);
            labelValueExameAparelhoReprodutor.Text += ("  " + textBoxExameReprodutor.Text);
        }

        private void btnResultadoExamesGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 2;
            //
            carregarGuia();

            //
            labelValueResultadoLaboratorial.Text += ("  " + textBoxResultadoLaboratoriais.Text);
            labelValueResultadoImagem.Text += ("  " + textBoxResultadoImagem.Text);
        }

        private void btnHipoteseDiagnosticaGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 3;
            //
            carregarGuia();

            //
            labelValueDiagnostico.Text += ("  " + textBoxHipoteseDiagnostico.Text);
            labelValueObservacaoHipotese.Text += ("  " + textBoxObservacaoHipoteseDiagnostico.Text);
        }

        private void btnCondutasGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 4;
            //
            carregarGuia();

            //
            labelValueDescricaoConduta.Text += ("  " + textBoxCondutas.Text);
        }

        private void btnComentarioMedicoGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 5;
            //
            carregarGuia();

            //
            labelValueComentarioMedico.Text += ("  " + textBoxComentarioMedico.Text);
        }

        private void btnProcessoFinalizadoGuia_Click(object sender, EventArgs e)
        {
            tipoGuia = 10;
            //
            carregarGuia();

            carregarProcessoFinalizado();
        }


        #endregion

        #region Anamnese - objects

        private void btnProximoAnamnese_Click(object sender, EventArgs e)
        {
            tipoGuia = 1;
            //
            carregarGuia();
            carregarDadosCheckBoxAnamnese();
            textBoxExameFisicoGeral.Focus();

            //
            labelValueQueixaPrincipal.Text = textBoxQueixaPrincipal.Text;
            labelValueHistoriaMolestia.Text = textBoxHistoriaMolestiaAtual.Text;
            labelValuePele.Text = textBoxPele.Text;
            labelValueCabeca.Text = textBoxCabeca.Text;
            labelValueOlhos.Text = textBoxOlhos.Text;
            labelValueNariz.Text = textBoxNariz.Text;
            labelValueOuvidos.Text = textBoxOuvidos.Text;
            labelValueGarganta.Text = textBoxGarganta.Text;
            labelValueSistemaRespiratorio.Text = textBoxSistemaRespiratorio.Text;
            labelValueSistemaCardiovascular.Text = textBoxSistemaCardiovascular.Text;
            labelValueSistemaDigestorio.Text = textBoxSistemaDigestorio.Text;
            labelValueSistemaGenitoUrinario.Text = textBoxSistemaGenitoUrinario.Text;
            labelValueSistemaLinfoHematopoletico.Text = textBoxSistemaLinfoHematopoletico.Text;
            labelValueSistemaEndocrinoMetabolico.Text = textBoxSistemaEndocrinoMeabolico.Text;
            labelValueNeuroPsiquico.Text = textBoxNeuroPsiquico.Text;
            labelValueSistemaLocomotor.Text = textBoxSistemaLocomotor.Text;
            labelValueEstadoGeralSaude.Text = textBoxEstadoGeralSaude.Text;
            labelValueMedicacoesUso.Text = textBoxMedicacoesUso.Text;
            labelValueHospitalizacoesATC.Text = textBoxHospitalizacoesATC.Text;
            labelValueDoencasMentais.Text = textBoxDoencasMentais.Text;
            labelValueAntecedentesReprodutivos.Text = textBoxAntencedentesReprodutivos.Text;
            labelValueAlergias.Text = textBoxAlergias.Text;
            labelValueImunizacoes.Text = textBoxImunizacoes.Text;
            labelValueHistoricoFamiliar.Text = historiaFamiliar;
            labelValueFatoresRisco.Text = textBoxFatoresRiscoDEE.Text;
            labelValueHistoriaOcupacional.Text = textBoxHistoriaOcupacional.Text;
            labelValueHabitos.Text = habitos;
            labelValueEstiloVida.Text = estiloVida;
            labelValueQueixaSexual.Text = textBoxQueixasSexual.Text;
        }

        private void checkBoxAutoImune_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoImune.Checked == true)
            {
                panelOutrasDoencas.Visible = false;
                panelAutoImune.Visible = true;

                textBoxOutrasDoencasFamilia.Enabled = false;
                textBoxAutoImune.Enabled = true;

                textBoxOutrasDrogas.Clear();
                textBoxAutoImune.Clear();
            }
            else
            {
                panelAutoImune.Visible = false;
                panelOutrasDoencas.Visible = true;

                textBoxAutoImune.Enabled = false;
                textBoxOutrasDoencasFamilia.Enabled = false;

                textBoxOutrasDrogas.Clear();
                textBoxAutoImune.Clear();
            }
        }

        private void checkBoxOutrasDoencas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOutrasDoencas.Checked == true)
            {
                panelAutoImune.Visible = false;
                panelOutrasDoencas.Visible = true;

                textBoxAutoImune.Enabled = false;
                textBoxOutrasDoencasFamilia.Enabled = true;

                textBoxOutrasDrogas.Clear();
                textBoxAutoImune.Clear();
            }
            else
            {
                panelAutoImune.Visible = false;
                panelOutrasDoencas.Visible = true;

                textBoxOutrasDoencasFamilia.Enabled = false;
                textBoxAutoImune.Enabled = false;

                textBoxOutrasDrogas.Clear();
                textBoxAutoImune.Clear();
            }
        }

        private void checkBoxOutrasDrogas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOutrasDrogas.Checked == true)
            {
                textBoxOutrasDrogas.Enabled = true;

                textBoxOutrasDrogas.Clear();
            }
            else
            {
                textBoxOutrasDrogas.Enabled = false;

                textBoxOutrasDrogas.Clear();
            }
        }

        #endregion

        #region Exame Fisico - objects

        private void btnProximoExameFisico_Click(object sender, EventArgs e)
        {
            tipoGuia = 2;
            //
            carregarGuia();
            textBoxResultadoLaboratoriais.Focus();

            //
            labelValueExameFisicoGeral.Text = textBoxExameFisicoGeral.Text;
            labelValueExameCabecaPescoco.Text = textBoxExameCabecaPescoco.Text;
            labelValueExameAparelhoRespiratorio.Text = textBoxExameRespiratorio.Text;
            labelValueExameAparelhoCardiovascular.Text = textBoxExameCardiovascular.Text;
            labelValueExameAbdomen.Text = textBoxExameAbdomen.Text;
            labelValueExameAparelhoLocomotor.Text = textBoxExameLocomotor.Text;
            labelValueExameSistemaNervoso.Text = textBoxExameSistemaNervoso.Text;
            labelValueExameAparelhoReprodutor.Text = textBoxExameReprodutor.Text;
        }

        private void btnVoltarExameFisico_Click(object sender, EventArgs e)
        {
            tipoGuia = 0;
            //
            carregarGuia();
        }

        #endregion

        #region Resultado Exames - objects

        private void btnProximoResultado_Click(object sender, EventArgs e)
        {
            tipoGuia = 3;
            //
            carregarGuia();
            textBoxHipoteseDiagnostico.Focus();

            //
            labelValueResultadoLaboratorial.Text = textBoxResultadoLaboratoriais.Text;
            labelValueResultadoImagem.Text = textBoxResultadoImagem.Text;
        }

        private void btnVoltarResultados_Click(object sender, EventArgs e)
        {
            tipoGuia = 1;
            //
            carregarGuia();
        }

        #endregion

        #region Hipotese Diagnostica - objects

        private void btnProximoHipotese_Click(object sender, EventArgs e)
        {
            tipoGuia = 4;
            //
            carregarGuia();
            textBoxCondutas.Focus();

            //
            labelValueDiagnostico.Text = textBoxHipoteseDiagnostico.Text;
            labelValueObservacaoHipotese.Text = textBoxObservacaoHipoteseDiagnostico.Text;
        }

        private void btnVoltarHipotese_Click(object sender, EventArgs e)
        {
            tipoGuia = 2;
            //
            carregarGuia();
        }

        private void comboBoxSugestaoDiagnosico_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCompleteHipoteseDiagnostico();
            textBoxHipoteseDiagnostico.Focus();

            textBoxHipoteseDiagnostico.Clear();
            textBoxObservacaoHipoteseDiagnostico.Clear();
        }

        private void textBoxHipoteseDiagnostico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string requestDiagnostico = ("SELECT hipoteseDiagnostica, observacaoHipoteseDiagnostica FROM FichaClinica WHERE hipoteseDiagnostica = @nome ");
                SqlCommand exeRequest = new SqlCommand(requestDiagnostico, banco.connection);

                exeRequest.Parameters.AddWithValue("@nome", textBoxHipoteseDiagnostico.Text);

                textBoxHipoteseDiagnostico.Clear();
                textBoxObservacaoHipoteseDiagnostico.Clear();

                banco.conectar();

                SqlDataReader datareader = exeRequest.ExecuteReader();

                while (datareader.Read())
                {
                    textBoxHipoteseDiagnostico.Text = datareader[0].ToString();
                    textBoxObservacaoHipoteseDiagnostico.Text = datareader[1].ToString();
                }

                banco.desconectar();
            }
        }

        #endregion

        #region Conduta - objects

        private void btnProximoConduta_Click(object sender, EventArgs e)
        {
            tipoGuia = 5;
            //
            carregarGuia();
            textBoxComentarioMedico.Focus();

            //
            labelValueDescricaoConduta.Text = textBoxCondutas.Text;
        }

        private void btnVoltaConduta_Click(object sender, EventArgs e)
        {
            tipoGuia = 3;
            //
            carregarGuia();
        }

        #endregion

        #region Comentario Medico - objects

        private void btnProximoComentarioMedico_Click(object sender, EventArgs e)
        {
            tipoGuia = 10;
            //
            carregarGuia();

            btnProcessoFinalizadoGuia.ForeColor = Color.FromArgb(1, 147, 59);

            //
            labelValueComentarioMedico.Text = textBoxComentarioMedico.Text;
        }

        private void btnVoltarComentarioMedico_Click(object sender, EventArgs e)
        {
            tipoGuia = 4;
            //
            carregarGuia();
        }

        #endregion

        #region Exames Procedimentos - objects

        private void btnSalvarExameProcedimento_Click(object sender, EventArgs e)
        {
            if (dataGridViewExameProcedimento.Rows.Count != 0)
            {
                string ExamesProcedimentos = ("INSERT INTO SolicitacaoExame (idPacienteFK, idColaboradorFK, protocoloAtendimento, data, idProcedimentoFK, quantidade) VALUES (@idPacienteFK, @idColaboradorFK, @protocoloAtendimento, @data, @idProcedimentoFK, @quantidade)");
                SqlCommand exeExamesProcedimento = new SqlCommand(ExamesProcedimentos, banco.connection);


                for (int i = 0; i < dataGridViewExameProcedimento.Rows.Count - 0; i++)
                {
                    exeExamesProcedimento.Parameters.Clear();
                    exeExamesProcedimento.Parameters.AddWithValue("@idPacienteFK", FichaClinicaId._retornarID());
                    exeExamesProcedimento.Parameters.AddWithValue("@idColaboradorFK", FichaClinicaId._retornarIdColaborador());
                    exeExamesProcedimento.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());
                    exeExamesProcedimento.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePesquisaData.Value).ToShortDateString()));
                    exeExamesProcedimento.Parameters.AddWithValue("@idProcedimentoFK", int.Parse(dataGridViewExameProcedimento.Rows[i].Cells[5].Value.ToString()));
                    exeExamesProcedimento.Parameters.AddWithValue("@quantidade", dataGridViewExameProcedimento.Rows[i].Cells[3].Value.ToString());

                    banco.conectar();
                    exeExamesProcedimento.ExecuteNonQuery();
                    banco.desconectar();
                }

                MessageBox.Show("Salvo com sucesso!");

                dataGridViewExameProcedimento.Rows.Clear();
            }
        }

        private void btnSairExameProcedimento_Click(object sender, EventArgs e)
        {
            tipoGuia = 10;
            //
            carregarGuia();
        }

        private void textBoxExamesProcedimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxQuantidadeExamesProcedimento.Focus();
            }
        }

        private void linkLabelCadNovoProcedimento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro.frmProcedimento windows = new Cadastro.frmProcedimento();
            windows.ShowDialog();
            windows.Dispose();

            if (Verificadores._abertoFechado() == 2)
            {
                AutoCompleteExamesProcedimentos();
                textBoxExamesProcedimentos.Focus();
            }
        }

        private void btnAdicionatExameProcedimento_Click(object sender, EventArgs e)
        {
            if (textBoxExamesProcedimentos.Text != "" && textBoxQuantidadeExamesProcedimento.Text != "")
            {
                string requestProcedimento = ("SELECT idProcedimento, procedimento, tipoProcedimento, nomeGenerico FROM Procedimento WHERE nomeGenerico = @nome ");
                SqlCommand exeRequest = new SqlCommand(requestProcedimento, banco.connection);

                exeRequest.Parameters.AddWithValue("@nome", textBoxExamesProcedimentos.Text);

                banco.conectar();

                SqlDataReader datareader = exeRequest.ExecuteReader();

                while (datareader.Read())
                {
                    if (datareader.HasRows)
                    {
                        dataGridViewExameProcedimento.Rows.Add(dataGridViewExameProcedimento.Rows.Count + 1,datareader[1].ToString(), datareader[2].ToString(), textBoxQuantidadeExamesProcedimento.Text, FichaClinicaId._retornarID(), FichaClinicaId._retornarIdColaborador(), datareader[0].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado nenhum Exame ou Procedimento com essa descricão." + "\n"  + "\n" + "Verifique se o mesmo encontra-se cadastrado e tente novamanete!");
                    }
                }
                banco.desconectar();

                textBoxExamesProcedimentos.Clear();
                //
                textBoxExamesProcedimentos.Focus();
            }
            
        }

        private void dataGridViewExameProcedimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dataGridViewExameProcedimento.Rows.RemoveAt(dataGridViewExameProcedimento.CurrentRow.Index);
            }
        }

        private void btnImprimirExameProcedimento_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarPDFexameProcedimento_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Documentos e Atestados - objects

        private void comboBoxModeloAtestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelCadNovoModelo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnImprimirAtestado_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarPDFatestado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAtestado_Click(object sender, EventArgs e)
        {
            string Atestados = ("INSERT INTO Atestados (idPaciente, idColaborador, descricao, protocoloAtendimento, data, modeloAtestado) VALUES (@idPaciente, @idColaborador, @descricao, @protocoloAtendimento, @data, @modeloAtestado)");
            SqlCommand exeAtestados = new SqlCommand(Atestados, banco.connection);

            exeAtestados.Parameters.AddWithValue("@idPaciente", FichaClinicaId._retornarID());
            exeAtestados.Parameters.AddWithValue("@idColaborador", FichaClinicaId._retornarIdColaborador());
            exeAtestados.Parameters.AddWithValue("@descricao", textBoxDescricaoAtestado.Text);
            exeAtestados.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());
            exeAtestados.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(dateTimeAtestado.Value).ToShortDateString()));
            exeAtestados.Parameters.AddWithValue("@modeloAtestado", comboBoxModeloAtestado.Text);

            if (comboBoxModeloAtestado.Text != "" && textBoxDescricaoAtestado.Text != "")
            {
                banco.conectar();
                exeAtestados.ExecuteNonQuery();
                banco.desconectar();

                MessageBox.Show("Salvo com sucesso!");

                //Documentos Atestados
                textBoxDescricaoAtestado.Clear();
            }
        }

        private void btnSairAtestado_Click(object sender, EventArgs e)
        {
            tipoGuia = 10;
            //
            carregarGuia();
        }

        #endregion

        #region Imagem e Anexo

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            var arquivo = importarArquivo();
            //
            carregarArquivo(arquivo);
        }

        private void backgroundWorkerDeterminada_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;
            int contGrid = dataGridViewImagemAnexo.Rows.Count;
            int contResult = 100 / contGrid;

            string ImagemAnexo = ("INSERT INTO Arquivos (nomeArquivo, extesao, length, fileStream, data, idPacienteFK, protocoloAtendimento) VALUES (@nomeArquivo, @extesao, @length, @fileStream, @data, @idPacienteFK, @protocoloAtendimento)");
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
                    exeImagemAnexo.Parameters.AddWithValue("@nomeArquivo", fileSelect.nomeArquivo);
                    exeImagemAnexo.Parameters.AddWithValue("@extesao", fileSelect.extensao);
                    exeImagemAnexo.Parameters.AddWithValue("@length", fileSelect.length);
                    exeImagemAnexo.Parameters.AddWithValue("@fileStream", fileSelect.FileStream);
                    exeImagemAnexo.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(dateImagemAnexo.Value).ToShortDateString()));
                    exeImagemAnexo.Parameters.AddWithValue("@idPacienteFK", FichaClinicaId._retornarID());
                    exeImagemAnexo.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());

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

        private void backgroundWorkerDeterminada_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            progressBarImagemAnexo.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            labelPorcentagem.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorkerDeterminada_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        private void btnSalvarImagemAnexo_Click(object sender, EventArgs e)
        {
            if (dataGridViewImagemAnexo.Rows.Count != 0)
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
            }
        }

        private void btnSairImagemAnexo_Click(object sender, EventArgs e)
        {
            tipoGuia = 10;
            //
            carregarGuia();
        }

        private void dataGridViewImagemAnexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGridViewImagemAnexo.Rows.RemoveAt(dataGridViewImagemAnexo.CurrentRow.Index);
            }
        }

        #endregion

        #region Prescricao - objects

        private void comboBoxSugestaoPrescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCompletePrescricao();
            textBoxMedicamento.Focus();

            textBoxMedicamento.Clear();
            textBoxPosologia.Clear();
        }

        private void textBoxMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string requestDiagnostico = ("SELECT medicamento FROM Prescricoes WHERE medicamento = @nome ");
                SqlCommand exeRequest = new SqlCommand(requestDiagnostico, banco.connection);

                exeRequest.Parameters.AddWithValue("@nome", textBoxMedicamento.Text);

                textBoxMedicamento.Clear();
                textBoxPosologia.Clear();

                banco.conectar();

                SqlDataReader datareader = exeRequest.ExecuteReader();

                while (datareader.Read())
                {
                    textBoxMedicamento.Text = datareader[0].ToString();

                    textBoxQuantidadeMedicamento.Focus();
                }

                banco.desconectar();
            }
        }

        private void btnAdcionarMedicamento_Click(object sender, EventArgs e)
        {
            dataGridViewPrescricao.Rows.Add(dataGridViewPrescricao.Rows.Count + 1, textBoxMedicamento.Text, textBoxQuantidadeMedicamento.Text,  textBoxPosologia.Text);
            //
            textBoxMedicamento.Clear();
            textBoxPosologia.Clear();
            //
            textBoxMedicamento.Focus();
        }

        private void dataGridViewPrescricao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dataGridViewPrescricao.Rows.RemoveAt(dataGridViewPrescricao.CurrentRow.Index);
            }
        }

        private void btnImprimirMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarPDFmedicamento_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarMedicamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrescricao.Rows.Count != 0)
            {
                string Prescricao = ("INSERT INTO Prescricoes (idPacienteFK, idColaboradorFK, medicamento, posologia, protocoloAtendimento, data, quantidadeMedicamento) VALUES (@idPacienteFK, @idColaboradorFK, @medicamento, @posologia, @protocoloAtendimento, @data, @quantidadeMedicamento)");
                SqlCommand exePrescricao = new SqlCommand(Prescricao, banco.connection);

                for (int i = 0; i < dataGridViewPrescricao.Rows.Count - 0; i++)
                {
                    exePrescricao.Parameters.Clear();
                    exePrescricao.Parameters.AddWithValue("@idPacienteFK", FichaClinicaId._retornarID());
                    exePrescricao.Parameters.AddWithValue("@idColaboradorFK", FichaClinicaId._retornarIdColaborador());
                    exePrescricao.Parameters.AddWithValue("@medicamento", dataGridViewPrescricao.Rows[i].Cells[1].Value);
                    exePrescricao.Parameters.AddWithValue("@posologia", dataGridViewPrescricao.Rows[i].Cells[3].Value);
                    exePrescricao.Parameters.AddWithValue("@protocoloAtendimento", FichaClinicaId._retornarProtocolo());
                    exePrescricao.Parameters.AddWithValue("@data", DateTime.Parse(Convert.ToDateTime(datePrescricao.Text).ToShortDateString()));
                    exePrescricao.Parameters.AddWithValue("@quantidadeMedicamento", dataGridViewPrescricao.Rows[i].Cells[2].Value);

                    banco.conectar();
                    exePrescricao.ExecuteNonQuery();
                    banco.desconectar();
                }

                MessageBox.Show("Salvo com sucesso!");

                dataGridViewPrescricao.Rows.Clear();
            }
        }

        private void btnSairMedicamento_Click(object sender, EventArgs e)
        {
            tipoGuia = 10;
            //
            carregarGuia();
        }

        #endregion

        #region Paneis - Bordas o evento Paint

        private void frmIniciarAtendimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Verificadores.abertoFechado(2);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            panelHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelHeader.Width,
            panelHeader.Height, 7, 7));
        }

        private void panelGuiaAnamnese_Paint(object sender, PaintEventArgs e)
        {
            panelGuiaAnamnese.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelGuiaAnamnese.Width,
            panelGuiaAnamnese.Height, 7, 7));
        }

        private void panelTituloGuia_Paint(object sender, PaintEventArgs e)
        {
            panelTituloGuia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTituloGuia.Width,
            panelTituloGuia.Height, 7, 7));
        }

        private void panelAnamnese_Paint(object sender, PaintEventArgs e)
        {
            panelAnamnese.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAnamnese.Width,
            panelAnamnese.Height, 7, 7));
        }

        private void panelExamesFisicos_Paint(object sender, PaintEventArgs e)
        {
            panelExamesFisicos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelExamesFisicos.Width,
            panelExamesFisicos.Height, 7, 7));
        }

        private void panelResultadoExames_Paint(object sender, PaintEventArgs e)
        {
            panelResultadoExames.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelResultadoExames.Width,
            panelResultadoExames.Height, 7, 7));
        }

        private void panelHipoteseDiagnostica_Paint(object sender, PaintEventArgs e)
        {
            panelHipoteseDiagnostica.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelHipoteseDiagnostica.Width,
            panelHipoteseDiagnostica.Height, 7, 7));
        }

        private void panelCondutas_Paint(object sender, PaintEventArgs e)
        {
            panelCondutas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCondutas.Width,
            panelCondutas.Height, 7, 7));
        }

        private void panelComentarioMedico_Paint(object sender, PaintEventArgs e)
        {
            panelComentarioMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelComentarioMedico.Width,
            panelComentarioMedico.Height, 7, 7));
        }

        private void panelExamesProcedimentos_Paint(object sender, PaintEventArgs e)
        {
            panelExamesProcedimentos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelExamesProcedimentos.Width,
            panelExamesProcedimentos.Height, 7, 7));
        }

        private void panelDocumentosAtestados_Paint(object sender, PaintEventArgs e)
        {
            panelDocumentosAtestados.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDocumentosAtestados.Width,
            panelDocumentosAtestados.Height, 7, 7));
        }

        private void panelImagemAnexo_Paint(object sender, PaintEventArgs e)
        {
            panelImagemAnexo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelImagemAnexo.Width,
            panelImagemAnexo.Height, 7, 7));
        }

        private void panelPrescricao_Paint(object sender, PaintEventArgs e)
        {
            panelPrescricao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPrescricao.Width,
            panelPrescricao.Height, 7, 7));
        }

        private void panelProcessoFinalizado_Paint(object sender, PaintEventArgs e)
        {
            panelProcessoFinalizado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelProcessoFinalizado.Width,
            panelProcessoFinalizado.Height, 7, 7));
        }

        #endregion
    }
}
