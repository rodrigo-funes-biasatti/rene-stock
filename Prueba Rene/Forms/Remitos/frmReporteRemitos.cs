using Microsoft.Reporting.WinForms;
using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Remitos
{
    public partial class frmReporteRemitos : Form
    {
        DataTable remito;
        accesoDatos ad;
        int codigo_rem;
        public frmReporteRemitos(int cod_rem)
        {
            InitializeComponent();
            ad = new accesoDatos();
            codigo_rem = cod_rem;
        }

        private void frmReporteRemitos_Load(object sender, EventArgs e)
        {
            remito = ad.obtenerDatosRemitoReporte(codigo_rem);
            DataTable items = new DataTable();
            ReportDataSource rdsRemito = new ReportDataSource("DataSetReporteRemitos", remito);
            ReportDataSource rdsItems = new ReportDataSource("DataSetReporteItem", items);

            reportViewerNuevoRemito.LocalReport.DataSources.Clear();
            reportViewerNuevoRemito.LocalReport.DataSources.Add(rdsRemito);
            reportViewerNuevoRemito.LocalReport.DataSources.Add(rdsItems);
            this.reportViewerNuevoRemito.RefreshReport();
        }
    }
}
