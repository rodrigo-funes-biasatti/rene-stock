using Prueba_Rene.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Remitos
{
    public partial class frmHistorialRemitos : Form
    {
        accesoDatos ad;
        frmMenuRemitos frmAnterior;
        Panel panel_principal;
        DataTable remitosXFecha;
        frmLoading loading;
        int cod_rem;
        frmReporteRemitos frmReporte;
        int nro_fac;
        bool ret_asociar_factura;
        public frmHistorialRemitos(Panel principal, frmMenuRemitos abm)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = abm;
            ad = new accesoDatos();
        }

        private void frmHistorialRemitos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerCargarTabla_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            remitosXFecha = ad.obtenerRemitosxFecha(dateTimePickerFechaDesde.Value, dateTimePickerFechaHasta.Value);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();

            backgroundWorkerCargarTabla.RunWorkerAsync();
        }

        private void backgroundWorkerCargarTabla_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dataGridViewRemitos.DataSource = remitosXFecha;
            dataGridViewRemitos.Refresh();
            loading.Close();
        }

        private void btnVerRemito_Click(object sender, EventArgs e)
        {
            if(dataGridViewRemitos.CurrentCell == null)
            {
                return;
            }

            cod_rem = Convert.ToInt32(dataGridViewRemitos.Rows[dataGridViewRemitos.CurrentCell.RowIndex].Cells[0].Value);

            frmReporte = new frmReporteRemitos(cod_rem);
            frmReporte.ShowDialog();
        }

        private void dataGridViewRemitos_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewRemitos.CurrentCell == null)
            {
                return;
            }

            txtNroFactura.Text = dataGridViewRemitos.Rows[dataGridViewRemitos.CurrentCell.RowIndex].Cells[1].Value.ToString();

        }

        private void Asociar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que quiere asociar ese Número de Factura al Remito?", "Asociar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cod_rem = Convert.ToInt32(dataGridViewRemitos.Rows[dataGridViewRemitos.CurrentCell.RowIndex].Cells[0].Value);
                    nro_fac = Convert.ToInt32(txtNroFactura.Text);
                    loading = new frmLoading();
                    loading.Show();

                    backgroundWorkerAsociarFactura.RunWorkerAsync();
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

        private void backgroundWorkerAsociarFactura_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ret_asociar_factura = ad.editarNroFacturaRemito(cod_rem, nro_fac);
        }

        private void backgroundWorkerAsociarFactura_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (ret_asociar_factura)
            {
                MessageBox.Show("Se asoció el Número de Factura al Remito con éxito", "Asociar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al asociar el Número de Factura al Remito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            backgroundWorkerCargarTabla.RunWorkerAsync();
        }
    }
}
