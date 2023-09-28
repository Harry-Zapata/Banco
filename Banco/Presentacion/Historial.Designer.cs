namespace Banco.Presentacion
{
    partial class Historial
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
            this.dtgHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistorial
            // 
            this.dtgHistorial.AllowUserToAddRows = false;
            this.dtgHistorial.AllowUserToDeleteRows = false;
            this.dtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorial.Location = new System.Drawing.Point(12, 147);
            this.dtgHistorial.Name = "dtgHistorial";
            this.dtgHistorial.ReadOnly = true;
            this.dtgHistorial.RowHeadersWidth = 51;
            this.dtgHistorial.RowTemplate.Height = 24;
            this.dtgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistorial.Size = new System.Drawing.Size(1055, 291);
            this.dtgHistorial.TabIndex = 0;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.dtgHistorial);
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHistorial;
    }
}