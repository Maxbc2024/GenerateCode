using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DLL_MAP
{
    public class SqlServerProcedureDAO
    {

        public List<Procedure> ListarProcedure()
        {
            SqlDataReader reader;
            SqlConnection cnx = SqlHelper.Conectar();
            String sql = " SELECT name FROM dbo.sysobjects WHERE (type = 'P') ORDER BY name ";

            Procedure objEntidad;
            List<Procedure> ListadoProcedure = new List<Procedure>();
            try
            {
                //SqlParameter[] arParms = new SqlParameter[1];
                //arParms[0] = new SqlParameter("@VCodVend", SqlDbType.Char);
                //arParms[0].Value = P_CodigoVendedor;

                reader = SqlHelper.ExecuteReader(cnx, CommandType.Text, sql);
                while (reader.Read())
                {
                    objEntidad = new Procedure();
                    objEntidad.nombre = Convert.ToString(reader["name"].Equals(System.DBNull.Value) ? "" : reader["name"]);
                    ListadoProcedure.Add(objEntidad);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }
            return ListadoProcedure;
        }


        public List<ProcedureColumnas> ListarColumnasProcedure(string p_NameProcedure)
        {
            SqlDataReader reader;
            SqlConnection cnx = SqlHelper.Conectar();
            String sql = "exec sp_describe_first_result_set N'" + p_NameProcedure + "'";

            ProcedureColumnas objEntidad;
            List<ProcedureColumnas> ListadoProcedureTabla = new List<ProcedureColumnas>();
            try
            {
                //SqlParameter[] arParms = new SqlParameter[1];
                //arParms[0] = new SqlParameter("@VCodVend", SqlDbType.Char);
                //arParms[0].Value = P_CodigoVendedor;

                reader = SqlHelper.ExecuteReader(cnx, CommandType.Text, sql);
                while (reader.Read())
                {
                    objEntidad = new ProcedureColumnas();
                    objEntidad.NombreColumna = Convert.ToString(reader["name"].Equals(System.DBNull.Value) ? "" : reader["name"]);
                    objEntidad.TipoDatoColumna = Convert.ToString(reader["system_type_name"].Equals(System.DBNull.Value) ? "" : reader["system_type_name"]);
                    ListadoProcedureTabla.Add(objEntidad);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }
            return ListadoProcedureTabla;

        }
    }
}
