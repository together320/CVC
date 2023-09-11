// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Forms.ModuleForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.MachineCustomization.Entities;
using CVC.ModuleManagement.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.ModuleManagement.Forms
{
    [FormScript("ModuleManagement.Module")]
    [BasedOnRow(typeof(ModuleRow))]
    public class ModuleForm
    {
        [Required]
        public string ModuleName { get; set; }

        [LookupEditor(typeof(MachineRow))]
        [Required]
        public int MachineId { get; set; }

        [LookupEditor(typeof(StatusRow))]
        [Required]
        public int StatusId { get; set; }

        public int Sequence { get; set; }

        public string EquipmentId { get; set; }

        [Updatable(false)]
        public string SerialNumber { get; set; }

        //public int CreatedBy { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public int UpdatedBy { get; set; }

        //public DateTime UpdatedDate { get; set; }
    }
}
