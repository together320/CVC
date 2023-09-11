using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{
    public class ArchivalViewModel
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string EndDate { get; set; }
        public int StatusId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string Type { get; set; }
        public string DeleteTableName { get; set; }
        public string FileName { get; set; }
        public string InsertTableName { get; set; }
        public string TruncateTableName { get; set; }


    }
}
