using Banco.CapaDatos;
using Banco.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Presentacion
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea grabar el Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                MetodoCliente AU = new MetodoCliente();

                AU.cod_cli = txtCodCliente.Text;
                AU.dni = txtDni.Text;
                AU.apellidos = txtApellido.Text;
                AU.nombres = txtNombre.Text;
                AU.direccion = txtDireccion.Text;
                AU.ciudad = txtCiudad.Text;
                AU.email = txtEmail.Text;
                
                try
                {
                    CLSCliente.AgregarCliente(AU);
                    MessageBox.Show("Cliente Ingreso Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RegistrarCuenta frm = new RegistrarCuenta();
                    frm.IdCliente = txtCodCliente.Text;
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Ingresar frm = new Ingresar();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
