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
    public partial class frmEditarProducto : Form
    {
        Form frm_anterior;
        Panel panel_principal;
        DataTable tabla_productos;
        accesoDatos ad;
        frmLoading loading;
        List<Rubro> rubros;
        Producto prod_seleccionado;
        bool ret_editar;

        public frmEditarProducto(Panel principal, frmABMProductos anterior)
        {
            InitializeComponent();
            frm_anterior = anterior;
            panel_principal = principal;
            ad = new accesoDatos();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            backgroundWorkerCargarTabla.RunWorkerAsync();
            backgroundWorkerCargarCombo.RunWorkerAsync();
            limpiarCampos();
        }

        private void backgroundWorkerCargarTabla_DoWork(object sender, DoWorkEventArgs e)
        {
            tabla_productos = ad.rellenarGrillaProductos();
        }

        public void cambiarRubros()
        {
            DataGridViewColumn columna = dataGridViewProductos.Columns["id_rubro"];
            columna.ValueType = typeof(String);

            foreach (DataGridViewRow fila in dataGridViewProductos.Rows)
            {
                foreach (Rubro r in rubros)
                {
                    if (r.Id_rubro.Equals(fila.Cells["id_rubro"].Value))
                    {
                        fila.Cells["rubro_name"].Value = r.Nombre;
                        continue;
                    }
                }
                if (fila.Cells["rubro_name"].Value == null)
                {
                    fila.Cells["rubro_name"].Value = "-Sin Rubro-";
                }
            }
            dataGridViewProductos.Columns["id_rubro"].Visible = false;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frm_anterior);
            frm_anterior.Show();
            GC.Collect();
        }

        private void backgroundWorkerCargarTabla_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridViewProductos.DataSource = tabla_productos;
            rubros = ad.obtenerRubros();
            cambiarRubros();
        }

        private void txtFiltroMarca_TextChanged(object sender, EventArgs e)
        {
            string marca = txtFiltroMarca.Text;
            DataTable dt = (DataTable)dataGridViewProductos.DataSource;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("marca LIKE '{0}%'", marca);
            cambiarRubros();
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            prod_seleccionado = new Producto();

            if (dataGridViewProductos.CurrentCell == null)
            {
                return;
            }

            prod_seleccionado.Id_prod = Convert.ToInt32(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[1].Value);
            prod_seleccionado.Marca = dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            prod_seleccionado.Nombre = dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            prod_seleccionado.Precio_unitario = Convert.ToDouble(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[4].Value);
            prod_seleccionado.Descripcion = dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[5].Value.ToString();
            prod_seleccionado.Id_rubro = Convert.ToInt32(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[6].Value);

            txtMarca.Text = prod_seleccionado.Marca;
            txtNombre.Text = prod_seleccionado.Nombre;
            mtxtPrecioUnitario.Text = prod_seleccionado.Precio_unitario.ToString();
            rtxtDescripcion.Text = prod_seleccionado.Descripcion;
            cmbRubros.SelectedValue = prod_seleccionado.Id_rubro;    

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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtMarca.Text = "";
            txtNombre.Text = "";
            mtxtPrecioUnitario.Text = "";
            rtxtDescripcion.Text = "";
            cmbRubros.SelectedIndex = -1;
            if(dataGridViewProductos.CurrentCell == null)
            {
                return;
            }

            dataGridViewProductos.CurrentCell.Selected = false;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals("") || mtxtPrecioUnitario.Text.Equals("") || rtxtDescripcion.Text.Equals("") || cmbRubros.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Faltan datos a completar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            prod_seleccionado.Marca = txtMarca.Text;
            prod_seleccionado.Nombre = txtNombre.Text;
            prod_seleccionado.Precio_unitario = Convert.ToDouble(mtxtPrecioUnitario.Text);
            prod_seleccionado.Descripcion = rtxtDescripcion.Text;
            prod_seleccionado.Id_rubro = Convert.ToInt32(cmbRubros.SelectedValue);

            loading = new frmLoading();
            loading.Show();

            backgroundWorkerEditarProducto.RunWorkerAsync();
            
        }

        private void backgroundWorkerEditarProducto_DoWork(object sender, DoWorkEventArgs e)
        {
            ret_editar = ad.editarProducto(prod_seleccionado);
        }

        private void backgroundWorkerEditarProducto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ret_editar)
            {
                MessageBox.Show("Se ha editado el Producto con éxito.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al editar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarCampos();
            backgroundWorkerCargarTabla.RunWorkerAsync();
            backgroundWorkerCargarCombo.RunWorkerAsync();
        }

        private void pictureBoxBack_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frm_anterior);
            frm_anterior.Show();
            GC.Collect();
        }

        private void dataGridViewProductos_Sorted(object sender, EventArgs e)
        {
            cambiarRubros();
        }
    }
}
