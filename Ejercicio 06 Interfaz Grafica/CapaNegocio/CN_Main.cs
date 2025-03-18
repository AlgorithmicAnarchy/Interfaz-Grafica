using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Main
    {
        private CD_Main objDato = new CD_Main();

        public DataTable MostrarClientes()
        {
            return objDato.MostrarClientes();
        }

    }
}
