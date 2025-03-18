using System.Data.SqlClient;
using System.Data;
using System;

namespace CapaDatos
{
    public class D_Guardar
    {
        private string connectionString = "Server=CRAROX;Database=Ventas;Integrated Security=true";

        public void EjecutarProcedimientoAlmacenado(string nombreProducto, int idMedida, int idCategoria, decimal precio, int stock)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_Guardar_Data", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre_Producto", nombreProducto);
                command.Parameters.AddWithValue("@ID_Medida", idMedida);
                command.Parameters.AddWithValue("@ID_Categoria", idCategoria);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Stock", stock);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }
        }


        


    }
}
