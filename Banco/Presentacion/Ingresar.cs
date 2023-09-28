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
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MetodoCliente US = new MetodoCliente();

            US.dni = txtDni.Text;
            US.cod_cli = txtCodCliente.Text;

            if ((txtDni.Text != "") && (txtCodCliente.Text != ""))
            {
                try
                {
                    CLSCliente.Ingresar(US);
                    Sistema frm = new Sistema();
                    frm.Cod_cli = this.txtCodCliente.Text;
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception) { MessageBox.Show("Verificar Usuario o contraseña"); }
            }
            else
            {
                MessageBox.Show("Deve Rellenar los campos");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarCliente frm = new RegistrarCliente();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
