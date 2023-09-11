// Decompiled with JetBrains decompiler
// Type: CVC.Report.Columns.AlarmLogColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using CVC.MachineCustomization.Entities;
using CVC.Batch.Entities;
using System.Configuration;

namespace CVC.Report.Columns
{
    [ColumnsScript("Report.AlarmLog")]
    [BasedOnRow(typeof(AlarmLogRow))]
    public class AlarmLogColumns
    {
        //[EditLink]
        [DisplayName("Db.Shared.RecordId")]
        //[AlignRight]
        public long AlarmLogId { get; set; }

        //public int MachineId { get; set; }

        //public int AlarmId { get; set; }

        //public int BatchId { get; set; }

        //public int LoggedUserId { get; set; }

        //[EditLink]
        //public string Comment { get; set; }

        //public string Description { get; set; }

        public string AlarmAlarmName { get; set; }

      
        [DisplayName("Entity Name")]
        [QuickFilter]
        [LookupEditor(typeof(MachineRow))]
       // [LookupEditor(typeof(MachineRow), CascadeField = "StatusId", CascadeValue = "1")]

        public string MachineMachineName { get; set; }

        [QuickFilter]
        [DisplayName("Batch Number")]
        [LookupEditor(typeof(BatchRow))]
        public string BatchBatchName { get; set; }

        [SortOrder(1, descending: true)]
        //[DisplayFormat("dd/MM/yyyy H:mm:ss")]
        [CustomDisplayFormatAttribute("")]
        [QuickFilter]
        public DateTime AlarmDateTime { get; set; }

        // public string PcipAddress { get; set; }
    }

    public class CustomDisplayFormatAttribute : DisplayFormatAttribute
    {
        public CustomDisplayFormatAttribute(string value)
            : base(GetMessageFromResource(value))
        { }

        private static string GetMessageFromResource(string value)
        {
            return ConfigurationManager.AppSettings["DateFormat"].ToString();
        }
    }
}
