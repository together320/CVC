using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Report.Forms
{
    [FormScript("Report.ExceptionLog")]
    [BasedOnRow(typeof(ExceptionLogRow))]
    public class ExceptionLogForm
    {
        public long Id { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public string Message { get; set; }
    }
}