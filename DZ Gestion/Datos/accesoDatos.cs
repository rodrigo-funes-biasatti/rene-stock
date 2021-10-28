using MySql.Data.MySqlClient;
using Prueba_Rene.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

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
            if (!guardarContraseñaAntigua(contraseña_actual))
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
                        if (result < 1)
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

                string query = "INSERT INTO Productos (id_prod,marca,nombre,precio_unitario,descripcion,id_rubro) VALUES (@id_prod, @marca, @nombre, @precio_unitario, @descripcion, @id_rubro)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Transaction = nuevoProd;
                    try
                    {
                        cmd.Parameters.AddWithValue("@id_prod", p.Id_prod);
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
                    catch (Exception e)
                    {
                        try
                        {
                            nuevoProd.Rollback();
                        }
                        catch (MySqlException ex)
                        {
                            if (nuevoProd.Connection != null)
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

                        if (result < 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public bool actulizarStockPrecio(double precio_nuevo, int id_prod)
        {
            using (var con = new MySqlConnection(cadena_conexion))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Productos SET precio_unitario = @precio_unitario WHERE id_prod=@id_prod";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@precio_unitario", precio_nuevo);
                        cmd.Parameters.AddWithValue("@id_prod", id_prod);

                        int result = cmd.ExecuteNonQuery();

                        if (result < 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
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

        public DataTable obtenerProductosTablaRemito()
        {
            DataTable ret = new DataTable();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                string query = "SELECT p.id_prod, p.marca, p.nombre, p.precio_unitario, s.cantidad_actual FROM Productos p JOIN Stock s ON p.id_prod = s.id_prod ";
                using (var da = new MySqlDataAdapter(query, con))
                {
                    da.Fill(ret);
                }
                con.Close();
            }
            return ret;
        }

        public List<Condicion_Venta> obtenerCondicionVenta()
        {
            List<Condicion_Venta> condiciones = new List<Condicion_Venta>();

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                try
                {
                    string query = "SELECT * FROM Condicion_Venta";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Condicion_Venta c = new Condicion_Venta()
                            {
                                Id_condicion_venta = Convert.ToInt32(reader["id_condicion_venta"]),
                                Descripcion = reader["descripcion"].ToString()
                            };
                            condiciones.Add(c);
                        }

                        return condiciones;
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

        public int obtenerNroRemito()
        {
            int ret;
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                try
                {
                    string query = "SELECT MAX(codigo_rem) FROM Remitos";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        ret = Convert.ToInt32(cmd.ExecuteScalar());
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

                return ret;
            }
        }

        public bool agregarRemito(Remito remito, List<Item_Remito> items, List<SStock> stock_actualizar)
        {
            MySqlTransaction agregarRemito;
            //MySqlTransaction agregarItems;

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                agregarRemito = con.BeginTransaction();

                string query = "INSERT INTO Remitos (codigo_rem, id_condicion_venta, factura_nro, fecha_remito, cod_barra, observaciones, negocio, total_remito, vendedor) VALUES (@codigo_rem, @id_condicion_venta, @factura_nro, @fecha_remito, @cod_barra, @observaciones, @negocio, @total_remito, @vendedor)";
                using (var cmdRemitos = new MySqlCommand(query, con))
                {
                    cmdRemitos.Transaction = agregarRemito;
                    try
                    {
                        cmdRemitos.Parameters.AddWithValue("@codigo_rem", remito.Codigo_remito);
                        cmdRemitos.Parameters.AddWithValue("@id_condicion_venta", remito.Id_condicion_venta);
                        cmdRemitos.Parameters.AddWithValue("@factura_nro", remito.Factura_nro);
                        cmdRemitos.Parameters.AddWithValue("@fecha_remito", remito.Fecha_remito);
                        cmdRemitos.Parameters.AddWithValue("@cod_barra", remito.Codigo_barra);
                        cmdRemitos.Parameters.AddWithValue("@observaciones", remito.Observaciones);
                        cmdRemitos.Parameters.AddWithValue("@negocio", remito.Negocio);
                        cmdRemitos.Parameters.AddWithValue("@total_remito", remito.Total_remito);
                        cmdRemitos.Parameters.AddWithValue("@vendedor", remito.Vendedor);

                        int result = cmdRemitos.ExecuteNonQuery();

                        if (result < 1)
                        {
                            return false;
                        }
                        else
                        {
                            string query2 = "INSERT INTO Item_Remito (codigo_rem, id_prod, cantidad, precio_unitario, subtotal) VALUES (@codigo_rem, @id_prod, @cantidad, @precio_unitario, @subtotal)";

                            using (var cmdItems = new MySqlCommand(query2, con))
                            {
                                cmdItems.Transaction = agregarRemito;

                                try
                                {
                                    foreach (Item_Remito i in items)
                                    {
                                        cmdItems.Parameters.Clear();
                                        cmdItems.Parameters.AddWithValue("@codigo_rem", remito.Codigo_remito);
                                        cmdItems.Parameters.AddWithValue("@id_prod", i.Id_prod);
                                        cmdItems.Parameters.AddWithValue("@cantidad", i.Cantidad);
                                        cmdItems.Parameters.AddWithValue("@precio_unitario", i.Precio_unitario);
                                        cmdItems.Parameters.AddWithValue("@subtotal", i.Subtotal);

                                        int result1 = cmdItems.ExecuteNonQuery();                                   

                                        if (result1 < 1)
                                        {
                                            return false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                    foreach(SStock s in stock_actualizar)
                                    {
                                        if(!actulizarStock(s.Cantidad_actual, s.Id_prod))
                                        {
                                            return false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    throw e;
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            agregarRemito.Rollback();
                        }
                        catch (MySqlException ex)
                        {
                            throw ex;
                        }
                        throw e;
                    }
                    finally
                    {
                        agregarRemito.Commit();
                        con.Close();
                    }
                }

                return true;
            }
        }

        public DataSet obtenerDatosReporteRemito(int codigo_rem)
        {
            DataSet ret = new DataSet();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "SELECT i.codigo_rem, cv.descripcion, r.factura_nro, r.fecha_remito, r.cod_barra, r.observaciones, r.total_remito, r.vendedor, i.id_prod, p.marca, p.nombre, i.cantidad, i.precio_unitario, i.subtotal FROM Condicion_Venta cv JOIN Remitos r ON cv.id_condicion_venta = r.id_condicion_venta JOIN Item_Remito i ON r.codigo_rem = i.codigo_rem JOIN Productos p ON i.id_prod = p.id_prod WHERE r.codigo_rem IN(SELECT MAX(codigo_rem) FROM Remitos)";
                try
                {
                    using (var da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(ret);
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
            return ret;
        }

        public DataTable obtenerDatosRemitoReporte(int codigo_rem)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable ret = new DataTable();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                using (var cmd = new MySqlCommand("obtenerRemitoReporte", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@cod_rem", codigo_rem);

                        da.SelectCommand = cmd;

                        da.Fill(ret);

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
            return ret;
        }

        public DataTable obtenerDatosReporteItems(int codigo_rem)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable ret = new DataTable();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                using (var cmd = new MySqlCommand("obtenerItemsRemitoReporte", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@cod_rem", codigo_rem);

                        da.SelectCommand = cmd;

                        da.Fill(ret);

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
            return ret;
        }

        public DataTable obtenerRemitosxFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable ret = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "SELECT codigo_rem, factura_nro, fecha_remito, total_remito, vendedor FROM Remitos WHERE fecha_remito BETWEEN @fechaDesde AND @fechaHasta";

                try
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                        da.SelectCommand = cmd;

                        da.Fill(ret);
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

            return ret;
        }

        public bool editarNroFacturaRemito(int cod_rem, int nro_fac)
        {
            int result;

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "UPDATE Remitos SET factura_nro=@nro_fac WHERE codigo_rem=@cod_rem";

                try
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nro_fac", nro_fac);
                        cmd.Parameters.AddWithValue("@cod_rem", cod_rem);

                        result = cmd.ExecuteNonQuery();

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

        public DatosRecaudacion obtenerDatosRecaudacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            DatosRecaudacion dr = new DatosRecaudacion();
            dr.FechaDesde = fechaDesde;
            dr.FechaHasta = fechaHasta;
            string query;

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                try
                {
                    query = "SELECT COUNT(r.codigo_rem) AS 'cantidad_remitos', SUM(r.total_remito) AS 'total_remitos', (SUM(r.total_remito)/DATEDIFF(DATE_FORMAT(@fechaHasta, '%Y-%m-%d'), DATE_FORMAT(@fechaDesde, '%Y-%m-%d'))) AS 'promedio_x_dia' FROM Remitos r WHERE DATE_FORMAT(r.fecha_remito, '%Y-%m-%d') BETWEEN DATE_FORMAT(@fechaDesde, '%Y-%m-%d') AND DATE_FORMAT(@fechaHasta, '%Y-%m-%d')";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dr.CantidadRemitosGenerados = Convert.ToInt32(reader["cantidad_remitos"]);
                            dr.TotalRecaudado = Convert.ToDouble(reader["total_remitos"]);
                            dr.PromedioRecaudacionPorDia = Convert.ToDouble(reader["promedio_x_dia"]);
                        }
                    }

                    query = "SELECT COUNT(i.codigo_rem) AS 'cantidad_prod' FROM Item_Remito i JOIN Remitos r ON i.codigo_rem = r.codigo_rem WHERE DATE_FORMAT(r.fecha_remito, '%Y-%m-%d') BETWEEN DATE_FORMAT(@fechaDesde, '%Y-%m-%d') AND DATE_FORMAT(@fechaHasta, '%Y-%m-%d')";
                    using (var cmd = new  MySqlCommand(query, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dr.ProductosVendidos = Convert.ToInt32(reader["cantidad_prod"]);
                        }
                    }

                    return dr;
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

        public int obtenerSugeridoCodigoProducto()
        {
            int codigo;

            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "SELECT MAX(id_prod) FROM Productos";
                try
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

            return codigo;
        }

        public DataTable obtenerDatosInformeStock(int id_rubro)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable ret = new DataTable();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "SELECT r.nombre, SUM(p.precio_unitario*s.cantidad_actual) AS total_valor_existencia, NOW() AS fecha FROM Rubros r JOIN Productos p ON r.id_rubro = p.id_rubro JOIN Stock s ON p.id_prod = s.id_prod WHERE r.id_rubro = @id_rubro";
                using (var cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id_rubro", id_rubro);

                        da.SelectCommand = cmd;

                        da.Fill(ret);

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
            return ret;
        }

        public DataTable obtenerDatosInformeStockItem(int id_rubro)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable ret = new DataTable();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();

                string query = "SELECT p.id_prod, p.nombre, p.marca, p.precio_unitario, s.cantidad_actual, p.precio_unitario*s.cantidad_actual AS valor_existencia FROM Productos p JOIN Stock s ON p.id_prod = s.id_prod WHERE p.id_rubro = @id_rubro";
                using (var cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id_rubro", id_rubro);

                        da.SelectCommand = cmd;

                        da.Fill(ret);

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
            return ret;
        }

        public double obtenerPrecioUnitarioProd(int id_prod)
        {
            double ret;
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                try
                {
                    string query = "SELECT p.precio_unitario FROM Productos p WHERE id_prod = @id_prod";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id_prod", id_prod);
                        ret = Convert.ToDouble(cmd.ExecuteScalar());
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

                return ret;
            }
        }

        public Producto obtenerProductoPorId(int id_prod)
        {
            Producto producto = new Producto();
            using (var con = new MySqlConnection(cadena_conexion))
            {
                con.Open();
                try
                {
                    string query = "SELECT * FROM Productos WHERE id_prod = @id_prod";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id_prod", id_prod);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            producto.Id_prod = Convert.ToInt32(reader["id_prod"]);
                            producto.Marca = reader["marca"].ToString();
                            producto.Nombre = reader["nombre"].ToString();
                            producto.Precio_unitario = Convert.ToDouble(reader["precio_unitario"]);
                            producto.Descripcion = reader["descripcion"].ToString();
                            producto.Id_rubro = Convert.ToInt32(reader["id_rubro"]);
                        }

                        return producto;
                    }
                }
                catch(MySqlException e)
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
