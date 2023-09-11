using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CVC.Modules.NModuleManagement
{
    public class NViewsForm
    {
        [Required]
        public string ViewName { get; set; }
        public int ViewsId { get; set; }
        //[LookupEditor(typeof(ModuleRow))]
        [Required]
        public int ModuleId { get; set; }
        //public short IsAccessFieldWise { get; set; }
        //[LookupEditor(typeof(StatusRow))]
        [Required]
        public int StatusId { get; set; }
        [DisplayName("Is Machine Settings")]
        public bool IsMachineSettings { get; set; }
        [DisplayName("Is Machine Summary")]
        public bool IsMachineSummary { get; set; }
        [DisplayName("Is label Roll")]
        public bool IslabelRoll { get; set; }
        [DisplayName("Is Command Panel")]
        public bool IsCommandPanel { get; set; }

        [DisplayName("Is Factory Setting")]
        public bool IsFactorySetting { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public int UpdatedBy { get; set; }
        //public DateTime UpdatedDate { get; set; }
    }
}