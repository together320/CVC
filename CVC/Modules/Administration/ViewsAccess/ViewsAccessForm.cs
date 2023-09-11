// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Forms.ViewsAccessForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Configuration.Entities;
using CVC.ModuleManagement.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Administration.Forms
{
    [FormScript("Administration.ViewsAccess")]
    [BasedOnRow(typeof(ViewsAccessRow))]
    public class ViewsAccessForm
    {
        [LookupEditor(typeof(ViewsRow))]
        [Required]
        public int ViewsId { get; set; }

        [LookupEditor(typeof(RoleRow))]
        [Required]
        public int RoleId { get; set; }

        public bool IsView { get; set; }

        public bool IsModify { get; set; }


        [LookupEditor(typeof(StatusRow))]
        [Required]
        public int StatusId { get; set; }

        //public int CreatedBy { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public int UpdatedBy { get; set; }

        //public DateTime UpdatedDate { get; set; }
    }
}
