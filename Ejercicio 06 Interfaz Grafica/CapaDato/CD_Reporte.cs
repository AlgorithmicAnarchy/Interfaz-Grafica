using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class CD_Reporte
    {

        public DataTable ObtenerFacturasConCliente()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerFacturasConCliente", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dt;
        }

        public DataTable BuscarFacturasConCliente(string campo, string filtro)
        {
            using (SqlConnection con = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_BuscarFacturasConCliente", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@campo", campo);
                da.SelectCommand.Parameters.AddWithValue("@filtro", filtro);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
