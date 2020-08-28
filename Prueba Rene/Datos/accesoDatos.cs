using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Prueba_Rene.Clases;

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

                    con.Close();

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
                con.Close();
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
                    con.Close();
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
                        con.Close();
                        return false;
                    }
                    else
                    {
                        con.Close();
                        return true;
                    }
                }
            }
        }

        public List<Rubro> obtenerRubros()
        {
            List<Rubro> rubros = new List<Rubro>();

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                string query = "SELECT * FROM Rubros";
                using (var cmd = new MySqlCommand(query, con))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Rubro r = new Rubro();
                        r.Id_rubro = Convert.ToInt32(reader["id_rubro"]);
                        r.Nombre = Convert.ToString(reader["nombre"]);
                        r.Descripcion = Convert.ToString(reader["descripcion"]);

                        rubros.Add(r);
                    }
                }
                con.Close();
                return rubros;
            }
        }

        public DataTable rellenarGrillaProductos()
        {
            DataTable ret = new DataTable();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                string query = "SELECT * FROM Productos";
                using (var da = new MySqlDataAdapter(query, con))
                {
                    da.Fill(ret);
                }
                con.Close();
            }
            return ret;
        }

        public bool borrarRubro(Rubro r)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                string query = "DELETE FROM Rubros WHERE id_rubro = " + r.Id_rubro.ToString();
                using (var cmd = new MySqlCommand(query, con))
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result < 1)
                    {
                        con.Close();
                        return false;
                    }
                    else
                    {
                        con.Close();
                        return true;
                    }
                }
            }
        }

        public bool editarRubro(Rubro r)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "UPDATE Rubros SET nombre='" + r.Nombre + "', descripcion='" + r.Descripcion + "' WHERE id_rubro = " + r.Id_rubro.ToString();
                using (var cmd = new MySqlCommand(query, con))
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result < 1)
                    {
                        con.Close();
                        return false;
                    }
                    else
                    {
                        con.Close();
                        return true;
                    }
                }
            }
        }

        public bool agregarRubro(Rubro r)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "INSERT INTO Rubros (nombre,descripcion) VALUES ('" + r.Nombre + "', '" + r.Descripcion + "')";
                using (var cmd = new MySqlCommand(query, con))
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result < 1)
                    {
                        con.Close();
                        return false;
                    }
                    else
                    {
                        con.Close();
                        return true;
                    }
                }
            }
        }


    }
}
