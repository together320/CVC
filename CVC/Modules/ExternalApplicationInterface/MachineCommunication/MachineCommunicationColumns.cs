// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Columns.MachineCommunicationColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ExternalApplicationInterface.Entities;
using Serenity.ComponentModel;

namespace CVC.ExternalApplicationInterface.Columns
{
    [ColumnsScript("ExternalApplicationInterface.MachineCommunication")]
    [BasedOnRow(typeof(MachineCommunicationRow))]
    public class MachineCommunicationColumns
    {
        public string ProtocolName { get; set; }

        [EditLink]
        [QuickFilter]
        public string MachineMachineName { get; set; }

        public string IpAddress { get; set; }

        public int TcpipPort { get; set; }

        public int PollRate { get; set; }

        public string StatusStatusName { get; set; }
    }
}
