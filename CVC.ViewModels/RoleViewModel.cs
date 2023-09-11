using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string ParentRole { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<bool> IsHidden { get; set; }
        public Nullable<int> ParentRoleId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public List<RoleViewModel> lstRoleViewModel { get; set; }
        public bool IsStatus { get; set; }
        public string StatusMessage { get; set; }


    }
}
