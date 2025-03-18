using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace CapaDatos
{
    public class CapaDeDatos
    {
        public SqlConnection cn =
            new SqlConnection("Server=CRAROX;Database=FarmaciaDB;Integrated Security=true");

        public DataTable ListarProductos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Listar_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable VerCategoria()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("VerCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
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


        public DataTable GuardarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Guardar_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Productos", ID);
                cmd.Parameters.AddWithValue("@Opcion", 1);
                cmd.Parameters.AddWithValue("@Nombre_Prod", producto);
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

        public DataTable ActualizarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Guardar_Actualizar", cn);
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

        public DataTable Eliminar(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarProducto", cn);
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
                SqlCommand cmd = new SqlCommand("BuscarProducto", cn);
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
    }
}
