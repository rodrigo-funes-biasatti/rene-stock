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
using Prueba_Rene.Clases;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using Prueba_Rene.Forms.Remitos;

namespace Prueba_Rene.Forms.Remitos
{
    public partial class frmGenerarRemito : Form
    {
        accesoDatos ad;
        frmMenuRemitos frmAnterior;
        Panel panel_principal;
        frmLoading loading;
        DataTable tabla_productos;
        //Producto prod_seleccionado;
        List<Condicion_Venta> condicion_Ventas;
        double total_remito;
        Remito remito_a_generar;
        List<Item_Remito> items;
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
            loading = new frmLoading();
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            loading.Show();
            backgroundWorker1CargarTablaProductos.RunWorkerAsync();
            total_remito = 0;
            
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
            dataGridViewProductos.ClearSelection();
        }

        private void backgroundWorker1CargarTablaProductos_DoWork(object sender, DoWorkEventArgs e)
        {
            tabla_productos = ad.obtenerProductosTablaRemito();
        }

        private void backgroundWorker1CargarTablaProductos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridViewProductos.DataSource = tabla_productos;
            txtNroRemito.Text = (ad.obtenerNroRemito()+1).ToString();
            backgroundWorkerCargarComboCondiciones.RunWorkerAsync();
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProductos_Sorted(object sender, EventArgs e)
        {
            
        }

        private void txtFiltroMarca_TextChanged(object sender, EventArgs e)
        {
            string marca = txtFiltroMarca.Text;
            DataTable dt = (DataTable)dataGridViewProductos.DataSource;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("marca LIKE '{0}%'", marca);
        }

        private void backgroundWorkerCargarComboCondiciones_DoWork(object sender, DoWorkEventArgs e)
        {
            condicion_Ventas = ad.obtenerCondicionVenta();
        }

        private void backgroundWorkerCargarComboCondiciones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbCondicionVenta.DataSource = condicion_Ventas;
            cmbCondicionVenta.DisplayMember = "descripcion";
            cmbCondicionVenta.ValueMember = "id_condicion_venta";
            cmbCondicionVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicionVenta.SelectedIndex = -1;
            
            loading.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentCell.Equals(null))
            {
                MessageBox.Show("Seleccione algun producto antes de agregarlo", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double cantidad;
            int id_prod = Convert.ToInt32(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[0].Value);
            string marca = dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string nombre = dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            double precio_unitario = Convert.ToDouble(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[3].Value);
            double stock = Convert.ToDouble(dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[4].Value);
            try
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                if(cantidad > stock)
                {
                    MessageBox.Show("No hay Stock suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double subtotal = precio_unitario * cantidad;

            dataGridViewRemito.Rows.Add(id_prod, marca, nombre, cantidad, precio_unitario, subtotal);
            actualizarTotalRemito(subtotal);
            dataGridViewProductos.Rows[dataGridViewProductos.CurrentCell.RowIndex].Cells[4].Value = stock - cantidad;
            dataGridViewProductos.Refresh();
        }

        public void actualizarTotalRemito(double aumento)
        {
            total_remito += aumento;
            lblTotalRemito.Text = total_remito.ToString();
        }

        private void btnQuitarSelec_Click(object sender, EventArgs e)
        {
            if (dataGridViewRemito.CurrentCell.Equals(null))
            {
                MessageBox.Show("Seleccione algun producto antes de agregarlo", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(MessageBox.Show("¿Seguro que desea borrar el item del remito?", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                double subtotal = Convert.ToDouble(dataGridViewRemito.Rows[dataGridViewRemito.CurrentCell.RowIndex].Cells[5].Value);
                DataGridViewRow fila = dataGridViewRemito.Rows[dataGridViewRemito.CurrentCell.RowIndex];

                double stock;
                double cantidad = Convert.ToDouble(dataGridViewRemito.Rows[dataGridViewRemito.CurrentCell.RowIndex].Cells[3].Value);
                foreach (DataGridViewRow filaProd in dataGridViewProductos.Rows)
                {
                    int id_prod = Convert.ToInt32(filaProd.Cells[0].Value);
                    int id_rem = Convert.ToInt32(dataGridViewRemito.Rows[dataGridViewRemito.CurrentCell.RowIndex].Cells[0].Value);
                    if (id_prod.Equals(id_rem))
                    {
                        stock = Convert.ToDouble(filaProd.Cells[4].Value);
                        filaProd.Cells[4].Value = cantidad + stock;
                        break;
                    }
                }
                
                dataGridViewRemito.Rows.Remove(fila);
                actualizarTotalRemito(-subtotal);
            }
            else
            {
                return;
            }
            
        }

        private void btnGenerarRemito_Click(object sender, EventArgs e)
        {
            remito_a_generar = new Remito();
            items = new List<Item_Remito>(); 
            if (MessageBox.Show("Está seguro que desea generar el Remito con estos Items?", "Generar Remito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                remito_a_generar.Codigo_remito = Convert.ToInt32(txtNroRemito.Text);
                remito_a_generar.Id_condicion_venta = Convert.ToInt32(cmbCondicionVenta.SelectedValue);
                remito_a_generar.Factura_nro = Convert.ToInt32(txtNroFactura.Text);
                remito_a_generar.Fecha_remito = DateTime.Now;
                remito_a_generar.Codigo_barra = Convert.ToInt32(txtCodigoBarras.Text);
                remito_a_generar.Observaciones = rtxtObservaciones.Text;
                remito_a_generar.Vendedor = cmbVendedor.SelectedText;
                remito_a_generar.Total_remito = Convert.ToDouble(lblTotalRemito.Text);

                foreach (DataGridViewRow fila in dataGridViewRemito.Rows)
                {
                    Item_Remito i = new Item_Remito()
                    {
                        Codigo_rem = remito_a_generar.Codigo_remito,
                        Id_prod = Convert.ToInt32(fila.Cells[0].Value),
                        Cantidad = Convert.ToDouble(fila.Cells[3].Value),
                        Precio_unitario = Convert.ToDouble(fila.Cells[4].Value),
                        Subtotal = Convert.ToDouble(fila.Cells[5].Value)
                    };

                    items.Add(i);
                }

                try
                {
                    loading = new frmLoading();
                    loading.Show();
                    backgroundWorkerGenerarRemito.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void backgroundWorkerGenerarRemito_DoWork(object sender, DoWorkEventArgs e)
        {
            ad.agregarRemito(remito_a_generar, items);
            frmReporteNuevoRemito reporte = new frmReporteNuevoRemito(remito_a_generar.Codigo_remito);
            reporte.Show();
        }

        private void backgroundWorkerGenerarRemito_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loading.Close();
        }
    }
}
