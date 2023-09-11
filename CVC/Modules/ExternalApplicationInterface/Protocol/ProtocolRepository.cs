// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Repositories.ProtocolRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ExternalApplicationInterface.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.ExternalApplicationInterface.Repositories
{
  public class ProtocolRepository
  {
    private static ProtocolRow.RowFields fld
    {
      get
      {
        return ProtocolRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ProtocolRow> request)
    {
      return new ProtocolRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ProtocolRow> request)
    {
      return new ProtocolRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ProtocolRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ProtocolRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ProtocolRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ProtocolRow> List(IDbConnection connection, ListRequest request)
    {
      return new ProtocolRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ProtocolRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ProtocolRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ProtocolRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ProtocolRow>
    {
    }
  }
}
