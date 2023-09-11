
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using CVC.Configuration.Entities;
    using CVC.MachineCustomization.Scripts;
    using CVC.MachineCustomization.Entities;

    [FormScript("MachineCustomization.DisplayObject")]
    [BasedOnRow(typeof(Entities.DisplayObjectRow))]
    public class DisplayObjectForm
    {
        //public Int32 ModuleId { get; set; }
        public String ViewName { get; set; }
        [LookupEditor(typeof(MachineRow))]
        public Int32 MachineId { get; set; }
        //public Boolean IsAccessFieldWise { get; set; }
        //[LookupEditor(typeof(DisplayObjectTypesLookup))]
        public Int32 DisplayObjectTypeId { get; set; }
        [LookupEditor(typeof(StatusRow))]
        public Int32 StatusId { get; set; }
        // added by Denis for RS 6.5 dated 8/6/2021
        [LookupEditor(typeof(ListDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 ListDisplayId { get; set; }
        // added by Denis for RS 6.5 dated 8/6/2021
        [LookupEditor(typeof(FormDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 FormDisplayId { get; set; }
        [LookupEditor(typeof(ButtonDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 ButtonDisplayId { get; set; }
        [LookupEditor(typeof(RealtimeParameterDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 RealtimeParameterDisplayId { get; set; }
        [LookupEditor(typeof(LineChartDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 LineChartDisplayId { get; set; }
        [LookupEditor(typeof(PieChartDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 PieChartDisplayId { get; set; }
        [LookupEditor(typeof(TreeDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 TreeDisplayId { get; set; }
        [LookupEditor(typeof(AttachmentDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 AttachmentDisplayId { get; set; }
        [LookupEditor(typeof(AlarmDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 AlarmDisplayId { get; set; }
        [LookupEditor(typeof(NotificationDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 NotificationDisplayId { get; set; }
        [LookupEditor(typeof(ContainerDisplayRow), InplaceAdd = true)]
        [Visible(false)]
        public Int32 ContainerDisplayId { get; set; }
        //public List<Entities.ListDisplayRow> DisplayObjectDetails { get; set; }
        [Visible(false)]
        public Int32 CreatedBy { get; set; }
        [Visible(false)]
        public DateTime CreatedDate { get; set; }
        [Visible(false)]
        public Int32 UpdatedBy { get; set; }
        [Visible(false)]
        public DateTime UpdatedDate { get; set; }
        //public Boolean IsMachineSettings { get; set; }
        //public Boolean IsMachineSummary { get; set; }
        //public Boolean IslabelRoll { get; set; }
        //public Boolean IsCommandPanel { get; set; }
        //public Boolean IsFactorySetting { get; set; }
    }
}