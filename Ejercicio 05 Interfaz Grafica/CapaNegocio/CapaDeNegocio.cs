using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Collections;

namespace CapaNegocio
{
    public class CapaDeNegocio
    {
        CapaDeDatos Datos = new CapaDeDatos();

        public DataTable ListarProductos()
        {
            return Datos.ListarProductos();
        }

        public DataTable VerCategorias()
        {
            return Datos.VerCategoria();
        }

        public DataTable VerProveedores()
        {
            return Datos.VerProveedores();
        }

        public DataTable GuardarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            return Datos.GuardarProductos(ID, producto,
            desc, id_categoria, stock, precio,
            fecha, id_proveedor);
        }

        public DataTable ActualizarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            return Datos.ActualizarProductos(ID, producto,
            desc, id_categoria, stock, precio,
            fecha, id_proveedor);
        }
    
        public DataTable Eliminar(int ID)
        {
            return Datos.Eliminar(ID);
        }

        public DataTable BuscarProductos(string Valor)
        {
            return Datos.BuscarProductos(Valor);
        }
    }
}
