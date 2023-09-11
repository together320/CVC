
using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Report.Forms
{
    [FormScript("Report.AlarmLogArchive")]
    [BasedOnRow(typeof(AlarmLogArchiveRow))]
    public class AlarmLogArchiveForm
    {
        public int MachineId { get; set; }

        public int AlarmId { get; set; }

        public int BatchId { get; set; }

        public int LoggedUserId { get; set; }

        public string Comment { get; set; }

        public string Description { get; set; }

        public DateTime AlarmDateTime { get; set; }

        public string PcipAddress { get; set; }
    }
}
