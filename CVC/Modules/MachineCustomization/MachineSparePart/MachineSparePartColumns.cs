// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineSparePartColumns
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
  [ColumnsScript("MachineCustomization.MachineSparePart")]
  [BasedOnRow(typeof (MachineSparePartRow))]
  public class MachineSparePartColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int MachineSparePartId { get; set; }

    public string MachineMachineName { get; set; }

    [EditLink]
    public string PartNumber { get; set; }

    public string PartName { get; set; }

    public string PartDescription { get; set; }

    public int NoOfUnitsRequired { get; set; }

    public Stream PartImage { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}
