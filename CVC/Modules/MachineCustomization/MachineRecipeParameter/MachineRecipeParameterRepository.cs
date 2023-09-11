// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineRecipeParameterRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineRecipeParameterRepository
  {
    private static MachineRecipeParameterRow.RowFields fld
    {
      get
      {
        return MachineRecipeParameterRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineRecipeParameterRow> request)
    {
      return new MachineRecipeParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineRecipeParameterRow> request)
    {
      return new MachineRecipeParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineRecipeParameterRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineRecipeParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineRecipeParameterRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineRecipeParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineRecipeParameterRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineRecipeParameterRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineRecipeParameterRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineRecipeParameterRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineRecipeParameterRow>
    {
    }
  }
}
