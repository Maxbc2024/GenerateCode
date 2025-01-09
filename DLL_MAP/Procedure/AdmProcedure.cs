using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_MAP
{

    public class AdmProcedure
    {

        public AdmProcedure() 
        {
           
        }


        public List<Procedure> getProcedures()
        {
            DAOFactory objDAOFactory = DAOFactory.getDAOFactory(DAOFactory.SQLSERVER);
            SqlServerProcedureDAO objSqlServerProcedureDAO = objDAOFactory.getProcedureDAO();
            return objSqlServerProcedureDAO.ListarProcedure();
        }

        public List<ProcedureColumnas> getColumns_x_procedure(string p_NameProcedure)
        {
            DAOFactory objDAOFactory = DAOFactory.getDAOFactory(DAOFactory.SQLSERVER);
            SqlServerProcedureDAO objSqlServerProcedureDAO = objDAOFactory.getProcedureDAO();
            return objSqlServerProcedureDAO.ListarColumnasProcedure(p_NameProcedure);
        }

    }

}
