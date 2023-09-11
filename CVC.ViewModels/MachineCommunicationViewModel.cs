using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class MachineCommunicationViewModel
    {
        public int MachineCommunicatonId { get; set; }

        public Nullable<int> ProtocolTypeId { get; set; }

        public string ProtocolTypeName { get; set; }

        public Nullable<int> MachineId { get; set; }

        public string IPAddress { get; set; }

        public Nullable<int> TCPIPPort { get; set; }

        public Nullable<int> PollRate { get; set; }

        public Nullable<int> StatusId { get; set; }

        public Nullable<int> CreatedBy { get; set; }

        public Nullable<System.DateTime> CreatedDate { get; set; }

        public Nullable<int> UpdatedBy { get; set; }

        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public string MDBPath { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        // public Nullable<int> SecurityModeId { get; set; }

        // public Nullable<int> SecurityPolicyId { get; set; }

        // public Nullable<int> UserIdentityId { get; set; }

        public string NodeId { get; set; }

        public string RequestType { get; set; }

        public string UserIdentity { get; set; }

        public string SecurityMode { get; set; }

        public string SecurityPolicy { get; set; }

        public string CertificateType { get; set; }

        public string CpuType { get; set; }

        public short? Rack { get; set; }

        public short? Slot { get; set; }



    }
}
