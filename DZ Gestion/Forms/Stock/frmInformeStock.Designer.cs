namespace Prueba_Rene.Forms.Stock
{
    partial class frmInformeStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeStock));
            this.reportViewerInformeStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerInformeStock
            // 
            this.reportViewerInformeStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerInformeStock.LocalReport.ReportEmbeddedResource = "Prueba_Rene.Forms.Stock.Informes.ReportInformeStock.rdlc";
            this.reportViewerInformeStock.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInformeStock.Name = "reportViewerInformeStock";
            this.reportViewerInformeStock.ServerReport.BearerToken = null;
            this.reportViewerInformeStock.Size = new System.Drawing.Size(694, 532);
            this.reportViewerInformeStock.TabIndex = 0;
            // 
            // frmInformeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 532);
            this.Controls.Add(this.reportViewerInformeStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformeStock";
            this.Text = "Informe Existencias";
            this.Load += new System.EventHandler(this.frmInformeStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInformeStock;
    }
}