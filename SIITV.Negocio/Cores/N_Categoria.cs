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
    public class N_Categoria
    {
        public static DataTable Listado_ca(string cTexto)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Listado_ca(cTexto);
        }

        public static string Guardar_ca(int nOpcion, E_Categoria oCa)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Guardar_ca(nOpcion, oCa);
        }
        public static string Eliminar_ca(int Codigo_ca)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Eliminar_ca(Codigo_ca);
        }
    }
}
