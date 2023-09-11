// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.AlarmRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.MachineCustomization.Entities;
using CVC.Modules.Common.Dashboard;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;
using System.Web;

namespace CVC.MachineCustomization.Repositories
{
    public class AlarmRepository
    {
        private static AlarmRow.RowFields fld
        {
            get
            {
                return AlarmRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmRow> request)
        {
           CheckAlarmNameExist(request.Entity.AlarmName, request.Entity.MachineId, request.Entity.AlarmId, "Create");
            var response = new AlarmRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
          //  new DashboardCommon().AlarmSet(request.Entity);
            return response;
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmRow> request)
        {
            CheckAlarmNameExist(request.Entity.AlarmName, request.Entity.MachineId, request.Entity.AlarmId, "Update");

            var response = new AlarmRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);

            //  new DashboardCommon().AlarmSet(request.Entity);
            return response;
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new AlarmRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<AlarmRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new AlarmRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<AlarmRow> List(IDbConnection connection, ListRequest request)
        {
            return new AlarmRepository.MyListHandler().Process(connection, request);
        }

     

        private class MySaveHandler : SaveRequestHandler<AlarmRow>
        {

        }

        private class MyDeleteHandler : DeleteRequestHandler<AlarmRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<AlarmRow>
        {
        }

        private class MyListHandler : ListRequestHandler<AlarmRow>
        {
        }

        private void CheckAlarmNameExist(string alarmName,int? machineId,int? alarmId,string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Alarm Name exist
                var alarm = new Alarm();
                if (requestType == "Create")
                {
                     alarm = cvcEntities?.Alarms?.FirstOrDefault(a => a.AlarmName.ToLower() == alarmName.ToLower() && a.MachineId == machineId);
                }
                else
                {
                     alarm = cvcEntities?.Alarms?.FirstOrDefault(a => a.AlarmName.ToLower() == alarmName.ToLower() && a.MachineId == machineId && a.AlarmId!=alarmId);
                }
                if (alarm != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Alarm Name' value(s) exists!");
                }
               
                #endregion
            }
        }

    }
}
