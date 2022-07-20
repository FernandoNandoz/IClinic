using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;

namespace IClinic.Forms
{
    public partial class frmFichaClinica : Form
    {
        Banco banco = new Banco();

        int contagem = 0;
        bool liberado = false;

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

        public frmFichaClinica()
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
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //

        private void preencherHeader()
        {
            if (contagem == 0)
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string fichaClinica = ("SELECT nomePaciente, DATEDIFF(YEAR, dataNascimento, GETDATE()), DATEDIFF(MONTH, dataNascimento, GETDATE()), DATEDIFF(DAY, dataNascimento, GETDATE()), (SELECT MIN(data) FROM FichaClinica WHERE idPacienteFK = @idPrimeiraConsulta) FROM Paciente WHERE idPaciente = @ID");
                SqlCommand exeVerificacao = new SqlCommand(fichaClinica, banco.connection);

                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
                exeVerificacao.Parameters.AddWithValue("@idPrimeiraConsulta", FichaClinicaId._retornarID());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    labelNamePatientHeader.Text = datareader[0].ToString();
                    labelValueIdade.Text = (datareader[1].ToString() + " anos, " + datareader[2].ToString() + " meses, " + datareader[3].ToString() + " dias");
                    labelValuePrimeiraConsulta.Text = DateTime.Parse(datareader[4].ToString()).ToShortDateString();//
                }
                banco.desconectar();
            }
            else
            {
                string fichaClinica = ("SELECT Paciente.nomePaciente, DATEDIFF(YEAR, dataNascimento, GETDATE()), DATEDIFF(MONTH, dataNascimento, GETDATE()), DATEDIFF(DAY, dataNascimento, GETDATE()), (SELECT MIN(data) FROM FichaClinica WHERE idPacienteFK = @idPrimeiraConsulta), (SELECT COUNT(*) FROM FichaClinica WHERE FichaClinica.status = 'CONCLUIDO'), (SELECT COUNT(*) FROM FichaClinica WHERE FichaClinica.status = 'FALTOU') FROM FichaClinica INNER JOIN Paciente ON FichaClinica.idPacienteFK = Paciente.idPaciente WHERE idPacienteFK = @ID");
                SqlCommand exeVerificacao = new SqlCommand(fichaClinica, banco.connection);

                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());
                exeVerificacao.Parameters.AddWithValue("@idPrimeiraConsulta", FichaClinicaId._retornarID());

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    labelNamePatientHeader.Text = datareader[0].ToString();
                    labelValueIdade.Text = (datareader[1].ToString() + " anos, " + datareader[2].ToString() + " meses, " + datareader[3].ToString() + " dias");
                    labelValuePrimeiraConsulta.Text = DateTime.Parse(datareader[4].ToString()).ToShortDateString();
                    labelAttendancePatientHeader.Text = Convert.ToString(contagem);
                    labelConcludedPatientHeader.Text = datareader[5].ToString();
                    labelAbsencesPatientHeader.Text = datareader[6].ToString();
                }
                banco.desconectar();
            }   
        }

        private void verificarQuantidade()
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string fichaClinica = ("SELECT COUNT(*) FROM FichaClinica INNER JOIN Colaborador ON FichaClinica.idColaboradorFK = Colaborador.idColaborador WHERE FichaClinica.idPacienteFK = @ID");
            SqlCommand exeVerificacao = new SqlCommand(fichaClinica, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@ID", FichaClinicaId._retornarID());

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            while (datareader.Read())
            {
                contagem = int.Parse(datareader[0].ToString());
            }

            banco.desconectar();

        }  

        private void carregarLista()
        {
            if (contagem != 0)
            {
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                //string fichaClinica = ("SELECT FichaClinica.dia, FichaClinica.mes, FichaClinica.ano, FichaClinica.data, Anamnese.queixaPrincipal, Anamnese.historiaQueixa, FichaClinica.protocoloAtendimento FROM FichaClinica INNER JOIN Anamnese ON FichaClinica.protocoloAtendimento = Anamnese.protocoloAtendimento WHERE FichaClinica.idPacienteFK = @ID");
                string fichaClinica = ("SELECT FichaClinica.dia, FichaClinica.mes, FichaClinica.ano, FichaClinica.dataHora, Colaborador.nomeProfissional, Colaborador.especialidade, FichaClinica.protocoloAtendimento, FichaClinica.tempoAtendimento FROM FichaClinica INNER JOIN Colaborador ON FichaClinica.idColaboradorFK = Colaborador.idColaborador WHERE FichaClinica.idPacienteFK = @ID");
                SqlCommand exeVerificacao = new SqlCommand(fichaClinica, banco.connection);
                banco.conectar();

                exeVerificacao.Parameters.AddWithValue("@ID", int.Parse(FichaClinicaId._retornarID().ToString()));

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                FichaItem[] fichaItems = new FichaItem[contagem];

                for (int i = 0; i < fichaItems.Length; i++)
                {
                    while (datareader.Read())
                    {
                        fichaItems[i] = new FichaItem();
                        fichaItems[i].Dia = Convert.ToString(datareader[0]);
                        fichaItems[i].Mes = Convert.ToString(datareader[1]);
                        fichaItems[i].Ano = Convert.ToString(datareader[2]);
                        fichaItems[i].Titulo = Convert.ToString(datareader[4]);
                        fichaItems[i].Resumo = Convert.ToString(datareader[5]);
                        fichaItems[i].DataHora = Convert.ToString(datareader[3]);
                        fichaItems[i].Protocolo = Convert.ToString(datareader[6]);
                        fichaItems[i].TempoAtendimento = Convert.ToString(datareader[7]);

                        if (liberado == true)
                        {
                            fichaItems[i].VerticalSuperior = true;
                        }

                        if (flowLayoutPanelContent.Controls.Count < 0)
                        {
                            flowLayoutPanelContent.Controls.Clear();
                        }
                        else
                            flowLayoutPanelContent.Controls.Add(fichaItems[i]);

                        liberado = true;
                    }
                }
                banco.desconectar();
            }
            else
            {
                MessageBox.Show("No momento este Paciente não possui nenhum atendimento.");
            }
        }

        private void frmFichaClinica_Load(object sender, EventArgs e)
        {
            verificarQuantidade();
            preencherHeader();
            carregarLista();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            panelContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContent.Width,
            panelContent.Height, 8, 8));
        }

        private void panelInfoHeader_Paint(object sender, PaintEventArgs e)
        {
            panelInfoHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInfoHeader.Width,
            panelInfoHeader.Height, 8, 8));
        }

        private void panelOpcoesHeader_Paint(object sender, PaintEventArgs e)
        {
            panelOpcoesHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelOpcoesHeader.Width,
            panelOpcoesHeader.Height, 8, 8));
        }

        private void btnVizualizarCadastro_Click(object sender, EventArgs e)
        {
            Reports.ReportCadastros.frmReportPaciente windows = new Reports.ReportCadastros.frmReportPaciente();
            windows.ShowDialog();
            windows.Dispose();
        }
    }
}
