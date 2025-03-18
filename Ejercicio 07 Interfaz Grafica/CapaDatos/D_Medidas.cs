using System;
using System.Data;
using System.Data.SqlClient;

public class D_Medidas
{
    private string connectionString = "Server=CRAROX;Database=Ventas;Integrated Security=true";

    public DataTable ObtenerMedidas()
    {
        DataTable tabla = new DataTable();
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_ObtenerMedidas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
        }
        return tabla;
    }

}
