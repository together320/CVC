using CVC.ModuleManagement.Columns;
using CVC.ModuleManagement.Entities;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.NModuleManagement;
using CVC.Service;
using CVC.ViewModels;
using CVC.Models;

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
using System.Web.UI.WebControls;
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
            ResponseModel<string> result = null;
            var TableName = _repo.getTableNamefromMachine(machineId);
            if (TableName == null || TableName == "")
                return Content("No Table is mapped to this Machine.", "application/json");
            else
                result = await repository.GetAllData(TableName);
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
        public async Task<ActionResult> getAllDataTypesFromDisplayObject(int displayObjectId) //getAllData
        {
            var machineId = 0;
            if (displayObjectId > 0)
            {
                DashboardCommon dashboardCommon = new DashboardCommon();
                machineId = (int)dashboardCommon.GetMachineIdFromViewId(displayObjectId);
            }

            ResponseModel<string> result;
            var TableName = _repo.getTableNamefromMachine(machineId);
            if (TableName == null || TableName == "")
                return Content("No Table is mapped to this Machine.", "application/json");
            else
                result = await repository.GetAllDataTypes(TableName);
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
            string tableName = null;
            if (machineId != null)
                tableName = _repo.getTableNamefromMachine(machineId);
            var jRealTimeData = new { machineId = machineId, isRealTime = isRealTime, moduleId = moduleId, tableName = tableName };
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
                    {"DOTypeId", color.DOTypeId}
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

        [HttpPost]
        public JsonResult DeleteRowFromTable(string TableName, int EntityId)
        {
            var deleteResult = _repo.DeleteRowFromTable(TableName, EntityId);
            return Json(deleteResult, JsonRequestBehavior.AllowGet);
        }

        // basic properties of displayobject e.g. LineChartDisplay's row
        [HttpPost]
        public JsonResult GetSubTypeTableAndPrimarykey(int ViewsId)
        {
            var viewData = _repo.GetDisplayObjectData(ViewsId);

            if (viewData == null || viewData.DisplayObjectTypeId == null || viewData.DisplayObjectTypeId == 0)
            {
                return Json(new { message = "DisplayObjectType is undefined." }, JsonRequestBehavior.AllowGet);
            }
            var subTable = getSubTypeTablePrimarayKeyName(viewData.DisplayObjectTypeId);
            int? primarykey = null;
            switch (subTable)
            {
                case "ListDisplay":
                    primarykey = viewData.ListDisplayId;
                    break;
                case "FormDisplay":
                    primarykey = viewData.FormDisplayId;
                    break;
                case "ButtonDisplay":
                    primarykey = viewData.ButtonDisplayId;
                    break;
                case "RealtimeParameterDisplay":
                    primarykey = viewData.RealtimeParameterDisplayId;
                    break;
                case "LineChartDisplay":
                    primarykey = viewData.LineChartDisplayId;
                    break;
                case "PieChartDisplay":
                    primarykey = viewData.PieChartDisplayId;
                    break;
                case "TreeDisplay":
                    primarykey = viewData.TreeDisplayId;
                    break;
                case "AttachmentDisplay":
                    primarykey = viewData.AttachmentDisplayId;
                    break;
                case "AlarmDisplay":
                    primarykey = viewData.AlarmDisplayId;
                    break;
                case "NotificationDisplay":
                    primarykey = viewData.NotificationDisplayId;
                    break;
                case "ContainerDisplay":
                    primarykey = viewData.ContainerDisplayId;
                    break;
            }
            return Json(new { tableName = subTable, primaryKey = primarykey }, JsonRequestBehavior.AllowGet);
        }

        private string getSubTypeTablePrimarayKeyName(int? dotype)
        {
            string tableName = "";
            switch (dotype)
            {
                case 1:
                    tableName = "ListDisplay";
                    break;
                case 2:
                    tableName = "FormDisplay";
                    break;
                case 3:
                    tableName = "ButtonDisplay";
                    break;
                case 4:
                    tableName = "RealtimeParameterDisplay";
                    break;
                case 5:
                    tableName = "LineChartDisplay";
                    break;
                case 6:
                    tableName = "PieChartDisplay";
                    break;
                case 7:
                    tableName = "TreeDisplay";
                    break;
                case 8:
                    tableName = "AttachmentDisplay";
                    break;
                case 9:
                    tableName = "AlarmDisplay";
                    break;
                case 10:
                    tableName = "NotificationDisplay";
                    break;
                case 11:
                    tableName = "ContainerDisplay";
                    break;
                default:
                    break;

            }
            return tableName;
        }

    }
}