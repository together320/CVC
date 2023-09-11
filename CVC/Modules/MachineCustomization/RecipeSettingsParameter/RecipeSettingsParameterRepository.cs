// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.RecipeSettingsParameterRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class RecipeSettingsParameterRepository
  {
    private static RecipeSettingsParameterRow.RowFields fld
    {
      get
      {
        return RecipeSettingsParameterRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<RecipeSettingsParameterRow> request)
    {
      return new RecipeSettingsParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<RecipeSettingsParameterRow> request)
    {
      return new RecipeSettingsParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new RecipeSettingsParameterRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<RecipeSettingsParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new RecipeSettingsParameterRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<RecipeSettingsParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new RecipeSettingsParameterRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<RecipeSettingsParameterRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<RecipeSettingsParameterRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<RecipeSettingsParameterRow>
    {
    }

    private class MyListHandler : ListRequestHandler<RecipeSettingsParameterRow>
    {
    }
  }
}
