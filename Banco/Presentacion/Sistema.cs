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
    public partial class Sistema : Form
    {
        public string Cod_cli = "";
        public Sistema()
        {
            InitializeComponent();
        }

        void rellenarData()
        {
            MetodoInfoGeneral AU = new MetodoInfoGeneral();
            AU.cod_cli = this.Cod_cli;

            CLSInfoGeneral.VerInformacion(AU);

            lblUsuario.Text = AU.nombres;
            lblNumeroCuenta.Text = AU.nro_cta;
            lblBanco.Text = AU.nombre;
            lblTipoCuenta.Text = AU.tipo_cuenta;
            lblSaldo.Text = Convert.ToString(AU.saldo);
        }
        
        private void Sistema_Load(object sender, EventArgs e)
        {
            rellenarData();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string textoACopiar = "Nro de Cuenta: " + lblNumeroCuenta.Text;

            // Copia el texto al portapapeles
            Clipboard.SetText(textoACopiar);

            // Opcionalmente, muestra un mensaje de confirmación
            MessageBox.Show("Texto copiado al portapapeles.", "Copia Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Ingresar frm = new Ingresar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaccion frm = new Transaccion();
            frm.saldoCliente = float.Parse(this.lblSaldo.Text);
            frm.nroCuentaCliente = this.lblNumeroCuenta.Text;
            frm.FormClosed += FormularioCerrado;
            frm.ShowDialog();
        }

        private void FormularioCerrado(object sender, FormClosedEventArgs e)
        {
            rellenarData();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial frm = new Historial();
            frm.nro_cta = lblNumeroCuenta.Text;
            frm.ShowDialog();
        }

        private void btnIngSal_Click(object sender, EventArgs e)
        {
            IngresosSalidas frm = new IngresosSalidas();
            frm.nro_cta = lblNumeroCuenta.Text;
            frm.FormClosed += FormularioCerrado;
            frm.ShowDialog();
        }
    }
}
