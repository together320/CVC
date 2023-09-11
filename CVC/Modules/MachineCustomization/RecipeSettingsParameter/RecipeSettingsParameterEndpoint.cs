// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.RecipeSettingsParameterController
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
  [RoutePrefix("Services/MachineCustomization/RecipeSettingsParameter")]
  [Route("{action}")]
  [ConnectionKey(typeof (RecipeSettingsParameterRow))]
  [ServiceAuthorize(typeof (RecipeSettingsParameterRow))]
  public class RecipeSettingsParameterController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (RecipeSettingsParameterRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<RecipeSettingsParameterRow> request)
    {
      return new RecipeSettingsParameterRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (RecipeSettingsParameterRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<RecipeSettingsParameterRow> request)
    {
      return new RecipeSettingsParameterRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (RecipeSettingsParameterRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new RecipeSettingsParameterRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<RecipeSettingsParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new RecipeSettingsParameterRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<RecipeSettingsParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new RecipeSettingsParameterRepository().List(connection, request);
    }
  }
}
