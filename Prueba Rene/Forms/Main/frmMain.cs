using Prueba_Rene.Forms.ABM;
using Prueba_Rene.Forms.Productos;
using Prueba_Rene.Forms.Remitos;
using Prueba_Rene.Forms.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Rene
{
    public partial class frmMain : Form
    {

        //List<Form> secuencia_panel;
        frmABMProductos abmprod;
        frmMenuStock menuStock;
        frmMenuRemitos menuRemitos;

        Timer t = new Timer();

        public frmMain()
        {
            InitializeComponent();
            limpiarPanelPrincipal();
        }

        private void clock1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lblHora.Text = time;
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.clock1_Tick);

            t.Start();

            habilitarPanelesConfig(false);
        }

        private void habilitarPanelesConfig(bool op)
        {
            panelConfig.Controls.Add(btnCambiarContraseña);
            this.panelConfig.Visible = op;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (panelConfig.Visible)
            {
                habilitarPanelesConfig(false);
            }
            else
            {
                habilitarPanelesConfig(true);
                panelConfig.Controls.Add(btnCambiarContraseña);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmABMContraseña frm_contra = new frmABMContraseña();
            cargarFormularioPanel(frm_contra);
            panelConfig.Controls.Add(btnCambiarContraseña);
        }

        private void btnLimpiarPanel_Click(object sender, EventArgs e)
        {
            limpiarPanelPrincipal();
        }

        public void limpiarPanelPrincipal()
        { 
            foreach (IDisposable control in panelContent.Controls)
            {
                control.Dispose();
            }

            List<Form> forms = obtenerForms();
            foreach (Form f in forms)
            {
                if (f.Name.Equals("frmMain"))
                {
                    continue;
                }
                f.Close();
            }

            //IEnumerator<FormCollection> eforms = new IEnumerator();

            //for (int i = 0; i < forms.Count; i++)
            //{ 
            //    if (forms.get)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        f.Close();
            //    }
            //}

            panelConfig.Controls.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {   
            abmprod = new frmABMProductos(panelContent, this);
            cargarFormularioPanel(abmprod);
        }

        private void cargarFormularioPanel(Form frm)
        {
            limpiarPanelPrincipal();
            frm.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private List<Form> obtenerForms()
        {
            List<Form> ret = new List<Form>();
            FormCollection forms = Application.OpenForms;

            foreach (Form f in forms)
            {
                ret.Add(f);
            }

            return ret;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            menuStock = new frmMenuStock(panelContent, this);
            cargarFormularioPanel(menuStock);
        }

        private void btnRemito_Click(object sender, EventArgs e)
        {
            menuRemitos = new frmMenuRemitos(panelContent, this);
            cargarFormularioPanel(menuRemitos);
        }


    }
}
