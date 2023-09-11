// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Forms.BatchForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using CVC.Configuration.Scripts;
using CVC.PackSettings.Entities;
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Batch.Forms
{
  [FormScript("Batch.Batch")]
  [BasedOnRow(typeof (BatchRow1))]
  public class BatchForm
  {
    [Category("General")]
    [LabelWidth(190)]
    [DisplayName("Batch Number")]
     [Updatable(false)]
        public string BatchName { get; set; }

    //[Category("Specification")]
    //[LabelWidth(190)]
    //[HalfWidth]
     
    //    [LookupEditor(typeof(PackRow))]
    //    [CssClass("drpat")]
        // []

         [Visible(false)]
        public int PackId { get; set; }


    [Visible(false)]
    public int MachineLineId { get; set; }

        [Category("Specification")]
        [LabelWidth(190)]
        [DisplayName("Pack Code")]
        [HalfWidth]
     
        //[Visible(false)]
        public string BatchStatus { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public int BatchSize { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "11")]
    public int BatchFor { get; set; }

   /* [LabelWidth(190)]
    [HalfWidth]
    public int NumberOfBottles { get; set; }*/

    [LabelWidth(190)]
    [HalfWidth]
 
        public DateTime ExpiryDate { get; set; }

    [Visible(false)]
    public int StatusId { get; set; }

    [Visible(false)]
    public int CreatedBy { get; set; }

    [Visible(false)]
    [DefaultValue("now")]
    [DateTimeEditor]
    public DateTime CreatedDate { get; set; }

    [Visible(false)]
    public int UpdatedBy { get; set; }

    [Visible(false)]
    [DefaultValue("now")]
    [DateTimeEditor]
    public DateTime UpdatedDate { get; set; }

        [Visible(false)]
        public string BatchVersion { get; set; }
    }
}
