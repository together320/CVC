// Decompiled with JetBrains decompiler
// Type: CVC.Data.ApplicationAccess
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class ApplicationAccess
  {
    public int AppAccessId { get; set; }

    public string PCName { get; set; }

    public string IPAddress { get; set; }

    public bool? IsPermissionToAccess { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
  }
}
