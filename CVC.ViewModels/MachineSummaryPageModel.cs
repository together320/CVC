using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class MachineSummaryPageModel
    {
        public List<DashBoardField> ViewFieldList { get; set; }

        // public string MaxIPCAddress { get; set; }

        //  public string MinIPCAddress { get; set; }

        //  public int Difference { get; set; }
        public int? MachineId { get; set; }

        public int MachineParameterId { get; set; }

        //  public List<Tuple<string, string>> IpcAddressAndValue { get; set; }

        public bool IsLabelRoll { get; set; }

        public string IPAddress { get; set; }

        public ushort TcpipPort { get; set; }

        public int PollRateOverride { get; set; } = 100;

        public string ProtocolType { get; set; }

        public string MDBPath { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string CpuType { get; set; }

        public short? Rack { get; set; }

        public short? Slot { get; set; }

    }

}
