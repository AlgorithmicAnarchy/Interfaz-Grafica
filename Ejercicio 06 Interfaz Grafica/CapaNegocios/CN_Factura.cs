using System;
using System.Data;
using CapaDato;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Factura
    {
        private CD_Factura datosFactura = new CD_Factura();

        public DataTable MostrarDetalleFactura(int idFactura)
        {
            return datosFactura.ObtenerDetalleFactura(idFactura);
        }

        public int InsertarFactura(int idCliente, DateTime fecha, decimal total)
        {
            return datosFactura.InsertarFactura(idCliente, fecha, total);
        }

        private CD_Factura objFactura = new CD_Factura();

        public bool InsertarDetalleFactura(int idFactura, int idArticulo, int cantidad, decimal precio)
        {
            return objFactura.InsertarDetalleFactura(idFactura, idArticulo, cantidad, precio);
        }

        public bool ActualizarTotalFactura(int facturaId, decimal nuevoTotal)
        {
            try
            {
                objFactura.ActualizarTotalFactura(facturaId, nuevoTotal);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la factura: " + ex.Message);
                return false;
            }
        }

        public int NuevaFactura(int idCliente)
        {
            return datosFactura.InsertarFactura(idCliente);
        }



        public DataTable ObtenerClientesCMB(string filtro = "")
        {
            return datosFactura.ObtenerClientesCMB(filtro);
        }

        public DataTable ObtenerArticulosCMB(string filtro)
        {
            return datosFactura.ObtenerArticulosCMB(filtro);
        }

        public DataTable ObtenerClientePorId(int idCliente)
        {
            try
            {
                return datosFactura.ObtenerClientePorId(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message);
            }
        }

        public DataTable ObtenerArticuloPorId(int idArticulo)
        {
            try
            {
                return datosFactura.ObtenerArticuloPorId(idArticulo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message);
            }
        }

        //public bool DescontarStockFactura(int idFactura)
        //{
        //    try
        //    {
        //        return datosFactura.ActualizarStock(idFactura);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error en la capa de negocios: " + ex.Message);
        //    }
        //}

        public bool ValidarYDescontarStock(int id_articulo, int cantidad)
        {
            return datosFactura.ValidarYDescontarStock(id_articulo, cantidad);
        }

        public DataTable ObtenerFactura(int idFactura)
        {
            return datosFactura.ObtenerFactura(idFactura);
        }
    }
}
