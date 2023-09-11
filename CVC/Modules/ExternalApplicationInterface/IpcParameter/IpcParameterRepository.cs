// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Repositories.IpcParameterRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.ExternalApplicationInterface.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.ExternalApplicationInterface.Repositories
{
  public class IpcParameterRepository
  {
    private static IpcParameterRow.RowFields fld
    {
      get
      {
        return IpcParameterRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<IpcParameterRow> request)
    {
            CheckIPCParameterNameExist(request.Entity.IpcParameterName, request.Entity.MachineId, request.Entity.IpcParameterId, "Create");
            return new IpcParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<IpcParameterRow> request)
        {
            CheckIPCParameterNameExist(request.Entity.IpcParameterName, request.Entity.MachineId, request.Entity.IpcParameterId, "Update");
            return new IpcParameterRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new IpcParameterRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<IpcParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new IpcParameterRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<IpcParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new IpcParameterRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<IpcParameterRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<IpcParameterRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<IpcParameterRow>
    {
    }

    private class MyListHandler : ListRequestHandler<IpcParameterRow>
    {

    }

        private void CheckIPCParameterNameExist(string ipcParameterName, int? machineId, int? ipcParameterId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check IPC Parameter Name exist
                var ipcParameter = new IPCParameter();
                if (requestType == "Create")
                {
                    ipcParameter = cvcEntities?.IPCParameters?.FirstOrDefault(a => a.IPCParameterName.ToLower() == ipcParameterName.ToLower() && a.MachineId == machineId);
                }
                else
                {
                    ipcParameter = cvcEntities?.IPCParameters?.FirstOrDefault(a => a.IPCParameterName.ToLower() == ipcParameterName.ToLower() && a.MachineId == machineId && a.IPCParameterId != ipcParameterId);
                }
                if (ipcParameter != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Ipc Parameter Name' value(s) exists!");
                }

                #endregion
            }
        }


    }
}
