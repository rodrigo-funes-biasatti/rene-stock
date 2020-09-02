using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Stock
{
    public partial class frmMenuStock : Form
    {
        Panel panel_principal;
        frmMain principal;
        frmConsultarStock frmConsStock;
        public frmMenuStock(Panel panel, frmMain main)
        {
            InitializeComponent();
            panel_principal = panel;
            principal = main;         
        }

        private void cargarFormularioPanel(Form frm)
        {
            this.Hide();
            frm.TopLevel = false;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(frm);
            frm.Show();
        }

        private void panelStockGeneral_Click(object sender, EventArgs e)
        {
            frmConsStock = new frmConsultarStock(panel_principal, this);
            cargarFormularioPanel(frmConsStock);
        }

        private void panelEditarStock_Click(object sender, EventArgs e)
        {
            frmEditarStock frmEditStock = new frmEditarStock(panel_principal, this);
            cargarFormularioPanel(frmEditStock);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmGraficos frmgraph = new frmGraficos(panel_principal, this);
            cargarFormularioPanel(frmgraph);
        }
    }
}
