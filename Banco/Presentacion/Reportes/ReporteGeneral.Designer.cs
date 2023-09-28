namespace Banco.Presentacion.Reportes
{
    partial class ReporteGeneral
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
            this.CristalReportGeneral = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CristalReportGeneral
            // 
            this.CristalReportGeneral.ActiveViewIndex = -1;
            this.CristalReportGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CristalReportGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.CristalReportGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CristalReportGeneral.Location = new System.Drawing.Point(0, 0);
            this.CristalReportGeneral.Name = "CristalReportGeneral";
            this.CristalReportGeneral.Size = new System.Drawing.Size(800, 450);
            this.CristalReportGeneral.TabIndex = 0;
            this.CristalReportGeneral.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CristalReportGeneral);
            this.Name = "ReporteGeneral";
            this.Text = "ReporteGeneral";
            this.Load += new System.EventHandler(this.ReporteGeneral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CristalReportGeneral;
    }
}