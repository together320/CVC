// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineSpecificationColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.MachineSpecification")]
  [BasedOnRow(typeof (MachineSpecificationRow))]
  public class MachineSpecificationColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int MachineSpecId { get; set; }

    public string MachineMachineName { get; set; }

    [EditLink]
    public string Description { get; set; }

    public string Details { get; set; }

    public Stream MachineImage { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}
