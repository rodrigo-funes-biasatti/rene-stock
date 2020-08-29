using Prueba_Rene.Forms.Rubros;
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
    public partial class frmABMProductos : Form
    {
        Panel panel_principal;
        frmMain principal;
        public frmABMProductos(Panel panel, frmMain main)
        {
            InitializeComponent();
            panel_principal = panel;
            principal = main;
        }

        private void frmABMProductos_Load(object sender, EventArgs e)
        {

        }

        private void panelListaProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos listadoProductos = new frmListaProductos(panel_principal, this);
            cargarFormularioPanel(listadoProductos);
        }

        private void panelRubros_Click(object sender, EventArgs e)
        {
            frmRubros frm_rubros = new frmRubros(panel_principal, this);
            cargarFormularioPanel(frm_rubros);
        }

        private void panelNuevoProducto_Click(object sender, EventArgs e)
        {
            frmNuevoProducto frm_nuevoprod = new frmNuevoProducto(this, panel_principal);
            cargarFormularioPanel(frm_nuevoprod);
        }

        private void cargarFormularioPanel(Form frm)
        {
            this.Hide();
            frm.TopLevel = false;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(frm);
            frm.Show();
        }

        private void panelEditarProducto_Click(object sender, EventArgs e)
        {
            frmEditarProducto frm_editarprod = new frmEditarProducto(panel_principal, this);
            cargarFormularioPanel(frm_editarprod);
        }

        private void panelEliminarProducto_Click(object sender, EventArgs e)
        {
            frmEliminarProducto frm_eliminarprod = new frmEliminarProducto(panel_principal, this);
            cargarFormularioPanel(frm_eliminarprod);
        }
    }
}
