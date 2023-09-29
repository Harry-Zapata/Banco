using Banco.CapaDatos;
using Banco.CapaLogica;
using Banco.Presentacion.Reportes;
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
    public partial class IngresosSalidas : Form
    {
        public string nro_cta = "";
        public int nro_sucursal = 0;
        public string cod_banco = "";
        public string fecha_mov = Convert.ToString(new DateTime());
        public float importe = 0;
        public IngresosSalidas()
        {
            InitializeComponent();
        }

        private void IngresosSalidas_Load(object sender, EventArgs e)
        {
            MetodoIngreso Mv = new MetodoIngreso();
            Mv.nro_cta = this.nro_cta;
            CLSIngreso.ObtenerData(Mv);
            this.nro_sucursal = Mv.nro_sucursal;
            this.cod_banco = Mv.cod_banco;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(100);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(200);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(500);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(20);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(50);
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            txtImporte.Enabled = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            MetodoTransaccion Cl = new MetodoTransaccion();
            if (cbTipoMov.Text == "Ingreso")
            {
                Cl.nro_cta = this.nro_cta;
                Cl.importe = float.Parse(txtImporte.Text);
                CLSTransaccion.SumarImporte(Cl);
            }
            else if (cbTipoMov.Text == "Salida")
            {
                Cl.nro_cta = this.nro_cta;
                Cl.importe = float.Parse(txtImporte.Text);
                CLSTransaccion.RestarSaldo(Cl);
            }
            else
            {
                throw new Exception("Seleccionar Tipo");
            }
            MetodoIngreso Mv = new MetodoIngreso();
            Mv.nro_cta = this.nro_cta;
            Mv.nro_sucursal = this.nro_sucursal;
            Mv.cod_banco = this.cod_banco;
            Mv.tipo_mov = cbTipoMov.Text;
            Mv.fecha_mov = DateTime.Parse(dtFecha.Value.ToString("dd/MM/yyyy"));
            Mv.importe = float.Parse(txtImporte.Text);
            CLSIngreso.AgregarIngreso(Mv);

            MessageBox.Show("Transaccion Exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Factura frm = new Factura();
            this.Hide();
            frm.cod_mov = Mv.nro_mov;
            frm.ShowDialog();
            this.Close();
        }
    }
}
