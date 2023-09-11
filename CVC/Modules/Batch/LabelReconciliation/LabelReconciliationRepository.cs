// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.LabelReconciliationRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Batch.Repositories
{
  public class LabelReconciliationRepository
  {
    private static LabelReconciliationRow.RowFields fld
    {
      get
      {
        return LabelReconciliationRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelReconciliationRow> request)
    {
      return new LabelReconciliationRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelReconciliationRow> request)
    {
      return new LabelReconciliationRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LabelReconciliationRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<LabelReconciliationRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LabelReconciliationRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<LabelReconciliationRow> List(IDbConnection connection, ListRequest request)
    {
      return new LabelReconciliationRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<LabelReconciliationRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<LabelReconciliationRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<LabelReconciliationRow>
    {
    }

    private class MyListHandler : ListRequestHandler<LabelReconciliationRow>
    {
    }
  }
}
