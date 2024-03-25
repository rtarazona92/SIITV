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
    public class N_TipoCombustible
    {
        public static DataTable Listado_tc(string cTexto)
        {
            D_TipoCombustible Datos = new D_TipoCombustible();
            return Datos.Listado_tc(cTexto);
        }

        public static string Guardar_tc(int nOpcion, E_TipoCombustible oTc)
        {
            D_TipoCombustible Datos = new D_TipoCombustible();
            return Datos.Guardar_tc(nOpcion, oTc);
        }
        public static string Eliminar_tc(int Codigo_tc)
        {
            D_TipoCombustible Datos = new D_TipoCombustible();
            return Datos.Eliminar_tc(Codigo_tc);
        }
    }
}
