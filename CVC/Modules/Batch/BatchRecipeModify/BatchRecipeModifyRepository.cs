// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.BatchRecipeModifyRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Batch.Repositories
{
  public class BatchRecipeModifyRepository
  {
    private static BatchRecipeModifyRow.RowFields fld
    {
      get
      {
        return BatchRecipeModifyRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchRecipeModifyRow> request)
    {
      return new BatchRecipeModifyRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchRecipeModifyRow> request)
    {
      return new BatchRecipeModifyRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchRecipeModifyRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<BatchRecipeModifyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchRecipeModifyRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<BatchRecipeModifyRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchRecipeModifyRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<BatchRecipeModifyRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<BatchRecipeModifyRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<BatchRecipeModifyRow>
    {
    }

    private class MyListHandler : ListRequestHandler<BatchRecipeModifyRow>
    {
    }
  }
}
