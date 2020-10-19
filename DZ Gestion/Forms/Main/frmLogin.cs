using Prueba_Rene.Datos;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Rene.Forms
{
    public partial class frmLogin : Form
    {

        accesoDatos datos;
        frmLoading loading;
        frmMain main;
        public frmLogin()
        {
            InitializeComponent();
            datos = new accesoDatos();
            main = new frmMain();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            loading = new frmLoading();
            Task<bool> validacion = new Task<bool>(validarContraseña); //Se crea una tarea para realizar de forma asíncrona, se le pasa por parámetro lo que hay que realizar
            validacion.Start(); //Arranca la tarea

            loading.Show();

            bool result = await validacion; //Indica lo que se realizará al acabar la tarea, en este caso, nada porque es void la función.

            if (result)
            {
                loading.Close();
                main.Show();
                this.Hide();
            }
            else
            {
                loading.Close();
                return;
            }
        }

        public bool validarContraseña()
        {
            string contraseña = txtContraseña.Text;

            bool validate = datos.validarContraseña(contraseña);

            if (validate)
            {
                MessageBox.Show("Contraseña correcta");
                return true;
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
