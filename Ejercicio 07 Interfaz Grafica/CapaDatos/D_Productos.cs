using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace CapaDatos
{
    public class D_Productos
    {
        private string connectionString = "Server=CRAROX;Database=Ventas;Integrated Security=true";

        private D_Conexion conexion = new D_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "sp_Listado_Data";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();

            DataTable nuevaTabla = new DataTable();
            nuevaTabla.Load(leer);

            leer.Close();
            conexion.CerrarConexion();

            return nuevaTabla;
        }


        public void InsertarProd(string nombre, int idMedida, int idCategoria, string precio, string stock)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertarProducto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@IDMedida", idMedida);
                cmd.Parameters.AddWithValue("@IDCategoria", idCategoria);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarProd(int idProducto, string nombre, int idMedida, int idCategoria, decimal precio, string stock)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "EXEC sp_editarProducto @IDProducto, @Nombre, @IDMedida, @IDCategoria, @Precio, @Stock";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@IDMedida", idMedida);
                cmd.Parameters.AddWithValue("@IDCategoria", idCategoria);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProd(int id)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "sp_EliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Producto", id);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


    }
}
