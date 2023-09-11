// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.LoggingRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;

namespace CVC.Administration.Entities
{
  public abstract class LoggingRow : Row, ILoggingRow, IUpdateLogRow, IInsertLogRow
  {
    private LoggingRow.LoggingRowFields loggingFields;

    protected LoggingRow(RowFieldsBase fields)
      : base(fields)
    {
      this.loggingFields = (LoggingRow.LoggingRowFields) fields;
    }

    [NotNull]
    [Insertable(false)]
    [Updatable(false)]
    [ForeignKey("Users", "UserId")]
    [LeftJoin("jCreatedBy")]
    [TextualField("CreatedByEmployeeId")]
    public int? CreatedBy
    {
      get
      {
        return this.loggingFields.CreatedBy[(Row) this];
      }
      set
      {
        this.loggingFields.CreatedBy[(Row) this] = value;
      }
    }

    [NotNull]
    [Insertable(false)]
    [Updatable(false)]
    public DateTime? CreatedDate
    {
      get
      {
        return this.loggingFields.CreatedDate[(Row) this];
      }
      set
      {
        this.loggingFields.CreatedDate[(Row) this] = value;
      }
    }

    [Insertable(false)]
    [Updatable(false)]
    [ForeignKey("Users", "UserId")]
    [LeftJoin("jUpdatedBy")]
    [TextualField("UpdatedByEmployeeId")]
    public int? UpdatedBy
    {
      get
      {
        return this.loggingFields.UpdatedBy[(Row) this];
      }
      set
      {
        this.loggingFields.UpdatedBy[(Row) this] = value;
      }
    }

    [Insertable(false)]
    [Updatable(false)]
    public DateTime? UpdatedDate
    {
      get
      {
        return this.loggingFields.UpdatedDate[(Row) this];
      }
      set
      {
        this.loggingFields.UpdatedDate[(Row) this] = value;
      }
    }

    IIdField IInsertLogRow.InsertUserIdField
    {
      get
      {
        return (IIdField) this.loggingFields.CreatedBy;
      }
    }

    IIdField IUpdateLogRow.UpdateUserIdField
    {
      get
      {
        return (IIdField) this.loggingFields.UpdatedBy;
      }
    }

    DateTimeField IInsertLogRow.InsertDateField
    {
      get
      {
        return this.loggingFields.CreatedDate;
      }
    }

    DateTimeField IUpdateLogRow.UpdateDateField
    {
      get
      {
        return this.loggingFields.UpdatedDate;
      }
    }

    public class LoggingRowFields : RowFieldsBase
    {
      public Int32Field CreatedBy;
      public DateTimeField CreatedDate;
      public Int32Field UpdatedBy;
      public DateTimeField UpdatedDate;

      public LoggingRowFields(string tableName = null, string fieldPrefix = null)
        : base(tableName, fieldPrefix)
      {
      }
    }
  }
}
