using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceLibrary
{
    public class EmployerModel
    {
        public string NO社員 { get; set; }
        public string NM社員 { get; set; }
        public PositionModel 職位 { get; set; }
        public string DA入社 { get; set; }
        public string DA生年月日 { get; set; }
        public ControlModel 所属 { get; set; }

        //public EmployerModel(string no, string name, PositionModel position, string enteredDate, string birthDate, ControlModel control)
        //{
        //    NO社員 = no;
        //    NM社員 = name;
        //    職位 = position;
        //    DA入社 = enteredDate;
        //    DA生年月日 = birthDate;
        //    所属 = control;
        //}
    }
}
