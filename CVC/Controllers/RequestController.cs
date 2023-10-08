using CVC.ModuleManagement.Columns;
using CVC.ModuleManagement.Entities;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.NModuleManagement;
using CVC.Service;
using CVC.ViewModels;

using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

using CVC.BusinessServices.DAL;
using CVC.BusinessServices.Interface;

using CVC.Modules.MachineCustomization.Message;
using CVC.Modules.MachineCustomization.TerminalType;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
// using CVC.ViewModels;
// using Serenity.Web;

namespace CVC.Controllers
{
    [RoutePrefix("Request")]
    [Route("{action=index}")]

    public class RequestController : Controller
    {
        NModuleManagementViewModel _objNModuleManagementViewModel;
        NModuleRepository _repo;
        CustomRepository repository = new CustomRepository();
        CVC.BusinessServices.Common.CommonServices commonServices = new BusinessServices.Common.CommonServices();

        public RequestController()
        {
            //_objNModuleManagementViewModel = new NModuleManagementViewModel();            
            _repo = new NModuleRepository();
        }
        // GET: NModuleManagement
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> getTableDataFromDisplayObject(int displayObjectId) //getAllData
        {
            var machineId = 0;
            if (displayObjectId > 0)
            {
                DashboardCommon dashboardCommon = new DashboardCommon();
                machineId = (int)dashboardCommon.GetMachineIdFromViewId(displayObjectId);
            }

            var TableName = _repo.getTableNamefromMachine(machineId);
            var result = await repository.GetAllData(TableName);
            if (result.resultCode == 200)
            {
                return Content(result.Data, "application/json");
            }
            else
            {
                ModelState.AddModelError("", result.message);
            }

            return Content(result.message, "application/json");
        }

        [HttpPost]
        public JsonResult GetDropdownListfromPickListId(int pickListId) //getAllData
        {
            CVC.Data.EDMX.PickList pickList = new Data.EDMX.PickList();
            pickList.PickListId = pickListId;
            List<CVC.Data.EDMX.PickListValue> pickValueList = commonServices.GetPickListValue_ByPickListId(pickList);
            List<string> values = new List<string>();

            foreach (CVC.Data.EDMX.PickListValue pickValue in pickValueList)
            {
                values.Add(pickValue.PickListValueName);
            }
            return Json(values, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetEFsFromDOId(int displayObjectId) //getAllData\
        {
            var machineId = 0;
            if (displayObjectId > 0)
            {
                DashboardCommon dashboardCommon = new DashboardCommon();
                machineId = (int)dashboardCommon.GetMachineIdFromViewId(displayObjectId);

            }
            return Json(_repo.getMachineParameterDropDown(machineId), JsonRequestBehavior.AllowGet);
        }

        // 2023.9.30 added by Denis
        [HttpPost]
        public JsonResult GetMachineRealTimeDataFromViewsId(int viewsId) //return machineId, isRealTime
        {
            DashboardCommon dashboardCommon = new DashboardCommon();
            var machineId = (int)dashboardCommon.GetMachineIdFromViewId(viewsId);
            var isRealTime = dashboardCommon.GetMachineRealTimeFromMachineId(machineId);
            var moduleId = dashboardCommon.GetModuleIdFromMachineId(machineId);
            var jRealTimeData = new { machineId = machineId, isRealTime = isRealTime, moduleId = moduleId };
            return Json(jRealTimeData, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void AddUpdateDOF(List<NViewFieldForm> parameterList)
        {
            foreach (var parameter in parameterList)
            {
                try
                {
                    if (_repo.AddUpdateViewField(parameter))
                    {
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public JsonResult getSelectedModule(int id)
        {
            NModuleForm ModuleFormInfo = new NModuleForm();
            ModuleFormInfo = _repo.getSelectedModule(id);
            //ModuleFormInfo.SerialNumber = new DashboardCommon().GetSerialNumber(ModuleFormInfo.MachineId);//ModuleFormInfo.SerialNumber ?? new DashboardCommon().GetSerialNumber(ModuleFormInfo.MachineId);
            //ModuleFormInfo.EquipmentId = new DashboardCommon().GetEquipmentId(ModuleFormInfo.MachineId);//ModuleFormInfo.EquipmentId ?? new DashboardCommon().GetEquipmentId(ModuleFormInfo.MachineId);
            return Json(ModuleFormInfo, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetDisplayObjectColors(int ViewsId)
        {
            var colors = new List<CVC.Data.EDMX.DisplayObjectColor>();
            colors = _repo.GetDOColors(ViewsId);
            var doType = _repo.GetDisplayObjectTypeIdByViewsId(ViewsId);
            JArray jArr = new JArray();
            foreach (CVC.Data.EDMX.DisplayObjectColor color in colors)
            {
                JObject jObj = new JObject {
                    {"ColorId", color.ColorId},
                    {"Color", color.Color},
                    {"RangeFrom", color.RangeFrom},
                    {"RangeTo", color.RangeTo},
                    {"ViewsId", color.ViewsId}
                };
                jArr.Add(jObj);
            }
            JObject jdata = new JObject() {
                {"DisplayObjectTypeId", doType},
                {"DisplayObjectColors", jArr}
            };
            return Json(jdata.ToString(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveDisplayObjectColor(int ViewsId, string RowData) // add a new color row and update existing row
        {
            JObject jdata = JObject.Parse(RowData.ToString());
            var addResult = _repo.AddDOColor(ViewsId, jdata);
            return Json(addResult, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteDisplayObjectColor(int ColorId)
        {
            var deleteResult = _repo.DeleteDOColor(ColorId);
            return Json(deleteResult, JsonRequestBehavior.AllowGet);
        }
    }
}