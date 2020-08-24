using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public string obtenerContraseñaActual()
        {
            string contraseña = "";
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                string query = "SELECT contrasena_actual FROM Contrasenas";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contraseña = reader["contrasena_actual"].ToString();
                        }
                    }
                }
            }
            return contraseña;
        }

        public bool cambiarContraseña(string nuevaContraseña)
        {
            string contraseña_actual = obtenerContraseñaActual();
            if (!this.guardarContraseñaAntigua(contraseña_actual))
            {
                return false;
            }
            else
            {
                using (var con = new MySqlConnection(cadena_conexion))
                {
                    con.Open();
                    string query = "UPDATE Contrasenas SET contrasena_actual = '" + nuevaContraseña + "'";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        int result = cmd.ExecuteNonQuery();
                        if(result < 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }

        public bool guardarContraseñaAntigua(string contraseñaVieja)
        {
            string query = "INSERT INTO Historial_Contrasenas (contrasena) VALUES ('" + contraseñaVieja + "')";


            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
