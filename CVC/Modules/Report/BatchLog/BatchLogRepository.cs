// Decompiled with JetBrains decompiler
// Type: CVC.Report.Repositories.BatchLogRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
  public class BatchLogRepository
  {
    private static BatchLogRow.RowFields fld
    {
      get
      {
        return BatchLogRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchLogRow> request)
    {
      return new BatchLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchLogRow> request)
    {
      return new BatchLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchLogRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<BatchLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchLogRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<BatchLogRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchLogRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<BatchLogRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<BatchLogRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<BatchLogRow>
    {
    }

    private class MyListHandler : ListRequestHandler<BatchLogRow>
    {
    }
  }
}
