using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Productos
    {
        private D_Productos objetoCD = new D_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string nombre, int idMedida, int idCategoria, decimal precio, string stock)
        {
            objetoCD.InsertarProd(nombre, idMedida, idCategoria, precio.ToString(), stock); 
        }

        public void EditarProd(string id, string nombre, int idMedida, int idCategoria, decimal precio, string stock)
        {
            objetoCD.EditarProd(Convert.ToInt32(id), nombre, idMedida, idCategoria, precio, stock);
        }

        public void EliminarProd(string id)
        {
            objetoCD.EliminarProd(Convert.ToInt32(id));
        }



    }

}
