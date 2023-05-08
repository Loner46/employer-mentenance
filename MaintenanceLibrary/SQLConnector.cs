using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MaintenanceLibrary;
using static MaintenanceLibrary.GlobalConfig;

namespace MaintenanceLibrary
{
    public class SQLConnector : IDataConnection
    {
        public List<ControlModel> GetControls()
        {
            List<ControlModel> output = new List<ControlModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString(DNS_DB)))
            {
                output = connection.Query<ControlModel>(SP_CONTROLS_GETALL).ToList();
            }
            return output;
        }

        public List<EmployerModel> GetEmployers()
        {
            List<EmployerModel> output = new List<EmployerModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString(DNS_DB)))
            {
                output = connection.Query<EmployerModel>(SP_EMPLOYER_GETALL).ToList();
                foreach (EmployerModel employer in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@NO社員", employer.NO社員);
                    employer.所属 = connection.Query<ControlModel>(SP_CONTROL_GET_BY_CODE, p, commandType: CommandType.StoredProcedure).First();

                    p = new DynamicParameters();
                    p.Add("@NO社員", employer.NO社員);
                    employer.職位 = connection.Query<PositionModel>(SP_POSITION_GET_BY_CODE, p, commandType: CommandType.StoredProcedure).First();
                }
            }
            return output;
        }

        public List<PositionModel> GetPositions()
        {
            List<PositionModel> output = new List<PositionModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString(DNS_DB)))
            {
                output = connection.Query<PositionModel>(SP_POSITIONS_GETALL).ToList();
            }
            return output;
        }

        public void UpdateEmployers(EmployerModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString(DNS_DB)))
            {
                var p = new DynamicParameters();
                p.Add("@NO社員", model.NO社員);
                p.Add("@NM社員", model.NM社員);

                if (model.職位 != null)
                {
                    p.Add("@CD職位", model.職位.CD職位);
                }
                else
                {
                    p.Add("@CD職位", null);
                }
                p.Add("@DA入社", model.DA入社);
                p.Add("@DA生年月日", model.DA生年月日);
                if (model.所属 != null)
                {
                    p.Add("@CD所属", model.所属.CD所属);
                }
                else
                {
                    p.Add("@CD所属", null);
                }
                connection.Execute(SP_UPDATE_EMPLOYERS, p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
