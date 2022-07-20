using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace IClinic
{
    class Banco
    {
        public SqlConnection connection = new SqlConnection();

        public void conectar()
        {
            connection.ConnectionString = ("Data Source=(local);Initial Catalog=IClinicDatabase;Integrated Security=True;");
            connection.Open();      
        }

        public void desconectar()
        {
            connection.Close();
        }
    }

    public class Autenticacao
    {
        static int idUsuario;
        static string nome;
        static string nomeProfissional;
        static string usuario;
        static string senha;
        static string perfil;
        static string especialidade;
        static string statusCadastro;
        static string usuarioADM;

        public static void login(int idUsuario1, string nome1, string nomeProfissional1, string usuario1, string senha1, string perfil1, string especialidade1, string usuarioADM1)
        {
            idUsuario = idUsuario1;
            nome = nome1;
            nomeProfissional = nomeProfissional1;
            usuario = usuario1;
            senha = senha1;
            perfil = perfil1;
            especialidade = especialidade1;
            usuarioADM = usuarioADM1;
        }

        public static int _idUsuario()
        {
            return idUsuario;
        }

        public static string _nome()
        {
            return nome;
        }

        public static string _nomeProfissional()
        {
            return nomeProfissional;
        }

        public static string _usuario()
        {
            return usuario;
        }

        public static string _perfil()
        {
            return perfil;
        }

        public static string _especialidade()
        {
            return especialidade;
        }

        public static void status(string statusCadastro1)
        {
            statusCadastro = statusCadastro1;
        }

        public static string _statusCadastro()
        {
            return statusCadastro;
        }

        public static string _senha()
        {
            return senha;
        }

        public static string _usuarioADM()
        {
            return usuarioADM;
        }
    }

    public class Verificadores
    {
        static int resposta;
        static bool liberado;
        static bool alterarPerfilDashboard;
        static bool alterarLogon;

        public static void abertoFechado(int resposta1)
        {
            resposta = resposta1;
        }

        public static int _abertoFechado()
        {
            return resposta;
        }

        public static void fazerLogon(bool liberado1)
        {
            liberado = liberado1;
        }

        public static bool _liberado()
        {
            return liberado;
        }

        public static void alterarPerfil(bool alterarPerfilDashboard1)
        {
            alterarPerfilDashboard = alterarPerfilDashboard1;
        }

        public static bool _alterarPerfil()
        {
            return alterarPerfilDashboard;
        }

        public static void AlterarLogon(bool alterarLogon1)
        {
            alterarLogon = alterarLogon1;
        }

        public static bool _AlterarLogon()
        {
            return alterarLogon;
        }
    }

    public class FichaClinicaId
    {
        static string protocoloAtencimento;
        static int idPaciente;
        static int idProcedimento;
        static int idColaborador;
        static int idAgenda;

        public static void receberProtocolo(string protocoloAtencimento1)
        {
            protocoloAtencimento = protocoloAtencimento1;
        }

        public static string _retornarProtocolo()
        {
            return protocoloAtencimento;
        }

        //IdPaciente
        public static void receberID(int idPaciente1)
        {
            idPaciente = idPaciente1;
        }

        public static int _retornarID()
        {
            return idPaciente;
        }

        //IdProcedimento
        public static void receberIdProcedimento(int idProcedimento1)
        {
            idProcedimento = idProcedimento1;
        }

        public static int _retornarIdProcedimento()
        {
            return idProcedimento;
        }

        //idColaborador
        public static void receberIdColaborador(int idColaborador1)
        {
            idColaborador = idColaborador1;
        }

        public static int _retornarIdColaborador()
        {
            return idColaborador;
        }

        //idAgenda
        public static void receberIdAgenda(int idAgenda1)
        {
            idAgenda = idAgenda1; 
        }

        public static int _retornarIdAgenda()
        {
            return idAgenda;
        }
    }

    public class Log
    {
        static string codigoLog;

        public static void gerarLog(string descrocao)
        {
            codigoLog = descrocao;
      
        }

        public static string _retornarLog()
        {
            codigoLog = (DateTime.Now.Minute + ""
                        + DateTime.Now.Hour + ""
                        + DateTime.Now.Day + ""
                        + DateTime.Now.Month + ""
                        + DateTime.Now.Year + ""
                        + Autenticacao._idUsuario()
                        );

            return codigoLog;
        }
    }

    public class Arquivo
    {
        public string nomeArquivo { get; set; }
        public string extensao { get; set; }
        public long length { get; set; }
        public byte[] FileStream { get; set; }
    }
}
