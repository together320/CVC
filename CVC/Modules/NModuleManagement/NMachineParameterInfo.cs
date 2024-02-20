using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.NModuleManagement
{
    public class NMachineParameterInfo
    {
        public int MachineParameterId { get; set; }
        public string ParameterName { get; set; }
        public string ColumnName { get; set; }
        public int PickListId { get; set; }
    }
}