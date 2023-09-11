
namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MachineCustomization.DisplayObjectField")]
    [BasedOnRow(typeof(Entities.DisplayObjectFieldRow), CheckNames = true)]
    public class DisplayObjectFieldColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ViewField { get; set; }
        [EditLink]
        public String ViewFieldName { get; set; }
        [QuickFilter]
        public String ViewsViewName { get; set; }
        public String MachineParameterParameterName { get; set; }
        //public Int32 MachineName { get; set; }
        public Int32 Sequence { get; set; }
        public String StatusStatusName { get; set; }
        public String CreatedByUsername { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedByUsername { get; set; }
        public DateTime UpdatedDate { get; set; }
        
        
        //public Boolean IsPopUpRequired { get; set; }
        //public Boolean IsCommentRequired { get; set; }
        //public Boolean IsAuthenticationRequired { get; set; }
        //public String ModuleModuleName { get; set; }
    }
}