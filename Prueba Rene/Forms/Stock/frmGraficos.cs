using Prueba_Rene.Clases;
using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Stock
{
    public partial class frmGraficos : Form
    {
        frmMenuStock frmAnterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        List<DataGraphStock> dataGraphStocks;
        int id_rubro_select;
        public frmGraficos(Panel principal, frmMenuStock menu)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = menu;
            ad = new accesoDatos();
            loading = new frmLoading();
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

        private void backgroundWorkerCargarGrafico_DoWork(object sender, DoWorkEventArgs e)
        {
            dataGraphStocks = ad.obtenerDatosGraph(id_rubro_select);
        }

        private void backgroundWorkerCargarGrafico_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            chartStock.Series.Clear();
            foreach (var dgs in dataGraphStocks)
            {
                chartStock.Series.Add(dgs.Nombre_prod);
                chartStock.Series[dgs.Nombre_prod].Points.AddXY(dgs.Nombre_prod, dgs.Stock_actual);

                //switch (true)
                //{
                //    case > 10: 
                //}

                if (dgs.Stock_actual < 10)
                {
                    chartStock.Series[dgs.Nombre_prod].Color = Color.FromArgb(208, 0, 0);
                }
                if (dgs.Stock_actual >= 10 && dgs.Stock_actual < 30)
                {
                    chartStock.Series[dgs.Nombre_prod].Color = Color.FromArgb(255, 224, 0);
                }
                if (dgs.Stock_actual >= 30)
                {
                    chartStock.Series[dgs.Nombre_prod].Color = Color.FromArgb(0, 207, 0);
                }
            }
            loading.Close();
        }

        private void cmbRubros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            id_rubro_select = Convert.ToInt32(cmbRubros.SelectedValue);

            backgroundWorkerCargarGrafico.RunWorkerAsync();
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {

        }
    }
}
