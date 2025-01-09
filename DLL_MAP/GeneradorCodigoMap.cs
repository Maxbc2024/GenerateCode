using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_MAP
{

    public class GeneradorCodigoMap
    {


        public StringBuilder Clase_GUI_CrearTable_PROCEDURE(List<ProcedureColumnas> p_NameColumnasProcedure, Func<string, StringBuilder> p_ConvertirTipoDatoSQLTO_C)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("private void CrearTabla_" + "MyTabla" + "()");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("       private DataTable dt" + "Data" + " = new DataTable();"); 
            p_Cadena.AppendLine("");
            foreach (ProcedureColumnas objColumnas in p_NameColumnasProcedure)
            {
                p_Cadena.AppendLine("       dt" + objColumnas.NombreColumna + ".Columns.Add(" + "\"" + objColumnas.NombreColumna + "\"" + ",typeof(" + p_ConvertirTipoDatoSQLTO_C(objColumnas.TipoDatoColumna) + "));");
            }
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

    }

}
