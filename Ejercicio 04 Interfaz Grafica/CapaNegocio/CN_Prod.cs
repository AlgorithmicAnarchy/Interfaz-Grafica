using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaNegocio
{
    public class CN_Prod
    {

        private CD_Prod productosDatos = new CD_Prod();

        public DataTable ObtenerProductos()
        {
            return productosDatos.ListarProductos();
        }

        public DataTable VerCategorias()
        {
            return productosDatos.VerCategoria();
        }

        public DataTable VerProveedores()
        {
            return productosDatos.VerProveedores();
        }

        public DataTable GuardarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            return productosDatos.GuardarProductos(ID, producto,
            desc, id_categoria, stock, precio,
            fecha, id_proveedor);
        }

        public DataTable ActualizarProductos(int ID, string producto,
            string desc, int id_categoria, int stock, decimal precio,
            DateTime fecha, int id_proveedor)
        {
            return productosDatos.ActualizarProductos(ID, producto,
            desc, id_categoria, stock, precio,
            fecha, id_proveedor);
        }

        public DataTable ObtenerProductoPorID(int idProducto)
        {
            CD_Prod objDatos = new CD_Prod();
            return objDatos.ObtenerProductoPorID(idProducto);
        }

        public DataTable Eliminar(int ID)
        {
            return productosDatos.Eliminar(ID);
        }

        public DataTable BuscarProductos(string Valor)
        {
            return productosDatos.BuscarProductos(Valor);
        }

        public DataTable ObtenerCategorias()
        {
            return productosDatos.ObtenerCategorias();
        }

        public DataTable InsertarCategoria(string nombreCategoria)
        {
            return productosDatos.InsertarCategoria(nombreCategoria);
        }

        public DataTable EditarCategoria(int idCategoria, string nombreCategoria)
        {
            return productosDatos.EditarCategoria(idCategoria, nombreCategoria);
        }

        public void EliminarCategoria(int idCategoria)
        {
            productosDatos.EliminarCategoria(idCategoria);
        }

        public DataTable ObtenerProveedores()
        {
            return productosDatos.ObtenerProveedores();
        }

        public int InsertarProveedor(string nombre, string contacto, bool activo = true)
        {
            try
            {
                return productosDatos.InsertarProveedor(nombre, contacto, activo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public void ActualizarProveedor(int idProveedor, string nombre, string contacto)
        {
            productosDatos.ActualizarProveedor(idProveedor, nombre, contacto);
        }

        public bool EliminarProveedor(int idProveedor)
        {
            try
            {
                return productosDatos.EliminarProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public DataTable ObtenerInventario()
        {
            try
            {
                return productosDatos.ObtenerInventario();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public void EditarStock(int idProducto, int nuevoStock)
        {
            try
            {
                productosDatos.EditarStock(idProducto, nuevoStock);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public DataTable BuscarInventario(string nombreProducto)
        {
            try
            {
                return productosDatos.BuscarInventario(nombreProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }


    }
}


