using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceLibrary
{
    public class ControlModel
    {
        public int CD所属 { get; set; }
        public string NM所属 { get; set; }
        public int CD支社 { get; set; }

        public string 所属
        {
            get
            {
                return $"{ CD所属 } : { NM所属 }";
            }
        }

    }
}
