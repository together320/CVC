using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class ModuleViewModel
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string MachineName { get; set; }
        public string StatusName { get; set; }
        public int? StatusId { get; set; }
        public bool? IsAccess { get; set; }
        public int RoleId { get; set; }


    }
}
