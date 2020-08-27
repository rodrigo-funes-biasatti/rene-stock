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

namespace Prueba_Rene.Forms.Rubros
{
    public partial class frmRubros : Form
    {

        Form frmAnterior;
        Panel panel_principal;
        List<Rubro> rubros;
        accesoDatos ad;
        Rubro rubro_seleccionado;
        public frmRubros(Panel principal, Form anterior)
        {
            InitializeComponent();
            frmAnterior = anterior;
            panel_principal = principal;
            ad = new accesoDatos();
            rubro_seleccionado = new Rubro();
        }

        private void frmRubros_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        private DataTable cargarRubros()
        {
            DataTable tabla_rubros = ConvertToDataTable(rubros);
            return tabla_rubros;
        }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void dataGridViewRubros_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRubros.CurrentCell.Equals(null))
            {
                return;
            }

            rubro_seleccionado.Id_rubro = Convert.ToInt32(dataGridViewRubros.Rows[dataGridViewRubros.CurrentCell.RowIndex].Cells[0].Value);
            rubro_seleccionado.Nombre = dataGridViewRubros.Rows[dataGridViewRubros.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rubro_seleccionado.Descripcion = dataGridViewRubros.Rows[dataGridViewRubros.CurrentCell.RowIndex].Cells[2].Value.ToString();

            txtNombreEditar.Text = rubro_seleccionado.Nombre;
            txtDescripcionEditar.Text = rubro_seleccionado.Descripcion;

        }

        private void limpiarTxt()
        {
            txtDescripcionEditar.Clear();
            txtDescripcionNuevo.Clear();
            txtNombreEditar.Clear();
            txtNombreNuevo.Clear();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if(dataGridViewRubros.CurrentCell == null)
            {
                MessageBox.Show("No hay elementos seleccionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = string.Format("¿Está seguro que desea borrar este Rubro ('{0}')? Recordá que tendrás que editar los Productos con este rubro porque se les eliminá el mismo.", rubro_seleccionado.Nombre);
            if (MessageBox.Show(message, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Task<bool> tarea1 = new Task<bool>(borrarRubro);
                Task tarea2 = new Task(cargarTabla);
                frmLoading loading = new frmLoading();

                loading.Show();
                tarea1.Start();
                bool result = await tarea1;
                tarea2.Start();
                await tarea2;
                loading.Close();

                if (result)
                {
                    MessageBox.Show("Se ha borrado el Rubro con éxito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rubro_seleccionado = new Rubro();
                    return;
                }
                else
                {
                    MessageBox.Show("Ha habido un problema al borrar el Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private bool borrarRubro()
        {
            return ad.borrarRubro(rubro_seleccionado);                       
        }

        private async void cargarTabla()
        {
            frmLoading loading = new frmLoading();
            Task<DataTable> tarea1 = new Task<DataTable>(cargarRubros);
            Task<List<Rubro>> tarea2 = new Task<List<Rubro>>(ad.obtenerRubros);

            loading.Show();

            tarea2.Start();

            rubros = await tarea2;

            tarea1.Start();

            DataTable tabla_rubros = await tarea1;

            dataGridViewRubros.DataSource = tabla_rubros;
            dataGridViewRubros.Refresh();
            dataGridViewRubros.CurrentCell = null;
            limpiarTxt();

            loading.Close();
        }
    }
}
