// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.PickListValueRoleAccessRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class PickListValueRoleAccessRepository
  {
    private static PickListValueRoleAccessRow.RowFields fld
    {
      get
      {
        return PickListValueRoleAccessRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PickListValueRoleAccessRow> request)
    {
      return new PickListValueRoleAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PickListValueRoleAccessRow> request)
    {
      return new PickListValueRoleAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PickListValueRoleAccessRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<PickListValueRoleAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PickListValueRoleAccessRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<PickListValueRoleAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new PickListValueRoleAccessRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<PickListValueRoleAccessRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<PickListValueRoleAccessRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<PickListValueRoleAccessRow>
    {
    }

    private class MyListHandler : ListRequestHandler<PickListValueRoleAccessRow>
    {
    }
  }
}
