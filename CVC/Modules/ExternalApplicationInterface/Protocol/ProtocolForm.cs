// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Forms.ProtocolForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.ExternalApplicationInterface.Entities;
using Serenity.ComponentModel;

namespace CVC.ExternalApplicationInterface.Forms
{
  [FormScript("ExternalApplicationInterface.Protocol")]
  [BasedOnRow(typeof (ProtocolRow))]
  public class ProtocolForm
  {
    public string ProtocolName { get; set; }

    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}
