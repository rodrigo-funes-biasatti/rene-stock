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
    public partial class frmAgregarStockRemito : Form
    {
        private Producto producto;
        private SStock stock_producto;
        private int id_prod;
        private accesoDatos accesoDatos;
        private frmLoading loading;
        private double nuevo_stock;
        public frmAgregarStockRemito(int id_prod)
        {
            InitializeComponent();
            this.id_prod = id_prod;
            this.accesoDatos = new accesoDatos();
        }

        private void frmAgregarStockRemito_Load(object sender, EventArgs e)
        {
            loading = new frmLoading();
            bwCargarDatosProducto.RunWorkerAsync();
            loading.ShowDialog();
        }

        private void bwCargarDatosProducto_DoWork(object sender, DoWorkEventArgs e)
        {
            producto = accesoDatos.obtenerProductoPorId(id_prod);
            stock_producto = accesoDatos.obtenerStock(id_prod);
        }

        private void bwCargarDatosProducto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProducto.Text = producto.Nombre;
            txtCantidadActual.Text = stock_producto.Cantidad_actual.ToString();
            loading.Close();
        }

        private void btnEditarStock_Click(object sender, EventArgs e)
        {
            nuevo_stock = Convert.ToDouble(txtCantidadActual.Text);
            if (nuevo_stock <= stock_producto.Cantidad_actual)
            {
                MessageBox.Show("La cantidad debe ser mayor a la actual", "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                loading = new frmLoading();
                bwEditarStock.RunWorkerAsync();
                loading.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bwEditarStock_DoWork(object sender, DoWorkEventArgs e)
        {
            accesoDatos.actulizarStock(nuevo_stock, id_prod);
        }

        private void bwEditarStock_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Se ha actualizado el stock correctamente.", "Agregar stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loading.Close();
            this.Close();
        }
    }
}
