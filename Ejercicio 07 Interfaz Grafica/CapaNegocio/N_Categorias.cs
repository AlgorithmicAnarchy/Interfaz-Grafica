using System.Data;

public class N_Categorias
{
    private D_Categorias objetoCD = new D_Categorias();

    public DataTable ObtenerCategorias()
    {
        return objetoCD.ObtenerCategorias();
    }
}
