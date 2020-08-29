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
    public partial class frmEliminarProducto : Form
    {
        Form frm_anterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        List<Rubro> rubros;
        DataTable tabla_productos;
        Producto prod_seleccionado;
        public frmEliminarProducto(Panel principal, frmABMProductos anterior)
        {
            InitializeComponent();
            frm_anterior = anterior;
            panel_principal = principal;
            ad = new accesoDatos();
        }

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            backgroundWorkerCargarTabla.RunWorkerAsync();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frm_anterior);
            frm_anterior.Show();
            GC.Collect();
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

        private void backgroundWorkerCargarTabla_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridViewProductos.DataSource = tabla_productos;
            rubros = ad.obtenerRubros();
            cambiarRubros();
            loading.Close();
        }

        private void txtFiltroMarca_TextChanged(object sender, EventArgs e)
        {
            string marca = txtFiltroMarca.Text;
            DataTable dt = (DataTable)dataGridViewProductos.DataSource;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("marca LIKE '{0}%'", marca);
            cambiarRubros();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {

            if (prod_seleccionado.Equals(null))
            {
                MessageBox.Show("No hay producto seleccionado", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string message = "¿Seguro que desea eliminar el Producto: '" + prod_seleccionado.Marca + "'?";
            if (MessageBox.Show(message, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loading = new frmLoading();
                loading.Show();
                backgroundWorkerBorrarProducto.RunWorkerAsync();
                backgroundWorkerCargarTabla.RunWorkerAsync();
            }
            else
            {
                return;
            }
            
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
            prod_seleccionado.Precio_unitario = Convert.ToDouble(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[3].Value);
            prod_seleccionado.Descripcion = dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            prod_seleccionado.Id_rubro = Convert.ToInt32(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[5].Value);
        }

        private void backgroundWorkerBorrarProducto_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ad.borrarProducto(prod_seleccionado.Id_prod))
            {
                MessageBox.Show("Se ha Eliminado el Producto con éxito.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al Eliminar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
