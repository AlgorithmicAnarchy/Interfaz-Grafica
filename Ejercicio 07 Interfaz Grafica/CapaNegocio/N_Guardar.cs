using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Guardar
    {
        private D_Guardar datos = new D_Guardar();

        public void GuardarProducto(string nombreProducto, int idMedida, int idCategoria, decimal precio, int stock)
        {
            try
            {
                
                datos.EjecutarProcedimientoAlmacenado(nombreProducto, idMedida, idCategoria, precio, stock);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }


        


    }
}
