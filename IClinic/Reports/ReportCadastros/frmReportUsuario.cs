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
    public partial class frmReportUsuario : Form
    {
        public frmReportUsuario()
        {
            InitializeComponent();
        }

        private void frmReportUsuario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
