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
    public partial class Transaccion : Form
    {
        public string nroCuentaCliente = "";
        public float saldoCliente = 0;
        public Transaccion()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MetodoTransaccion AU = new MetodoTransaccion();
            AU.nro_cta = txtNumeroCuenta.Text;
            try
            {
                CLSTransaccion.buscarUsuario(AU);
            }
            catch (Exception) { MessageBox.Show("Codigo no encontrado"); }

            txtNomCliente.Text = AU.nombres.ToString() + " " + AU.apellidos.ToString();
            txtCodBanco.Text = AU.cod_banco.ToString();
            txtNomBanco.Text = AU.nombre.ToString();
            txtNroSucursal.Text = AU.nro_sucursal.ToString();
            txtNomSucursal.Text = AU.ciudad.ToString();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Transferir el dinero?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                if (float.Parse(txtImporte.Text) <= this.saldoCliente)
                {
                    MetodoTransaccion Cl = new MetodoTransaccion();
                    Cl.nro_cta = txtNumeroCuenta.Text;
                    Cl.importe = float.Parse(txtImporte.Text);
                    CLSTransaccion.SumarImporte(Cl);

                    Cl.nro_cta = this.nroCuentaCliente;
                    Cl.importe = float.Parse(txtImporte.Text);
                    CLSTransaccion.RestarSaldo(Cl);

                    MetodoMovimiento Mv = new MetodoMovimiento();
                    Mv.nro_cta_origen = this.nroCuentaCliente;
                    Mv.nro_cta_destino = txtNumeroCuenta.Text;
                    Mv.nro_sucursal = int.Parse(txtNroSucursal.Text);
                    Mv.cod_banco = txtCodBanco.Text;
                    Mv.tipo_mov = cbTipoMovimiento.Text;
                    Mv.fecha_mov = DateTime.Parse(dtFecha.Value.ToString("dd/MM/yyyy"));
                    Mv.importe = float.Parse(txtImporte.Text);
                    CLSMovimientos.AgregarMovimiento(Mv);

                    MessageBox.Show("Transaccion Exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente");
                }

            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
