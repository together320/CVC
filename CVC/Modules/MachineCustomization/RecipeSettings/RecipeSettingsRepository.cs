// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.RecipeSettingsRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class RecipeSettingsRepository
  {
    private static RecipeSettingsRow.RowFields fld
    {
      get
      {
        return RecipeSettingsRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<RecipeSettingsRow> request)
    {
      return new RecipeSettingsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<RecipeSettingsRow> request)
    {
      return new RecipeSettingsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new RecipeSettingsRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<RecipeSettingsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new RecipeSettingsRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<RecipeSettingsRow> List(IDbConnection connection, ListRequest request)
    {
      return new RecipeSettingsRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<RecipeSettingsRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<RecipeSettingsRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<RecipeSettingsRow>
    {
    }

    private class MyListHandler : ListRequestHandler<RecipeSettingsRow>
    {
    }
  }
}
