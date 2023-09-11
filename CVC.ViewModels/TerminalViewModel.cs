using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class TerminalViewModel
    {
        public List<MachineList> machineList { get; set; }

        public bool IsModifyMachineDetails { get; set; }

        public bool IsModifyMachineTerminalMapping { get; set; }

        public bool IsModifyMachineUserMapping { get; set; }


    }
    public class MachineList
    {
        public int Id { get; set; }

        public int MachineId { get; set; }

        public string MachineName { get; set; }

        public string Status { get; set; }

    }

    public class MachineDetails
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; } 
        public bool IsRealTime { get; set; }                // added by JSGURU manually
        public int? TableId { get; set; }                   // added by JSGURU manually
        public string TableName { get; set; }               // added by JSGURU manually
        public string OldMachineName { get; set; }
        public int? MachineSequence { get; set; }
        public int? OldMachineSequence { get; set; }
        public string AccessIPAddress { get; set; }
        public string OldAccessIPAddress { get; set; }
        public string Description { get; set; }
        public string OldDescription { get; set; }
        public string ModelNumber { get; set; }
        public string OldModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string OldSerialNumber { get; set; }
        public string PlcMake { get; set; }
        public string OldPlcMake { get; set; }
        public string Make { get; set; }
        public string OldMake { get; set; }
        public int? Year { get; set; }
        public int? OldYear { get; set; }
        public string PlcModelNumber { get; set; }
        public string OldPlcModelNumber { get; set; }
        public string PlcSerialNumber { get; set; }
        public string OldPlcSerialNumber { get; set; }
        public string PLCAddress { get; set; }
        public string OldPLCAddress { get; set; }
        public int StatusId { get; set; }
        public int? TimerForAlarm { get; set; }
        public int OldStatusId { get; set; }
        public bool IsImportAccessForMachineParameter { get; set; }
        public bool IsImportAccessForIpcParameter { get; set; }
        public bool IsImportAccessForAlarm { get; set; }
        public bool IsImportAccessForMachineCommunication { get; set; }
        public bool IsMenuAccessForMachineParameter { get; set; }
        public bool IsMenuAccessForIpcParameter { get; set; }
        public bool IsMenuAccessForAlarm { get; set; }
        public bool IsMenuAccessForMachineCommunication { get; set; }
    }

    public class TerminalTypeViewModel
    {
        public int Id { get; set; }
        public int TerminalTypeId { get; set; }
        public string TerminalTypeName { get; set; }
        public bool IsActive { get; set; }
        public bool IsRead { get; set; }
        public bool IsWrite { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public string Description { get; set; }
        public string OldTerminalTypeName { get; set; }
        public bool OldIsActive { get; set; }
        public bool OldIsRead { get; set; }
        public bool OldIsWrite { get; set; }
        public string OldDescription { get; set; }

    }

}
