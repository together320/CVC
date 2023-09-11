// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Columns.ViewFieldColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.ModuleManagement.Columns
{
    [ColumnsScript("ModuleManagement.ViewField")]
    [BasedOnRow(typeof(ViewFieldRow))]
    public class ViewFieldColumns
    {
        [EditLink]
        [DisplayName("Db.Shared.RecordId")]
        [AlignRight]
        public int ViewField { get; set; }

        [QuickFilter]
        [LookupEditor(typeof(ViewsRow))]
        public string ViewsViewName { get; set; }

        [EditLink]
        public string ViewFieldName { get; set; }

        public string MachineParameterMachineParameterName { get; set; }

        public string StatusStatusName { get; set; }

        //public string CreatedByEmployeeId { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public string UpdatedByEmployeeId { get; set; }

        //public DateTime UpdatedDate { get; set; }
    }
}
