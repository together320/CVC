using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using CVC.MachineCustomization.Entities;
using CVC.Batch.Entities;
using System.Configuration;

namespace CVC.Report.Columns
{

    [ColumnsScript("Report.ExceptionLog")]
    [BasedOnRow(typeof(ExceptionLogRow))]
    public class ExceptionLogColumn
    {
        public  long Id { get; set; }

        public string ApplicationName { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public string Message { get; set; }

        [SortOrder(1, descending: true)]
        //[DisplayFormat("dd/MM/yyyy H:mm:ss")]
        [CustomDisplayFormatAttribute("")]
        [QuickFilter]
        public DateTime CreationDate { get; set; }

    }
}