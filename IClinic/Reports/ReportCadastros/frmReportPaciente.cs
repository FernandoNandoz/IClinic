using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IClinic.Reports.ReportCadastros
{
    public partial class frmReportPaciente : Form
    {
        public frmReportPaciente()
        {
            InitializeComponent();
        }

        private void frmReportPaciente_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
