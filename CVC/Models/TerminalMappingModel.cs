using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace CVC.Models
{

    public class TerminalMappingVM
    {
        public MasterTerminlsModel AddEditTermial { get; set; }
        public List<MachineModel> GetMachines { get; set; }
        public TerminalType TerminalType { get; set; }
        // public List<MachineTerminalMapping> MachineTerminalMapping { get; set; }
    }


    public class MasterTerminlsModel
    {
        public int Index { get; set; }
        public int? ID { get; set; }

        [Required(ErrorMessage = "Enter the Terminal Name")]
        [DisplayName("Treminal Name")]
        [MaxLength(50,ErrorMessage = "Treminal Name not exceed more than 50 character")]
       // [Remote("IsTerminalNameExists", "terminaltab", AdditionalFields = "TerminalName", ErrorMessage = "Terminal Name already in use")]
        public string TerminalName { get; set; }
        [Required(ErrorMessage = "Enter the Mac Address")]
        [DisplayName("Mac Address")]
      //  [MaxLength(17, ErrorMessage = "Invalid Mac Address")]


        // [RegularExpression("^([0-9A-F]{2}[:-]){5}([0-9A-F]{2})$", ErrorMessage = "InValid Mac Address")]
        public string MacAddress { get; set; }
        [DisplayName("Serial Number")]
        public string SerialNumber{ get; set; }
        [DisplayName("Model Number")]
        public string ModelNumber { get; set; }

        [Required(ErrorMessage = "Select Terminal Type")]
        [DisplayName("Terminal Type")]
        public int TerminalTypeId { get; set; }

        //  [Required(ErrorMessage = "Please Select Terminal")]
        [DisplayName("Status")]
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public string ActiveTab { get; set; }

    }

    public class MachineModel
    {
        public int ID { get; set; }
        public string MachineName { get; set; }
        public string ModuleName { get; set; }
    }

    public class TerminalType
    {
        public int TerminalTypeId { get; set; }

        public string TerminalTypeName { get; set; }

        public bool IsActive { get; set; }

        public bool IsRead { get; set; }

        public bool IsWrite { get; set; }

    }
}
