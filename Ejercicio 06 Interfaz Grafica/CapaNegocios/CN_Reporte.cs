using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocios
{
    public class CN_Reporte
    {
        CD_Reporte objReporte = new CD_Reporte();
        public DataTable ObtenerFacturasConCliente()
        {
            return objReporte.ObtenerFacturasConCliente();
        }

        public DataTable BuscarFacturasConCliente(string campo, string filtro)
        {
            return objReporte.BuscarFacturasConCliente(campo, filtro);
        }
    }
}
