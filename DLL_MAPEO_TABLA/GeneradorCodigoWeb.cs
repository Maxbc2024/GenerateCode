
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_MAPEO
{

    public class GeneradorCodigoWeb
    {

       



        //************************************************************************************
        //************************************************************************************
        //*************************** ENTIDAD WEB *******************************************
        //************************************************************************************
        //************************************************************************************


        public StringBuilder Generar_Web_Entidad(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine(" public class " + p_objTabla.Nombre + " {");
            foreach (Columnas objColumnas in p_objTabla.ListarColumnas())
            {
                p_Cadena.AppendLine("    public " + GetTipoDato_x_Columna(objColumnas) + "  " + objColumnas.NombreColumna + "{ get; set; } ");
            }
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        public StringBuilder Generar_Web_EntidadDto(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("public class " + p_objTabla.Nombre + "Dto ");
            p_Cadena.AppendLine("{");
            foreach (Columnas objColumnas in p_objTabla.ListarColumnas())
            {
                p_Cadena.AppendLine("    public " + GetTipoDato_x_Columna(objColumnas) + "  " + objColumnas.NombreColumna + "{ get; set; } ");
            }
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        public StringBuilder Generar_Web_EntidadQueryDto(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("public class " + p_objTabla.Nombre + "QueryDto: IQueryObject");
            p_Cadena.AppendLine("{ ");
            p_Cadena.AppendLine("    public string filterNombre { get; set; } ");
            p_Cadena.AppendLine("    //***************************************************  ");
            p_Cadena.AppendLine("    public string SortBy { get; set; } ");
            p_Cadena.AppendLine("    public bool IsSortAscending { get; set; } ");
            p_Cadena.AppendLine("    public int Page { get; set; } ");
            p_Cadena.AppendLine("    public byte PageSize { get; set; } ");

            p_Cadena.AppendLine("}");
            return p_Cadena;
        }


        //************************************************************************************
        //************************************************************************************
        //*************************** ADMIN WEB **********************************************
        //************************************************************************************
        //************************************************************************************

        public StringBuilder Generar_Web_Admin(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("public class Adm" + p_objTabla.Nombre);
            p_Cadena.AppendLine("{ ");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine(GeneraMetodo_web_ListGrid(p_objTabla).ToString());
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine(GeneraMetodo_web_Register(p_objTabla).ToString());
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine(GeneraMetodo_web_Update(p_objTabla).ToString());
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        private StringBuilder GeneraMetodo_web_ListGrid(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("public async Task<QueryResultDto<" + p_objTabla.Nombre + "Dto>> ListPage" + p_objTabla.Nombre + "Async(" + p_objTabla.Nombre + "QueryDto queryObj)");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("   var result = new QueryResultDto<" + p_objTabla.Nombre  + "Dto>();");
            p_Cadena.AppendLine("   var query = _context." + p_objTabla.Nombre + ".Select(");
            p_Cadena.AppendLine("   x  => new " + p_objTabla.Nombre + "Dto");
            p_Cadena.AppendLine("       {");
            p_Cadena.AppendLine("       }");
            p_Cadena.AppendLine("   )");
            p_Cadena.AppendLine("   .AsQueryable();");
            p_Cadena.AppendLine("");
            // filtro
            p_Cadena.AppendLine("// filtro");
            p_Cadena.AppendLine("if (string.IsNullOrEmpty(queryObj.filterNombre) == false )");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("   query = query.Where(v => v.Nombre.Contains(queryObj.filterNombre) ||");
            p_Cadena.AppendLine("   );");
            p_Cadena.AppendLine("};");
            p_Cadena.AppendLine("");
            // ordenar
            p_Cadena.AppendLine("// Columnas para ordenar ");
            p_Cadena.AppendLine("var columnsMap = new Dictionary<string, Expression<Func<" + p_objTabla.Nombre + "Dto, object>>>()");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("   [" + "\"" + "CodigoUsuario" + "\"" + "] = v => v." + "CodigoUsuario" + ",");
            p_Cadena.AppendLine("};");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("query = query.ApplyOrdering(queryObj, columnsMap);");
            p_Cadena.AppendLine("result.TotalItems = await query.CountAsync();");
            // paginar
            p_Cadena.AppendLine("// paginar");
            p_Cadena.AppendLine("query = query.ApplyPaging(queryObj);");
            p_Cadena.AppendLine("result.Items = await query.ToListAsync();");
            p_Cadena.AppendLine("return result;");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }


        private StringBuilder GeneraMetodo_web_Register(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("public async Task<" + p_objTabla.Nombre + "Dto> Add" + p_objTabla.Nombre + "Async(" + p_objTabla.Nombre + "Dto p_entidadDto)");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        private StringBuilder GeneraMetodo_web_Update(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            return p_Cadena;
        }



        //************************************************************************************
        //************************************************************************************
        //*************************** CONTROLLER WEB *****************************************
        //************************************************************************************
        //************************************************************************************


        public StringBuilder Generar_Web_Controller(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("[ApiController]");
            p_Cadena.AppendLine("[Route("+"\""+"api/[controller]" + "\""+")]");
            p_Cadena.AppendLine("public class "+ p_objTabla.Nombre +"Controller : ControllerBase");
            p_Cadena.AppendLine("{ ");
            p_Cadena.AppendLine("   private readonly AdmPermisos _AdmPermiso;");
            p_Cadena.AppendLine("public " + p_objTabla.Nombre + "Controller(AdmPermisos armazenadorDePermiso)");
            p_Cadena.AppendLine("{ ");
            p_Cadena.AppendLine("   _AdmPermiso = armazenadorDePermiso; ");
            p_Cadena.AppendLine("}");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine(GeneraMetodo_web_controller_ListGrid(p_objTabla).ToString());
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine(GeneraMetodo_web_controller_Register(p_objTabla).ToString());
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        private StringBuilder GeneraMetodo_web_controller_ListGrid(Tabla p_objTabla) 
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("[HttpGet(" + "\"" + "filtrov1" + "\"" + ")]");
            p_Cadena.AppendLine("public async Task<ActionResult> GetPostPage([FromQuery] "+p_objTabla.Nombre+"QueryDto filterResource)");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("   var c = await _Adm" + p_objTabla.Nombre + ".ListPage" + p_objTabla.Nombre + "Async(filterResource);");
            p_Cadena.AppendLine("   return Ok(c);");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }


        private StringBuilder GeneraMetodo_web_controller_Register(Tabla p_objTabla)
        {
            StringBuilder p_Cadena = new StringBuilder();
            p_Cadena.AppendLine("[HttpPost]");
            p_Cadena.AppendLine("public async Task<ActionResult> Register([FromBody] " + p_objTabla.Nombre + "Dto dtoRegister)");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("var result = await _Adm" + p_objTabla.Nombre + ".Add" + p_objTabla.Nombre + "Async(dtoRegister);");
            p_Cadena.AppendLine("if (result == null)");
            p_Cadena.AppendLine("{");
            p_Cadena.AppendLine("return NotFound();");
            p_Cadena.AppendLine("}");
            p_Cadena.AppendLine("return Ok(result);");
            p_Cadena.AppendLine("}");
            return p_Cadena;
        }

        //************************************************************************************
        //************************************************************************************
        //*************************** UTIL *****************************************
        //************************************************************************************
        //************************************************************************************

        #region Util_v2


        public StringBuilder GetTipoDato_x_Columna(Columnas p_objColumna)
        {
            string p_Cadena = "";
            if (p_objColumna.TipoDato.Length > 3)
            {
                p_Cadena = p_objColumna.TipoDato.Substring(0, 4);
            }
            else
            {
                p_Cadena = p_objColumna.TipoDato;
            }
            p_Cadena = p_Cadena.Trim();
            switch (p_Cadena)
            {
                case "char":
                    p_Cadena = consts.TIPO_DATO_CADENA_C;
                    break;
                case "varc":
                    p_Cadena = consts.TIPO_DATO_CADENA_C;
                    break;
                case "deci":
                    p_Cadena = consts.TIPO_DATO_DOUBLE_C + "?";
                    break;
                case "nume":
                    p_Cadena = consts.TIPO_DATO_DOUBLE_C + "?";
                    break;
                case "date":
                    p_Cadena = consts.TIPO_DATO_FECHA_C + "?";
                    break;
                case "int":
                    p_Cadena = consts.TIPO_DATO_ENTERO_C + "?";
                    break;
                case "bit":
                    p_Cadena = consts.TIPO_DATO_BOOLEANO_C + "?";
                    break;
                case "tiny":
                    p_Cadena = consts.TIPO_DATO_ENTERO_PEQUEÑO_C + "?";
                    break;
            }
            StringBuilder p_cad = new StringBuilder(p_Cadena);
            return p_cad;
        }


        #endregion


    }
}
