// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.RecipeSettingsController
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
  [RoutePrefix("Services/MachineCustomization/RecipeSettings")]
  [Route("{action}")]
  [ConnectionKey(typeof (RecipeSettingsRow))]
  [ServiceAuthorize(typeof (RecipeSettingsRow))]
  public class RecipeSettingsController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (RecipeSettingsRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<RecipeSettingsRow> request)
    {
      return new RecipeSettingsRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (RecipeSettingsRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<RecipeSettingsRow> request)
    {
      return new RecipeSettingsRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (RecipeSettingsRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new RecipeSettingsRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<RecipeSettingsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new RecipeSettingsRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<RecipeSettingsRow> List(IDbConnection connection, ListRequest request)
    {
      return new RecipeSettingsRepository().List(connection, request);
    }
  }
}
