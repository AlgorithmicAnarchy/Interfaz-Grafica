using System.Data;
using System.Data.SqlClient;

public class N_Medidas
{
    private D_Medidas objetoCDM = new D_Medidas();

    public DataTable ObtenerMedidas()
    {
        return objetoCDM.ObtenerMedidas();
    }
}
