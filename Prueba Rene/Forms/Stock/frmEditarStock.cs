using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_Rene.Clases;
using Prueba_Rene.Datos;

namespace Prueba_Rene.Forms.Stock
{
    public partial class frmEditarStock : Form
    {
        frmMenuStock frmAnterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        List<Producto> productos;
        int id_rubro_select;
        int id_prod_select;
        SStock stock_actual;
        bool result;
        public frmEditarStock(Panel principal, frmMenuStock menu)
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

        private void frmEditarStock_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
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
            txtCantidadActual.Enabled = true;
            loading = new frmLoading();
            loading.Show();
            id_prod_select = Convert.ToInt32(cmbProductos.SelectedValue);
            backgroundWorkerCargarStock.RunWorkerAsync();
        }

        private void backgroundWorkerCargarStock_DoWork(object sender, DoWorkEventArgs e)
        {
            stock_actual = ad.obtenerStock(id_prod_select);
        }

        private void backgroundWorkerCargarStock_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtCantidadActual.Text = stock_actual.Cantidad_actual.ToString();
            loading.Close();
        }

        private void btnEditarStock_Click(object sender, EventArgs e)
        {
            if (txtCantidadActual.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos que completar.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            stock_actual.Cantidad_actual = Convert.ToDouble(txtCantidadActual.Text);

            loading = new frmLoading();
            loading.Show();
            backgroundWorkerActualizarStock.RunWorkerAsync();
        }

        private void backgroundWorkerActualizarStock_DoWork(object sender, DoWorkEventArgs e)
        {
            result = ad.actulizarStock(stock_actual.Cantidad_actual, stock_actual.Id_prod);
        }

        private void backgroundWorkerActualizarStock_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (result)
            {
                MessageBox.Show("El Stock se ha actualizado correctamente.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Hubo un error al Actualizar el Stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarCampos();
            }


            loading.Close();
        }

        private void limpiarCampos()
        {
            cmbProductos.SelectedIndex = -1;
            txtCantidadActual.Text = "";
        }
    }
}
