using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SIITV.Entidades;

namespace SIITV.Datos
{
    public class D_TipoTransmision
    {
        public DataTable Listado_tt(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_tt", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public string Guardar_tt(int nOpcion, E_TipoTransmision oTt)
        {
            string Rpta = "";
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_tt", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_tt", SqlDbType.Int).Value = oTt.Codigo_tt;
                Comando.Parameters.Add("@cSigla_tt", SqlDbType.VarChar).Value = oTt.Sigla_tt;
                Comando.Parameters.Add("@cNombre_tt", SqlDbType.VarChar).Value = oTt.Nombre_tt;
                Comando.Parameters.Add("@cDefinicion_tt", SqlDbType.VarChar).Value = oTt.Definicion_tt;
                SQLCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Error de Registro de datos..";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
            return Rpta;
        }

        public string Eliminar_tt(int Codigo_tt)
        {
            string Rpta = "";
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_tt", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_tt", SqlDbType.Int).Value = Codigo_tt;
                SQLCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Error de Eliminar los datos..";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
            return Rpta;
        }
    }
}
