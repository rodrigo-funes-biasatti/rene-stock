using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_Rene.Datos;

namespace Prueba_Rene.Forms.Remitos
{
    public partial class frmGenerarRemito : Form
    {
        accesoDatos ad;
        frmMenuRemitos frmAnterior;
        Panel panel_principal;
        frmLoading loading;
        DataTable tabla_productos;
        public frmGenerarRemito(Panel principal, frmMenuRemitos abm)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = abm;
            ad = new accesoDatos();

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        private void frmGenerarRemito_Load(object sender, EventArgs e)
        {
            cmbCondicionVenta.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNroRemito.Clear();
            txtNroFactura.Clear();
            cmbCondicionVenta.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
            txtFiltroMarca.Clear();
            txtCantidad.Clear();
            rtxtObservaciones.Clear();
        }

        private void backgroundWorker1CargarTablaProductos_DoWork(object sender, DoWorkEventArgs e)
        {
            tabla_productos = ad.rellenarGrillaProductos();
        }
    }
}
