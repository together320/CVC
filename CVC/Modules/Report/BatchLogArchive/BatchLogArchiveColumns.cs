// Decompiled with JetBrains decompiler
// Type: CVC.Report.Columns.BatchLogColumns

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Report.Columns
{
    [ColumnsScript("Report.BatchLogArchive")]
    [BasedOnRow(typeof(BatchLogArchiveRow))]
    public class BatchLogArchiveColumns
    {
        [EditLink]
        [DisplayName("Db.Shared.RecordId")]
        [AlignRight]
        public long BatchLogArchiveId { get; set; }

        public int MachineId { get; set; }

        public int BatchId { get; set; }

        [EditLink]
        public string Description { get; set; }

        public int UserId { get; set; }
        [CustomDisplayFormatAttribute("")]
        public DateTime UpdatedDateTime { get; set; }
    }
}
