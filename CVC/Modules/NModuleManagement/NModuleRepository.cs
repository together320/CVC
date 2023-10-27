using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using CVC.ModuleManagement.Columns;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using CVC.ViewModels;
using bs = CVC.BusinessServices.Common;
using System.Web.Helpers;
using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using CVC.MachineCustomization.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CVC.Modules.NModuleManagement
{
    public class NModuleRepository
    {
        CVCEntities cvcEntities;
        bs.CommonServices commonServices = new bs.CommonServices();

        public NModuleRepository()
        {
            cvcEntities = new CVCEntities();
        }
        public bool AddUpdateModule(NModuleForm ModuleFormInfo)
        {
            Module m = ModuleFormInfo.ModuleId != 0 ? cvcEntities.Modules.First(mo => mo.ModuleId == ModuleFormInfo.ModuleId) : new Module();
            m.ModuleName = ModuleFormInfo.ModuleName;
            m.MachineId = ModuleFormInfo.MachineId;
            m.StatusId = ModuleFormInfo.StatusId;
            m.Sequence = ModuleFormInfo.Sequence;
            m.EquipmentID = ModuleFormInfo.EquipmentId;
            m.SerialNumber = ModuleFormInfo.SerialNumber;
            var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
            if (ModuleFormInfo.ModuleId == 0)
            {
                m.CreatedDate = DateTime.Now;
                m.CreatedBy = loggedUserIdCache;

                cvcEntities.Modules.Add(m);
                if (ModuleFormInfo.SerialNumber != "" && ModuleFormInfo.SerialNumber != null)
                {
                    CVC.Data.EDMX.Machine mm = cvcEntities.Machines.FirstOrDefault(a => a.MachineId == m.MachineId && a.SerialNumber != m.SerialNumber);
                    if (mm != null)
                    {
                        mm.SerialNumber = m.SerialNumber;
                    }
                }
                cvcEntities.SaveChanges();
            }
            else
            {
                m.UpdatedDate = DateTime.Now;
                m.UpdatedBy = loggedUserIdCache;
                cvcEntities.SaveChanges();
            }
            return true;
        }

        public bool AddUpdateView(NViewsForm ViewsFormInfo)
        {
            View v = ViewsFormInfo.ViewsId != 0 ? cvcEntities.Views.First(vi => vi.ViewsId == ViewsFormInfo.ViewsId) : new View();
            v.ViewName = ViewsFormInfo.ViewName;
            v.ModuleId = ViewsFormInfo.ModuleId;
            //v.IsAccessFieldWise = ViewsFormInfo.is
            v.StatusId = ViewsFormInfo.StatusId;
            v.IsMachineSettings = ViewsFormInfo.IsMachineSettings;
            v.IsMachineSummary = ViewsFormInfo.IsMachineSummary;
            v.IslabelRoll = ViewsFormInfo.IslabelRoll;
            v.IsCommandPanel = ViewsFormInfo.IsCommandPanel;
            v.IsFactorySetting = ViewsFormInfo.IsFactorySetting;
            var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);

            if (ViewsFormInfo.ViewsId == 0)
            {
                v.CreatedDate = DateTime.Now;
                v.CreatedBy = loggedUserIdCache;
                cvcEntities.Views.Add(v);
                cvcEntities.SaveChanges();
            }
            else
            {
                v.UpdatedDate = DateTime.Now;
                v.UpdatedBy = loggedUserIdCache;
                cvcEntities.SaveChanges();
            }
            return true;
        }

        public bool AddUpdateViewField(NViewFieldForm ViewFieldFormInfo)
        {
            bool isUpdate = cvcEntities.ViewFields.Any(a => a.ViewFieldName == ViewFieldFormInfo.ViewFieldName
            && a.ViewsId == ViewFieldFormInfo.ViewsId && a.MachineParameterId == ViewFieldFormInfo.MachineParameterId);
            ViewField vf = isUpdate ? cvcEntities.ViewFields.First(a => a.ViewFieldName == ViewFieldFormInfo.ViewFieldName
            && a.ViewsId == ViewFieldFormInfo.ViewsId && a.MachineParameterId == ViewFieldFormInfo.MachineParameterId) : new ViewField();
            vf.ViewFieldName = ViewFieldFormInfo.ViewFieldName;
            vf.ViewsId = ViewFieldFormInfo.ViewsId;
            vf.StatusId = ViewFieldFormInfo.StatusId;
            vf.Sequence = ViewFieldFormInfo.Sequence;
            vf.MachineParameterId = ViewFieldFormInfo.MachineParameterId;
            vf.ModuleId = null;
            // vf.ModuleId = ViewFieldFormInfo.ModuleId;
            vf.IsPopUpRequired = ViewFieldFormInfo.IsPopUpRequired;
            vf.IsCommentRequired = ViewFieldFormInfo.IsCommentRequired;
            vf.IsAuthenticationRequired = ViewFieldFormInfo.IsAuthenticationRequired;
            // var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);

            if (!isUpdate)
            {
                vf.CreatedDate = DateTime.Now;
                // vf.CreatedBy = loggedUserIdCache;
                cvcEntities.ViewFields.Add(vf);
                cvcEntities.SaveChanges();
            }
            else
            {
                vf.UpdatedDate = DateTime.Now;
                // vf.UpdatedBy = loggedUserIdCache;
                cvcEntities.SaveChanges();
            }
            AddUpdateViewFieldAuthentication(vf.ViewField1, ViewFieldFormInfo.RoleIds);
            return true;
        }
        public bool deleteModule(int id)
        {
            Module m = cvcEntities.Modules.First(mo => mo.ModuleId == id);
            cvcEntities.Modules.Remove(m);
            cvcEntities.SaveChanges();
            return true;
        }
        public bool deleteView(int id)
        {
            View v = cvcEntities.Views.First(a => a.ViewsId == id);
            cvcEntities.Views.Remove(v);
            cvcEntities.SaveChanges();
            return true;
        }
        public bool deleteViewField(int id)
        {
            ViewField v = cvcEntities.ViewFields.First(a => a.ViewField1 == id);
            cvcEntities.ViewFields.Remove(v);
            cvcEntities.SaveChanges();
            return true;
        }
        public List<NModuleColumns> getModuleList()
        {
            var moduledata = (from m in cvcEntities.Modules
                                  //join mm in cvcEntities.Machines on m.MachineId equals mm.MachineId
                                  //join st in cvcEntities.Status on mm.StatusId equals st.StatusId
                                  //join mm in cvcEntities.Machines on new { m.MachineId, m.StatusId} equals new { mm.MachineId, mm.StatusId}
                                  //orderby m.CreatedDate descending
                              select new NModuleColumns
                              {
                                  ModuleId = m.ModuleId,
                                  ModuleName = m.ModuleName,
                                  MachineMachineName = m.Machine.MachineName,
                                  StatusStatusName = m.Status.StatusName,
                                  MachineId = m.MachineId ?? 0,
                                  Sequence = m.Sequence
                              }).DefaultIfEmpty();
            return moduledata.ToList();
        }
        public List<ViewsColumns> getViewsList()
        {
            var viewsdata = (from v in cvcEntities.Views
                             select new ViewsColumns { ViewsId = v.ViewsId, ModuleModuleName = v.Module.ModuleName, ViewName = v.ViewName, StatusStatusName = v.Status.StatusName }).DefaultIfEmpty();
            return viewsdata.ToList();
        }
        public List<ViewFieldColumns> getViewFieldList()
        {
            var viewfielddata = (from vf in cvcEntities.ViewFields
                                 select new ViewFieldColumns { ViewField = vf.ViewField1, ViewFieldName = vf.ViewFieldName, ViewsViewName = vf.View.ViewName, StatusStatusName = vf.Status.StatusName, MachineParameterMachineParameterName = vf.MachineParameter.ParameterName }).DefaultIfEmpty();
            return viewfielddata.ToList();
        }
        public List<MachineInfo> getMachineDropDown()
        {
            var machinedata = (from m in cvcEntities.Machines
                               select new MachineInfo { MachineId = m.MachineId, MachineName = m.MachineName }).DefaultIfEmpty();
            return machinedata.ToList();
        }
        public List<StatusInfo> getStatusDropDown()
        {
            var statusdata = (from s in cvcEntities.Status
                              select new StatusInfo { StatusId = s.StatusId, StatusName = s.StatusName }).DefaultIfEmpty();
            return statusdata.ToList();
        }
        public string getTableNamefromMachine(int id)
        {
            return cvcEntities.Machines.FirstOrDefault(a => a.MachineId == id).TableName;
        }
        public List<NMachineParameterInfo> getMachineParameterDropDown(int id) // id: machineId
        {
            var machineParameterdata = (from mp in cvcEntities.MachineParameters
                                        where mp.MachineId == id && mp.StatusId == (int)ClsConstants.StatusType.Active
                                        orderby mp.ParameterName
                                        select new NMachineParameterInfo { MachineParameterId = mp.MachineParameterId, ParameterName = mp.ParameterName, ColumnName = mp.ColumnName, PickListId = (int)(mp.PickListId == null ? -1 : mp.PickListId) }).DefaultIfEmpty();
            return machineParameterdata.ToList();
        }
        public NModuleForm getSelectedModule(int id)
        {
            var moduledata = (from m in cvcEntities.Modules
                              where m.ModuleId == id
                              select new NModuleForm
                              {
                                  ModuleId = m.ModuleId,
                                  MachineId = m.MachineId ?? 0,
                                  ModuleName = m.ModuleName,
                                  StatusId = m.StatusId ?? 0,
                                  Sequence = m.Sequence,
                                  EquipmentId = m.EquipmentID,
                                  SerialNumber = m.SerialNumber
                              }).FirstOrDefault();
            return moduledata;
        }
        public NViewsForm getSelectedView(int id)
        {
            var viewdata = (from v in cvcEntities.Views
                            where v.ViewsId == id
                            select new NViewsForm
                            {
                                ViewsId = v.ViewsId,
                                ViewName = v.ViewName,
                                ModuleId = v.ModuleId ?? 0,
                                StatusId = v.StatusId ?? 0,
                                IsMachineSettings = v.IsMachineSettings ?? false,
                                IsMachineSummary = v.IsMachineSummary ?? false,
                                IslabelRoll = v.IslabelRoll ?? false,
                                IsCommandPanel = v.IsCommandPanel ?? false,
                                IsFactorySetting = v.IsFactorySetting ?? false
                            }).FirstOrDefault();
            return viewdata;
        }
        public NViewFieldForm getSelectedViewField(int id)
        {
            var viewfielddata = (from vf in cvcEntities.ViewFields
                                 where vf.ViewField1 == id
                                 select new NViewFieldForm
                                 {
                                     ViewsId = vf.ViewsId ?? 0,
                                     ViewField = vf.ViewField1,
                                     ViewFieldName = vf.ViewFieldName,
                                     StatusId = vf.StatusId ?? 0,
                                     ModuleId = 0,
                                     MachineParameterId = vf.MachineParameterId ?? 0,
                                     Sequence = vf.Sequence,
                                     IsPopUpRequired = vf.IsPopUpRequired ?? false,
                                     IsCommentRequired = vf.IsCommentRequired ?? false,
                                     IsAuthenticationRequired = vf.IsAuthenticationRequired ?? false,
                                 }).FirstOrDefault();
            return viewfielddata;
        }
        public List<ViewsColumns> getViewsBasedOnModuleId(int id)
        {
            var viewsdata = (from v in cvcEntities.Views
                             where v.ModuleId == id
                             select new ViewsColumns
                             {
                                 ViewsId = v.ViewsId,
                                 ModuleModuleName = v.Module.ModuleName,
                                 ViewName = v.ViewName,
                                 StatusStatusName = v.Status.StatusName
                             }).DefaultIfEmpty();
            return viewsdata.ToList();
        }
        public List<ViewFieldColumns> getViewFieldListBasedOnViewId(int id)
        {
            var viewfielddata = (from vf in cvcEntities.ViewFields
                                 where vf.ViewsId == id
                                 select new ViewFieldColumns
                                 {
                                     ViewField = vf.ViewField1,
                                     ViewFieldName = vf.ViewFieldName,
                                     ViewsViewName = vf.View.ViewName,
                                     StatusStatusName = vf.Status.StatusName,
                                     MachineParameterMachineParameterName = vf.MachineParameter.ParameterName
                                 }).DefaultIfEmpty();
            return viewfielddata.ToList();
        }
        public bool checkViewInViewField(int id)
        {
            return cvcEntities.ViewFields.Any(a => a.ViewsId == id);
        }
        public bool checkModuleInView(int id)
        {
            return cvcEntities.Views.Any(z => z.ModuleId == id);
        }
        public List<SelectListItem> PopulatRoleList()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            // CommonServices objCommonServices = new CommonServices();
            using (CommonServices objCommonServices = new CommonServices())
            {
                RoleViewModel objRoleViewModel = new RoleViewModel();
                var RoleViewModel = objCommonServices.GetAllRoles(objRoleViewModel, Serenity.Authorization.UserId);

                foreach (var obj in RoleViewModel.lstRoleViewModel)
                {
                    items.Add(new SelectListItem
                    {
                        Value = obj.RoleId.ToString(),
                        Text = obj.RoleName,
                    });
                }
            }
            return items;
        }

        public int[] GetRoleViewFieldWise(int ViewFieldId)
        {
            return cvcEntities.ViewFieldAuthentications.Where(vf => vf.ViewFieldId == ViewFieldId).Select(vf => vf.RoleId).ToArray();
        }

        public bool AddUpdateViewFieldAuthentication(int ViewFieldId, string RoleIds)
        {
            var GetAllRoles = cvcEntities.ViewFieldAuthentications.Where(vf => vf.ViewFieldId == ViewFieldId).ToList();

            foreach (var item in GetAllRoles)
            {
                cvcEntities.Entry(item).State = EntityState.Deleted;
                cvcEntities.SaveChanges();
            }
            if (!string.IsNullOrEmpty(RoleIds))
            {
                var GetRoleIds = RoleIds.Split(',');

                foreach (var item in GetRoleIds)
                {
                    ViewFieldAuthentication objViewFieldAuthentication = new ViewFieldAuthentication();
                    objViewFieldAuthentication.RoleId = Convert.ToInt32(item);
                    objViewFieldAuthentication.ViewFieldId = ViewFieldId;
                    cvcEntities.ViewFieldAuthentications.Add(objViewFieldAuthentication);
                    cvcEntities.SaveChanges();
                }
            }


            return true;
        }

        public bool CheckMachineAlreadyMappedToModule(int machineId)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var modules = cVCEntities?.Modules?.FirstOrDefault(m => m.MachineId == machineId);
                if (modules != null)
                    return true;
                else
                    return false;

            }
        }

        public List<DisplayObjectColor> GetDOColors(int viewsId)
        {
            List<DisplayObjectColor> colors = new List<DisplayObjectColor>();

            using (CVCEntities cVCEntities = new CVCEntities())
            {
                // colors = cVCEntities.DisplayObjectColors.Where(a => a.ViewsId == viewsId).ToList();
            }
            return colors;
        }

        public SaveResponse AddDOColor(int viewsId, JObject RowData)
        {
            var request = new SaveRequest<DisplayObjectColorRow>();
            var repo = new DisplayObjectColorRepository();
            var data = new SaveResponse();
            IDbConnection connection = SqlConnections.NewFor<DisplayObjectColorRow>();
            using (var uow = new UnitOfWork(connection))
            {
                if (RowData.Value<string>("ColorId") == "new")
                { // add
                    request = new SaveRequest<DisplayObjectColorRow>()
                    {
                        // EntityId = 100000,
                        Entity = new DisplayObjectColorRow()
                        {
                            //ColorId = 100,
                            RangeFrom = float.Parse(RowData["RangeFrom"].ToString()),
                            RangeTo = float.Parse(RowData["RangeTo"].ToString()),
                            Color = RowData["Color"].ToString(),
                            ViewsId = int.Parse(RowData["ViewsId"].ToString())
                        }
                    };
                    data = repo.Create(uow, request);
                    uow.Commit();
                }
                else
                { // update

                    var entityId = int.Parse(RowData["ColorId"].ToString());
                    var retreviewReqeust = new RetrieveRequest()
                    {
                        EntityId = entityId
                    };
                    var updateRow = repo.Retrieve(connection, retreviewReqeust);
                    updateRow.Entity = new DisplayObjectColorRow()
                    {
                        //ColorId = 100,
                        RangeFrom = float.Parse(RowData["RangeFrom"].ToString()),
                        RangeTo = float.Parse(RowData["RangeTo"].ToString()),
                        Color = RowData["Color"].ToString(),
                        ViewsId = int.Parse(RowData["ViewsId"].ToString())
                    };
                    request.EntityId = entityId;
                    request.Entity = updateRow.Entity;
                    data = repo.Update(uow, request);
                    uow.Commit();
                }

            }
            return data;
        }

        public DeleteResponse DeleteDOColor(int colorId)
        {
            DeleteResponse data = new DeleteResponse();
            var repo = new DisplayObjectColorRepository();
            IDbConnection connection = SqlConnections.NewFor<DisplayObjectColorRow>();
            using (var uow = new UnitOfWork(connection))
            {
                var deleteRequest = new DeleteRequest();
                deleteRequest.EntityId = colorId;
                data = repo.Delete(uow, deleteRequest);
                uow.Commit();
            }
            return data;
        }

        public int? GetDisplayObjectTypeIdByViewsId(int viewsId)
        {
            var cvcEntities = new CVCEntities();
            var jdata = cvcEntities.Views.FirstOrDefault(a => a.ViewsId == viewsId);
            int? dotype = jdata.DisplayObjectTypeId;
            return dotype;
        }

        public DeleteResponse DeleteRowFromTable(string tableName, int entityId)
        {
            DeleteResponse data = new DeleteResponse();
            var repo = new DisplayObjectColorRepository();
            IDbConnection connection = SqlConnections.NewFor<DisplayObjectColorRow>();
            using (var uow = new UnitOfWork(connection))
            {
                var deleteRequest = new DeleteRequest();
                deleteRequest.EntityId = entityId;
                data = repo.Delete(uow, deleteRequest);
                uow.Commit();
            }
            return data;
        }

        public View GetDisplayObjectData(int viewsId)
        {
            var viewData = cvcEntities.Views.FirstOrDefault(v => v.ViewsId == viewsId);
           // var data = JObject.Parse(viewData.ToString());
            return viewData;
        }
    }
}