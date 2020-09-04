namespace Prueba_Rene.Forms.Remitos
{
    partial class frmReporteNuevoRemito
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteNuevoRemito));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.test_reneDataSet = new Prueba_Rene.test_reneDataSet();
            this.reporteRemitosPruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteRemitosPruebaTableAdapter = new Prueba_Rene.test_reneDataSetTableAdapters.reporteRemitosPruebaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.test_reneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteRemitosPruebaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReport";
            reportDataSource1.Value = this.reporteRemitosPruebaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prueba_Rene.Forms.Remitos.Informes.reporteNuevoRemito.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 696);
            this.reportViewer1.TabIndex = 0;
            // 
            // test_reneDataSet
            // 
            this.test_reneDataSet.DataSetName = "test_reneDataSet";
            this.test_reneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteRemitosPruebaBindingSource
            // 
            this.reporteRemitosPruebaBindingSource.DataMember = "reporteRemitosPrueba";
            this.reporteRemitosPruebaBindingSource.DataSource = this.test_reneDataSet;
            // 
            // reporteRemitosPruebaTableAdapter
            // 
            this.reporteRemitosPruebaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteNuevoRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 696);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteNuevoRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remito";
            this.Load += new System.EventHandler(this.ReporteGenerarRemito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_reneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteRemitosPruebaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteRemitosPruebaBindingSource;
        private test_reneDataSet test_reneDataSet;
        private test_reneDataSetTableAdapters.reporteRemitosPruebaTableAdapter reporteRemitosPruebaTableAdapter;
    }
}