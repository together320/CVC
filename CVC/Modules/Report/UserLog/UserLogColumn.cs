using CVC.Administration.Entities;
using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Report.Columns
{

    [ColumnsScript("Report.UserLog")]
    [BasedOnRow(typeof(UserLogRow))]
    public class UserLogColumn
    {

        //[EditLink]
        //[DisplayName("Db.Shared.RecordId")]
       // [AlignRight]
        public long UserLogId { get; set; }

        [DisplayName("User")]
        [QuickFilter]
        [LookupEditor(typeof(UserRow))]
        public int UserId { get; set; }

        //[QuickFilter]
        public string UserName { get; set; }

        [QuickFilter]
        public string Action { get; set; }

        [SortOrder(1, descending: true)]
        //[DisplayFormat("dd/MM/yyyy H:mm:ss")]
        [CustomDisplayFormatAttribute("")]
        [QuickFilter]
        public DateTime ChangedOn { get; set; }
    }
}