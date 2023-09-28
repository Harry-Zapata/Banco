using Banco.CapaDatos;
using Banco.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Presentacion
{
    public partial class Historial : Form
    {
        public string nro_cta = "";
        public Historial()
        {
            InitializeComponent();
        }

        public void CargarData()
        {
            MetodoTransaccion Tr = new MetodoTransaccion();
            Tr.nro_cta = this.nro_cta;
            CLSTransaccion.ListarHistorial(Tr);
            dtgHistorial.DataSource = CLSTransaccion.ds;
            dtgHistorial.DataMember = "Cargar";
        }
        private void Historial_Load(object sender, EventArgs e)
        {
            CargarData();
        }
    }
}
