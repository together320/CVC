// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineRecipeParameterController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Endpoints
{
  [RoutePrefix("Services/MachineCustomization/MachineRecipeParameter")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineRecipeParameterRow))]
  [ServiceAuthorize(typeof (MachineRecipeParameterRow))]
  public class MachineRecipeParameterController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineRecipeParameterRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineRecipeParameterRow> request)
    {
      return new MachineRecipeParameterRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineRecipeParameterRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineRecipeParameterRow> request)
    {
      return new MachineRecipeParameterRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineRecipeParameterRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineRecipeParameterRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineRecipeParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineRecipeParameterRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineRecipeParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineRecipeParameterRepository().List(connection, request);
    }
  }
}
