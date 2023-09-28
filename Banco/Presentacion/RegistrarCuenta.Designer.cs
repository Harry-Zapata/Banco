namespace Banco.Presentacion
{
    partial class RegistrarCuenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.txtNroCuenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoCuenta);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.cbSucursal);
            this.groupBox1.Controls.Add(this.cbBanco);
            this.groupBox1.Controls.Add(this.txtNroCuenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Items.AddRange(new object[] {
            "Cuenta Corriente",
            "Cuenta con Chequera",
            "Cuenta Ahorro",
            "Cuenta Nómina",
            "Cuenta en Dólares"});
            this.cbTipoCuenta.Location = new System.Drawing.Point(178, 381);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(237, 24);
            this.cbTipoCuenta.TabIndex = 13;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(178, 319);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(237, 22);
            this.dtFecha.TabIndex = 12;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(178, 267);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(237, 22);
            this.txtSaldo.TabIndex = 11;
            this.txtSaldo.Text = "0";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(178, 207);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(237, 22);
            this.txtCodCliente.TabIndex = 10;
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(178, 136);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(237, 24);
            this.cbSucursal.TabIndex = 9;
            this.cbSucursal.Click += new System.EventHandler(this.cbSucursal_Click);
            // 
            // cbBanco
            // 
            this.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(178, 73);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(237, 24);
            this.cbBanco.TabIndex = 8;
            this.cbBanco.Click += new System.EventHandler(this.cbBanco_Click);
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Enabled = false;
            this.txtNroCuenta.Location = new System.Drawing.Point(178, 19);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(237, 22);
            this.txtNroCuenta.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Apertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cod_Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro_Cuenta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(617, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gestiona tus finanzas de manera conveniente y eficiente.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(466, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "¡Abre una cuenta bancaria con nosotros ahora!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::Banco.Properties.Resources._2132776;
            this.pictureBox1.Location = new System.Drawing.Point(649, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Enabled = false;
            this.btnCopiar.Image = global::Banco.Properties.Resources._1455554314_line_15_icon_icons_com_53330;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopiar.Location = new System.Drawing.Point(224, 471);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(130, 56);
            this.btnCopiar.TabIndex = 4;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Image = global::Banco.Properties.Resources.continue_120122;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(395, 471);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(143, 56);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Image = global::Banco.Properties.Resources.generatekeysarrows_generar_llave_1490;
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(46, 471);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(154, 56);
            this.BtnGenerar.TabIndex = 1;
            this.BtnGenerar.Text = "Generar Numero \r\nDe Cuenta";
            this.BtnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(544, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(487, 593);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // RegistrarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 539);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "RegistrarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarCuenta";
            this.Load += new System.EventHandler(this.RegistrarCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNroCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoCuenta;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}