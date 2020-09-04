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
    public partial class frmReporteNuevoRemito : Form
    {
        DataTable datos;
        int codigo_rem;
        accesoDatos ad;
        public frmReporteNuevoRemito(int cr)
        {
            InitializeComponent();
            codigo_rem = cr;
            ad = new accesoDatos();
            datos = ad.obtenerDatosReporteRemito(codigo_rem);
        }

        private void ReporteGenerarRemito_Load(object sender, EventArgs e)
        {
            reporteRemitosPruebaTableAdapter.Fill(test_reneDataSet.reporteRemitosPrueba, codigo_rem);
            this.reportViewer1.RefreshReport();
        }
    }
}
