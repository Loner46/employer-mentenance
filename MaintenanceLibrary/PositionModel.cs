using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceLibrary
{
    public class PositionModel
    {
        public int CD職位 { get; set; }
        public string NM職位 { get; set; }
        public string KB管理 { get; set; }

        public string 職位
        {
            get
            {
                return $"{ CD職位 } : { NM職位 }";
            }
        }

    }
}
