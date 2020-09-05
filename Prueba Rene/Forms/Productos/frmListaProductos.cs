﻿using Prueba_Rene.Clases;
using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Productos
{
    public partial class frmListaProductos : Form
    {
        List<Rubro> rubros;
        accesoDatos ad;
        frmABMProductos frmAnterior;
        Panel panel_principal;

        public frmListaProductos(Panel principal, frmABMProductos abm)
        {
            InitializeComponent();
            panel_principal = principal;
            frmAnterior = abm;
        }

        private async void frmListaProductos_Load(object sender, EventArgs e)
        {
            frmLoading loading = new frmLoading();
            Task<DataTable> tarea = new Task<DataTable>(cargarTabla);

            tarea.Start();
            loading.Show();

            dataGridViewProductos.DataSource = await tarea;

            cambiarRubros();

            loading.Close();
        }

        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.BackColor = Color.Firebrick;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        public void cambiarRubros()
        {
            DataGridViewColumn columna = dataGridViewProductos.Columns["id_rubro"];
            columna.ValueType = typeof(String);

            foreach (DataGridViewRow fila in dataGridViewProductos.Rows)
            {
                foreach (Rubro r in rubros)
                {
                    if (r.Id_rubro.Equals(fila.Cells["id_rubro"].Value))
                    {
                        fila.Cells["rubro_name"].Value = r.Nombre;
                        continue;
                    }
                }
                if (fila.Cells["rubro_name"].Value == null)
                {
                    fila.Cells["rubro_name"].Value = "-Sin Rubro-";
                }
            }
            dataGridViewProductos.Columns["id_rubro"].Visible = false;
        }

        public DataTable cargarTabla()
        {
            ad = new accesoDatos();

            rubros = ad.obtenerRubros();

            DataTable tabla = ad.rellenarGrillaProductos();

            return tabla;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string marca = txtFiltroMarca.Text;
            DataTable dt = (DataTable)dataGridViewProductos.DataSource;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("marca LIKE '{0}%'", marca);
            cambiarRubros();
        }
    }
}
