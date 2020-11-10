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

namespace Prueba_Rene.Forms.Stock
{
    public partial class frmInformeStock : Form
    {
        accesoDatos ad;
        int id_rubro;
        DataTable informe;
        DataTable items;

        public frmInformeStock(int id_r)
        {
            InitializeComponent();
            ad = new accesoDatos();
            id_rubro = id_r;
        }

        private void frmInformeStock_Load(object sender, EventArgs e)
        {
            informe = ad.obtenerDatosInformeStock(id_rubro);
            items = ad.obtenerDatosInformeStockItem(id_rubro);
            ReportDataSource rdsInforme = new ReportDataSource("DataSetInformeStock", informe);
            ReportDataSource rdsItems = new ReportDataSource("DataSetInformeStockItem", items);

            reportViewerInformeStock.LocalReport.DataSources.Clear();
            reportViewerInformeStock.LocalReport.DataSources.Add(rdsInforme);
            reportViewerInformeStock.LocalReport.DataSources.Add(rdsItems);
            reportViewerInformeStock.RefreshReport();
        }
    }
}
