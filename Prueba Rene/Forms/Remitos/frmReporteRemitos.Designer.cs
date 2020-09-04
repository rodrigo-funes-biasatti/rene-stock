namespace Prueba_Rene.Forms.Remitos
{
    partial class frmReporteRemitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteRemitos));
            this.reportViewerNuevoRemito = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerNuevoRemito
            // 
            this.reportViewerNuevoRemito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerNuevoRemito.LocalReport.ReportEmbeddedResource = "Prueba_Rene.Forms.Remitos.Informes.ReportNuevoRemito.rdlc";
            this.reportViewerNuevoRemito.Location = new System.Drawing.Point(0, 0);
            this.reportViewerNuevoRemito.Name = "reportViewerNuevoRemito";
            this.reportViewerNuevoRemito.ServerReport.BearerToken = null;
            this.reportViewerNuevoRemito.Size = new System.Drawing.Size(811, 532);
            this.reportViewerNuevoRemito.TabIndex = 0;
            // 
            // frmReporteRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 532);
            this.Controls.Add(this.reportViewerNuevoRemito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteRemitos";
            this.Text = "Remito";
            this.Load += new System.EventHandler(this.frmReporteRemitos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNuevoRemito;
    }
}