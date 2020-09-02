using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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

        public bool agregarProducto(Producto p)
        {
            MySqlTransaction nuevoProd;

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                nuevoProd = con.BeginTransaction();

                string query = "INSERT INTO Productos (marca,nombre,precio_unitario,descripcion,id_rubro) VALUES (@marca, @nombre, @precio_unitario, @descripcion, @id_rubro)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Transaction = nuevoProd;
                    try
                    {
                        cmd.Parameters.AddWithValue("@marca", p.Marca);
                        cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                        cmd.Parameters.AddWithValue("@precio_unitario", p.Precio_unitario);
                        cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                        cmd.Parameters.AddWithValue("@id_rubro", p.Id_rubro);

                        int result = cmd.ExecuteNonQuery();
                        if (result < 1)
                        {
                            return false;
                        }
                        else
                        {

                            nuevoProd.Commit();
                            return true;
                        }
                    }
                    catch(Exception e)
                    {
                        try
                        {
                            nuevoProd.Rollback();
                        }
                        catch(MySqlException ex)
                        {
                            if(nuevoProd.Connection != null)
                            {
                                throw ex;
                            }
                        }
                        throw e;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        public bool editarProducto(Producto p)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "UPDATE Productos SET marca=@marca, nombre=@nombre, precio_unitario=@precio_unitario, descripcion=@descripcion, id_rubro=@id_rubro WHERE id_prod=@id_prod";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@marca", p.Marca);
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@precio_unitario", p.Precio_unitario);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@id_rubro", p.Id_rubro);
                    cmd.Parameters.AddWithValue("@id_prod", p.Id_prod);
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

        public bool borrarProducto(int id)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "DELETE FROM Productos WHERE id_prod=@id";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
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

        public List<Producto> obtenerProdPorRubro(int id_rubro)
        {
            List<Producto> productos = new List<Producto>();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                try
                {
                    string query = "SELECT * FROM Productos WHERE id_rubro = @id_rubro";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_rubro", id_rubro);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Producto p = new Producto();
                            p.Id_prod = Convert.ToInt32(reader["id_prod"]);
                            p.Marca = reader["marca"].ToString();
                            p.Nombre = reader["nombre"].ToString();
                            p.Precio_unitario = Convert.ToDouble(reader["precio_unitario"]);
                            p.Descripcion = reader["descripcion"].ToString();
                            p.Id_rubro = Convert.ToInt32(reader["id_rubro"]);

                            productos.Add(p);
                        }

                        return productos;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public SStock obtenerStock(int id_prod)
        {
            SStock s = new SStock();
            using (var con = new MySqlConnection(cadena_conexion))
            {             
                con.Open();
                try
                {
                    string query = "SELECT * FROM Stock WHERE id_prod = @id_prod";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_prod", id_prod);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            
                            s.Id_prod = Convert.ToInt32(reader["id_prod"]);
                            s.Ult_fecha_modif = Convert.ToDateTime(reader["ult_fecha_modif"]);
                            s.Cantidad_actual = Convert.ToDouble(reader["cantidad_actual"]);
                        }

                        return s;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public bool actulizarStock(double cantidad_nueva, int id_prod)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Stock SET cantidad_actual = @cantidad_actual WHERE id_prod=@id_prod";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cantidad_actual", cantidad_nueva);
                        cmd.Parameters.AddWithValue("@id_prod", id_prod);

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
                catch(Exception e)
                {
                    throw e;
                }
            }
        }

        public List<DataGraphStock> obtenerDatosGraph(int id_rubro)
        {
            List<DataGraphStock> dataGraphStocks = new List<DataGraphStock>();

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                try
                {
                    string query = "SELECT p.nombre, s.cantidad_actual FROM Productos p JOIN Stock s ON p.id_prod = s.id_prod WHERE p.id_rubro = @id_rubro ORDER BY p.nombre ASC";

                    using (var cmd = new MySqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@id_rubro", id_rubro);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataGraphStock dgs = new DataGraphStock();

                            dgs.Nombre_prod = reader["nombre"].ToString();
                            dgs.Stock_actual = Convert.ToDouble(reader["cantidad_actual"]);

                            dataGraphStocks.Add(dgs);
                        }

                        return dataGraphStocks;
                    }
                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
