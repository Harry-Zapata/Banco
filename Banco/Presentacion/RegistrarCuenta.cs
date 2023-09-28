using Banco.CapaDatos;
using Banco.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banco.Presentacion
{
    public partial class RegistrarCuenta : Form
    {
        public string IdCliente = ""; 
        public RegistrarCuenta()
        {
            InitializeComponent();
        }
        private void LlenarBanco()
        {
            CLSCuenta.LLenarComboxBanco();
            cbBanco.DataSource = CLSCuenta.dt;
            cbBanco.DisplayMember = "nombre";
            cbBanco.ValueMember = "cod_banco";
            cbBanco.Text = "Seleccionar";
        }
        private void LlenarSucursal(string id)
        {
            CLSCuenta.LLenarComboxSucursal(id);
            cbSucursal.DataSource = CLSCuenta.dt;
            cbSucursal.DisplayMember = "Ciudad";
            cbSucursal.ValueMember = "nro_sucursal";
            cbSucursal.Text = "Seleccionar";
        }
        private void RegistrarCuenta_Load(object sender, EventArgs e)
        {
            txtCodCliente.Text = this.IdCliente;
        }

        private void cbBanco_Click(object sender, EventArgs e)
        {
            LlenarBanco();
            cbSucursal.Enabled = true;
        }

        private void cbSucursal_Click(object sender, EventArgs e)
        {
            if (cbBanco.Text != "Seleccionar")
            {
                LlenarSucursal(cbBanco.SelectedValue.ToString());
                cbSucursal.Enabled = true;

            }
            else
            {
                MessageBox.Show("Primero deve seleccionar un banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea grabar Generar Su Numero de Cuenta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                MetodoCuenta AU = new MetodoCuenta();

                AU.nro_sucursal = cbSucursal.SelectedValue.ToString();
                AU.cod_banco = cbBanco.SelectedValue.ToString();
                AU.cod_cli = txtCodCliente.Text;
                AU.saldo = float.Parse(txtSaldo.Text);
                AU.fechaapertura = DateTime.ParseExact(dtFecha.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                AU.tipocta = cbTipoCuenta.Text;


                CLSCuenta.GenerarCuenta(AU);

                MessageBox.Show("Se Genero su cuenta correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    CLSCuenta.VerCuenta(AU);
                }
                catch (Exception) { MessageBox.Show("Codigo no encontrado"); }

                txtNroCuenta.Text = AU.nro_cta;
                btnCopiar.Enabled = true;

            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string textoACopiar = "Nro de Cuenta: " + txtNroCuenta.Text + Environment.NewLine +
                                  "Banco: " + cbBanco.Text + Environment.NewLine +
                                  "Sucursal: " + cbSucursal.Text + Environment.NewLine+
                                  "Codigo Cliente: "+txtCodCliente.Text + Environment.NewLine +
                                  "Saldo: " + txtSaldo.Text + Environment.NewLine +
                                  "Fecha de Apertura: "+ dtFecha.Text + Environment.NewLine +
                                  "Tipo de cuenta: "+ cbTipoCuenta.Text;

            // Copia el texto al portapapeles
            Clipboard.SetText(textoACopiar);

            // Opcionalmente, muestra un mensaje de confirmación
            MessageBox.Show("Texto copiado al portapapeles.", "Copia Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Se le direccionara A la pagina de Inicio.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ingresar frm = new Ingresar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Ingresar frm = new Ingresar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
