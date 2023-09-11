// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.StatusRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class StatusRepository
  {
    private static StatusRow.RowFields fld
    {
      get
      {
        return StatusRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<StatusRow> request)
    {
      return new StatusRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<StatusRow> request)
    {
      return new StatusRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new StatusRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<StatusRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new StatusRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<StatusRow> List(IDbConnection connection, ListRequest request)
    {
      return new StatusRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<StatusRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<StatusRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<StatusRow>
    {
    }

    private class MyListHandler : ListRequestHandler<StatusRow>
    {
    }
  }
}
