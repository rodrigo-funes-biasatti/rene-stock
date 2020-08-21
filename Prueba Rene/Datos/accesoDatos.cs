using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Prueba_Rene.Datos
{
    class accesoDatos
    {
        string cadena_conexion = "server=45.80.152.253;user id=hs;password=cacaca12;database=test_rene";

        public bool validarContraseña(string contraseña)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Contrasenas WHERE contrasena_actual = '" + contraseña + "'";

                using (var cmd = new MySqlCommand(query, con))
                {
                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result < 1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
