    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Prod
    {
        public string cn = "Server=CRAROX;Database=FarmaciaDB;Integrated Security=True;TrustServerCertificate=True";
        public SqlConnection cn2 = new SqlConnection("Server=CRAROX;Database=FarmaciaDB;Integrated Security=True;TrustServerCertificate=True");

        public DataTable ListarProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cn
))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("Listar_Productos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }
            return dt;
        }

        public DataTable VerCategoria()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cn))
                {
                    using (SqlCommand cmd = new SqlCommand("VerCategorias", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public DataTable VerProveedores()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cn.ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("VerProveedores", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public DataTable GuardarProductos(int ID, string producto, string desc,
    int id_categoria, int stock, decimal precio, DateTime fecha, int id_proveedor)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cn))
                {
                    using (SqlCommand cmd = new SqlCommand("Guardar_Actualizar", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Opcion", 1);
                        cmd.Parameters.AddWithValue("@ID_Productos", ID);
                        cmd.Parameters.AddWithValue("@Nombre_Prod", producto);
                        cmd.Parameters.AddWithValue("@Descripcion", desc);
                        cmd.Parameters.AddWithValue("@ID_Categoria", id_categoria);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fecha);
                        cmd.Parameters.AddWithValue("@ID_Proveedor", id_proveedor);

                        using (SqlDataAdapter A = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            A.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public DataTable ActualizarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Guardar_Actualizar", cn2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Opcion", 0);
                cmd.Parameters.AddWithValue("@Nombre_Prod", producto);
                cmd.Parameters.AddWithValue("@ID_Productos", ID);
                cmd.Parameters.AddWithValue("@Descripcion", desc);
                cmd.Parameters.AddWithValue("@ID_Categoria", id_categoria);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fecha);
                cmd.Parameters.AddWithValue("@ID_Proveedor", id_proveedor);

                SqlDataAdapter A = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                A.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ObtenerProductoPorID(int idProducto)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cn))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProductoPorID", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_Producto", idProducto);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el producto: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable Eliminar(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarProducto", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public DataTable BuscarProductos(string Valor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BuscarProducto", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Valor", Valor);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public DataTable ObtenerCategorias()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerCategorias", cn2);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public DataTable InsertarCategoria(string nombreCategoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", cn2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Categoria", nombreCategoria);

                SqlDataAdapter A = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                A.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable EditarCategoria(int idCategoria, string nombreCategoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EditarCategoria", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria);
                cmd.Parameters.AddWithValue("@Categoria", nombreCategoria);

                SqlDataAdapter A = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                A.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                if (cn2.State == ConnectionState.Closed)
                    cn2.Open();

                SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", cn2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la categoría: " + ex.Message);
            }
            finally
            {
                if (cn2.State == ConnectionState.Open)
                    cn2.Close();
            }
        }

        public DataTable ObtenerProveedores()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerProveedores", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }
        }

        public int InsertarProveedor(string nombre, string contacto, bool activo = true)
        {
            try
            {
                if (cn2.State == ConnectionState.Closed)
                {
                    cn2.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_InsertarProveedor", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreProveedor", nombre);
                cmd.Parameters.AddWithValue("@ContactoProveedor", contacto);
                cmd.Parameters.AddWithValue("@Activo", activo ? 1 : 0);

                int proveedorId = Convert.ToInt32(cmd.ExecuteScalar());

                return proveedorId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el proveedor: " + ex.Message);
            }
            finally
            {
                if (cn2.State == ConnectionState.Open)
                {
                    cn2.Close();
                }
            }
        }

        public void ActualizarProveedor(int idProveedor, string nombre, string contacto)
        {
            try
            {
                SqlConnection connection = cn2;
                SqlCommand cmd = new SqlCommand("sp_ActualizarProveedor", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", nombre);
                cmd.Parameters.AddWithValue("@ContactoProveedor", contacto);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el proveedor: " + ex.Message);
            }
            finally
            {
                cn2.Close();
            }
        }

        public bool EliminarProveedor(int idProveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", cn2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);

                cn2.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el proveedor: " + ex.Message);
            }
            finally
            {
                cn2.Close();
            }
        }

        public DataTable ObtenerInventario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_MostrarInventario", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                cn2.Open();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el inventario: " + ex.Message);
            }
            finally
            {
                cn2.Close();
            }
        }

        public void EditarStock(int idProducto, int nuevoStock)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EditarStockProducto", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                cmd.Parameters.AddWithValue("@NuevoStock", nuevoStock);

                cn2.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el stock del producto: " + ex.Message);
            }
            finally
            {
                cn2.Close();
            }
        }

        public DataTable BuscarInventario(string nombreProducto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarInventario", cn2);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar en el inventario: " + ex.Message);
            }
            finally
            {
                cn2.Close();
            }
        }







    }
}