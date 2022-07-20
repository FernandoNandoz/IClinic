using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;
using System.Threading;

namespace IClinic.Forms
{
    public partial class frmLogin : Form
    {
        Banco banco = new Banco();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //textBoxUsuario.Text = "Fernando";
            //textBoxSenha.Text = "145989";

            //this.btnEntrar_Click(sender, e);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string Colaborador = ("SELECT * FROM Colaborador WHERE usuario = @usuario AND senha = @senha");
            SqlCommand exeVerificacao = new SqlCommand(Colaborador, banco.connection);
            banco.conectar();

            exeVerificacao.Parameters.AddWithValue("@usuario", textBoxUsuario.Text);
            exeVerificacao.Parameters.AddWithValue("@senha", textBoxSenha.Text);

            SqlDataReader datareader = exeVerificacao.ExecuteReader();

            if (datareader.Read())
            {
                Autenticacao.login(
                    int.Parse(datareader[0].ToString()),
                    datareader[2].ToString(),
                    datareader[13].ToString(),
                    datareader[14].ToString(),
                    datareader[15].ToString(), 
                    datareader[1].ToString(),
                    datareader[11].ToString(),
                    datareader[19].ToString());

                Autenticacao.status(datareader[18].ToString());

                var th = new Thread(() => Application.Run(new frmPrincipal()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e senhsa invalidos!");
            }

            banco.desconectar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxSenha.UseSystemPasswordChar == true)
            {
                textBoxSenha.UseSystemPasswordChar = false;
                textBoxSenha.Focus();
            }

            if (checkBoxMostrarSenha.Checked == false)
            {
                textBoxSenha.UseSystemPasswordChar = true;
                textBoxSenha.Focus();
            }
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
       
    }
}
