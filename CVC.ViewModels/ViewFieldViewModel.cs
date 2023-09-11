using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class ViewFieldViewModel
    {
        public Nullable<int> ViewsId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> ViewFieldId { get; set; }
        public string ViewFieldName { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> MachineParameterId { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsModify { get; set; }
        public string StatusName { get; set; }
    }
}
