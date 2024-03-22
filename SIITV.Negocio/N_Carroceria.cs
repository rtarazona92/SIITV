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
    }
}
