namespace Banco.Presentacion
{
    partial class IngresosSalidas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoMov = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btnOtro = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Movimiento";
            // 
            // cbTipoMov
            // 
            this.cbTipoMov.FormattingEnabled = true;
            this.cbTipoMov.Items.AddRange(new object[] {
            "Ingreso",
            "Salida"});
            this.cbTipoMov.Location = new System.Drawing.Point(33, 62);
            this.cbTipoMov.Name = "cbTipoMov";
            this.cbTipoMov.Size = new System.Drawing.Size(226, 24);
            this.cbTipoMov.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(33, 115);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(159, 55);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(33, 210);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(159, 55);
            this.btn200.TabIndex = 5;
            this.btn200.Text = "200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(33, 303);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(159, 55);
            this.btn500.TabIndex = 6;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(343, 115);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(159, 55);
            this.btn20.TabIndex = 7;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(343, 210);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(159, 55);
            this.btn50.TabIndex = 8;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btnOtro
            // 
            this.btnOtro.Location = new System.Drawing.Point(346, 303);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(159, 55);
            this.btnOtro.TabIndex = 9;
            this.btnOtro.Text = "Otro";
            this.btnOtro.UseVisualStyleBackColor = true;
            this.btnOtro.Click += new System.EventHandler(this.btnOtro_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(346, 62);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(159, 22);
            this.txtImporte.TabIndex = 10;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(183, 388);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(168, 62);
            this.btnContinuar.TabIndex = 11;
            this.btnContinuar.Text = "Realizar Operacion";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(375, 419);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(130, 22);
            this.dtFecha.TabIndex = 12;
            // 
            // IngresosSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 472);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.btnOtro);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoMov);
            this.Controls.Add(this.label1);
            this.Name = "IngresosSalidas";
            this.Text = "IngresosSalidas";
            this.Load += new System.EventHandler(this.IngresosSalidas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoMov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}