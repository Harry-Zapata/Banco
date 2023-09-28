using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Presentacion.Reportes
{
    public partial class ReporteGeneral : Form
    {
        public string DATO = "";
        public ReporteGeneral()
        {
            InitializeComponent();
        }

        private void ReporteGeneral_Load(object sender, EventArgs e)
        {
            PDFReporteGeneral reporte = new PDFReporteGeneral();
            CristalReportGeneral.ReportSource = reporte;
            reporte.SetParameterValue("@nro_cta", this.DATO);
            reporte.SetDatabaseLogon("sa", "Contraseña");
            reporte.Refresh();
        }
    }
}
