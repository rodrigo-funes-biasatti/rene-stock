using Prueba_Rene.Clases;
using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Stock
{
    public partial class frmConsultarStock : Form
    {
        frmMenuStock frmAnterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        List<Producto> productos;
        int id_rubro_select;
        int id_prod_select;
        SStock stock_actual;

        public frmConsultarStock(Panel principal, frmMenuStock menu)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = menu;
            ad = new accesoDatos();
            loading = new frmLoading();
            productos = new List<Producto>();
            loading.Show();
            backgroundWorkerCargarComboRubros.RunWorkerAsync();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.BackColor = Color.Firebrick;
        }

        private void backgroundWorkerCargarComboRubros_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Rubro> rubros = ad.obtenerRubros();

            cmbRubros.DataSource = rubros;
        }

        private void backgroundWorkerCargarComboRubros_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbRubros.DisplayMember = "nombre";
            cmbRubros.ValueMember = "id_rubro";
            cmbRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRubros.SelectedIndex = -1;
            loading.Close();
        }

        private void backgroundWorkerCargarCombroProductos_DoWork(object sender, DoWorkEventArgs e)
        {
            productos = ad.obtenerProdPorRubro(id_rubro_select);
        }

        private void backgroundWorkerCargarCombroProductos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbProductos.DataSource = productos;
            cmbProductos.DisplayMember = "nombre";
            cmbProductos.ValueMember = "id_prod";
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.SelectedIndex = -1;
            loading.Close();
        }

        private void cmbRubros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cmbProductos.SelectedItem == null)
            //{
            //    return;
            //}
            loading = new frmLoading();
            loading.Show();
            id_rubro_select = Convert.ToInt32(cmbRubros.SelectedValue);
            backgroundWorkerCargarCombroProductos.RunWorkerAsync();
        }

        private void cmbProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            id_prod_select = Convert.ToInt32(cmbProductos.SelectedValue);
            backgroundWorkerCargarStock.RunWorkerAsync();
        }

        private void backgroundWorkerCargarStock_DoWork(object sender, DoWorkEventArgs e)
        {
            stock_actual = ad.obtenerStock(id_prod_select);
        }

        private void frmConsultarStock_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerCargarStock_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtUltFechAct.Text = stock_actual.Ult_fecha_modif.ToString();
            txtCantidadActual.Text = stock_actual.Cantidad_actual.ToString();
            if (stock_actual.Cantidad_actual < 10.0)
            {
                txtCantidadActual.BackColor = Color.Red;
                txtCantidadActual.ForeColor = Color.White;
            }
            if (stock_actual.Cantidad_actual > 10.0 && stock_actual.Cantidad_actual < 30.0)
            {
                txtCantidadActual.BackColor = Color.Yellow;
                txtCantidadActual.ForeColor = Color.Black;
            }
            if (stock_actual.Cantidad_actual > 30.0)
            {
                txtCantidadActual.BackColor = Color.Green;
                txtCantidadActual.ForeColor = Color.Black;
            }

            loading.Close();
        }
    }
}
