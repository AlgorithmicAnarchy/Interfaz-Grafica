using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato
{
    public class CD_Main
    {

        public DataTable MostrarClientes()
        {
            DataTable dtClientes = new DataTable();
            try
            {
                using (SqlConnection cn2 = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
                {
                    cn2.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_MostrarClientes", cn2))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtClientes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message);
            }
            return dtClientes;
        }

        public string Insertar(string nombre, string direccion, string telefono, string correo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_InsertarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@correo", correo);

                comando.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return respuesta;
        }

        public string Desactivar(int idCliente)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_DesactivarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_cliente", idCliente);

                comando.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return respuesta;
        }

        public string Actualizar(int idCliente, string nombre, string direccion, string telefono, string correo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_ActualizarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_cliente", idCliente);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@correo", correo);

                comando.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return respuesta;
        }

        public DataTable BuscarClientes(string campo, string filtro)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_BuscarClientesV4", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@campo", campo);
                comando.Parameters.AddWithValue("@filtro", filtro);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                tabla = null;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return tabla;
        }





       // ARTICULOSSSS
       // --------------------------------------------------------

        public DataTable MostrarArticulos()
        {
            DataTable dtClientes = new DataTable();
            try
            {
                using (SqlConnection cn2 = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
                {
                    cn2.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_MostrarArticulos", cn2))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtClientes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los Articulos: " + ex.Message);
            }
            return dtClientes;
        }

        public string InsertarArticulos(string nombre, decimal precio, int stock)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_InsertarArticulo", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return respuesta;
        }

        public string ActualizarArticulos(int idArticulo, string nombre, decimal precio, int stock)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_ActualizarArticulo", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_articulo", idArticulo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return respuesta;
        }

        public string DesactivarArticulos(int idArticulo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("sp_DesactivarArticulo", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_articulo", idArticulo);

                comando.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return respuesta;
        }

        public DataTable BuscarArticulos(string filtro)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection connection = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_BuscarArticulos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@filtro", filtro);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar artículos: " + ex.Message);
                }
            }

            return tabla;
        }


    }
}
