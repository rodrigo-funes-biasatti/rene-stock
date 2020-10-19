using Prueba_Rene.Clases;
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
    public partial class frmRecaudacion : Form
    {
        accesoDatos ad;
        frmMenuRemitos frmAnterior;
        Panel panel_principal;
        frmLoading loading;
        DatosRecaudacion dr;
        DateTime fechaDesde;
        DateTime fechaHasta;
        public frmRecaudacion(Panel principal, frmMenuRemitos abm)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = abm;
            ad = new accesoDatos();
            loading = new frmLoading();
        }

        private void frmRecaudacion_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerCargarDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            dr = ad.obtenerDatosRecaudacion(fechaDesde, fechaHasta);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            fechaDesde = dateTimePickerFechaDesde.Value;
            fechaHasta = dateTimePickerFechaHasta.Value;

            lblFechas.Text = "Fechas: del " + fechaDesde.ToShortDateString() + " hasta " + fechaHasta.ToShortDateString() + ".";

            loading = new frmLoading();
            loading.Show();

            backgroundWorkerCargarDatos.RunWorkerAsync();
        }

        private void backgroundWorkerCargarDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblRemitosGenerados.Text = dr.CantidadRemitosGenerados.ToString();
            lblProductosVendidos.Text = dr.ProductosVendidos.ToString();
            lblRecaudacionPromedioPorDia.Text = Math.Round(dr.PromedioRecaudacionPorDia, 2).ToString();
            lblRecaudacion.Text = Math.Round(dr.TotalRecaudado, 2).ToString();

            loading.Close();


        }
    }
}
