using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintenanceLibrary;

namespace MaintenanceLibrary
{
    public static class GlobalConfig
    {
        public const string DNS_DB = "SQLDB";
        public const string SP_POSITIONS_GETALL = "Positions_GetAll";
        public const string SP_CONTROLS_GETALL = "Controls_GetAll";
        public const string SP_EMPLOYER_GETALL = "Employer_GetAll";
        public const string SP_EMPLOYER_GET_BY_CODE = "Employer_GetByCode";
        public const string SP_POSITION_GET_BY_CODE = "Positions_GetByCode";
        public const string SP_CONTROL_GET_BY_CODE = "Controls_GetByCode";
        public const string SP_UPDATE_EMPLOYERS = "Employer_Update";
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections()
        {
            SQLConnector sql = new SQLConnector();
            Connection = sql;
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookUp(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
