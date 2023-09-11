// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.BatchRunDataRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Batch.Repositories
{
  public class BatchRunDataRepository
  {
    private static BatchRunDataRow.RowFields fld
    {
      get
      {
        return BatchRunDataRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchRunDataRow> request)
    {
      return new BatchRunDataRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchRunDataRow> request)
    {
      return new BatchRunDataRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchRunDataRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<BatchRunDataRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchRunDataRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<BatchRunDataRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchRunDataRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<BatchRunDataRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<BatchRunDataRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<BatchRunDataRow>
    {
    }

    private class MyListHandler : ListRequestHandler<BatchRunDataRow>
    {
    }
  }
}
