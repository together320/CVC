using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class ViewsViewModel
    {
        public int ViewsId { get; set; }
        public int RoleId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string ViewName { get; set; }
        public Nullable<bool> IsAccessFieldWise { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsMachineSettings { get; set; }
        public Nullable<bool> IsMachineSummary { get; set; }
        public Nullable<bool> IslabelRoll { get; set; }
        public Nullable<bool> IsCommandPanel { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsModify { get; set; }
        public string StatusName { get; set; }

    }
}
