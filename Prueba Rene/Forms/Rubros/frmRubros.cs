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
        DataTable tabla_rubros;
        frmLoading loading;

        public frmRubros(Panel principal, Form anterior)
        {
            InitializeComponent();
            frmAnterior = anterior;
            panel_principal = principal;
            ad = new accesoDatos();
            rubro_seleccionado = new Rubro();
            limpiarTxt();
        }

        private void frmRubros_Load(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            backgroundWorkerCargarTabla.RunWorkerAsync();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
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
            if(dataGridViewRubros.CurrentCell == null)
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

                loading = new frmLoading();
                loading.Show();
                tarea1.Start();
                bool result = await tarea1;

                if (result)
                {
                    MessageBox.Show("Se ha borrado el Rubro con éxito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rubro_seleccionado = new Rubro();
                }
                else
                {
                    MessageBox.Show("Ha habido un problema al borrar el Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loading.Close();
                    limpiarTxt();
                    return;
                }

                backgroundWorkerCargarTabla.RunWorkerAsync();
                loading.Close();
                limpiarTxt();

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

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            loading = new frmLoading();

            if(txtNombreEditar.Text.Equals("") || txtDescripcionEditar.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos a completar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Task<bool> tarea1 = new Task<bool>(editarRubro);
            
            loading.Show();
            tarea1.Start();

            bool ret = await tarea1;

            if (!ret)
            {
                MessageBox.Show("Hubo un error al editar el Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTxt();
                return;
            }
            else
            {
                MessageBox.Show("Se ha editado el Rubro con éxito.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            backgroundWorkerCargarTabla.RunWorkerAsync();

            loading.Close();
            limpiarTxt();
        }

        private bool editarRubro()
        {
            Rubro r = new Rubro()
            {
                Id_rubro = rubro_seleccionado.Id_rubro,
                Nombre = txtNombreEditar.Text,
                Descripcion = txtDescripcionEditar.Text
            };

            return ad.editarRubro(r);
        }

        private async void bntAgregarNuevo_Click(object sender, EventArgs e)
        {
            loading = new frmLoading();

            if (txtNombreNuevo.Text.Equals("") || txtDescripcionNuevo.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos a completar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Task<bool> tareaAgregar = new Task<bool>(agregarRubro);

            tareaAgregar.Start();
            loading.Show();

            bool ret = await tareaAgregar;          

            if (ret)
            {
                MessageBox.Show("Se ha agregado el Rubro correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un problema al agregar el Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTxt();
                return;
            }

            limpiarTxt();
            backgroundWorkerCargarTabla.RunWorkerAsync();
            loading.Close();
        }

        private bool agregarRubro()
        {
            Rubro r = new Rubro()
            {
                Nombre = txtNombreNuevo.Text,
                Descripcion = txtDescripcionNuevo.Text
            };

            if (ad.agregarRubro(r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void backgroundWorkerCargarTabla_DoWork(object sender, DoWorkEventArgs e)
        {
            rubros = ad.obtenerRubros();

            tabla_rubros = ConvertToDataTable(rubros);

        }

        private void backgroundWorkerCargarTabla_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridViewRubros.DataSource = tabla_rubros;
            dataGridViewRubros.Update();
            dataGridViewRubros.Refresh();
            dataGridViewRubros.CurrentCell = null;
            loading.Close();
        }
    }
}
