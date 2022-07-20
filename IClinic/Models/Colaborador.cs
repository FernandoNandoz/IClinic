using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinic.Models
{
    public class Colaborador
    {
        public string usuario { get; set; }

        public string tipoColaborador { get; set; }

        public string sexo { get; set; }

        public string cpf { get; set; }

        public string telefone { get; set; }

        public string formaTratamento { get; set; }

        public string nomeProfissional { get; set; }

        public string especialidade { get; set; }
    }
}
