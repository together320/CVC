using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.NModuleManagement
{
    public class NModuleColumns
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string MachineMachineName { get; set; }
        public string StatusStatusName { get; set; }
        public int MachineId { get; set; }
        public int? Sequence { get; set; }
    }
}