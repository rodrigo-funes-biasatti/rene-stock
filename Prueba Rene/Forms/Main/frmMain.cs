﻿using Prueba_Rene.Forms.ABM;
using Prueba_Rene.Forms.Productos;
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

        Timer t = new Timer();

        public frmMain()
        {
            InitializeComponent();
            panelContent.Controls.Clear();
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
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            limpiarPanelPrincipal();
            frmABMContraseña form = new frmABMContraseña();
            form.TopLevel = false;

            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnLimpiarPanel_Click(object sender, EventArgs e)
        {
            limpiarPanelPrincipal();
        }

        public void limpiarPanelPrincipal()
        {
            FormCollection forms = Application.OpenForms;
            panelContent.Controls.Clear();
            for (int i = 0; i < forms.Count; i++)
            {
                Form f = forms[i];
                if (f.Name.Equals("frmABMProductos") || f.Name.Equals("frmListaProductos"))
                {
                    f.Dispose();
                }
            }
            GC.Collect();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            limpiarPanelPrincipal();

            abmprod = new frmABMProductos(panelContent, this);
            abmprod.TopLevel = false;
            
            panelContent.Controls.Add(abmprod);
            abmprod.Show();
        }
    }
}
