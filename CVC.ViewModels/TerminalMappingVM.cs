using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CVC.ViewModels
{
   
    public class TerminalMappingVM
    {
        public MasterTerminlsModel AddEditTermial { get; set; }
        public List<MachineModel> GetMachines { get; set; }
    }


    public class MasterTerminlsModel
    {
        public int Index { get; set; }

        public int? ID { get; set; }
       
        [Required(ErrorMessage = "Enter the Terminal Name")]
        [DisplayName("Treminal Name")]
        public string TerminalName { get; set; }
        public string OldTerminalName { get; set; }

        [Required(ErrorMessage = "Enter the Mac Address")]
        [DisplayName("Mac Address")]
        [RegularExpression("^([0-9A-F]{2}[:-]){5}([0-9A-F]{2})$",ErrorMessage ="Incorrect")]
        public string MacAddress { get; set; }
        public string OldMacAddress { get; set; }

        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }
        public string OldSerialNumber { get; set; }

        [DisplayName("Model Number")]
        public string ModelNumber { get; set; }
        public string OldModelNumber { get; set; }

        [Required(ErrorMessage = "Select Terminal Type")]
        [DisplayName("Terminal Type")]
        public int TerminalTypeId { get; set; }
        public int OldTerminalTypeId { get; set; }

        //  [Required(ErrorMessage = "Please Select Terminal")]
        [DisplayName("Active Terminal")]
        public int IsActive { get; set; }
        public int OldIsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }

        public string TerminalType { get; set; }
        public bool IsActiveTerminalType { get; set;}

    }

    public class MachineModel
    {
        public int ID { get; set; }
        public string MachineName { get; set; }
        public string ModuleName { get; set; }
    }

    public class MachineTerminalMapping
    {
        public int Id { get; set; }

        public int TerminalId { get; set; }

        public string TerminalName { get; set; }

        public string MacAddress { get; set; }

        public bool? IsRead { get; set; }

        public bool? IsWrite { get; set; }

        public int MachineId { get; set; }

        public string [] ReadArray { get; set; }

        public string [] WriteArray { get; set; }

        public bool? IsDisableWrite { get; set; }

        public string TerminalType { get; set; }

        public string [] SelectedItemList { get; set; }

        public int ModuleId { get; set; }

        public bool? IsSelected { get; set; }

    }

    public class MachineUserMapping
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Role { get; set; }

        public int MachineId { get; set; }

        public string Status { get; set; }

        public string[] SelectedItemList { get; set; }

        public int ModuleId { get; set; }

        public bool IsSelected { get; set; }

    }
}
