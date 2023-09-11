using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class ModuleAccessViewModel
    {
        public int ModuleAccessId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<bool> IsAccess { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string[] ModuleIds { get; set; }
        public string[] ActiveStatusIds { get; set; }
        public string RoleName { get; set; }
        public List<ModuleViewModel> lstModuleViewModel { get; set; }
       // public Dictionary<int, int>[] DctnryModuleIdStatusId { get; set; }
    }
}
