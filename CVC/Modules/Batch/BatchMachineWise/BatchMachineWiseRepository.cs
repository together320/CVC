// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.BatchMachineWiseRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Batch.Repositories
{
  public class BatchMachineWiseRepository
  {
    private static BatchMachineWiseRow.RowFields fld
    {
      get
      {
        return BatchMachineWiseRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchMachineWiseRow> request)
    {
      return new BatchMachineWiseRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchMachineWiseRow> request)
    {
      return new BatchMachineWiseRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchMachineWiseRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<BatchMachineWiseRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchMachineWiseRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<BatchMachineWiseRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchMachineWiseRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<BatchMachineWiseRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<BatchMachineWiseRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<BatchMachineWiseRow>
    {
    }

    private class MyListHandler : ListRequestHandler<BatchMachineWiseRow>
    {
    }
  }
}
