using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.NModuleManagement
{
    public class CommonMM_Model
    {
    }

    public class MachineInfo
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
    }
    public class StatusInfo
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}