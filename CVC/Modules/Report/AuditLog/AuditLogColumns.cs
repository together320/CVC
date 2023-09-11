// Decompiled with JetBrains decompiler
// Type: CVC.Report.Columns.AuditLogColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Batch.Entities;
using CVC.MachineCustomization.Entities;
using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Report.Columns
{
    [ColumnsScript("Report.AuditLog")]
    [BasedOnRow(typeof(AuditLogRow))]
  //  [LookupEditor(typeof(MachineCustomization.Scripts.MachineLookUp))]

    public class AuditLogColumns
    {
        //[EditLink]
        [DisplayName("Db.Shared.RecordId")]
        [AlignRight]
        public long AuditLogId { get; set; }

        [DisplayName("User Name")]
        [QuickFilter]
        [LookupEditor(typeof(UserRow))]
        public string UserEmployeeId { get; set; }

        //[EditLink]
        
        [DisplayName("User")]
       // [QuickFilter]
       // [LookupEditor(typeof(UserRow))]
        public string UserName { get; set; }

        public string Action { get; set; }

        [SortOrder(1, descending: true)]
        //[DisplayFormat("dd/MM/yyyy H:mm:ss")]
        [CustomDisplayFormatAttribute("")]
        [QuickFilter]
        public DateTime ChangedOn { get; set; }

        public string TableName { get; set; }

        public int RowId { get; set; }

        public string Module { get; set; }

        public string Page { get; set; }

        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public string Comments { get; set; }

        //public string PcipAddress { get; set; }



        //public string BatchName { get; set; }
       
        [DisplayName("Entity Name")]
        [QuickFilter(true)]
        
        [LookupEditor(typeof(MachineCustomization.Scripts.MachineLookUp))]
     // [LookupEditor(typeof(MachineRow),FilterField = "isactive", FilterValue =true)]

        public string MachineMachineName { get; set; }

        [QuickFilter]
        [DisplayName("Batch Number")]
        [LookupEditor(typeof(BatchRow))]
        public string BatchBatchName { get; set; }

        //public string MachineName { get; set; }
    }
}
