
using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Report.Forms
{
    [FormScript("Report.AuditLogArchive")]
    [BasedOnRow(typeof(AuditLogArchiveRow))]
    public class AuditLogArchiveForm
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Action { get; set; }

        public DateTime ChangedOn { get; set; }

        public string TableName { get; set; }

        public int RowId { get; set; }

        public string Module { get; set; }

        public string Page { get; set; }

        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public string Comments { get; set; }

        public string PcipAddress { get; set; }

        public int BatchId { get; set; }

        public string BatchName { get; set; }

        public int MachineId { get; set; }

        public string MachineName { get; set; }
    }
}
