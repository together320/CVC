using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVC.Modules.NModuleManagement
{
    public class NModuleForm
    {
       [System.ComponentModel.DataAnnotations.Required]
        //[Remote("Common", "IsNameExist", AdditionalFields = "ModuleName",
        //        ErrorMessage = "Name already exists")]

        public string ModuleName { get; set; }
        //[LookupEditor(typeof(MachineRow))]
        [System.ComponentModel.DataAnnotations.Required]
        public int MachineId { get; set; }
        //[LookupEditor(typeof(StatusRow))]
        [System.ComponentModel.DataAnnotations.Required]
        public int StatusId { get; set; }
        public int? Sequence { get; set; }
        public int? ModuleId { get; set; }
        public string EquipmentId { get; set; }
        //[Updatable(false)]
        public string SerialNumber { get; set; }
    }
}