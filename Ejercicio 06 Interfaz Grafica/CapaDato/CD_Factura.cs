using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using System;

public class CD_Factura
{
    private CD_Conexion conexion = new CD_Conexion();

    public DataTable ObtenerDetalleFactura(int idFactura)
    {
        DataTable tabla = new DataTable();

        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerDetalleFactura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener detalle de factura: " + ex.Message);
        }

        return tabla;
    }

    public int InsertarFactura(int idCliente, DateTime fecha, decimal total)
    {
        int idFactura = 0;

        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarFactura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@total", total);

                    idFactura = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al insertar la factura: " + ex.Message);
        }

        return idFactura;
    }

    public bool InsertarDetalleFactura(int idFactura, int idArticulo, int cantidad, decimal precio)
    {
        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarDetalleFactura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_factura", idFactura);
                    cmd.Parameters.AddWithValue("@id_articulo", idArticulo);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@precio", precio);

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool ActualizarTotalFactura(int idFactura, decimal total)
    {
        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarTotalFactura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_factura", idFactura);
                    cmd.Parameters.AddWithValue("@total", total);

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al actualizar total factura: " + ex.Message);
            return false;
        }
    }


    public DataTable ObtenerClientesCMB(string filtro = "")
    {
        DataTable tabla = new DataTable();
        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerClientesCMB", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@filtro", filtro);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener clientes: " + ex.Message);
        }
        return tabla;
    }

    public DataTable ObtenerArticulosCMB(string filtro = "")
    {
        DataTable tabla = new DataTable();
        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerArticulosCMB", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@filtro", filtro);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener artículos: " + ex.Message);
        }
        return tabla;
    }

    public int ObtenerUltimoIdFactura()
    {
        int idFactura = 0;

        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY()", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out idFactura) && idFactura > 0)
                    {
                        return idFactura;
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener el ID de la factura.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener el último ID de la factura: " + ex.Message);
        }
    }

    public int InsertarFactura(int idCliente)
    {
        int idFactura = 0;

        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarFactura", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@total", 0); // El total inicial es 0

                    idFactura = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

        }
        catch (Exception ex)
        {
            throw new Exception("Error al insertar la factura: " + ex.Message);
        }

        return idFactura;
    }

    public DataTable ObtenerClientePorId(int idCliente)
    {
        DataTable dtCliente = new DataTable();

        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerClientePorId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCliente);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener los datos del cliente: " + ex.Message);
        }

        return dtCliente;
    }

    public DataTable ObtenerArticuloPorId(int idArticulo)
    {
        DataTable dtArticulo = new DataTable();

        try
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerArticuloPorId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_articulo", idArticulo);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtArticulo);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener los datos del Articulo: " + ex.Message);
        }

        return dtArticulo;
    }

    //public bool ActualizarStock(int idFactura)
    //{
    //    using (SqlConnection conn = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
    //    {
    //        try
    //        {
    //            conn.Open();
    //            using (SqlCommand cmd = new SqlCommand("sp_ActualizarStockFactura", conn))
    //            {
    //                cmd.CommandType = CommandType.StoredProcedure;
    //                cmd.Parameters.AddWithValue("@idFactura", idFactura);
    //                cmd.ExecuteNonQuery();
    //            }
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error al actualizar stock: " + ex.Message);
    //        }
    //    }
    //}

    public bool ValidarYDescontarStock(int id_articulo, int cantidad)
    {
        using (SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
        {
            try
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("ValidarYDescontarStock", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_articulo", id_articulo);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);

                    SqlParameter exitoParam = new SqlParameter("@exito", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(exitoParam);

                    cmd.ExecuteNonQuery();

                    return (bool)exitoParam.Value;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar stock: " + ex.Message);
            }
        }
    }

    public DataTable ObtenerFactura(int idFactura)
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
        {
            SqlCommand cmd = new SqlCommand("ObtenerFacturaPorId", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFactura", idFactura);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        return dt;
    }





}
