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
    public class D_Categoria
    {
        public DataTable Listado_ca(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_ca", SQLCon);
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

        public string Guardar_ca(int nOpcion, E_Categoria oCa)
        {
            string Rpta = "";
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_ca", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = oCa.Codigo_ca;
                Comando.Parameters.Add("@cSigla_ca", SqlDbType.VarChar).Value = oCa.Sigla_ca;
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

        public string Eliminar_ca(int Codigo_ca)
        {
            string Rpta = "";
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_ca", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = Codigo_ca;
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
