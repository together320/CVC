
using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using CVC.MachineCustomization.Entities;
using CVC.Batch.Entities;
using System.Configuration;

namespace CVC.Report.Columns
{
    [ColumnsScript("Report.AlarmLogArchive")]
    [BasedOnRow(typeof(AlarmLogArchiveRow))]
    public class AlarmLogArchiveColumns
    {
        [DisplayName("Db.Shared.RecordId")]
        [AlignRight]
        public long AlarmLogArchiveId { get; set; }

        public string AlarmAlarmName { get; set; }

        [DisplayName("Entity Name")]
        [QuickFilter]
        [LookupEditor(typeof(MachineRow))]
        public string MachineMachineName { get; set; }

        [QuickFilter]
        [DisplayName("Batch Name")]
        [LookupEditor(typeof(BatchRow))]
        public string BatchBatchName { get; set; }

        [SortOrder(1, descending: true)]
        // [DisplayFormat("dd/MM/yyyy H:mm:ss")]
        // [CustomDisplayFormatAttribute("")]
        [QuickFilter]
        public DateTime AlarmDateTime { get; set; }

        // public string PcipAddress { get; set; }
    }

    //public class CustomDisplayFormatAttribute : DisplayFormatAttribute
    //{
    //    public CustomDisplayFormatAttribute(string value)
    //        : base(GetMessageFromResource(value))
    //    { }

    //    private static string GetMessageFromResource(string value)
    //    {
    //        return ConfigurationManager.AppSettings["DateFormat"].ToString();
    //    }
    //}
}
