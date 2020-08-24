﻿using System;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelListaProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos listadoProductos = new frmListaProductos(panel_principal, this);
            principal.limpiarPanelPrincipal();
            listadoProductos.TopLevel = false;

            panel_principal.Controls.Add(listadoProductos);
            listadoProductos.Show();
        }

        private void panelListaProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmABMProductos_Load(object sender, EventArgs e)
        {

        }

        public void cargarListadoProductos()
        {
            frmListaProductos listadoProductos = new frmListaProductos(panel_principal, this);
            listadoProductos.TopLevel = false;

            panel_principal.Controls.Add(listadoProductos);
            listadoProductos.Show();
        }
    }
}
