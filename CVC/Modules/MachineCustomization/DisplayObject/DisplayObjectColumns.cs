
namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MachineCustomization.DisplayObject")]
    [BasedOnRow(typeof(Entities.DisplayObjectRow))]
    public class DisplayObjectColumns
    {
        [SortOrder(1, descending: true)]
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ViewsId { get; set; }
        //public String ModuleModuleName { get; set; }
        [EditLink]
        public String ViewName { get; set; }
        public String MachineMachineName { get; set; }
        //public Boolean IsAccessFieldWise { get; set; }
        //public String DisplayObjectTypeDoName { get; set; }
        public Int32 DisplayObjectTypeId { get; set; }
        public String DisplayObjectStyle { get; set; }
        public String StatusStatusName { get; set; }
        public String CreatedByUsername { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedByUsername { get; set; }
        public DateTime UpdatedDate { get; set; }
        //public Boolean IsMachineSettings { get; set; }
        //public Boolean IsMachineSummary { get; set; }
        //public Boolean IslabelRoll { get; set; }
        //public Boolean IsCommandPanel { get; set; }
        //public Boolean IsFactorySetting { get; set; }
        public String ListDisplayName { get; set; }
        public String FormDisplayName { get; set; }
        public String ButtonDisplayName { get; set; }
        public String RealtimeParameterDisplayName { get; set; }
        public String LineChartDisplayName { get; set; }
        public String PieChartDisplayName { get; set; }
        public String TreeDisplayName { get; set; }
        public String AttachmentDisplayName { get; set; }
        public String AlarmDisplayName { get; set; }
        public String NotificationDisplayName { get; set; }
        public String ContainerDisplayName { get; set; }

    }
}