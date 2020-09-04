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
    public partial class frmMenuRemitos : Form
    {
        Panel panel_principal;
        frmMain principal;
        frmGenerarRemito frmGenRem;
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
            this.Hide();
            frm.TopLevel = false;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(frm);
            frm.Show();
        }
    }
}
