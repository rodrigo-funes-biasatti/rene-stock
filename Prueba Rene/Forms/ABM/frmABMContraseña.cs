using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Rene.Forms.ABM
{
    public partial class frmABMContraseña : Form
    {
        accesoDatos ad;
        
        public frmABMContraseña()
        {
            InitializeComponent();
            ad = new accesoDatos();
        }

        private async void bntNuevaContraseña_Click(object sender, EventArgs e)
        {

            frmLoading loading = new frmLoading();

            Task tarea = new Task(cambiarContraseña);
            tarea.Start();

            loading.Show();

            await tarea;

            loading.Close();

        }

        public void cambiarContraseña() //Creo una funcion con retorno Task<bool> para poder llamarla de forma asíncrona después
        { 
            string nuevaContraseña = txtNuevaContraseña.Text;
            string viejaContraseña = txtAnteriorContraseña.Text;
            string contraseñaActual = ad.obtenerContraseñaActual();

            if(nuevaContraseña.Equals("") || viejaContraseña.Equals(""))
            {
                MessageBox.Show("Faltan datos a completar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!viejaContraseña.Equals(contraseñaActual))
            {
                MessageBox.Show("La contraseña actual no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = "¿Realmente desea cambiar su contraseña a: " + nuevaContraseña + "?";
            if (MessageBox.Show(message, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (ad.cambiarContraseña(nuevaContraseña))
            {
                MessageBox.Show("La contraseña se ha cambiado correctamente", "Contraseña cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("La contraseña NO se ha cambiado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
