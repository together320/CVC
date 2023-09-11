// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Entities.BatchLogRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Batch.Entities
{
  [ConnectionKey("Default")]
  [TableName("BatchLog")]
  [DisplayName("Batch Log")]
  [InstanceName("Batch Log")]
  [TwoLevelCached(new string[] {})]
 // [ReadPermission("Administration:General")]
 // [ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class BatchLogRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly BatchLogRow.RowFields Fields = new BatchLogRow.RowFields().Init<BatchLogRow.RowFields>();

    [DisplayName("Batch Log Id")]
    [Identity]
    public long? BatchLogId
    {
      get
      {
        return BatchLogRow.Fields.BatchLogId[(Row) this];
      }
      set
      {
        BatchLogRow.Fields.BatchLogId[(Row) this] = value;
      }
    }

    [DisplayName("Machine Id")]
    public int? MachineId
    {
      get
      {
        return BatchLogRow.Fields.MachineId[(Row) this];
      }
      set
      {
        BatchLogRow.Fields.MachineId[(Row) this] = value;
      }
    }

    [DisplayName("Batch Id")]
    public int? BatchId
    {
      get
      {
        return BatchLogRow.Fields.BatchId[(Row) this];
      }
      set
      {
        BatchLogRow.Fields.BatchId[(Row) this] = value;
      }
    }

    [DisplayName("Description")]
    [Size(1000)]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string Description
    {
      get
      {
        return BatchLogRow.Fields.Description[(Row) this];
      }
      set
      {
        BatchLogRow.Fields.Description[(Row) this] = value;
      }
    }

    [DisplayName("User Id")]
    public int? UserId
    {
      get
      {
        return BatchLogRow.Fields.UserId[(Row) this];
      }
      set
      {
        BatchLogRow.Fields.UserId[(Row) this] = value;
      }
    }

    [DisplayName("Updated Date Time")]
    public DateTime? UpdatedDateTime
    {
      get
      {
        return BatchLogRow.Fields.UpdatedDateTime[(Row) this];
      }
      set
      {
        BatchLogRow.Fields.UpdatedDateTime[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) BatchLogRow.Fields.BatchLogId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return BatchLogRow.Fields.Description;
      }
    }

    public BatchLogRow()
      : base((RowFieldsBase) BatchLogRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int64Field BatchLogId;
      public Int32Field MachineId;
      public Int32Field BatchId;
      public StringField Description;
      public Int32Field UserId;
      public DateTimeField UpdatedDateTime;

      public RowFields()
        : base((string) null, "")
      {
        this.LocalTextPrefix = "Batch.BatchLog";
      }
    }
  }
}
