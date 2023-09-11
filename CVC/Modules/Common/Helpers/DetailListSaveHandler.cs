// Decompiled with JetBrains decompiler
// Type: CVC.Common.DetailListSaveHandler`1
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CVC.Common
{
  public class DetailListSaveHandler<TRow> where TRow : Row, IIdRow, new()
  {
    private IEnumerable<TRow> oldList;
    private IDictionary<long, TRow> oldById;
    private IEnumerable<TRow> newList;
    private ILookup<long?, TRow> newById;
    private Action<IUnitOfWork, DeleteRequest> delete;
    private Action<IUnitOfWork, SaveRequest<TRow>> save;
    private Action<TRow> setOwnerID;

    public DetailListSaveHandler(IEnumerable<TRow> oldList, IEnumerable<TRow> newList, Action<TRow> setOwnerID, Action<IUnitOfWork, SaveRequest<TRow>> save = null, Action<IUnitOfWork, DeleteRequest> delete = null)
    {
      this.oldList = oldList ?? (IEnumerable<TRow>) new List<TRow>();
      this.oldById = (IDictionary<long, TRow>) this.oldList.ToDictionary<TRow, long>((Func<TRow, long>) (x => this.GetID(x).Value));
      this.newList = newList ?? (IEnumerable<TRow>) new List<TRow>();
      this.newById = this.newList.ToLookup<TRow, long?>((Func<TRow, long?>) (x => this.GetID(x)));
      this.setOwnerID = setOwnerID;
      this.delete = delete ?? new Action<IUnitOfWork, DeleteRequest>(this.Delete);
      this.save = save ?? new Action<IUnitOfWork, SaveRequest<TRow>>(this.Save);
    }

    public bool CheckChangesOnUpdate { get; set; }

    protected virtual void Delete(IUnitOfWork uow, DeleteRequest request)
    {
      new DeleteRequestHandler<TRow>().Process(uow, request);
    }

    protected virtual void Save(IUnitOfWork uow, SaveRequest<TRow> request)
    {
      new SaveRequestHandler<TRow>().Process(uow, request, SaveRequestType.Auto);
    }

    private long? GetID(TRow row)
    {
      return row.IdField[(Row) row];
    }

    public virtual void Process(IUnitOfWork uow)
    {
      foreach (TRow row in this.oldList.Where<TRow>((Func<TRow, bool>) (x => !this.newById.Contains(this.GetID(x)))))
      {
        DeleteRequest request = new DeleteRequest()
        {
          EntityId = (object) this.GetID(row)
        };
        this.Delete(uow, request);
      }
      foreach (TRow row1 in this.newList.Where<TRow>((Func<TRow, bool>) (x =>
      {
        long? id = this.GetID(x);
        if (id.HasValue)
          return !this.oldById.ContainsKey(id.Value);
        return true;
      })))
      {
        TRow row2 = row1.Clone<TRow>();
        row2.IdField[(Row) row2] = new long?();
        this.setOwnerID(row2);
        SaveRequest<TRow> request = new SaveRequest<TRow>()
        {
          Entity = row2
        };
        this.Save(uow, request);
      }
      foreach (TRow row1 in this.newList)
      {
        long? id = this.GetID(row1);
        TRow row2;
        if (id.HasValue && this.oldById.TryGetValue(id.Value, out row2))
        {
          if (this.CheckChangesOnUpdate)
          {
            bool flag = false;
            foreach (Field field in (Collection<Field>) row1.GetFields())
            {
              if (row1.IsAssigned(field) && (field.Flags & FieldFlags.Updatable) == FieldFlags.Updatable & (uint) field.IndexCompare((Row) row2, (Row) row1) > 0U)
              {
                flag = true;
                break;
              }
            }
            if (!flag)
              continue;
          }
          TRow row3 = row1.Clone<TRow>();
          this.setOwnerID(row3);
          SaveRequest<TRow> request = new SaveRequest<TRow>()
          {
            Entity = row3
          };
          this.Save(uow, request);
        }
      }
    }
  }
}
