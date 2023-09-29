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
    public partial class Factura : Form
    {
        public int cod_mov = 0;
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            ReporteFactura reporte = new ReporteFactura();
            crystalReportViewer1.ReportSource = reporte;
            reporte.SetParameterValue("@nro_mov", this.cod_mov);
            reporte.SetDatabaseLogon("sa", "Senati");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
