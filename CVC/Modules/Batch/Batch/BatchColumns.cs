// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.BatchColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Batch.Columns
{
    [ColumnsScript("Batch.Batch")]
    [BasedOnRow(typeof(BatchRow1))]
    public class BatchColumns
    {
        [SortOrder(2, descending: true)]
        public string BatchName { get; set; }
        [Report.Columns.CustomDisplayFormatAttribute("")]

        public DateTime BatchStartDateTime { get; set; }
        [Report.Columns.CustomDisplayFormatAttribute("")]
        public DateTime BatchEndDateTime { get; set; }

        public string BatchStatus { get; set; }

        public int BatchSize { get; set; }

        public int NumberOfBottles { get; set; }
        [Report.Columns.CustomDisplayFormatAttribute("")]

        public DateTime ExpiryDate { get; set; }
        [SortOrder(3)]
        public string BatchVersion { get; set; }
        public string Comments { get; set; }
        public string RepackStatus { get; set; }
        public string BatchLatestVersion { get; set; }
        [Report.Columns.CustomDisplayFormatAttribute("")]
        [SortOrder(1, descending: true)]
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

    }
}
