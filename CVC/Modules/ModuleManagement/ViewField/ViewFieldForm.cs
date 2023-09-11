// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Forms.ViewFieldForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.ExternalApplicationInterface.Entities;
using CVC.MachineCustomization.Entities;
using CVC.ModuleManagement.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.ModuleManagement.Forms
{
    [FormScript("ModuleManagement.ViewField")]
    [BasedOnRow(typeof(ViewFieldRow))]
    public class ViewFieldForm
    {
        [LookupEditor(typeof(ViewsRow))]
        [Required]
        public int ViewsId { get; set; }

        [Required]
        public string ViewFieldName { get; set; }

        [LookupEditor(typeof(MachineParameterRow))]
        [Required]
        public int MachineParameterId { get; set; }

        [LookupEditor(typeof(StatusRow))]
        [Required]
        public int StatusId { get; set; }

        public int Sequence { get; set; }

        //public int CreatedBy { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public int UpdatedBy { get; set; }

        //public DateTime UpdatedDate { get; set; }
    }
}
