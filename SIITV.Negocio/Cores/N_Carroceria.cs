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
    public class N_Carroceria
    {
        public static DataTable Listado_carr(string cTexto)
        {
            D_Carroceria Datos = new D_Carroceria();
            return Datos.Listado_carr(cTexto);
        }

        public static string Guardar_carr(int nOpcion, E_Carroceria oCarr)
        {
            D_Carroceria Datos = new D_Carroceria();
            return Datos.Guardar_carr(nOpcion, oCarr);
        }
        public static string Eliminar_carr(int Codigo_carr)
        {
            D_Carroceria Datos = new D_Carroceria();
            return Datos.Eliminar_carr(Codigo_carr);
        }
    }
}
