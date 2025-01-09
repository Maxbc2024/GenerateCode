using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DLL_MAPEO;
using DLL_MAP;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AdministradorTablas objAdministradorTablas1 = new AdministradorTablas();
        private AdmProcedure objAdmProcedure = new AdmProcedure();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            this.cmbTablasBD.DataSource = objAdministradorTablas1.ListarTabla();
            this.cmbTablasBD.DisplayMember="Nombre";
            this.cmbTablasBD.ValueMember = "Id";


            this.cmbProcedures.DataSource = objAdmProcedure.getProcedures();
            this.cmbProcedures.DisplayMember = "nombre";
            this.cmbProcedures.ValueMember = "nombre";
            
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StringBuilder p_Impresion = new StringBuilder();
            GeneradorCodigo objGeneradorCodigo= new GeneradorCodigo();
            GeneradorCodigoWeb objGeneradorCodigoWeb = new GeneradorCodigoWeb();
            Tabla objTabla = new Tabla(Convert.ToString(this.cmbTablasBD.SelectedValue));

            ///-------------------------
            //string p_nameProcedure = Convert.ToString(this.cmbProcedures.SelectedValue);
            string p_nameProcedure = "ListarTodoTipoPieza";
            GeneradorCodigoMap objGeneradorCodigoMap = new GeneradorCodigoMap();


            ///-------------------------
            consts.TIPO_BASE_DATOS p_TIPO_BASE_DATOS =  consts.TIPO_BASE_DATOS.SQL_SERVER;

            switch (this.treeView1.SelectedNode.Name) 
            {
                case "BeanEntidad":
                    p_Impresion = objGeneradorCodigo.GenerarEntidades(objTabla);
                    break;
                case "InterfaceDao":
                    p_Impresion = objGeneradorCodigo.InterfaceDAO(objTabla);
                    break; 
                case "SqlServer_Tabla_Dao":
                    p_Impresion = objGeneradorCodigo.SqlServer_Tabla_DAO(objTabla);
                    break;
                case "ClaseNegocio":
                    p_Impresion = objGeneradorCodigo.Clase_Negocio(objTabla, objTabla);
                    break;
                case "MantenimientoGUI":
                    p_Impresion = objGeneradorCodigo.Clase_GUI_Mantenimiento(objTabla);
                    break;
                case "MantenimientoProcedure":
                    p_Impresion = objGeneradorCodigo.Clase_GUI_Mantenimiento_Procedure(objTabla, p_TIPO_BASE_DATOS);
                    break;
                //******************************************************************************
                //****************************** ESTADOV2 ********************************
                //******************************************************************************
                case "InterfaceDaoEstadoV2":
                    p_Impresion = objGeneradorCodigo.InterfaceDAO_EstadoV2(objTabla);
                    break;
                case "SqlServer_Tabla_DaoEstadoV2":
                    p_Impresion = objGeneradorCodigo.SqlServer_Tabla_DAO_EstadoV2(objTabla);
                    break;
                case "ClaseNegocioEstadoV2":
                    p_Impresion = objGeneradorCodigo.Clase_Negocio_EstadoV2(objTabla);
                    break;
                case "MantenimientoGUIEstadoV2":
                    p_Impresion = objGeneradorCodigo.Clase_GUI_Mantenimiento_EstadoV2(objTabla);
                    break;
                //******************************************************************************
                //****************************** V3 SIN BEAN ***********************************
                //******************************************************************************
                case "EntidadV3":
                    p_Impresion = objGeneradorCodigo.GenerarEntidades_EstadoV2(objTabla);
                    break;
                case "DaoV3":
                    p_Impresion = objGeneradorCodigo.InterfaceDAO_V3(objTabla);
                    break;
                case "SqlServer_Tabla_DaoV3":
                    p_Impresion = objGeneradorCodigo.SqlServer_Tabla_DAO_V3(objTabla);
                    break;
                case "ClaseNegocioV3":
                    p_Impresion = objGeneradorCodigo.Clase_Negocio_V3(objTabla);
                    break;
                //******************************************************************************
                //****************************** WEB CONTROLLER ********************************
                //******************************************************************************
                case "EntidadWeb":
                    p_Impresion = objGeneradorCodigoWeb.Generar_Web_Entidad(objTabla);
                    break;
                case "EntidadDto":
                    p_Impresion = objGeneradorCodigoWeb.Generar_Web_EntidadDto(objTabla);
                    break;
                case "EntidadQueryDto":
                    p_Impresion = objGeneradorCodigoWeb.Generar_Web_EntidadQueryDto(objTabla);
                    break;
                    //*** Negocio
                case "Admin":
                    p_Impresion = objGeneradorCodigoWeb.Generar_Web_Admin(objTabla);
                    break;
                    //*** controller
                case "Controller":
                    p_Impresion = objGeneradorCodigoWeb.Generar_Web_Controller(objTabla);
                    break;
                default:
                    break;
                //******************************************************************************
                //****************************** GUI *******************************************
                //******************************************************************************
                case "CrearTable":
                    p_Impresion = objGeneradorCodigo.Clase_GUI_CrearTable(objTabla);
                    break;
                case "CrearGrid":
                    p_Impresion = objGeneradorCodigo.Clase_GUI_CrearGrid(objTabla);
                    break;
                //************** procedure
                case "CrearTableProcedure":
                    p_Impresion = objGeneradorCodigoMap.Clase_GUI_CrearTable_PROCEDURE(objAdmProcedure.getColumns_x_procedure(p_nameProcedure), objGeneradorCodigo.ConvertirTipoDatoSQLTO_C);
                    break;

                    
            }
            this.richTextBox1.Text = p_Impresion.ToString();
        }



    }
}
