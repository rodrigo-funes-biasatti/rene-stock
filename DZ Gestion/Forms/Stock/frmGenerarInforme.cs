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
    public partial class frmGenerarInforme : Form
    {
        frmMenuStock frmAnterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        public frmGenerarInforme(Panel principal, frmMenuStock menu)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = menu;
            ad = new accesoDatos();
            loading = new frmLoading();
        }

        private void frmGenerarInforme_Load(object sender, EventArgs e)
        {
            cmbRubros.SelectedIndex = -1;
            backgroundWorkerCargarComboRubros.RunWorkerAsync();
            loading.ShowDialog();
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

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            int id_rubro = Convert.ToInt32(cmbRubros.SelectedValue);
            frmInformeStock informe = new frmInformeStock(id_rubro);
            informe.ShowDialog();

            cmbRubros.SelectedIndex = -1;
        }
    }
}
