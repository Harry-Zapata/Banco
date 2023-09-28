namespace Banco.Presentacion
{
    partial class Transaccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodBanco = new System.Windows.Forms.TextBox();
            this.txtNroSucursal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.txtNomBanco = new System.Windows.Forms.TextBox();
            this.txtNomSucursal = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(165, 32);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(292, 22);
            this.txtNumeroCuenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de cuenta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(515, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 75);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sucursal";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Enabled = false;
            this.txtNomCliente.Location = new System.Drawing.Point(165, 72);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(292, 22);
            this.txtNomCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // txtCodBanco
            // 
            this.txtCodBanco.Enabled = false;
            this.txtCodBanco.Location = new System.Drawing.Point(165, 116);
            this.txtCodBanco.Name = "txtCodBanco";
            this.txtCodBanco.Size = new System.Drawing.Size(66, 22);
            this.txtCodBanco.TabIndex = 7;
            // 
            // txtNroSucursal
            // 
            this.txtNroSucursal.Enabled = false;
            this.txtNroSucursal.Location = new System.Drawing.Point(165, 164);
            this.txtNroSucursal.Name = "txtNroSucursal";
            this.txtNroSucursal.Size = new System.Drawing.Size(66, 22);
            this.txtNroSucursal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo De Movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(165, 330);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(292, 22);
            this.txtImporte.TabIndex = 13;
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Items.AddRange(new object[] {
            "Pago de servicios",
            "Transferencia entre mis cuentas",
            "pago mensual"});
            this.cbTipoMovimiento.Location = new System.Drawing.Point(165, 212);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(292, 24);
            this.cbTipoMovimiento.TabIndex = 14;
            // 
            // txtNomBanco
            // 
            this.txtNomBanco.Enabled = false;
            this.txtNomBanco.Location = new System.Drawing.Point(263, 116);
            this.txtNomBanco.Name = "txtNomBanco";
            this.txtNomBanco.Size = new System.Drawing.Size(194, 22);
            this.txtNomBanco.TabIndex = 15;
            // 
            // txtNomSucursal
            // 
            this.txtNomSucursal.Enabled = false;
            this.txtNomSucursal.Location = new System.Drawing.Point(263, 164);
            this.txtNomSucursal.Name = "txtNomSucursal";
            this.txtNomSucursal.Size = new System.Drawing.Size(194, 22);
            this.txtNomSucursal.TabIndex = 16;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(165, 273);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(292, 22);
            this.dtFecha.TabIndex = 17;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(515, 273);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(108, 77);
            this.btnTransferir.TabIndex = 18;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 391);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtNomSucursal);
            this.Controls.Add(this.txtNomBanco);
            this.Controls.Add(this.cbTipoMovimiento);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNroSucursal);
            this.Controls.Add(this.txtCodBanco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Name = "Transaccion";
            this.Text = "Transaccion";
            this.Load += new System.EventHandler(this.Transaccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodBanco;
        private System.Windows.Forms.TextBox txtNroSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.TextBox txtNomBanco;
        private System.Windows.Forms.TextBox txtNomSucursal;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnTransferir;
    }
}