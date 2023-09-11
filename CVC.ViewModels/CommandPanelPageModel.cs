using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class CommandPanelPageModel
    {
        public List<DashBoardField> ViewFieldList { get; set; }

        public int? MachineId { get; set; }

        public int MachineParameterId { get; set; }

        public string IPAddress { get; set; }

        public ushort TcpipPort { get; set; }

        public int PollRateOverride { get; set; } = 100;

        public string ProtocolType { get; set; }

        public string MDBPath { get; set; }

        public bool isWriteTerminalType { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string CpuType { get; set; }

        public short? Rack { get; set; }

        public short? Slot { get; set; }


    }

}
