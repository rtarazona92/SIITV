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
    public class N_Color
    {
        public static DataTable Listado_co(string cTexto)
        {
            D_Color Datos = new D_Color();
            return Datos.Listado_co(cTexto);
        }

        public static string Guardar_co(int nOpcion, E_Color oCo)
        {
            D_Color Datos = new D_Color();
            return Datos.Guardar_co(nOpcion, oCo);
        }
        public static string Eliminar_co(int Codigo_co)
        {
            D_Color Datos = new D_Color();
            return Datos.Eliminar_co(Codigo_co);
        }
    }
}
