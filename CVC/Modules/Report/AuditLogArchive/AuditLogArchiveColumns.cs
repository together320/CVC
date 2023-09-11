
using CVC.Administration.Entities;
using CVC.Batch.Entities;
using CVC.MachineCustomization.Entities;
using CVC.Report.Entities;
using CVC.Report.Forms;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using CVC.Modules.Common.CommonServices;
using CVC.Modules.Common;
using System.ComponentModel.DataAnnotations;

namespace CVC.Report.Columns
{
    [ColumnsScript("Report.AuditLogArchive")]
    [BasedOnRow(typeof(AuditLogArchiveRow))]
    public class AuditLogArchiveColumns
    {

        //[EditLink]
        [DisplayName("Db.Shared.RecordId")]
        [AlignRight]
        public long AuditLogArchiveId { get; set; }

        public string UserEmployeeId { get; set; }

        [DisplayName("User Name")]
        [QuickFilter]
        [LookupEditor(typeof(UserRow))]
        public string UserName { get; set; }

        public string Action { get; set; }

        [SortOrder(1, descending: true)]
        [QuickFilter]
     
        [CustomDisplayFormatAttribute("")]
        public DateTime ChangedOn { get; set; }

        public string TableName { get; set; }

        public int RowId { get; set; }

        public string Module { get; set; }

        public string Page { get; set; }

        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public string Comments { get; set; }

        [DisplayName("Entity Name")]
        [QuickFilter]
        [LookupEditor(typeof(MachineRow))]
        public string MachineMachineName { get; set; }

        [QuickFilter]
        [DisplayName("Batch Name")]
        [LookupEditor(typeof(BatchRow))]
        public string BatchBatchName { get; set; }

    }
    
}
