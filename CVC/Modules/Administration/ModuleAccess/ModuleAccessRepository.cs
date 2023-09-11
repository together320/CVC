// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.ModuleAccessRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Administration.Repositories
{
  public class ModuleAccessRepository
  {
    private static ModuleAccessRow.RowFields fld
    {
      get
      {
        return ModuleAccessRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ModuleAccessRow> request)
    {
      return new ModuleAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ModuleAccessRow> request)
    {
      return new ModuleAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ModuleAccessRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ModuleAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ModuleAccessRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ModuleAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new ModuleAccessRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ModuleAccessRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ModuleAccessRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ModuleAccessRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ModuleAccessRow>
    {
    }
  }
}
