﻿using Prueba_Rene.Clases;
using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.Productos
{
    public partial class frmNuevoProducto : Form
    {
        Form frmAnterior;
        Panel panel_principal;
        accesoDatos ad;
        frmLoading loading;
        bool ret_agregar;
        Producto p_agregar;
        int codigo_sugerido;
        public frmNuevoProducto(Form anterior, Panel principal)
        {
            InitializeComponent();
            frmAnterior = anterior;
            panel_principal = principal;
            ad = new accesoDatos();
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            loading = new frmLoading();
            loading.Show();
            backgroundWorkerCargarCombo.RunWorkerAsync();
            limpiarCampos();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Dispose();
            panel_principal.Controls.Add(frmAnterior);
            frmAnterior.Show();
            GC.Collect();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtMarca.Text = "";
            txtNombre.Text = "";
            mtxtPrecioUnitario.Text = "";
            rtxtDescripcion.Text = "";
            cmbRubros.SelectedIndex = -1;
        }

        private void backgroundWorkerCargarCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Rubro> rubros = ad.obtenerRubros();

            cmbRubros.DataSource = rubros;
        }

        private void backgroundWorkerCargarCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbRubros.DisplayMember = "nombre";
            cmbRubros.ValueMember = "id_rubro";
            cmbRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            backgroundWorkerCodigoSugerido.RunWorkerAsync();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            p_agregar = new Producto();
            string marca;
            string nombre;
            double precio_unitario;
            string descripcion;
            int id_rubro;

            if (txtMarca.Text.Equals("") || txtNombre.Text.Equals("") || mtxtPrecioUnitario.Text.Equals("") || rtxtDescripcion.Text.Equals("") || cmbRubros.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Faltan datos a completar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            marca = txtMarca.Text;
            nombre = txtNombre.Text;

            try
            {
                precio_unitario = Double.Parse(mtxtPrecioUnitario.Text.Replace(' ', '0'));
            }
            catch
            {
                MessageBox.Show("Error al convertir el precio unitario. Por favor, ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                p_agregar.Id_prod = Convert.ToInt32(txtCodigo.Text);
            }
            catch
            {
                MessageBox.Show("Error al convertir el código. Por favor, ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            descripcion = rtxtDescripcion.Text;
            id_rubro = Convert.ToInt32(cmbRubros.SelectedValue);

            
            p_agregar.Marca = marca;
            p_agregar.Nombre = nombre;
            p_agregar.Precio_unitario = precio_unitario;
            p_agregar.Descripcion = descripcion;
            p_agregar.Id_rubro = id_rubro;

            loading = new frmLoading();
            loading.Show();

            backgroundWorkerAgregarProducto.RunWorkerAsync();

            backgroundWorkerCargarCombo.RunWorkerAsync();

            return;
        }

        private void backgroundWorkerAgregarProducto_DoWork(object sender, DoWorkEventArgs e)
        {
            ret_agregar = ad.agregarProducto(p_agregar);
            if (ret_agregar)
            {
                MessageBox.Show("Se ha agregado el Producto con éxito.", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorkerAgregarProducto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            limpiarCampos();
            backgroundWorkerCodigoSugerido.RunWorkerAsync();
        }

        private void backgroundWorkerCodigoSugerido_DoWork(object sender, DoWorkEventArgs e)
        {
            codigo_sugerido = ad.obtenerSugeridoCodigoProducto();
        }

        private void backgroundWorkerCodigoSugerido_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtCodigo.Text = (codigo_sugerido + 1).ToString();
            loading.Close();
        }
    }
}