// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Forms.ViewsForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.ModuleManagement.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.ModuleManagement.Forms
{
    [FormScript("ModuleManagement.Views")]
    [BasedOnRow(typeof(ViewsRow))]
    public class ViewsForm
    {

        [Required]
        public string ViewName { get; set; }

        [LookupEditor(typeof(ModuleRow))]
        [Required]
        public int ModuleId { get; set; }

        //public short IsAccessFieldWise { get; set; }

        [LookupEditor(typeof(StatusRow))]
        [Required]
        public int StatusId { get; set; }

        [DisplayName("Is Machine Settings")]
        public bool IsMachineSettings { get; set; }

        [DisplayName("Is Machine Summary")]
        public bool IsMachineSummary { get; set; }

        [DisplayName("Is label Roll")]
        public bool IslabelRoll { get; set; }

        [DisplayName("Is Command Panel")]
        public bool IsCommandPanel { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public int UpdatedBy { get; set; }

        //public DateTime UpdatedDate { get; set; }
    }
}
