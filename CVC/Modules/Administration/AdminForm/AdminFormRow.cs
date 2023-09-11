// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.AdminFormRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CVC.Administration.Entities
{
  [ConnectionKey("Default")]
  [TableName("AdminForm")]
  [DisplayName("Admin Form")]
  [InstanceName("Admin Form")]
  [TwoLevelCached(new string[] {})]
  //[ReadPermission("Administration:General")]
  //[ModifyPermission("Administration:General")]
   [ReadPermission("")]
   [ModifyPermission("")]

    public sealed class AdminFormRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly AdminFormRow.RowFields Fields = new AdminFormRow.RowFields().Init<AdminFormRow.RowFields>();

    [DisplayName("Admin Form Id")]
    [Identity]
    public int? AdminFormId
    {
      get
      {
        return AdminFormRow.Fields.AdminFormId[(Row) this];
      }
      set
      {
        AdminFormRow.Fields.AdminFormId[(Row) this] = value;
      }
    }

    [DisplayName("Form Name")]
    [Size(100)]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string FormName
    {
      get
      {
        return AdminFormRow.Fields.FormName[(Row) this];
      }
      set
      {
        AdminFormRow.Fields.FormName[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) AdminFormRow.Fields.AdminFormId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return AdminFormRow.Fields.FormName;
      }
    }

    public AdminFormRow()
      : base((RowFieldsBase) AdminFormRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int32Field AdminFormId;
      public StringField FormName;

      public RowFields()
        : base((string) null, "")
      {
        this.LocalTextPrefix = "Administration.AdminForm";
      }
    }
  }
}
