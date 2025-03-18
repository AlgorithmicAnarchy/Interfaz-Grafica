using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private string connectionString = "Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection AbrirConexion()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public void CerrarConexion(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

}
