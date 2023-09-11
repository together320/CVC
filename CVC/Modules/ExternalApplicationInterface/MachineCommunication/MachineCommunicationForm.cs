// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Forms.MachineCommunicationForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using CVC.ExternalApplicationInterface.Entities;
using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.ExternalApplicationInterface.Forms
{
    [FormScript("ExternalApplicationInterface.MachineCommunication")]
    [BasedOnRow(typeof(MachineCommunicationRow))]
    public class MachineCommunicationForm
    {
        [Category("General")]
        [LabelWidth(190)]
        [LookupEditor(typeof(ProtocolRow))]
        public int ProtocolTypeId { get; set; }

        [LabelWidth(190)]
        [LookupEditor(typeof(MachineRow))]
        [ReadOnly(true)]
        public int MachineId { get; set; }

        [LabelWidth(190)]
        public string IpAddress { get; set; }

        [LabelWidth(190)]
        public int TcpipPort { get; set; }

        [LabelWidth(190)]
        public int PollRate { get; set; }

        [LabelWidth(190)]        
        public string MDBPath { get; set; }

        [LabelWidth(190)]
        [Category("Status")]
        [LookupEditor(typeof(StatusRow))]
        public int StatusId { get; set; }

        [Category("Opc End Point Information")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "20")]
        public int SecurityModeId { get; set; }

        [Category("Opc End Point Information")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "21")]
        public int SecurityPolicyId { get; set; }

        [Category("Opc Authentication Settings")]
        [LabelWidth(190)]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "22")]
        public int UserIdentityId { get; set; }


        [LabelWidth(190)]
        public string UserName { get; set; }

        [LabelWidth(190)]
        public string Password { get; set; }

        [Category("Siemens S7 Net")]
        [LabelWidth(190)]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "25")]
        public int CpuTypeId { get; set; }

        [LabelWidth(190)]
        public short Rack { get; set; }

        [LabelWidth(190)]
        public short Slot { get; set; }


    }
}
