using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
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


        
    }
}
