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
            p_Cadena.AppendLine("       private DataTable dtData = new DataTable();"); 
            foreach (ProcedureColumnas objColumnas in p_NameColumnasProcedure)
            {
                p_Cadena.AppendLine("       dtData.Columns.Add(" + "\"" + objColumnas.NombreColumna + "\"" + ",typeof(" + p_ConvertirTipoDatoSQLTO_C(objColumnas.TipoDatoColumna) + "));");
            }
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        public StringBuilder Clase_GUI_CrearGrid_PROCEDURE(List<ProcedureColumnas> p_NameColumnasProcedure, Func<string, StringBuilder> p_ConvertirTipoDatoSQLTO_C)
        {
            
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("private void CargarGridMyTabla(){");
            p_Cadena.AppendLine(" dtData.Rows.Clear();");
            p_Cadena.AppendLine(" foreach (data" + " objData in obj" + ".ListarTodos())");
            p_Cadena.AppendLine(" {");
            p_Cadena.AppendLine("         DataRow dtw = dtData.NewRow();");
            p_Cadena.AppendLine("         dtw[" + "\"" + "Id" + "\"" + "] = objData.Id;");
            foreach (ProcedureColumnas objColumnas in p_NameColumnasProcedure)
            {
                p_Cadena.AppendLine("         dtw[" + "\"" + objColumnas.NombreColumna + "\"" + "] = objData." + objColumnas.NombreColumna + ";");
            }
            p_Cadena.AppendLine("         dtData.Rows.Add(dtw);");
            p_Cadena.AppendLine("}");
            p_Cadena.AppendLine("this.grvListado.DataSource = dtData;");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }



        public StringBuilder GenerarEntidadResult_ResultadoProcedure(List<ProcedureColumnas> p_NameColumnasProcedure, Func<string, StringBuilder> ConvertirTipoDatoSQLTO_C)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine(" public class " + "MyClass" + "Dto");
            p_Cadena.AppendLine("{");
            foreach (ProcedureColumnas objColumnas in p_NameColumnasProcedure)
            {
                p_Cadena.AppendLine("    public " + ConvertirTipoDatoSQLTO_C(objColumnas.TipoDatoColumna) + "  " + objColumnas.NombreColumna + "{ get; set; } ");
            }
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }


    }

}
