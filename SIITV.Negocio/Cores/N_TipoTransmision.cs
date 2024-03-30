using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SIITV.Entidades;
using SIITV.Datos;

namespace SIITV.Negocio
{
    public class N_TipoTransmision
    {
        public static DataTable Listado_tt(string cTexto)
        {
            D_TipoTransmision Datos = new D_TipoTransmision();
            return Datos.Listado_tt(cTexto);
        }

        public static string Guardar_tt(int nOpcion, E_TipoTransmision oTt)
        {
            D_TipoTransmision Datos = new D_TipoTransmision();
            return Datos.Guardar_tt(nOpcion, oTt);
        }
        public static string Eliminar_tt(int Codigo_tt)
        {
            D_TipoTransmision Datos = new D_TipoTransmision();
            return Datos.Eliminar_tt(Codigo_tt);
        }
    }
}
