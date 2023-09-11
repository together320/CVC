
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MachineCustomization.DisplayObjectField")]
    [BasedOnRow(typeof(Entities.DisplayObjectFieldRow), CheckNames = true)]
    public class DisplayObjectFieldForm
    {
        public String ViewFieldName { get; set; }
        public Int32 ViewsId { get; set; }
        public Int32 MachineParameterId { get; set; }
        public Int32 Sequence { get; set; }
        public Int32 StatusId { get; set; }
        //public Int32 CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public Int32 UpdatedBy { get; set; }
        //public DateTime UpdatedDate { get; set; }
        public Boolean IsPopUpRequired { get; set; }
        public Boolean IsCommentRequired { get; set; }
        [HalfWidth]
        public Boolean IsAuthenticationRequired { get; set; }
        [HalfWidth]
        public Boolean IsSelectAllRoles { get; set; }
        public List<Int32> Roles { get; set; }
        //public Int32 ModuleId { get; set; }
    }
}