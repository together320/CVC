﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class ViewAccessViewModel
    {
        public int ViewsAccessId { get; set; }
        public Nullable<int> ViewsId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsModify { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string[] IsViewIds { get; set; }
        public string[] IsModifyIds { get; set; }
        public List<ViewsViewModel> lstViewsViewModel { get; set; }
    }
}
