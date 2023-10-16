// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineParameterRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineParameterRepository
  {
    private static MachineParameterRow.RowFields fld
    {
      get
      {
        return MachineParameterRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineParameterRow> request)
    {
      CheckMachineParameterNameExist(request.Entity.ParameterName, request.Entity.MachineId, request.Entity.MachineParameterId, "Create");

      return new MachineParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineParameterRow> request)
    {
      CheckMachineParameterNameExist(request.Entity.ParameterName, request.Entity.MachineId, request.Entity.MachineParameterId, "Update");

      return new MachineParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      try
      {
        return new MachineParameterRepository.MyDeleteHandler().Process(uow, request);
      }
      catch (DbUpdateException ex) // Foreign key violation
      {
        throw new ValidationError("Cannot delete the record as it's being referenced in another table.");
      }
    }

    public RetrieveResponse<MachineParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineParameterRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineParameterRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineParameterRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineParameterRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineParameterRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineParameterRow>
    {
    }

    private void CheckMachineParameterNameExist(string machineParameterName, int? machineId, int? machineParameterId, string requestType)
    {
      using (CVCEntities cvcEntities = new CVCEntities())
      {
        #region Check Machine Parameter Name exist
        var machineParameter = new MachineParameter();
        if (requestType == "Create")
        {
          machineParameter = cvcEntities?.MachineParameters?.FirstOrDefault(a => a.ParameterName.ToLower() == machineParameterName.ToLower() && a.MachineId == machineId);
        }
        else
        {
          machineParameter = cvcEntities?.MachineParameters?.FirstOrDefault(a => a.ParameterName.ToLower() == machineParameterName.ToLower() && a.MachineId == machineId && a.MachineParameterId != machineParameterId);
        }
        if (machineParameter != null)
        {
          throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Parameter Name' value(s) exists!");
        }

        #endregion
      }
    }

  }
}
