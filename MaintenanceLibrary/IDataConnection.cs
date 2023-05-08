using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintenanceLibrary;

namespace MaintenanceLibrary
{
    public interface IDataConnection
    {
        List<PositionModel> GetPositions();
        List<ControlModel> GetControls();
        List<EmployerModel> GetEmployers();
        void UpdateEmployers(EmployerModel model);
    }
}
