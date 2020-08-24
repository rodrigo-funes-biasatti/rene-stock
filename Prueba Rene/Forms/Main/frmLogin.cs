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

namespace Prueba_Rene.Forms
{
    public partial class frmLogin : Form
    {

        accesoDatos datos = null;
        frmLoading loading = new frmLoading();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            datos = new accesoDatos();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            Task validacion = new Task(validarContraseña); //Se crea una tarea para realizar de forma asíncrona, se le pasa por parámetro lo que hay que realizar
            validacion.Start(); //Arranca la tarea

            loading.Show();

            await validacion; //Indica lo que se realizará al acabar la tarea, en este caso, nada porque es void la función.

            loading.Hide();
        }

        public void validarContraseña()
        {
            string contraseña = txtContraseña.Text;

            bool validate = datos.validarContraseña(contraseña);

            if (validate)
            {
                MessageBox.Show("Contraseña correcta");
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
