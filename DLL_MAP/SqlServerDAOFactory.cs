using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_MAP
{
    public class SqlServerDAOFactory : DAOFactory
    {
        public override SqlServerProcedureDAO getProcedureDAO()
        {
            return new SqlServerProcedureDAO();
        }
    
    }
}
