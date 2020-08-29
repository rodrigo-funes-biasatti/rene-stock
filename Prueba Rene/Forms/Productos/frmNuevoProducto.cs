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

namespace Prueba_Rene.Forms.Productos
{
    public partial class frmNuevoProducto : Form
    {
        Form frmAnterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        bool ret_agregar;
        Producto p_agregar;
        public frmNuevoProducto(Form anterior, Panel principal)
        {
            InitializeComponent();
            frmAnterior = anterior;
            panel_principal = principal;
            ad = new accesoDatos();
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            backgroundWorkerCargarCombo.RunWorkerAsync();
            limpiarCampos();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtMarca.Text = "";
            mtxtPrecioUnitario.Text = "";
            rtxtDescripcion.Text = "";
            cmbRubros.SelectedIndex = -1;
        }

        private void backgroundWorkerCargarCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Rubro> rubros = ad.obtenerRubros();

            cmbRubros.DataSource = rubros;
        }

        private void backgroundWorkerCargarCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbRubros.DisplayMember = "nombre";
            cmbRubros.ValueMember = "id_rubro";
            cmbRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            loading.Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            p_agregar = new Producto();
            string marca;
            double precio_unitario;
            string descripcion;
            int id_rubro;

            if (txtMarca.Text.Equals("") || mtxtPrecioUnitario.Text.Equals("") || rtxtDescripcion.Text.Equals("") || cmbRubros.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Faltan datos a completar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            marca = txtMarca.Text;
            try
            {
                precio_unitario = Convert.ToDouble(mtxtPrecioUnitario.Text);
            }
            catch
            {
                MessageBox.Show("Error al convertir el precio unitario. Por favor, ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            descripcion = rtxtDescripcion.Text;
            id_rubro = Convert.ToInt32(cmbRubros.SelectedValue);

            p_agregar.Marca = marca;
            p_agregar.Precio_unitario = precio_unitario;
            p_agregar.Descripcion = descripcion;
            p_agregar.Id_rubro = id_rubro;

            loading = new frmLoading();
            loading.Show();

            backgroundWorkerAgregarProducto.RunWorkerAsync();

            backgroundWorkerCargarCombo.RunWorkerAsync();

            return;
        }

        private void backgroundWorkerAgregarProducto_DoWork(object sender, DoWorkEventArgs e)
        {
            ret_agregar = ad.agregarProducto(p_agregar);
            if (ret_agregar)
            {
                MessageBox.Show("Se ha agregado el Producto con éxito.", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarCampos();
        }

        private void backgroundWorkerAgregarProducto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loading.Close();
        }
    }
}
