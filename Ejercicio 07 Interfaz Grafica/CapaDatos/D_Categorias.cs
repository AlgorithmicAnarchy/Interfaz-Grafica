using System.Data;
using System.Data.SqlClient;

public class D_Categorias
{
    private string connectionString = "Server=CRAROX;Database=Ventas;Integrated Security=true";

    public DataTable ObtenerCategorias()
    {
        DataTable tabla = new DataTable();
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_ObtenerCategorias", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
        }
        return tabla;
    }
}
