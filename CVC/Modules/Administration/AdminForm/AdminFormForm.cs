// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Forms.AdminFormForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.ComponentModel;

namespace CVC.Administration.Forms
{
  [FormScript("Administration.AdminForm")]
  [BasedOnRow(typeof (AdminFormRow))]
  public class AdminFormForm
  {
    public string FormName { get; set; }
  }
}
