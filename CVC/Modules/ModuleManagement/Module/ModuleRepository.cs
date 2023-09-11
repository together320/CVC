// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Repositories.ModuleRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using CVC.Modules.Common.Dashboard;

namespace CVC.ModuleManagement.Repositories
{
    public class ModuleRepository
    {
        private static ModuleRow.RowFields fld
        {
            get
            {
                return ModuleRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<ModuleRow> request)
        {
            return new ModuleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<ModuleRow> request)
        {
            return new ModuleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new ModuleRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<ModuleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            var ret = new ModuleRepository.MyRetrieveHandler().Process(connection, request);
            ret.Entity.SerialNumber = new DashboardCommon().GetSerialNumber(ret.Entity.MachineId);
            ret.Entity.EquipmentId = new DashboardCommon().GetEquipmentId(ret.Entity.MachineId);
            return ret;
        }

        public ListResponse<ModuleRow> List(IDbConnection connection, ListRequest request)
        {
            return new ModuleRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<ModuleRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<ModuleRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<ModuleRow>
        {
        }

        private class MyListHandler : ListRequestHandler<ModuleRow>
        {
        }
    }
}
