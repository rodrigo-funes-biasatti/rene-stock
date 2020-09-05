using System;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Remitos
{
    public partial class frmMenuRemitos : Form
    {
        Panel panel_principal;
        frmMain principal;
        frmGenerarRemito frmGenRem;
        frmHistorialRemitos frmHistRem;
        public frmMenuRemitos(Panel panel, frmMain main)
        {
            InitializeComponent();
            panel_principal = panel;
            principal = main;
        }

        private void frmMenuRemitos_Load(object sender, EventArgs e)
        {

        }

        private void panelGenerarRemito_Click(object sender, EventArgs e)
        {
            frmGenRem = new frmGenerarRemito(panel_principal, this);
            cargarFormularioPanel(frmGenRem);
        }

        private void cargarFormularioPanel(Form frm)
        {
            Hide();
            frm.TopLevel = false;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(frm);
            frm.Show();
        }

        private void panelHistorialRemitos_Click(object sender, EventArgs e)
        {
            frmHistRem = new frmHistorialRemitos(panel_principal, this);
            cargarFormularioPanel(frmHistRem);
        }
    }
}
