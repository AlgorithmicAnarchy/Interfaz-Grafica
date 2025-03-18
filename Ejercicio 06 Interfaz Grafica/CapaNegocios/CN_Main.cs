using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CapaDato;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Main
    {

        private CD_Main objDatos = new CD_Main();

        public DataTable ObtenerClientes()
        {
            return objDatos.MostrarClientes();
        }

        public static string Insertar(string nombre, string direccion, string telefono, string correo)
        {
            CD_Main datos = new CD_Main();
            return datos.Insertar(nombre, direccion, telefono, correo);
        }

        public static string Desactivar(int idCliente)
        {
            CD_Main datos = new CD_Main();
            return datos.Desactivar(idCliente);
        }

        public static string Actualizar(int idCliente, string nombre, string direccion, string telefono, string correo)
        {
            CD_Main datos = new CD_Main();
            return datos.Actualizar(idCliente, nombre, direccion, telefono, correo);
        }

        public static DataTable BuscarClientes(string campo, string filtro)
        {
            CD_Main datos = new CD_Main();
            return datos.BuscarClientes(campo, filtro);
        }


        // ARTICULOSSSS
        // -------------------
        public DataTable ObtenerArticulos()
        {
            return objDatos.MostrarArticulos();
        }

        public static string InsertarArticulos(string nombre, decimal precio, int stock)
        {
            CD_Main datos = new CD_Main();
            return datos.InsertarArticulos(nombre, precio, stock);
        }

        public static string ActualizarArticulo(int idArticulo, string nombre, decimal precio, int stock)
        {
            CD_Main datos = new CD_Main();
            return datos.ActualizarArticulos(idArticulo, nombre, precio, stock);
        }

        public static string DesactivarArticulo(int idArticulo)
        {
            CD_Main datos = new CD_Main();
            return datos.DesactivarArticulos(idArticulo);
        }

        public DataTable BuscarArticulos(string filtro)
        {
            CD_Main datos = new CD_Main();
            return datos.BuscarArticulos(filtro);
        }

    }
}
